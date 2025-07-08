using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TAPTAGPOS
{
    public partial class TableUnites : Form
    {
        private string connectionString = DatabaseConnection.GetConnectionString();

        public TableUnites()
        {
            InitializeComponent();
            // Link all events in the constructor
            this.Load += TableUnites_Load;

            this.btnFermer.Click += (s, e) => this.Close();
            this.dgvUnites.CellDoubleClick += (s, e) => btnModifier_Click(s, e);
        }

        private void TableUnites_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            dgvUnites.Rows.Clear();
            string query = "SELECT UniteID, UniteName FROM Unites WHERE ISNULL(IsActive, 1) = 1 ORDER BY UniteName";
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
                            int rowIndex = dgvUnites.Rows.Add();
                            DataGridViewRow row = dgvUnites.Rows[rowIndex];
                            row.Tag = reader["UniteID"];
                            row.Cells["colUnite"].Value = reader["UniteName"];
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading units: " + ex.Message);
            }
        }

        private void btnNouveau_Click(object sender, EventArgs e)
        {
            using (FicheUnite editorForm = new FicheUnite())
            {
                if (editorForm.ShowDialog(this) == DialogResult.OK)
                {
                    string newName = editorForm.UniteName;
                    string query = "INSERT INTO Unites (UniteName) VALUES (@Name)";
                    try
                    {
                        using (var conn = new SqlConnection(connectionString))
                        using (var cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@Name", newName);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            LoadData(); // Refresh the grid
                        }
                    }
                    catch (Exception ex) { MessageBox.Show("Error adding unit: " + ex.Message); }
                }
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (dgvUnites.SelectedRows.Count == 0) return;

            int idToEdit = (int)dgvUnites.SelectedRows[0].Tag;
            string currentName = dgvUnites.SelectedRows[0].Cells["colUnite"].Value.ToString();

            using (FicheUnite editorForm = new FicheUnite(idToEdit, currentName))
            {
                if (editorForm.ShowDialog(this) == DialogResult.OK)
                {
                    string newName = editorForm.UniteName;
                    string query = "UPDATE Unites SET UniteName = @Name WHERE UniteID = @ID";
                    try
                    {
                        using (var conn = new SqlConnection(connectionString))
                        using (var cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@Name", newName);
                            cmd.Parameters.AddWithValue("@ID", idToEdit);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            LoadData(); // Refresh the grid
                        }
                    }
                    catch (Exception ex) { MessageBox.Show("Error updating unit: " + ex.Message); }
                }
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (dgvUnites.SelectedRows.Count == 0) return;

            if (MessageBox.Show("Are you sure?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                int idToDelete = (int)dgvUnites.SelectedRows[0].Tag;
                // Soft delete is safer
                string query = "UPDATE Unites SET IsActive = 0 WHERE UniteID = @ID";
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
                catch (Exception ex) { MessageBox.Show("Error deleting unit: " + ex.Message); }
            }
        }
    }
}