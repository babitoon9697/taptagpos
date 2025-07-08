using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization; // For CultureInfo if using specific currency formats
using System.Linq;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.IO;
using System.Drawing;

namespace TAPTAGPOS
{
    public partial class Achat : Form
    {
        // SessionManager.cs
        public static class SessionManager
        {
            // You will set this property to the user's name when they successfully log in
            public static string CurrentUser { get; set; } = "DefaultUser"; // Default value
        }
        private A4PurchaseInvoiceData _currentA4InvoiceData; // هذا هو المتغير الذي كان ناقصاً

        #region Class Members & Constructors
        private Dictionary<string, int> supplierNameToIdMap = new Dictionary<string, int>();
      
        // --- Class Members ---
        private readonly string connectionString = DatabaseConnection.GetConnectionString();
        private List<Article> articles; // Holds the currently displayed page of articles for selection
        private int currentPage = 0;
        private const int itemsPerPage = 23; // Number of articles to show in the selection panel

        private int _selectedWarehouseId = 0; // 
        private string generatedInvoiceNumber;

        // --- Edit Mode Members ---
        private bool isEditMode = false;
        private int currentPurchaseInvoicePK = 0; // The Primary Key of the invoice being edited
        private List<PurchaseGridItem> originalInvoiceItems = new List<PurchaseGridItem>(); // Stores original items for stock calculation during edit
        private decimal originalGrandTotal = 0;
        private decimal originalAmountPaid = 0;

        // --- Printing Members ---
        private PurchaseTicketData _currentPurchaseTicketForPrint;
        private bool usePurchasePrintPreview = true; // true = Preview, false = Direct Print

        // --- Helper Constants ---
        private const string ArticleIdColName = "ArticleID";



        public Achat()
        {
            InitializeComponent();
            InitializeDefaultValues();
        }

        public Achat(int purchaseInvoicePrimaryKeyToEdit) : this()
        {
            this.isEditMode = true;
            this.currentPurchaseInvoicePK = purchaseInvoicePrimaryKeyToEdit;
        }
        #endregion
        #region Form Load & Data Preparation
        private void Achat_Load(object sender, EventArgs e)
        {
            // Configure the DataGridView if not done in the designer
            SetupPurchaseGrid();

            // Load initial data
            LoadSuppliers();
            LoadWarehouses();
            LoadArticlesForSelection();
            cmbWarehouse.SelectedIndexChanged += (s, ev) => LoadArticlesForSelection();

            if (isEditMode)
            {
                PrepareFormForEditMode();
                LoadPurchaseInvoiceForEditing(this.currentPurchaseInvoicePK);
            }
            else
            {
                PrepareFormForNewMode();
            }
            UpdateTotals();
        }
        public void LoadFromBonCommande(int bonCommandeId)
        {
            // This method will be called from the TableBonCommande form.
            // It will load all data from the selected purchase order.
            try
            {
                using (var conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    // 1. Load header data from the BonCommande
                    string headerQuery = "SELECT * FROM BonCommandes WHERE BC_ID = @BC_ID";
                    using (var cmd = new SqlCommand(headerQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@BC_ID", bonCommandeId);
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Set the supplier and other header info
                                _selectedSupplierId = Convert.ToInt32(reader["SupplierID"]);
                                cmbSuppliers.SelectedValue = _selectedSupplierId;
                                lbl_fournisseur.Text = cmbSuppliers.Text;
                                generatedInvoiceNumber = reader["BC_Number"].ToString();
                                lbl_CurrentInvoiceNumber.Text = generatedInvoiceNumber;
                            }
                        }
                    }

                    // 2. Load line items
                    DatagridArticles.Rows.Clear();
                    string itemsQuery = "SELECT * FROM BonCommandeItems WHERE BC_ID = @BC_ID";
                    using (var cmd = new SqlCommand(itemsQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@BC_ID", bonCommandeId);
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int articleId = Convert.ToInt32(reader["ArticleID"]);
                                int quantity = Convert.ToInt32(reader["Quantity"]);
                                // Fetch the full article to get its latest details
                                Article article = GetArticleById(articleId);
                                if (article != null)
                                {
                                    // Override the price with the one from the purchase order
                                    article.BuyPrice = Convert.ToDecimal(reader["UnitPriceHT"]);
                                    AddOrUpdateArticleInGrid(article, quantity);
                                }
                            }
                        }
                    }

                    // 3. Deactivate the old Bon de Commande so it cannot be used again
                    string updateQuery = "UPDATE BonCommandes SET IsActive = 0 WHERE BC_ID = @BC_ID";
                    using (var cmd = new SqlCommand(updateQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@BC_ID", bonCommandeId);
                        cmd.ExecuteNonQuery();
                    }
                }
                UpdateTotals();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading from Bon de Commande: " + ex.Message);
            }
        }
        // In Achat.cs

        private Article GetArticleById(int articleId)
        {
            // This query selects a single article by its primary key (ID)
            string query = "SELECT * FROM Articles WHERE Id = @ArticleID";
            Article foundArticle = null;

            try
            {
                using (var conn = new SqlConnection(connectionString))
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ArticleID", articleId);
                    conn.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // If the article is found, create the object and fill it with data
                            foundArticle = new Article
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                ArticleCode = reader["Article"]?.ToString(),
                                ArticleLongName = reader["ArticleLongName"]?.ToString(),
                                Barcode = reader["Barcodes"] as string, // Assuming 'Barcodes' holds the primary barcode
                                BuyPrice = reader["BuyPrice"] != DBNull.Value ? Convert.ToDecimal(reader["BuyPrice"]) : 0m,
                                SellPrice = reader["DetailsPrice"] != DBNull.Value ? Convert.ToDecimal(reader["DetailsPrice"]) : 0m, // Assuming DetailsPrice is the default sell price
                                QuantityStock = reader["QuantityStock"] != DBNull.Value ? Convert.ToDecimal(reader["QuantityStock"]) : 0m
                                // Add any other properties from your Article class here
                            };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching article by ID: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return foundArticle;
        }
        private void InitializeDefaultValues()
        {
            lbl_total.Text = 0m.ToString("N2");
            lbl_avance.Text = 0m.ToString("N2");
            lbl_reste.Text = 0m.ToString("N2");
        }
        private void PrepareFormForNewMode()
        {
            this.Text = "Nouvelle Facture d'Achat";
            if (this.Controls.Find("btn_Valider", true).FirstOrDefault() is Button validerButton)
            {
                validerButton.Text = "Valider";
            }
            if (cmbSuppliers.Items.Count > 0) cmbSuppliers.SelectedIndex = 0;
            GenerateNewInvoiceNumber();
        }
        private void PrepareFormForEditMode()
        {
            if (this.Controls.Find("btn_Valider", true).FirstOrDefault() is Button validerButton)
            {
                validerButton.Text = "Mettre à Jour";
            }
            // Title will be set after loading the invoice number
        }

        private void SetupPurchaseGrid()
        {
            if (!DatagridArticles.Columns.Contains(ArticleIdColName))
            {
                DatagridArticles.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = ArticleIdColName,
                    HeaderText = "ID",
                    Visible = false // Hide the ID column from the user
                });
            }
            // Ensure other columns like Barcode, ArticleName, Quantity, BuyPrice, Tot are in the designer
        }

        #endregion
        #region Article & Supplier Loading (UI)

        private void LoadArticlesForSelection()
        {
            // Get the currently selected warehouse ID from the ComboBox
            // --- FIX: Get the selected warehouse ID before fetching articles ---
            int.TryParse(cmbWarehouse.SelectedValue?.ToString(), out _selectedWarehouseId);

            articles = GetArticlesFromDb(currentPage * itemsPerPage, itemsPerPage, _selectedWarehouseId);
            DisplayArticlesInPanel();
        }


        public List<Article> GetArticlesFromDb(int offset, int limit, int warehouseId)
        {
            var articlesList = new List<Article>();
            string query;

            if (warehouseId == 0) // If "All" or no warehouse is selected, show global stock
            {
                query = @"SELECT Id, Article, ArticleLongName, Barcodes, BuyPrice, QuantityStock 
                          FROM Articles WHERE IsActive = 1 
                          ORDER BY Article OFFSET @offset ROWS FETCH NEXT @limit ROWS ONLY";
            }
            else // Otherwise, get the stock for the specific warehouse
            {
                query = @"SELECT a.Id, a.Article, a.ArticleLongName, a.Barcodes, a.BuyPrice, 
                                 ISNULL(s.Quantity, 0) AS QuantityStock 
                          FROM Articles a
                          LEFT JOIN ArticleStock s ON a.Id = s.ArticleID AND s.WarehouseID = @WarehouseID
                          WHERE a.IsActive = 1
                          ORDER BY a.Article OFFSET @offset ROWS FETCH NEXT @limit ROWS ONLY";
            }

            try
            {
                using (var conn = new SqlConnection(connectionString))
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@offset", offset);
                    cmd.Parameters.AddWithValue("@limit", limit);
                    if (warehouseId > 0)
                    {
                        cmd.Parameters.AddWithValue("@WarehouseID", warehouseId);
                    }


                    conn.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            articlesList.Add(new Article
                            {
                                Id = reader.GetInt32(reader.GetOrdinal("Id")),
                                ArticleCode = reader["Article"]?.ToString(),
                                ArticleLongName = reader["ArticleLongName"]?.ToString(),
                                BuyPrice = reader["BuyPrice"] != DBNull.Value ? Convert.ToDecimal(reader["BuyPrice"]) : 0,
                                QuantityStock = reader["QuantityStock"] != DBNull.Value ? Convert.ToDecimal(reader["QuantityStock"]) : 0
                            });
                        }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show($"Erreur chargement articles: {ex.Message}"); }
            return articlesList;
        }
        private void DisplayArticlesInPanel()
        {
            tableLayoutPanel7.SuspendLayout();
            tableLayoutPanel7.Controls.Clear();

            if (articles != null)
            {
                for (int i = 0; i < articles.Count; i++)
                {
                    // --- FIX: Now using the correct 'ArticleControl' ---
                    ArticleControl articleControl = new ArticleControl();

                    // Tell the control to show the 'Buy Price'
                    articleControl.SetArticleData(articles[i]);

                    // Make sure the event handler is named correctly
                    articleControl.ArticleClicked += BuySArticleControl_ArticleClicked;

                    tableLayoutPanel7.Controls.Add(articleControl, i % 6, i / 6);
                }
            }
            tableLayoutPanel7.ResumeLayout();
        }
        private void InitiatePurchasePrint()
        {
            if (_currentPurchaseTicketForPrint == null)
            {
                MessageBox.Show("Aucune donnée de facture d'achat à imprimer.", "Erreur d'impression", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            bool printerFound = false;
            using (PrintDocument pd = new PrintDocument())
            {
                // --- Printer & Page Settings (Uses AppSettingsManager) ---
                string targetPrinterName = AppSettingsManager.PrinterTicket; // Using setting for 80mm ticket printer

                if (!string.IsNullOrEmpty(targetPrinterName))
                {
                    pd.PrinterSettings.PrinterName = targetPrinterName;
                    printerFound = true;
                }
                else
                {
                    // If no printer is set in settings, you might want to show an error or let the user choose.
                    MessageBox.Show("Aucune imprimante de ticket n'est configurée dans les paramètres.", "Erreur d'impression", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Stop the print job
                }
                if (!printerFound && !targetPrinterName.Equals("Microsoft Print to PDF", StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show(
                        $"L'imprimante cible '{targetPrinterName}' est introuvable. L'imprimante par défaut sera utilisée.",
                        "Avertissement Imprimante", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                PaperSize receiptPaperSize = null;
                // Attempt to find or create an 80mm paper size.
                // (Logic for finding/creating PaperSize as in your previous InitiatePrint method)
                int widthInHundredthsOfInch = (int)Math.Round((80.0 / 25.4) * 100.0);
                receiptPaperSize = new PaperSize("80mm Purchase Roll", widthInHundredthsOfInch, 1200); // Height approx 12 inches
                pd.DefaultPageSettings.PaperSize = receiptPaperSize;
                pd.DefaultPageSettings.Margins = new Margins(15, 15, 20, 20); // L, R, T, B

                pd.PrintPage += new PrintPageEventHandler(PurchasePrintPageHandler); // Use the new handler

                if (usePurchasePrintPreview)
                {
                    using (PrintPreviewDialog previewDialog = new PrintPreviewDialog())
                    {
                        previewDialog.Document = pd;
                        previewDialog.WindowState = FormWindowState.Maximized;
                        previewDialog.Text = "Aperçu Bon de Réception/Facture d'Achat (80mm)";
                        previewDialog.PrintPreviewControl.AutoZoom = true;
                        try { previewDialog.ShowDialog(this); }
                        catch (Exception ex) { MessageBox.Show($"Erreur aperçu: {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    }
                }
                else
                {
                    try { pd.Print(); }
                    catch (Exception ex) { MessageBox.Show($"Erreur impression: {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
            }
        }

        private void PurchasePrintPageHandler(object sender, PrintPageEventArgs e)
        {
            if (_currentPurchaseTicketForPrint == null) return;

            Graphics graphics = e.Graphics;
            Font regularFont = new Font("Arial", 8);
            Font boldFont = new Font("Arial", 9, FontStyle.Bold);
            Font smallFont = new Font("Arial", 7);
            Font titleFont = new Font("Arial", 10, FontStyle.Bold);
            Font itemHeaderFont = new Font("Arial", 8, FontStyle.Bold);

            Pen itemTableVerticalSeparatorPen = new Pen(Color.DarkGray, 0.5f) { DashStyle = System.Drawing.Drawing2D.DashStyle.Dot };
            Pen horizontalSeparatorPen = new Pen(Color.DarkGray, 0.5f);
            Pen summaryTableCellPen = new Pen(Color.Black, 0.7f);

            float yPos = e.MarginBounds.Top;
            float leftMargin = e.MarginBounds.Left;
            float printableWidth = e.MarginBounds.Width;
            float lineSpacing = regularFont.GetHeight(graphics) + 3;
            float smallLineSpacing = smallFont.GetHeight(graphics) + 2;
            float cellPadding = 4f;

            StringFormat sfCenter = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center, FormatFlags = StringFormatFlags.DirectionRightToLeft };
            StringFormat sfRight = new StringFormat { Alignment = StringAlignment.Near, LineAlignment = StringAlignment.Center, FormatFlags = StringFormatFlags.DirectionRightToLeft };
            StringFormat sfLeft = new StringFormat { Alignment = StringAlignment.Far, LineAlignment = StringAlignment.Center, FormatFlags = StringFormatFlags.DirectionRightToLeft };
            StringFormat sfCellTextRight = new StringFormat { Alignment = StringAlignment.Near, LineAlignment = StringAlignment.Center, FormatFlags = StringFormatFlags.DirectionRightToLeft | StringFormatFlags.LineLimit };
            StringFormat sfCellTextLeft = new StringFormat { Alignment = StringAlignment.Far, LineAlignment = StringAlignment.Center, FormatFlags = StringFormatFlags.DirectionRightToLeft | StringFormatFlags.LineLimit };

            PurchaseTicketData data = _currentPurchaseTicketForPrint; // Convenience

            // --- Optional: Company Logo ---
            // (Similar logo printing logic as before, using data.YourCompanyLogoPath)

            // --- Your Company Header ---
            graphics.DrawString(data.YourCompanyName, titleFont, Brushes.Black, new RectangleF(leftMargin, yPos, printableWidth, titleFont.GetHeight(graphics)), sfCenter);
            yPos += titleFont.GetHeight(graphics) + 2;
            graphics.DrawString(data.YourCompanyAddress, smallFont, Brushes.Black, new RectangleF(leftMargin, yPos, printableWidth, smallFont.GetHeight(graphics)), sfCenter);
            yPos += smallLineSpacing;
            graphics.DrawString(data.YourCompanyPhone, smallFont, Brushes.Black, new RectangleF(leftMargin, yPos, printableWidth, smallFont.GetHeight(graphics)), sfCenter);
            yPos += smallLineSpacing;
            if (!string.IsNullOrWhiteSpace(data.YourCompanyVatNumber))
            {
                graphics.DrawString(data.YourCompanyVatNumber, smallFont, Brushes.Black, new RectangleF(leftMargin, yPos, printableWidth, smallFont.GetHeight(graphics)), sfCenter);
                yPos += smallLineSpacing;
            }
            yPos += lineSpacing / 2;

            // --- Ticket Title ---
            graphics.DrawString(data.TicketTitle, boldFont, Brushes.Black, new RectangleF(leftMargin, yPos, printableWidth, boldFont.GetHeight(graphics)), sfCenter);
            yPos += boldFont.GetHeight(graphics) + lineSpacing;

            // --- Invoice and Supplier Info ---
            DrawLabelAndValue(graphics, "N° Facture Achat:", data.PurchaseInvoiceNumber, regularFont, Brushes.Black, leftMargin, yPos, printableWidth, sfRight, sfLeft); yPos += lineSpacing;
            DrawLabelAndValue(graphics, "Date Achat:", data.PurchaseDate.ToString("yyyy/MM/dd HH:mm"), regularFont, Brushes.Black, leftMargin, yPos, printableWidth, sfRight, sfLeft); yPos += lineSpacing;
            DrawLabelAndValue(graphics, "Fournisseur:", data.SupplierName, boldFont, Brushes.Black, leftMargin, yPos, printableWidth, sfRight, sfLeft); yPos += lineSpacing;
            // Add more supplier details if available in 'data' and needed (e.g., supplier address)
            yPos += lineSpacing / 2;

            // --- Items Section (similar to sales receipt item table) ---
            graphics.DrawLine(horizontalSeparatorPen, leftMargin, yPos, leftMargin + printableWidth, yPos); yPos += lineSpacing / 2;

            float itemNameColPercent = 0.40f, itemQtyColPercent = 0.15f, itemPriceColPercent = 0.20f, itemTotalColPercent = 0.25f;
            float itemNameColWidth = printableWidth * itemNameColPercent;
            float itemQtyColWidth = printableWidth * itemQtyColPercent;
            float itemPriceColWidth = printableWidth * itemPriceColPercent;
            float itemTotalColWidth = printableWidth * itemTotalColPercent;
            float itemNameColX = leftMargin + printableWidth - itemNameColWidth;
            float itemQtyColX = itemNameColX - itemQtyColWidth;
            float itemPriceColX = itemQtyColX - itemPriceColWidth;
            float itemTotalColX = leftMargin;
            float itemVSep1X = itemNameColX - 1, itemVSep2X = itemQtyColX - 1, itemVSep3X = itemPriceColX - 1;
            float itemsHeaderY = yPos;

            graphics.DrawString("Article", itemHeaderFont, Brushes.Black, new RectangleF(itemNameColX, itemsHeaderY, itemNameColWidth, itemHeaderFont.GetHeight(graphics)), sfRight);
            graphics.DrawString("Qté", itemHeaderFont, Brushes.Black, new RectangleF(itemQtyColX, itemsHeaderY, itemQtyColWidth, itemHeaderFont.GetHeight(graphics)), sfCenter);
            graphics.DrawString("P.U. Achat", itemHeaderFont, Brushes.Black, new RectangleF(itemPriceColX, itemsHeaderY, itemPriceColWidth, itemHeaderFont.GetHeight(graphics)), sfRight);
            graphics.DrawString("Total Partiel", itemHeaderFont, Brushes.Black, new RectangleF(itemTotalColX, itemsHeaderY, itemTotalColWidth, itemHeaderFont.GetHeight(graphics)), sfRight);
            yPos += itemHeaderFont.GetHeight(graphics) + 4;
            float itemsContentStartY = yPos;

            foreach (var item in data.Items)
            {
                float currentItemStartY = yPos;
                List<string> nameLines = SplitTextForPrinting(graphics, item.Name, regularFont, itemNameColWidth - 4);
                float nameLinesHeight = 0;
                foreach (string namePart in nameLines)
                {
                    graphics.DrawString(namePart, regularFont, Brushes.Black, new RectangleF(itemNameColX, currentItemStartY + nameLinesHeight, itemNameColWidth, regularFont.GetHeight(graphics)), sfRight);
                    nameLinesHeight += regularFont.GetHeight(graphics);
                }
                float itemDetailsY = currentItemStartY;
                graphics.DrawString(item.Quantity.ToString(), regularFont, Brushes.Black, new RectangleF(itemQtyColX, itemDetailsY, itemQtyColWidth, regularFont.GetHeight(graphics)), sfCenter);
                graphics.DrawString(item.UnitPrice.ToString("N2"), regularFont, Brushes.Black, new RectangleF(itemPriceColX, itemDetailsY, itemPriceColWidth, regularFont.GetHeight(graphics)), sfRight);
                graphics.DrawString(item.TotalPrice.ToString("N2"), regularFont, Brushes.Black, new RectangleF(itemTotalColX, itemDetailsY, itemTotalColWidth, regularFont.GetHeight(graphics)), sfRight);
                yPos += Math.Max(nameLinesHeight, regularFont.GetHeight(graphics)) + (lineSpacing / 2);
            }
            float itemsContentEndY = yPos - (lineSpacing / 2);
            if (data.Items.Any())
            {
                float vLineTopY = itemsHeaderY + itemHeaderFont.GetHeight(graphics) + 1;
                float vLineBottomY = itemsContentEndY + 1;
                graphics.DrawLine(itemTableVerticalSeparatorPen, itemVSep1X, vLineTopY, itemVSep1X, vLineBottomY);
                graphics.DrawLine(itemTableVerticalSeparatorPen, itemVSep2X, vLineTopY, itemVSep2X, vLineBottomY);
                graphics.DrawLine(itemTableVerticalSeparatorPen, itemVSep3X, vLineTopY, itemVSep3X, vLineBottomY);
            }
            yPos = itemsContentEndY + (lineSpacing / 2);
            graphics.DrawLine(horizontalSeparatorPen, leftMargin, yPos, leftMargin + printableWidth, yPos);
            yPos += lineSpacing * 1.5f; // Increased space

            // --- Summary Table (Totals & Payment) ---
            float valueSummaryColPercent = 0.45f; // Value on left
            float labelSummaryColPercent = 0.55f; // Label on right
            float valueSummaryColWidth = printableWidth * valueSummaryColPercent;
            float labelSummaryColWidth = printableWidth * labelSummaryColPercent;
            float valueSummaryColX = leftMargin;
            float labelSummaryColX = leftMargin + valueSummaryColWidth;

            Action<string, string, Font, Font> drawSummaryTableRow = (labelText, valueText, labelFont, valueFont) =>
            {
                float cHeightLabel = graphics.MeasureString(labelText ?? "", labelFont, (int)(labelSummaryColWidth - 2 * cellPadding), sfCellTextRight).Height;
                float cHeightValue = graphics.MeasureString(valueText ?? "", valueFont, (int)(valueSummaryColWidth - 2 * cellPadding), sfCellTextLeft).Height;
                float currentContentHeight = Math.Max(cHeightLabel, cHeightValue);
                float currentRowHeight = currentContentHeight + (2 * cellPadding);
                RectangleF valCellOut = new RectangleF(valueSummaryColX, yPos, valueSummaryColWidth, currentRowHeight);
                RectangleF lblCellOut = new RectangleF(labelSummaryColX, yPos, labelSummaryColWidth, currentRowHeight);
                RectangleF valTxtIn = new RectangleF(valCellOut.X + cellPadding, valCellOut.Y + cellPadding, valCellOut.Width - (2 * cellPadding), currentContentHeight);
                RectangleF lblTxtIn = new RectangleF(lblCellOut.X + cellPadding, lblCellOut.Y + cellPadding, lblCellOut.Width - (2 * cellPadding), currentContentHeight);
                graphics.DrawRectangle(summaryTableCellPen, valCellOut.X, valCellOut.Y, valCellOut.Width, valCellOut.Height);
                graphics.DrawRectangle(summaryTableCellPen, lblCellOut.X, lblCellOut.Y, lblCellOut.Width, lblCellOut.Height);
                graphics.DrawString(valueText ?? "", valueFont, Brushes.Black, valTxtIn, sfCellTextLeft);
                graphics.DrawString(labelText ?? "", labelFont, Brushes.Black, lblTxtIn, sfCellTextRight);
                yPos += currentRowHeight;
            };

            drawSummaryTableRow("Total Articles:", data.SubTotalAmount.ToString("C2"), regularFont, regularFont);
            if (data.DiscountAmount > 0) drawSummaryTableRow("Remise:", data.DiscountAmount.ToString("C2"), regularFont, regularFont);
            if (data.TaxAmount > 0) drawSummaryTableRow("Taxe:", data.TaxAmount.ToString("C2"), regularFont, regularFont);
            drawSummaryTableRow("Grand Total:", data.GrandTotalAmount.ToString("C2"), boldFont, boldFont);
            if (data.AmountPaid > 0 || !string.IsNullOrEmpty(data.PaymentType)) // Show payment info if relevant
            {
                yPos += lineSpacing / 2; // Small gap before payment section within table
                                         // Payment Method Header Row
                float paymentHeaderContentHeight = graphics.MeasureString("Règlement:", boldFont, (int)(labelSummaryColWidth - 2 * cellPadding), sfCellTextRight).Height;
                float paymentHeaderRowHeight = paymentHeaderContentHeight + (2 * cellPadding);
                RectangleF paymentLabelCellOuterRect = new RectangleF(labelSummaryColX, yPos, labelSummaryColWidth, paymentHeaderRowHeight);
                RectangleF paymentValueCellOuterRect = new RectangleF(valueSummaryColX, yPos, valueSummaryColWidth, paymentHeaderRowHeight);
                graphics.DrawRectangle(summaryTableCellPen, paymentLabelCellOuterRect.X, paymentLabelCellOuterRect.Y, paymentLabelCellOuterRect.Width, paymentLabelCellOuterRect.Height);
                graphics.DrawRectangle(summaryTableCellPen, paymentValueCellOuterRect.X, paymentValueCellOuterRect.Y, paymentValueCellOuterRect.Width, paymentValueCellOuterRect.Height);
                graphics.DrawString("Règlement:", boldFont, Brushes.Black, new RectangleF(paymentLabelCellOuterRect.X + cellPadding, paymentLabelCellOuterRect.Y + cellPadding, paymentLabelCellOuterRect.Width - (2 * cellPadding), paymentHeaderContentHeight), sfCellTextRight);
                yPos += paymentHeaderRowHeight;

                drawSummaryTableRow("Type Paiement:", data.PaymentType, regularFont, regularFont);
                drawSummaryTableRow("Statut Paiement:", data.PaymentStatus, regularFont, regularFont);
                drawSummaryTableRow("Montant Payé (Avance):", data.AmountPaid.ToString("C2"), regularFont, regularFont);
                drawSummaryTableRow("Reste à Payer:", data.AmountDue.ToString("C2"), regularFont, boldFont); // Reste might be bold
            }
            yPos += lineSpacing;

            // --- Footer ---
            graphics.DrawString(data.FooterMessage1, regularFont, Brushes.Black, new RectangleF(leftMargin, yPos, printableWidth, regularFont.GetHeight(graphics)), sfCenter); yPos += lineSpacing;
            graphics.DrawString(data.FooterMessage2, smallFont, Brushes.Black, new RectangleF(leftMargin, yPos, printableWidth, smallFont.GetHeight(graphics)), sfCenter); yPos += smallLineSpacing;

            // Optional: "Received by" signature line
            // yPos += lineSpacing * 2;
            // graphics.DrawString("Reçu par: _________________________", regularFont, Brushes.Black, new RectangleF(leftMargin, yPos, printableWidth, regularFont.GetHeight(graphics)), sfRight);
            // yPos += lineSpacing;


            regularFont.Dispose(); boldFont.Dispose(); smallFont.Dispose(); titleFont.Dispose(); itemHeaderFont.Dispose();
            itemTableVerticalSeparatorPen.Dispose(); horizontalSeparatorPen.Dispose(); summaryTableCellPen.Dispose();
            e.HasMorePages = false;
        }

        private void DrawLabelAndValue(Graphics g, string label, string value, Font font, Brush brush, float x, float y, float totalWidth, StringFormat labelFormat, StringFormat valueFormat)
        {
            RectangleF valueRect = new RectangleF(x, y, totalWidth * 0.45f, font.GetHeight(g)); // Value on left 45%
            RectangleF labelRect = new RectangleF(x + totalWidth * 0.45f, y, totalWidth * 0.55f, font.GetHeight(g)); // Label on right 55%
            g.DrawString(value ?? "", font, brush, valueRect, valueFormat); // For Arabic, value on left
            g.DrawString(label ?? "", font, brush, labelRect, labelFormat); // Label on right
        }

        private List<string> SplitTextForPrinting(Graphics g, string text, Font font, float maxWidth)
        {
            var lines = new List<string>();
            if (string.IsNullOrEmpty(text) || maxWidth <= 0) { if (!string.IsNullOrEmpty(text)) lines.Add(text); return lines; }
            string[] words = text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (!words.Any())
            { /* ... (handle single long word without spaces) ... */
                string currentLineNoSpace = string.Empty;
                foreach (char c in text)
                {
                    if (g.MeasureString(currentLineNoSpace + c, font).Width > maxWidth && currentLineNoSpace.Length > 0)
                    {
                        lines.Add(currentLineNoSpace); currentLineNoSpace = c.ToString();
                    }
                    else { currentLineNoSpace += c; }
                }
                if (!string.IsNullOrEmpty(currentLineNoSpace)) lines.Add(currentLineNoSpace);
                return lines.Any() ? lines : new List<string> { text };
            }
            string line = "";
            foreach (string word in words)
            { /* ... (word wrapping logic) ... */
                string testLine = string.IsNullOrEmpty(line) ? word : line + " " + word;
                if (g.MeasureString(testLine, font).Width > maxWidth)
                {
                    if (!string.IsNullOrEmpty(line)) { lines.Add(line); }
                    if (g.MeasureString(word, font).Width > maxWidth)
                    {
                        string currentSubWord = "";
                        foreach (char c in word)
                        {
                            if (g.MeasureString(currentSubWord + c, font).Width > maxWidth && currentSubWord.Length > 0)
                            {
                                lines.Add(currentSubWord); currentSubWord = c.ToString();
                            }
                            else { currentSubWord += c; }
                        }
                        line = currentSubWord;
                    }
                    else { line = word; }
                }
                else { line = testLine; }
            }
            if (!string.IsNullOrEmpty(line)) { lines.Add(line); }
            return lines.Any() ? lines : new List<string> { text };
        }

        private void PrepareAndPrintPurchaseTicket(int purchaseInvoicePK, string generatedInvNum, DateTime purchaseDate,
                                               string suppName, List<DataGridViewRow> items,
                                               decimal subTotal, decimal disc, decimal tax, decimal grandTot,
                                               decimal advance, string pType, string pStatus)
        {
            _currentA4InvoiceData = new A4PurchaseInvoiceData
            {
                PurchaserCompanyName = AppSettingsManager.CompanyName,
                PurchaserAddress = AppSettingsManager.CompanyAddress,
                PurchaserPhone = AppSettingsManager.CompanyPhone,
                PurchaserVatId = AppSettingsManager.VatNumber,
                PurchaserLogoPath = AppSettingsManager.LogoPath,
                Notes = AppSettingsManager.FooterPage,

                InvoiceNumber = generatedInvNum,
                InvoiceDate = purchaseDate,
                SupplierName = suppName,

                SubtotalAmount = subTotal,
                DiscountAmount = disc,
                TaxAmount = tax,
                GrandTotalAmount = grandTot,
                AmountPaid = advance,
                PaymentMethod = pType,
                PaymentStatus = pStatus,
                Items = new List<A4PurchaseInvoiceItem>()
            };

            int lineNumber = 1;
            foreach (DataGridViewRow row in items)
            {
                if (row.IsNewRow) continue;
                _currentA4InvoiceData.Items.Add(new A4PurchaseInvoiceItem
                {
                    LineNumber = lineNumber++,
                    ItemCode = row.Cells["ArticleID"].Value?.ToString() ?? "",
                    Description = row.Cells["ArticleName"].Value?.ToString() ?? "",
                    Quantity = Convert.ToInt32(row.Cells["quantity"].Value ?? 0),
                    UnitPrice = Convert.ToDecimal(row.Cells["BuyPrice"].Value ?? 0)
                });
            }

            // استدعاء دالة بدء الطباعة التي كانت ناقصة
            InitiateA4InvoicePrint();
        }

        // <<-- أضف هذه الدالة الجديدة بالكامل -->>
        private void InitiateA4InvoicePrint()
        {
            if (_currentA4InvoiceData == null) return;

            using (PrintDocument pd = new PrintDocument())
            {
                pd.DocumentName = "Facture Achat";
                pd.PrinterSettings.PrinterName = AppSettingsManager.PrinterA4A5;
                pd.DefaultPageSettings.Landscape = true; // A4 Landscape
                pd.DefaultPageSettings.PaperSize = new PaperSize("A4", 1169, 827);
                pd.DefaultPageSettings.Margins = new Margins(40, 40, 50, 50);

                pd.PrintPage += new PrintPageEventHandler(A4InvoicePrintPageHandler);

                using (PrintPreviewDialog previewDialog = new PrintPreviewDialog())
                {
                    previewDialog.Document = pd;
                    previewDialog.WindowState = FormWindowState.Maximized;
                    previewDialog.ShowDialog(this);
                }
                pd.PrintPage -= new PrintPageEventHandler(A4InvoicePrintPageHandler);
            }
        }

        // <<-- أضف هذه الدالة الجديدة بالكامل -->>
        private void A4InvoicePrintPageHandler(object sender, PrintPageEventArgs e)
        {
            // ... (هنا يتم وضع كود الرسم الكامل الذي يشبه تقرير حركة المخزون) ...
            // لقد قمت بإعداده لك في ردود سابقة، يمكنك نسخه من هناك أو سأرسله لك مجدداً إذا أردت.
        }



        
        private void bunifuButton215_Click(object sender, EventArgs e) // Close button
        {
            this.Close();
        }

        public List<Article> GetArticles(int offset, int limit, int warehouseId)
        {

            var articlesList = new List<Article>();
            string query;

            if (warehouseId == 0) // If "All" or no warehouse is selected, show global stock
            {
                query = @"SELECT Id, Article, ArticleLongName, Barcodes, BuyPrice, QuantityStock 
                          FROM Articles WHERE IsActive = 1 
                          ORDER BY ArticleLongName OFFSET @offset ROWS FETCH NEXT @limit ROWS ONLY";
            }
            else // Otherwise, get the stock for the specific warehouse
            {
                query = @"SELECT a.Id, a.Article, a.ArticleLongName, a.Barcodes, a.BuyPrice, 
                                 ISNULL(s.Quantity, 0) AS QuantityStock 
                          FROM Articles a
                          LEFT JOIN ArticleStock s ON a.Id = s.ArticleID AND s.WarehouseID = @WarehouseID
                          WHERE a.IsActive = 1
                          ORDER BY a.ArticleLongName OFFSET @offset ROWS FETCH NEXT @limit ROWS ONLY";
            }

            try
            {
                using (var conn = new SqlConnection(connectionString))
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@offset", offset);
                    cmd.Parameters.AddWithValue("@limit", limit);
                    if (warehouseId > 0)
                    {
                        cmd.Parameters.AddWithValue("@WarehouseID", warehouseId);
                    }

                    conn.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            articlesList.Add(new Article
                            {
                                Id = reader.GetInt32(reader.GetOrdinal("Id")),
                                ArticleCode = reader["Article"]?.ToString(),
                                ArticleLongName = reader["ArticleLongName"]?.ToString(),
                                BuyPrice = reader["BuyPrice"] != DBNull.Value ? Convert.ToDecimal(reader["BuyPrice"]) : 0,
                                QuantityStock = reader["QuantityStock"] != DBNull.Value ? Convert.ToDecimal(reader["QuantityStock"]) : 0
                            });
                        }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show($"Erreur chargement articles: {ex.Message}"); }
            return articlesList;
        }

        private void LoadArticles()
        {
            int offset = currentPage * itemsPerPage;
            int warehouseId = 0;
            if (cmbWarehouse.SelectedValue != null && int.TryParse(cmbWarehouse.SelectedValue.ToString(), out int id))
            {
                warehouseId = id;
            }
            articles = GetArticles(offset, itemsPerPage, warehouseId); // This class member 'articles' will be updated
            DisplayArticles();
            UpdatePaginationButtonsState(); // Method to enable/disable next/prev buttons
        }

        private void DisplayArticles()
        {
            tableLayoutPanel7.Controls.Clear();

            if (articles == null) return;

            for (int i = 0; i < articles.Count; i++)
            {
                buyarticlesControl articleControl = new buyarticlesControl();
                articleControl.SetArticleData(articles[i]);
                // Unsubscribe first to prevent multiple handlers if this method is called in a way that reuses controls (unlikely with Clear)
                articleControl.ArticleClicked -= BuySArticleControl_ArticleClicked;
                articleControl.ArticleClicked += BuySArticleControl_ArticleClicked;

                // Assuming tableLayoutPanel7 has 6 columns. Adjust if different.
                tableLayoutPanel7.Controls.Add(articleControl, i % 6, i / 6);
            }

            // Consider moving Next/Previous buttons out of tableLayoutPanel7
            // and using dedicated buttons on the form whose Enabled state is managed by UpdatePaginationButtonsState()
        }

        private void RecalculateTotal()
        {
            decimal newGridTotal = 0;
            foreach (DataGridViewRow row in DatagridArticles.Rows)
            {
                if (!row.IsNewRow && row.Cells["tot"].Value != null)
                {
                    newGridTotal += Convert.ToDecimal(row.Cells["tot"].Value);
                }
            }

            lbl_total.Text = newGridTotal.ToString("C2");

            // إذا كنا في وضع التعديل، فاحسب "الباقي" بناءً على المبلغ المدفوع الأصلي
            if (isEditMode)
            {
                lbl_avance.Text = this.originalAmountPaid.ToString("C2");
                lbl_reste.Text = (newGridTotal - this.originalAmountPaid).ToString("C2");

            }
            else // في وضع الإضافة، الحساب يبقى كما هو
            {
                decimal avance = 0; // يمكنك ربط هذا بحقل إدخال الدفعة المقدمة
                if (decimal.TryParse(lbl_avance.Text, out avance)) { /* OK */ }
                lbl_reste.Text = (newGridTotal - avance).ToString("C2");
            }
        }

        private void ClearForm()
        {
            lbl_fournisseur.Text = "Choisir Un Fournisseur";
            if (cmbSuppliers.Items.Count > 0)
            {
                cmbSuppliers.SelectedIndex = -1; // Clear selection
            }
            _selectedSupplierId = -1;

            DatagridArticles.Rows.Clear();

            lbl_total.Text = 0m.ToString("C2");
            lbl_avance.Text = 0m.ToString("C2");
            lbl_reste.Text = 0m.ToString("C2");

            // Regenerate invoice number for the next purchase
            GenerateInvoiceNumber();
            // Update UI if displaying invoice number:
            // lbl_DisplayInvoiceNumber.Text = generatedInvoiceNumber;

            currentPage = 0; // Reset pagination for articles
            LoadArticles(); // Reload first page of articles
        }

        private bool InvoiceNumberExists(string invNumber)
        {
            string query = "SELECT COUNT(1) FROM PurchaseInvoices WHERE InvoiceNumber = @InvoiceNumber";
            string connectionString = DatabaseConnection.GetConnectionString();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@InvoiceNumber", invNumber);
                    conn.Open();
                    return (int)cmd.ExecuteScalar() > 0;
                }
            }
        }
        private void GenerateInvoiceNumber()
        {
            int nextNumber = AppSettingsManager.SerieAchat;
            generatedInvoiceNumber = $"ACH-{DateTime.Now:yyyy}-{nextNumber:D5}";
            // يمكنك عرضها في ليبل إذا أردت
            lbl_CurrentInvoiceNumber.Text = generatedInvoiceNumber;
            txt_CurrentInvoiceNumber.Text = generatedInvoiceNumber;
        }

        private void btn_Quantity_Click(object sender, EventArgs e)
        {
            if (DatagridArticles.SelectedRows.Count == 0)
            {
                MessageBox.Show("المرجو تحديد السلعة أولا", "Pas de sélection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DataGridViewRow selectedRow = DatagridArticles.SelectedRows[0];
            using (QuantityForm quantityForm = new QuantityForm()) // Pass current quantity
            {
                if (quantityForm.ShowDialog() == DialogResult.OK)
                {
                    selectedRow.Cells["Quantity"].Value = quantityForm.Quantity;
                    UpdateTotal(selectedRow);
                    RecalculateTotal();
                }
            }
        }

        private void UpdateTotal(DataGridViewRow row)
        {
            if (row.Cells["BuyPrice"].Value != null && row.Cells["Quantity"].Value != null)
            {
                if (decimal.TryParse(row.Cells["BuyPrice"].Value.ToString(), out decimal buyPrice) &&
                    decimal.TryParse(row.Cells["Quantity"].Value.ToString(), out decimal quantity))
                {
                    row.Cells["tot"].Value = buyPrice * quantity;
                }
                else
                {
                    row.Cells["tot"].Value = 0m; // Default to 0 if parsing fails
                }
            }
        }
        private void Btn_PriceChange_Click(object sender, EventArgs e)
        {
            if (DatagridArticles.SelectedRows.Count == 0)
            {
                MessageBox.Show("المرجو تحديد السلعة أولا", "Pas de sélection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DataGridViewRow selectedRow = DatagridArticles.SelectedRows[0];

            // Assuming QuantityForm can also handle price input.
            // It's better to have a specific form or mode for price change.
            using (QuantityForm priceForm = new QuantityForm(Convert.ToDecimal(selectedRow.Cells["BuyPrice"].Value))) // Pass current price
            {
                // You might need to tell QuantityForm it's for price, e.g., by changing its title or input label
                priceForm.Text = "Changer Prix d'Achat";
                if (priceForm.ShowDialog() == DialogResult.OK)
                {
                    // **FIXED BUG HERE**: Use a 'Price' property from the form, not 'Quantity'
                    selectedRow.Cells["BuyPrice"].Value = priceForm.Price; // Assuming QuantityForm has 'public decimal Price { get; set; }'
                    UpdateTotal(selectedRow);
                    RecalculateTotal();
                }
            }
        }

        private void SetupSupplierComboBox()
        {
            // Assuming cmbSuppliers is your ComboBox control name
            cmbSuppliers.DisplayMember = "Text";
            cmbSuppliers.ValueMember = "Value";
            cmbSuppliers.DropDownStyle = ComboBoxStyle.DropDownList; // Recommended
        }

        private void LoadSuppliers()
        {
            cmbSuppliers.Items.Clear();
            supplierNameToIdMap.Clear();

            string defaultText = "Choisir Un Fournisseur...";
            cmbSuppliers.Items.Add(defaultText);
            supplierNameToIdMap.Add(defaultText, -1); // Add a corresponding entry to the map

            string query = "SELECT SupplierID, Name FROM Suppliers WHERE Status = 'Active' ORDER BY Name";
            try
            {
                using (SqlConnection conn = new SqlConnection(DatabaseConnection.GetConnectionString()))
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        string name = reader["Name"].ToString();
                        int id = Convert.ToInt32(reader["SupplierID"]);

                        // Add the name to the dropdown and the name/ID pair to the map
                        cmbSuppliers.Items.Add(name);
                        supplierNameToIdMap[name] = id;
                    }
                }
                cmbSuppliers.SelectedIndex = 0; // Select the default item
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur chargement fournisseurs: {ex.Message}", "Erreur DB", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void GenerateNewInvoiceNumber()
        {
            try
            {
                int nextSerial = AppSettingsManager.SerieAchat;

                int currentYear = DateTime.Now.Year;

                // The :D5 part ensures it is padded with leading zeros to 5 digits.
                generatedInvoiceNumber = $"ACH-{currentYear}-{nextSerial:D5}";

                // 4. (Optional) Display the new number on the form if you have a label for it
                // For example, if you have a label named lbl_CurrentInvoiceNumber:
                // lbl_CurrentInvoiceNumber.Text = generatedInvoiceNumber;
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ في إنشاء رقم فاتورة جديد: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Disable the save button if a number cannot be generated
                btn_Valider.Enabled = false;
            }
        }
        private void cmbSuppliers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSuppliers.SelectedItem != null)
            {
                string selectedName = cmbSuppliers.SelectedItem.ToString();

                // Use the dictionary to find the ID corresponding to the selected name
                if (supplierNameToIdMap.TryGetValue(selectedName, out int id) && id > 0)
                {
                    this._selectedSupplierId = id;
                    lbl_fournisseur.Text = selectedName;
                }
                else
                {
                    // This handles the "Choisir Un Fournisseur..." case
                    this._selectedSupplierId = 0;
                    lbl_fournisseur.Text = "Choisir Un Fournisseur";
                }
            }
        }


        private void UpdatePaginationButtonsState()
        {
            BtnPrevious.Enabled = (currentPage > 0);
            BtnNext.Enabled = (articles != null && articles.Count == itemsPerPage);
        }
        private void BtnNext_Click(object sender, EventArgs e)
        {
            if (articles != null && articles.Count == itemsPerPage)
            {
                currentPage++;
                LoadArticlesForSelection();
            }
        }
        private void LoadWarehouses()
        {
            try
            {
                var dt = new DataTable();
                dt.Columns.Add("WarehouseID", typeof(int));
                dt.Columns.Add("WarehouseName", typeof(string));
                dt.Rows.Add(0, "--- Global (No Stock Change) ---"); // Add a default option

                using (var conn = new SqlConnection(DatabaseConnection.GetConnectionString()))
                using (var adapter = new SqlDataAdapter("SELECT WarehouseID, WarehouseName FROM Warehouses ORDER BY WarehouseName", conn))
                {
                    adapter.Fill(dt);
                }
                cmbWarehouse.DataSource = dt;
                cmbWarehouse.DisplayMember = "WarehouseName";
                cmbWarehouse.ValueMember = "WarehouseID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ في تحميل المخازن: " + ex.Message);
            }
        }

        private void BtnPrevious_Click(object sender, EventArgs e)
        {
            if (currentPage > 0)
            {
                currentPage--;
                LoadArticlesForSelection();
            }
        }
        #endregion
        #region Invoice Grid Management (Add, Edit, Delete Item)

        private void BuySArticleControl_ArticleClicked(object sender, Article article)
        {
            if (article == null)
            {
                MessageBox.Show("L'article sélectionné est invalide.", "Erreur Article", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool articleFound = false;
            // Look for the article in the grid by its ID
            foreach (DataGridViewRow row in DatagridArticles.Rows)
            {
                if (row.IsNewRow) continue;
                // Use the hidden ArticleID column for a reliable check
                if (Convert.ToInt32(row.Cells[ArticleIdColName].Value) == article.Id)
                {
                    decimal currentQuantity = Convert.ToDecimal(row.Cells["quantity"].Value);
                    row.Cells["quantity"].Value = currentQuantity + 1; // Increment quantity
                    articleFound = true;
                    break;
                }
            }

            if (!articleFound)
            {
                // If the article is not in the grid, add a new row
                int rowIndex = DatagridArticles.Rows.Add();
                DataGridViewRow newRow = DatagridArticles.Rows[rowIndex];

                // --- THIS IS THE CRITICAL FIX ---
                // Explicitly set the value for each cell by its name
                newRow.Cells[ArticleIdColName].Value = article.Id; // <-- Correctly stores the ID
                newRow.Cells["Barcode"].Value = article.Barcode;
                newRow.Cells["ArticleName"].Value = article.ArticleCode;
                newRow.Cells["quantity"].Value = 1;
                newRow.Cells["BuyPrice"].Value = article.BuyPrice;
            }

            UpdateTotals(); // Recalculate totals after adding/updating
        }
        private void AddOrUpdateArticleInGrid(Article article, decimal quantityToAdd)
        {
            // Find if the article already exists in the grid
            var existingRow = DatagridArticles.Rows.Cast<DataGridViewRow>()
                .FirstOrDefault(row => !row.IsNewRow && Convert.ToInt32(row.Cells[ArticleIdColName].Value) == article.Id);

            if (existingRow != null)
            {
                decimal currentQuantity = Convert.ToDecimal(existingRow.Cells["quantity"].Value);
                existingRow.Cells["quantity"].Value = currentQuantity + quantityToAdd;
            }
            else
            {
                DatagridArticles.Rows.Add(
                    article.Id,
                    article.Barcode,
                    article.ArticleLongName, // Use the long name for clarity
                    quantityToAdd,
                    article.BuyPrice,
                    article.BuyPrice * quantityToAdd // Initial total
                );
            }
            UpdateTotals();
        }
        private void bunifuButton210_Click(object sender, EventArgs e) // Delete selected item
        {
            if (DatagridArticles.SelectedRows.Count > 0)
            {
                DatagridArticles.Rows.Remove(DatagridArticles.SelectedRows[0]);
                UpdateTotals();
            }
        }
        private void bunifuButton211_Click(object sender, EventArgs e) // Clear all items
        {
            DatagridArticles.Rows.Clear();
            _globalDiscountAmount = 0;
            
            UpdateTotals();
        }
        private void UpdateTotals()
        {
            decimal gridTotal = 0;

            // Recalculate each row's total and get the grand total before global discount
            foreach (DataGridViewRow row in DatagridArticles.Rows)
            {
                if (row.IsNewRow) continue;

                decimal quantity = Convert.ToDecimal(row.Cells["quantity"].Value ?? 0);
                decimal price = Convert.ToDecimal(row.Cells["BuyPrice"].Value ?? 0);
                decimal lineTotal = quantity * price;

                // Subtract any fixed discount applied to this specific row
                if (row.Cells["colRemise"].Value != null && !row.Cells["colRemise"].Value.ToString().Contains("%"))
                {
                    if (decimal.TryParse(row.Cells["colRemise"].Value.ToString(), out decimal rowDiscount))
                    {
                        lineTotal -= rowDiscount;
                    }
                }

                row.Cells["Tot"].Value = lineTotal;
                gridTotal += lineTotal;
            }

            // Subtract the global discount for the whole invoice
            decimal finalTotal = gridTotal - _globalDiscountAmount;

            // --- THIS IS THE CORRECTED LOGIC FOR EDIT MODE ---
            decimal amountPaid = 0;
            if (_isEditMode)
            {
                // In Edit Mode, the amount paid is the value loaded from the original invoice.
                amountPaid = this.originalAmountPaid;
            }
            else
            {
                // In New Mode, payment is 0 until a payment is entered.
                // You can add a textbox for this later if you want.
                amountPaid = 0;
            }

            decimal remainder = finalTotal - amountPaid;

            // Update all the labels
            lbl_total.Text = finalTotal.ToString("N2");
            lbl_avance.Text = amountPaid.ToString("N2");
            lbl_reste.Text = remainder.ToString("N2");
        }
        #endregion
        #region Main Save/Update Logic (btn_Valider_Click)

        private void btn_Valider_Click(object sender, EventArgs e)
        {
            // --- 1. Validation ---
            if (!ValidateInputs()) // Use the validation helper method
            {
                return;
            }
            if (!int.TryParse(cmbWarehouse.SelectedValue?.ToString(), out _selectedWarehouseId) || _selectedWarehouseId <= 0)
            {
                MessageBox.Show("Veuillez sélectionner un dépôt valide pour l'entrée en stock.", "Dépôt Invalide", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            bool isSaveSuccessful = false;

            // --- 2. Database Transaction Block ---
            // This block will ONLY handle saving the data.
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    if (isEditMode)
                    {
                        ExecuteUpdatePurchase(conn, transaction);
                    }
                    else
                    {
                        ExecuteNewPurchase(conn, transaction);
                    }

                    transaction.Commit();
                    isSaveSuccessful = true; // Mark the save as successful
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    isSaveSuccessful = false;
                    MessageBox.Show($"فشل حفظ البيانات: {ex.Message}\n\nStackTrace: {ex.StackTrace}", "خطأ فادح", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } // The using block ensures the connection is closed here.

            // --- 3. Post-Save Actions Block ---
            // This code runs only if the database save was successful.
            if (isSaveSuccessful)
            {
                MessageBox.Show(isEditMode ? "تم تعديل الفاتورة بنجاح" : "تم حفظ الفاتورة بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Ask to print only for NEW purchases
                if (!isEditMode && MessageBox.Show("Voulez-vous imprimer le bon d'achat ?", "Imprimer", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        // Prepare and print the 80mm ticket
                        // (This is the printing logic we created before)
                        _currentPurchaseTicketForPrint = new PurchaseTicketData
                        {
                            YourCompanyName = AppSettingsManager.CompanyName,
                            YourCompanyAddress = AppSettingsManager.CompanyAddress,
                            YourCompanyPhone = AppSettingsManager.CompanyPhone,
                            YourCompanyVatNumber = AppSettingsManager.VatNumber,
                            TicketTitle = "BON D'ACHAT",
                            PurchaseInvoiceNumber = generatedInvoiceNumber,
                            PurchaseDate = DateTime.Now,
                            SupplierName = lbl_fournisseur.Text,
                            Items = DatagridArticles.Rows.Cast<DataGridViewRow>()
                                .Where(r => !r.IsNewRow)
                                .Select(r => new PurchaseTicketItem
                                {
                                    Name = r.Cells["ArticleName"].Value?.ToString() ?? "",
                                    Quantity = Convert.ToDecimal(r.Cells["quantity"].Value ?? 0),
                                    UnitPrice = Convert.ToDecimal(r.Cells["BuyPrice"].Value ?? 0)
                                }).ToList(),
                            GrandTotalAmount = GetTotalAmountFromGrid(),
                            AmountPaid = 0,
                            AmountDue = GetTotalAmountFromGrid(),
                            PaymentType = "N/A",
                            PaymentStatus = "Non Payé",
                            FooterMessage1 = AppSettingsManager.FooterReceipt,
                            FooterMessage2 = " "
                        };
                        InitiatePurchasePrint();
                        DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    catch (Exception printEx)
                    {
                        // If printing fails, it will no longer crash the application.
                        MessageBox.Show($"La facture a été enregistrée, mais l'impression a échoué: {printEx.Message}", "Erreur d'impression", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }

                // Finally, clear or close the form
                if (isEditMode)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    ClearFormForNextPurchase();
                }
            }
        }
        private bool ValidateInputs()
        {
            if (_selectedSupplierId <= 0)
            {
                MessageBox.Show("Veuillez sélectionner un fournisseur.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (DatagridArticles.Rows.Count == 0 || DatagridArticles.Rows[0].IsNewRow)
            {
                MessageBox.Show("Veuillez ajouter au moins un article à la facture.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cmbWarehouse.SelectedValue == null || !int.TryParse(cmbWarehouse.SelectedValue.ToString(), out _selectedWarehouseId) || _selectedWarehouseId <= 0)
            {
                MessageBox.Show("Veuillez sélectionner un dépôt valide.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void ExecuteNewPurchase(SqlConnection conn, SqlTransaction transaction)
        {
            decimal grandTotal = GetTotalAmountFromGrid();

            // 1. Insert Invoice Header
            string insertInvoiceQuery = "INSERT INTO PurchaseInvoices (InvoiceNumber, SupplierID,blpurchasenumber, SupplierName, PurchaseDate, GrandTotal, TotalAmount, AmountPaid,Discount,CreatedBy, Status) OUTPUT INSERTED.InvoiceID VALUES (@Num, @SID, @blpurchasenumber,@SName, @Date, @GTotal, @TotalAmount,@AmountPaid ,@discount,'Admin', 'Completed');";
            int newInvoiceId;
            using (var cmd = new SqlCommand(insertInvoiceQuery, conn, transaction))
            {
                cmd.Parameters.AddWithValue("@Num", generatedInvoiceNumber);
                cmd.Parameters.AddWithValue("@blpurchasenumber", txt_CurrentInvoiceNumber.Text);
                cmd.Parameters.AddWithValue("@SID", _selectedSupplierId);
                cmd.Parameters.AddWithValue("@SName", lbl_fournisseur.Text); // Use the label text
                cmd.Parameters.AddWithValue("@Date", DateTime.Now);
                cmd.Parameters.AddWithValue("@GTotal", grandTotal);
                cmd.Parameters.AddWithValue("@AmountPaid", 0);
                cmd.Parameters.AddWithValue("@TotalAmount", grandTotal); // Assuming same for now
                cmd.Parameters.AddWithValue("@Discount", _globalDiscountAmount); 
                newInvoiceId = (int)cmd.ExecuteScalar();
            }

            // 2. Insert Invoice Items and Update Stock for each item
            foreach (DataGridViewRow row in DatagridArticles.Rows)
            {
                if (row.IsNewRow) continue;
                var item = PurchaseGridItem.FromRow(row, ArticleIdColName);

                SavePurchaseItem(conn, transaction, newInvoiceId, item);
                UpdateStockAndHistory(conn, transaction, item.ArticleID, item.Quantity, _selectedWarehouseId, "Purchase", generatedInvoiceNumber);
            }

            // 3. Update Supplier Debt
            UpdateSupplierDebt(conn, transaction, _selectedSupplierId, grandTotal);

            // 4. Increment Invoice Series Number
            UpdateNextInvoiceNumber(conn, transaction);
        }

        private void ExecuteUpdatePurchase(SqlConnection conn, SqlTransaction transaction)
        {
            decimal newGrandTotal = GetTotalAmountFromGrid();
            decimal changeInTotal = newGrandTotal - this.originalGrandTotal;

            // 1. Calculate stock changes and apply them
            var stockChanges = CalculateStockChanges();
            foreach (var change in stockChanges)
            {
                if (change.Value != 0) // Only process if there's a change in quantity
                {
                    UpdateStockAndHistory(conn, transaction, change.Key, change.Value, _selectedWarehouseId, "Purchase-Edit", this.Text);
                }
            }

            // 2. Update Invoice Header
            string updateInvoiceQuery = "UPDATE PurchaseInvoices SET GrandTotal = @GrandTotal, TotalAmount = @TotalAmount, SupplierID = @SID, SupplierName = @SName,blpurchasenumber = @blpurchasenumber WHERE InvoiceID = @InvoiceID";
            using (var cmd = new SqlCommand(updateInvoiceQuery, conn, transaction))
            {
                cmd.Parameters.AddWithValue("@GrandTotal", newGrandTotal);
                cmd.Parameters.AddWithValue("@TotalAmount", newGrandTotal);
                cmd.Parameters.AddWithValue("@SID", _selectedSupplierId);
                cmd.Parameters.AddWithValue("@SName", lbl_fournisseur.Text);
                cmd.Parameters.AddWithValue("@InvoiceID", currentPurchaseInvoicePK);
                cmd.Parameters.AddWithValue("@blpurchasenumber", txt_CurrentInvoiceNumber);
                cmd.ExecuteNonQuery();
            }

            // 3. Update supplier debt with the difference
            if (changeInTotal != 0)
            {
                UpdateSupplierDebt(conn, transaction,_selectedSupplierId, changeInTotal);
            }

            // 4. Delete old items and re-insert new ones
            using (var cmd = new SqlCommand("DELETE FROM PurchaseInvoiceItems WHERE InvoiceID = @InvoiceID", conn, transaction))
            {
                cmd.Parameters.AddWithValue("@InvoiceID", currentPurchaseInvoicePK);
                cmd.ExecuteNonQuery();
            }
            foreach (DataGridViewRow row in DatagridArticles.Rows)
            {
                if (row.IsNewRow) continue;
                var item = PurchaseGridItem.FromRow(row, ArticleIdColName);
                SavePurchaseItem(conn, transaction, currentPurchaseInvoicePK, item);
            }
        }

        private void ClearFormForNextPurchase()
        {
            DatagridArticles.Rows.Clear();
            if (cmbSuppliers.Items.Count > 0) cmbSuppliers.SelectedIndex = 0;
            if (cmbWarehouse.Items.Count > 0) cmbWarehouse.SelectedIndex = 0;
            InitializeDefaultValues();
            GenerateNewInvoiceNumber();
            currentPage = 0;
            LoadArticlesForSelection();
        }

        #endregion
        #region Core Database & Stock Logic

        private void UpdateStockAndHistory(SqlConnection conn, SqlTransaction transaction, int articleId, decimal quantityChange, int warehouseId, string movementType, string referenceId)
        {
            if (quantityChange == 0) return;

            // --- 1. UPSERT into ArticleStock and get the new quantity ---
            string upsertStockQuery = @"
        MERGE ArticleStock AS target
        USING (SELECT @ArticleID AS ArticleID, @WarehouseID AS WarehouseID) AS source
        ON (target.ArticleID = source.ArticleID AND target.WarehouseID = source.WarehouseID)
        WHEN MATCHED THEN 
            UPDATE SET Quantity = target.Quantity + @QuantityChange
        WHEN NOT MATCHED BY TARGET THEN 
            INSERT (ArticleID, WarehouseID, Quantity) VALUES (@ArticleID, @WarehouseID, @QuantityChange)
        OUTPUT INSERTED.Quantity;";

            decimal newWarehouseQuantity;

            using (SqlCommand stockCmd = new SqlCommand(upsertStockQuery, conn, transaction))
            {
                stockCmd.Parameters.AddWithValue("@ArticleID", articleId);
                stockCmd.Parameters.AddWithValue("@WarehouseID", warehouseId);
                stockCmd.Parameters.AddWithValue("@QuantityChange", quantityChange);

                object result = stockCmd.ExecuteScalar();
                newWarehouseQuantity = (result == DBNull.Value || result == null) ? 0 : Convert.ToDecimal(result);
            }

            // --- 2. Update the total aggregate stock in the main Articles table ---
            string updateTotalStockQuery = @"
        UPDATE Articles 
        SET QuantityStock = (SELECT ISNULL(SUM(Quantity), 0) FROM ArticleStock WHERE ArticleID = @ArticleID)
        WHERE Id = @ArticleID";

            using (SqlCommand updateTotalCmd = new SqlCommand(updateTotalStockQuery, conn, transaction))
            {
                updateTotalCmd.Parameters.AddWithValue("@ArticleID", articleId);
                updateTotalCmd.ExecuteNonQuery();
            }

            // --- 3. Log the movement in ArticleStockHistory ---
            string insertHistoryQuery = @"
INSERT INTO ArticleStockHistory (ArticleID, WarehouseID, ChangeQuantity, NewQuantity, MovementType, ReferenceID, UserID) 
VALUES (@ArticleID, @WarehouseID, @ChangeQuantity, @NewQuantity, @MovementType, @ReferenceID, @UserID)";

            using (SqlCommand historyCmd = new SqlCommand(insertHistoryQuery, conn, transaction))
            {
                historyCmd.Parameters.AddWithValue("@ArticleID", articleId);
                historyCmd.Parameters.AddWithValue("@WarehouseID", warehouseId);
                historyCmd.Parameters.AddWithValue("@ChangeQuantity", quantityChange);
                historyCmd.Parameters.AddWithValue("@NewQuantity", newWarehouseQuantity);
                historyCmd.Parameters.AddWithValue("@MovementType", movementType);
                historyCmd.Parameters.AddWithValue("@ReferenceID", referenceId);
                historyCmd.Parameters.AddWithValue("@UserID", SessionManager.CurrentUser); // Use the logged-in user
                historyCmd.ExecuteNonQuery();
            }
        }
        private void SavePurchaseItem(SqlConnection conn, SqlTransaction transaction, int invoiceId, PurchaseGridItem item)
        {
            string insertItemQuery = "INSERT INTO PurchaseInvoiceItems (InvoiceID, ArticleID, Barcode, ArticleName, Quantity, BuyPrice, TotalPrice) VALUES (@InvoiceID, @ArticleID, @Barcode, @ArticleName, @Quantity, @BuyPrice, @TotalPrice)";
            using (SqlCommand itemCmd = new SqlCommand(insertItemQuery, conn, transaction))
            {
                itemCmd.Parameters.AddWithValue("@InvoiceID", invoiceId);
                itemCmd.Parameters.AddWithValue("@ArticleID", item.ArticleID); // Now reads the correct ID from the item object
                itemCmd.Parameters.AddWithValue("@Barcode", item.Barcode ?? string.Empty);
                itemCmd.Parameters.AddWithValue("@ArticleName", item.ArticleName);
                itemCmd.Parameters.AddWithValue("@Quantity", item.Quantity);
                itemCmd.Parameters.AddWithValue("@BuyPrice", item.BuyPrice);
                itemCmd.Parameters.AddWithValue("@TotalPrice", item.TotalPrice);
                itemCmd.ExecuteNonQuery();
            }
        }

        private void UpdateSupplierDebt(SqlConnection conn, SqlTransaction transaction, int supplierId, decimal amountChange)
        {
            // CORRECTED: Using 'CurrentBalance' to match your database table schema
            string query = "UPDATE Suppliers SET CurrentBalance = ISNULL(CurrentBalance, 0) + @Amount WHERE SupplierID = @SID";

            using (var cmd = new SqlCommand(query, conn, transaction))
            {
                cmd.Parameters.AddWithValue("@Amount", amountChange);
                cmd.Parameters.AddWithValue("@SID", supplierId);
                cmd.ExecuteNonQuery();
            }
        }

        private void UpdateNextInvoiceNumber(SqlConnection conn, SqlTransaction transaction)
        {
            int nextSerial = AppSettingsManager.SerieAchat + 1;
            string queryUpdateSerial = "UPDATE AppSettings SET SettingValue = @NewValue WHERE SettingKey = 'SerieAchat'";
            using (var cmd = new SqlCommand(queryUpdateSerial, conn, transaction))
            {
                cmd.Parameters.AddWithValue("@NewValue", nextSerial.ToString());
                cmd.ExecuteNonQuery();
            }
            // The line causing the error has been removed.
        }

        // In Achat.cs

        // --- THIS IS THE CORRECTED METHOD ---
        // It now correctly returns a Dictionary with a decimal for the quantity change.
        private Dictionary<int, decimal> CalculateStockChanges()
        {
            var changes = new Dictionary<int, decimal>(); // Changed from <int, int> to <int, decimal>

            // Get the current items from the grid
            var currentItems = DatagridArticles.Rows.Cast<DataGridViewRow>()
                .Where(r => !r.IsNewRow)
                .Select(r => PurchaseGridItem.FromRow(r, ArticleIdColName))
                .ToList();

            // Get a combined list of all unique article IDs from the original invoice and the current grid
            var allArticleIds = originalInvoiceItems.Select(i => i.ArticleID)
                .Union(currentItems.Select(i => i.ArticleID))
                .Distinct();

            foreach (int articleId in allArticleIds)
            {
                // Get the original quantity, defaulting to 0 if the item wasn't on the original invoice
                decimal originalQty = originalInvoiceItems.FirstOrDefault(i => i.ArticleID == articleId)?.Quantity ?? 0;

                // Get the new quantity, defaulting to 0 if the item has been removed
                decimal currentQty = currentItems.FirstOrDefault(i => i.ArticleID == articleId)?.Quantity ?? 0;

                // If the quantity has changed, record the difference
                if (originalQty != currentQty)
                {
                    // The result of (decimal - decimal) is a decimal, which now correctly fits in the dictionary.
                    changes[articleId] = currentQty - originalQty;
                }
            }
            return changes;
        }
        private void LoadPurchaseInvoiceForEditing(int invoicePK)
        {
            try
            {
                using (var conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string invoiceQuery = "SELECT * FROM PurchaseInvoices WHERE InvoiceID = @InvoiceID";
                    using (var invoiceCmd = new SqlCommand(invoiceQuery, conn))
                    {
                        invoiceCmd.Parameters.AddWithValue("@InvoiceID", invoicePK);
                        using (var reader = invoiceCmd.ExecuteReader())
                        {
                            if (!reader.Read())
                            {
                                MessageBox.Show("Facture introuvable.");
                                this.Close();
                                return;
                            }

                            this.Text = $"Modifier Facture: {reader["InvoiceNumber"]}";
                            lbl_CurrentInvoiceNumber.Text = reader["InvoiceNumber"]?.ToString();
                            txt_CurrentInvoiceNumber.Text = (reader["blpurchasenumber"] ?? reader["InvoiceNumber"])?.ToString();

                            _selectedSupplierId = reader["SupplierID"] != DBNull.Value ? Convert.ToInt32(reader["SupplierID"]) : 0;

                            // --- BUG FIX: Removed the line that reads 'WarehouseID' as it does not exist ---

                            originalGrandTotal = reader["GrandTotal"] != DBNull.Value ? Convert.ToDecimal(reader["GrandTotal"]) : 0;
                            originalAmountPaid = reader["AmountPaid"] != DBNull.Value ? Convert.ToDecimal(reader["AmountPaid"]) : 0;
                            lbl_total.Text = originalGrandTotal.ToString("N2");
                            lbl_avance.Text = originalAmountPaid.ToString("N2");
                            lbl_reste.Text = (originalGrandTotal - originalAmountPaid).ToString("N2");
                            cmbSuppliers.SelectedValue = _selectedSupplierId;

                            // Set warehouse to a neutral/default state, forcing user to re-select if needed
                            cmbWarehouse.SelectedValue = 0;
                        }
                    }

                    // Load items (this part is good)
                    DatagridArticles.Rows.Clear();
                    _originalInvoiceItems.Clear();
                    string itemsQuery = "SELECT * FROM PurchaseInvoiceItems WHERE InvoiceID = @InvoiceID";
                    using (var itemsCmd = new SqlCommand(itemsQuery, conn))
                    {
                        itemsCmd.Parameters.AddWithValue("@InvoiceID", invoicePK);
                        using (var itemReader = itemsCmd.ExecuteReader())
                        {
                            while (itemReader.Read())
                            {
                                var item = new PurchaseGridItem
                                {
                                    ArticleID = itemReader["ArticleID"] != DBNull.Value ? Convert.ToInt32(itemReader["ArticleID"]) : 0,
                                    Barcode = itemReader["Barcode"]?.ToString(),
                                    ArticleName = itemReader["ArticleName"]?.ToString(),
                                    Quantity = itemReader["Quantity"] != DBNull.Value ? Convert.ToDecimal(itemReader["Quantity"]) : 0,
                                    BuyPrice = itemReader["BuyPrice"] != DBNull.Value ? Convert.ToDecimal(itemReader["BuyPrice"]) : 0,
                                    Discount =itemReader["discount"] != DBNull.Value ? Convert.ToDecimal(itemReader["discount"]) : 0
                                };
                                _originalInvoiceItems.Add(item);
                                DatagridArticles.Rows.Add(item.ArticleID, item.Barcode, item.ArticleName, item.Quantity, item.BuyPrice, item.TotalPrice, item.Discount);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement de la facture: {ex.Message}");
                this.Close();
            }
        }
        #endregion

        #region Helper Classes & Methods
        private void SavePurchaseItem(SqlConnection conn, SqlTransaction transaction, int invoiceId, DataGridViewRow row)
        {
            string insertItemQuery = "INSERT INTO PurchaseInvoiceItems (InvoiceID, ArticleID, Barcode, ArticleName, Quantity, BuyPrice, TotalPrice) VALUES (@InvoiceID, @ArticleID, @Barcode, @ArticleName, @Quantity, @BuyPrice, @TotalPrice)";
            using (SqlCommand itemCmd = new SqlCommand(insertItemQuery, conn, transaction))
            {
                itemCmd.Parameters.AddWithValue("@InvoiceID", invoiceId);
                itemCmd.Parameters.AddWithValue("@ArticleID", Convert.ToInt32(row.Tag));
                itemCmd.Parameters.AddWithValue("@Barcode", row.Cells["Barcode"].Value.ToString());
                itemCmd.Parameters.AddWithValue("@ArticleName", row.Cells["ArticleName"].Value.ToString());
                itemCmd.Parameters.AddWithValue("@Quantity", Convert.ToDecimal(row.Cells["quantity"].Value));
                itemCmd.Parameters.AddWithValue("@BuyPrice", Convert.ToDecimal(row.Cells["BuyPrice"].Value));
                itemCmd.Parameters.AddWithValue("@TotalPrice", Convert.ToDecimal(row.Cells["tot"].Value));
                itemCmd.ExecuteNonQuery();
            }
        }
        // <<-- استبدل الدالة القديمة بهذه النسخة الكاملة والمصححة -->>
        private class ComboBoxItem
        {
            public string Text { get; set; }
            public int Value { get; set; }
            public override string ToString() => Text;
        }
        private class PurchaseGridItem
        {
            public int ArticleID { get; set; }
            public string Barcode { get; set; }
            public string ArticleName { get; set; }
            public decimal Quantity { get; set; }
            public decimal BuyPrice { get; set; }
            public decimal Discount { get; set; }
            public decimal TotalPrice => Quantity * BuyPrice;

            public static PurchaseGridItem FromRow(DataGridViewRow row, string idColName)
            {
                return new PurchaseGridItem
                {
                    ArticleID = Convert.ToInt32(row.Cells[idColName].Value),
                    Barcode = row.Cells["Barcode"].Value?.ToString(),
                    ArticleName = row.Cells["ArticleName"].Value?.ToString(),
                    Quantity = Convert.ToDecimal(row.Cells["quantity"].Value),
                    BuyPrice = Convert.ToDecimal(row.Cells["BuyPrice"].Value),
                    Discount = Convert.ToDecimal(row.Cells["colRemise"].Value)
                };
            }
        }
        private decimal GetTotalAmountFromGrid()
        {
            decimal total = 0;
            foreach (DataGridViewRow row in DatagridArticles.Rows)
            {
                if (!row.IsNewRow && row.Cells["tot"].Value != null)
                {
                    total += Convert.ToDecimal(row.Cells["tot"].Value);
                }
            }
            return total;
        }

        #endregion

        private void btnOpenAddSupplierForm_Click(object sender, EventArgs e)
        {
            using (AddSupplier addSupplierForm = new AddSupplier())
            {
                if (addSupplierForm.ShowDialog(this) == DialogResult.OK)
                {
                    // If a supplier was successfully added,
                    // refresh the supplier list in the Achat form's ComboBox
                    LoadSuppliers(); // Assuming LoadSuppliers() in Achat.cs repopulates cmbSuppliers
                }
            }
        }

        private void bunifuButton212_Click(object sender, EventArgs e)
        {

        }

        private void cmbWarehouse_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadArticlesForSelection();
        }

        private void btn_QuantityPlus1_Click(object sender, EventArgs e)
        {
            if (DatagridArticles.SelectedRows.Count == 0) return;
            var row = DatagridArticles.SelectedRows[0];

            decimal currentQty = Convert.ToDecimal(row.Cells["quantity"].Value);
            row.Cells["quantity"].Value = currentQty + 1;
            UpdateTotals();

        }

        private void btn_quantitymoin1_Click(object sender, EventArgs e)
        {
            if (DatagridArticles.SelectedRows.Count == 0) return;
            var row = DatagridArticles.SelectedRows[0];

            decimal currentQty = Convert.ToDecimal(row.Cells["quantity"].Value);
            if (currentQty > 1)
            {
                row.Cells["quantity"].Value = currentQty - 1;
            }
            else
            {
                DatagridArticles.Rows.Remove(row);
            }
            UpdateTotals();
        }

        private void btn_discount_Click(object sender, EventArgs e)
        {
            using (var discountForm = new DiscountForm())
            {
                if (discountForm.ShowDialog(this) != DialogResult.OK) return;

                decimal discountValue = discountForm.DiscountValue;
                bool isPercentage = discountForm.IsPercentage;

                var result = MessageBox.Show("Appliquer sur toute la facture (OUI) ou sur le(s) article(s) sélectionné(s) (NON) ?",
                                             "Appliquer la Remise", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (result == DialogResult.Cancel) return;

                ClearAllRowDiscounts();

                if (result == DialogResult.Yes) // Apply to ALL rows
                {
                    if (isPercentage)
                    {
                        foreach (DataGridViewRow row in DatagridArticles.Rows)
                        {
                            ApplyDiscountToRow(row, discountValue, true);
                        }
                    }
                    else
                    {
                        _globalDiscountAmount = discountValue;
                    }
                }
                else // Apply to SELECTED rows only
                {
                    if (DatagridArticles.SelectedRows.Count == 0)
                    {
                        MessageBox.Show("Veuillez sélectionner au moins un article.", "Aucune Sélection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    foreach (DataGridViewRow row in DatagridArticles.SelectedRows)
                    {
                        ApplyDiscountToRow(row, discountValue, isPercentage);
                    }
                }
                UpdateTotals();
            }
        }
        private void ApplyDiscountToRow(DataGridViewRow row, decimal discountValue, bool isPercentage)
        {
            if (row == null || row.IsNewRow || row.Tag as Article == null) return;
            var article = (Article)row.Tag;


            int articleId = Convert.ToInt32(row.Tag);
            decimal quantity = Convert.ToDecimal(row.Cells["Quantity"].Value);
            decimal originalPrice = article.BuyPrice;

            decimal originalRowTotal = originalPrice * quantity;
            decimal discountAmountForRow;
            if (isPercentage)
            {
                discountAmountForRow = originalRowTotal * (discountValue / 100m);
                // Apply percentage discount to the Buy Price for this row
                //row.Cells["BuyPrice"].Value = originalPrice * (1 - (discountValue / 100m));
                row.Cells["colRemise"].Value = $"{discountValue:F2} %";

            }
            else // Fixed amount discount on a single row
            {
                // We record the fixed discount amount in the Remise column
                row.Cells["colRemise"].Value = discountValue.ToString("N2");
            }
            UpdateTotals(); // Recalculate everything after the change
        }

        private void ClearAllRowDiscounts()
        {
            _globalDiscountAmount = 0; // Reset global discount
            foreach (DataGridViewRow row in DatagridArticles.Rows)
            {
                if (row.IsNewRow || row.Tag as Article == null) continue;
                var article = (Article)row.Tag;

                row.Cells["BuyPrice"].Value = article.BuyPrice; // Reset to original buy price
                row.Cells["colRemise"].Value = string.Empty;
            }
            UpdateTotals();
        }

        #region Discount Logic

        private void ApplyPercentageDiscount(decimal percentageValue)
        {
            var result = MessageBox.Show("Appliquer sur toute la facture (OUI) ou sur l'article sélectionné (NON) ?", "Appliquer la Remise", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Cancel) return;

            var rowsToDiscount = (result == DialogResult.Yes)
                ? DatagridArticles.Rows.Cast<DataGridViewRow>()
                : DatagridArticles.SelectedRows.Cast<DataGridViewRow>();

            foreach (var row in rowsToDiscount)
            {
                if (row.IsNewRow || row.Tag as Article == null) continue;
                var article = (Article)row.Tag;
                decimal originalPrice = article.BuyPrice;
                row.Cells["BuyPrice"].Value = originalPrice * (1 - (percentageValue / 100m));
                row.Cells["colRemise"].Value = $"{percentageValue:F2} %";
            }
        }

        private void ApplyFixedDiscount(decimal fixedAmount)
        {
            var result = MessageBox.Show("Appliquer sur toute la facture (OUI) ou sur l'article sélectionné (NON) ?", "Appliquer la Remise", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Cancel) return;

            if (result == DialogResult.Yes)
            {
                _globalDiscountAmount = fixedAmount;
            }
            else
            {
                if (DatagridArticles.SelectedRows.Count == 0) return;
                DataGridViewRow row = DatagridArticles.SelectedRows[0];
                if (row.IsNewRow) return;

                decimal currentTotal = Convert.ToDecimal(row.Cells["Tot"].Value);
                row.Cells["Tot"].Value = currentTotal - fixedAmount;
                row.Cells["colRemise"].Value = fixedAmount.ToString("N2");
            }
        }


        #endregion

        #region Total & Update Logic


        #endregion
        #region Class Members
        private int _selectedSupplierId = 0;
        private string _generatedInvoiceNumber;
        private bool _isEditMode = false;
        private int _editingPurchaseInvoiceId = 0;
        private List<PurchaseGridItem> _originalInvoiceItems = new List<PurchaseGridItem>();
        private decimal _globalDiscountAmount = 0;
        #endregion
    }
}