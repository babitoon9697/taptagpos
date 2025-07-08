using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TAPTAGPOS
{
    public partial class FormEtatGlobalStock : Form
    {
        private string connectionString = DatabaseConnection.GetConnectionString();

        public FormEtatGlobalStock()
        {
            InitializeComponent();
            InitializeEventHandlers();
        }

        private void InitializeEventHandlers()
        {
            this.Load += FormEtatGlobalStock_Load;
            // Link the "View" button to reload the data
            this.btnView.Click += (s, e) => LoadData();
            // You can add logic for the Print button here
            this.btnPrint.Click += (s, e) => MessageBox.Show("La fonctionnalité d'impression sera ajoutée ultérieurement.", "Info");
        }

        private void FormEtatGlobalStock_Load(object sender, EventArgs e)
        {
            LoadComboBoxes();
            LoadData();
        }

        private void LoadComboBoxes()
        {
            // Load Product Families
            try
            {
                var dtFamilies = new DataTable();
                // Assumes your table is named 'ArticleCategories' with 'CategoryID' and 'CategoryName'
                using (var conn = new SqlConnection(connectionString))
                using (var adapter = new SqlDataAdapter("SELECT CategoryID, CategoryName FROM ArticleCategories WHERE IsActive=1 ORDER BY CategoryName", conn))
                {
                    adapter.Fill(dtFamilies);
                }

                DataRow dr = dtFamilies.NewRow();
                dr["CategoryID"] = 0; // Use 0 for "All"
                dr["CategoryName"] = "Toutes";
                dtFamilies.Rows.InsertAt(dr, 0);

                cmbFamily.DataSource = dtFamilies;
                cmbFamily.DisplayMember = "CategoryName";
                cmbFamily.ValueMember = "CategoryID"; // Set the ValueMember to use the ID
            }
            catch (Exception ex) { MessageBox.Show("Error loading families: " + ex.Message); }

            // Load Warehouses
            try
            {
                var dtWarehouses = new DataTable();
                using (var conn = new SqlConnection(connectionString))
                using (var adapter = new SqlDataAdapter("SELECT WarehouseID, WarehouseName FROM Warehouses WHERE IsActive=1", conn))
                {
                    adapter.Fill(dtWarehouses);
                }

                DataRow dr = dtWarehouses.NewRow();
                dr["WarehouseID"] = 0;
                dr["WarehouseName"] = "Tous les Dépôts";
                dtWarehouses.Rows.InsertAt(dr, 0);

                cmbWarehouse.DataSource = dtWarehouses;
                cmbWarehouse.DisplayMember = "WarehouseName";
                cmbWarehouse.ValueMember = "WarehouseID";
            }
            catch (Exception ex) { MessageBox.Show("Error loading warehouses: " + ex.Message); }
        }

        private void LoadData()
        {
            dgvStock.Rows.Clear();
            decimal grandTotalValue = 0;

            // --- START OF FIX ---
            // Safely get the selected ID from each ComboBox
            int selectedWarehouseId = 0;
            if (cmbWarehouse.SelectedValue != null && cmbWarehouse.SelectedValue != DBNull.Value)
            {
                selectedWarehouseId = Convert.ToInt32(cmbWarehouse.SelectedValue);
            }

            int selectedFamilyId = 0;
            string selectedFamilyName="";
            if (cmbFamily.SelectedValue != null && cmbFamily.SelectedValue != DBNull.Value)
            {
                selectedFamilyId = Convert.ToInt32(cmbFamily.SelectedValue);
                selectedFamilyName = cmbFamily.Text;
            }
            // --- END OF FIX ---

            var queryBuilder = new StringBuilder(@"
                SELECT a.Id AS Code, a.Article as ArticleLongName, a.BuyPrice, a.MinStock, a.QuantiteBox, ");

            if (selectedWarehouseId > 0)
            {
                queryBuilder.Append("ISNULL(s.Quantity, 0) AS Stock ");
                queryBuilder.Append("FROM Articles a LEFT JOIN ArticleStock s ON a.Id = s.ArticleID AND s.WarehouseID = @WarehouseID ");
            }
            else
            {
                queryBuilder.Append("ISNULL(a.QuantityStock, 0) AS Stock ");
                queryBuilder.Append("FROM Articles a ");
            }

            queryBuilder.Append("WHERE a.IsActive = 1 ");
            // Correctly filter by CategoryID (more reliable than text)
            if (selectedFamilyId > 0)
            {
                queryBuilder.Append(" AND a.Categorie = @FamilyID");
            }
            queryBuilder.Append(" ORDER BY a.Article");

            try
            {
                using (var conn = new SqlConnection(connectionString))
                using (var cmd = new SqlCommand(queryBuilder.ToString(), conn))
                {
                    if (selectedWarehouseId > 0) cmd.Parameters.AddWithValue("@WarehouseID", selectedWarehouseId);
                    if (selectedFamilyId > 0) cmd.Parameters.AddWithValue("@FamilyID", selectedFamilyName);

                    conn.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Safely handle potential NULL values from the database
                            decimal stock = Convert.ToDecimal(reader["Stock"]);
                            decimal buyPrice = reader["BuyPrice"] == DBNull.Value ? 0m : Convert.ToDecimal(reader["BuyPrice"]);
                            int itemsPerCarton = reader["QuantiteBox"] == DBNull.Value ? 0 : Convert.ToInt32(reader["QuantiteBox"]);
                            decimal stockValue = stock * buyPrice;
                            decimal cartonStock = (itemsPerCarton > 0) ? (stock / itemsPerCarton) : 0;
                            decimal minStock = reader["MinStock"] == DBNull.Value ? 0 : Convert.ToDecimal(reader["MinStock"]);

                            int rowIndex = dgvStock.Rows.Add(
                                reader["Code"],
                                reader["ArticleLongName"],
                                stock.ToString("N2"),
                                stockValue.ToString("C2"),
                                cartonStock.ToString("N2")
                            );

                            // Color coding for stock levels
                            if (stock <= 0)
                            {
                                dgvStock.Rows[rowIndex].DefaultCellStyle.BackColor = Color.Red;
                                dgvStock.Rows[rowIndex].DefaultCellStyle.ForeColor = Color.White;
                            }
                            else if (stock < minStock)
                            {
                                dgvStock.Rows[rowIndex].DefaultCellStyle.BackColor = Color.Gold;
                            }
                            grandTotalValue += stockValue;
                        }
                    }
                }
                txtTotal.Text = grandTotalValue.ToString("C2");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading stock data: " + ex.Message);
            }
        }
    }
}