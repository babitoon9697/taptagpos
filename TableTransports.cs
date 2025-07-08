using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TAPTAGPOS
{
    public partial class TableTransports : Form
    {
        private string connectionString = DatabaseConnection.GetConnectionString();

        public TableTransports()
        {
            InitializeComponent();
            this.Load += (s, e) => LoadData();
            this.btnModifier.Click += btnModifier_Click;
            this.btnSupprimer.Click += btnSupprimer_Click;
            this.btnFermer.Click += (s, e) => this.Close();
            this.dgvTransports.CellDoubleClick += (s, e) => btnModifier_Click(s, e);
        }

        private void LoadData()
        {
            dgvTransports.Rows.Clear();
            string query = "SELECT TransportID, Code, RaisonSociale, Adresse, Telephone, Fax FROM Transports WHERE IsActive = 1 ORDER BY RaisonSociale";
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
                            int rowIndex = dgvTransports.Rows.Add();
                            DataGridViewRow row = dgvTransports.Rows[rowIndex];
                            row.Tag = reader["TransportID"];
                            row.Cells["colCode"].Value = reader["Code"];
                            row.Cells["colRaisonSociale"].Value = reader["RaisonSociale"];
                            row.Cells["colAdresse"].Value = reader["Adresse"];
                            row.Cells["colTelephone"].Value = reader["Telephone"];
                            row.Cells["colFax"].Value = reader["Fax"];
                        }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Error loading transport companies: " + ex.Message); }
        }

        private void btnNouveau_Click(object sender, EventArgs e)
        {
            using (FicheTransport editorForm = new FicheTransport())
            {
                if (editorForm.ShowDialog(this) == DialogResult.OK)
                {
                    LoadData();
                }
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (dgvTransports.SelectedRows.Count == 0) return;
            int idToEdit = (int)dgvTransports.SelectedRows[0].Tag;
            using (FicheTransport editorForm = new FicheTransport(idToEdit))
            {
                if (editorForm.ShowDialog(this) == DialogResult.OK)
                {
                    LoadData();
                }
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (dgvTransports.SelectedRows.Count == 0) return;
            if (MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                int idToDelete = (int)dgvTransports.SelectedRows[0].Tag;
                string query = "UPDATE Transports SET IsActive = 0 WHERE TransportID = @ID";
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
                catch (Exception ex) { MessageBox.Show("Error deleting transport company: " + ex.Message); }
            }
        }
    }
}