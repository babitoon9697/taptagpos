using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TAPTAGPOS
{
    public partial class frmSalesByCustomer : Form
    {
        private readonly string connectionString = DatabaseConnection.GetConnectionString();

        public frmSalesByCustomer()
        {
            InitializeComponent();
            SetupForm();
        }

        // Optional: Constructor to open the form for a specific customer
        public frmSalesByCustomer(int customerId) : this()
        {
            this.Load += (s, e) => {
                cmbCustomer.SelectedValue = customerId;
                if (cmbCustomer.SelectedIndex > 0)
                {
                    btnView.PerformClick();
                }
            };
        }

        private void SetupForm()
        {
            this.Load += FrmSalesByCustomer_Load;
            this.btnView.Click += BtnView_Click;
            this.btnDetails.Click += BtnDetails_Click;
            // You can add printing logic to this button later
            this.btnPrint.Click += (s, e) => MessageBox.Show("La fonctionnalité d'impression sera ajoutée ultérieurement.");
        }

        private void FrmSalesByCustomer_Load(object sender, EventArgs e)
        {
            LoadCustomers();
            LoadCategories();

            // Set default date range for the current month
            dtpFrom.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtpTo.Value = DateTime.Now;
        }

        #region Data Loading and Filtering

        private void LoadCustomers()
        {
            try
            {
                using (var conn = new SqlConnection(connectionString))
                {
                    var query = "SELECT CustomerID, CustomerName FROM Customers WHERE IsActive = 1 ORDER BY CustomerName";
                    var adapter = new SqlDataAdapter(query, conn);
                    var dt = new DataTable();
                    adapter.Fill(dt);

                    DataRow dr = dt.NewRow();
                    dr["CustomerID"] = 0;
                    dr["CustomerName"] = "-- Choisir un client --";
                    dt.Rows.InsertAt(dr, 0);

                    cmbCustomer.DataSource = dt;
                    cmbCustomer.DisplayMember = "CustomerName";
                    cmbCustomer.ValueMember = "CustomerID";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur chargement clients: " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadCategories()
        {
            try
            {
                using (var conn = new SqlConnection(connectionString))
                {
                    var query = "SELECT CategoryID, CategoryName FROM Category ORDER BY CategoryName";
                    var adapter = new SqlDataAdapter(query, conn);
                    var dt = new DataTable();
                    adapter.Fill(dt);

                    DataRow dr = dt.NewRow();
                    dr["CategoryID"] = 0;
                    dr["CategoryName"] = "Toutes les familles";
                    dt.Rows.InsertAt(dr, 0);

                    cmbCategory.DataSource = dt;
                    cmbCategory.DisplayMember = "CategoryName";
                    cmbCategory.ValueMember = "CategoryID";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur chargement familles: " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnView_Click(object sender, EventArgs e)
        {
            if (cmbCustomer.SelectedValue == null || (int)cmbCustomer.SelectedValue == 0)
            {
                MessageBox.Show("Veuillez sélectionner un client.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int customerId = (int)cmbCustomer.SelectedValue;
            int categoryId = (int)cmbCategory.SelectedValue;
            DateTime startDate = dtpFrom.Value.Date;
            DateTime endDate = dtpTo.Value.Date.AddDays(1).AddSeconds(-1);

            // This query joins all necessary tables and groups the results by article
            string query = @"
                SELECT 
                    a.Id AS ArticleID,
                    a.Article AS ArticleCode,
                    a.ArticleLongName AS ArticleName,
                    c.CategoryName,
                    SUM(ti.Quantity) AS TotalQuantity,
                    SUM(ti.TotalPrice) AS TotalSale
                FROM Transactions t
                JOIN TransactionItems ti ON t.TransactionID = ti.TransactionID
                JOIN Articles a ON ti.ArticleID = a.Id
                LEFT JOIN Category c ON a.CategoryID = c.CategoryID
                WHERE t.CustomerID = @CustomerID 
                  AND t.TransactionDate BETWEEN @StartDate AND @EndDate
                  AND (@CategoryID = 0 OR a.CategoryID = @CategoryID)
                GROUP BY a.Id, a.Article, a.ArticleLongName, c.CategoryName
                ORDER BY TotalSale DESC";

            try
            {
                using (var conn = new SqlConnection(connectionString))
                {
                    var adapter = new SqlDataAdapter(query, conn);
                    adapter.SelectCommand.Parameters.AddWithValue("@CustomerID", customerId);
                    adapter.SelectCommand.Parameters.AddWithValue("@StartDate", startDate);
                    adapter.SelectCommand.Parameters.AddWithValue("@EndDate", endDate);
                    adapter.SelectCommand.Parameters.AddWithValue("@CategoryID", categoryId);

                    var dt = new DataTable();
                    adapter.Fill(dt);

                    dgvSales.DataSource = dt;
                    FormatGrid();
                    CalculateTotals();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la génération du rapport: " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region UI Helpers and Event Handlers

        private void FormatGrid()
        {
            if (!dgvSales.Columns.Contains("ArticleID"))
            {
                dgvSales.Columns.Add("ArticleID", "ArticleID");
            }
            dgvSales.Columns["ArticleID"].DataPropertyName = "ArticleID";
            dgvSales.Columns["ArticleID"].Visible = false;

            dgvSales.Columns["colCode"].DataPropertyName = "ArticleCode";
            dgvSales.Columns["colArticle"].DataPropertyName = "ArticleName";
            dgvSales.Columns["colCategory"].DataPropertyName = "CategoryName";
            dgvSales.Columns["colQuantity"].DataPropertyName = "TotalQuantity";
            dgvSales.Columns["colTotal"].DataPropertyName = "TotalSale";

            dgvSales.Columns["colTotal"].DefaultCellStyle.Format = "N2";
        }

        private void CalculateTotals()
        {
            decimal totalSales = 0m;
            decimal totalQuantity = 0m;

            foreach (DataGridViewRow row in dgvSales.Rows)
            {
                totalQuantity += Convert.ToDecimal(row.Cells["colQuantity"].Value ?? 0);
                totalSales += Convert.ToDecimal(row.Cells["colTotal"].Value ?? 0);
            }

            txtTotalQuantity.Text = totalQuantity.ToString();
            txtTotalSales.Text = totalSales.ToString("C2");
        }

        private void BtnDetails_Click(object sender, EventArgs e)
        {
            if (dgvSales.SelectedRows.Count > 0)
            {
                int articleId = Convert.ToInt32(dgvSales.SelectedRows[0].Cells["ArticleID"].Value);

                // Open the article history/tracking form for the selected article
                // Note: This requires FormSuiviArticle to have a constructor that accepts an articleId.
                FormSuiviArticle frm = new FormSuiviArticle(articleId);
                frm.ShowDialog(this);
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un article pour voir ses détails.", "Aucune sélection", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion
    }
}