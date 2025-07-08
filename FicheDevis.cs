using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Microsoft.VisualBasic;
using static TAPTAGPOS.PopupTableArticles;
namespace TAPTAGPOS
{
    public partial class FicheDevis : Form
    {
        private int selectedClientId = -1;
        private string connectionString = DatabaseConnection.GetConnectionString();
        private bool isEditMode = false;
        private int devisId = 0;


        // Add this property to your class
        public string DocumentType { get; set; } = "Devis"; // "Devis" or "Proforma"


        public FicheDevis()
        {
            InitializeComponent();
            this.Load += FicheDevis_Load;
            this.btnSelectClient.Click += btnSelectClient_Click;
            this.btnAjouterLigne.Click += btnAjouterLigne_Click;
            this.btnSupprimerLigne.Click += btnSupprimerLigne_Click;
            this.dgvLignes.CellValueChanged += (s, e) => RecalculateTotals();
            this.btnOK.Click += btnOK_Click;
        }

        public FicheDevis(int idToEdit) : this()
        {
            this.isEditMode = true;
            this.devisId = idToEdit;
        }

        private void FicheDevis_Load(object sender, EventArgs e)
        {
            this.Text = (DocumentType == "Devis") ? "Fiche Devis" : "Fiche Facture Proformat";
            if (isEditMode)
            {
                LoadDataForEdit();
            }
            else
            {
                GenerateNewDevisNumber();
            }
        }
        private void GenerateNewDevisNumber()
        {
            // Use the setting for the next "Devis" or "Proforma" number
            if (DocumentType == "Devis")
            {
                txtDevis.Text = $"DV-{DateTime.Now:yyyy}-{AppSettingsManager.SerieDevis:D5}";
            }
            else
            {
                txtDevis.Text = $"FP-{DateTime.Now:yyyy}-{AppSettingsManager.SerieProforma:D5}";
            }
        }
  

        private void btnSelectClient_Click(object sender, EventArgs e)
        {
            using (frmCustomersList customerSelector = new frmCustomersList())
            {
                if (customerSelector.ShowDialog(this) == DialogResult.OK)
                {
                    this.selectedClientId = customerSelector.SelectedCustomerId;
                    this.txtClientName.Text = customerSelector.SelectedCustomerName;
                }
            }
        }

        private void btnAjouterLigne_Click(object sender, EventArgs e)
        {
            using (var articleSelector = new PopupTableArticles(ArticleSelectionMode.Single))
            {
                if (articleSelector.ShowDialog(this) == DialogResult.OK && articleSelector.SelectedArticle != null)
                {
                    var article = articleSelector.SelectedArticle;
                    string qtyStr = Interaction.InputBox($"Enter Quantity for: {article.ArticleCode}", "Quantity", "1");
                    if (decimal.TryParse(qtyStr, out decimal quantity) && quantity > 0)
                    {
                        int rowIndex = dgvLignes.Rows.Add();
                        DataGridViewRow row = dgvLignes.Rows[rowIndex];
                        row.Tag = article.Id;
                        row.Cells["colRef"].Value = article.ArticleCode;
                        row.Cells["colLibelle"].Value = article.ArticleLongName;
                        row.Cells["colQte"].Value = quantity;
                        row.Cells["colPrix"].Value = article.SellPrice; // Use SellPrice for quotes
                        row.Cells["colTVA"].Value = 20; // Default TVA
                        row.Cells["colRemise"].Value = 0; // Default Discount
                        RecalculateTotals();
                    }
                }
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (this.selectedClientId <= 0)
            {
                MessageBox.Show("Veuillez sélectionner un client.", "Validation");
                return;
            }
            if (dgvLignes.Rows.Count == 0 || dgvLignes.Rows[0].IsNewRow)
            {
                MessageBox.Show("Veuillez ajouter au moins un article.", "Validation");
                return;
            }

            RecalculateTotals(); // Ensure totals are up-to-date before saving

            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                var transaction = conn.BeginTransaction();
                try
                {
                    if (isEditMode)
                    {
                        // --- UPDATE EXISTING DOCUMENT ---
                        string query = "UPDATE Devis SET DevisDate=@Date, CustomerID=@CID, TotalHT=@HT, TotalTVA=@TVA, TotalTTC=@TTC WHERE DevisID=@ID";
                        using (var cmd = new SqlCommand(query, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@Date", dtpDate.Value);
                            cmd.Parameters.AddWithValue("@CID", this.selectedClientId);
                            cmd.Parameters.AddWithValue("@HT", Convert.ToDecimal(txtTotalHT.Text));
                            cmd.Parameters.AddWithValue("@TVA", Convert.ToDecimal(txtTva.Text));
                            cmd.Parameters.AddWithValue("@TTC", Convert.ToDecimal(txtTotalTTC.Text));
                            cmd.Parameters.AddWithValue("@ID", this.devisId);
                            cmd.ExecuteNonQuery();
                        }

                        // Delete old items before re-inserting
                        using (var cmd = new SqlCommand("DELETE FROM DevisItems WHERE DevisID = @ID", conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@ID", this.devisId);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        // --- INSERT NEW DOCUMENT ---
                        string query = "INSERT INTO Devis (DevisNumber, DevisDate, CustomerID, DocumentType, TotalHT, TotalTVA, TotalTTC) OUTPUT INSERTED.DevisID VALUES (@Num, @Date, @CID, @Type, @HT, @TVA, @TTC)";
                        using (var cmd = new SqlCommand(query, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@Num", txtDevis.Text);
                            cmd.Parameters.AddWithValue("@Date", dtpDate.Value);
                            cmd.Parameters.AddWithValue("@CID", this.selectedClientId);
                            cmd.Parameters.AddWithValue("@Type", this.DocumentType);
                            cmd.Parameters.AddWithValue("@HT", Convert.ToDecimal(txtTotalHT.Text));
                            cmd.Parameters.AddWithValue("@TVA", Convert.ToDecimal(txtTva.Text));
                            cmd.Parameters.AddWithValue("@TTC", Convert.ToDecimal(txtTotalTTC.Text));
                            this.devisId = (int)cmd.ExecuteScalar(); // Get the new ID
                        }
                    }

                    // --- Save Line Items (for both Add and Edit) ---
                    string itemQuery = "INSERT INTO DevisItems (DevisID, ArticleID, Quantity, UnitPriceHT, DiscountPercentage, TVA_Rate) VALUES (@DevisID, @ArtID, @Qty, @Price, @Remise, @TVA)";
                    foreach (DataGridViewRow row in dgvLignes.Rows)
                    {
                        if (row.IsNewRow) continue;
                        using (var cmd = new SqlCommand(itemQuery, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@DevisID", this.devisId);
                            cmd.Parameters.AddWithValue("@ArtID", (int)row.Tag);
                            cmd.Parameters.AddWithValue("@Qty", Convert.ToDecimal(row.Cells["colQte"].Value));
                            cmd.Parameters.AddWithValue("@Price", Convert.ToDecimal(row.Cells["colPrix"].Value));
                            cmd.Parameters.AddWithValue("@Remise", Convert.ToDecimal(row.Cells["colRemise"].Value));
                            cmd.Parameters.AddWithValue("@TVA", Convert.ToDecimal(row.Cells["colTVA"].Value));
                            cmd.ExecuteNonQuery();
                        }
                    }

                    // Increment serial number only when adding a new one
                    if (!isEditMode)
                    {
                        string key = (DocumentType == "Devis") ? "SerieDevis" : "SerieProforma";
                        int nextSerial = (DocumentType == "Devis") ? AppSettingsManager.SerieDevis + 1 : AppSettingsManager.SerieProforma + 1;
                        string queryUpdateSerial = "UPDATE AppSettings SET SettingValue = @NewValue WHERE SettingKey = @Key";
                        using (var cmd = new SqlCommand(queryUpdateSerial, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@NewValue", nextSerial.ToString());
                            cmd.Parameters.AddWithValue("@Key", key);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    transaction.Commit();
                    AppSettingsManager.LoadSettings();
                    MessageBox.Show("Document enregistré avec succès!");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Error saving document: " + ex.Message);
                }
            }
        }
        private void LoadDataForEdit()
        {
            try
            {
                using (var conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    // Step 1: Load the main Devis details
                    string queryMain = "SELECT * FROM Devis WHERE DevisID = @ID";
                    using (var cmdMain = new SqlCommand(queryMain, conn))
                    {
                        cmdMain.Parameters.AddWithValue("@ID", this.devisId);
                        using (var reader = cmdMain.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                this.DocumentType = reader["DocumentType"].ToString();
                                this.Text = (this.DocumentType == "Devis") ? "Modifier Devis" : "Modifier Facture Proformat";

                                txtDevis.Text = reader["DevisNumber"].ToString();
                                dtpDate.Value = (DateTime)reader["DevisDate"];
                                this.selectedClientId = (int)reader["CustomerID"];

                                // We need a separate query to get the client's name
                            }
                        }
                    }

                    // Get Client Name
                    using (var cmdClient = new SqlCommand("SELECT CustomerName FROM Customers WHERE CustomerID = @CID", conn))
                    {
                        cmdClient.Parameters.AddWithValue("@CID", this.selectedClientId);
                        txtClientName.Text = cmdClient.ExecuteScalar()?.ToString();
                    }

                    // Step 2: Load the Devis items into the grid
                    dgvLignes.Rows.Clear();
                    string queryItems = @"SELECT di.ArticleID, a.Article, a.ArticleLongName, di.Quantity, di.UnitPriceHT, di.TVA_Rate, di.DiscountPercentage 
                                FROM DevisItems di JOIN Articles a ON di.ArticleID = a.Id
                                WHERE di.DevisID = @ID";
                    using (var cmdItems = new SqlCommand(queryItems, conn))
                    {
                        cmdItems.Parameters.AddWithValue("@ID", this.devisId);
                        using (var reader = cmdItems.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int rowIndex = dgvLignes.Rows.Add();
                                DataGridViewRow row = dgvLignes.Rows[rowIndex];
                                row.Tag = reader["ArticleID"];
                                row.Cells["colRef"].Value = reader["Article"];
                                row.Cells["colLibelle"].Value = reader["ArticleLongName"];
                                row.Cells["colQte"].Value = reader["Quantity"];
                                row.Cells["colPrix"].Value = reader["UnitPriceHT"];
                                row.Cells["colTVA"].Value = reader["TVA_Rate"];
                                row.Cells["colRemise"].Value = reader["DiscountPercentage"];
                            }
                        }
                    }
                }
                RecalculateTotals();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading document for editing: " + ex.Message);
                this.Close();
            }
        }
        private void btnSupprimerLigne_Click(object sender, EventArgs e)
        {
            if (dgvLignes.SelectedRows.Count > 0)
            {
                dgvLignes.Rows.Remove(dgvLignes.SelectedRows[0]);
                RecalculateTotals();
            }
        }

        private void RecalculateTotals()
        {
            decimal totalHT = 0;
            decimal totalTVA = 0;

            foreach (DataGridViewRow row in dgvLignes.Rows)
            {
                if (row.IsNewRow) continue;

                decimal qty = Convert.ToDecimal(row.Cells["colQte"].Value ?? 0);
                decimal price = Convert.ToDecimal(row.Cells["colPrix"].Value ?? 0);
                decimal remise = Convert.ToDecimal(row.Cells["colRemise"].Value ?? 0);
                decimal tvaRate = Convert.ToDecimal(row.Cells["colTVA"].Value ?? 0);

                decimal lineTotalHT = (qty * price) * (1 - remise / 100);
                decimal lineTVA = lineTotalHT * (tvaRate / 100);

                row.Cells["colTotal"].Value = lineTotalHT + lineTVA;

                totalHT += lineTotalHT;
                totalTVA += lineTVA;
            }

            txtTotalHT.Text = totalHT.ToString("N2");
            txtTva.Text = totalTVA.ToString("N2");
            txtTotalTTC.Text = (totalHT + totalTVA).ToString("N2");
        }

    }
}