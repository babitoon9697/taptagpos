using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TAPTAGPOS
{
    public partial class TableBonCommande : Form
    {
        private string connectionString = DatabaseConnection.GetConnectionString();

        public TableBonCommande()
        {
            InitializeComponent();
            // Connect all event handlers in the constructor for clarity
            this.Load += (s, e) => LoadData();
            this.btnNouveau.Click += btnNouveau_Click;
            this.btnModifier.Click += btnModifier_Click;
            this.btnSupprimer.Click += btnSupprimer_Click;
            this.btnFermer.Click += (s, e) => this.Close();
            this.btnConvertToInvoice.Click += btnConvertToInvoice_Click;
        }
        private void btnNouveau_Click(object sender, EventArgs e)
        {
            // This opens the form to create a NEW purchase order
            using (FicheBonCommande editorForm = new FicheBonCommande())
            {
                editorForm.ShowDialog(this);
                LoadData(); // Refresh grid after the form closes
            }
        }
        private void btnConvertToInvoice_Click(object sender, EventArgs e)
        {
            if (dgvBonCommande.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un bon de commande à convertir.", "Aucune Sélection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int bonCommandeId = Convert.ToInt32(dgvBonCommande.SelectedRows[0].Tag);

            // 1. Create an instance of the Achat form
            Achat purchaseForm = new Achat();

            // 2. Call the new public method to load data from the purchase order
            purchaseForm.LoadFromBonCommande(bonCommandeId);

            // 3. Show the Achat form
            purchaseForm.Show();

            // 4. Refresh the list, the converted order should now disappear
            LoadData();
        }
    
        private void LoadData()
        {
            dgvBonCommande.Rows.Clear();
            // The query correctly joins with Suppliers and only shows active orders
            string query = @"
                SELECT bc.BC_ID, bc.BC_Number, bc.BC_Date, s.SupplierCode, s.Name 
                FROM BonCommandes bc
                JOIN Suppliers s ON bc.SupplierID = s.SupplierID
                WHERE bc.IsActive = 1
                ORDER BY bc.BC_Date DESC";

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
                            int rowIndex = dgvBonCommande.Rows.Add();
                            DataGridViewRow row = dgvBonCommande.Rows[rowIndex];
                            // Store the Primary Key (BC_ID) in the Tag property for easy access
                            row.Tag = reader["BC_ID"];
                            row.Cells["colBC"].Value = reader["BC_Number"];
                            row.Cells["colDate"].Value = ((DateTime)reader["BC_Date"]).ToShortDateString();
                            row.Cells["colCodeFournisseur"].Value = reader["SupplierCode"];
                            row.Cells["colFournisseur"].Value = reader["Name"];
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading purchase orders: " + ex.Message);
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (dgvBonCommande.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un bon de commande à modifier.", "Aucune Sélection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Get the ID from the selected row's Tag property
            int bonCommandeId = Convert.ToInt32(dgvBonCommande.SelectedRows[0].Tag);

            // Open the editor form in "Edit Mode" by passing the ID to its constructor
            using (FicheBonCommande editorForm = new FicheBonCommande(bonCommandeId))
            {
                editorForm.ShowDialog(this);
                LoadData(); // Refresh grid after the form closes
            }
        }

        // --- THIS IS THE NEW, IMPLEMENTED DELETE METHOD ---
        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (dgvBonCommande.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un bon de commande à supprimer.", "Aucune Sélection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int bonCommandeId = Convert.ToInt32(dgvBonCommande.SelectedRows[0].Tag);
            string bcNumber = dgvBonCommande.SelectedRows[0].Cells["colBC"].Value.ToString();

            // Ask for confirmation before deleting
            var confirmResult = MessageBox.Show($"Êtes-vous sûr de vouloir supprimer le Bon de Commande N°{bcNumber}?\nCette action est irréversible.",
                                                "Confirmer la Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    // This is a "soft delete". We set IsActive to 0 instead of permanently deleting.
                    string query = "UPDATE BonCommandes SET IsActive = 0 WHERE BC_ID = @BC_ID";
                    using (var conn = new SqlConnection(connectionString))
                    using (var cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@BC_ID", bonCommandeId);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Le bon de commande a été supprimé avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData(); // Refresh the grid to hide the deleted item
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting purchase order: " + ex.Message);
                }
            }
        }
    }
}