using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TAPTAGPOS
{
    public partial class TableFichesTechniques : Form
    {
        private string connectionString = DatabaseConnection.GetConnectionString();

        public TableFichesTechniques()
        {
            InitializeComponent();
            this.Load += (s, e) => LoadData();
            this.btnModifier.Click += btnModifier_Click;
            this.btnConsulter.Click += (s, e) => btnModifier_Click(s, e); // Consulter is same as Modify
            this.btnSupprimer.Click += btnSupprimer_Click;
            this.btnFermer.Click += (s, e) => this.Close();
            this.dgvFiches.CellDoubleClick += (s, e) => btnModifier_Click(s, e);
        }

        private void LoadData()
        {
            dgvFiches.Rows.Clear();
            string query = @"
                SELECT f.FicheID, a.Article AS Reference, a.ArticleLongName AS Designation, f.CostPrice
                FROM FichesTechniques f
                JOIN Articles a ON f.ArticleID = a.Id
                WHERE f.IsActive = 1
                ORDER BY a.Article";

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
                            int rowIndex = dgvFiches.Rows.Add();
                            DataGridViewRow row = dgvFiches.Rows[rowIndex];
                            row.Tag = reader["FicheID"];
                            row.Cells["colReference"].Value = reader["Reference"];
                            row.Cells["colDesignation"].Value = reader["Designation"];
                            row.Cells["colPrixRevient"].Value = Convert.ToDecimal(reader["CostPrice"]).ToString("C2");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading fiches techniques: " + ex.Message);
            }
        }

        private void btnNouveau_Click(object sender, EventArgs e)
        {
            using (FicheTechnique editorForm = new FicheTechnique())
            {
                if (editorForm.ShowDialog(this) == DialogResult.OK)
                {
                    LoadData();
                }
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (dgvFiches.SelectedRows.Count == 0) return;
            int idToEdit = (int)dgvFiches.SelectedRows[0].Tag;
            using (FicheTechnique editorForm = new FicheTechnique(idToEdit))
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
            if (dgvFiches.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner une fiche à supprimer.", "Aucune sélection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // 2. Ask the user for confirmation
            if (MessageBox.Show("Êtes-vous sûr de vouloir supprimer cette fiche technique ?", "Confirmer la suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    // 3. Get the ID of the selected record from the row's Tag property
                    int idToDelete = Convert.ToInt32(dgvFiches.SelectedRows[0].Tag);

                    // 4. Execute the soft delete query
                    string query = "UPDATE FichesTechniques SET IsActive = 0 WHERE FicheID = @ID";

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
                    MessageBox.Show("Erreur lors de la suppression de la fiche technique: " + ex.Message, "Erreur Base de Données", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}