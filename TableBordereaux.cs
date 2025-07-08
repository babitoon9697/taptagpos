using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TAPTAGPOS
{
    public partial class TableBordereaux : Form
    {
        private string connectionString = DatabaseConnection.GetConnectionString();

        public TableBordereaux()
        {
            InitializeComponent();
            this.Load += (s, e) => LoadData();
            // Link other buttons
        }

        private void LoadData()
        {
            dgvBordereaux.Rows.Clear();
            string query = @"
                SELECT b.BordereauID, b.BordereauNumber, b.BordereauDate, b.PaymentMethod, b.TotalAmount, t.RaisonSociale as Transport
                FROM Bordereaux b
                JOIN Transports t ON b.TransportID = t.TransportID
                WHERE b.IsActive = 1 ORDER BY b.BordereauDate DESC";

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
                            int rowIndex = dgvBordereaux.Rows.Add();
                            DataGridViewRow row = dgvBordereaux.Rows[rowIndex];
                            row.Tag = reader["BordereauID"];
                            row.Cells["colNum"].Value = reader["BordereauNumber"];
                            // ... Populate other cells from the reader ...
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading bordereaux: " + ex.Message);
            }
        }

        private void btnNouveau_Click(object sender, EventArgs e)
        {
            using (FicheBordereau editorForm = new FicheBordereau())
            {
                if (editorForm.ShowDialog(this) == DialogResult.OK)
                {
                    LoadData();
                }
            }
        }

        // ... Other button handlers for Modify, Delete, etc.
    }
}