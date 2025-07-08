using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace TAPTAGPOS
{
    public partial class TablePromotions : Form
    {
        private string connectionString = DatabaseConnection.GetConnectionString();

        public TablePromotions()
        {
            InitializeComponent();
            this.Load += (s, e) => LoadData();
            this.btnModifier.Click += btnModifier_Click;
            this.btnSupprimer.Click += btnSupprimer_Click;
            this.btnFermer.Click += (s, e) => this.Close();
        }

        private void LoadData()
        {
            dgvPromotions.Rows.Clear();
            string query = "SELECT PromotionID, StartDate, EndDate, PromotionName, DiscountPercentage FROM Promotions WHERE IsActive = 1 ORDER BY StartDate DESC";
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
                            int rowIndex = dgvPromotions.Rows.Add();
                            DataGridViewRow row = dgvPromotions.Rows[rowIndex];

                            row.Tag = reader["PromotionID"];
                            row.Cells["colDateDebut"].Value = ((DateTime)reader["StartDate"]).ToShortDateString();
                            row.Cells["colDateFin"].Value = ((DateTime)reader["EndDate"]).ToShortDateString();
                            row.Cells["colPromotion"].Value = reader["PromotionName"];
                            row.Cells["colRemise"].Value = reader["DiscountPercentage"] + " %";

                            // Color code the status
                            DateTime endDate = (DateTime)reader["EndDate"];
                            if (endDate < DateTime.Today)
                            {
                                row.Cells["colSituation"].Value = "Expirée";
                                row.DefaultCellStyle.ForeColor = Color.Gray;
                            }
                            else
                            {
                                row.Cells["colSituation"].Value = "Active";
                                row.DefaultCellStyle.ForeColor = Color.Green;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading promotions: " + ex.Message);
            }
        }

        private void btnNouveau_Click(object sender, EventArgs e)
        {
            using (FichePromotion editorForm = new FichePromotion())
            {
                if (editorForm.ShowDialog(this) == DialogResult.OK)
                {
                    LoadData();
                }
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (dgvPromotions.SelectedRows.Count == 0) return;
            int idToEdit = (int)dgvPromotions.SelectedRows[0].Tag;
            using (FichePromotion editorForm = new FichePromotion(idToEdit))
            {
                if (editorForm.ShowDialog(this) == DialogResult.OK)
                {
                    LoadData();
                }
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            // 1. Check if a row is selected
            if (dgvPromotions.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a promotion to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // 2. Ask the user for confirmation
            if (MessageBox.Show("Are you sure you want to delete this promotion?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                // 3. Get the ID of the selected promotion from the row's Tag property
                int idToDelete = Convert.ToInt32(dgvPromotions.SelectedRows[0].Tag);

                // 4. Execute the soft delete query
                string query = "UPDATE Promotions SET IsActive = 0 WHERE PromotionID = @ID";
                try
                {
                    using (var conn = new SqlConnection(connectionString))
                    using (var cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ID", idToDelete);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }

                    // 5. Refresh the grid to show the result
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting promotion: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}