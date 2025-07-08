using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TAPTAGPOS
{
    public partial class TableBanque : Form
    {
        private string connectionString = DatabaseConnection.GetConnectionString();

        public TableBanque()
        {
            InitializeComponent();
            // Link all events in the constructor
            this.Load += TableBanque_Load;
            this.btnModifier.Click += btnModifier_Click;
            this.btnSupprimer.Click += btnSupprimer_Click;
            this.btnFermer.Click += (s, e) => this.Close();
            this.dgvBanques.CellDoubleClick += (s, e) => btnModifier_Click(s, e);
        }

        private void TableBanque_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            dgvBanques.Rows.Clear();
            string query = "SELECT BanqueID, NomBanque, NumCompte FROM Banques WHERE ISNULL(IsActive, 1) = 1 ORDER BY NomBanque";
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
                            int rowIndex = dgvBanques.Rows.Add();
                            DataGridViewRow row = dgvBanques.Rows[rowIndex];
                            row.Tag = reader["BanqueID"];
                            row.Cells["colBanque"].Value = reader["NomBanque"];
                            row.Cells["colNumCompte"].Value = reader["NumCompte"];
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading bank data: " + ex.Message);
            }
        }

        private void btnNouveau_Click(object sender, EventArgs e)
        {
            using (FicheBanque editorForm = new FicheBanque())
            {
                if (editorForm.ShowDialog(this) == DialogResult.OK)
                {
                    LoadData(); // Refresh the grid after adding
                }
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (dgvBanques.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a bank to modify.");
                return;
            }
            int idToEdit = (int)dgvBanques.SelectedRows[0].Tag;
            using (FicheBanque editorForm = new FicheBanque(idToEdit))
            {
                if (editorForm.ShowDialog(this) == DialogResult.OK)
                {
                    LoadData(); // Refresh the grid after editing
                }
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (dgvBanques.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a bank to delete.");
                return;
            }
            if (MessageBox.Show("Are you sure?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                int idToDelete = (int)dgvBanques.SelectedRows[0].Tag;
                string query = "UPDATE Banques SET IsActive = 0 WHERE BanqueID = @ID";
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
                    MessageBox.Show("Error deleting bank: " + ex.Message);
                }
            }
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {

        }
    }
}
