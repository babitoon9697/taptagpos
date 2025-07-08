using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using TheArtOfDev.HtmlRenderer.Adapters;

namespace TAPTAGPOS
{
    public partial class ListeTicketPurchase : Form
    {
        string connectionString = DatabaseConnection.connectionString;
        private bool useA4InvoicePrintPreview = true; // true for preview, false for direct print
        private A4PurchaseInvoiceData _currentA4InvoiceData;
        public ListeTicketPurchase()
        {
            InitializeComponent();
        }
        private void LoadSuppliers()
        {
            string query = "SELECT SupplierID, Name FROM Suppliers WHERE Status = 'Active' ORDER BY Name";
            using (SqlConnection conn = new SqlConnection(DatabaseConnection.GetConnectionString()))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cmbSuppliers.Items.Add(new
                    {
                        Text = reader["Name"].ToString(),
                        Value = reader["SupplierID"]
                    });
                }
            }
        }
        private void LoadPurchases()
        {
            string query = @"
        SELECT 
            InvoiceID, InvoiceNumber, PurchaseDate, SupplierName, GrandTotal
        FROM PurchaseInvoices
        ORDER BY PurchaseDate DESC";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int index = dataGridViewFactures.Rows.Add();
                    dataGridViewFactures.Rows[index].Cells["InvoiceID"].Value = reader["InvoiceID"];
                    dataGridViewFactures.Rows[index].Cells["InvoiceNumber"].Value = reader["InvoiceNumber"];
                    dataGridViewFactures.Rows[index].Cells["PurchaseDate"].Value = reader["PurchaseDate"];
                    dataGridViewFactures.Rows[index].Cells["SupplierName"].Value = reader["SupplierName"];
                    dataGridViewFactures.Rows[index].Cells["GrandTotal"].Value = reader["GrandTotal"];
                }
            }
        }

        private void ListeTicketPurchase_Load(object sender, EventArgs e)
        {
            LoadSuppliers();
            LoadPurchases();
        }

        private void bunifuButton23_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_AddArticlesForm_Click(object sender, EventArgs e)
        {
            Achat c = new Achat();
            c.ShowDialog();
            if(c.DialogResult == DialogResult.OK)
            {
                dataGridViewFactures.Rows.Clear();
                LoadPurchases();
            }
        }

        private void btnEditPurchase_Click(object sender, EventArgs e)
        {
            if (dataGridViewFactures.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewFactures.SelectedRows[0];

                // Ensure the "InvoiceID" cell and its value are not null
                if (selectedRow.Cells["InvoiceID"].Value != null &&
                    int.TryParse(selectedRow.Cells["InvoiceID"].Value.ToString(), out int invoiceIdToEdit))
                {
                    // Open Achat form in edit mode, passing the primary key of the PurchaseInvoices table
                    // We are assuming 'InvoiceID' column in dataGridViewFactures holds this PK.
                    using (Achat editAchatForm = new Achat(invoiceIdToEdit)) // Requires a new constructor in Achat.cs
                    {
                        DialogResult result = editAchatForm.ShowDialog(this); // Show as modal dialog
                        if (result == DialogResult.OK)
                        {
                            // If Achat form returns OK (meaning update was successful), refresh the list
                            LoadPurchases();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("L'ID de la facture sélectionnée est invalide ou introuvable.", "Erreur de Sélection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une facture à modifier.", "Sélection Requise", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private A4PurchaseInvoiceData FetchA4InvoiceData(int purchaseInvoicePK)
        {
            A4PurchaseInvoiceData data = new A4PurchaseInvoiceData();
            // Populate Your Company details from data class defaults or config

            using (SqlConnection conn = new SqlConnection(connectionString)) // Use class member connectionString
            {
                conn.Open();
                // 1. Fetch PurchaseInvoice details
                string invoiceQuery = @"
                    SELECT pi.*, s.Name AS FullSupplierName, s.Address AS SupplierAddress, 
                           s.ContactPerson AS SupplierContactPerson, s.Phone AS SupplierPhone, 
                           s.VATNumber AS SupplierVatId, s.PaymentTerms AS SupplierPaymentTerms, s.Notes AS SupplierNotes
                    FROM PurchaseInvoices pi
                    LEFT JOIN Suppliers s ON pi.SupplierID = s.SupplierID
                    WHERE pi.InvoiceID = @InvoiceID_PK";
                // Ensure pi.InvoiceID is the PK of PurchaseInvoices
                // If your PK is named differently, adjust pi.InvoiceID and @InvoiceID_PK

                using (SqlCommand cmd = new SqlCommand(invoiceQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@InvoiceID_PK", purchaseInvoicePK);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            data.InvoiceNumber = reader["InvoiceNumber"]?.ToString();
                            data.InvoiceDate = Convert.ToDateTime(reader["PurchaseDate"]);
                            data.SupplierName = reader["FullSupplierName"]?.ToString();
                            data.SupplierAddress = reader["SupplierAddress"]?.ToString();
                            data.SupplierContactPerson = reader["SupplierContactPerson"]?.ToString();
                            data.SupplierPhone = reader["SupplierPhone"]?.ToString();
                            data.SupplierVatId = reader["SupplierVatId"]?.ToString();
                            data.PaymentTerms = reader["SupplierPaymentTerms"]?.ToString();
                            // If PurchaseInvoices table also stores PaymentTerms that override supplier's, prioritize that
                            // data.PaymentTerms = reader["InvoicePaymentTerms"]?.ToString() ?? reader["SupplierPaymentTerms"]?.ToString();


                            data.SubtotalAmount = Convert.ToDecimal(reader["TotalAmount"]); // Assuming TotalAmount is SubTotal
                            data.DiscountAmount = Convert.ToDecimal(reader["Discount"]);
                            data.TaxAmount = Convert.ToDecimal(reader["Tax"]);
                            data.GrandTotalAmount = Convert.ToDecimal(reader["GrandTotal"]);
                            data.PaymentMethod = reader["PaymentType"]?.ToString();
                            // Assuming 'AmountPaid' for this specific invoice is not directly in PurchaseInvoices
                            // but rather related to 'lbl_avance' from Achat form if payment was made then.
                            // For a historical invoice, AmountPaid might need to be fetched from a payments table.
                            // For simplicity, let's assume GrandTotal - AmountDue logic or get it from somewhere
                            // data.AmountPaid = ... (You might need another query or table for actual payments made against this invoice)
                            // For now, let's set AmountPaid based on status, or assume it's the grand total if paid
                            data.AmountPaid = (reader["PaymentStatus"]?.ToString().Equals("Paid", StringComparison.OrdinalIgnoreCase) ?? false) ? data.GrandTotalAmount : 0m;
                            // Add notes if your PurchaseInvoices table has a notes field:
                            // data.Notes = reader["InvoiceNotes"]?.ToString() ?? data.Notes;
                        }
                        else { return null; /* Invoice not found */ }
                    }
                }

                // 2. Fetch PurchaseInvoiceItems
                string itemsQuery = @"
    SELECT 
        a.Article AS ItemCodeFromArticleTable, -- This is the Article Code from Articles table
        pii.ArticleName,                      -- This is the name stored at time of purchase
        pii.Quantity, 
        pii.BuyPrice, 
        pii.TotalPrice,
        pii.Barcode AS ItemBarcode,           -- Barcode stored in PurchaseInvoiceItems
        a.Unite AS UnitOfMeasure
    FROM PurchaseInvoiceItems pii
    LEFT JOIN Articles a ON pii.ArticleID = a.Id
    WHERE pii.InvoiceID = @InvoiceID_PK_Items";


                using (SqlCommand cmdItems = new SqlCommand(itemsQuery, conn))
                {
                    cmdItems.Parameters.AddWithValue("@InvoiceID_PK_Items", purchaseInvoicePK);
                    int lineNumber = 1;
                    using (SqlDataReader readerItems = cmdItems.ExecuteReader())
                    {
                        while (readerItems.Read())
                        {
                            data.Items.Add(new A4PurchaseInvoiceItem
                            {
                                LineNumber = lineNumber++,
                                ItemCode = readerItems["ItemCodeFromArticleTable"]?.ToString(), // Article's short code/name
                                Barcode = readerItems["ItemBarcode"]?.ToString(),             // <<< POPULATE BARCODE
                                Description = readerItems["ArticleName"]?.ToString(),         // This is likely ArticleLongName or similar
                                Quantity = Convert.ToInt32(readerItems["Quantity"]),
                                UnitPrice = Convert.ToDecimal(readerItems["BuyPrice"]),
                                UnitOfMeasure = readerItems.IsDBNull(readerItems.GetOrdinal("UnitOfMeasure")) ? "PCE" : readerItems["UnitOfMeasure"]?.ToString(),
                            });
                        }
                    }
                }
            }
            return data;
        }
        private void InitiateA4InvoicePrint()
        {
            if (_currentA4InvoiceData == null) return;

            using (PrintDocument pd = new PrintDocument())
            {
                // Printer Name (Optional, but good for consistency)
                // string targetPrinterName = "Microsoft Print to PDF"; // Or your actual A4 printer
                // if (PrinterSettings.InstalledPrinters.Cast<string>().Any(p => p.Equals(targetPrinterName, StringComparison.OrdinalIgnoreCase)))
                // {
                //    pd.PrinterSettings.PrinterName = targetPrinterName;
                // }

                // Page Settings for A4 Landscape
                pd.DefaultPageSettings.Landscape = true;
                PaperSize pkA4 = null;
                foreach (PaperSize ps in pd.PrinterSettings.PaperSizes)
                {
                    if (ps.Kind == PaperKind.A4) { pkA4 = ps; break; }
                }
                pd.DefaultPageSettings.PaperSize = pkA4 ?? new PaperSize("A4", 827, 1169); // Default A4 if not found (width/height in 1/100 inch for portrait)
                // For landscape, these dimensions are swapped by the Landscape=true setting.

                pd.DefaultPageSettings.Margins = new Margins(50, 50, 50, 50); // 0.5 inch margins

                pd.PrintPage += new PrintPageEventHandler(A4InvoicePrintPageHandler);

                if (useA4InvoicePrintPreview)
                {
                    using (PrintPreviewDialog previewDialog = new PrintPreviewDialog())
                    {
                        previewDialog.Document = pd;
                        previewDialog.WindowState = FormWindowState.Maximized;
                        previewDialog.Text = "Aperçu Facture Achat A4";
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

        private void A4InvoicePrintPageHandler(object sender, PrintPageEventArgs e)
        {
            if (_currentA4InvoiceData == null) return;

            Graphics g = e.Graphics;
            A4PurchaseInvoiceData data = _currentA4InvoiceData;

            Font titleFont = new Font("Arial", 16, FontStyle.Bold);
            Font headerFont = new Font("Arial", 10, FontStyle.Bold);
            Font bodyFont = new Font("Arial", 10);
            Font smallBodyFont = new Font("Arial", 8);
            Pen blackPen = new Pen(Color.Black, 1);

            float yPos = e.MarginBounds.Top;
            float leftMargin = e.MarginBounds.Left;
            float rightMargin = e.MarginBounds.Right;
            float printableWidth = e.MarginBounds.Width;
            float printableHeight = e.MarginBounds.Height;
            float lineHeight = bodyFont.GetHeight(g);
            float currentX;

            StringFormat sfLeft = new StringFormat { Alignment = StringAlignment.Near, LineAlignment = StringAlignment.Center };
            StringFormat sfRight = new StringFormat { Alignment = StringAlignment.Far, LineAlignment = StringAlignment.Center };
            StringFormat sfCenter = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };

            // --- 1. Purchaser (Your Company) & Supplier Details Side-by-Side ---
            float halfWidth = printableWidth / 2 - 10; // 10 for padding between columns

            // Purchaser Details (Left Column)
            currentX = leftMargin;
            float initialYPurchaser = yPos;
            if (!string.IsNullOrEmpty(data.PurchaserLogoPath) && File.Exists(data.PurchaserLogoPath))
            {
                using (Image logo = Image.FromFile(data.PurchaserLogoPath))
                {
                    float logoW = 100, logoH = (logo.Height / (float)logo.Width) * logoW;
                    g.DrawImage(logo, currentX, yPos, logoW, logoH);
                    yPos += logoH + 5;
                }
            }
            g.DrawString(data.PurchaserCompanyName, headerFont, Brushes.Black, new RectangleF(currentX, yPos, halfWidth, lineHeight), sfLeft); yPos += lineHeight;
            g.DrawString(data.PurchaserAddress.Replace("\n", Environment.NewLine), smallBodyFont, Brushes.Black, new RectangleF(currentX, yPos, halfWidth, lineHeight * 2), sfLeft); yPos += lineHeight * 2;
            g.DrawString(data.PurchaserPhone, smallBodyFont, Brushes.Black, new RectangleF(currentX, yPos, halfWidth, lineHeight), sfLeft); yPos += lineHeight;
            g.DrawString(data.PurchaserEmail, smallBodyFont, Brushes.Black, new RectangleF(currentX, yPos, halfWidth, lineHeight), sfLeft); yPos += lineHeight;
            g.DrawString(data.PurchaserVatId, smallBodyFont, Brushes.Black, new RectangleF(currentX, yPos, halfWidth, lineHeight), sfLeft); yPos += lineHeight;
            float maxYLeft = yPos;

            // Supplier Details (Right Column)
            yPos = initialYPurchaser; // Reset Y for right column
            currentX = leftMargin + halfWidth + 20;
            g.DrawString("FOURNISSEUR:", headerFont, Brushes.Black, new RectangleF(rightMargin-150, yPos, halfWidth, lineHeight), sfLeft); yPos += lineHeight + 5;
            g.DrawString(data.SupplierName, bodyFont, Brushes.Black, new RectangleF(rightMargin-150, yPos, halfWidth, lineHeight), sfLeft); yPos += lineHeight;
            if (!string.IsNullOrWhiteSpace(data.SupplierAddress))
            {
                g.DrawString(data.SupplierAddress.Replace("\n", Environment.NewLine), smallBodyFont, Brushes.Black, new RectangleF(rightMargin - 150, yPos, halfWidth, lineHeight * 2), sfLeft); yPos += lineHeight * 2;
            }
            if (!string.IsNullOrWhiteSpace(data.SupplierContactPerson))
            {
                g.DrawString($"Attn: {data.SupplierContactPerson}", smallBodyFont, Brushes.Black, new RectangleF(rightMargin - 150, yPos, halfWidth, lineHeight), sfLeft); yPos += lineHeight;
            }
            if (!string.IsNullOrWhiteSpace(data.SupplierPhone))
            {
                g.DrawString($"Tél: {data.SupplierPhone}", smallBodyFont, Brushes.Black, new RectangleF(rightMargin - 150, yPos, halfWidth, lineHeight), sfLeft); yPos += lineHeight;
            }
            if (!string.IsNullOrWhiteSpace(data.SupplierVatId))
            {
                g.DrawString($"ICE/RC: {data.SupplierVatId}", smallBodyFont, Brushes.Black, new RectangleF(rightMargin - 150, yPos, halfWidth, lineHeight), sfLeft); yPos += lineHeight;
            }
            yPos = Math.Max(maxYLeft, yPos) + lineHeight * 2; // Ensure yPos is below the taller column

            // --- 2. Invoice Title and Details ---
            g.DrawString(data.InvoiceTitle, titleFont, Brushes.Black, new RectangleF(leftMargin, yPos, printableWidth, titleFont.GetHeight(g)), sfCenter);
            yPos += titleFont.GetHeight(g) + lineHeight;

            float infoBoxX = leftMargin + 50; // Box for Invoice No, Date etc on the right
            float infoBoxWidth = 300;
            g.DrawString($"Facture N°: {data.InvoiceNumber}", headerFont, Brushes.Black, infoBoxX, yPos); yPos += lineHeight;
            g.DrawString($"Date Facture: {data.InvoiceDate:dd/MM/yyyy}", bodyFont, Brushes.Black, infoBoxX, yPos); yPos += lineHeight;
            if (!string.IsNullOrWhiteSpace(data.PaymentTerms))
            {
                g.DrawString($"Termes Paiement: {data.PaymentTerms}", bodyFont, Brushes.Black, infoBoxX, yPos); yPos += lineHeight;
            }
            yPos += lineHeight; // Extra space

            // --- 3. Items Table ---
            float tableHeaderY = yPos;
            // Define column widths (approximate percentages of printableWidth)
            float colNoX = leftMargin; float colNoWidth = printableWidth * 0.05f;
            float colCodeX = colNoX + colNoWidth; float colCodeWidth = printableWidth * 0.15f;
            float colDescX = colCodeX + colCodeWidth; float colDescWidth = printableWidth * 0.35f;
            float colQtyX = colDescX + colDescWidth; float colQtyWidth = printableWidth * 0.10f;
            float colUnitPX = colQtyX + colQtyWidth; float colUnitPWidth = printableWidth * 0.15f;
            float colTotalPX = colUnitPX + colUnitPWidth; float colTotalPWidth = printableWidth * 0.20f;

            // Draw Headers
            g.FillRectangle(Brushes.LightGray, leftMargin, tableHeaderY, printableWidth, lineHeight + 2); // Header background
            g.DrawString("N°", headerFont, Brushes.Black, colNoX + 2, tableHeaderY + 1);
            g.DrawString("Code Article", headerFont, Brushes.Black, colCodeX + 2, tableHeaderY + 1);
            g.DrawString("Description", headerFont, Brushes.Black, colDescX + 2, tableHeaderY + 1);
            g.DrawString("Qté", headerFont, Brushes.Black, new RectangleF(colQtyX, tableHeaderY + 1, colQtyWidth, lineHeight), sfRight);
            g.DrawString("P.U. HT", headerFont, Brushes.Black, new RectangleF(colUnitPX, tableHeaderY + 1, colUnitPWidth, lineHeight), sfRight);
            g.DrawString("Total HT", headerFont, Brushes.Black, new RectangleF(colTotalPX, tableHeaderY + 1, colTotalPWidth, lineHeight), sfRight);
            yPos += lineHeight + 2;
            g.DrawLine(blackPen, leftMargin, yPos, rightMargin, yPos); // Line below headers

            // Draw Items
            foreach (A4PurchaseInvoiceItem item in data.Items)
            {
                float itemRowY = yPos + 2;
                float textHeightForItem = Math.Max(lineHeight, g.MeasureString(item.Description, bodyFont, (int)colDescWidth).Height); // For wrapped description
                string codeToDisplay = item.ItemCode; // Default to Article.Article (short code/name)
                if (!string.IsNullOrWhiteSpace(item.Barcode))
                {
                    // If a specific barcode was recorded for this purchase item and is not empty, prefer it.
                    // You might want to check if item.Barcode is different from item.ItemCode if ItemCode can also be a barcode.
                    // For now, if Barcode field has a value, we use it.
                    codeToDisplay = item.Barcode;
                }

                g.DrawString(item.LineNumber.ToString(), bodyFont, Brushes.Black, colNoX + 2, itemRowY);
                g.DrawString(codeToDisplay, bodyFont, Brushes.Black, colCodeX + 2, itemRowY);
                g.DrawString(item.Description, bodyFont, Brushes.Black, new RectangleF(colDescX + 2, itemRowY, colDescWidth - 4, textHeightForItem));
                g.DrawString(item.Quantity.ToString(), bodyFont, Brushes.Black, new RectangleF(colQtyX, itemRowY, colQtyWidth, lineHeight), sfRight);
                g.DrawString(item.UnitPrice.ToString("N2"), bodyFont, Brushes.Black, new RectangleF(colUnitPX, itemRowY, colUnitPWidth, lineHeight), sfRight);
                g.DrawString(item.TotalLinePrice.ToString("N2"), bodyFont, Brushes.Black, new RectangleF(colTotalPX, itemRowY, colTotalPWidth, lineHeight), sfRight);
                yPos += textHeightForItem + 4; // 2 for top padding, 2 for bottom before line
                g.DrawLine(Pens.LightGray, leftMargin, yPos, rightMargin, yPos); // Line between items
            }
            g.DrawLine(blackPen, leftMargin, yPos, rightMargin, yPos); // Line after last item
            yPos += lineHeight;

            // --- 4. Totals Section (Typically on the right side) ---
            yPos += lineHeight;
            float totalsBlockWidth = printableWidth * 0.50f; // Let totals block take 50% of page width, on the right
            float totalsBlockStartX = rightMargin - (totalsBlockWidth/3)*2 - leftMargin; // X where this block begins
            float labelPartWidth = totalsBlockWidth * 0.60f; // Labels take 60% of the totals block width
            float valuePartWidth = totalsBlockWidth * 0.40f; // Values take 40%
                                                             // Define X coordinates for these parts within the totalsBlock
            float valueColumnX = totalsBlockStartX; // Value column starts at the beginning of totals block
            float labelColumnX = totalsBlockStartX + valuePartWidth; // Label column starts after value column
            StringFormat sfAlignRightWithinRect = new StringFormat
            {
                Alignment = StringAlignment.Far, // Far = Right for LTR rectangles
                LineAlignment = StringAlignment.Center,
                FormatFlags = StringFormatFlags.DirectionRightToLeft // Ensures Arabic text itself is RTL
            };
            // StringFormat for left-aligning text (useful for values if you prefer them left-aligned in their box)
            // StringFormat sfAlignLeftWithinRect = new StringFormat {
            //     Alignment = StringAlignment.Near, // Near = Left for LTR rectangles
            //     LineAlignment = StringAlignment.Center,
            //     FormatFlags = StringFormatFlags.DirectionRightToLeft
            // };

            // Helper Action to draw a single line in the totals section
            Action<string, string, Font, Brush, bool> drawTotalLine =
                (labelText, valueText, font, textColor, isValueBold) =>
                {
                    float currentLineDrawHeight = font.GetHeight(g); // Use actual font height for drawing bounds
                                                                     // Define the rectangle for the label text
                    RectangleF labelRect = new RectangleF(labelColumnX, yPos, labelPartWidth - 5, currentLineDrawHeight); // -5 for padding from edge
                                                                                                                          // Define the rectangle for the value text
                    RectangleF valueRect = new RectangleF(valueColumnX + 5, yPos, valuePartWidth - 5, currentLineDrawHeight); // +5, -5 for padding

                    Font valueFont = isValueBold ? headerFont : font; // Use bold font for value if specified

                    g.DrawString(labelText, font, textColor, labelRect, sfAlignRightWithinRect);
                    g.DrawString(valueText, valueFont, textColor, valueRect, sfAlignRightWithinRect); // Values also right-aligned in their box

                    yPos += currentLineDrawHeight + 2; // Add a small gap (2) between lines
                };

            float totalsX = rightMargin - 250; // X position for totals block
            float labelX = totalsX;
            float valueX = totalsX + 150; // X for values
            drawTotalLine("SOUS-TOTAL HT:", data.SubtotalAmount.ToString("C2"), bodyFont, Brushes.Black, false);

            if (data.DiscountAmount > 0)
            {
                drawTotalLine("REMISE:", data.DiscountAmount.ToString("C2"), bodyFont, Brushes.Black, false);
            }

            // Assuming TaxableAmount is Subtotal - Discount. If you display it:
            // drawTotalLine("MONTANT TAXABLE:", data.TaxableAmount.ToString("C2"), bodyFont, Brushes.Black, false);

            if (data.TaxAmount > 0)
            {
                drawTotalLine($"TVA ({data.TaxRate:P0}):", data.TaxAmount.ToString("C2"), bodyFont, Brushes.Black, false);
            }

            if (data.ShippingAmount > 0)
            {
                drawTotalLine("FRAIS DE PORT:", data.ShippingAmount.ToString("C2"), bodyFont, Brushes.Black, false);
            }
            yPos += 5; // Small gap before the line
            g.DrawLine(blackPen, totalsBlockStartX, yPos, leftMargin + printableWidth, yPos); // Line across the page width or just totals block width
            yPos += 5; // Small gap after the line

            // Line before Grand Total
            drawTotalLine("TOTAL TTC:", data.GrandTotalAmount.ToString("C2"), headerFont, Brushes.Black, true); // Grand total (label and value bold)
            yPos += 5; // Extra space after grand total

            if (data.AmountPaid != 0 || (data.GrandTotalAmount != data.AmountDue && data.AmountDue != 0) || !string.IsNullOrEmpty(data.PaymentMethod))
            {
                if (!string.IsNullOrEmpty(data.PaymentMethod))
                {
                    drawTotalLine("Mode de Paiement:", data.PaymentMethod, bodyFont, Brushes.Black, false);
                }
                drawTotalLine("MONTANT PAYÉ (Avance):", data.AmountPaid.ToString("C2"), bodyFont, Brushes.Black, false);
                drawTotalLine("RESTE À PAYER:", data.AmountDue.ToString("C2"), headerFont, Brushes.Black, true); // Reste value bold
            }
            yPos += lineHeight; // Space after all totals

            // --- 5. Payment Method & Notes ---
            if (!string.IsNullOrWhiteSpace(data.PaymentMethod))
            {
                g.DrawString($"Méthode de paiement: {data.PaymentMethod}", bodyFont, Brushes.Black, leftMargin, yPos); yPos += lineHeight;
            }
            if (!string.IsNullOrWhiteSpace(data.Notes))
            {
                g.DrawString("Notes:", headerFont, Brushes.Black, leftMargin, yPos); yPos += lineHeight;
                g.DrawString(data.Notes, bodyFont, Brushes.Black, new RectangleF(leftMargin, yPos, printableWidth, lineHeight * 3), sfLeft); yPos += lineHeight * 3;
            }
            if (!string.IsNullOrWhiteSpace(data.BankDetails))
            {
                g.DrawString(data.BankDetails, smallBodyFont, Brushes.Black, new RectangleF(leftMargin, printableHeight - e.MarginBounds.Bottom + smallBodyFont.GetHeight(g) * 2, printableWidth, smallBodyFont.GetHeight(g) * 2), sfCenter);
            }


            // --- Cleanup ---
            titleFont.Dispose(); headerFont.Dispose(); bodyFont.Dispose(); smallBodyFont.Dispose(); blackPen.Dispose();
            // itemTableVerticalSeparatorPen.Dispose(); horizontalSeparatorPen.Dispose(); summaryTableCellPen.Dispose(); // If these were used

            e.HasMorePages = false; // For now, assuming single page. Multi-page is more complex.
        }

        private void btnPrintA4_Click(object sender, EventArgs e)
        {
            if (dataGridViewFactures.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewFactures.SelectedRows[0];
                if (selectedRow.Cells["InvoiceID"].Value != null &&
                    int.TryParse(selectedRow.Cells["InvoiceID"].Value.ToString(), out int purchaseInvoicePK))
                {
                    _currentA4InvoiceData = FetchA4InvoiceData(purchaseInvoicePK);
                    if (_currentA4InvoiceData != null)
                    {
                        InitiateA4InvoicePrint();
                    }
                    else
                    {
                        MessageBox.Show("Impossible de charger les données de la facture pour l'impression.", "Erreur de Données", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("L'ID de la facture sélectionnée est invalide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une facture à imprimer.", "Sélection Requise", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btndeleteFacture_Click(object sender, EventArgs e)
        {
            if (dataGridViewFactures.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner une facture à supprimer.", "Aucune Sélection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DataGridViewRow selectedRow = dataGridViewFactures.SelectedRows[0];
            if (selectedRow.Cells["InvoiceID"].Value == null ||
                !int.TryParse(selectedRow.Cells["InvoiceID"].Value.ToString(), out int invoiceIdToDelete))
            {
                MessageBox.Show("L'ID de la facture sélectionnée est invalide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string invoiceNumberForMessage = selectedRow.Cells["InvoiceNumber"].Value?.ToString() ?? $"ID: {invoiceIdToDelete}";

            DialogResult confirmation = MessageBox.Show(
                $"Êtes-vous sûr de vouloir supprimer la facture N° {invoiceNumberForMessage} et toutes ses lignes d'articles ?\n\n" +
                "Cette action ajustera également les stocks des articles concernés et ne peut pas être annulée.",
                "Confirmer la Suppression",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirmation == DialogResult.No)
            {
                return;
            }

            // Proceed with deletion
            using (SqlConnection conn = new SqlConnection(connectionString)) // Use your existing connectionString
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    // Step 1: Get all items from the invoice to revert stock
                    List<Tuple<int, int>> itemsToRevertStock = new List<Tuple<int, int>>(); // ArticleID, Quantity
                    string fetchItemsQuery = "SELECT ArticleID, Quantity FROM PurchaseInvoiceItems WHERE InvoiceID = @InvoiceID_Param";
                    using (SqlCommand fetchCmd = new SqlCommand(fetchItemsQuery, conn, transaction))
                    {
                        fetchCmd.Parameters.AddWithValue("@InvoiceID_Param", invoiceIdToDelete);
                        using (SqlDataReader reader = fetchCmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Ensure data is valid before adding to list
                                if (!reader.IsDBNull(0) && !reader.IsDBNull(1))
                                {
                                    itemsToRevertStock.Add(new Tuple<int, int>(reader.GetInt32(0), reader.GetInt32(1)));
                                }
                            }
                        } // Reader is closed here
                    }

                    foreach (var itemTuple in itemsToRevertStock)
                    {
                        int articleIdToUpdate = itemTuple.Item1;
                        int quantityToSubtract = itemTuple.Item2;

                        if (articleIdToUpdate <= 0) // Basic validation
                        {
                            // Log or handle this scenario - an invalid ArticleID was in PurchaseInvoiceItems
                            System.Diagnostics.Debug.WriteLine($"Skipping stock revert for invalid ArticleID: {articleIdToUpdate}");
                            continue;
                        }
                        if (quantityToSubtract <= 0) // No stock to revert or invalid quantity
                        {
                            System.Diagnostics.Debug.WriteLine($"Skipping stock revert for ArticleID: {articleIdToUpdate} due to non-positive quantity: {quantityToSubtract}");
                            continue;
                        }


                        string revertStockQuery = "UPDATE Articles SET QuantityStock = ISNULL(QuantityStock, 0) - @Quantity WHERE Id = @ArticleID";
                        // Ensure 'Id' is the PK of your Articles table
                        using (SqlCommand revertCmd = new SqlCommand(revertStockQuery, conn, transaction))
                        {
                            revertCmd.Parameters.AddWithValue("@Quantity", quantityToSubtract);
                            revertCmd.Parameters.AddWithValue("@ArticleID", articleIdToUpdate);

                            int rowsAffectedByStockRevert = revertCmd.ExecuteNonQuery();
                            if (rowsAffectedByStockRevert == 0)
                            {
                                // This is problematic. The article existed in the purchase but wasn't found for stock update.
                                // This could indicate data inconsistency or that the article was deleted from the Articles table.
                                // Depending on business rules, you might log this, warn the user, or even rollback.
                                // For now, we'll log it and continue with other items, but the transaction might still be committed.
                                // For stricter control, you might want to throw an exception here to force a rollback.
                                System.Diagnostics.Debug.WriteLine($"Avertissement: La mise à jour du stock (soustraction) n'a affecté aucune ligne pour ArticleID {articleIdToUpdate}. Le stock n'a peut-être pas été correctement ajusté.");
                                // Consider:
                                // transaction.Rollback();
                                // MessageBox.Show($"Erreur critique: Le stock pour l'article ID {articleIdToUpdate} n'a pas pu être ajusté. L'opération a été annulée.", "Erreur Ajustement Stock", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                // return;
                            }
                        }
                    }

                    // Step 3: Delete items from PurchaseInvoiceItems
                    string deleteItemsQuery = "DELETE FROM PurchaseInvoiceItems WHERE InvoiceID = @InvoiceID_Param";
                    using (SqlCommand deleteItemsCmd = new SqlCommand(deleteItemsQuery, conn, transaction))
                    {
                        deleteItemsCmd.Parameters.AddWithValue("@InvoiceID_Param", invoiceIdToDelete);
                        deleteItemsCmd.ExecuteNonQuery();
                    }

                    // Step 4: Delete the main invoice from PurchaseInvoices
                    // Ensure 'InvoiceID' is the PK of your PurchaseInvoices table
                    string deleteInvoiceQuery = "DELETE FROM PurchaseInvoices WHERE InvoiceID = @InvoiceID_Param";
                    using (SqlCommand deleteInvoiceCmd = new SqlCommand(deleteInvoiceQuery, conn, transaction))
                    {
                        deleteInvoiceCmd.Parameters.AddWithValue("@InvoiceID_Param", invoiceIdToDelete);
                        int rowsAffected = deleteInvoiceCmd.ExecuteNonQuery();

                        if (rowsAffected == 0)
                        {
                            // This might indicate the invoice was already deleted or ID was wrong,
                            // but items and stock adjustments might have already happened.
                            // The transaction will handle rollback if this is an issue.
                            throw new Exception("La facture principale n'a pas été trouvée ou n'a pas pu être supprimée.");
                        }
                    }

                    transaction.Commit();
                    MessageBox.Show($"La facture N° {invoiceNumberForMessage} a été supprimée avec succès.", "Suppression Réussie", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadPurchases(); // Refresh the DataGridView
                }
                catch (SqlException sqlEx)
                {
                    try { if (transaction?.Connection != null) transaction.Rollback(); }
                    catch (Exception exRollback) { MessageBox.Show($"Erreur lors de l'annulation: {exRollback.Message}", "Erreur Rollback", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    MessageBox.Show($"Erreur SQL lors de la suppression: {sqlEx.Message}\nNuméro d'erreur: {sqlEx.Number}", "Erreur Base de Données", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    try { if (transaction?.Connection != null) transaction.Rollback(); }
                    catch (Exception exRollback) { MessageBox.Show($"Erreur lors de l'annulation: {exRollback.Message}", "Erreur Rollback", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    MessageBox.Show($"Une erreur s'est produite: {ex.Message}", "Erreur Inattendue", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } // using SqlConnection ensures connection is closed
        }
    }
}
