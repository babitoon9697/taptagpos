using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TAPTAGPOS
{
    public partial class FormMouvementBancaire : Form
    {
        private string connectionString = DatabaseConnection.GetConnectionString();

        public FormMouvementBancaire()
        {
            InitializeComponent();
            this.Load += (s, e) => LoadData();
            this.btnModifier.Click += btnModifier_Click;
            this.btnSupprimer.Click += btnSupprimer_Click;
            this.btnFermer.Click += (s, e) => this.Close();
            this.dgvMouvements.CellDoubleClick += (s, e) => btnModifier_Click(s, e);
        }

        private void LoadData()
        {
            dgvMouvements.Rows.Clear();
            string query = @"
                SELECT m.MouvementID, b.NomBanque, m.MouvementDate, m.Libelle, m.NumeroPiece, m.Credit, m.Debit 
                FROM MouvementsBancaires m
                JOIN Banques b ON m.BanqueID = b.BanqueID
                WHERE m.IsActive = 1 ORDER BY m.MouvementDate DESC";

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
                            int rowIndex = dgvMouvements.Rows.Add();
                            DataGridViewRow row = dgvMouvements.Rows[rowIndex];
                            row.Tag = reader["MouvementID"];
                            row.Cells["colCompte"].Value = reader["NomBanque"];
                            row.Cells["colDate"].Value = ((DateTime)reader["MouvementDate"]).ToShortDateString();
                            row.Cells["colLibelle"].Value = reader["Libelle"];
                            row.Cells["colPJ"].Value = reader["NumeroPiece"];
                            row.Cells["colCredit"].Value = Convert.ToDecimal(reader["Credit"]).ToString("N2");
                            row.Cells["colDebit"].Value = Convert.ToDecimal(reader["Debit"]).ToString("N2");
                        }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Error loading bank transactions: " + ex.Message); }
        }

        private void btnNouveau_Click(object sender, EventArgs e)
        {
            using (FicheCompte editorForm = new FicheCompte())
            {
                if (editorForm.ShowDialog(this) == DialogResult.OK)
                {
                    LoadData();
                }
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (dgvMouvements.SelectedRows.Count == 0) return;
            int idToEdit = (int)dgvMouvements.SelectedRows[0].Tag;
            using (FicheCompte editorForm = new FicheCompte(idToEdit))
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
            if (dgvMouvements.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un mouvement à supprimer.", "Aucune sélection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // 2. Ask the user for confirmation
            if (MessageBox.Show("Êtes-vous sûr de vouloir supprimer ce mouvement ?", "Confirmer la suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    // 3. Get the ID of the selected transaction from the row's Tag property
                    int idToDelete = Convert.ToInt32(dgvMouvements.SelectedRows[0].Tag);

                    // 4. Execute the soft delete query
                    string query = "UPDATE MouvementsBancaires SET IsActive = 0 WHERE MouvementID = @ID";

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
                    MessageBox.Show("Erreur lors de la suppression du mouvement : " + ex.Message, "Erreur Base de Données", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}