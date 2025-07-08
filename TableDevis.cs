using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TAPTAGPOS
{
    public partial class TableDevis : Form
    {
        private string connectionString = DatabaseConnection.GetConnectionString();

        public TableDevis()
        {
            InitializeComponent();
            this.Load += (s, e) => LoadData();
            // Link all events here
            this.Load += (s, e) => LoadData();
            this.btnNouveauDevis.Click += btnNouveauDevis_Click;
            this.btnNouveauProformat.Click += btnNouveauProformat_Click;
            this.btnModifier.Click += btnModifier_Click;
            this.btnConsulter.Click += btnConsulter_Click;
            this.btnSupprimer.Click += btnSupprimer_Click;
            this.btnDevisToBL.Click += btnDevisToBL_Click;
            this.btnFermer.Click += btnFermer_Click;
            this.dgvDevis.CellDoubleClick += (s, e) => btnModifier_Click(s, e); // Double-click to edit

        }

        private void LoadData()
        {
            dgvDevis.Rows.Clear();
            string query = @"
                SELECT d.DevisID, d.DevisNumber, d.DevisDate, d.DocumentType, c.CustomerName, d.TotalTTC
                FROM Devis d
                JOIN Customers c ON d.CustomerID = c.CustomerID
                WHERE d.IsActive = 1
                ORDER BY d.DevisDate DESC";

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
                            int rowIndex = dgvDevis.Rows.Add();
                            DataGridViewRow row = dgvDevis.Rows[rowIndex];
                            row.Tag = reader["DevisID"];
                            row.Cells["colNumDevis"].Value = reader["DevisNumber"];
                            row.Cells["colDate"].Value = ((DateTime)reader["DevisDate"]).ToShortDateString();
                            row.Cells["colCat"].Value = reader["DocumentType"];
                            row.Cells["colClient"].Value = reader["CustomerName"];
                            row.Cells["colTotal"].Value = Convert.ToDecimal(reader["TotalTTC"]).ToString("C2");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading quotes: " + ex.Message);
            }
        }

        private void btnNouveauDevis_Click(object sender, EventArgs e)
        {
            using (FicheDevis editorForm = new FicheDevis { DocumentType = "Devis" })
            {
                editorForm.ShowDialog(this);
                LoadData();
            }
        }

        private void btnNouveauProformat_Click(object sender, EventArgs e)
        {
            using (FicheDevis editorForm = new FicheDevis { DocumentType = "Proforma" })
            {
                editorForm.ShowDialog(this);
                LoadData();
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (dgvDevis.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un devis à modifier.", "Aucune sélection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Get the ID from the selected row's Tag property
            int idToEdit = Convert.ToInt32(dgvDevis.SelectedRows[0].Tag);

            // Open FicheDevis in edit mode
            using (FicheDevis editorForm = new FicheDevis(idToEdit))
            {
                if (editorForm.ShowDialog(this) == DialogResult.OK)
                {
                    // Refresh the grid if changes were saved
                    LoadData();
                }
            }
        }

        private void btnConsulter_Click(object sender, EventArgs e)
        {
            // "Consulter" (View) will simply open the same editor form
            btnModifier_Click(sender, e);
        }
        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (dgvDevis.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un devis à supprimer.", "Aucune sélection");
                return;
            }

            if (MessageBox.Show("Êtes-vous sûr de vouloir supprimer ce document ?", "Confirmer la suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                int idToDelete = Convert.ToInt32(dgvDevis.SelectedRows[0].Tag);
                string query = "UPDATE Devis SET IsActive = 0 WHERE DevisID = @ID";
                try
                {
                    using (var conn = new SqlConnection(connectionString))
                    using (var cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ID", idToDelete);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        LoadData(); // Refresh grid to remove the item from view
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de la suppression: " + ex.Message);
                }
            }
        }
        private void btnDevisToBL_Click(object sender, EventArgs e)
        {
            if (dgvDevis.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un devis à transformer.", "Aucune sélection");
                return;
            }

            int devisId = Convert.ToInt32(dgvDevis.SelectedRows[0].Tag);
            string docType = dgvDevis.SelectedRows[0].Cells["colCat"].Value.ToString();

            if (docType != "Devis")
            {
                MessageBox.Show("Seuls les documents de type 'Devis' peuvent être transformés en Bon de Livraison.", "Opération non permise");
                return;
            }

            // Placeholder for the conversion logic
            MessageBox.Show($"La logique pour transformer le devis N°{devisId} en Bon de Livraison sera implémentée ici.\nCela ouvrira une nouvelle interface 'FicheBonLivraison'.", "Fonctionnalité à venir");
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}