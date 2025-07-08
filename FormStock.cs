using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TAPTAGPOS
{
    public partial class FormStock : Form
    {
        private string connectionString = DatabaseConnection.GetConnectionString();

        public FormStock()
        {
            InitializeComponent();
            InitializeEventHandlers();
        }

        private void InitializeEventHandlers()
        {
            this.Load += FormStock_Load;
            // The filters will automatically refresh the data when changed
            this.cmbDesignation.SelectedIndexChanged += (s, e) => LoadData();
            this.cmbFamille.SelectedIndexChanged += (s, e) => LoadData();
            this.cmbDepot.SelectedIndexChanged += (s, e) => LoadData();
        }

        private void FormStock_Load(object sender, EventArgs e)
        {
            LoadComboBoxes();
            LoadData(); // Load all data initially
        }

        private void LoadComboBoxes()
        {
            // Load Articles into Designation ComboBox
            try
            {
                var dtArticles = new DataTable();
                dtArticles.Rows.Add(0, "Tous les Articles");
                using (var conn = new SqlConnection(connectionString))
                using (var adapter = new SqlDataAdapter("SELECT Id, ArticleLongName FROM Articles WHERE IsActive=1 ORDER BY ArticleLongName", conn))
                {
                    adapter.Fill(dtArticles);
                }
                cmbDesignation.DataSource = dtArticles;
                cmbDesignation.DisplayMember = "ArticleLongName";
                cmbDesignation.ValueMember = "Id";
            }
            catch (Exception ex) { MessageBox.Show("Error loading articles: " + ex.Message); }

            // Load Families
            try
            {
                var dtFamilies = new DataTable();
                dtFamilies.Rows.Add("Toutes");
                using (var conn = new SqlConnection(connectionString))
                using (var adapter = new SqlDataAdapter("SELECT DISTINCT CategoryName FROM ArticleCategories WHERE IsActive=1", conn))
                {
                    adapter.Fill(dtFamilies);
                }
                cmbFamille.DataSource = dtFamilies;
                cmbFamille.DisplayMember = "CategoryName";
            }
            catch (Exception ex) { MessageBox.Show("Error loading families: " + ex.Message); }

            // Load Warehouses
            try
            {
                var dtWarehouses = new DataTable();
                dtWarehouses.Rows.Add(0, "Tous les Dépôts");
                using (var conn = new SqlConnection(connectionString))
                using (var adapter = new SqlDataAdapter("SELECT WarehouseID, WarehouseName FROM Warehouses WHERE IsActive=1", conn))
                {
                    adapter.Fill(dtWarehouses);
                }
                cmbDepot.DataSource = dtWarehouses;
                cmbDepot.DisplayMember = "WarehouseName";
                cmbDepot.ValueMember = "WarehouseID";
            }
            catch (Exception ex) { MessageBox.Show("Error loading warehouses: " + ex.Message); }
        }

        private void LoadData()
        {
            dgvStock.Rows.Clear();
            decimal grandTotalValue = 0;

            int selectedWarehouseId = (int)(cmbDepot.SelectedValue ?? 0);
            int selectedArticleId = (int)(cmbDesignation.SelectedValue ?? 0);
            string selectedFamily = cmbFamille.Text;

            var queryBuilder = new StringBuilder();
            var parameters = new Dictionary<string, object>();

            // Base query
            queryBuilder.Append(@"
                SELECT a.Article AS Code, a.ArticleLongName, a.BuyPrice, a.MinStock, a.QuantiteBox, ");

            if (selectedWarehouseId > 0)
            {
                queryBuilder.Append("ISNULL(s.Quantity, 0) AS Stock ");
                queryBuilder.Append("FROM Articles a LEFT JOIN ArticleStock s ON a.Id = s.ArticleID AND s.WarehouseID = @WarehouseID ");
                parameters.Add("@WarehouseID", selectedWarehouseId);
            }
            else
            {
                queryBuilder.Append("ISNULL(a.QuantityStock, 0) AS Stock ");
                queryBuilder.Append("FROM Articles a ");
            }

            // Filtering
            queryBuilder.Append("WHERE a.IsActive = 1 ");

            if (selectedArticleId > 0)
            {
                queryBuilder.Append(" AND a.Id = @ArticleID");
                parameters.Add("@ArticleID", selectedArticleId);
            }
            if (selectedFamily != "Toutes")
            {
                queryBuilder.Append(" AND a.Categorie = @Family");
                parameters.Add("@Family", selectedFamily);
            }

            queryBuilder.Append(" ORDER BY a.Article");

            try
            {
                using (var conn = new SqlConnection(connectionString))
                using (var cmd = new SqlCommand(queryBuilder.ToString(), conn))
                {
                    foreach (var p in parameters)
                    {
                        cmd.Parameters.AddWithValue(p.Key, p.Value);
                    }
                    conn.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            decimal stock = Convert.ToDecimal(reader["Stock"]);
                            decimal buyPrice = Convert.ToDecimal(reader["BuyPrice"] ?? 0);
                            decimal stockValue = stock * buyPrice;
                            decimal minStock = Convert.ToDecimal(reader["MinStock"] ?? 0);

                            int rowIndex = dgvStock.Rows.Add(
                                reader["Code"],
                                reader["ArticleLongName"],
                                stock.ToString("N2"),
                                buyPrice.ToString("C2"),
                                stockValue.ToString("C2")
                            );

                            if (stock <= 0)
                            {
                                dgvStock.Rows[rowIndex].DefaultCellStyle.BackColor = Color.Red;
                            }
                            else if (minStock > 0 && stock <= minStock)
                            {
                                dgvStock.Rows[rowIndex].DefaultCellStyle.BackColor = Color.LimeGreen;
                            }

                            grandTotalValue += stockValue;
                        }
                    }
                }
                txtStockValue.Text = grandTotalValue.ToString("C2");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading stock data: " + ex.Message);
            }
        }
    }
}