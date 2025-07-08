using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Microsoft.VisualBasic; // For the InputBox

namespace TAPTAGPOS
{
    public partial class TableRayon : Form
    {
        private string connectionString = DatabaseConnection.GetConnectionString();

        public TableRayon()
        {
            InitializeComponent();
            // Link all events in the constructor
            this.Load += TableRayon_Load;
            this.dgvRayon.UserAddedRow += dgvRayon_UserAddedRow; // To add new rows directly
            this.dgvRayon.CellValueChanged += dgvRayon_CellValueChanged;
            this.btnSupprimer.Click += btnSupprimer_Click;
            this.btnFermer.Click += (s, e) => this.Close();
        }

        private void TableRayon_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                using (var conn = new SqlConnection(connectionString))
                {
                    // Use SqlDataAdapter to easily fill and update
                    var adapter = new SqlDataAdapter("SELECT RayonID, RayonName FROM Rayons WHERE ISNULL(IsActive, 1) = 1 ORDER BY RayonName", conn);

                    var dt = new DataTable();
                    adapter.Fill(dt);

                    dgvRayon.DataSource = dt;

                    // Set column headers and properties
                    dgvRayon.Columns["RayonID"].Visible = false; // Hide the ID column
                    dgvRayon.Columns["RayonName"].HeaderText = "Rayon";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading rayons: " + ex.Message);
            }
        }

        private void dgvRayon_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            // This event fires after a user types into the new row.
            // We can prompt for a name and save it.
            string newRayonName = Interaction.InputBox("Entrez le nom du nouveau rayon:", "Nouveau Rayon", "");
            if (!string.IsNullOrWhiteSpace(newRayonName))
            {
                try
                {
                    // Immediately save the new row to the database
                    string query = "INSERT INTO Rayons (RayonName) VALUES (@Name)";
                    using (var conn = new SqlConnection(connectionString))
                    using (var cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Name", newRayonName);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                    LoadData(); // Refresh the grid to get the new ID
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding rayon: " + ex.Message);
                    LoadData(); // Reload to remove the incomplete new row
                }
            }
            else
            {
                LoadData(); // If user cancels, reload to remove the new row
            }
        }

        private void dgvRayon_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // This event fires when a user edits a cell directly
            if (e.RowIndex < 0 || dgvRayon.Rows[e.RowIndex].IsNewRow) return;

            DataGridViewRow row = dgvRayon.Rows[e.RowIndex];
            int rayonId = Convert.ToInt32(((DataTable)dgvRayon.DataSource).Rows[e.RowIndex]["RayonID"]);
            string newName = row.Cells["RayonName"].Value.ToString();

            try
            {
                string query = "UPDATE Rayons SET RayonName = @Name WHERE RayonID = @ID";
                using (var conn = new SqlConnection(connectionString))
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", newName);
                    cmd.Parameters.AddWithValue("@ID", rayonId);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex) { MessageBox.Show("Error updating rayon: " + ex.Message); }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (dgvRayon.SelectedRows.Count == 0) return;
            if (MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int idToDelete = Convert.ToInt32(((DataTable)dgvRayon.DataSource).Rows[dgvRayon.SelectedRows[0].Index]["RayonID"]);
                string query = "UPDATE Rayons SET IsActive = 0 WHERE RayonID = @ID";
                try
                {
                    using (var conn = new SqlConnection(connectionString))
                    using (var cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ID", idToDelete);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        LoadData();
                    }
                }
                catch (Exception ex) { MessageBox.Show("Error deleting rayon: " + ex.Message); }
            }
        }
    }
}