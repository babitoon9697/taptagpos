using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace TAPTAGPOS
{
    public partial class Caisse : Form
    {
        public class SaleGridItem
        {


            public int ArticleID { get; set; }
            public string Barcode { get; set; }
            public string ArticleName { get; set; }
            public int Quantity { get; set; }
            public decimal SellPrice { get; set; }
            public decimal TotalPrice => Quantity * SellPrice;

            public static SaleGridItem FromRow(DataGridViewRow row)
            {
                return new SaleGridItem
                {
                    ArticleID = Convert.ToInt32(row.Cells["ArticleID_DGV"].Value),
                    Barcode = row.Cells["Barcode"].Value?.ToString(),
                    ArticleName = row.Cells["ArticleName"].Value?.ToString(),
                    Quantity = Convert.ToInt32(row.Cells["Quantity"].Value),
                    SellPrice = Convert.ToDecimal(row.Cells["SellPrice"].Value)
                };
            }
        }
        #region Class Members & Constructors

        private readonly string connectionString = DatabaseConnection.GetConnectionString();
        private int _ticketIdToLoadOnStart = 0;
        private int _currentSessionId = 0;
        private int defaultSaleWarehouseId = AppSettingsManager.DefaultSaleWarehouseId;
        // Article selection and pagination
        private List<Article> articles;
        private int currentPage = 0;
        private const int itemsPerPage = 23;
        // --- State Management for Filters ---
        private int _selectedWarehouseId = 0; // 0 = Global
        private int? _selectedCategoryId = null; // null = All
        private string _currentSearchTerm = "";

        // Edit Mode State
        private bool _isEditMode = false;
        private int _editingTransactionId = 0;
        private List<TicketItemRecord> _originalTicketItems = new List<TicketItemRecord>();
        private decimal _originalTotalAmount = 0;
        private decimal _originalAmountPaid = 0;
        private decimal _originalDiscount = 0;
        decimal _currentDiscountAmount = 0;
        decimal _currentDiscountAmountc = 0;
        // Payment and Customer Info
        private decimal paymentCash = 0;
        private decimal paymentCard = 0;
        private decimal paymentCheque = 0;
        private int currentCustomerId = 1; // Default to cash customer
        public string Tarifs { get; set; }
        private List<categ> allCategories = new List<categ>();

        private const string ArticleIdColName = "ArticleID_DGV";

        private int _editingTicketId = 0;
        private string paymentMethod = "N/A";

        private List<ChequeInfo> _checksReceived = new List<ChequeInfo>();
        private CustomerFinancials selectedCustomerData;

        private int categoryCurrentPage = 0;
        private const int categoriesPerPage = 13;
        private CategoryControl _selectedCategoryControl = null;


        // Printing
        private ReceiptPrintData _currentReceiptDataForPrint;
        // --- Class Members ---

        public Caisse(int ticketIdToLoad = 0)
        {
            InitializeComponent();
            _ticketIdToLoadOnStart = ticketIdToLoad;
        }
        #endregion
        #region Form Load & Initialization

        private void SetupInitialUI()
        {
            FetchAllCategories();
            DisplayCategories();
            LoadArticles(); // Now it's safe to load articles
        }
        private void Caisse_Load(object sender, EventArgs e)
        {

            this.Tarifs = AppSettingsManager.DefaultTarif;
            CheckForOpenSession();

            // This is the new, safer loading sequence
            SetupInitialUI();

            if (_ticketIdToLoadOnStart > 0)
            {
                FillDataGridForEditing(_ticketIdToLoadOnStart);
            }
            else
            {
                NewSale();
            }
        }
        private void FetchAllCategories()
        {
            allCategories.Clear();
            string query = "SELECT CategoryID, CategoryName FROM ArticleCategories WHERE IsActive = 1 ORDER BY CategoryName";
            try
            {
                using (var conn = new SqlConnection(connectionString))
                using (var cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            allCategories.Add(new categ // Use the correct 'categ' class
                            {
                                CategoryID = (int)reader["CategoryID"],
                                CategoryName = reader["CategoryName"].ToString()
                            });
                        }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Error loading categories: " + ex.Message); }
        }
        // --- NEW: Method to display the current page of categories ---
        private void DisplayCategories()
        {
            tbllayout_categories.Controls.Clear();

            // 1. Add the "All Categories" button
            var allCatControl = new CategoryControl();
            allCatControl.SetData(null, "Toutes les catégories"); // Use null ID for "All"
            allCatControl.CategoryClicked += CategoryControl_Clicked;
            allCatControl.Dock = DockStyle.Fill;
            tbllayout_categories.Controls.Add(allCatControl, 0, 0);

            // Select it by default if no other category is selected
            if (_selectedCategoryId == null)
            {
                SelectCategoryControl(allCatControl);
            }

            // 2. Add the 11 categories for the current page
            int startIndex = categoryCurrentPage * categoriesPerPage;
            var categoriesToShow = allCategories.Skip(startIndex).Take(categoriesPerPage).ToList();

            for (int i = 0; i < categoriesToShow.Count; i++)
            {
                var category = categoriesToShow[i];
                var catControl = new CategoryControl();
                catControl.SetData(category.CategoryID, category.CategoryName);
                catControl.CategoryClicked += CategoryControl_Clicked;
                tbllayout_categories.Controls.Add(catControl, i + 1, 0); // Add to next available cell

                if (_selectedCategoryId == category.CategoryID)
                {
                    SelectCategoryControl(catControl);
                }
            }

            // 3. Add pagination controls to the last cell
            // (Assuming you have added btn_previouscat and btn_nextcat to a panel in the designer)
            btn_previouscat.Enabled = (categoryCurrentPage > 0);
            btn_nextcat.Enabled = ((categoryCurrentPage + 1) * categoriesPerPage < allCategories.Count);
        }

        // --- NEW: Event handler for when any category button is clicked ---
        private void CategoryControl_Clicked(object sender, EventArgs e)
        {
            var clickedControl = sender as CategoryControl;
            if (clickedControl == null) return;

            SelectCategoryControl(clickedControl);
            _selectedCategoryId = clickedControl.CategoryID;

            // Refresh articles based on new category
            currentPage = 0;
            LoadArticles();
        }

        // --- NEW: Helper method to handle the visual selection ---
        private void SelectCategoryControl(CategoryControl controlToSelect)
        {
            // Deselect the previously selected control
            if (_selectedCategoryControl != null)
            {
                _selectedCategoryControl.IsSelected = false;
            }
            // Select the new control
            controlToSelect.IsSelected = true;
            _selectedCategoryControl = controlToSelect;
        }

        // --- NEW: Event handlers for category pagination buttons ---
        private void btn_previouscat_Click(object sender, EventArgs e)
        {
            if (categoryCurrentPage > 0)
            {
                categoryCurrentPage--;
                DisplayCategories();
            }
        }
        private void btn_nextcat_Click(object sender, EventArgs e)
        {
            if ((categoryCurrentPage + 1) * categoriesPerPage < allCategories.Count)
            {
                categoryCurrentPage++;
                DisplayCategories();
            }
        }
        // In Caisse.cs
        string lblSessionUser="";
        private void CheckForOpenSession()
        {
            // --- START OF FIX: The query now joins with the Users table to get the FullName ---
            string query = @"
        SELECT TOP 1 
            SessionID, 
            UserID  as FullName 
        FROM PosSessions 
        WHERE Status = 'Open' 
        ORDER BY StartDate DESC";
            // --- END OF FIX ---

            try
            {
                using (var conn = new SqlConnection(connectionString))
                using (var cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Now we get both the ID and the Name
                            _currentSessionId = Convert.ToInt32(reader["SessionID"]);
                            string userName = reader["FullName"].ToString();

                            // Update your new label with the session info
                            lblSessionUser = userName;
                            btn_Valider.Enabled = true;
                        }
                        else
                        {
                            // No open session was found
                            _currentSessionId = 0;
                            btn_Valider.Enabled = false;
                            MessageBox.Show("لا توجد جلسة مفتوحة. لا يمكن إجراء مبيعات. الرجاء فتح جلسة جديدة أولاً.", "جلسة مغلقة", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ في التحقق من حالة الجلسة: " + ex.Message, "خطأ فادح", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btn_Valider.Enabled = false;
            }
        }
        #endregion
        public void FillDataGridForEditing(int transactionId)
        {
            NewSale(); // Start with a clean state
            _isEditMode = true;
            _editingTransactionId = transactionId;
            _originalTicketItems.Clear();

            // This query now joins correctly and gets all necessary info
            string query = @"
                SELECT t.TicketID, t.CustomerID, t.TotalAmount, t.AmountPaid, 
                       ti.ArticleID, ti.Barcode, ti.ItemName, ti.Quantity, ti.Price, ti.TotalPrice,
                       c.CustomerName
                FROM Transactions t
                JOIN TransactionItems ti ON t.TransactionID = ti.TransactionID
                JOIN Customers c ON t.CustomerID = c.CustomerID
                WHERE t.TransactionID = @TransactionID";

            try

            {
                using (var conn = new SqlConnection(connectionString))
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@TransactionID", transactionId);
                    conn.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        bool firstRow = true;
                        while (reader.Read())
                        {
                            if (firstRow)
                            {
                                this.currentCustomerId = Convert.ToInt32(reader["CustomerID"]);
                                this.lbl_client.Text = reader["CustomerName"].ToString();
                                this._originalTotalAmount = Convert.ToDecimal(reader["TotalAmount"]);
                                this._originalAmountPaid = Convert.ToDecimal(reader["AmountPaid"]);
                                this._editingTicketId = Convert.ToInt32(reader["TicketID"]); // Store the legacy ticket ID if needed
                                LoadCustomerFinancials(this.currentCustomerId);
                                firstRow = false;
                            }
                            int articleId = Convert.ToInt32(reader["ArticleID"]);
                            int quantity = Convert.ToInt32(reader["Quantity"]);
                            _originalTicketItems.Add(new TicketItemRecord { ArticleID = articleId, OriginalQuantity = quantity });

                            int rowIndex = DatagridArticles.Rows.Add();
                            DataGridViewRow newRow = DatagridArticles.Rows[rowIndex];
                            newRow.Tag = articleId;
                            newRow.Cells["ArticleID_DGV"].Value = articleId;
                            newRow.Cells["Barcode"].Value = reader["Barcode"];
                            newRow.Cells["ArticleName"].Value = reader["ItemName"];
                            newRow.Cells["Quantity"].Value = quantity;
                            newRow.Cells["SellPrice"].Value = reader["Price"];
                            newRow.Cells["Tot"].Value = reader["TotalPrice"];
                        }
                    }
                }
                UpdateAllTotals();
            }
            catch (Exception ex) { /* ... Error handling ... */ }
        }

        private decimal GetStockForArticleInWarehouse(int articleId, int warehouseId)
        {
            decimal stockQuantity = 0;
            string query = "SELECT Quantity FROM ArticleStock WHERE ArticleID = @ArticleID AND WarehouseID = @WarehouseID";

            try
            {
                using (var conn = new SqlConnection(DatabaseConnection.GetConnectionString()))
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ArticleID", articleId);
                    cmd.Parameters.AddWithValue("@WarehouseID", warehouseId);
                    conn.Open();
                    object result = cmd.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        stockQuantity = Convert.ToDecimal(result);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ في التحقق من المخزون: " + ex.Message);
            }
            return stockQuantity;
        }
        private void bunifuButton215_Click(object sender, EventArgs e)
        {
            if (DatagridArticles.Rows.Count > 0)
            {
                MessageBox.Show("المرجو إنهاء الفاتورة أولا");
            }
            else
                this.Close();
        }
        string Tar;

        string jsonBarcodes = "[]";
        private bool usePrintPreview = true;
        public List<Article> GetArticles(int offset, int limit, int warehouseId)
        {
            List<Article> articles = new List<Article>();
            string query;

            // --- We now have two different queries based on the warehouse selection ---
            if (warehouseId == 0) // A warehouse ID of 0 means "All Warehouses"
            {
                // Query to get the GLOBAL stock quantity
                query = @"
            SELECT Id, Article, ArticleLongName,BuyPrice, Barcodes, DetailsPrice, SemigrosPrice, GrosPrice, SpecialPrice, QuantityStock, ArticleColor 
            FROM Articles WHERE IsActive = 1 ORDER BY Id
            OFFSET @offset ROWS FETCH NEXT @limit ROWS ONLY";
            }
            else
            {
                // Query to get the stock quantity from a SPECIFIC warehouse by joining with ArticleStock
                query = @"
            SELECT 
                a.Id, a.Article, a.ArticleLongName,a.BuyPrice, a.Barcodes, a.DetailsPrice, 
                a.SemigrosPrice, a.GrosPrice, a.SpecialPrice, a.ArticleColor,
                ISNULL(s.Quantity, 0) AS QuantityStock 
            FROM Articles a
            LEFT JOIN ArticleStock s ON a.Id = s.ArticleID AND s.WarehouseID = @WarehouseID
            WHERE a.IsActive = 1
            ORDER BY a.Id
            OFFSET @offset ROWS FETCH NEXT @limit ROWS ONLY";
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@offset", offset);
                cmd.Parameters.AddWithValue("@limit", limit);
                if (warehouseId > 0) // Add the WarehouseID parameter only if needed
                {
                    cmd.Parameters.AddWithValue("@WarehouseID", warehouseId);
                }

                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        // This part remains the same, but 'QuantityStock' now holds the correct value
                        Article article = new Article
                        {
                            Id = reader.GetInt32(reader.GetOrdinal("Id")),
                            ArticleCode = reader["Article"]?.ToString(),
                            ArticleLongName = reader["ArticleLongName"]?.ToString(),
                            SellPrice = GetPriceByTarif(reader, this.Tarifs), // Use helper to get correct price
                            QuantityStock = Convert.ToDecimal(reader["QuantityStock"]),
                            ArticleColor = reader["ArticleColor"]?.ToString(),
                            BuyPrice = Convert.ToDecimal(reader["BuyPrice"])
                        };

                        string jsonBarcodes = reader["Barcodes"]?.ToString() ?? "[]";
                        try
                        {
                            article.Barcode = (JsonConvert.DeserializeObject<List<string>>(jsonBarcodes) ?? new List<string>()).FirstOrDefault() ?? "";
                        }
                        catch { article.Barcode = ""; }

                        articles.Add(article);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erreur lors du chargement des articles : {ex.Message}");
                }
            }
            return articles;
        }
        // In Caisse.cs

        // This method now passes the selected category ID to GetArticles
        private void LoadArticles()
        {
            int offset = currentPage * itemsPerPage;
            int? categoryIdToUse = _selectedCategoryId;
            if (!string.IsNullOrWhiteSpace(_currentSearchTerm))
            {
                categoryIdToUse = null;
            }
            articles = GetArticles(offset, itemsPerPage, _selectedWarehouseId, categoryIdToUse, _currentSearchTerm);
            DisplayArticles();
        }


        // This is your working GetArticles method, now with the Category filter added
        public List<Article> GetArticles(int offset, int limit, int warehouseId, int? categoryId, string searchTerm)
        {
            var articleList = new List<Article>();
            var queryParams = new Dictionary<string, object>();

            // This string builder will hold our final query
            var queryBuilder = new StringBuilder();

            // --- Base Query ---
            // This part correctly selects either Global Stock or stock from a specific Warehouse
            if (warehouseId == 0)
            {
                queryBuilder.Append(@"SELECT Id, Article,BuyPrice, ArticleLongName, Barcodes, DetailsPrice, SemigrosPrice, 
                                     GrosPrice, SpecialPrice, QuantityStock, ArticleColor, CategoryID 
                              FROM Articles a WHERE a.IsActive = 1");
            }
            else
            {
                queryBuilder.Append(@"SELECT a.Id, a.Article,a.BuyPrice, a.ArticleLongName, a.Barcodes, a.DetailsPrice, a.SemigrosPrice, 
                                     a.GrosPrice, a.SpecialPrice, a.ArticleColor, a.CategoryID,
                                     ISNULL(s.Quantity, 0) AS QuantityStock 
                              FROM Articles a 
                              LEFT JOIN ArticleStock s ON a.Id = s.ArticleID AND s.WarehouseID = @WarehouseID 
                              WHERE a.IsActive = 1");
                queryParams.Add("@WarehouseID", warehouseId);
            }

            // --- Dynamic Filters ---

            // 1. Add Category Filter (if one is selected)
            if (categoryId.HasValue && categoryId > 0)
            {
                queryBuilder.Append(" AND a.CategoryID = @CategoryID");
                queryParams.Add("@CategoryID", categoryId.Value);
            }

            // 2. Add Search Filter (if there is search text)
            if (!string.IsNullOrWhiteSpace(searchTerm))
            {
                queryBuilder.Append(" AND (a.ArticleLongName LIKE @SearchTerm OR a.Article LIKE @SearchTerm OR JSON_VALUE(a.Barcodes, '$[0]') LIKE @SearchTerm)");
                queryParams.Add("@SearchTerm", $"%{searchTerm}%");
            }

            // 3. Add Pagination
            queryBuilder.Append(" ORDER BY a.Article OFFSET @Offset ROWS FETCH NEXT @Limit ROWS ONLY");
            queryParams.Add("@Offset", offset);
            queryParams.Add("@Limit", limit);

            // --- Execute Query ---
            using (var conn = new SqlConnection(connectionString))
            using (var cmd = new SqlCommand(queryBuilder.ToString(), conn))
            {
                foreach (var p in queryParams)
                {
                    cmd.Parameters.AddWithValue(p.Key, p.Value);
                }
                try
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var article = new Article
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                ArticleCode = reader["Article"]?.ToString(),
                                ArticleLongName = reader["ArticleLongName"]?.ToString(),
                                SellPrice = GetPriceByTarif(reader, this.Tarifs),
                                QuantityStock = Convert.ToDecimal(reader["QuantityStock"]),
                                ArticleColor = reader["ArticleColor"]?.ToString(),
                                BuyPrice = Convert.ToDecimal(reader["BuyPrice"])
                            };
                            string jsonBarcodes = reader["Barcodes"]?.ToString() ?? "[]";
                            try
                            {
                                article.Barcode = (JsonConvert.DeserializeObject<List<string>>(jsonBarcodes) ?? new List<string>()).FirstOrDefault() ?? "";
                            }
                            catch { article.Barcode = ""; }

                            articleList.Add(article);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erreur lors du chargement des articles : {ex.Message}");
                }
            }
            return articleList;
        }
        private void DisplayArticles()
        {
            // --- START OF FIX ---
            // IMPORTANT: Replace 'tableLayoutPanel7' with the real name of your panel from the designer!
            var articlePanel = this.tableLayoutPanel7;

            if (articlePanel == null)
            {
                MessageBox.Show("Error: The layout panel for articles was not found in the code. Please check the control name.", "Developer Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            articlePanel.Controls.Clear();

            // This part of the code assumes it's a TableLayoutPanel.
            // If it is, you might need to clear rows if you add them dynamically.
            // If it's a FlowLayoutPanel, this is all you need.

            if (articles == null) return;

            foreach (var article in articles)
            {
                var articleControl = new ArticleControl();
                articleControl.SetArticleData(article);
                articleControl.ArticleClicked += ArticleControl_ArticleClicked;
                articleControl.Dock = DockStyle.Fill;

                try
                {
                    if (!string.IsNullOrEmpty(article.ArticleColor))
                    {
                        articleControl.BackColor = ColorTranslator.FromHtml(article.ArticleColor);
                    }
                }
                catch { /* Ignore invalid color codes */ }

                articlePanel.Controls.Add(articleControl);
            }
            // --- END OF FIX ---
        }
        // In Caisse.cs

        // --- This is the new, more robust version of the method ---
        private decimal GetPriceByTarif(SqlDataReader reader, string tarif)
        {
            switch (tarif?.ToLower())
            {
                case "gros":
                    return Convert.ToDecimal(reader["GrosPrice"] ?? 0);
                case "semigros":
                case "semi gros":
                    return Convert.ToDecimal(reader["SemigrosPrice"] ?? 0);
                case "special":
                    return Convert.ToDecimal(reader["SpecialPrice"] ?? 0);
                default:
                    return Convert.ToDecimal(reader["DetailsPrice"] ?? 0);
            }
        }

        private void LoadCustomerFinancials(int custId)
        {
            // إذا كان الزبون هو "Passager" (ID=1) أو أي زبون افتراضي آخر، لا تقم بأي شيء
            if (custId <= 1)
            {
                ResetCustomerFinancials();
                return;
            }

            selectedCustomerData = new CustomerFinancials { CustomerID = custId };
            string query = "SELECT CreditAllowed, AmountDue, DebtCeiling, CheckCeiling FROM Customers WHERE CustomerID = @CustomerID";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@CustomerID", custId);
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            selectedCustomerData.IsCreditAllowed = reader["CreditAllowed"] != DBNull.Value && Convert.ToBoolean(reader["CreditAllowed"]);
                            selectedCustomerData.CurrentDebt = reader["AmountDue"] != DBNull.Value ? Convert.ToDecimal(reader["AmountDue"]) : 0;
                            selectedCustomerData.DebtCeiling = reader["DebtCeiling"] != DBNull.Value ? Convert.ToDecimal(reader["DebtCeiling"]) : (decimal?)null;
                            selectedCustomerData.CheckCeiling = reader["CheckCeiling"] != DBNull.Value ? Convert.ToDecimal(reader["CheckCeiling"]) : (decimal?)null;

                            // (اختياري) عرض البيانات في label للمستخدم
                            // lblCustomerInfo.Text = $"الدين: {selectedCustomerData.CurrentDebt:C2} | سقف الدين: {selectedCustomerData.DebtCeiling:C2}";
                            // lblCustomerInfo.Visible = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ في جلب بيانات الزبون المالية: " + ex.Message);
                ResetCustomerFinancials();
            }
        }

        // --- أضف هذه الدالة أيضاً ---
        private void ResetCustomerFinancials()
        {
            selectedCustomerData = null;
            // (اختياري) إخفاء label المعلومات
            // lblCustomerInfo.Visible = false;
        }
        private void BtnNext_Click(object sender, EventArgs e)
        {
            currentPage++;
            LoadArticles();
        }

        private void BtnPrevious_Click(object sender, EventArgs e)
        {
            if (currentPage > 0)
            {
                currentPage--;
                LoadArticles();
            }
        }

        int countart = 0;
        private void ArticleControl_ArticleClicked(object sender, Article article)
        {

            AddArticleToCart(article, 1);

        }
        private void DeleteArticleButton_Click(object sender, EventArgs e)
        {
            btn_delete_item_Click(sender, e);

        }

        private void bunifuButton29_Click(object sender, EventArgs e)
        {
           DialogResult r = MessageBox.Show("هل تريد إلغاء الفاتورة ؟", "إلغاء الفاتورة", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                NewSale();
                UpdateAllTotals();
                ResetCustomerFinancials();
                lbl_client.Text = "Client"; // أعد اسم الزبون للافتراضي
                this.currentCustomerId = 1; // أعد رقم الزبون للافتراضي
            }

        }

        private void btn_Quantity_Click(object sender, EventArgs e)
        {  // Check if a row is selected in the DataGridView
            if (DatagridArticles.SelectedRows.Count == 0)
            {
                MessageBox.Show("المرجو تحديد السلعة أولا", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Get the selected row
            DataGridViewRow selectedRow = DatagridArticles.SelectedRows[0];

            // Open the QuantityForm
            using (QuantityForm quantityForm = new QuantityForm())
            {
                if (quantityForm.ShowDialog() == DialogResult.OK)
                {
                    // Update the Quantity column in the selected row
                    selectedRow.Cells["Quantity"].Value = quantityForm.Quantity;
                    // Calculate the total for the affected row
                    decimal price = Convert.ToDecimal(selectedRow.Cells["SellPrice"].Value);
                    decimal quantity = Convert.ToDecimal(selectedRow.Cells["Quantity"].Value);
                    selectedRow.Cells["Tot"].Value = price * quantity;
                    // Update the Total column
                    UpdateAllTotals();
                    txt_barcode.Focus();
                }
            }
        }

        private void DatagridArticles_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            // Commit the cell value immediately after editing
            if (DatagridArticles.IsCurrentCellDirty)
            {
                DatagridArticles.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }


        private void bunifuIconButton2_Click(object sender, EventArgs e)
        {
            if (DatagridArticles.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = DatagridArticles.SelectedRows[0];
                int currentQuantity = Convert.ToInt32(selectedRow.Cells["Quantity"].Value);
                selectedRow.Cells["Quantity"].Value = currentQuantity + 1;

                decimal price = Convert.ToDecimal(selectedRow.Cells["SellPrice"].Value);
                int quantity = Convert.ToInt32(selectedRow.Cells["Quantity"].Value);
                selectedRow.Cells["Tot"].Value = price * quantity;

                UpdateAllTotals(); // <-- استدعاء الدالة المركزية
            }
        }

        private void bunifuIconButton1_Click(object sender, EventArgs e)
        {
            if (DatagridArticles.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = DatagridArticles.SelectedRows[0];
                int currentQuantity = Convert.ToInt32(selectedRow.Cells["Quantity"].Value);
                if (currentQuantity > 1)
                {
                    selectedRow.Cells["Quantity"].Value = currentQuantity - 1;
                    decimal price = Convert.ToDecimal(selectedRow.Cells["SellPrice"].Value);
                    selectedRow.Cells["Tot"].Value = price * (currentQuantity - 1);

                }
                else
                {
                    // إذا كانت الكمية 1، قم بحذف السطر
                    DatagridArticles.Rows.Remove(selectedRow);
                }
                UpdateAllTotals(); // <-- استدعاء الدالة المركزية
            }
        }

        private void bunifuButton24_Click(object sender, EventArgs e)
        {
            if (DatagridArticles.SelectedRows.Count == 0)
            {
                MessageBox.Show("المرجو تحديد السلعة أولا", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Get the selected row
            DataGridViewRow selectedRow = DatagridArticles.SelectedRows[0];
            decimal price = Convert.ToDecimal(selectedRow.Cells["SellPrice"].Value);
            // Open the QuantityForm
            using (QuantityForm quantityForm = new QuantityForm(price))
            {
                if (quantityForm.ShowDialog() == DialogResult.OK)
                {
                    // Update the Quantity column in the selected row
                    selectedRow.Cells["SellPrice"].Value = quantityForm.Price.ToString("N2");

                    decimal prices = Convert.ToDecimal(selectedRow.Cells["SellPrice"].Value);
                    decimal quantity = Convert.ToDecimal(selectedRow.Cells["Quantity"].Value);
                    selectedRow.Cells["Tot"].Value = prices * quantity;
                    UpdateAllTotals();
                    txt_barcode.Focus();
                }
            }
        }

        private void bunifuButton210_Click(object sender, EventArgs e)
        {

        }
        decimal total = 0;
        public void FillDataGridArticlesTickets(int ticketId)
        {
            string connectionstring = DatabaseConnection.GetConnectionString();
            string query = "SELECT  Barcode, ArticleName, Quantity, SellPrice, Total " +
                           "FROM TransactionItemID WHERE id_ticket = @TicketId";

            using (SqlConnection conn = new SqlConnection(connectionstring))
            {
                try
                {
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);
                    dataAdapter.SelectCommand.Parameters.AddWithValue("@TicketId", ticketId);

                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    // Clear existing rows in the DataGridView
                    DatagridArticles.Rows.Clear();

                    // Check if data was retrieved
                    if (dataTable.Rows.Count > 0)
                    {
                        foreach (DataRow row in dataTable.Rows)
                        {
                            // Add rows to the DataGridView
                            DatagridArticles.Rows.Add(
                                row["Barcode"],         // Barcode
                                row["ArticleName"],     // Article Name
                                row["Quantity"],        // Quantity
                                row["SellPrice"],       // Sell Price
                                row["Tot"]            // Total
                            );
                            total += decimal.Parse(row["Tot"].ToString());
                        }
                        lbl_total.Text = total.ToString();
                        lbl_reste.Text = total.ToString();
                        lbl_avance.Text = "0";
                    }
                    else
                    {
                        MessageBox.Show("No data found for the selected ticket.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error retrieving data: {ex.Message}");
                }
            }
        }
        int countrows = 0;
        public int CountData()
        {
            return DatagridArticles.RowCount;
        }

        private (decimal TotalAmount, decimal AmountPaid) GetTransactionDetails(int ticketId)
        {
            string query = "SELECT TotalAmount, AmountPaid FROM Transactions WHERE TicketID = @TicketID";
            using (var conn = new SqlConnection(connectionString))
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@TicketID", ticketId);
                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return (Convert.ToDecimal(reader["TotalAmount"]), Convert.ToDecimal(reader["AmountPaid"]));
                    }
                }
            }
            return (0, 0);
        }
        private void bunifuButton211_Click(object sender, EventArgs e)
        {
            using (ListEnAttente attForm = new ListEnAttente(this))
            {
                attForm.ShowDialog(this);
            }

        }

        public void LoadPendingTicket(int ticketId)
        {
            NewSale(); // Clear the current sale first
            string query = "SELECT * FROM Attente WHERE id_ticket = @TicketID";

            try
            {
                using (var conn = new SqlConnection(connectionString))
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@TicketID", ticketId);
                    conn.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Find the full article details to add it correctly
                            Article article = GetArticleByBarcode(reader["Barcode"].ToString());
                            if (article != null)
                            {
                                int quantity = Convert.ToInt32(reader["Quantity"]);
                                // Manually set price from the saved ticket
                                article.SellPrice = Convert.ToDecimal(reader["SellPrice"]);
                                AddArticleToCart(article, quantity);
                            }
                            lbl_client.Text = reader["ClientName"].ToString();
                        }
                    }
                }

                // After loading, delete the pending ticket so it can't be loaded again
                using (var conn = new SqlConnection(connectionString))
                using (var cmd = new SqlCommand("DELETE FROM Attente WHERE id_ticket = @TicketID; DELETE FROM Ticket WHERE id_ticket = @TicketID;", conn))
                {
                    cmd.Parameters.AddWithValue("@TicketID", ticketId);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load pending ticket: " + ex.Message);
            }
        }
        private void Att_FillDataGridArticles(object sender, DataTable e)
        {
            // Assuming the 'e' DataTable contains the data for datagridArticles.
            DatagridArticles.DataSource = e;
        }

        private void btn_freequantity_Click(object sender, EventArgs e)
        {
            // Ensure a row is selected
            if (DatagridArticles.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = DatagridArticles.SelectedRows[0];

                // Extract the Barcode and ArticleName
                string id = selectedRow.Cells["ArticleID_DGV"].Value?.ToString();
                string barcode = selectedRow.Cells["Barcode"].Value?.ToString();
                string articleName = selectedRow.Cells["ArticleName"].Value?.ToString();

                if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(articleName))
                {
                    MessageBox.Show("Invalid data in the selected row.");
                    return;
                }

                // Check if there's already a FreeQuantity row for this Barcode
                bool rowUpdated = false;

                foreach (DataGridViewRow row in DatagridArticles.Rows)
                {
                    // Skip empty or new rows
                    if (row.IsNewRow) continue;

                    if (row.Cells["ArticleID_DGV"].Value?.ToString() == id &&
                        row.Cells["SellPrice"].Value?.ToString() == "0")
                    {
                        // Update the Quantity and Total
                        decimal currentQuantity = Convert.ToDecimal(row.Cells["Quantity"].Value);
                        row.Cells["Quantity"].Value = currentQuantity + 1;

                        rowUpdated = true;
                        txt_barcode.Focus();
                        break;
                    }
                }

                if (!rowUpdated)
                {
                    // Add a new FreeQuantity row
                    DatagridArticles.Rows.Add(
                        id,
                        barcode,        // Barcode
                        articleName,    // ArticleName
                        1,              // Quantity
                        0,              // SellPrice
                        0               // Total
                    );
                    txt_barcode.Focus();
                }
            }
            else
            {
                MessageBox.Show("Please select a row first.");
            }
        }
        // خاصية لتخزين قيمة الخصم على مستوى الفورم
        public decimal Remise { get; set; }

        // In Caisse.cs

        // 1. Replace your btn_Remise_Click method with this improved version.

        private void btn_Remise_Click(object sender, EventArgs e)
        {
            using (var discountForm = new DiscountForm())
            {
                if (discountForm.ShowDialog(this) != DialogResult.OK) return;

                decimal discountValue = discountForm.DiscountValue;
                bool isPercentage = discountForm.IsPercentage;

                var result = MessageBox.Show("Appliquer sur toute la facture (OUI) ou sur l'article sélectionné (NON) ?", "Appliquer la Remise", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (result == DialogResult.Cancel) return;

                // Always clear previous discounts before applying a new one
                ClearAllRowDiscounts();

                if (result == DialogResult.Yes) // Apply to ALL
                {
                    if (isPercentage)
                    {
                        foreach (DataGridViewRow row in DatagridArticles.Rows)
                        {
                            ApplyDiscountToRow(row, discountValue, true);
                        }
                    }
                    else
                    {
                        // Apply a fixed discount to the grand total
                        _currentDiscountAmount = discountValue;
                    }
                }
                else // Apply to SELECTED rows only
                {
                    if (DatagridArticles.SelectedRows.Count == 0)
                    {
                        MessageBox.Show("Veuillez sélectionner au moins un article.", "Aucune Sélection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    foreach (DataGridViewRow row in DatagridArticles.SelectedRows)
                    {
                        ApplyDiscountToRow(row, discountValue, isPercentage);
                    }
                }
                UpdateAllTotals();
            }
        }
        private void ApplyDiscountToAll(decimal discountValue, bool isPercentage)
        {
            ClearAllRowDiscounts(); // Start by clearing any existing discounts

            if (isPercentage)
            {
                // Apply the percentage to every row
                decimal percentage = discountValue / 100m;
                foreach (DataGridViewRow row in DatagridArticles.Rows)
                {
                    ApplyPercentageDiscountToRow(row, percentage, discountValue);
                }
            }
            else
            {
                // Set the global discount amount for the whole ticket
                _currentDiscountAmount = discountValue;
            }
        }

        private void ApplyDiscountToSelected(decimal discountValue, bool isPercentage)
        {
            _currentDiscountAmount = 0; // Clear global discount if applying to specific items

            foreach (DataGridViewRow row in DatagridArticles.SelectedRows)
            {
                if (isPercentage)
                {
                    decimal percentage = discountValue / 100m;
                    ApplyPercentageDiscountToRow(row, percentage, discountValue);
                }
                else
                {
                    // Apply the fixed amount to this single row
                    ApplyFixedDiscountToRow(row, discountValue);
                }
            }
        }

        // In Caisse.cs

        private void ApplyPercentageDiscountToRow(DataGridViewRow row, decimal percentage, decimal displayPercent)
        {
            if (row == null || row.IsNewRow || row.Tag == null) return;

            try
            {
                // --- START OF FIX ---
                // Step 1: Get the ArticleID from the Tag
                int articleId = Convert.ToInt32(row.Tag);

                // Step 2: Fetch the article's original base price from the database
                decimal originalPrice = GetOriginalSellPrice(articleId);
                if (originalPrice == 0) return; // Could not get price, so can't apply discount

                // Step 3: Calculate the new price after applying the percentage discount
                decimal newPrice = originalPrice * (1 - percentage);
                // --- END OF FIX ---

                // Update the grid cells with the new discounted price and total
                row.Cells["SellPrice"].Value = newPrice;
                row.Cells["colRemise"].Value = $"{displayPercent:F2} %";

                // Recalculate the row's total with the new price
                UpdateRowTotal(row);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error applying discount: " + ex.Message);
            }
        }
        private void ApplyFixedDiscountToRow(DataGridViewRow row, decimal amount)
        {
            if (row == null || row.IsNewRow) return;
            // A fixed discount on a single row is not standard.
            // A better approach would be to change the SellPrice directly.
            // For now, we will add the discount to the remise column and adjust the row total.
            row.Cells["colRemise"].Value = amount.ToString("N2");
            UpdateRowTotal(row); // Recalculate based on the new logic in UpdateAllTotals
        }
        private void ClearAllRowDiscounts()
        {
            foreach (DataGridViewRow row in DatagridArticles.Rows)
            {
                if (row.IsNewRow || row.Tag as Article == null) continue;
                var article = (Article)row.Tag;

                row.Cells["SellPrice"].Value = article.SellPrice;
                row.Cells["colRemise"].Value = string.Empty;
                UpdateRowTotal(row);
            }
            _currentDiscountAmount = 0;
        }

        private void UpdateRowTotal(DataGridViewRow row)
        {
            if (row == null || row.IsNewRow) return;

            try
            {
                // Safely get the quantity and price from the row's cells
                decimal quantity = Convert.ToDecimal(row.Cells["Quantity"].Value ?? 0);
                decimal sellPrice = Convert.ToDecimal(row.Cells["SellPrice"].Value ?? 0);

                // Calculate the new total and update the "Tot" cell
                row.Cells["Tot"].Value = quantity * sellPrice;
            }
            catch (Exception ex)
            {
                // This catch block is important to prevent crashes if a cell has invalid data
                MessageBox.Show("Error calculating row total: " + ex.Message);
                row.Cells["Tot"].Value = 0m;
            }
        }

        // 3. Add this new helper method to clear the discount column.
        private decimal GetOriginalSellPrice(int articleId)
        {
            // We assume 'DetailsPrice' is the default original price. Change if needed.
            string query = "SELECT DetailsPrice FROM Articles WHERE Id = @ArticleID";
            try
            {
                using (var conn = new SqlConnection(connectionString))
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ArticleID", articleId);
                    conn.Open();
                    object result = cmd.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        return Convert.ToDecimal(result);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not fetch original price for article " + articleId + ". Error: " + ex.Message);
            }
            return 0m; // Return 0 if price can't be found
        }
        private decimal GetOriginalBuyPrice(int articleId)
        {
            // We assume 'DetailsPrice' is the default original price. Change if needed.
            string query = "SELECT BuyPrice FROM Articles WHERE Id = @ArticleID";
            try
            {
                using (var conn = new SqlConnection(connectionString))
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ArticleID", articleId);
                    conn.Open();
                    object result = cmd.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        return Convert.ToDecimal(result);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not fetch original price for article " + articleId + ". Error: " + ex.Message);
            }
            return 0m; // Return 0 if price can't be found
        }
        // <<-- أضف هذه الدالة الجديدة: لتطبيق الخصم على صف واحد -->>
        private void UpdateRowWithDiscount(DataGridViewRow row)
        {
            try
            {
                // --- تصحيح: استخدام اسم العمود الصحيح "Total" ---
                if (row.Cells["SellPrice"].Value != null && row.Cells["tot"].Value != null)
                {
                    decimal originalPrice = Convert.ToDecimal(row.Cells["SellPrice"].Value);
                    decimal quantity = Convert.ToDecimal(row.Cells["quantity"].Value);
                    decimal originalprice = Convert.ToDecimal(row.Cells["tot"].Value);

                    // حساب السعر الجديد بعد الخصم
                    // مثال: لو السعر 100 والخصم 0.15 (15%)، السعر الجديد = 100 * (1 - 0.15) = 85
                    decimal discountedPrice = originalPrice * (1 - this.Remise);

                    // حساب الإجمالي الجديد للصف
                    decimal newTotal = discountedPrice * quantity;
                    _currentDiscountAmount += originalPrice - newTotal;
                    // تحديث قيم الخلايا في الجدول
                    // يمكنك اختيار تحديث السعر أو فقط الإجمالي بناءً على متطلبات عملك
                    // هنا سنقوم بتحديث الإجمالي فقط للحفاظ على السعر الأصلي
                    // row.Cells["SellPrice"].Value = discountedPrice.ToString("F2"); // (اختياري)
                    row.Cells["tot"].Value = newTotal.ToString("F2");
                }
            }
            catch (Exception ex)
            {
                // التعامل مع أي أخطاء قد تحدث أثناء تحويل البيانات
                MessageBox.Show("حدث خطأ أثناء تحديث الصف: " + ex.Message);
            }
        }

        // <<-- أضف هذه الدالة الجديدة: لإعادة حساب المجموع الكلي للفاتورة -->>
        private void UpdateRow(DataGridViewRow row)
        {
            // Get the current SellPrice and Total
            decimal sellPrice = Convert.ToDecimal(row.Cells["SellPrice"].Value);
            decimal total = Convert.ToDecimal(row.Cells["Tot"].Value);

            // Calculate the new SellPrice and Total after applying the quantity discount
            decimal newSellPrice = sellPrice - (sellPrice * this.Remise);
            decimal newTotal = total - (total * this.Remise);

            // Update the cells with the new values
            row.Cells["SellPrice"].Value = newSellPrice;
            row.Cells["Tot"].Value = newTotal;
        }

        // In Caisse.cs

        // Remove or refactor your old UpdateLabels() method if RecalculateTotal() now covers its functionality.
        // For example, DatagridArticles_CellValueChanged should call RecalculateTotal():
        private void DatagridArticles_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            // إذا تم تغيير الكمية أو السعر يدوياً
            if (e.ColumnIndex == DatagridArticles.Columns["Quantity"].Index ||
                e.ColumnIndex == DatagridArticles.Columns["SellPrice"].Index)
            {
                UpdateAllTotals();
            }
        }
        private void btn_delete_item_Click(object sender, EventArgs e)
        {
            if (DatagridArticles.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in DatagridArticles.SelectedRows)
                {
                    if (!row.IsNewRow)
                    {
                        DatagridArticles.Rows.Remove(row);
                    }
                }
                UpdateAllTotals();
            }
            else
            {
                MessageBox.Show("الرجاء تحديد منتج لحذفه.");
            }
        }
        // Renamed your UpdateTotal to UpdateTotalForRow to avoid confusion with RecalculateTotal (grand total)
        // In Caisse.cs
        string searcharticle;
        private void bunifuButton216_Click(object sender, EventArgs e)
        {
            Keyboard keyboardForm = new Keyboard();

            // Show the keyboard form as a modal dialog
            if (keyboardForm.ShowDialog() == DialogResult.OK)  // If the user presses OK (or any custom logic you define)
            {
                // Get the entered text from the KeyboardForm
                string enteredText = keyboardForm.EnteredText;

                // Use the entered text (e.g., store it in a variable, assign it to a TextBox, etc.)
                txtSearch.Text = enteredText;  // Assign the entered text to a TextBox on the parent form
                searcharticle = enteredText;  // Assign the entered text to a TextBox on the parent form
                searchbyarticle();
            }
        }
        public List<Article> SearchArticles(int offset, int limit)
        {
            string connectionString = DatabaseConnection.GetConnectionString();
            List<Article> articles = new List<Article>();

            string query = @"
    SELECT * 
    FROM [TaptagCaisse].[dbo].[Articles] 
    WHERE 
        JSON_VALUE(Barcodes, '$[0]') LIKE @searcharticle + '%' OR
        JSON_VALUE(Barcodes, '$[1]') LIKE @searcharticle + '%' OR
        JSON_VALUE(Barcodes, '$[2]') LIKE @searcharticle + '%' OR
        JSON_VALUE(Barcodes, '$[3]') LIKE @searcharticle + '%' OR
        JSON_VALUE(Barcodes, '$[4]') LIKE @searcharticle + '%' OR
        JSON_VALUE(Barcodes, '$[5]') LIKE @searcharticle + '%' OR
        JSON_VALUE(Barcodes, '$[6]') LIKE @searcharticle + '%' OR
        JSON_VALUE(Barcodes, '$[7]') LIKE @searcharticle + '%'
    ORDER BY [Id] 
    OFFSET @offset ROWS FETCH NEXT @limit ROWS ONLY";


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@offset", offset);
                command.Parameters.AddWithValue("@limit", limit);
                command.Parameters.AddWithValue("@searcharticle", searcharticle);

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Article article = new Article
                        {
                            Id = reader.GetInt32(reader.GetOrdinal("Id")),
                            ArticleCode = reader["Article"] as string, // Handle nullable strings with 'as string'
                            ArticleLongName = reader["ArticleLongName"] as string,
                            Barcode = reader["Barcode1"] as string,
                            // Continue for other nullable string fields

                            BuyPrice = reader.IsDBNull(reader.GetOrdinal("BuyPrice")) ? 0 : reader.GetDecimal(reader.GetOrdinal("BuyPrice")),
                            SellPrice = reader.IsDBNull(reader.GetOrdinal("TTCBuyPrice")) ? 0 : reader.GetDecimal(reader.GetOrdinal("DetailsPrice")),
                            // Handle other nullable numeric fields similarly
                            QuantityStock = reader.IsDBNull(reader.GetOrdinal("QuantityStock")) ? 0 : reader.GetDecimal(reader.GetOrdinal("QuantityStock")),
                            // Repeat for all nullable columns
                        };

                        articles.Add(article);
                    }
                }
            }

            return articles;
        }
        private void searchbyarticle()
        {
            int offset = currentPage * itemsPerPage;
            articles = SearchArticles(offset, itemsPerPage);
            DisplayArticles();
        }

        private void Btn_TarifsChange_Click(object sender, EventArgs e)
        {
            // Create an instance of the child form (Changement_Tarifs)
            Changement_Tarifs tarifsss = new Changement_Tarifs();

            // Link the parent form's UpdateTarif method to the child form's OnTarifSelected property
            tarifsss.OnTarifSelected = UpdateTarif;

            // Show the child form as a dialog
            tarifsss.ShowDialog();
        }
        public void UpdateTarif(string newTarif)
        {
            Tarifs = newTarif;
            LoadArticles();
            txt_barcode.Focus();
        }

        // In Caisse.cs
        private string GetPaymentMethodString()
        {
            var methods = new List<string>();
            if (paymentCash > 0) methods.Add("Espèces");
            if (paymentCard > 0) methods.Add("Carte");
            if (paymentCheque > 0) methods.Add("Chèque");

            if (methods.Any())
            {
                return string.Join(" + ", methods);
            }

            // If no specific payment was made, but the bill is covered, it was likely credit.
            if (GetTotalAmountFromGrid() <= 0)
            {
                return "N/A";
            }

            return "À Crédit"; // Default if there is a balance but no payment was entered
        }
        // --- FIX: All payment methods now update the paymentMethod string ---
        private void btn_cash_Click(object sender, EventArgs e)
        {
            using (var cashForm = new CashPaiement(decimal.Parse(lbl_reste.Text)))
            {
                if (cashForm.ShowDialog() == DialogResult.OK)
                {
                    paymentCash += cashForm.paid;
                    UpdatePaymentMethodString();
                    UpdateAllTotals();
                }
            }
        }
        string paymentMethode = "None";
        string paymentStatus;
        int newTicketId = 0;
        string selectedSellerName = "";

        private void btn_Valider_Click(object sender, EventArgs e)
        {

            // --- 1. VALIDATION ---
            if (_currentSessionId == 0)
            {
                MessageBox.Show("لا يمكن الحفظ لأنه لا توجد جلسة مفتوحة.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (DatagridArticles.Rows.Count == 0 || DatagridArticles.Rows[0].IsNewRow)
            {
                MessageBox.Show("لا توجد أي عناصر في الفاتورة.", "فاتورة فارغة", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
 
            using (var userPicker = new UserPickForm())
            {
                if (userPicker.ShowDialog(this) != DialogResult.OK)
                {
                    MessageBox.Show("يجب اختيار البائع لإتمام العملية.", "لم يتم اختيار البائع", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Stop if no seller was selected
                }
                selectedSellerName = userPicker.SelectedUserName;
            }
            // 2. CALCULATE FINAL TOTALS AND DISCOUNT *BEFORE* SAVING
            foreach (DataGridViewRow row in DatagridArticles.Rows)
            {
                if (row.IsNewRow || row.Tag as Article == null) continue;
                var article = (Article)row.Tag;
                subTotal += article.SellPrice * Convert.ToDecimal(row.Cells["Quantity"].Value);
            }

            decimal finalTotal = GetTotalAmountFromGrid() - _currentDiscountAmount;
            decimal totalDiscountToSave = subTotal - finalTotal; // This is the correct total discount to save.
            decimal totalAmount = GetTotalAmountFromGrid();
            decimal newPayments = paymentCash + paymentCard + paymentCheque;
            decimal finalAmountPaid = _isEditMode ? _originalAmountPaid + newPayments : newPayments;
            if(finalTotal-finalAmountPaid>0 && loanAmount == 0)
            {
                MessageBox.Show("المرجو تحديد طريقة الدفع");
                return;
            }
            loanAmount = finalTotal - finalAmountPaid;
            // Recalculate payment info based on the correct final total
            decimal amountPaid = paymentCash + paymentCard + paymentCheque;
            if (loanAmount < 0) loanAmount = 0;
            string paymentStatus = (loanAmount <= 0.01m) ? "Paid" : "Partially Paid";
            // --- END OF FIX ---




            if (!decimal.TryParse(lbl_total.Text, NumberStyles.Any, CultureInfo.CurrentCulture, out totalAmount))
            {
                MessageBox.Show("إجمالي المبلغ غير صالح.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (loanAmount < 0) loanAmount = 0;

            if (Math.Abs(totalAmount - (finalAmountPaid + loanAmount)) > 0.01m)
            {
                MessageBox.Show("خطأ في الحسابات، مجموع المدفوعات لا يساوي المبلغ الإجمالي.", "خطأ في التوازن", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (loanAmount > 0)
            {
                if (selectedCustomerData == null || !selectedCustomerData.IsCreditAllowed)
                {
                    MessageBox.Show("هذا الزبون غير مسموح له بالدين.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                decimal futureDebt = _isEditMode ? (selectedCustomerData.CurrentDebt - _originalTotalAmount) + totalAmount : selectedCustomerData.CurrentDebt + loanAmount;
                if (selectedCustomerData.DebtCeiling.HasValue && futureDebt > selectedCustomerData.DebtCeiling.Value)
                {
                    MessageBox.Show("فشلت العملية. سقف الدين للزبون لا يسمح بهذا المبلغ.", "تجاوز سقف الدين", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
            }
            // --- 2. SAVE LOGIC ---
            bool isSaveSuccessful = false;
            int ticketIdForPrint = 0;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                if (_isEditMode)
                {
                    ExecuteUpdateSale(conn, transaction, selectedSellerName, totalDiscountToSave);
                    ticketIdForPrint = this._editingTicketId; // Use the existing ticket ID for printing
                    isSaveSuccessful = true;
                }
                else
                {
                    // Pass the correct discount amount to the save method
                    ticketIdForPrint = ExecuteNewSale(conn, transaction, selectedSellerName, totalDiscountToSave);
                }

                transaction.Commit();
                isSaveSuccessful = true; // Mark as successful ONLY after commit


            }

            // --- 3. POST-SAVE ACTIONS (PRINTING & CLEARING) ---
            // This code only runs if the database transaction was successful.
            if (isSaveSuccessful)
            {
                MessageBox.Show("تمت العملية بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (!_isEditMode && MessageBox.Show("Voulez-vous imprimer le ticket ?", "Imprimer", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        // Prepare data for the receipt
                        _currentReceiptDataForPrint = new ReceiptPrintData
                        {
                            CompanyName = AppSettingsManager.CompanyName,
                            CompanyAddress = AppSettingsManager.CompanyAddress,
                            CompanyPhone = AppSettingsManager.CompanyPhone,
                            VatNumber = AppSettingsManager.VatNumber,
                            FooterMessage1 = AppSettingsManager.FooterReceipt,
                            TicketId = ticketIdForPrint,
                            PrintDateTime = DateTime.Now,
                            ClientName = lbl_client.Text,
                            PaymentMethod = GetPaymentMethodString(),
                            SubTotal = subTotal, // The original total before discounts
                            TotalDiscount = totalDiscountToSave, // The total discount amount

                            TotalAmount = totalAmount,
                            AmountPaid = amountPaid,
                            RemainingDebt = loanAmount,
                            Items = DatagridArticles.Rows.Cast<DataGridViewRow>()
                                .Where(r => !r.IsNewRow)
                                .Select(r => new ReceiptItem
                                {
                                    Name = r.Cells["ArticleName"].Value?.ToString() ?? "",
                                    Quantity = Convert.ToDecimal(r.Cells["Quantity"].Value ?? 0),
                                    Price = Convert.ToDecimal(r.Cells["SellPrice"].Value ?? 0),
                                }).ToList()
                        };
                        InitiatePrint();
                    }
                    catch (Exception printEx)
                    {
                        // If printing fails, it will NOT crash the application anymore
                        MessageBox.Show($"La vente a été enregistrée, mais l'impression a échoué: {printEx.Message}", "Erreur d'impression", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

                // Reset the form for the next sale
                NewSale();
                LoadArticles();
            }

        }
        private int ExecuteNewSale(SqlConnection conn, SqlTransaction transaction, string sellerName, decimal totalDiscount)
        {
            // --- Calculations ---
            DateTime currentDateTime = DateTime.Now;
            decimal totalAmount = GetTotalAmountFromGrid();
            decimal amountPaid = paymentCash + paymentCard + paymentCheque;
            decimal loanAmount = totalAmount - amountPaid;
            if (loanAmount < 0) loanAmount = 0;
            string paymentStatus = (loanAmount <= 0.01m) ? "Paid" : "Partially Paid";

            // --- 1. Insert into legacy Ticket Table ---
            string insertTicketQuery = "INSERT INTO [dbo].[Ticket] (ticket_date, ClientName, total_amount, created_by, validated) OUTPUT INSERTED.id_ticket VALUES (@Date, @Client, @Total, @User, 1)";
            int ticketId;
            using (SqlCommand ticketCmd = new SqlCommand(insertTicketQuery, conn, transaction))
            {
                ticketCmd.Parameters.AddWithValue("@Date", currentDateTime);
                ticketCmd.Parameters.AddWithValue("@Client", lbl_client.Text);
                ticketCmd.Parameters.AddWithValue("@Total", totalAmount);
                ticketCmd.Parameters.AddWithValue("@User", sellerName); // Use the selected seller
                ticketId = (int)ticketCmd.ExecuteScalar();
            }

            // --- 2. Insert into modern Transactions Table ---
            string insertTransactionQuery = @"
        INSERT INTO [dbo].[Transactions] (CustomerID, TransactionDate, TotalAmount, AmountPaid, PaymentStatus, DueDate, TicketID, Cash, CreditCard, Loan, Cheque, DiscountAmount, SessionID, CreatedBy) 
        OUTPUT INSERTED.TransactionID 
        VALUES (@CID, @Date, @Total, @Paid, @Status, @DueDate, @TicketID, @Cash, @Card, @Loan, @Cheque, @Discount, @SID, @User)";

            int transactionId;
            using (SqlCommand transactionCmd = new SqlCommand(insertTransactionQuery, conn, transaction))
            {
                transactionCmd.Parameters.AddWithValue("@CID", this.currentCustomerId);
                transactionCmd.Parameters.AddWithValue("@Date", currentDateTime);
                transactionCmd.Parameters.AddWithValue("@Total", totalAmount);
                transactionCmd.Parameters.AddWithValue("@Paid", amountPaid);
                transactionCmd.Parameters.AddWithValue("@Status", paymentStatus);
                transactionCmd.Parameters.AddWithValue("@DueDate", loanAmount > 0 ? (object)currentDateTime.AddDays(30) : DBNull.Value);
                transactionCmd.Parameters.AddWithValue("@TicketID", ticketId);
                transactionCmd.Parameters.AddWithValue("@Cash", this.paymentCash);
                transactionCmd.Parameters.AddWithValue("@Card", this.paymentCard);
                transactionCmd.Parameters.AddWithValue("@Loan", loanAmount);
                transactionCmd.Parameters.AddWithValue("@Cheque", this.paymentCheque);
                transactionCmd.Parameters.AddWithValue("@Discount", totalDiscount);
                transactionCmd.Parameters.AddWithValue("@SID", this._currentSessionId);
                transactionCmd.Parameters.AddWithValue("@User", sellerName); // Use the selected seller
                transactionId = Convert.ToInt32(transactionCmd.ExecuteScalar());
            }

            // --- 3. Loop through grid to insert items and update stock ---
            foreach (DataGridViewRow row in DatagridArticles.Rows)
            {
                if (row.IsNewRow) continue;
                var item = SaleGridItem.FromRow(row); // Use the correct helper class

                // Insert into TransactionItems using the correct parameters
                SaveTransactionItem(conn, transaction, transactionId, ticketId, item);

                // Update Stock and History (subtracting from stock)
                UpdateStockAndHistory(conn, transaction, item.ArticleID, -item.Quantity, defaultSaleWarehouseId, "Sale", transactionId.ToString());
            }
            // --- START OF FIX: Log the payment details to CustomerPayments ---
            if (amountPaid > 0)
            {
                if (paymentCash > 0)
                {
                    LogCustomerPayment(conn, transaction, transactionId, "Cash", paymentCash);
                }
                if (paymentCard > 0)
                {
                    LogCustomerPayment(conn, transaction, transactionId, "Card", paymentCard);
                }
                if (paymentCheque > 0)
                {
                    foreach (var cheque in _checksReceived)
                    {
                        LogCustomerCheque(conn, transaction, transactionId, cheque);
                    }
                }
            }
            // --- END OF FIX ---
            // --- 4. Update Customer Debt if any ---
            if (loanAmount > 0)
            {
                UpdateCustomerDebt(conn, transaction, this.currentCustomerId, loanAmount);
            }

            // --- 5. Return the new ticketId so it can be used for printing ---
            return ticketId;
        }
        #region Helper Methods (Corrected)
        private void LogCustomerPayment(SqlConnection conn, SqlTransaction transaction, int transactionId, string method, decimal amount)
        {
            string query = "INSERT INTO CustomerPayments (CustomerID, TransactionID, PaymentDate, Amount, PaymentMethod, Notes) VALUES (@CID, @TID, @Date, @Amount, @Method, 'Paiement de vente')";
            using (var cmd = new SqlCommand(query, conn, transaction))
            {
                cmd.Parameters.AddWithValue("@CID", this.currentCustomerId);
                cmd.Parameters.AddWithValue("@TID", transactionId);
                cmd.Parameters.AddWithValue("@Date", DateTime.Now);
                cmd.Parameters.AddWithValue("@Amount", amount);
                cmd.Parameters.AddWithValue("@Method", method);
                cmd.ExecuteNonQuery();
            }
        }

        // In Caisse.cs
        private void LogCustomerCheque(SqlConnection conn, SqlTransaction transaction, int transactionId, ChequeInfo cheque)
        {
            // This query will now work because the columns exist
            string query = @"INSERT INTO ClientChecks 
                        (TransactionID, CustomerID, CheckNumber, BankName, Amount, DueDate,ReceivedDate, PayerName, Status) 
                     VALUES 
                        (@TID, @CID, @Num, @Bank, @Amount, @DueDate,@ReceivedDate, @Payer, 'Received')";

            using (var cmd = new SqlCommand(query, conn, transaction))
            {
                cmd.Parameters.AddWithValue("@TID", transactionId);
                cmd.Parameters.AddWithValue("@CID", this.currentCustomerId);
                cmd.Parameters.AddWithValue("@Num", cheque.CheckNumber);
                cmd.Parameters.AddWithValue("@Bank", cheque.BankName);
                cmd.Parameters.AddWithValue("@Amount", cheque.Amount);
                cmd.Parameters.AddWithValue("@DueDate", cheque.DueDate);
                cmd.Parameters.AddWithValue("@ReceivedDate", DateTime.Today);
                cmd.Parameters.AddWithValue("@Payer", cheque.PayerName);
                cmd.ExecuteNonQuery();
            }
        }
        private void ExecuteUpdateSale(SqlConnection conn, SqlTransaction transaction, string sellerName, decimal totalDiscount)
        {
            // --- 1. Calculate financial changes ---
            decimal newGrandTotal = GetTotalAmountFromGrid();
            decimal newPaymentsThisSession = paymentCash + paymentCard + paymentCheque;
            decimal newFinalAmountPaid = _originalAmountPaid + newPaymentsThisSession;
            decimal newLoanAmount = newGrandTotal - newFinalAmountPaid;
            if (newLoanAmount < 0) newLoanAmount = 0;

            decimal financialChangeOnDebt = (newGrandTotal - _originalTotalAmount) - newPaymentsThisSession;

            // --- 2. Calculate stock changes ---
            var stockChanges = CalculateStockChanges();

            // --- 3. Apply all updates to the database ---

            // Update stock for each item that has a quantity change
            foreach (var change in stockChanges.Where(c => c.Value != 0))
            {
                UpdateStockAndHistory(conn, transaction, Convert.ToInt32(change.Key), -change.Value, defaultSaleWarehouseId, "Sale-Edit", $"TrscID: {_editingTransactionId}");
            }

            // Update the main transaction record
            string newStatus = (newLoanAmount <= 0.01m) ? "Paid" : "Partially Paid";
            string updateTransQuery = @"UPDATE Transactions SET 
                                    TotalAmount = @Total, 
                                    AmountPaid = @Paid, 
                                    PaymentStatus = @Status, 
                                    DiscountAmount = @Discount,
                                    CreatedBy = @User
                                WHERE TransactionID = @TID";


            using (var cmd = new SqlCommand(updateTransQuery, conn, transaction))
            {
                cmd.Parameters.AddWithValue("@Total", newGrandTotal);
                cmd.Parameters.AddWithValue("@Paid", newFinalAmountPaid);
                cmd.Parameters.AddWithValue("@Status", newStatus);
                cmd.Parameters.AddWithValue("@Discount", totalDiscount);
                cmd.Parameters.AddWithValue("@User", sellerName);
                cmd.Parameters.AddWithValue("@TID", _editingTransactionId);
                cmd.ExecuteNonQuery();
            }

            // Update the customer's total debt with the calculated difference
            if (Math.Abs(financialChangeOnDebt) > 0.01m)
            {
                UpdateCustomerDebt(conn, transaction, this.currentCustomerId, financialChangeOnDebt);
            }

            // ====================================================================
            // --- START: NEW/MISSING PAYMENT LOGGING LOGIC (FOR EDITS) ---
            // ====================================================================
            // If a new payment was made during this edit session, log it permanently.
            if (newPaymentsThisSession > 0)
            {
                // Log new cash payments
                if (paymentCash > 0)
                {
                    string cashQuery = "INSERT INTO CustomerPayments (CustomerID, TransactionID, PaymentDate, Amount, PaymentMethod, Notes) VALUES (@CID, @TID, @Date, @Amount, 'Cash', 'Paiement partiel lors de la modification')";
                    using (var paymentCmd = new SqlCommand(cashQuery, conn, transaction))
                    {
                        paymentCmd.Parameters.AddWithValue("@CID", this.currentCustomerId);
                        paymentCmd.Parameters.AddWithValue("@TID", _editingTransactionId);
                        paymentCmd.Parameters.AddWithValue("@Date", DateTime.Now);
                        paymentCmd.Parameters.AddWithValue("@Amount", paymentCash);
                        paymentCmd.ExecuteNonQuery();
                    }
                }
                // Log new card payments
                if (paymentCard > 0)
                {
                    string cardQuery = "INSERT INTO CustomerPayments (CustomerID, TransactionID, PaymentDate, Amount, PaymentMethod, Notes) VALUES (@CID, @TID, @Date, @Amount, 'Card', 'Paiement partiel lors de la modification')";
                    using (var paymentCmd = new SqlCommand(cardQuery, conn, transaction))
                    {
                        paymentCmd.Parameters.AddWithValue("@CID", this.currentCustomerId);
                        paymentCmd.Parameters.AddWithValue("@TID", _editingTransactionId);
                        paymentCmd.Parameters.AddWithValue("@Date", DateTime.Now);
                        paymentCmd.Parameters.AddWithValue("@Amount", paymentCard);
                        paymentCmd.ExecuteNonQuery();
                    }
                }
                // Log new cheques received
                if (paymentCheque > 0 && _checksReceived.Any())
                {
                    string chequeQuery = "INSERT INTO ClientCheques (TransactionID, CustomerID, CheckNumber, BankName, Amount, DueDate, PayerName, Status) VALUES (@TID, @CID, @Num, @Bank, @Amount, @DueDate, @Payer, 'Received')";
                    foreach (var cheque in _checksReceived)
                    {
                        using (var chequeCmd = new SqlCommand(chequeQuery, conn, transaction))
                        {
                            chequeCmd.Parameters.AddWithValue("@TID", _editingTransactionId);
                            chequeCmd.Parameters.AddWithValue("@CID", this.currentCustomerId);
                            chequeCmd.Parameters.AddWithValue("@Num", cheque.CheckNumber);
                            chequeCmd.Parameters.AddWithValue("@Bank", cheque.BankName);
                            chequeCmd.Parameters.AddWithValue("@Amount", cheque.Amount);
                            chequeCmd.Parameters.AddWithValue("@DueDate", cheque.DueDate);
                            chequeCmd.Parameters.AddWithValue("@Payer", cheque.PayerName);
                            chequeCmd.ExecuteNonQuery();
                        }
                    }
                }
            }


            using (var cmd = new SqlCommand("DELETE FROM TransactionItems WHERE TransactionID = @TID", conn, transaction))
            {
                cmd.Parameters.AddWithValue("@TID", _editingTransactionId);
                cmd.ExecuteNonQuery();
            }

            foreach (DataGridViewRow row in DatagridArticles.Rows)
            {
                if (row.IsNewRow) continue;

                var item = SaleGridItem.FromRow(row);

                // Save the updated item back to the database
                // NOTE: Ensure your SaveTransactionItem method is updated to accept SaleGridItem
                SaveTransactionItem(conn, transaction, _editingTransactionId, _editingTicketId, item);
            }
        }
        private void UpdateStockAndHistory(SqlConnection conn, SqlTransaction transaction, int articleId, decimal quantityChange, int warehouseId, string movementType, string referenceId)
        {
            // Do nothing if there is no change in quantity
            if (quantityChange == 0) return;

            // --- Step 1: Update the specific warehouse stock (UPSERT Logic) ---
            // The MERGE statement is powerful: it updates a row if it exists, or inserts it if it doesn't.
            // We use OUTPUT to get the new stock quantity in a single step.
            string upsertStockQuery = @"
        MERGE ArticleStock AS target
        USING (SELECT @ArticleID AS ArticleID, @WarehouseID AS WarehouseID) AS source
        ON (target.ArticleID = source.ArticleID AND target.WarehouseID = source.WarehouseID)
        WHEN MATCHED THEN 
            UPDATE SET Quantity = target.Quantity + @QuantityChange
        WHEN NOT MATCHED BY TARGET THEN 
            INSERT (ArticleID, WarehouseID, Quantity) VALUES (@ArticleID, @WarehouseID, @QuantityChange)
        OUTPUT INSERTED.Quantity;";

            decimal newWarehouseQuantity;
            using (SqlCommand stockCmd = new SqlCommand(upsertStockQuery, conn, transaction))
            {
                stockCmd.Parameters.AddWithValue("@ArticleID", articleId);
                stockCmd.Parameters.AddWithValue("@WarehouseID", warehouseId);
                stockCmd.Parameters.AddWithValue("@QuantityChange", quantityChange);

                object result = stockCmd.ExecuteScalar();
                newWarehouseQuantity = (result == DBNull.Value || result == null) ? 0 : Convert.ToDecimal(result);
            }

            // --- Step 2: Update the total stock in the main Articles table ---
            // After changing the stock in one warehouse, we must recalculate the total for that article across ALL warehouses.
            string updateTotalStockQuery = @"
        UPDATE Articles 
        SET QuantityStock = (SELECT ISNULL(SUM(Quantity), 0) FROM ArticleStock WHERE ArticleID = @ArticleID)
        WHERE Id = @ArticleID";

            using (SqlCommand updateTotalCmd = new SqlCommand(updateTotalStockQuery, conn, transaction))
            {
                updateTotalCmd.Parameters.AddWithValue("@ArticleID", articleId);
                updateTotalCmd.ExecuteNonQuery();
            }

            // --- Step 3: Log the movement in the history table for auditing ---
            // This creates a permanent, unchangeable record of every stock movement.
            string insertHistoryQuery = @"
        INSERT INTO ArticleStockHistory (ArticleID, WarehouseID, ChangeQuantity, NewQuantity, MovementType, ReferenceID, UserID) 
        VALUES (@ArticleID, @WarehouseID, @ChangeQuantity, @NewQuantity, @MovementType, @ReferenceID, @User)";

            using (SqlCommand historyCmd = new SqlCommand(insertHistoryQuery, conn, transaction))
            {
                historyCmd.Parameters.AddWithValue("@ArticleID", articleId);
                historyCmd.Parameters.AddWithValue("@WarehouseID", warehouseId);
                historyCmd.Parameters.AddWithValue("@ChangeQuantity", quantityChange);
                historyCmd.Parameters.AddWithValue("@NewQuantity", newWarehouseQuantity);
                historyCmd.Parameters.AddWithValue("@MovementType", movementType);
                historyCmd.Parameters.AddWithValue("@ReferenceID", (object)referenceId ?? DBNull.Value);
                historyCmd.Parameters.AddWithValue("@User", "Admin"); // Replace with the actual logged-in user
                historyCmd.ExecuteNonQuery();
            }
        }
        /// <summary>
        /// Saves a single sales item to the TransactionItems table.
        /// This method now uses the SaleGridItem class for type safety and clarity.
        /// </summary>
        /// <param name="conn">The active SQL Connection</param>
        /// <param name="transaction">The active SQL Transaction</param>
        /// <param name="transactionId">The ID of the parent transaction record</param>
        /// <param name="ticketId">The ID of the legacy ticket record</param>
        /// <param name="item">The SaleGridItem object containing all necessary data</param>
        private void SaveTransactionItem(SqlConnection conn, SqlTransaction transaction, int transactionId, int ticketId, SaleGridItem item)
        {
            string query = @"INSERT INTO TransactionItems 
                     (ArticleID, TransactionID, TicketID, ItemName, Barcode, Quantity, Price, TotalPrice) 
                     VALUES 
                     (@ArtID, @TransID, @TicketID, @Name, @Barcode, @Qty, @Price, @Total)";

            using (var cmd = new SqlCommand(query, conn, transaction))
            {
                // Get values directly from the 'item' object properties
                cmd.Parameters.AddWithValue("@ArtID", item.ArticleID);
                cmd.Parameters.AddWithValue("@TransID", transactionId);
                cmd.Parameters.AddWithValue("@TicketID", ticketId);
                cmd.Parameters.AddWithValue("@Name", item.ArticleName);
                cmd.Parameters.AddWithValue("@Barcode", item.Barcode);
                cmd.Parameters.AddWithValue("@Qty", item.Quantity);
                cmd.Parameters.AddWithValue("@Price", item.SellPrice);
                cmd.Parameters.AddWithValue("@Total", item.TotalPrice);

                cmd.ExecuteNonQuery();
            }
        }

        // This helper updates the customer's debt balance
        private void UpdateCustomerDebt(SqlConnection conn, SqlTransaction transaction, int customerId, decimal amountChange)
        {
            // Do not update debt for the cash customer (ID = 1)
            if (customerId <= 1) return;

            string query = "UPDATE Customers SET AmountDue = ISNULL(AmountDue, 0) + @Amount WHERE CustomerID = @CID";
            using (var cmd = new SqlCommand(query, conn, transaction))
            {
                cmd.Parameters.AddWithValue("@Amount", amountChange);
                cmd.Parameters.AddWithValue("@CID", customerId);
                cmd.ExecuteNonQuery();
            }
        }

        #endregion
        public class PurchaseGridItem
        {
            public int ArticleID { get; set; }
            public string Barcode { get; set; }
            public string ArticleName { get; set; }
            public decimal Quantity { get; set; }
            public decimal BuyPrice { get; set; } // Or SellPrice
            public decimal TotalPrice => Quantity * BuyPrice;

            public static PurchaseGridItem FromRow(DataGridViewRow row, string idColName)
            {
                return new PurchaseGridItem
                {
                    ArticleID = Convert.ToInt32(row.Cells[idColName].Value),
                    Barcode = row.Cells["Barcode"].Value?.ToString(),
                    ArticleName = row.Cells["ArticleName"].Value?.ToString(),
                    Quantity = Convert.ToDecimal(row.Cells["quantity"].Value),
                    BuyPrice = Convert.ToDecimal(row.Cells["BuyPrice"].Value) // Or SellPrice
                };
            }
        }
        private decimal GetTotalAmountFromGrid()
        {
            return DatagridArticles.Rows.Cast<DataGridViewRow>()
                .Where(r => !r.IsNewRow)
                .Sum(r => Convert.ToDecimal(r.Cells["Tot"].Value ?? 0));
        }


        private Dictionary<decimal, decimal> CalculateStockChanges()
        {
            var changes = new Dictionary<decimal, decimal>();

            var currentItems = DatagridArticles.Rows.Cast<DataGridViewRow>()
                .Where(r => !r.IsNewRow && r.Tag != null)
                .ToDictionary(r => Convert.ToInt32(r.Tag), r => Convert.ToDecimal(r.Cells["Quantity"].Value));

            // مقارنة القائمة الحالية بالأصلية
            foreach (var originalItem in _originalTicketItems)
            {
                if (currentItems.TryGetValue(originalItem.ArticleID, out decimal newQuantity))
                {
                    // المنتج ما زال موجوداً، احسب الفرق
                    changes[originalItem.ArticleID] = newQuantity - originalItem.OriginalQuantity;
                    currentItems.Remove(originalItem.ArticleID); // أزله من القائمة الحالية لنعرف ما تبقى
                }
                else
                {
                    // المنتج تم حذفه من الفاتورة، يجب إعادة كميته للمخزون
                    changes[originalItem.ArticleID] = -originalItem.OriginalQuantity;
                }
            }

            // أي منتج متبقٍ في القائمة الحالية هو منتج جديد تمت إضافته
            foreach (var newItem in currentItems)
            {
                changes[newItem.Key] = newItem.Value; // الكمية كاملة هي التغيير
            }
            return changes;
        }

        private void NewSale()
        {
            _isEditMode = false;
            _editingTicketId = 0;
            _originalTicketItems.Clear();
            _originalTotalAmount = 0;
            _originalAmountPaid = 0;
            _currentDiscountAmount = 0;
            _currentDiscountAmountc = 0;
            DatagridArticles.Rows.Clear();

            paymentCash = 0;
            paymentCard = 0;
            paymentCheque = 0;

            UpdateAllTotals(); // سيقوم بتصفير كل الليبلات

            // إعادة العميل الافتراضي
            currentCustomerId = 1;
            lbl_client.Text = "Client";
            ResetCustomerFinancials();

            txt_barcode.Clear();
            txt_barcode.Focus();
        }
        private void ResetSaleForm()
        {
            // 1. مسح جدول المنتجات
            DatagridArticles.Rows.Clear();

            // 2. تصفير قيم المبالغ
            lbl_total.Text = "0.00";
            lbl_avance.Text = "0.00"; // اسم الليبل الخاص بالدفع
            lbl_reste.Text = "0.00";  // اسم الليبل الخاص بالباقي

            // 3. تصفير متغيرات الدفع
            paymentCash = 0;
            paymentCard = 0;
            paymentCheque = 0;

            // 4. إعادة العميل للعميل الافتراضي
            // SelectDefaultCustomer(); // دالة تقوم باختيار الزبون النقدي

            // 5. تنظيف حقل الباركود والتركيز عليه
            txt_barcode.Clear();
            txt_barcode.Focus();
        }
        // In Caisse.cs, add this helper method
        private void DrawRightAlignedText(Graphics g, string text, Font font, float x, float y, float width)
        {
            SizeF textSize = g.MeasureString(text, font);
            float startX = x + width - textSize.Width;
            g.DrawString(text, font, Brushes.Black, startX, y);
        }

        // Replace your existing PrintPageHandler with this one.
        // --- دالة الطباعة الرئيسية ---
        // --- دالة الطباعة الرئيسية ---
        private void PrintPageHandler(object sender, PrintPageEventArgs e)
        {   // Safety check
            if (_currentReceiptDataForPrint == null || e.Graphics == null) return;

            Graphics g = e.Graphics;
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

            // --- 1. Define GDI+ Objects ---
            using (Font headerFont = new Font("Segoe UI", 10, FontStyle.Bold))
            using (Font subHeaderFont = new Font("Segoe UI", 8, FontStyle.Regular))
            using (Font bodyFont = new Font("Segoe UI", 7, FontStyle.Regular))
            using (Font bodyBoldFont = new Font("Segoe UI", 7, FontStyle.Bold))
            using (Pen separatorPen = new Pen(Color.Black, 0.5f))
            using (SolidBrush mainBrush = new SolidBrush(Color.Black))
            {
                // --- 2. Define Layout Variables ---
                float yPos = e.MarginBounds.Top;
                float leftMargin = e.MarginBounds.Left;
                float printableWidth = e.MarginBounds.Width;
                float rowSpacing = 8f;

                StringFormat sfCenter = new StringFormat { Alignment = StringAlignment.Center };
                StringFormat sfRight = new StringFormat { Alignment = StringAlignment.Near, FormatFlags = StringFormatFlags.DirectionRightToLeft };
                StringFormat sfLeft = new StringFormat { Alignment = StringAlignment.Far, FormatFlags = StringFormatFlags.DirectionRightToLeft };

                // --- 3. Receipt Header (Loading from AppSettingsManager) ---
                string logoPath = AppSettingsManager.LogoPath;
                if (!string.IsNullOrEmpty(logoPath) && File.Exists(logoPath))
                {
                    try
                    {
                        Image logo = Image.FromFile(logoPath);
                        // Draw logo centered, max width 120, scale height to maintain aspect ratio
                        float logoWidth = 120;
                        float logoHeight = (logo.Height / (float)logo.Width) * logoWidth;
                        g.DrawImage(logo, new RectangleF((printableWidth / 2) - (logoWidth / 2) + leftMargin, yPos, logoWidth, logoHeight));
                        yPos += logoHeight + 5;
                    }
                    catch { /* Could not load image, will proceed without it */ }
                }

                string headerText = AppSettingsManager.HeaderReceipt.Replace("\\n", Environment.NewLine);
                float headerHeight = g.MeasureString(headerText, subHeaderFont, (int)printableWidth).Height;
                g.DrawString(headerText, subHeaderFont, mainBrush, new RectangleF(leftMargin, yPos, printableWidth, headerHeight), sfCenter);
                yPos += headerHeight + 15;

                // --- 4. Transaction Info ---
                DrawLabelAndValue(g, "المستخدم:", selectedSellerName, bodyFont, mainBrush, leftMargin, yPos, printableWidth, sfRight, sfLeft);
                yPos += bodyFont.GetHeight(g) + rowSpacing;
                DrawLabelAndValue(g, "البائع:", lblSessionUser, bodyFont, mainBrush, leftMargin, yPos, printableWidth, sfRight, sfLeft);
                yPos += bodyFont.GetHeight(g) + rowSpacing;
                DrawLabelAndValue(g, "التاريخ:", _currentReceiptDataForPrint.PrintDateTime.ToString("yyyy/MM/dd HH:mm:ss"), bodyFont, mainBrush, leftMargin, yPos, printableWidth, sfRight, sfLeft);
                yPos += bodyFont.GetHeight(g) + rowSpacing;
                DrawLabelAndValue(g, "رقم الفاتورة:", _currentReceiptDataForPrint.TicketId.ToString(), bodyFont, mainBrush, leftMargin, yPos, printableWidth, sfRight, sfLeft);
                yPos += bodyFont.GetHeight(g) + rowSpacing;
                if (!string.IsNullOrWhiteSpace(_currentReceiptDataForPrint.ClientName) && !_currentReceiptDataForPrint.ClientName.Equals("passager", StringComparison.OrdinalIgnoreCase))
                {
                    DrawLabelAndValue(g, "الزبون:", _currentReceiptDataForPrint.ClientName, bodyFont, mainBrush, leftMargin, yPos, printableWidth, sfRight, sfLeft);
                    yPos += bodyFont.GetHeight(g) + rowSpacing;
                }
           
                
                yPos += 10;

                // --- 5. جدول المنتجات ---
                float tableStartY = yPos;
                float colWidthTotal = printableWidth * 0.25f;
                float colWidthPrice = printableWidth * 0.22f;
                float colWidthQty = printableWidth * 0.13f;
                float colWidthName = printableWidth - (colWidthTotal + colWidthPrice + colWidthQty);
                float xQty = leftMargin + printableWidth - colWidthQty;
                float xName = xQty - colWidthName;
                float xPrice = xName - colWidthPrice;

                // رسم رأس الجدول
                yPos += rowSpacing / 2;
                g.DrawString("الإجمالي", bodyBoldFont, mainBrush, new RectangleF(leftMargin, yPos, colWidthTotal, bodyFont.GetHeight(g)), sfCenter);
                g.DrawString("السعر", bodyBoldFont, mainBrush, new RectangleF(xPrice, yPos, colWidthPrice, bodyFont.GetHeight(g)), sfCenter);
                g.DrawString("الكمية", bodyBoldFont, mainBrush, new RectangleF(xQty, yPos, colWidthQty, bodyFont.GetHeight(g)), sfCenter);
                g.DrawString("الصنف", bodyBoldFont, mainBrush, new RectangleF(xName, yPos, colWidthName, bodyFont.GetHeight(g)), sfCenter);
                yPos += bodyFont.GetHeight(g) + rowSpacing / 2;
                g.DrawLine(separatorPen, leftMargin, yPos, leftMargin + printableWidth, yPos);

                // رسم بنود الفاتورة
                foreach (var item in _currentReceiptDataForPrint.Items)
                {
                    yPos += rowSpacing;
                    float currentItemHeight = SplitTextForPrinting(g, item.Name, bodyFont, colWidthName - 10).Count * bodyFont.GetHeight(g);
                    g.DrawString(item.Total.ToString("N2"), bodyBoldFont, mainBrush, new RectangleF(leftMargin, yPos, colWidthTotal, currentItemHeight), sfCenter);
                    g.DrawString(item.Price.ToString("N2"), bodyFont, mainBrush, new RectangleF(xPrice, yPos, colWidthPrice, currentItemHeight), sfCenter);
                    g.DrawString(item.Quantity.ToString(), bodyFont, mainBrush, new RectangleF(xQty, yPos, colWidthQty, currentItemHeight), sfCenter);
                    g.DrawString(item.Name, bodyFont, mainBrush, new RectangleF(xName + 5, yPos, colWidthName - 10, currentItemHeight), sfCenter);
                    yPos += currentItemHeight + rowSpacing;
                    g.DrawLine(separatorPen, leftMargin + 10, yPos, leftMargin + printableWidth - 10, yPos);
                }
                float tableEndY = yPos;

                // رسم إطارات الجدول
                g.DrawRectangle(new Pen(Color.Black, 0.8f), leftMargin, tableStartY, printableWidth, tableEndY - tableStartY);
                g.DrawLine(separatorPen, xQty, tableStartY, xQty, tableEndY);
                g.DrawLine(separatorPen, xName, tableStartY, xName, tableEndY);
                g.DrawLine(separatorPen, xPrice, tableStartY, xPrice, tableEndY);

                yPos = tableEndY + 15;

                // --- 6. ملخص الدفع ---
                yPos += 10;
                DrawSummaryLine(g, "المجموع:", _currentReceiptDataForPrint.SubTotal.ToString("C2"), bodyFont, mainBrush, leftMargin, printableWidth, ref yPos);
                DrawSummaryLine(g, "الخصم:", _currentReceiptDataForPrint.TotalDiscount.ToString("C2"), bodyFont, mainBrush, leftMargin, printableWidth, ref yPos);
                g.DrawLine(separatorPen, leftMargin, yPos, leftMargin + printableWidth, yPos);
                yPos += 5;
                DrawSummaryLine(g, "الإجمالي للدفع:", _currentReceiptDataForPrint.TotalAmount.ToString("C2"), bodyBoldFont, mainBrush, leftMargin, printableWidth, ref yPos);
                DrawSummaryLine(g, "المبلغ المدفوع:", _currentReceiptDataForPrint.AmountPaid.ToString("C2"), bodyFont, mainBrush, leftMargin, printableWidth, ref yPos);
                DrawSummaryLine(g, "طريقة الدفع:", _currentReceiptDataForPrint.PaymentMethod, bodyFont, mainBrush, leftMargin, printableWidth, ref yPos);
                // تحقق من إعداد إخفاء الدين قبل طباعة المبلغ المتبقي
                if (_currentReceiptDataForPrint.RemainingDebt > 0 && !AppSettingsManager.HideCreditOnTicket)
                {
                    DrawSummaryLine(g, "المتبقي (عليكم):", _currentReceiptDataForPrint.RemainingDebt.ToString("C2"), bodyBoldFont, Brushes.Red, leftMargin, printableWidth, ref yPos);
                }

                yPos += 15;
                // --- 7. Footer (Loading from AppSettingsManager) ---
                string footerText = AppSettingsManager.FooterReceipt.Replace("\\n", Environment.NewLine);
                float footerHeight = g.MeasureString(footerText, bodyFont, (int)printableWidth).Height;
                g.DrawString(footerText, bodyFont, mainBrush, new RectangleF(leftMargin, yPos, printableWidth, footerHeight), sfCenter);

                e.HasMorePages = false;
            }
        }
        private void DrawSummaryLine(Graphics g, string label, string value, Font font, Brush brush, float x, float width, ref float yPos)
        {
            float lineHeight = font.GetHeight(g) + 3; // Add some padding
            StringFormat rightAlign = new StringFormat { Alignment = StringAlignment.Far, FormatFlags = StringFormatFlags.DirectionRightToLeft };
            StringFormat leftAlign = new StringFormat { Alignment = StringAlignment.Near, FormatFlags = StringFormatFlags.DirectionRightToLeft };

            g.DrawString(label, font, brush, new RectangleF(x, yPos, width, lineHeight), rightAlign);
            g.DrawString(value, font, brush, new RectangleF(x, yPos, width, lineHeight), leftAlign);

            yPos += lineHeight;
        }
        private void UpdateStock(SqlConnection conn, SqlTransaction transaction, int articleId, int quantityChange)
        {
            // دالة محسنة: تقوم فقط بتحديث المخزن المحدد
            if (quantityChange == 0) return;

            string stockQuery = "UPDATE ArticleStock SET Quantity = Quantity - @Change WHERE ArticleID = @ArticleID AND WarehouseID = @WarehouseID";
            using (var cmd = new SqlCommand(stockQuery, conn, transaction))
            {
                cmd.Parameters.AddWithValue("@Change", quantityChange);
                cmd.Parameters.AddWithValue("@ArticleID", articleId);
                cmd.Parameters.AddWithValue("@WarehouseID", defaultSaleWarehouseId);
                if (cmd.ExecuteNonQuery() == 0)
                {
                    // If no row was updated, it means the item doesn't exist in this warehouse. Insert it.
                    string insertQuery = "INSERT INTO ArticleStock (ArticleID, WarehouseID, Quantity) VALUES (@ArticleID, @WarehouseID, @InitialStock)";
                    using (var insertCmd = new SqlCommand(insertQuery, conn, transaction))
                    {
                        insertCmd.Parameters.AddWithValue("@ArticleID", articleId);
                        insertCmd.Parameters.AddWithValue("@WarehouseID", defaultSaleWarehouseId);
                        insertCmd.Parameters.AddWithValue("@InitialStock", -quantityChange); // Insert with the correct stock value
                        insertCmd.ExecuteNonQuery();
                    }
                }
            }
        }

        private void DrawSummaryLine(Graphics g, string label, string value, Font font, float x, float width, ref float yPos)
        {
            float lineHeight = font.GetHeight(g) + 10;
            g.DrawString(label, font, Brushes.Black, x + width, yPos, new StringFormat { Alignment = StringAlignment.Far, FormatFlags = StringFormatFlags.DirectionRightToLeft });
            g.DrawString(value, font, Brushes.Black, x, yPos, new StringFormat { Alignment = StringAlignment.Near, FormatFlags = StringFormatFlags.DirectionRightToLeft });
            yPos += lineHeight;
        }        // Helper method to draw summary lines neatly
        // Helper method - no changes needed
        private void DrawLabelAndValue(Graphics g, string label, string value, Font font, Brush brush, float x, float y, float width, StringFormat labelFormat, StringFormat valueFormat)
        {
            float labelWidth = width * 0.4f;
            float valueWidth = width * 0.6f;
            RectangleF labelRect = new RectangleF(x + valueWidth, y, labelWidth, font.GetHeight(g));
            RectangleF valueRect = new RectangleF(x, y, valueWidth, font.GetHeight(g));
            g.DrawString(label, font, brush, labelRect, labelFormat);
            g.DrawString(value, font, brush, valueRect, valueFormat);
        }
        // --- Helper Methods (should be part of YourFormName class) ---

        private List<string> SplitTextForPrinting(Graphics g, string text, Font font, float maxWidth)
        {
            var lines = new List<string>();
            if (string.IsNullOrEmpty(text) || maxWidth <= 0)
            {
                if (!string.IsNullOrEmpty(text)) lines.Add(text);
                return lines;
            }

            string[] words = text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (!words.Any())
            {
                string currentLineNoSpace = string.Empty;
                foreach (char c in text)
                {
                    if (g.MeasureString(currentLineNoSpace + c, font).Width > maxWidth && currentLineNoSpace.Length > 0)
                    {
                        lines.Add(currentLineNoSpace);
                        currentLineNoSpace = c.ToString();
                    }
                    else
                    {
                        currentLineNoSpace += c;
                    }
                }
                if (!string.IsNullOrEmpty(currentLineNoSpace)) lines.Add(currentLineNoSpace);
                return lines.Any() ? lines : new List<string> { text };
            }

            string line = "";
            foreach (string word in words)
            {
                string testLine = string.IsNullOrEmpty(line) ? word : line + " " + word;
                if (g.MeasureString(testLine, font).Width > maxWidth)
                {
                    if (!string.IsNullOrEmpty(line)) { lines.Add(line); }
                    if (g.MeasureString(word, font).Width > maxWidth)
                    {
                        string currentSubWord = "";
                        foreach (char c in word)
                        {
                            if (g.MeasureString(currentSubWord + c, font).Width > maxWidth && currentSubWord.Length > 0)
                            {
                                lines.Add(currentSubWord);
                                currentSubWord = c.ToString();
                            }
                            else { currentSubWord += c; }
                        }
                        line = currentSubWord;
                    }
                    else { line = word; }
                }
                else { line = testLine; }
            }
            if (!string.IsNullOrEmpty(line)) { lines.Add(line); }
            return lines.Any() ? lines : new List<string> { text };
        }



        private void InitiatePrint()
        {
            if (_currentReceiptDataForPrint == null)
            {
                MessageBox.Show("لا توجد بيانات لطباعتها.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (PrintDocument pd = new PrintDocument())
            {
                // Use the printer name from settings
                string targetPrinterName = AppSettingsManager.PrinterTicket;

                if (string.IsNullOrEmpty(targetPrinterName))
                {
                    MessageBox.Show("Aucune imprimante de ticket n'est configurée dans les paramètres.", "Erreur d'impression", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                pd.PrinterSettings.PrinterName = targetPrinterName;

                // Set paper size and margins
                int widthInHundredthsOfInch = (int)Math.Round((80.0 / 25.4) * 100.0);
                pd.DefaultPageSettings.PaperSize = new PaperSize("80mm Custom Roll", widthInHundredthsOfInch, 1100);
                pd.DefaultPageSettings.Margins = new Margins(15, 15, 20, 20);

                pd.PrintPage += new PrintPageEventHandler(PrintPageHandler);

                try
                {
                    if (usePrintPreview)
                    {
                        using (PrintPreviewDialog previewDialog = new PrintPreviewDialog())
                        {
                            previewDialog.Document = pd;
                            previewDialog.WindowState = FormWindowState.Maximized;
                            previewDialog.Text = "معاينة طباعة الإيصال (80 مم)";
                            previewDialog.PrintPreviewControl.AutoZoom = true;
                            previewDialog.ShowDialog(this);
                        }
                    }
                    else
                    {
                        pd.Print();
                    }
                }
                catch (System.Drawing.Printing.InvalidPrinterException ex)
                {
                    MessageBox.Show($"L'imprimante '{targetPrinterName}' est introuvable ou invalide.\n\nDétails: {ex.Message}", "Erreur Imprimante", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Une erreur est survenue lors de l'impression: {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    pd.PrintPage -= new PrintPageEventHandler(PrintPageHandler);
                }
            }
        }

        // Helper method to reset form fields
        private void ResetFormFields()
        {
            lbl_total.Text = "0.00";
            lbl_avance.Text = "0.00";
            lbl_reste.Text = "0.00";
            lbl_client.Text = "Client";
        }
        private void btn_cartebancaire_Click(object sender, EventArgs e)
        {
            using (var cashForm = new CashPaiement(decimal.Parse(lbl_reste.Text)))
            {
                if (cashForm.ShowDialog() == DialogResult.OK)
                {
                    paymentCard += cashForm.paid;
                    UpdatePaymentMethodString();
                    UpdateAllTotals();
                }
            }
        }
        decimal loanAmount = 0;
        private void btn_Credit_Click(object sender, EventArgs e)
        {
            if (currentCustomerId <= 1)
            {
                using (frmCustomersList listCustomerForm = new frmCustomersList(true))
                {
                    // عند فتح النافذة وعمل Double-Click، ستكون النتيجة OK
                    if (listCustomerForm.ShowDialog() == DialogResult.OK)
                    {
                        // الآن سيتمكن من قراءة هذه الخصائص بنجاح
                        currentCustomerId = listCustomerForm.SelectedCustomerId;
                        string customername = listCustomerForm.SelectedCustomerName;
                        lbl_client.Text = customername;
  
                        LoadCustomerFinancials(currentCustomerId);
                  
                        txt_barcode.Focus();
                    }
                }

            }
            decimal finalTotal = GetTotalAmountFromGrid() - _currentDiscountAmount;
            decimal totalDiscountToSave = subTotal - finalTotal; // This is the correct total discount to save.
            decimal totalAmount = GetTotalAmountFromGrid();
            decimal newPayments = paymentCash + paymentCard + paymentCheque;
            decimal finalAmountPaid = _isEditMode ? _originalAmountPaid + newPayments : newPayments;
            loanAmount = finalTotal - finalAmountPaid;
            UpdatePaymentMethodString();
            MessageBox.Show($"سيتم تسجيل مبلغ {loanAmount + " DH"} كدين على الزبون.");
        }

        // In Caisse.cs

        private void btn_cheque_Click(object sender, EventArgs e)
        {
            decimal reste;
            if (!decimal.TryParse(lbl_reste.Text, out reste) || reste <= 0)
            {
                MessageBox.Show("المبلغ مدفوع بالكامل أو غير صالح.", "معلومات", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (var chequeForm = new ChequePaiement(reste))
            {
                if (chequeForm.ShowDialog() == DialogResult.OK)
                {
                    // --- START OF FIX ---
                    // Create a new ChequeInfo object and populate it with the
                    // public properties from the chequeForm after it closes.
                    var newCheque = new ChequeInfo
                    {
                        Amount = chequeForm.AmountPaid,
                        BankName = chequeForm.BankName,
                        CheckNumber = chequeForm.CheckNumber,
                        DueDate = chequeForm.DueDate,
                        PayerName = chequeForm.PayerName
                    };
                    // --- END OF FIX ---

                    // Add the new cheque to the list for this sale
                    _checksReceived.Add(newCheque);

                    // Update the total payment by cheque
                    paymentCheque += newCheque.Amount;

                    // Refresh the totals and payment method display
                    UpdatePaymentMethodString();
                    UpdateAllTotals();
                }
            }
        }
        private void btn_customer_Click(object sender, EventArgs e)
        {
            // --- FIX: Open the form in explicit "Selection Mode" ---
            using (frmCustomersList listCustomerForm = new frmCustomersList(true))
            {
                // When the user double-clicks a customer, the form will close with DialogResult.OK
                if (listCustomerForm.ShowDialog() == DialogResult.OK)
                {
                    // The rest of your code is perfect. It correctly gets the data.
                    this.currentCustomerId = listCustomerForm.SelectedCustomerId;
                    this.lbl_client.Text = listCustomerForm.SelectedCustomerName;

                    LoadCustomerFinancials(this.currentCustomerId);
                    txt_barcode.Focus();
                }
            }
        }
        private void btn_cancelpaiment_Click(object sender, EventArgs e)
        {
            paymentCash = 0;
            paymentCard = 0;
            paymentCheque = 0;
            _checksReceived.Clear();
            UpdatePaymentMethodString(); // Update the method string
            UpdateAllTotals();
        }
        private void UpdatePaymentMethodString()
        {
            var methods = new List<string>();
            if (paymentCash > 0) methods.Add("نقدا");
            if (paymentCard > 0) methods.Add("بطاقة بنكية");
            if (paymentCheque > 0) methods.Add("شيك");
            if (loanAmount > 0) methods.Add("آجل");

            if (methods.Count == 0)
            {
                paymentMethod = "N/A";
            }
            else
            {
                paymentMethod = string.Join(" + ", methods);
            }
        }
        private void ListTickets_Click(object sender, EventArgs e)
        {
            using (LISTTICKET attForm = new LISTTICKET())
            {
                // 1. نقوم بإنشاء نسخة من الفورم باستخدام الـ constructor الافتراضي
                // 2. نقوم بتعيين الفورم الحالي (Caisse) للخاصية الجديدة
                attForm.ParentCaisseForm = this;

                // 3. نعرض الفورم
                attForm.ShowDialog(this);
            }
        }
        private void bunifuButton212_Click(object sender, EventArgs e)
        {
            // Ensure a row is selected
            if (DatagridArticles.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = DatagridArticles.SelectedRows[0];

                // Extract the Barcode and ArticleName
                string ArticleID_DGV = selectedRow.Cells["ArticleID_DGV"].Value?.ToString();
                string barcode = selectedRow.Cells["barcode"].Value?.ToString();
                string articleName = selectedRow.Cells["ArticleName"].Value?.ToString();

                if (string.IsNullOrEmpty(ArticleID_DGV) || string.IsNullOrEmpty(articleName))
                {
                    MessageBox.Show("Invalid data in the selected row.");
                    return;
                }

                // Check if there's already a FreeQuantity row for this Barcode
                bool rowUpdated = false;

                foreach (DataGridViewRow row in DatagridArticles.Rows)
                {
                    // Skip empty or new rows
                    if (row.IsNewRow) continue;

                    if (row.Cells["ArticleID_DGV"].Value?.ToString() == ArticleID_DGV &&
                        Convert.ToDouble(row.Cells["Quantity"].Value?.ToString()) < 0)
                    {
                        // Update the Quantity and Total
                        double currentQuantity = Convert.ToDouble(row.Cells["Quantity"].Value);
                        currentQuantity--;
                        row.Cells["Quantity"].Value = currentQuantity;
                        row.Cells["tot"].Value = currentQuantity * Convert.ToInt32(row.Cells["SellPrice"].Value);
                        UpdateAllTotals();
                        rowUpdated = true;

                        break;
                    }
                }

                if (!rowUpdated)
                {
                    // Add a new FreeQuantity row
                    DatagridArticles.Rows.Add(
                        ArticleID_DGV,
                        barcode,        // Barcode
                        articleName,    // ArticleName
                        -1,              // Quantity
                        Convert.ToDouble(selectedRow.Cells["SellPrice"].Value),              // SellPrice
                        -Convert.ToDouble(selectedRow.Cells["tot"].Value)           // Total
                    );
                    selectedRow.Cells["Quantity"].Value = Convert.ToInt32(selectedRow.Cells["Quantity"].Value) - 1;
                    if (Convert.ToDouble(selectedRow.Cells["Quantity"].Value) <= 0)
                    {
                        DatagridArticles.Rows.Remove(selectedRow);
                    }
                }
                UpdateAllTotals();
                txt_barcode.Focus();
            }
            else
            {
                MessageBox.Show("Please select a row first.");
            }
        }
        // أضف هذه الدالة المركزية واستخدمها في كل مكان
        // In Caisse.cs

        // In Caisse.cs
        private void ApplyDiscountToRow(DataGridViewRow row, decimal discountValue, bool isPercentage)
        {
            if (row == null || row.IsNewRow || row.Tag == null) return;

            try
            {
                int articleId = Convert.ToInt32(row.Tag);
                decimal originalPrice = GetOriginalSellPrice(articleId);
                decimal originalBuyPrice = GetOriginalBuyPrice(articleId);
                decimal quantity = Convert.ToDecimal(row.Cells["Quantity"].Value);
                decimal originalRowTotal = originalPrice * quantity;
                decimal originalRowearning = (originalPrice -originalBuyPrice) * quantity;
                decimal discountAmountForRow;

                if (isPercentage)
                {
                    discountAmountForRow = originalRowTotal * (discountValue / 100m);
                    row.Cells["colRemise"].Value = $"{discountValue:F2} %";
                }
                else // This is a fixed amount discount for this specific row
                {
                    discountAmountForRow = discountValue;
                    row.Cells["colRemise"].Value = discountAmountForRow.ToString("N2");
                }

                // Set the new total for this row
                row.Cells["Tot"].Value = originalRowTotal - discountAmountForRow;
                row.Cells["earning"].Value = originalRowearning - discountAmountForRow;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error applying discount: " + ex.Message);
            }
        }
        private Article GetArticleByIdFromList(int articleId)
        {
            // This is a placeholder. You should have a master list of articles available
            // or fetch it if necessary. For now, we fetch it.
            // A better solution would be to cache this.
            return GetArticleByBarcode(articleId.ToString()); // This is inefficient but will work.
        }
        decimal subTotal = 0;

        private void UpdateAllTotals()
        {
            subTotal = 0;
            decimal finalTotal = 0;
            decimal earnings = 0;

            foreach (DataGridViewRow row in DatagridArticles.Rows)
            {
                if (row.IsNewRow || row.Tag == null) continue;

                var article = GetArticleByIdFromList(Convert.ToInt32(row.Tag)); // Use helper to get full article data
                if (article == null) continue;

                decimal quantity = Convert.ToDecimal(row.Cells["Quantity"].Value);
                subTotal += article.SellPrice * quantity; // Subtotal is always original price * qty
                finalTotal += Convert.ToDecimal(row.Cells["Tot"].Value ?? 0); // Final total is sum of discounted row totals
                earnings += Convert.ToDecimal(row.Cells["earning"].Value);
            }
            // Subtract the global fixed discount from the final total
            finalTotal -= _currentDiscountAmount;
            earnings -= _currentDiscountAmount;
            decimal totalDiscount = subTotal - finalTotal;

            decimal totalPaidDuringSession = paymentCash + paymentCard + paymentCheque;
            decimal grandTotalPaid = _isEditMode ? (_originalAmountPaid + totalPaidDuringSession) : totalPaidDuringSession;
            decimal remainingAmount = finalTotal - grandTotalPaid;

            // lbl_subtotal.Text = subTotal.ToString("N2");
            //lbl_remise.Text = totalDiscount.ToString("N2");
            lbl_total.Text = finalTotal.ToString("N2");
            lbl_avance.Text = grandTotalPaid.ToString("N2");
            lbl_reste.Text = remainingAmount.ToString("N2");
            lbl_earningsnet.Text = earnings.ToString("N2");
        }
        private void bunifuButton26_Click(object sender, EventArgs e)
        {

        }
        private void AddArticleToCart(Article article, int quantityToAdd)
        {

            if (article == null) return;

            if (!AppSettingsManager.AllowNegativeStock)
            {
                decimal availableStock;
                string stockLocation;

                if (_selectedWarehouseId == 0) // Check GLOBAL stock
                {
                    availableStock = article.QuantityStock;
                    stockLocation = "global";
                }
                else // Check stock for the SPECIFIC selected warehouse
                {
                    availableStock = GetStockForArticleInWarehouse(article.Id, _selectedWarehouseId);
                    stockLocation = $"dans le dépôt sélectionné (ID: {_selectedWarehouseId})";
                }

                int quantityInCart = 0;
                DataGridViewRow existingRowForStockCheck = DatagridArticles.Rows.Cast<DataGridViewRow>()
                    .FirstOrDefault(row => !row.IsNewRow && row.Tag != null && (int)row.Tag == article.Id);

                if (existingRowForStockCheck != null)
                {
                    quantityInCart = Convert.ToInt32(existingRowForStockCheck.Cells["Quantity"].Value);
                }

                if ((quantityInCart + quantityToAdd) > availableStock)
                {
                    MessageBox.Show($"الكمية غير متوفرة. المتوفر: {availableStock} {stockLocation}", "نفاد المخزون", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            DataGridViewRow targetRow = DatagridArticles.Rows.Cast<DataGridViewRow>()
                .FirstOrDefault(row => !row.IsNewRow && row.Tag != null && (int)row.Tag == article.Id);

            if (targetRow != null)
            {
                int currentQty = Convert.ToInt32(targetRow.Cells["Quantity"].Value);
                targetRow.Cells["Quantity"].Value = currentQty + quantityToAdd;
            }
            else
            {
                int rowIndex = DatagridArticles.Rows.Add();
                targetRow = DatagridArticles.Rows[rowIndex];

                targetRow.Tag = article.Id;
                targetRow.Cells["ArticleID_DGV"].Value = article.Id;
                targetRow.Cells["Barcode"].Value = article.Barcode;
                targetRow.Cells["ArticleName"].Value = article.ArticleCode;
                targetRow.Cells["Quantity"].Value = quantityToAdd;
                targetRow.Cells["SellPrice"].Value = article.SellPrice;
                targetRow.Cells["colPrixAchat"].Value = article.BuyPrice;

            }
            // Calculate the total for the affected row
            decimal price = Convert.ToDecimal(targetRow.Cells["SellPrice"].Value);
            int quantity = Convert.ToInt32(targetRow.Cells["Quantity"].Value);
            targetRow.Cells["Tot"].Value = price * quantity;
            targetRow.Cells["earning"].Value  = (price - Convert.ToDecimal(targetRow.Cells["colPrixAchat"].Value))* quantity;

            UpdateAllTotals();

            DatagridArticles.ClearSelection();
            targetRow.Selected = true;
        }
        private Article GetArticleByBarcode(string barcode)
        {
            // إذا كان الباركود فارغاً، لا تقم بالبحث
            if (string.IsNullOrWhiteSpace(barcode))
            {
                return null;
            }

            Article foundArticle = null;
            string connectionString = DatabaseConnection.GetConnectionString();

            // جملة SQL للبحث عن المنتج باستخدام أي من الباركودات المسجلة له
            // تم إضافة ArticleColor لجلب اللون أيضاً
            string query = @"
        SELECT TOP 1 * FROM Articles 
        WHERE 
            Id = @Barcode OR 
            EXISTS (
                SELECT 1 
                FROM OPENJSON(Barcodes) 
                WHERE value = @Barcode
            )";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Barcode", barcode);
                    try
                    {
                        conn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            // إذا وجدنا المنتج، قم بإنشاء كائن Article جديد واملأه بالبيانات
                            foundArticle = new Article
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                ArticleCode = reader["Article"]?.ToString(),
                                // نفترض أن سعر البيع الافتراضي هو سعر التفاصيل (DetailsPrice)
                                // يجب تعديل هذا إذا كنت تستخدم منطق تسعير مختلف
                                SellPrice = Convert.ToDecimal(reader["DetailsPrice"]),
                                Barcode = barcode, // الباركود الذي تم البحث به
                                ArticleColor = reader["ArticleColor"]?.ToString()
                                // يمكنك إضافة أي خصائص أخرى تحتاجها من جدول Articles هنا
                            };
                            switch (this.Tarifs)
                            {
                                case "Gros":
                                    foundArticle.SellPrice = Convert.ToDecimal(reader["GrosPrice"]);
                                    break;
                                case "Semigros":
                                    foundArticle.SellPrice = Convert.ToDecimal(reader["SemigrosPrice"]);
                                    break;
                                case "Special":
                                    foundArticle.SellPrice = Convert.ToDecimal(reader["SpecialPrice"]);
                                    break;
                                default: // الافتراضي هو سعر التفاصيل
                                    foundArticle.SellPrice = Convert.ToDecimal(reader["DetailsPrice"]);
                                    break;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("خطأ أثناء البحث عن المنتج: " + ex.Message);
                    }
                }
            }
            return foundArticle; // إرجاع المنتج الذي تم العثور عليه، أو null إذا لم يتم العثور عليه
        }
        private void txt_barcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                // هنا يتم استدعاء الدالة الجديدة
                var article = GetArticleByBarcode(txt_barcode.Text.Trim());
                if (article != null)
                {
                    AddArticleToCart(article, 1);
                    txt_barcode.Clear();
                }
                else
                {
                    MessageBox.Show("المنتج غير موجود.");
                }
                e.Handled = true;
            }
        }

        // In Caisse.cs
        // In Caisse.cs

        // In Caisse.cs

        public void PrintReceiptForTransaction(int transactionId)
        {
            try
            {
                var data = new ReceiptPrintData();
                string query = @"SELECT t.*, c.CustomerName 
                         FROM Transactions t 
                         JOIN Customers c ON t.CustomerID = c.CustomerID 
                         WHERE t.TransactionID = @TID";

                using (var conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    // Get main transaction info
                    using (var cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@TID", transactionId);
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                data.TicketId = transactionId;
                                data.PrintDateTime = Convert.ToDateTime(reader["TransactionDate"]);
                                data.ClientName = reader["CustomerName"].ToString();
                                data.TotalAmount = Convert.ToDecimal(reader["TotalAmount"]);
                                data.AmountPaid = Convert.ToDecimal(reader["AmountPaid"]);
                                data.TotalDiscount = Convert.ToDecimal(reader["DiscountAmount"]);
                                data.SubTotal = data.TotalAmount + data.TotalDiscount;
                                data.RemainingDebt = data.TotalAmount - data.AmountPaid;
                            }
                        }
                    }

                    // Get transaction items
                    data.Items = new List<ReceiptItem>();
                    query = "SELECT * FROM TransactionItems WHERE TransactionID = @TID";
                    using (var cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@TID", transactionId);
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                data.Items.Add(new ReceiptItem
                                {
                                    Name = reader["ItemName"].ToString(),
                                    Quantity = Convert.ToDecimal(reader["Quantity"]),
                                    Price = Convert.ToDecimal(reader["Price"])
                                });
                            }
                        }
                    }
                }
                _currentReceiptDataForPrint = data;
                InitiatePrint();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to get data for printing duplicate receipt: " + ex.Message);
            }
        }// In Caisse.cs

        public void CreateReturnForTransaction(int originalTransactionId)
        {
            // This is the main method to cancel out an old sale by creating a new, negative "return" sale.
            CheckForOpenSession();
            if (_currentSessionId == 0)
            {
                MessageBox.Show("Impossible de traiter un retour. Veuillez d'abord ouvrir une session de caisse.",
                                "Aucune Session Active", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Stop the entire method
            }

            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (var transaction = conn.BeginTransaction())
                {
                    try
                    {
                        // 2. Get original transaction data
                        var originalTransaction = new Dictionary<string, object>();
                        var cmdGetOriginal = new SqlCommand("SELECT * FROM Transactions WHERE TransactionID = @TID AND ISNULL(IsReturn, 0) = 0", conn, transaction);
                        cmdGetOriginal.Parameters.AddWithValue("@TID", originalTransactionId);

                        using (var reader = cmdGetOriginal.ExecuteReader())
                        {
                            if (!reader.Read())
                            {
                                MessageBox.Show("Transaction originale introuvable ou déjà retournée.");
                                return;
                            }
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                originalTransaction[reader.GetName(i)] = reader.GetValue(i);
                            }
                        } // The reader is now closed here.

                        int warehouseToReturnTo = AppSettingsManager.DefaultSaleWarehouseId;
                        if (warehouseToReturnTo == 0) // Safety check if default is not set
                        {
                            MessageBox.Show("Aucun dépôt de vente par défaut n'est configuré dans les paramètres.", "Erreur de Configuration", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            transaction.Rollback();
                            return;
                        }

                        // 3. Create the new RETURN transaction
                        string insertReturnQuery = @"
                            INSERT INTO Transactions (CustomerID, TransactionDate, TotalAmount, AmountPaid, PaymentStatus, Loan, DiscountAmount, SessionID, CreatedBy, IsReturn, Cash, CreditCard, Cheque, DueDate, TicketID)
                            OUTPUT INSERTED.TransactionID
                            VALUES (@CID, @Date, @Total, @Paid, 'Returned', @Loan, @Discount, @SID, @User, 1, @Cash, @Card, @Cheque, @DueDate, @TicketID)";

                        int newReturnTransactionId;
                        using (var cmdReturn = new SqlCommand(insertReturnQuery, conn, transaction))
                        {
                            cmdReturn.Parameters.AddWithValue("@CID", originalTransaction["CustomerID"]);
                            cmdReturn.Parameters.AddWithValue("@Date", DateTime.Now);
                            cmdReturn.Parameters.AddWithValue("@Total", -Convert.ToDecimal(originalTransaction["TotalAmount"]));
                            cmdReturn.Parameters.AddWithValue("@Paid", -Convert.ToDecimal(originalTransaction["AmountPaid"]));
                            cmdReturn.Parameters.AddWithValue("@Loan", -Convert.ToDecimal(originalTransaction["Loan"]));
                            cmdReturn.Parameters.AddWithValue("@Discount", -Convert.ToDecimal(originalTransaction["DiscountAmount"]));
                            cmdReturn.Parameters.AddWithValue("@SID", this._currentSessionId);
                            cmdReturn.Parameters.AddWithValue("@User", SessionManager.CurrentUser);
                            cmdReturn.Parameters.AddWithValue("@Cash", -Convert.ToDecimal(originalTransaction["Cash"]));
                            cmdReturn.Parameters.AddWithValue("@Card", -Convert.ToDecimal(originalTransaction["CreditCard"]));
                            cmdReturn.Parameters.AddWithValue("@Cheque", -Convert.ToDecimal(originalTransaction["Cheque"]));
                            cmdReturn.Parameters.AddWithValue("@DueDate", originalTransaction["DueDate"] == DBNull.Value ? (object)DBNull.Value : Convert.ToDateTime(originalTransaction["DueDate"]));
                            cmdReturn.Parameters.AddWithValue("@TicketID", originalTransaction["TicketID"] == DBNull.Value ? (object)DBNull.Value : Convert.ToInt32(originalTransaction["TicketID"]));

                            newReturnTransactionId = (int)cmdReturn.ExecuteScalar();
                        }


                        var itemsToReturn = new List<DataRow>();
                        var itemsTable = new DataTable();
                        var cmdGetItems = new SqlCommand("SELECT * FROM TransactionItems WHERE TransactionID = @TID", conn, transaction);
                        cmdGetItems.Parameters.AddWithValue("@TID", originalTransactionId);

                        using (var adapter = new SqlDataAdapter(cmdGetItems))
                        {
                            adapter.Fill(itemsTable);
                        }

                        // 5. NOW, loop through the temporary list and perform updates.
                        foreach (DataRow itemRow in itemsTable.Rows)
                        {
                            int articleId = Convert.ToInt32(itemRow["ArticleID"]);
                            decimal quantity = Convert.ToDecimal(itemRow["Quantity"]);

                            // Add the stock back
                            UpdateStockAndHistory(conn, transaction, articleId, quantity, warehouseToReturnTo, "Return", newReturnTransactionId.ToString());

                            // Insert the negative transaction item
                            string itemQuery = "INSERT INTO TransactionItems (TransactionID, ArticleID, ItemName, Barcode, Quantity, Price, TotalPrice) VALUES (@TID, @ArtID, @Name, @Barcode, @Qty, @Price, @Total)";
                            using (var itemCmd = new SqlCommand(itemQuery, conn, transaction))
                            {
                                itemCmd.Parameters.AddWithValue("@TID", newReturnTransactionId);
                                itemCmd.Parameters.AddWithValue("@ArtID", articleId);
                                itemCmd.Parameters.AddWithValue("@Name", itemRow["ItemName"]);
                                itemCmd.Parameters.AddWithValue("@Barcode", itemRow["Barcode"]);
                                itemCmd.Parameters.AddWithValue("@Qty", -quantity); // Negative quantity
                                itemCmd.Parameters.AddWithValue("@Price", itemRow["Price"]);
                                itemCmd.Parameters.AddWithValue("@Total", -Convert.ToDecimal(itemRow["TotalPrice"])); // Negative total
                                itemCmd.ExecuteNonQuery();
                            }
                        }

                        // 4. Correct the customer's debt
                        UpdateCustomerDebt(conn, transaction, Convert.ToInt32(originalTransaction["CustomerID"]), -Convert.ToDecimal(originalTransaction["Loan"]));
                        
                        // 5. Mark the original transaction as 'Returned'
                        var cmdUpdateOriginal = new SqlCommand("UPDATE Transactions SET PaymentStatus = 'Returned' WHERE TransactionID = @TID", conn, transaction);
                        cmdUpdateOriginal.Parameters.AddWithValue("@TID", originalTransactionId);
                        cmdUpdateOriginal.ExecuteNonQuery();

                        transaction.Commit();
                        MessageBox.Show("Le retour a été traité avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Failed to process return: " + ex.Message, "Error");
                    }
                }
            }
        }
        private void btn_warehousepick_Click(object sender, EventArgs e)
        {
            using (changementWarehouse warehousePicker = new changementWarehouse())
            {
                if (warehousePicker.ShowDialog(this) == DialogResult.OK)
                {
                    _selectedWarehouseId = warehousePicker.SelectedWarehouseId;
                    lbl_warehouse.Text = warehousePicker.SelectedWarehouseName;
                    defaultSaleWarehouseId = _selectedWarehouseId;
                    // Refresh the article list with the new warehouse filter
                    currentPage = 0;
                    LoadArticles();
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            _currentSearchTerm = txtSearch.Text;
            currentPage = 0;
            LoadArticles();
        }

        private void btn_addtoattente_Click(object sender, EventArgs e)
        {
            if (DatagridArticles.Rows.Count == 0) return;

            string query = @"INSERT INTO Ticket (ticket_date, ClientName, total_amount, created_by, validated) 
                     OUTPUT INSERTED.id_ticket 
                     VALUES (@Date, @Client, @Total, @User, 0);"; // validated = 0 means it's on hold

            try
            {
                using (var conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (var transaction = conn.BeginTransaction())
                    {
                        int newTicketId;
                        using (var cmd = new SqlCommand(query, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@Date", DateTime.Now);
                            cmd.Parameters.AddWithValue("@Client", lbl_client.Text);
                            cmd.Parameters.AddWithValue("@Total", decimal.Parse(lbl_total.Text));
                            cmd.Parameters.AddWithValue("@User", SessionManager.CurrentUser);
                            newTicketId = (int)cmd.ExecuteScalar();
                        }

                        // Now save each item to the Attente table
                        foreach (DataGridViewRow row in DatagridArticles.Rows)
                        {
                            if (row.IsNewRow) continue;
                            var item = SaleGridItem.FromRow(row);
                            var itemQuery = "INSERT INTO Attente (id_ticket, ClientName, Barcode, ArticleName, Quantity, SellPrice, Total) VALUES (@TicketID, @ClientName, @Barcode, @ItemName, @Qty, @Price, @Total)";
                            using (var itemCmd = new SqlCommand(itemQuery, conn, transaction))
                            {
                                itemCmd.Parameters.AddWithValue("@TicketID", newTicketId);
                                itemCmd.Parameters.AddWithValue("@ClientName", lbl_client.Text);
                                itemCmd.Parameters.AddWithValue("@Barcode", item.ArticleID);
                                itemCmd.Parameters.AddWithValue("@ItemName", item.ArticleName);
                                itemCmd.Parameters.AddWithValue("@Qty", item.Quantity);
                                itemCmd.Parameters.AddWithValue("@Price", item.SellPrice);
                                itemCmd.Parameters.AddWithValue("@Total", item.TotalPrice);
                                itemCmd.ExecuteNonQuery();
                            }
                        }

                        transaction.Commit();
                        MessageBox.Show("Vente mise en attente avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        NewSale(); // Clear the screen for the next customer
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to save pending sale: " + ex.Message, "Error");
            }
        }
    }
}
