using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Windows.Forms;
using static TAPTAGPOS.Achat;

namespace TAPTAGPOS
{
    public partial class FicheFacture : Form
    {
        #region Class Members and Properties

        private readonly string connectionString = DatabaseConnection.GetConnectionString();

        // This will hold the ID of the customer selected for the invoice
        private int _selectedCustomerId = 0;
        private int _editingInvoiceId = 0;
        // This holds the default tax rate, which you can make configurable in AppSettingsManager
        private const decimal DefaultTvaRate = 0.20m; // 20% VAT, change as needed

        #endregion

        #region Constructor and Form Load

        public FicheFacture()
        {
            InitializeComponent();
            SetupForm();
        }

        // You can use this constructor later to open and edit an existing invoice
        // public FicheFacture(int invoiceIdToEdit) : this()
        // {
        //    // Logic to load an existing invoice would go here
        // }
        public FicheFacture(int invoiceIdToEdit) : this()
        {
            this._editingInvoiceId = invoiceIdToEdit;
            this.Text = "Modifier la Facture";

            // Load the invoice data when the form opens in edit mode
            LoadInvoiceForEdit(invoiceIdToEdit);
        }
        private void LoadInvoiceForEdit(int invoiceId)
        {
            try
            {
                using (var conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    // 1. Load Invoice Header
                    string queryHeader = @"SELECT i.*, c.CustomerName 
                                   FROM Invoices i 
                                   JOIN Customers c ON i.CustomerID = c.CustomerID 
                                   WHERE i.InvoiceID = @ID";
                    using (var cmd = new SqlCommand(queryHeader, conn))
                    {
                        cmd.Parameters.AddWithValue("@ID", invoiceId);
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                _selectedCustomerId = Convert.ToInt32(reader["CustomerID"]);
                                txtFacture.Text = reader["InvoiceNumber"].ToString();
                                dtpDate.Value = Convert.ToDateTime(reader["InvoiceDate"]);
                                txtClientName.Text = reader["CustomerName"].ToString();
                                txtTotalBrut.Text = Convert.ToDecimal(reader["TotalBrut"]).ToString("N2");
                                txtRemiseTaux.Text = Convert.ToDecimal(reader["DiscountRate"]).ToString("N2");
                                txtRemiseMontant.Text = Convert.ToDecimal(reader["DiscountAmount"]).ToString("N2");
                                txtTotalHT.Text = Convert.ToDecimal(reader["TotalHT"]).ToString("N2");
                                txtTotalTVA.Text = Convert.ToDecimal(reader["TotalTVA"]).ToString("N2");
                                txtTotalTTC.Text = Convert.ToDecimal(reader["TotalTTC"]).ToString("N2");
                            }
                            else
                            {
                                MessageBox.Show("Facture introuvable.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                this.Close();
                                return;
                            }
                        }
                    }

                    // 2. Load Invoice Items
                    dgvLignes.Rows.Clear();
                    string queryItems = "SELECT * FROM InvoiceItems WHERE InvoiceID = @ID";
                    using (var cmd = new SqlCommand(queryItems, conn))
                    {
                        cmd.Parameters.AddWithValue("@ID", invoiceId);
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int rowIndex = dgvLignes.Rows.Add();
                                DataGridViewRow row = dgvLignes.Rows[rowIndex];
                                row.Tag = reader["ArticleID"];
                                row.Cells["colRef"].Value = reader["Reference"];
                                row.Cells["colDesignation"].Value = reader["Description"];
                                row.Cells["colQte"].Value = reader["Quantity"];
                                row.Cells["colPUHT"].Value = reader["UnitPriceHT"];
                                row.Cells["colTVA"].Value = Convert.ToDecimal(reader["TvaRate"]) * 100;
                                row.Cells["colTotal"].Value = reader["TotalHT"];
                            }
                        }
                    }
                    RecalculateTotals();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement de la facture: " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void SetupForm()
        {
            // Attach event handlers to controls
            this.Load += FicheFacture_Load;
            this.btnSelectClient.Click += BtnSelectClient_Click;
            this.btnAjouter.Click += BtnAjouter_Click;
            this.btnEnlever.Click += BtnEnlever_Click;
            this.dgvLignes.CellValueChanged += DgvLignes_CellValueChanged;
            this.txtRemiseTaux.TextChanged += TxtRemise_TextChanged;
            this.txtRemiseMontant.TextChanged += TxtRemise_TextChanged;
            this.btnOK.Click += BtnOK_Click;
            this.btnFermer.Click += (s, e) => this.Close();
            this.btnAnnuler.Click += (s, e) => ClearForm();
        }

        private void FicheFacture_Load(object sender, EventArgs e)
        {
            // When the form loads, prepare it for a new invoice
            ClearForm();
        }

        #endregion

        #region Core UI Logic (Adding, Removing, Calculating)

        private void BtnSelectClient_Click(object sender, EventArgs e)
        {
            using (var customerListForm = new frmCustomersList())
            {
                if (customerListForm.ShowDialog(this) == DialogResult.OK)
                {
                    _selectedCustomerId = customerListForm.SelectedCustomerId;
                    txtClientName.Text = customerListForm.SelectedCustomerName;
                }
            }
        }

        private void BtnAjouter_Click(object sender, EventArgs e)
        {
            // Use the existing article popup to select an item to add to the invoice
            using (var popup = new PopupTableArticles(PopupTableArticles.ArticleSelectionMode.Single))
            {
                if (popup.ShowDialog(this) == DialogResult.OK && popup.SelectedArticle != null)
                {
                    var article = popup.SelectedArticle;

                    // Add the selected article as a new row in the grid
                    int rowIndex = dgvLignes.Rows.Add();
                    DataGridViewRow row = dgvLignes.Rows[rowIndex];

                    row.Cells["colRef"].Value = article.ArticleCode;
                    row.Cells["colDesignation"].Value = article.ArticleLongName;
                    row.Cells["colQte"].Value = 1; // Default quantity
                    row.Cells["colPUHT"].Value = article.SellPrice / (1 + DefaultTvaRate); // Calculate Price HT from Sell Price TTC
                    row.Cells["colTVA"].Value = DefaultTvaRate * 100; // Show TVA as percentage

                    // Store the Article ID in the row's Tag for later use
                    row.Tag = article.Id;
                }
            }
        }

        private void BtnEnlever_Click(object sender, EventArgs e)
        {
            if (dgvLignes.SelectedRows.Count > 0)
            {
                dgvLignes.Rows.Remove(dgvLignes.SelectedRows[0]);
                RecalculateTotals();
            }
        }

        private void DgvLignes_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // When a cell value changes (e.g., quantity), recalculate everything
            if (e.RowIndex >= 0)
            {
                RecalculateTotals();
            }
        }

        private void TxtRemise_TextChanged(object sender, EventArgs e)
        {
            // If the discount changes, recalculate
            RecalculateTotals();
        }

        #endregion

        #region Calculation Engine

        private void RecalculateTotals()
        {
            decimal totalBrutHT = 0;

            // Calculate total for each line and sum them up
            foreach (DataGridViewRow row in dgvLignes.Rows)
            {
                if (row.IsNewRow) continue;

                decimal qte = Convert.ToDecimal(row.Cells["colQte"].Value ?? 0);
                decimal puht = Convert.ToDecimal(row.Cells["colPUHT"].Value ?? 0);

                decimal totalLigne = qte * puht;
                row.Cells["colTotal"].Value = totalLigne.ToString("N2");

                totalBrutHT += totalLigne;
            }

            txtTotalBrut.Text = totalBrutHT.ToString("N2");

            // Calculate discount
            decimal tauxRemise = decimal.TryParse(txtRemiseTaux.Text, out tauxRemise) ? tauxRemise / 100m : 0;
            decimal montantRemise = totalBrutHT * tauxRemise;
            txtRemiseMontant.Text = montantRemise.ToString("N2");

            // Calculate final totals
            decimal totalNetHT = totalBrutHT - montantRemise;
            decimal totalTVA = totalNetHT * DefaultTvaRate;
            decimal totalTTC = totalNetHT + totalTVA;

            txtTotalHT.Text = totalNetHT.ToString("N2");
            txtTotalTVA.Text = totalTVA.ToString("N2");
            txtTotalTTC.Text = totalTTC.ToString("N2");
        }

        #endregion

        #region Database Operations (Save Invoice)

        private void BtnOK_Click(object sender, EventArgs e)
        {
            // --- 1. Validation ---
            if (_selectedCustomerId == 0)
            {
                MessageBox.Show("Veuillez sélectionner un client.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dgvLignes.Rows.Count == 0 || dgvLignes.Rows[0].IsNewRow)
            {
                MessageBox.Show("Veuillez ajouter au moins un article à la facture.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // --- 2. Save using a transaction ---
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();
                try
                {
                    // --- 3. Insert into Invoices table ---
                    string queryInvoice = @"
                        INSERT INTO Invoices (InvoiceNumber, InvoiceDate, CustomerID, TotalBrut, DiscountRate, DiscountAmount, TotalHT, TotalTVA, TotalTTC, CreatedBy)
                        OUTPUT INSERTED.InvoiceID
                        VALUES (@Num, @Date, @CID, @Brut, @RemTaux, @RemMontant, @HT, @TVA, @TTC, @User)";

                    int newInvoiceId;
                    using (var cmd = new SqlCommand(queryInvoice, conn, transaction))
                    {
                        cmd.Parameters.AddWithValue("@Num", txtFacture.Text);
                        cmd.Parameters.AddWithValue("@Date", dtpDate.Value);
                        cmd.Parameters.AddWithValue("@CID", _selectedCustomerId);
                        cmd.Parameters.AddWithValue("@Brut", Convert.ToDecimal(txtTotalBrut.Text));
                        cmd.Parameters.AddWithValue("@RemTaux", Convert.ToDecimal(txtRemiseTaux.Text ?? "0"));
                        cmd.Parameters.AddWithValue("@RemMontant", Convert.ToDecimal(txtRemiseMontant.Text));
                        cmd.Parameters.AddWithValue("@HT", Convert.ToDecimal(txtTotalHT.Text));
                        cmd.Parameters.AddWithValue("@TVA", Convert.ToDecimal(txtTotalTVA.Text));
                        cmd.Parameters.AddWithValue("@TTC", Convert.ToDecimal(txtTotalTTC.Text));
                        cmd.Parameters.AddWithValue("@User", SessionManager.CurrentUser); // Using the session manager

                        newInvoiceId = (int)cmd.ExecuteScalar();
                    }

                    // --- 4. Insert each line into InvoiceItems table ---
                    string queryItem = @"
                        INSERT INTO InvoiceItems (InvoiceID, ArticleID, Reference, Description, Quantity, UnitPriceHT, TvaRate, TotalHT)
                        VALUES (@InvID, @ArtID, @Ref, @Desc, @Qty, @PUHT, @TVA, @TotalHT)";

                    foreach (DataGridViewRow row in dgvLignes.Rows)
                    {
                        if (row.IsNewRow) continue;
                        using (var cmd = new SqlCommand(queryItem, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@InvID", newInvoiceId);
                            cmd.Parameters.AddWithValue("@ArtID", (int)row.Tag); // Get Article ID from the Tag
                            cmd.Parameters.AddWithValue("@Ref", row.Cells["colRef"].Value);
                            cmd.Parameters.AddWithValue("@Desc", row.Cells["colDesignation"].Value);
                            cmd.Parameters.AddWithValue("@Qty", Convert.ToDecimal(row.Cells["colQte"].Value));
                            cmd.Parameters.AddWithValue("@PUHT", Convert.ToDecimal(row.Cells["colPUHT"].Value));
                            cmd.Parameters.AddWithValue("@TVA", Convert.ToDecimal(row.Cells["colTVA"].Value));
                            cmd.Parameters.AddWithValue("@TotalHT", Convert.ToDecimal(row.Cells["colTotal"].Value));
                            cmd.ExecuteNonQuery();
                        }
                    }

                    transaction.Commit();
                    MessageBox.Show("Facture enregistrée avec succès!", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // After saving, you can enable printing and clear the form
                    btnImprimer.Enabled = true;
                    ClearForm();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Erreur lors de l'enregistrement de la facture:\n" + ex.Message, "Erreur Base de Données", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        #endregion

        #region Helper Methods

        private void ClearForm()
        {
            _selectedCustomerId = 0;
            txtClientName.Clear();
            dgvLignes.Rows.Clear();
            txtRemiseTaux.Text = "0";
            txtRemiseMontant.Text = "0.00";
            dtpDate.Value = DateTime.Now;

            RecalculateTotals();
            GenerateNewInvoiceNumber();
        }

        private void GenerateNewInvoiceNumber()
        {
            // Use the same logic as Achat/Caisse forms, but with its own series from settings
            int nextSerial = AppSettingsManager.SerieFacture;
            txtFacture.Text = $"FAC-{DateTime.Now:yyyy}-{nextSerial:D5}";
        }

        #endregion
        private void Invoice_PrintPage(object sender, PrintPageEventArgs e, A4InvoicePrintData data, bool printHeader)
        {
            Graphics g = e.Graphics;
            using (Font titleFont = new Font("Arial", 18, FontStyle.Bold))
            using (Font headerFont = new Font("Arial", 10, FontStyle.Bold))
            using (Font bodyFont = new Font("Arial", 9, FontStyle.Regular))
            using (Pen blackPen = new Pen(Color.Black, 1))
            {
                float y = e.MarginBounds.Top;
                float x = e.MarginBounds.Left;
                float pageHeight = e.MarginBounds.Height;
                float pageWidth = e.MarginBounds.Width;

                // ===================================================================
                // START: This block is now conditional based on the 'printHeader' flag
                // ===================================================================
                if (printHeader)
                {
                    // 1. HEADER SECTION (Company Info)
                    g.DrawString("FACTURE", titleFont, Brushes.Black, x, y);
                    y += titleFont.GetHeight(g) + 10;

                    // Company Info
                    g.DrawString(data.CompanyName, headerFont, Brushes.Black, x, y);
                    y += headerFont.GetHeight(g);
                    g.DrawString(data.CompanyAddress, bodyFont, Brushes.Black, x, y);
                    y += bodyFont.GetHeight(g);
                    g.DrawString($"Tél: {data.CompanyPhone}", bodyFont, Brushes.Black, x, y);
                }
                // ===================================================================
                // END: Conditional block
                // ===================================================================


                // Invoice Info (on the right) - This part will always print
                float rightColX = x + pageWidth / 2;
                float yRight = e.MarginBounds.Top + titleFont.GetHeight(g) + 10;
                g.DrawString($"Facture N°: {data.InvoiceNumber}", headerFont, Brushes.Black, rightColX, yRight);
                yRight += headerFont.GetHeight(g);
                g.DrawString($"Date: {data.InvoiceDate:dd/MM/yyyy}", headerFont, Brushes.Black, rightColX, yRight);
                yRight += headerFont.GetHeight(g);
                g.DrawString($"Client: {data.CustomerName}", headerFont, Brushes.Black, rightColX, yRight);

                // Adjust starting Y position if header was not printed
                y = Math.Max(y, yRight) + 40;

                // 2. TABLE HEADER
                float tableY = y;
                float colRefX = x;
                float colDescX = x + 100;
                float colQtyX = x + 400;
                float colPUHTX = x + 460;
                float colTvaX = x + 540;
                float colTotalX = x + 600;

                g.FillRectangle(Brushes.LightGray, x, tableY, pageWidth, headerFont.GetHeight(g) + 10);
                g.DrawString("Réf.", headerFont, Brushes.Black, colRefX + 5, tableY + 5);
                g.DrawString("Désignation", headerFont, Brushes.Black, colDescX + 5, tableY + 5);
                g.DrawString("Qté", headerFont, Brushes.Black, colQtyX + 5, tableY + 5);
                g.DrawString("P.U. HT", headerFont, Brushes.Black, colPUHTX + 5, tableY + 5);
                g.DrawString("TVA %", headerFont, Brushes.Black, colTvaX + 5, tableY + 5);
                g.DrawString("Total HT", headerFont, Brushes.Black, colTotalX + 5, tableY + 5);
                y += headerFont.GetHeight(g) + 10;

                // 3. TABLE ROWS
                foreach (var item in data.Items)
                {
                    y += 5;
                    g.DrawString(item.Reference, bodyFont, Brushes.Black, colRefX + 5, y);
                    g.DrawString(item.Description, bodyFont, Brushes.Black, colDescX + 5, y);
                    g.DrawString(item.Quantity.ToString("N2"), bodyFont, Brushes.Black, colQtyX + 5, y);
                    g.DrawString(item.UnitPriceHT.ToString("C2"), bodyFont, Brushes.Black, colPUHTX + 5, y);
                    g.DrawString(item.TvaRate.ToString("P0"), bodyFont, Brushes.Black, colTvaX + 5, y);
                    g.DrawString(item.TotalHT.ToString("C2"), bodyFont, Brushes.Black, colTotalX + 5, y);
                    y += bodyFont.GetHeight(g) + 5;
                    g.DrawLine(blackPen, x, y, x + pageWidth, y);
                }

                // 4. TOTALS SECTION
                float totalsX = x + pageWidth / 2;
                y += 20;
                Action<string, decimal> drawTotalLine = (label, value) => {
                    g.DrawString(label, headerFont, Brushes.Black, totalsX, y);
                    g.DrawString(value.ToString("C2"), headerFont, Brushes.Black, totalsX + 150, y);
                    y += headerFont.GetHeight(g) + 5;
                };

                drawTotalLine("Total HT:", data.NetHT);
                drawTotalLine("Total TVA:", data.TotalTVA);
                g.DrawLine(blackPen, totalsX, y, totalsX + 250, y);
                y += 5;
                drawTotalLine("TOTAL TTC:", data.TotalTTC);
            }
        }
        private void btnImprimer_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Prepare the data object
                A4InvoicePrintData data = PrepareInvoiceDataForPrint();

                // 2. Setup Print Document
                PrintDocument pd = new PrintDocument();
                pd.DocumentName = $"Facture {data.InvoiceNumber}";
                pd.DefaultPageSettings.PaperSize = new PaperSize("A4", 827, 1169); // A4 dimensions in 1/100 inch
                pd.DefaultPageSettings.Landscape = false;

                // Pass the data to the PrintPage event handler
                pd.PrintPage += (s, ev) => Invoice_PrintPage(s, ev, data, true);
                // 3. Show Print Preview
                PrintPreviewDialog preview = new PrintPreviewDialog
                {
                    Document = pd,
                    WindowState = FormWindowState.Maximized
                };
                preview.ShowDialog(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la préparation de l'impression : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // This helper method gathers all the data from the form
        private A4InvoicePrintData PrepareInvoiceDataForPrint()
        {
            var data = new A4InvoicePrintData
            {
                // Load company info from settings
                CompanyName = AppSettingsManager.CompanyName,
                CompanyAddress = AppSettingsManager.CompanyAddress,
                CompanyPhone = AppSettingsManager.CompanyPhone,
                CompanyVatNumber = AppSettingsManager.VatNumber,

                // Load invoice info from form
                InvoiceNumber = txtFacture.Text,
                InvoiceDate = dtpDate.Value,
                CustomerName = txtClientName.Text, // Basic name from textbox

                // Load totals from textboxes
                TotalHT = decimal.Parse(txtTotalBrut.Text) - decimal.Parse(txtRemiseMontant.Text),
                DiscountAmount = decimal.Parse(txtRemiseMontant.Text),
                NetHT = decimal.Parse(txtTotalHT.Text),
                TotalTVA = decimal.Parse(txtTotalTVA.Text),
                TotalTTC = decimal.Parse(txtTotalTTC.Text)
                // You would need a library to convert TotalTTCInWords
            };

            // Load line items from the grid
            foreach (DataGridViewRow row in dgvLignes.Rows)
            {
                if (row.IsNewRow) continue;
                data.Items.Add(new InvoicePrintItem
                {
                    Reference = row.Cells["colRef"].Value?.ToString(),
                    Description = row.Cells["colDesignation"].Value?.ToString(),
                    Quantity = Convert.ToDecimal(row.Cells["colQte"].Value),
                    UnitPriceHT = Convert.ToDecimal(row.Cells["colPUHT"].Value),
                    TvaRate = Convert.ToDecimal(row.Cells["colTVA"].Value),
                    TotalHT = Convert.ToDecimal(row.Cells["colTotal"].Value)
                });
            }
            return data;
        }

        private void btnImprimerSansEP_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Prepare the data object (same as normal print)
                A4InvoicePrintData data = PrepareInvoiceDataForPrint();

                // 2. Setup Print Document
                PrintDocument pd = new PrintDocument();
                pd.DocumentName = $"Facture {data.InvoiceNumber}";
                pd.DefaultPageSettings.PaperSize = new PaperSize("A4", 827, 1169);
                pd.DefaultPageSettings.Landscape = false;

                // 3. Call the print method WITHOUT the header
                pd.PrintPage += (s, ev) => Invoice_PrintPage(s, ev, data, false);

                // 4. Show Print Preview
                PrintPreviewDialog preview = new PrintPreviewDialog
                {
                    Document = pd,
                    WindowState = FormWindowState.Maximized
                };
                preview.ShowDialog(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la préparation de l'impression : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}