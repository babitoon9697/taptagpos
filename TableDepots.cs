using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TAPTAGPOS
{
    public partial class TableDepots : Form
    {
        private string connectionString = DatabaseConnection.GetConnectionString();

        public TableDepots()
        {
            InitializeComponent();
            this.Load += TableDepots_Load;
            this.btnModifier.Click += btnModifier_Click;
            this.btnSupprimer.Click += btnSupprimer_Click;
            this.btnFermer.Click += (s, e) => this.Close();
            this.dgvDepots.CellDoubleClick += (s, e) => btnModifier_Click(s, e);
        }

        private void TableDepots_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            dgvDepots.Rows.Clear();
            string query = "SELECT WarehouseID, WarehouseName, PrintSeparateTicket FROM Warehouses WHERE ISNULL(IsActive, 1) = 1 ORDER BY WarehouseName";
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
                            int rowIndex = dgvDepots.Rows.Add();
                            DataGridViewRow row = dgvDepots.Rows[rowIndex];
                            row.Tag = reader["WarehouseID"];
                            row.Cells["colDepot"].Value = reader["WarehouseName"];
                            row.Cells["colImpression"].Value = reader["PrintSeparateTicket"] != DBNull.Value && Convert.ToBoolean(reader["PrintSeparateTicket"]);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading depots: " + ex.Message);
            }
        }

        private void btnNouveau_Click(object sender, EventArgs e)
        {
            using (FicheDepot editorForm = new FicheDepot())
            {
                if (editorForm.ShowDialog(this) == DialogResult.OK)
                {
                    LoadData();
                }
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (dgvDepots.SelectedRows.Count == 0) return;
            int idToEdit = (int)dgvDepots.SelectedRows[0].Tag;
            using (FicheDepot editorForm = new FicheDepot(idToEdit))
            {
                if (editorForm.ShowDialog(this) == DialogResult.OK)
                {
                    LoadData();
                }
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (dgvDepots.SelectedRows.Count == 0) return;
            if (MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int idToDelete = (int)dgvDepots.SelectedRows[0].Tag;
                string query = "UPDATE Warehouses SET IsActive = 0 WHERE WarehouseID = @ID";
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
                catch (Exception ex) { MessageBox.Show("Error deleting depot: " + ex.Message); }
            }
        }
    }
}