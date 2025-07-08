using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Bunifu.UI.WinForms;
using Newtonsoft.Json;



namespace TAPTAGPOS
{
    public partial class AddArticles : Form
    {
        private string articleId = null;
        private bool isEditMode = false;
        private int currentArticleId = 0;
        private List<string> barcodeList = new List<string>();
        string txtImagePath;

        // In AddArticles.cs
        private void btnBrowseImage_Click()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                openFileDialog.Title = "Select an Article Image";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Get the path of the selected file
                    string imagePath = openFileDialog.FileName;

                    // Display the path in the TextBox
                    txtImagePath = imagePath;

                    // Display a preview of the image in the PictureBox
                    try
                    {
                        picture_article.Image = Image.FromFile(imagePath);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error loading image preview: " + ex.Message);
                        picture_article.Image = null;
                    }
                }
            }
        }
        public AddArticles()
        {
            InitializeComponent();
            SubscribeNumericEvents();
        }
        private void SubscribeNumericEvents()
        {
            // ربط كل مربعات النصوص التي يجب أن تقبل أرقاماً فقط
            var numericTextBoxes = new List<BunifuTextBox>
            {
                txtbuy_PRice, txtearning_detail, txtearning_gros, txtdetails_price,
                txtsemigros_price, txtgros_price, txtspecial_price, txtmin_price,
                txtmax_price, txt_quantitebox, txt_minstock, txt_weight, txtpourcentage_seller,
                ttcbuy_price, ttcDetail_price, ttcgros_price, ttcspecial_price, ttcsemigros_price
            };
            foreach (var txtBox in numericTextBoxes)
            {
                txtBox.KeyPress += NumericTextBox_KeyPress;
            }
        }
        public AddArticles(int articleID) : this() // استدعاء الـ constructor الافتراضي
        {
            currentArticleId = articleID;
            isEditMode = true;
            this.Text = "تعديل المنتوج";
            btn_save.Text = "تعديل";
            LoadArticleDataFromDatabase(currentArticleId);
        }
        private void ShowKeyboardFor(BunifuTextBox targetTextBox)
        {
            using (Keyboard keyboardForm = new Keyboard())
            {
                if (keyboardForm.ShowDialog() == DialogResult.OK)
                {
                    targetTextBox.Text = keyboardForm.EnteredText;
                }
            }
        }
        private void LoadTransactionItems(string[] barcodes)
        {
            string connectionString = DatabaseConnection.GetConnectionString();

            // Clear existing rows
            dataGridViewTransactions.Rows.Clear();

            // Filter out empty or null barcodes
            var validBarcodes = barcodes?.Where(b => !string.IsNullOrWhiteSpace(b)).ToArray();

            if (validBarcodes == null || !validBarcodes.Any())
                return;

            // Build SQL IN clause with parameters
            var barcodeParams = string.Join(",", validBarcodes.Select((b, i) => $"@Barcode{i}"));

            string query = $@"
        SELECT 
            [TransactionID],
            [ItemName],
            [Quantity],
            [Price],
            [TotalPrice],
            [TicketID]
        FROM [TaptagCaisse].[dbo].[TransactionItems]
        WHERE Barcode IN ({barcodeParams})";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // Add each barcode as a parameter
                    for (int i = 0; i < validBarcodes.Length; i++)
                    {
                        cmd.Parameters.AddWithValue($"@Barcode{i}", validBarcodes[i]);
                    }

                    try
                    {
                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int rowIndex = dataGridViewTransactions.Rows.Add();

                                dataGridViewTransactions.Rows[rowIndex].Cells[TransactionID.Index].Value =
                                    reader["TransactionID"];

                                dataGridViewTransactions.Rows[rowIndex].Cells[ItemName.Index].Value =
                                    reader["ItemName"];

                                dataGridViewTransactions.Rows[rowIndex].Cells[Quantity.Index].Value =
                                    reader["Quantity"];

                                dataGridViewTransactions.Rows[rowIndex].Cells[Price.Index].Value =
                                    reader["Price"];

                                dataGridViewTransactions.Rows[rowIndex].Cells[TotalPrice.Index].Value =
                                    reader["TotalPrice"];

                                dataGridViewTransactions.Rows[rowIndex].Cells[TicketID.Index].Value =
                                    reader["TicketID"];
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error loading transaction items: " + ex.Message);
                    }
                }
            }
        }
        private void LoadWarehouseStock(int articleID)
        {
            dgvWarehouseStock.Rows.Clear();
            string query = @"
                SELECT 
                    w.WarehouseID, 
                    w.WarehouseName, 
                    ISNULL(ast.Quantity, 0) as Quantity
                FROM Warehouses w
                LEFT JOIN ArticleStock ast ON w.WarehouseID = ast.WarehouseID AND ast.ArticleID = @ArticleID
                ORDER BY w.WarehouseName";

            try
            {
                using (var conn = new SqlConnection(DatabaseConnection.GetConnectionString()))
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ArticleID", articleID);
                    conn.Open();
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        dgvWarehouseStock.Rows.Add(
                            reader["WarehouseID"],
                            reader["WarehouseName"],
                            reader["Quantity"]
                        );
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ في تحميل كميات المخزون: " + ex.Message);
            }
        }

        private void LoadArticleDataFromDatabase(int articleID)
        {
            string connectionString = DatabaseConnection.GetConnectionString();
            string query = "SELECT * FROM Articles WHERE Id = @ArticleID";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ArticleID", articleID);

                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        if (reader["CategoryID"] != DBNull.Value)
                        {
                            dropdown_Categorie.SelectedValue = reader["CategoryID"];


                        }
                        else
                        {
                            dropdown_Categorie.SelectedIndex = 0; // Select "-- Aucune Catégorie --"
                        }
                        // --- تحميل البيانات الأساسية ---
                        txtarticle.Text = reader["Article"]?.ToString();
                        txtarticlelongname.Text = reader["ArticleLongName"]?.ToString();
                        string imagePath = reader["ImagePath"]?.ToString();
                        txtImagePath = imagePath; // Display the path

                        // --- تحميل بيانات الأسعار والأرباح (باستخدام الأسماء الصحيحة) ---
                        txtbuy_PRice.Text = reader["BuyPrice"]?.ToString();
                        ttcbuy_price.Text = reader["TTCBuyPrice"]?.ToString();
                        txtdetails_price.Text = reader["DetailsPrice"]?.ToString();
                        txtsemigros_price.Text = reader["SemigrosPrice"]?.ToString();
                        txtgros_price.Text = reader["GrosPrice"]?.ToString();
                        txtspecial_price.Text = reader["SpecialPrice"]?.ToString();
                        txtmin_price.Text = reader["MinPrice"]?.ToString();
                        txtmax_price.Text = reader["MaxPrice"]?.ToString();
                        ttcDetail_price.Text = reader["TTCDetailedPrice"]?.ToString(); // لاحظ اختلاف الأسماء
                        ttcgros_price.Text = reader["TTCGrosPrice"]?.ToString();
                        ttcspecial_price.Text = reader["TTCSpecialPrice"]?.ToString();
                        ttcsemigros_price.Text = reader["TTCSemigrosPrice"]?.ToString();
                        txtearning_detail.Text = reader["EarningDetail"]?.ToString();
                        txtearning_semigros.Text = reader["EarningSemigros"]?.ToString();
                        txtearning_gros.Text = reader["EarningGros"]?.ToString();
                        txtearning_special.Text = reader["EarningSpecial"]?.ToString();

                        // --- تحميل بيانات المخزون والتصنيف (باستخدام الأسماء الصحيحة) ---
                        txt_weight.Text = reader["Weight"]?.ToString();
                        txtpourcentage_seller.Text = reader["PercentageSeller"]?.ToString();
                        txt_quantitebox.Text = reader["QuantiteBox"]?.ToString();
                        txt_minstock.Text = reader["MinStock"]?.ToString();
                        dropdown_unite.Text = reader["Unite"]?.ToString();
                        dropdown_tax.Text = reader["Tax"]?.ToString();

                        // --- تحميل الخيارات (Checkboxes) (باستخدام الأسماء الصحيحة) ---
                        if (reader["Sell"] != DBNull.Value)
                            checkBox_sell.Checked = Convert.ToBoolean(reader["Sell"]);
                        if (reader["Buy"] != DBNull.Value)
                            checkBox_buy.Checked = Convert.ToBoolean(reader["Buy"]);

                        // --- تحميل اللون ---
                        string colorFromDb = reader["ArticleColor"]?.ToString();
                        if (!string.IsNullOrEmpty(colorFromDb))
                        {
                            try
                            {
                                pnlColorPreview.BackColor = System.Drawing.ColorTranslator.FromHtml(colorFromDb);
                            }
                            catch
                            {
                                pnlColorPreview.BackColor = Color.Transparent; // Set default color on error
                            }
                        }

                        // --- تحميل الباركود ---
                        string jsonBarcodes = reader["Barcodes"]?.ToString() ?? "[]";
                        try
                        {
                            var barcodeList = JsonConvert.DeserializeObject<List<string>>(jsonBarcodes);
                            dataGridViewBarcodes.DataSource = barcodeList.Select(b => new { Barcode = b }).ToList();

                            if (barcodeList.Any())
                            {
                                // LoadTransactionItems(barcodeList.ToArray()); // You might need this method
                            }
                            else
                            {
                                // dataGridViewTransactions.DataSource = null;
                            }
                        }
                        catch { /* Handle JSON errors silently or show a message */ }

                        // --- تحميل الصورة ---
                        if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
                        {
                            try
                            {
                                picture_article.Image = Image.FromFile(imagePath);
                            }
                            catch
                            {
                                picture_article.Image = null; // Set to null if the image file is corrupt or unreadable
                            }
                        }
                        LoadWarehouseStock(articleID);
                        // --- ضبط الواجهة لوضع التعديل ---
                        btn_save.Text = "تعديل";
                        this.Text = "تعديل المنتوج";
                    }
                    else
                    {
                        MessageBox.Show("لم يتم العثور على المنتوج.");
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("حدث خطأ أثناء تحميل بيانات المنتوج: " + ex.Message);
                }
            }
        }
        private void NumericTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox;

            // Check if the pressed key is a digit, comma, backspace, or decimal separator
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true; // Block the key press if it's not allowed
            }

            // Allow only one decimal separator (either ',' or '.') in the TextBox
            if ((e.KeyChar == ',' || e.KeyChar == '.') && (textBox.Text.Contains(",") || textBox.Text.Contains(".")))
            {
                e.Handled = true; // Block the key press if a separator already exists
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void AddParameters(SqlCommand cmd,
    string article, string articleLongName, string barcode1, string barcode2, string barcode3, string barcode4,
    string barcode5, string barcode6, string barcode7, string barcode8, decimal buyPrice, decimal ttcBuyPrice,
    decimal detailsPrice, decimal semigrosPrice, decimal grosPrice, decimal specialPrice, decimal minPrice,
    decimal maxPrice, decimal ttcDetailedPrice, decimal ttcGrosPrice, decimal ttcSpecialPrice, decimal ttcSemigrosPrice,
    decimal earningDetail, decimal earningSemigros, decimal earningGros, decimal earningSpecial, decimal weight,
    decimal percentageSeller, int quantiteBox, int minStock, int stock, string unite, string tax, string categorie,
    bool sell, bool buy, byte[] articlePicture)
        {
            cmd.Parameters.AddWithValue("@Article", article);
            cmd.Parameters.AddWithValue("@ArticleLongName", articleLongName);
            cmd.Parameters.AddWithValue("@Barcode1", barcode1);
            cmd.Parameters.AddWithValue("@Barcode2", barcode2);
            cmd.Parameters.AddWithValue("@Barcode3", barcode3);
            cmd.Parameters.AddWithValue("@Barcode4", barcode4);
            cmd.Parameters.AddWithValue("@Barcode5", barcode5);
            cmd.Parameters.AddWithValue("@Barcode6", barcode6);
            cmd.Parameters.AddWithValue("@Barcode7", barcode7);
            cmd.Parameters.AddWithValue("@Barcode8", barcode8);
            cmd.Parameters.AddWithValue("@BuyPrice", buyPrice);
            cmd.Parameters.AddWithValue("@TTCBuyPrice", ttcBuyPrice);
            cmd.Parameters.AddWithValue("@DetailsPrice", detailsPrice);
            cmd.Parameters.AddWithValue("@SemigrosPrice", semigrosPrice);
            cmd.Parameters.AddWithValue("@GrosPrice", grosPrice);
            cmd.Parameters.AddWithValue("@SpecialPrice", specialPrice);
            cmd.Parameters.AddWithValue("@MinPrice", minPrice);
            cmd.Parameters.AddWithValue("@MaxPrice", maxPrice);
            cmd.Parameters.AddWithValue("@TTCDetailedPrice", ttcDetailedPrice);
            cmd.Parameters.AddWithValue("@TTCGrosPrice", ttcGrosPrice);
            cmd.Parameters.AddWithValue("@TTCSpecialPrice", ttcSpecialPrice);
            cmd.Parameters.AddWithValue("@TTCSemigrosPrice", ttcSemigrosPrice);
            cmd.Parameters.AddWithValue("@EarningDetail", earningDetail);
            cmd.Parameters.AddWithValue("@EarningSemigros", earningSemigros);
            cmd.Parameters.AddWithValue("@EarningGros", earningGros);
            cmd.Parameters.AddWithValue("@EarningSpecial", earningSpecial);
            cmd.Parameters.AddWithValue("@Weight", weight);
            cmd.Parameters.AddWithValue("@PercentageSeller", percentageSeller);
            cmd.Parameters.AddWithValue("@QuantiteBox", quantiteBox);
            cmd.Parameters.AddWithValue("@MinStock", minStock);
            cmd.Parameters.AddWithValue("@Stock", stock);
            cmd.Parameters.AddWithValue("@Unite", unite);
            cmd.Parameters.AddWithValue("@Tax", tax);
            cmd.Parameters.AddWithValue("@Categorie", categorie);
            cmd.Parameters.AddWithValue("@Sell", sell);
            cmd.Parameters.AddWithValue("@Buy", buy);
            cmd.Parameters.AddWithValue("@ArticlePicture", (object)articlePicture ?? DBNull.Value);
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string connectionString = DatabaseConnection.connectionString;
            // --- 1. Validation ---
            if (string.IsNullOrWhiteSpace(txtarticle.Text))
            {
                MessageBox.Show("الرجاء إدخال اسم المنتوج.", "بيانات ناقصة", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // --- 2. Gather all data from the UI ---
            var articleData = GatherDataFromUI();

            // --- 3. Database Transaction ---
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlTransaction transaction = conn.BeginTransaction())
                {
                        int targetArticleId = this.currentArticleId;
                        string query;

                        if (isEditMode)
                        {
                            // --- START OF FIX: This UPDATE query is now complete ---
                            query = @"UPDATE Articles SET 
                                Article=@Article, ArticleLongName=@ArticleLongName, Barcodes=@Barcodes, BuyPrice=@BuyPrice, 
                                TTCBuyPrice=@TTCBuyPrice, DetailsPrice=@DetailsPrice, SemigrosPrice=@SemigrosPrice, 
                                GrosPrice=@GrosPrice, SpecialPrice=@SpecialPrice, MinPrice=@MinPrice, MaxPrice=@MaxPrice, 
                                TTCDetailedPrice=@TTCDetailedPrice, TTCGrosPrice=@TTCGrosPrice, TTCSpecialPrice=@TTCSpecialPrice, 
                                TTCSemigrosPrice=@TTCSemigrosPrice, EarningDetail=@EarningDetail, EarningSemigros=@EarningSemigros, 
                                EarningGros=@EarningGros, EarningSpecial=@EarningSpecial, Weight=@Weight, 
                                PercentageSeller=@PercentageSeller, QuantiteBox=@QuantiteBox, MinStock=@MinStock, 
                                Unite=@Unite, Tax=@Tax, CategoryID=@CategoryID, Sell=@Sell, Buy=@Buy, 
                                ArticlePicture=@ArticlePicture, ArticleColor=@ArticleColor , ImagePath=@ImagePath 
                              WHERE Id = @Id";
                        }
                        else
                        {
                            // --- START OF FIX: This INSERT query is now complete ---
                            query = @"INSERT INTO Articles (
                                Article, ArticleLongName, Barcodes, BuyPrice, TTCBuyPrice, DetailsPrice, SemigrosPrice, 
                                GrosPrice, SpecialPrice, MinPrice, MaxPrice, TTCDetailedPrice, TTCGrosPrice, 
                                TTCSpecialPrice, TTCSemigrosPrice, EarningDetail, EarningSemigros, EarningGros, 
                                EarningSpecial, Weight, PercentageSeller, QuantiteBox, MinStock, Unite, Tax, 
                                CategoryID, Sell, Buy, ArticlePicture, QuantityStock, IsActive, ArticleColor,ImagePath
                              ) VALUES (
                                @Article, @ArticleLongName, @Barcodes, @BuyPrice, @TTCBuyPrice, @DetailsPrice, @SemigrosPrice, 
                                @GrosPrice, @SpecialPrice, @MinPrice, @MaxPrice, @TTCDetailedPrice, @TTCGrosPrice, 
                                @TTCSpecialPrice, @TTCSemigrosPrice, @EarningDetail, @EarningSemigros, @EarningGros, 
                                @EarningSpecial, @Weight, @PercentageSeller, @QuantiteBox, @MinStock, @Unite, @Tax, 
                                @CategoryID, @Sell, @Buy, @ArticlePicture, 0, 1, @ArticleColor, @ImagePath
                              ); SELECT SCOPE_IDENTITY();";
                        }

                        using (var cmd = new SqlCommand(query, conn, transaction))
                        {
                            // The AddParametersToCommand helper method will add all the values
                            AddParametersToCommand(cmd, articleData);

                            if (isEditMode)
                            {
                                cmd.Parameters.AddWithValue("@Id", targetArticleId);
                                cmd.ExecuteNonQuery();
                            }
                            else
                            {
                                targetArticleId = Convert.ToInt32(cmd.ExecuteScalar());
                            }
                        }

                        SaveWarehouseStock(conn, transaction, targetArticleId);
                        UpdateTotalStockInArticlesTable(conn, transaction, targetArticleId);

                        transaction.Commit();
                        MessageBox.Show(isEditMode ? "تم تعديل المنتوج بنجاح!" : "تم حفظ المنتوج بنجاح!", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    
                   
                }
            }
        }
        private Dictionary<string, object> GatherDataFromUI()
        {
            var data = new Dictionary<string, object>
            {
                ["Article"] = txtarticle.Text,
                ["ArticleLongName"] = txtarticlelongname.Text,
                ["Barcodes"] = JsonConvert.SerializeObject(barcodeList),
                ["BuyPrice"] = ParseDecimal(txtbuy_PRice.Text),
                ["TTCBuyPrice"] = ParseDecimal(ttcbuy_price.Text),
                ["DetailsPrice"] = ParseDecimal(txtdetails_price.Text),
                ["SemigrosPrice"] = ParseDecimal(txtsemigros_price.Text),
                ["CategoryID"] = (dropdown_Categorie.SelectedValue != null && dropdown_Categorie.SelectedValue != DBNull.Value)
                         ? dropdown_Categorie.SelectedValue
                         : (object)DBNull.Value,

                ["GrosPrice"] = ParseDecimal(txtgros_price.Text),
                ["SpecialPrice"] = ParseDecimal(txtspecial_price.Text),
                ["MinPrice"] = ParseDecimal(txtmin_price.Text),
                ["MaxPrice"] = ParseDecimal(txtmax_price.Text),
                ["TTCDetailedPrice"] = ParseDecimal(ttcDetail_price.Text),
                ["TTCGrosPrice"] = ParseDecimal(ttcgros_price.Text),
                ["TTCSpecialPrice"] = ParseDecimal(ttcspecial_price.Text),
                ["TTCSemigrosPrice"] = ParseDecimal(ttcsemigros_price.Text),
                ["EarningDetail"] = ParseDecimal(txtearning_detail.Text),
                ["EarningSemigros"] = ParseDecimal(txtearning_semigros.Text),
                ["EarningGros"] = ParseDecimal(txtearning_gros.Text),
                ["EarningSpecial"] = ParseDecimal(txtearning_special.Text),
                ["Weight"] = ParseDecimal(txt_weight.Text),
                ["PercentageSeller"] = ParseDecimal(txtpourcentage_seller.Text),
                ["QuantiteBox"] = ParseInt(txt_quantitebox.Text),
                ["MinStock"] = ParseInt(txt_minstock.Text),
                ["Unite"] = dropdown_unite.Text,
                ["Tax"] = dropdown_tax.Text,
                ["Categorie"] = dropdown_Categorie.Text,
                ["Sell"] = checkBox_sell.Checked,
                ["Buy"] = checkBox_buy.Checked,
                ["ArticleColor"] = ColorTranslator.ToHtml(pnlColorPreview.BackColor),
                ["ImagePath"] = txtImagePath
            };

            byte[] articlePicture = null;
            if (picture_article.Image != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    picture_article.Image.Save(ms, ImageFormat.Png);
                    articlePicture = ms.ToArray();
                }
            }
            data["ArticlePicture"] = (object)articlePicture ?? DBNull.Value;

            return data;
        }

        // دالة جديدة لإضافة الـ Parameters لتقليل التكرار
        private void AddParametersToCommand(SqlCommand cmd, Dictionary<string, object> data)
        {
            // حذف Parameters التي لا نحتاجها في الاستعلام الرئيسي
            data.Remove("QuantityStock");

            foreach (var entry in data)
            {
                // التعامل مع الصور بشكل خاص
                if (entry.Key == "ArticlePicture")
                {
                    cmd.Parameters.Add(new SqlParameter("@ArticlePicture", SqlDbType.VarBinary, -1) { Value = entry.Value });
                    cmd.Parameters.AddWithValue($"@{entry.Key}", entry.Value ?? DBNull.Value);

                }
                else
                {
                    cmd.Parameters.AddWithValue($"@{entry.Key}", entry.Value ?? DBNull.Value);
                }
            }
        }

        // دالة جديدة لحفظ الكميات في جدول ArticleStock
        private void SaveWarehouseStock(SqlConnection conn, SqlTransaction transaction, int articleId)
        {
            // جملة MERGE تقوم بعمل UPDATE إذا كان السجل موجوداً، و INSERT إذا لم يكن موجوداً
            string mergeQuery = @"
        MERGE ArticleStock AS target
        USING (SELECT @WarehouseID AS WarehouseID, @Quantity AS Quantity) AS source
        ON (target.ArticleID = @ArticleID AND target.WarehouseID = source.WarehouseID)
        WHEN MATCHED THEN 
            UPDATE SET Quantity = source.Quantity
        WHEN NOT MATCHED BY TARGET THEN
            INSERT (ArticleID, WarehouseID, Quantity)
            VALUES (@ArticleID, source.WarehouseID, source.Quantity);";

            foreach (DataGridViewRow row in dgvWarehouseStock.Rows)
            {
                if (row.IsNewRow || row.Cells["WarehouseID"].Value == null) continue;

                int warehouseId = Convert.ToInt32(row.Cells["WarehouseID"].Value);
                decimal quantity = ParseDecimal(row.Cells["QuantityEdit"].Value?.ToString());

                using (var cmd = new SqlCommand(mergeQuery, conn, transaction))
                {
                    cmd.Parameters.AddWithValue("@ArticleID", articleId);
                    cmd.Parameters.AddWithValue("@WarehouseID", warehouseId);
                    cmd.Parameters.AddWithValue("@Quantity", quantity);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // دالة جديدة لتحديث المجموع في جدول Articles
        private void UpdateTotalStockInArticlesTable(SqlConnection conn, SqlTransaction transaction, int articleId)
        {
            string query = @"
        UPDATE Articles
        SET QuantityStock = (SELECT ISNULL(SUM(Quantity), 0) FROM ArticleStock WHERE ArticleID = @ArticleID)
        WHERE Id = @ArticleID";

            using (var cmd = new SqlCommand(query, conn, transaction))
            {
                cmd.Parameters.AddWithValue("@ArticleID", articleId);
                cmd.ExecuteNonQuery();
            }
        }

        // دوال مساعدة لتحويل النصوص إلى أرقام بشكل آمن
        private decimal ParseDecimal(string text)
        {
            return decimal.TryParse(text.Replace(",", "."), System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out var result) ? result : 0;
        }

        private int ParseInt(string text)
        {
            return int.TryParse(text, out var result) ? result : 0;
        }
        // دالة جديدة لإضافة الـ Parameters لتقليل التكرار

        private void UpdateAllPrices()
        {
            decimal buyPrice = ParseDecimal(txtbuy_PRice.Text);
            decimal taxPercent = ParseDecimal(dropdown_tax.Text);
            if (buyPrice == 0) return;

            // Calculate TTC Buy Price
            decimal ttcBuy = buyPrice * (1 + (taxPercent / 100));
            ttcbuy_price.Text = ttcBuy.ToString("F2");

            // Calculate other prices based on earnings
            UpdateSinglePrice(txtearning_detail, txtdetails_price, ttcDetail_price, ttcBuy, taxPercent);
            UpdateSinglePrice(txtearning_semigros, txtsemigros_price, ttcsemigros_price, ttcBuy, taxPercent);
            UpdateSinglePrice(txtearning_gros, txtgros_price, ttcgros_price, ttcBuy, taxPercent);
            UpdateSinglePrice(txtearning_special, txtspecial_price, ttcspecial_price, ttcBuy, taxPercent);
        }
        private void UpdateSinglePrice(BunifuTextBox earningBox, BunifuTextBox priceBox, BunifuTextBox ttcPriceBox, decimal ttcBuy, decimal taxPercent)
        {
            decimal earningPercent = ParseDecimal(earningBox.Text);
            if (earningPercent > 0)
            {
                decimal price = ttcBuy * (1 + (earningPercent / 100));
                priceBox.Text = price.ToString("F2");

                decimal ttcPrice = price * (1 + (taxPercent / 100));
                ttcPriceBox.Text = ttcPrice.ToString("F2");
            }
        }
        private void txtbuy_PRice_Leave(object sender, EventArgs e) => UpdateAllPrices();
        private void txtearning_detail_Leave(object sender, EventArgs e) => UpdateAllPrices();
        private void txtearning_semigros_Leave(object sender, EventArgs e) => UpdateAllPrices();
        private void txtearning_gros_Leave(object sender, EventArgs e) => UpdateAllPrices();
        private void txtearning_special_Leave(object sender, EventArgs e) => UpdateAllPrices();
        private void dropdown_tax_SelectedIndexChanged(object sender, EventArgs e) => UpdateAllPrices();

        private void bunifuImageButton_Keyboard_Click(object sender, EventArgs e)
        {
            var btn = sender as BunifuImageButton;
            // يمكنك تحديد المربع المستهدف بناءً على اسم الزر أو أي خاصية أخرى
            // هذا مثال بسيط، يمكنك تحسينه
            if (btn == bunifuImageButton18) ShowKeyboardFor(txtarticle);
            else if (btn == bunifuImageButton19) ShowKeyboardFor(txtarticlelongname);
            // ... وهكذا
        }
        private void txtbuy_PRice_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the pressed key is a digit, comma, backspace, or the decimal separator
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true; // Block the key press if it's not allowed
            }

            // Allow only one decimal separator (either ',' or '.') in the TextBox
            if ((e.KeyChar == ',' || e.KeyChar == '.') && (txtbuy_PRice.Text.Contains(",") || txtbuy_PRice.Text.Contains(".")))
            {
                e.Handled = true; // Block the key press if a separator already exists
            }
        }

        private void AddCat_Click(object sender, EventArgs e)
        {
            OverlayForm overlay = new OverlayForm(this);
            overlay.Show();

            // Create and show the centered Category form
            Category categoryForm = new Category();
            categoryForm.StartPosition = FormStartPosition.CenterScreen;

            // Attach an event to close the overlay and refocus the main form when Category closes
            categoryForm.FormClosed += (s, args) =>
            {
                overlay.Close();        // Close the overlay form
                this.Activate();        // Bring main form back to focus                                       
                LoadCategoriesIntoDropdown();     // Reload categories in the dropdown when the Category form is closed
            };

            // Show the Category form as a dialog
            categoryForm.ShowDialog();
        }
        private void CategoryForm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
        private void LoadCategoriesIntoDropdown()
        {
            try
            {
                string connectionString = DatabaseConnection.GetConnectionString();

                var dt = new DataTable();
                using (var conn = new SqlConnection(connectionString))
                {
                    // Note: Uses the correct table name 'ArticleCategories'
                    var query = "SELECT CategoryID, CategoryName FROM ArticleCategories WHERE IsActive = 1 ORDER BY CategoryName";
                    new SqlDataAdapter(query, conn).Fill(dt);
                }

                DataRow dr = dt.NewRow();
                dr["CategoryID"] = DBNull.Value; // Use DBNull for the "no category" option
                dr["CategoryName"] = "-- Aucune Catégorie --";
                dt.Rows.InsertAt(dr, 0);

                dropdown_Categorie.DataSource = dt;
                dropdown_Categorie.DisplayMember = "CategoryName";
                dropdown_Categorie.ValueMember = "CategoryID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur chargement des catégories: " + ex.Message);
            }
        }
        private void AddArticles_Load(object sender, EventArgs e)
        {
            dropdown_tax.SelectedIndex = 0;
            LoadCategoriesIntoDropdown();
            bunifuPages1.SelectedTab = tabPage1;
            if (isEditMode)
            {
                this.Text = "Modifier l'Article";
                btn_save.Text = "Modifier";
                LoadArticleDataFromDatabase(currentArticleId);
            }
            else
            {
                this.Text = "Ajouter un Article";
                btn_save.Text = "Enregistrer";
                LoadWarehouseStock(0); // Load with 0 stock for a new item
            }
        }

        private void btn_uploadpicture_Click(object sender, EventArgs e)
        {
            // Create and configure an OpenFileDialog to select an image
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif;*.tiff";  // Restrict to image files
            openFileDialog.Title = "Select Article Image";

            // Show the dialog and check if the user selected a file
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Load the selected image into the PictureBox
                    picture_article.Image = Image.FromFile(openFileDialog.FileName);
                    btnBrowseImage_Click();
                }
                catch (Exception ex)
                {
                    // Handle any errors in loading the image
                    MessageBox.Show($"Error loading image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void txtdetails_price_Leave(object sender, EventArgs e) => UpdateAllPrices();

        private void bunifuImageButton18_Click(object sender, EventArgs e)
        {
            Keyboard keyboardForm = new Keyboard();

            // Show the keyboard form as a modal dialog
            if (keyboardForm.ShowDialog() == DialogResult.OK)  // If the user presses OK (or any custom logic you define)
            {
                // Get the entered text from the KeyboardForm
                string enteredText = keyboardForm.EnteredText;

                // Use the entered text (e.g., store it in a variable, assign it to a TextBox, etc.)
                txtarticle.Text = enteredText;  // Assign the entered text to a TextBox on the parent form
            }
        }

        private void bunifuImageButton19_Click(object sender, EventArgs e)
        {
            Keyboard keyboardForm = new Keyboard();

            // Show the keyboard form as a modal dialog
            if (keyboardForm.ShowDialog() == DialogResult.OK)  // If the user presses OK (or any custom logic you define)
            {
                // Get the entered text from the KeyboardForm
                string enteredText = keyboardForm.EnteredText;

                // Use the entered text (e.g., store it in a variable, assign it to a TextBox, etc.)
                txtarticlelongname.Text = enteredText;  // Assign the entered text to a TextBox on the parent form
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Keyboard keyboardForm = new Keyboard();

            // Show the keyboard form as a modal dialog
            if (keyboardForm.ShowDialog() == DialogResult.OK)  // If the user presses OK (or any custom logic you define)
            {
                // Get the entered text from the KeyboardForm
                string enteredText = keyboardForm.EnteredText;

                // Use the entered text (e.g., store it in a variable, assign it to a TextBox, etc.)
                txt_quantitebox.Text = enteredText;  // Assign the entered text to a TextBox on the parent form
            }
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            Keyboard keyboardForm = new Keyboard();

            // Show the keyboard form as a modal dialog
            if (keyboardForm.ShowDialog() == DialogResult.OK)  // If the user presses OK (or any custom logic you define)
            {
                // Get the entered text from the KeyboardForm
                string enteredText = keyboardForm.EnteredText;

                // Use the entered text (e.g., store it in a variable, assign it to a TextBox, etc.)
                txtbuy_PRice.Text = enteredText;  // Assign the entered text to a TextBox on the parent form
            }
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            Keyboard keyboardForm = new Keyboard();

            // Show the keyboard form as a modal dialog
            if (keyboardForm.ShowDialog() == DialogResult.OK)  // If the user presses OK (or any custom logic you define)
            {
                // Get the entered text from the KeyboardForm
                string enteredText = keyboardForm.EnteredText;

                // Use the entered text (e.g., store it in a variable, assign it to a TextBox, etc.)
                txtearning_detail.Text = enteredText;  // Assign the entered text to a TextBox on the parent form
            }
        }

        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {
            Keyboard keyboardForm = new Keyboard();

            // Show the keyboard form as a modal dialog
            if (keyboardForm.ShowDialog() == DialogResult.OK)  // If the user presses OK (or any custom logic you define)
            {
                // Get the entered text from the KeyboardForm
                string enteredText = keyboardForm.EnteredText;

                // Use the entered text (e.g., store it in a variable, assign it to a TextBox, etc.)
                txtearning_gros.Text = enteredText;  // Assign the entered text to a TextBox on the parent form
            }
        }

        private void bunifuImageButton8_Click(object sender, EventArgs e)
        {
            Keyboard keyboardForm = new Keyboard();

            // Show the keyboard form as a modal dialog
            if (keyboardForm.ShowDialog() == DialogResult.OK)  // If the user presses OK (or any custom logic you define)
            {
                // Get the entered text from the KeyboardForm
                string enteredText = keyboardForm.EnteredText;

                // Use the entered text (e.g., store it in a variable, assign it to a TextBox, etc.)
                txtdetails_price.Text = enteredText;  // Assign the entered text to a TextBox on the parent form
            }
        }

        private void bunifuImageButton10_Click(object sender, EventArgs e)
        {
            Keyboard keyboardForm = new Keyboard();

            // Show the keyboard form as a modal dialog
            if (keyboardForm.ShowDialog() == DialogResult.OK)  // If the user presses OK (or any custom logic you define)
            {
                // Get the entered text from the KeyboardForm
                string enteredText = keyboardForm.EnteredText;

                // Use the entered text (e.g., store it in a variable, assign it to a TextBox, etc.)
                txtsemigros_price.Text = enteredText;  // Assign the entered text to a TextBox on the parent form
            }
        }

        private void bunifuImageButton12_Click(object sender, EventArgs e)
        {
            Keyboard keyboardForm = new Keyboard();

            // Show the keyboard form as a modal dialog
            if (keyboardForm.ShowDialog() == DialogResult.OK)  // If the user presses OK (or any custom logic you define)
            {
                // Get the entered text from the KeyboardForm
                string enteredText = keyboardForm.EnteredText;

                // Use the entered text (e.g., store it in a variable, assign it to a TextBox, etc.)
                txtgros_price.Text = enteredText;  // Assign the entered text to a TextBox on the parent form
            }
        }

        private void bunifuImageButton14_Click(object sender, EventArgs e)
        {
            Keyboard keyboardForm = new Keyboard();

            // Show the keyboard form as a modal dialog
            if (keyboardForm.ShowDialog() == DialogResult.OK)  // If the user presses OK (or any custom logic you define)
            {
                // Get the entered text from the KeyboardForm
                string enteredText = keyboardForm.EnteredText;

                // Use the entered text (e.g., store it in a variable, assign it to a TextBox, etc.)
                txtspecial_price.Text = enteredText;  // Assign the entered text to a TextBox on the parent form
            }
        }

        private void bunifuImageButton16_Click(object sender, EventArgs e)
        {
            Keyboard keyboardForm = new Keyboard();

            // Show the keyboard form as a modal dialog
            if (keyboardForm.ShowDialog() == DialogResult.OK)  // If the user presses OK (or any custom logic you define)
            {
                // Get the entered text from the KeyboardForm
                string enteredText = keyboardForm.EnteredText;

                // Use the entered text (e.g., store it in a variable, assign it to a TextBox, etc.)
                txtmin_price.Text = enteredText;  // Assign the entered text to a TextBox on the parent form
            }
        }

        private void bunifuImageButton17_Click(object sender, EventArgs e)
        {
            Keyboard keyboardForm = new Keyboard();

            // Show the keyboard form as a modal dialog
            if (keyboardForm.ShowDialog() == DialogResult.OK)  // If the user presses OK (or any custom logic you define)
            {
                // Get the entered text from the KeyboardForm
                string enteredText = keyboardForm.EnteredText;

                // Use the entered text (e.g., store it in a variable, assign it to a TextBox, etc.)
                txtmax_price.Text = enteredText;  // Assign the entered text to a TextBox on the parent form
            }
        }

        private void bunifuImageButton15_Click(object sender, EventArgs e)
        {
            Keyboard keyboardForm = new Keyboard();

            // Show the keyboard form as a modal dialog
            if (keyboardForm.ShowDialog() == DialogResult.OK)  // If the user presses OK (or any custom logic you define)
            {
                // Get the entered text from the KeyboardForm
                string enteredText = keyboardForm.EnteredText;

                // Use the entered text (e.g., store it in a variable, assign it to a TextBox, etc.)
                ttcspecial_price.Text = enteredText;  // Assign the entered text to a TextBox on the parent form
            }
        }

        private void bunifuImageButton13_Click(object sender, EventArgs e)
        {
            Keyboard keyboardForm = new Keyboard();

            // Show the keyboard form as a modal dialog
            if (keyboardForm.ShowDialog() == DialogResult.OK)  // If the user presses OK (or any custom logic you define)
            {
                // Get the entered text from the KeyboardForm
                string enteredText = keyboardForm.EnteredText;

                // Use the entered text (e.g., store it in a variable, assign it to a TextBox, etc.)
                ttcgros_price.Text = enteredText;  // Assign the entered text to a TextBox on the parent form
            }
        }

        private void bunifuImageButton11_Click(object sender, EventArgs e)
        {
            Keyboard keyboardForm = new Keyboard();

            // Show the keyboard form as a modal dialog
            if (keyboardForm.ShowDialog() == DialogResult.OK)  // If the user presses OK (or any custom logic you define)
            {
                // Get the entered text from the KeyboardForm
                string enteredText = keyboardForm.EnteredText;

                // Use the entered text (e.g., store it in a variable, assign it to a TextBox, etc.)
                ttcsemigros_price.Text = enteredText;  // Assign the entered text to a TextBox on the parent form
            }
        }

        private void bunifuImageButton9_Click(object sender, EventArgs e)
        {
            Keyboard keyboardForm = new Keyboard();

            // Show the keyboard form as a modal dialog
            if (keyboardForm.ShowDialog() == DialogResult.OK)  // If the user presses OK (or any custom logic you define)
            {
                // Get the entered text from the KeyboardForm
                string enteredText = keyboardForm.EnteredText;

                // Use the entered text (e.g., store it in a variable, assign it to a TextBox, etc.)
                ttcDetail_price.Text = enteredText;  // Assign the entered text to a TextBox on the parent form
            }
        }

        private void bunifuImageButton7_Click(object sender, EventArgs e)
        {
            Keyboard keyboardForm = new Keyboard();

            // Show the keyboard form as a modal dialog
            if (keyboardForm.ShowDialog() == DialogResult.OK)  // If the user presses OK (or any custom logic you define)
            {
                // Get the entered text from the KeyboardForm
                string enteredText = keyboardForm.EnteredText;

                // Use the entered text (e.g., store it in a variable, assign it to a TextBox, etc.)
                txtearning_special.Text = enteredText;  // Assign the entered text to a TextBox on the parent form
            }
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            Keyboard keyboardForm = new Keyboard();

            // Show the keyboard form as a modal dialog
            if (keyboardForm.ShowDialog() == DialogResult.OK)  // If the user presses OK (or any custom logic you define)
            {
                // Get the entered text from the KeyboardForm
                string enteredText = keyboardForm.EnteredText;

                // Use the entered text (e.g., store it in a variable, assign it to a TextBox, etc.)
                txtearning_semigros.Text = enteredText;  // Assign the entered text to a TextBox on the parent form
            }
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            Keyboard keyboardForm = new Keyboard();

            // Show the keyboard form as a modal dialog
            if (keyboardForm.ShowDialog() == DialogResult.OK)  // If the user presses OK (or any custom logic you define)
            {
                // Get the entered text from the KeyboardForm
                string enteredText = keyboardForm.EnteredText;

                // Use the entered text (e.g., store it in a variable, assign it to a TextBox, etc.)
                ttcbuy_price.Text = enteredText;  // Assign the entered text to a TextBox on the parent form
            }
        }

        private void bunifuImageButton22_Click(object sender, EventArgs e)
        {
            Keyboard keyboardForm = new Keyboard();

            // Show the keyboard form as a modal dialog
            if (keyboardForm.ShowDialog() == DialogResult.OK)  // If the user presses OK (or any custom logic you define)
            {
                // Get the entered text from the KeyboardForm
                string enteredText = keyboardForm.EnteredText;

                // Use the entered text (e.g., store it in a variable, assign it to a TextBox, etc.)
                txt_weight.Text = enteredText;  // Assign the entered text to a TextBox on the parent form
            }
        }

        private void bunifuImageButton20_Click(object sender, EventArgs e)
        {
            Keyboard keyboardForm = new Keyboard();

            // Show the keyboard form as a modal dialog
            if (keyboardForm.ShowDialog() == DialogResult.OK)  // If the user presses OK (or any custom logic you define)
            {
                // Get the entered text from the KeyboardForm
                string enteredText = keyboardForm.EnteredText;

                // Use the entered text (e.g., store it in a variable, assign it to a TextBox, etc.)
                txt_minstock.Text = enteredText;  // Assign the entered text to a TextBox on the parent form
            }
        }

        private void bunifuImageButton21_Click(object sender, EventArgs e)
        {
            Keyboard keyboardForm = new Keyboard();

            // Show the keyboard form as a modal dialog
            if (keyboardForm.ShowDialog() == DialogResult.OK)  // If the user presses OK (or any custom logic you define)
            {
                // Get the entered text from the KeyboardForm
                string enteredText = keyboardForm.EnteredText;

                // Use the entered text (e.g., store it in a variable, assign it to a TextBox, etc.)
                txtpourcentage_seller.Text = enteredText + " %";  // Assign the entered text to a TextBox on the parent form
            }
        }















        private void bunifuImageButton23_Click(object sender, EventArgs e)
        {
            // الخطوة 1: التأكد من أن المستخدم قد حدد صفاً (مخزناً) في الجدول
            if (dgvWarehouseStock.SelectedRows.Count == 0)
            {
                MessageBox.Show("الرجاء تحديد مخزن من الجدول أولاً.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // الحصول على الصف المحدد
            DataGridViewRow selectedRow = dgvWarehouseStock.SelectedRows[0];

            // الخطوة 2: فتح لوحة المفاتيح
            using (Keyboard keyboardForm = new Keyboard())
            {
                if (keyboardForm.ShowDialog() == DialogResult.OK)
                {
                    // الحصول على النص المدخل
                    string enteredText = keyboardForm.EnteredText;

                    // الخطوة 3: التحقق من أن القيمة المدخلة هي رقم صحيح
                    if (int.TryParse(enteredText, out int newQuantity))
                    {
                        // الخطوة 4: تحديث قيمة خلية الكمية في الصف المحدد
                        selectedRow.Cells["QuantityEdit"].Value = newQuantity;
                    }
                    else
                    {
                        MessageBox.Show("الرجاء إدخال كمية رقمية صحيحة.", "خطأ في الإدخال", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }
        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            bunifuPages1.SelectedTab = tabPage1;
        }

        private void bunifuButton22_Click(object sender, EventArgs e)
        {
            bunifuPages1.SelectedTab = tabPage2;
        }

        private void btn_cancelpicture_Click(object sender, EventArgs e)
        {
            picture_article.Image = null;
        }

        private void txtearning_detail_Leave_1(object sender, EventArgs e)
        {
            if (txtbuy_PRice.Text != string.Empty)
            {
                txtdetails_price.Text = (float.Parse(ttcbuy_price.Text) + (float.Parse(txtearning_detail.Text) / 100) * float.Parse(ttcbuy_price.Text)).ToString();
                ttcDetail_price.Text = (float.Parse(txtdetails_price.Text) + float.Parse(dropdown_tax.Text) * float.Parse(txtdetails_price.Text) / 100).ToString();

            }
        }





        private void bunifuButton23_Click(object sender, EventArgs e)
        {
            bunifuPages1.SelectedTab = tabPage3;

        }

        private void btnAddBarcode_Click(object sender, EventArgs e)
        {
            string barcode = txtNewBarcode.Text.Trim();

            if (string.IsNullOrWhiteSpace(barcode))
            {
                MessageBox.Show("Enter a valid barcode.");
                return;
            }

            if (barcodeList.Contains(barcode))
            {
                MessageBox.Show("Barcode already exists.");
                return;
            }

            barcodeList.Add(barcode);
            dataGridViewBarcodes.DataSource = null;
            dataGridViewBarcodes.DataSource = barcodeList.Select(b => new { Barcode = b }).ToList();

            txtNewBarcode.Clear();
            txtNewBarcode.Focus();
        }

        private void txtNewBarcode_DoubleClick(object sender, EventArgs e)
        {
            Keyboard keyboardForm = new Keyboard();

            // Show the keyboard form as a modal dialog
            if (keyboardForm.ShowDialog() == DialogResult.OK)  // If the user presses OK (or any custom logic you define)
            {
                // Get the entered text from the KeyboardForm
                string enteredText = keyboardForm.EnteredText;

                // Use the entered text (e.g., store it in a variable, assign it to a TextBox, etc.)
                txtNewBarcode.Text = enteredText;  // Assign the entered text to a TextBox on the parent form
            }
        }
        private void RefreshBarcodeGrid()
        {
            dataGridViewBarcodes.DataSource = null;
            dataGridViewBarcodes.DataSource = barcodeList.Select(b => new { Barcode = b }).ToList();
        }


        private void dataGridViewBarcodes_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure the double-click is on a valid row and the correct column
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridViewBarcodes.Columns["Barcode"].Index)
            {
                // Get the barcode value from the clicked cell
                var cellValue = dataGridViewBarcodes.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

                if (cellValue != null)
                {
                    string barcodeToRemove = cellValue.ToString();

                    // Remove from the internal list
                    if (barcodeList.Contains(barcodeToRemove))
                    {
                        barcodeList.Remove(barcodeToRemove);

                        // Refresh the grid to reflect changes
                        RefreshBarcodeGrid();
                    }
                }
            }
        }

        private void btnChooseColor_Click(object sender, EventArgs e)
        {
            // عند الضغط على الزر، قم بإظهار نافذة اختيار الألوان
            // colorDialog1 هو اسم المكون الذي أضفته من الـ Toolbox
            DialogResult result = colorDialog1.ShowDialog();

            // تحقق مما إذا كان المستخدم قد ضغط على "OK"
            if (result == DialogResult.OK)
            {
                // 1. احصل على اللون الذي اختاره المستخدم
                Color selectedColor = colorDialog1.Color;

                // 2. اعرض هذا اللون كخلفية للـ Panel الذي أضفته
                pnlColorPreview.BackColor = selectedColor;
            }
        }

        private void BTN_detailsArticle_Click(object sender, EventArgs e)
        {
            bunifuPages1.SelectedTab = tabPage1;

        }

        private void btn_viewdetailsells_Click(object sender, EventArgs e)
        {
            bunifuPages1.SelectedTab = tabPage2;
        }

        private void btn_viewdetailachat_Click(object sender, EventArgs e)
        {
            bunifuPages1.SelectedTab = tabPage3;

        }
        
        private void btn_viewStatistiques_Click(object sender, EventArgs e)
        {
            bunifuPages1.SelectedTab = tabPage4;
        }
    }
}
