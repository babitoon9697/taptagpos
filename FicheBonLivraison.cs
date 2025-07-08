using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using static TAPTAGPOS.PopupTableArticles; // For Interaction.InputBox

namespace TAPTAGPOS
{
    public partial class FicheBonLivraison : Form
    {
        private int selectedClientId = -1;
        private bool isEditMode = false;
        private int blId = 0;
        private string connectionString = DatabaseConnection.GetConnectionString();

        public FicheBonLivraison()
        {
            InitializeComponent();
            InitializeEventHandlers();
        }

        public FicheBonLivraison(int idToEdit) : this()
        {
            this.isEditMode = true;
            this.blId = idToEdit;
            this.Text = "Modifier Bon de Livraison";
        }

        private void InitializeEventHandlers()
        {
            this.Load += FicheBonLivraison_Load;
            this.btnSelectClient.Click += btnSelectClient_Click;
            this.btnAjouter.Click += btnAjouterLigne_Click;
            this.btnEnlever.Click += btnEnlever_Click;
            this.dgvLignes.CellValueChanged += (s, e) => RecalculateTotals();
            this.btnOK.Click += btnOK_Click;
            this.btnFermer.Click += (s, e) => this.Close();
            this.btnAnnuler.Click += (s, e) => this.Close();
        }

        private void FicheBonLivraison_Load(object sender, EventArgs e)
        {
            if (isEditMode)
            {
                // Logic to load an existing BL for editing
            }
            else
            {
                GenerateNewBLNumber();
                dtpDate.Value = DateTime.Now;
            }
        }

        private void GenerateNewBLNumber()
        {
            txtBL.Text = $"BL-{DateTime.Now:yyyy}-{AppSettingsManager.SerieBL:D5}";
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
                        row.Cells["colDesignation"].Value = article.ArticleLongName;
                        row.Cells["colQte"].Value = quantity;
                        row.Cells["colPUHT"].Value = article.SellPrice;
                        row.Cells["colTVA"].Value = 20; // Default VAT, user can edit
                        row.Cells["colRemise"].Value = 0; // Default discount

                        RecalculateTotals();
                    }
                }
            }
        }

        private void btnEnlever_Click(object sender, EventArgs e)
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
                decimal priceHT = Convert.ToDecimal(row.Cells["colPUHT"].Value ?? 0);
                decimal discount = Convert.ToDecimal(row.Cells["colRemise"].Value ?? 0);
                decimal tvaRate = Convert.ToDecimal(row.Cells["colTVA"].Value ?? 0);

                decimal lineTotalAfterDiscount = (qty * priceHT) * (1 - discount / 100);
                decimal lineTVA = lineTotalAfterDiscount * (tvaRate / 100);

                row.Cells["colTotal"].Value = lineTotalAfterDiscount + lineTVA;

                totalHT += lineTotalAfterDiscount;
                totalTVA += lineTVA;
            }

            txtTotalBrut.Text = totalHT.ToString("N2");
            txtTotalTVA.Text = totalTVA.ToString("N2");
            txtTotalTTC.Text = (totalHT + totalTVA).ToString("N2");
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            // Save logic for the Bon de Livraison will go here.
            // It will be a complex transaction involving multiple tables (BonLivraisons, BonLivraisonItems, Transactions, ArticleStock, Customers).
            MessageBox.Show("Save logic is the next step!");
        }
        // --- Helper method to find an article by its barcode ---
        private Article GetArticleByBarcode(string barcode)
        {
            // This logic is identical to the one in PopupTableArticles
            // It's best to move this to a central "DataManager" class later
            // to avoid duplication, but this will work for now.
            Article foundArticle = null;
            string query = "SELECT * FROM Articles WHERE JSON_VALUE(Barcodes, '$[0]') = @Barcode"; // Simplified search
            try
            {
                using (var conn = new SqlConnection(connectionString))
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Barcode", barcode);
                    conn.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            foundArticle = new Article
                            {
                                Id = (int)reader["Id"],
                                ArticleCode = reader["Article"]?.ToString(),
                                ArticleLongName = reader["ArticleLongName"]?.ToString(),
                                SellPrice = Convert.ToDecimal(reader["DetailsPrice"] ?? 0),
                                Barcode = barcode
                            };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error finding article: " + ex.Message);
            }
            return foundArticle;
        }

        // --- Helper to add an article to the grid ---
        private void AddArticleToGrid(Article article)
        {
            if (article == null) return;

            string qtyStr = Interaction.InputBox($"Enter Quantity for: {article.ArticleCode}", "Quantity", "1");
            if (decimal.TryParse(qtyStr, out decimal quantity) && quantity > 0)
            {
                int rowIndex = dgvLignes.Rows.Add();
                DataGridViewRow row = dgvLignes.Rows[rowIndex];
                row.Tag = article.Id;
                row.Cells["colRef"].Value = article.ArticleCode;
                row.Cells["colDesignation"].Value = article.ArticleLongName;
                row.Cells["colQte"].Value = quantity;
                row.Cells["colPUHT"].Value = article.SellPrice;
                row.Cells["colTVA"].Value = 20;
                row.Cells["colRemise"].Value = 0;

                RecalculateTotals();
            }
        }
        private void btnAjouterCodeBarre_Click(object sender, EventArgs e)
        {
            using (PopupCodeBarre barcodeForm = new PopupCodeBarre())
            {
                if (barcodeForm.ShowDialog(this) == DialogResult.OK)
                {
                    string barcode = barcodeForm.EnteredBarcode;
                    Article foundArticle = GetArticleByBarcode(barcode);

                    if (foundArticle != null)
                    {
                        AddArticleToGrid(foundArticle);
                    }
                    else
                    {
                        MessageBox.Show("Article with this barcode was not found.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

    }
}