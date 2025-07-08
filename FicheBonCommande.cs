using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using static TAPTAGPOS.PopupTableArticles;

namespace TAPTAGPOS
{
    public partial class FicheBonCommande : Form
    {
        private string connectionString = DatabaseConnection.GetConnectionString();
        private int _bonCommandeId = 0;
        private bool _isEditMode = false;
        private int _selectedSupplierId = 0;
        public FicheBonCommande()
        {
            InitializeComponent();
            this.Load += FicheBonCommande_Load;
            this.btnAjouterLigne.Click += btnAjouterLigne_Click;
            this.btnSupprimerLigne.Click += btnSupprimerLigne_Click;
            this.dgvLignes.CellValueChanged += (s, e) => RecalculateTotals();
            this.btnOK.Click += btnOK_Click;
        }
        public FicheBonCommande(int bonCommandeId = 0)
        {
            InitializeComponent();

            if (bonCommandeId > 0)
            {
                _isEditMode = true;
                _bonCommandeId = bonCommandeId;
            }

            // Wire up all events
            this.Load += FicheBonCommande_Load;
            this.btnAjouterLigne.Click += btnAjouterLigne_Click;
            this.btnSupprimerLigne.Click += btnSupprimerLigne_Click;
            this.dgvLignes.CellValueChanged += (s, e) => RecalculateTotals();
            this.btnOK.Click += btnOK_Click;
            this.btnAnnuler.Click += (s, e) => this.Close();
        }
        private void LoadBonCommandeForEditing(int bonCommandeId)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM BonCommandes WHERE BC_ID = @BC_ID";
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@BC_ID", bonCommandeId);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtBC.Text = reader["BC_Number"]?.ToString();
                            dtpDate.Value = Convert.ToDateTime(reader["BC_Date"]);
                            _selectedSupplierId = Convert.ToInt32(reader["SupplierID"]);

                            // Automatically select the correct supplier in the ComboBox
                            cmbSupplier.SelectedValue = _selectedSupplierId;
                        }
                    }
                }

                dgvLignes.Rows.Clear();
                string itemsQuery = @"
                    SELECT bci.*, a.Article as ItemCode, a.ArticleLongName as ItemName 
                    FROM BonCommandeItems bci
                    JOIN Articles a ON bci.ArticleID = a.Id
                    WHERE bci.BC_ID = @BC_ID";

                using (var itemsCmd = new SqlCommand(itemsQuery, conn))
                {
                    itemsCmd.Parameters.AddWithValue("@BC_ID", bonCommandeId);
                    using (var itemReader = itemsCmd.ExecuteReader())
                    {
                        while (itemReader.Read())
                        {
                            int rowIndex = dgvLignes.Rows.Add();
                            DataGridViewRow row = dgvLignes.Rows[rowIndex];
                            row.Tag = itemReader["ArticleID"];
                            row.Cells["colRef"].Value = itemReader["ItemCode"];
                            row.Cells["colDesignation"].Value = itemReader["ItemName"];
                            row.Cells["colQte"].Value = itemReader["Quantity"];
                            row.Cells["colPrix"].Value = itemReader["UnitPriceHT"];
                            row.Cells["colTva"].Value = itemReader["TVA_Rate"];
                        }
                    }
                }
            }
            RecalculateTotals();
        }
        private void cmbSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSupplier.SelectedValue != null && int.TryParse(cmbSupplier.SelectedValue.ToString(), out int id))
            {
                _selectedSupplierId = id;
            }
        }
       
        private void FicheBonCommande_Load(object sender, EventArgs e)
        {
            LoadSuppliers();
            if (_isEditMode)
            {
                this.Text = "Modifier Bon de Commande";
                LoadBonCommandeForEditing(_bonCommandeId);
            }
            else
            {
                this.Text = "Nouveau Bon de Commande";
                GenerateNewBCNumber();
                dtpDate.Value = DateTime.Now;
            }
            this.cmbSupplier.SelectedIndexChanged += cmbSupplier_SelectedIndexChanged;

        }
        private void LoadSuppliers()
        {
            try
            {
                var dt = new DataTable();
                using (var adapter = new SqlDataAdapter("SELECT SupplierID, Name FROM Suppliers WHERE Status = 'Active' ORDER BY Name", connectionString))
                {
                    adapter.Fill(dt);
                }

                // Add a placeholder row at the top of the list
                DataRow placeholder = dt.NewRow();
                placeholder["SupplierID"] = 0;
                placeholder["Name"] = "-- Choisir un fournisseur --";
                dt.Rows.InsertAt(placeholder, 0);

                cmbSupplier.DataSource = dt;
                cmbSupplier.DisplayMember = "Name";
                cmbSupplier.ValueMember = "SupplierID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading suppliers: " + ex.Message);
            }
        }
        private void GenerateNewBCNumber()
        {
            txtBC.Text = $"BC-{DateTime.Now:yyyy}-{AppSettingsManager.SerieBonCmd:D5}";
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
                        // Add the new line to the grid
                        int rowIndex = dgvLignes.Rows.Add();
                        DataGridViewRow row = dgvLignes.Rows[rowIndex];
                        row.Tag = article.Id; // Store the ArticleID
                        row.Cells["colRef"].Value = article.Id;
                        row.Cells["colDesignation"].Value = article.ArticleCode;
                        row.Cells["colQte"].Value = quantity;
                        row.Cells["colPrix"].Value = article.BuyPrice; // Use BuyPrice for purchase orders
                        row.Cells["colTva"].Value = 20; // Default TVA, user can edit this

                        RecalculateTotals();
                    }
                }
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
                decimal prixHT = Convert.ToDecimal(row.Cells["colPrix"].Value ?? 0);
                decimal tvaRate = Convert.ToDecimal(row.Cells["colTva"].Value ?? 0);

                decimal lineTotalHT = qty * prixHT;
                decimal lineTVA = lineTotalHT * (tvaRate / 100);
                decimal lineTotalTTC = lineTotalHT + lineTVA;

                row.Cells["colTotal"].Value = lineTotalTTC; 

                totalHT += lineTotalHT;
                totalTVA += lineTVA;
            }

            txtTotalHT.Text = totalHT.ToString("N2");
            txtTva.Text = totalTVA.ToString("N2");
            txtTotalTTC.Text = (totalHT + totalTVA).ToString("N2");
        }
        private void ExecuteInsert(SqlConnection conn, SqlTransaction transaction)
        {
            RecalculateTotals(); // Ensure totals are up-to-date
            string queryBC = "INSERT INTO BonCommandes (BC_Number, BC_Date, SupplierID, TotalHT, TotalTVA, TotalTTC, IsActive) OUTPUT INSERTED.BC_ID VALUES (@Num, @Date, @SID, @HT, @TVA, @TTC, 1)";
            int newBcId;
            using (var cmd = new SqlCommand(queryBC, conn, transaction))
            {
                cmd.Parameters.AddWithValue("@Num", txtBC.Text);
                cmd.Parameters.AddWithValue("@Date", dtpDate.Value);
                cmd.Parameters.AddWithValue("@SID", this._selectedSupplierId);
                cmd.Parameters.AddWithValue("@HT", Convert.ToDecimal(txtTotalHT.Text));
                cmd.Parameters.AddWithValue("@TVA", Convert.ToDecimal(txtTva.Text));
                cmd.Parameters.AddWithValue("@TTC", Convert.ToDecimal(txtTotalTTC.Text));
                newBcId = (int)cmd.ExecuteScalar();
            }

            // Save each line item
            foreach (DataGridViewRow row in dgvLignes.Rows)
            {
                SaveItem(conn, transaction, newBcId, row);
            }

            // Increment the serial number
        }

        private void ExecuteUpdate(SqlConnection conn, SqlTransaction transaction)
        {
            RecalculateTotals(); // Ensure totals are up-to-date
            string queryBC = "UPDATE BonCommandes SET BC_Date=@Date, SupplierID=@SID, TotalHT=@HT, TotalTVA=@TVA, TotalTTC=@TTC WHERE BC_ID=@BCID";
            using (var cmd = new SqlCommand(queryBC, conn, transaction))
            {
                cmd.Parameters.AddWithValue("@Date", dtpDate.Value);
                cmd.Parameters.AddWithValue("@SID", this._selectedSupplierId);
                cmd.Parameters.AddWithValue("@HT", Convert.ToDecimal(txtTotalHT.Text));
                cmd.Parameters.AddWithValue("@TVA", Convert.ToDecimal(txtTva.Text));
                cmd.Parameters.AddWithValue("@TTC", Convert.ToDecimal(txtTotalTTC.Text));
                cmd.Parameters.AddWithValue("@BCID", _bonCommandeId);
                cmd.ExecuteNonQuery();
            }

            // Delete old items
            using (var cmd = new SqlCommand("DELETE FROM BonCommandeItems WHERE BC_ID = @BCID", conn, transaction))
            {
                cmd.Parameters.AddWithValue("@BCID", _bonCommandeId);
                cmd.ExecuteNonQuery();
            }

            // Re-insert current items
            foreach (DataGridViewRow row in dgvLignes.Rows)
            {
                SaveItem(conn, transaction, _bonCommandeId, row);
            }
        }

        private void SaveItem(SqlConnection conn, SqlTransaction transaction, int bcId, DataGridViewRow row)
        {
            if (row.IsNewRow) return;

            // The query no longer includes ItemName and ItemCode
            string queryItems = "INSERT INTO BonCommandeItems (BC_ID, ArticleID, Quantity, UnitPriceHT, TVA_Rate) VALUES (@BCID, @ArtID, @Qty, @Price, @TVA)";

            using (var cmd = new SqlCommand(queryItems, conn, transaction))
            {
                cmd.Parameters.AddWithValue("@BCID", bcId);
                cmd.Parameters.AddWithValue("@ArtID", Convert.ToInt32(row.Tag ?? 0));
                cmd.Parameters.AddWithValue("@Qty", Convert.ToDecimal(row.Cells["colQte"].Value ?? 0));
                cmd.Parameters.AddWithValue("@Price", Convert.ToDecimal(row.Cells["colPrix"].Value ?? 0));
                cmd.Parameters.AddWithValue("@TVA", Convert.ToDecimal(row.Cells["colTva"].Value ?? 0));
                cmd.ExecuteNonQuery();
            }
        }
        // --- THIS IS THE NEW, MISSING METHOD ---
        private void UpdateNextBCNumber(SqlConnection conn, SqlTransaction transaction)
        {
            try
            {
                int nextSerial = AppSettingsManager.SerieBonCmd + 1;
                string queryUpdateSerial = "UPDATE AppSettings SET SettingValue = @NewValue WHERE SettingKey = 'SerieBonCmd'";
                using (var cmd = new SqlCommand(queryUpdateSerial, conn, transaction))
                {
                    cmd.Parameters.AddWithValue("@NewValue", nextSerial.ToString());
                    cmd.ExecuteNonQuery();
                }
                // Refresh the settings in the application so the new number is available immediately
                AppSettingsManager.LoadSettings();
            }
            catch (Exception ex)
            {
                // Throw the exception so the transaction can be rolled back
                throw new Exception("Could not update the Bon de Commande serial number.", ex);
            }
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (this._selectedSupplierId <= 0 || dgvLignes.Rows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un fournisseur et ajouter au moins un article.", "Validation");
                return;
            }

            bool isSaveSuccessful = false;
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (var transaction = conn.BeginTransaction())
                {
                    try
                    {
                        if (_isEditMode)
                        {
                            ExecuteUpdate(conn, transaction);
                        }
                        else
                        {
                            ExecuteInsert(conn, transaction);
                        }

                        // Commit all database changes first to release the locks
                        transaction.Commit();
                        isSaveSuccessful = true;
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Error saving Bon de Commande: " + ex.Message);
                    }
                }
            }

            // --- THIS PART NOW RUNS *AFTER* THE DATABASE TRANSACTION IS CLOSED ---
            if (isSaveSuccessful)
            {
                // If it was a NEW Bon de Commande, we now safely update the settings
                if (!_isEditMode)
                {
                    try
                    {
                        // Get the latest serial number and increment it in memory
                        int nextSerial = AppSettingsManager.SerieBonCmd + 1;
                        // Create a NEW connection to update the setting
                        using (var conn = new SqlConnection(connectionString))
                        using (var cmd = new SqlCommand("UPDATE AppSettings SET SettingValue = @NewValue WHERE SettingKey = 'SerieBonCmd'", conn))
                        {
                            cmd.Parameters.AddWithValue("@NewValue", nextSerial.ToString());
                            conn.Open();
                            cmd.ExecuteNonQuery();
                        }
                        // Finally, reload the settings into the application
                        AppSettingsManager.LoadSettings();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Bon de commande enregistré, mais échec de la mise à jour du numéro de série : " + ex.Message);
                    }
                }

                MessageBox.Show(_isEditMode ? "Bon de commande mis à jour!" : "Bon de commande enregistré!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnImprimer_Click(object sender, EventArgs e)
        {
            if (dgvLignes.Rows.Count == 0) return;

            // --- Print WITH Prices ---
            var headers = new List<string> { "Référence", "Désignation", "Qte", "Prix HT", "TVA %", "Total TTC" };
            var columnWidths = new List<float> { 0.15f, 0.35f, 0.10f, 0.15f, 0.10f, 0.15f };

            var dtToPrint = new DataTable();
            foreach (string header in headers) { dtToPrint.Columns.Add(header); }

            foreach (DataGridViewRow row in dgvLignes.Rows)
            {
                if (row.IsNewRow) continue;
                dtToPrint.Rows.Add(
                    row.Cells["colRef"].Value,
                    row.Cells["colDesignation"].Value,
                    row.Cells["colQte"].Value,
                    Convert.ToDecimal(row.Cells["colPrix"].Value).ToString("N2"),
                    row.Cells["colTva"].Value,
                    Convert.ToDecimal(row.Cells["colTotal"].Value).ToString("N2")
                );
            }

            var summary = new Dictionary<string, string>
            {
                { "Total HT", txtTotalHT.Text },
                { "Total TVA", txtTva.Text },
                { "Total TTC", txtTotalTTC.Text }
            };

            string title = $"Bon de Commande: {txtBC.Text}";
            string subTitle = $"Fournisseur: {cmbSupplier.Text}\nDate: {dtpDate.Value:dd/MM/yyyy}";

            var printer = new ReportPrinter(dtToPrint, headers, columnWidths, title, subTitle, summary);
            printer.Print(false); // false for Portrait
        }

        private void btnImprimerSansEP_Click(object sender, EventArgs e)
        {
            if (dgvLignes.Rows.Count == 0) return;

            // --- Print WITHOUT Prices ---
            var headers = new List<string> { "Référence", "Désignation", "Quantité" };
            var columnWidths = new List<float> { 0.25f, 0.60f, 0.15f };

            var dtToPrint = new DataTable();
            foreach (string header in headers) { dtToPrint.Columns.Add(header); }

            foreach (DataGridViewRow row in dgvLignes.Rows)
            {
                if (row.IsNewRow) continue;
                dtToPrint.Rows.Add(
                    row.Cells["colRef"].Value,
                    row.Cells["colDesignation"].Value,
                    row.Cells["colQte"].Value
                );
            }

            var summary = new Dictionary<string, string>(); // No summary for this version

            string title = $"Bon de Commande (Réception): {txtBC.Text}";
            string subTitle = $"Fournisseur: {cmbSupplier.Text}\nDate: {dtpDate.Value:dd/MM/yyyy}";

            var printer = new ReportPrinter(dtToPrint, headers, columnWidths, title, subTitle, summary);
            printer.Print(false); // false for Portrait
        }
    }
}