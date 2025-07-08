using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TAPTAGPOS
{
    public partial class ListeArticlesFournisseur : Form
    {
        private string connectionString = DatabaseConnection.GetConnectionString();

        public ListeArticlesFournisseur()
        {
            InitializeComponent();
            // Link events in the constructor
            this.Load += ListeArticlesFournisseur_Load;
            this.cmbFournisseur.SelectedIndexChanged += cmbFournisseur_SelectedIndexChanged;
            // You can add the print button event handler here when ready
            // this.btnImprimer.Click += btnImprimer_Click;
        }

        private void ListeArticlesFournisseur_Load(object sender, EventArgs e)
        {
            LoadSuppliers();
        }

        private void LoadSuppliers()
        {
            try
            {
                var dt = new DataTable();
                dt.Columns.Add("SupplierID", typeof(int));
                dt.Columns.Add("Name", typeof(string));
                dt.Rows.Add(-1, "Choisir un fournisseur...");

                string query = "SELECT SupplierID, Name FROM Suppliers WHERE Status = 'Active' ORDER BY Name";
                using (var conn = new SqlConnection(connectionString))
                using (var adapter = new SqlDataAdapter(query, conn))
                {
                    adapter.Fill(dt);
                }

                cmbFournisseur.DataSource = dt;
                cmbFournisseur.DisplayMember = "Name";
                cmbFournisseur.ValueMember = "SupplierID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading suppliers: " + ex.Message);
            }
        }

        private void cmbFournisseur_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Check if the selected value is actually a valid number (DataRowView or int)
            if (cmbFournisseur.SelectedValue != null && int.TryParse(cmbFournisseur.SelectedValue.ToString(), out int supplierId))
            {
                // Check if a real supplier is selected (ID > 0)
                if (supplierId > 0)
                {
                    LoadArticlesForSupplier(supplierId);
                }
                else
                {
                    // If the user selected "Choisir un fournisseur...", clear the grid
                    dgvArticles.Rows.Clear();
                }
            }
        }

        private void LoadArticlesForSupplier(int supplierId)
        {
            dgvArticles.Rows.Clear();
            // This query assumes you have a SupplierID column in your Articles table
            string query = @"
                SELECT Article AS Reference, ArticleLongName AS Designation, BuyPrice AS Prix
                FROM Articles 
                WHERE SupplierID = @SupplierID 
                ORDER BY Article";

            try
            {
                using (var conn = new SqlConnection(connectionString))
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@SupplierID", supplierId);
                    conn.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            dgvArticles.Rows.Add(
                                reader["Reference"],
                                reader["Designation"],
                                Convert.ToDecimal(reader["Prix"] ?? 0).ToString("N2")
                            );
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading articles for supplier: " + ex.Message);
            }
        }
    }
}