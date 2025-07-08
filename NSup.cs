using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TAPTAGPOS
{
    public partial class NewSupplier : Form
    {
        public NewSupplier()
        {
            InitializeComponent();
        }
        int currentSupplierId = -1;
        private void LoadSuppliers()
        {
            string connectionString = DatabaseConnection.GetConnectionString();
            string query = "SELECT * FROM Suppliers WHERE Status = 'Active' ORDER BY Name";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                dataGridViewSuppliers.Rows.Clear();

                while (reader.Read())
                {
                    int index = dataGridViewSuppliers.Rows.Add();
                    dataGridViewSuppliers.Rows[index].Cells["SupplierID"].Value = reader["SupplierID"];
                    dataGridViewSuppliers.Rows[index].Cells["Name"].Value = reader["Name"];
                    dataGridViewSuppliers.Rows[index].Cells["Phone"].Value = reader["Phone"];
                    dataGridViewSuppliers.Rows[index].Cells["Email"].Value = reader["Email"];
                    dataGridViewSuppliers.Rows[index].Cells["City"].Value = reader["City"];
                }
            }
        }

        private void deletesupplier(int Supplier)
        {
            if (Supplier == -1)
            {
                MessageBox.Show("Sélectionnez un fournisseur à supprimer.");
                return;
            }

            var confirmResult = MessageBox.Show(
                "Êtes-vous sûr de vouloir supprimer ce fournisseur?",
                "Confirmer la suppression",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirmResult == DialogResult.Yes)
            {
                string connectionString = DatabaseConnection.GetConnectionString();
                string query = "UPDATE Suppliers SET Status = 'Inactive' WHERE SupplierID = @SupplierID";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@SupplierID", Supplier);
                        try
                        {
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Fournisseur désactivé avec succès!");
                            LoadSuppliers();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Erreur lors de la suppression: " + ex.Message);
                        }
                    }
                }
            }
        }

        private void dataGridViewCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewSuppliers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewSuppliers.Rows[e.RowIndex];
                currentSupplierId = Convert.ToInt32(row.Cells["SupplierID"].Value);
            }
        }

        private void NewSupplier_Load(object sender, EventArgs e)
        {
            LoadSuppliers();
        }
    }
}
