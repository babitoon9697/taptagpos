using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TAPTAGPOS
{
    public partial class TableMachines : Form
    {
        private string connectionString = DatabaseConnection.GetConnectionString();

        public TableMachines()
        {
            InitializeComponent();
            this.Load += (s, e) => LoadData();
            this.btnModifier.Click += btnModifier_Click;
            this.btnSupprimer.Click += btnSupprimer_Click;
            this.btnFermer.Click += (s, e) => this.Close();
        }

        private void LoadData()
        {
            dgvMachines.Rows.Clear();
            string query = "SELECT MachineID, MachineName, Marque, DateAcquisition, Capacite FROM Machines WHERE ISNULL(IsActive, 1) = 1 ORDER BY MachineName";
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
                            int rowIndex = dgvMachines.Rows.Add();
                            DataGridViewRow row = dgvMachines.Rows[rowIndex];
                            row.Tag = reader["MachineID"];
                            row.Cells["colMachine"].Value = reader["MachineName"];
                            row.Cells["colMarque"].Value = reader["Marque"];
                            row.Cells["colCapacite"].Value = reader["Capacite"];
                            if (reader["DateAcquisition"] != DBNull.Value)
                            {
                                row.Cells["colDateAcquisition"].Value = ((DateTime)reader["DateAcquisition"]).ToShortDateString();
                            }
                        }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Error loading machines: " + ex.Message); }
        }

        private void btnNouveau_Click(object sender, EventArgs e)
        {
            using (FicheMachine editorForm = new FicheMachine())
            {
                if (editorForm.ShowDialog(this) == DialogResult.OK)
                {
                    LoadData();
                }
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (dgvMachines.SelectedRows.Count == 0) return;
            int idToEdit = (int)dgvMachines.SelectedRows[0].Tag;
            using (FicheMachine editorForm = new FicheMachine(idToEdit))
            {
                if (editorForm.ShowDialog(this) == DialogResult.OK)
                {
                    LoadData();
                }
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (dgvMachines.SelectedRows.Count == 0) return;
            if (MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int idToDelete = (int)dgvMachines.SelectedRows[0].Tag;
                string query = "UPDATE Machines SET IsActive = 0 WHERE MachineID = @ID";
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
                catch (Exception ex) { MessageBox.Show("Error deleting machine: " + ex.Message); }
            }
        }
    }
}