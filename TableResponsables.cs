using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TAPTAGPOS
{
    public partial class TableResponsables : Form
    {
        private string connectionString = DatabaseConnection.GetConnectionString();

        public TableResponsables()
        {
            InitializeComponent();
            this.Load += (s, e) => LoadData();
            this.btnModifier.Click += btnModifier_Click;
            this.btnSupprimer.Click += btnSupprimer_Click;
            this.btnFermer.Click += (s, e) => this.Close();
            this.dgvResponsables.CellDoubleClick += (s, e) => btnModifier_Click(s, e);
        }

        private void LoadData()
        {
            dgvResponsables.Rows.Clear();
            string query = "SELECT ResponsableID, NomComplet FROM Responsables WHERE ISNULL(IsActive, 1) = 1 ORDER BY NomComplet";
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
                            int rowIndex = dgvResponsables.Rows.Add();
                            DataGridViewRow row = dgvResponsables.Rows[rowIndex];
                            row.Tag = reader["ResponsableID"];
                            row.Cells["colResponsable"].Value = reader["NomComplet"];
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
            using (FicheResponsable editorForm = new FicheResponsable())
            {
                if (editorForm.ShowDialog(this) == DialogResult.OK)
                {
                    string newName = editorForm.NomComplet;
                    string query = "INSERT INTO Responsables (NomComplet) VALUES (@Name)";
                    try
                    {
                        using (var conn = new SqlConnection(connectionString))
                        using (var cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@Name", newName);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            LoadData(); // Refresh grid
                        }
                    }
                    catch (Exception ex) { MessageBox.Show("Error adding responsable: " + ex.Message); }
                }
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (dgvResponsables.SelectedRows.Count == 0) return;
            int idToEdit = (int)dgvResponsables.SelectedRows[0].Tag;
            string currentName = dgvResponsables.SelectedRows[0].Cells["colResponsable"].Value.ToString();

            using (FicheResponsable editorForm = new FicheResponsable(currentName))
            {
                if (editorForm.ShowDialog(this) == DialogResult.OK)
                {
                    string newName = editorForm.NomComplet;
                    string query = "UPDATE Responsables SET NomComplet = @Name WHERE ResponsableID = @ID";
                    try
                    {
                        using (var conn = new SqlConnection(connectionString))
                        using (var cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@Name", newName);
                            cmd.Parameters.AddWithValue("@ID", idToEdit);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            LoadData(); // Refresh grid
                        }
                    }
                    catch (Exception ex) { MessageBox.Show("Error updating responsable: " + ex.Message); }
                }
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (dgvResponsables.SelectedRows.Count == 0) return;
            if (MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int idToDelete = (int)dgvResponsables.SelectedRows[0].Tag;
                string query = "UPDATE Responsables SET IsActive = 0 WHERE ResponsableID = @ID";
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
                catch (Exception ex) { MessageBox.Show("Error deleting responsable: " + ex.Message); }
            }
        }
    }
}