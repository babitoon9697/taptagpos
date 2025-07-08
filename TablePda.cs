using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace TAPTAGPOS
{
    public partial class TablePda : Form
    {
        private string connectionString = DatabaseConnection.GetConnectionString();

        public TablePda()
        {
            InitializeComponent();
            this.Load += TablePda_Load;
            this.btnModifier.Click += btnModifier_Click;
            this.btnSupprimer.Click += btnSupprimer_Click;
        }

        private void TablePda_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            dgvPda.Rows.Clear();
            string query = @"
                SELECT p.PdaID, p.NomPda, c.Nom AS Vendeur, p.Couleur
                FROM PDAs p
                LEFT JOIN Commerciaux c ON p.CommercialID = c.CommercialID
                WHERE p.IsActive = 1
                ORDER BY p.NomPda";

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
                            int rowIndex = dgvPda.Rows.Add();
                            DataGridViewRow row = dgvPda.Rows[rowIndex];
                            row.Tag = reader["PdaID"];
                            row.Cells["colNomPda"].Value = reader["NomPda"];
                            row.Cells["colVendeur"].Value = reader["Vendeur"];

                            // Color the cell for visual feedback
                            string colorHex = reader["Couleur"]?.ToString();
                            if (!string.IsNullOrEmpty(colorHex))
                            {
                                row.Cells["colCouleur"].Value = colorHex;
                                try { row.Cells["colCouleur"].Style.BackColor = ColorTranslator.FromHtml(colorHex); }
                                catch { /* Ignore invalid color codes */ }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading PDA data: " + ex.Message);
            }
        }

        private void btnNouveau_Click(object sender, EventArgs e)
        {
            using (FichePda editorForm = new FichePda())
            {
                if (editorForm.ShowDialog(this) == DialogResult.OK)
                {
                    LoadData();
                }
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (dgvPda.SelectedRows.Count == 0) return;
            int idToEdit = (int)dgvPda.SelectedRows[0].Tag;
            using (FichePda editorForm = new FichePda(idToEdit))
            {
                if (editorForm.ShowDialog(this) == DialogResult.OK)
                {
                    LoadData();
                }
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (dgvPda.SelectedRows.Count == 0) return;
            if (MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string query = "UPDATE PDAs SET IsActive = 0 WHERE PdaID = @ID";

                int idToDelete = (int)dgvPda.SelectedRows[0].Tag;
                using (var conn = new SqlConnection(connectionString))

                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.ExecuteNonQuery();
                    LoadData();
                }
            }
        }
    }
}