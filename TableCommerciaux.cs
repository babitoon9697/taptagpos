using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TAPTAGPOS
{
    public partial class TableCommerciaux : Form
    {
        private string connectionString = DatabaseConnection.GetConnectionString();

        public TableCommerciaux()
        {
            InitializeComponent();
            // Link events in the constructor for clarity
            this.Load += TableCommerciaux_Load;
            this.btnModifier.Click += btnModifier_Click;
            this.btnSupprimer.Click += btnSupprimer_Click;
            this.dgvCommerciaux.CellDoubleClick += (s, e) => btnModifier_Click(s, e); // Double-click to edit
        }

        private void TableCommerciaux_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            dgvCommerciaux.Rows.Clear();
            string query = "SELECT CommercialID, Nom, Adresse, Telephone, Email FROM Commerciaux WHERE ISNULL(IsActive, 1) = 1 ORDER BY Nom";
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
                            int rowIndex = dgvCommerciaux.Rows.Add();
                            DataGridViewRow row = dgvCommerciaux.Rows[rowIndex];
                            row.Tag = reader["CommercialID"];
                            row.Cells["colNom"].Value = reader["Nom"];
                            row.Cells["colAdresse"].Value = reader["Adresse"];
                            row.Cells["colTelephone"].Value = reader["Telephone"];
                            row.Cells["colEmail"].Value = reader["Email"];
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

        private void btnNouveau_Click(object sender, EventArgs e)
        {
            using (FicheCommercial editorForm = new FicheCommercial())
            {
                if (editorForm.ShowDialog(this) == DialogResult.OK)
                {
                    LoadData(); // Refresh the grid after adding
                }
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (dgvCommerciaux.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a salesperson to modify.");
                return;
            }
            int idToEdit = (int)dgvCommerciaux.SelectedRows[0].Tag;
            using (FicheCommercial editorForm = new FicheCommercial(idToEdit))
            {
                if (editorForm.ShowDialog(this) == DialogResult.OK)
                {
                    LoadData(); // Refresh the grid after editing
                }
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (dgvCommerciaux.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a salesperson to delete.");
                return;
            }
            if (MessageBox.Show("Are you sure you want to delete this salesperson?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                int idToDelete = (int)dgvCommerciaux.SelectedRows[0].Tag;
                // Soft delete is safer
                string query = "UPDATE Commerciaux SET IsActive = 0 WHERE CommercialID = @ID";
                try
                {
                    using (var conn = new SqlConnection(connectionString))
                    using (var cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ID", idToDelete);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        LoadData(); // Refresh grid after deleting
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting salesperson: " + ex.Message);
                }
            }
        }
    }
}