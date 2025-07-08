using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace TAPTAGPOS
{
    public partial class GlobalSupplierSituationForm : Form
    {
        private readonly string connectionString = DatabaseConnection.GetConnectionString();
        private DataTable situationData; // Use a DataTable to hold the data for easy access


        // --- Members for Printing ---
        private List<DataGridViewRow> rowsToPrint;
        private int currentRowIndexToPrint = 0;

        public GlobalSupplierSituationForm()
        {
            InitializeComponent();
            SetupForm();
        }

        private void SetupForm()
        {
            // Set up the form and connect event handlers
            this.Load += GlobalSupplierSituationForm_Load;
            this.buttonValidate.Click += ButtonValidate_Click;
            this.buttonPayment.Click += ButtonPayment_Click;
            this.buttonPrint.Click += ButtonPrint_Click;
            this.dataGridViewSituation.CellDoubleClick += DataGridViewSituation_CellDoubleClick;
        }

        private void GlobalSupplierSituationForm_Load(object sender, EventArgs e)
        {
            dataGridViewSituation.AutoGenerateColumns = false;
            // Set default date range to the current month
            dateTimePickerStartDate.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dateTimePickerEndDate.Value = dateTimePickerStartDate.Value.AddMonths(1).AddDays(-1);

            // Initially load the data
            ButtonValidate_Click(sender, e);
        }

        private void ButtonValidate_Click(object sender, EventArgs e)
        {
            LoadGlobalSituation();
        }

        private void LoadGlobalSituation()
        {
            DateTime startDate = dateTimePickerStartDate.Value.Date;
            DateTime endDate = dateTimePickerEndDate.Value.Date.AddDays(1).AddSeconds(-1); // Include the whole end day

            // This powerful SQL query calculates everything we need in one go
            string query = @"
                WITH SupplierBalances AS (
                    SELECT
                        s.SupplierID,
                        s.Name,
                        -- Calculate the balance *before* the start date
                        ISNULL((SELECT SUM(pi.GrandTotal) FROM PurchaseInvoices pi WHERE pi.SupplierID = s.SupplierID AND pi.PurchaseDate < @StartDate), 0) -
                        ISNULL((SELECT SUM(sp.Amount) FROM SupplierPayments sp WHERE sp.SupplierID = s.SupplierID AND sp.PaymentDate < @StartDate), 0) AS OldBalance,

                        -- Calculate total purchases *within* the date range
                        ISNULL((SELECT SUM(pi.GrandTotal) FROM PurchaseInvoices pi WHERE pi.SupplierID = s.SupplierID AND pi.PurchaseDate BETWEEN @StartDate AND @EndDate), 0) AS TotalPurchases,

                        -- Calculate total payments *within* the date range
                        ISNULL((SELECT SUM(sp.Amount) FROM SupplierPayments sp WHERE sp.SupplierID = s.SupplierID AND sp.PaymentDate BETWEEN @StartDate AND @EndDate), 0) AS TotalPayments
                    FROM
                        Suppliers s
                    WHERE
                        s.Status = 'Active'
                )
                SELECT 
                    SupplierID,
                    Name,
                    OldBalance,
                    TotalPurchases,
                    TotalPayments,
                    (OldBalance + TotalPurchases - TotalPayments) AS FinalBalance
                FROM SupplierBalances
                WHERE OldBalance != 0 OR TotalPurchases != 0 OR TotalPayments != 0
                ORDER BY Name;
            ";

            try
            {
                using (var conn = new SqlConnection(connectionString))
                {
                    using (var adapter = new SqlDataAdapter(query, conn))
                    {
                        adapter.SelectCommand.Parameters.AddWithValue("@StartDate", startDate);
                        adapter.SelectCommand.Parameters.AddWithValue("@EndDate", endDate);

                        situationData = new DataTable();
                        adapter.Fill(situationData);

                        // Bind the results to the grid
                        dataGridViewSituation.DataSource = situationData;

                        // Configure the visible columns
                        SetupDataGridViewColumns();
                        CalculateFooterTotals();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load global supplier situation: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetupDataGridViewColumns()
        {
            dataGridViewSituation.AutoGenerateColumns = false;
            // Add a hidden column for the SupplierID if it doesn't exist
            if (!dataGridViewSituation.Columns.Contains("SupplierID"))
            {
                dataGridViewSituation.Columns.Add("SupplierID", "SupplierID");
            }
            dataGridViewSituation.Columns["SupplierID"].Visible = false;

            // Map the data to the correct columns
            dataGridViewSituation.Columns["SupplierID"].DataPropertyName = "SupplierID";
            dataGridViewSituation.Columns["colSupplier"].DataPropertyName = "Name";
            dataGridViewSituation.Columns["colOldBalance"].DataPropertyName = "OldBalance";
            dataGridViewSituation.Columns["colTotal"].DataPropertyName = "TotalPurchases";
            dataGridViewSituation.Columns["colPayment"].DataPropertyName = "TotalPayments";
            dataGridViewSituation.Columns["colBalance"].DataPropertyName = "FinalBalance";

            // Format currency columns
            string currencyFormat = "N2";
            dataGridViewSituation.Columns["colOldBalance"].DefaultCellStyle.Format = currencyFormat;
            dataGridViewSituation.Columns["colTotal"].DefaultCellStyle.Format = currencyFormat;
            dataGridViewSituation.Columns["colPayment"].DefaultCellStyle.Format = currencyFormat;
            dataGridViewSituation.Columns["colBalance"].DefaultCellStyle.Format = currencyFormat;

            // Make the final balance column bold
            dataGridViewSituation.Columns["colBalance"].DefaultCellStyle.Font = new Font(this.Font, FontStyle.Bold);
        }

        private void CalculateFooterTotals()
        {
            decimal totalOldBalance = 0m, totalPurchases = 0m, totalPayments = 0m, totalFinalBalance = 0m;

            foreach (DataRow row in situationData.Rows)
            {
                totalOldBalance += Convert.ToDecimal(row["OldBalance"]);
                totalPurchases += Convert.ToDecimal(row["TotalPurchases"]);
                totalPayments += Convert.ToDecimal(row["TotalPayments"]);
                totalFinalBalance += Convert.ToDecimal(row["FinalBalance"]);
            }

            textBoxTotalOldBalance.Text = totalOldBalance.ToString("N2");
            textBoxTotalTotal.Text = totalPurchases.ToString("N2"); // Purchase Total
            textBoxTotalPayment.Text = totalPayments.ToString("N2");
            textBoxTotalBalance.Text = totalFinalBalance.ToString("N2");
            textBoxTotalCredit.Text = ""; // Not used in this context
        }

        // --- EVENT HANDLERS FOR ACTIONS ---

        private void DataGridViewSituation_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // On double-click, open the detailed view for the selected supplier
            if (e.RowIndex >= 0)
            {
                int supplierId = Convert.ToInt32(dataGridViewSituation.Rows[e.RowIndex].Cells["SupplierID"].Value);
                using (var detailForm = new SupplierSituationForm(supplierId))
                {
                    detailForm.ShowDialog(this);
                }
            }
        }

        private void ButtonPayment_Click(object sender, EventArgs e)
        {
            if (selectedSupID > 0)
            {


                // This call will now work correctly
                using (var paymentForm = new frmAddSupplierPayment(selectedSupID))
                {
                    if (paymentForm.ShowDialog(this) == DialogResult.OK)
                    {
                        // Refresh the data after a payment is made
                        LoadGlobalSituation();
                    }
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un fournisseur pour effectuer un règlement.", "Aucune sélection", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #region Printing Logic
        private void ButtonPrint_Click(object sender, EventArgs e)
        {
            if (dataGridViewSituation.Rows.Count == 0)
            {
                MessageBox.Show("Il n'y a rien à imprimer.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            rowsToPrint = new List<DataGridViewRow>();
            foreach (DataGridViewRow row in dataGridViewSituation.Rows)
            {
                rowsToPrint.Add(row);
            }
            currentRowIndexToPrint = 0;


            PrintDocument pd = new PrintDocument();

            // --- START OF FIX ---
            // 1. Use the correct printer from your settings
            string printerName = AppSettingsManager.PrinterA4A5;
            if (!string.IsNullOrEmpty(printerName))
            {
                pd.PrinterSettings.PrinterName = printerName;
            }
            else
            {
                // If no printer is set, the default printer will be used. 
                // The user can still choose another one in the print dialog.
            }

            // 2. Set page orientation to Landscape
            pd.DefaultPageSettings.Landscape = true;

            // NOTE: We do NOT set a specific paper size like A4 or A5 here.
            // By leaving it to the printer's default, the code becomes responsive.
            // The user can choose A4 or A5 in the print dialog, and the drawing code will adapt.
            // --- END OF FIX ---

            pd.DocumentName = "Situation Globale Fournisseurs";
            pd.PrintPage += new PrintPageEventHandler(PrintPage_Handler);

            PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog
            {
                Document = pd,
                WindowState = FormWindowState.Maximized
            };
            printPreviewDialog.ShowDialog(this);
        }

        private void PrintPage_Handler(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            float yPos = e.MarginBounds.Top-20;
            float leftMargin = e.MarginBounds.Left;
            float pageWidth = e.MarginBounds.Width;
            float rowHeight = 30;

            using (Font titleFont = new Font("Arial", 16, FontStyle.Bold))
            using (Font headerFont = new Font("Arial", 9, FontStyle.Bold))
            using (Font bodyFont = new Font("Arial", 9))
            using (StringFormat centerFormat = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center })
            {
                // ---- 1. Report Header ----
                string reportTitle = "Situation Globale Fournisseurs";
                string dateRange = $"Période du {dateTimePickerStartDate.Value:dd/MM/yyyy} au {dateTimePickerEndDate.Value:dd/MM/yyyy}";
                g.DrawString(reportTitle, titleFont, Brushes.Black, new RectangleF(leftMargin, yPos, pageWidth, 40), centerFormat);
                yPos += 40;
                g.DrawString(dateRange, bodyFont, Brushes.Black, new RectangleF(leftMargin, yPos, pageWidth, 20), centerFormat);
                yPos += 40;

                // ---- 2. Table Header ----
                float headerY = yPos;
                float[] colWidths = { 0.30f, 0.14f, 0.14f, 0.14f, 0.14f, 0.14f }; // Adjusted widths
                string[] headers = { "Fournisseur", "Ancien Solde", "Total Achats", "Règlements", "Avoirs", "Solde Final" };

                g.FillRectangle(Brushes.LightGray, leftMargin, headerY, pageWidth, rowHeight);
                float currentX = leftMargin;
                for (int i = 0; i < headers.Length; i++)
                {
                    float colW = pageWidth * colWidths[i];
                    g.DrawRectangle(Pens.Black, currentX, headerY, colW, rowHeight);
                    g.DrawString(headers[i], headerFont, Brushes.Black, new RectangleF(currentX, headerY, colW, rowHeight), centerFormat);
                    currentX += colW;
                }
                yPos += rowHeight;

                // ---- 3. Table Rows ----
                // Reserve space for the footer at the bottom of the page
                float footerHeight = 60;

                while (currentRowIndexToPrint < dataGridViewSituation.Rows.Count)
                {
                    // Check if the next row will fit on the current page
                    if (yPos + rowHeight > e.MarginBounds.Bottom - footerHeight)
                    {
                        e.HasMorePages = true; // Signal that there is another page
                        return; // Exit the handler for this page
                    }

                    DataGridViewRow row = dataGridViewSituation.Rows[currentRowIndexToPrint];
                    currentX = leftMargin;
                    for (int i = 0; i < headers.Length; i++)
                    {
                        float colW = pageWidth * colWidths[i];
                        string cellValue = row.Cells[i].FormattedValue.ToString();
                        g.DrawRectangle(Pens.Black, currentX, yPos, colW, rowHeight);
                        g.DrawString(cellValue, bodyFont, Brushes.Black, new RectangleF(currentX + 5, yPos, colW - 10, rowHeight), new StringFormat { LineAlignment = StringAlignment.Center });
                        currentX += colW;
                    }
                    yPos += rowHeight;
                    currentRowIndexToPrint++; // CRITICAL: Increment the index
                }

                // ---- 4. Table Footer (Grand Totals) - Drawn only on the last page ----
                yPos += 10;
                currentX = leftMargin;
                TextBox[] footerBoxes = { null, textBoxTotalOldBalance, textBoxTotalTotal, textBoxTotalPayment, textBoxTotalCredit, textBoxTotalBalance };
                g.DrawString("TOTAL GÉNÉRAL:", headerFont, Brushes.Black, new RectangleF(currentX, yPos, pageWidth * colWidths[0], rowHeight), new StringFormat { Alignment = StringAlignment.Far, LineAlignment = StringAlignment.Center });

                for (int i = 1; i < headers.Length; i++)
                {
                    currentX += pageWidth * colWidths[i - 1];
                    float colW = pageWidth * colWidths[i];
                    g.DrawString(footerBoxes[i].Text, headerFont, Brushes.Black, new RectangleF(currentX + 5, yPos, colW - 10, rowHeight), new StringFormat { LineAlignment = StringAlignment.Center });
                }

                // All rows have been printed, so there are no more pages.
                e.HasMorePages = false;
            }
        }        
        #endregion

        int selectedSupID = 0; 
        private void dataGridViewSituation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if a valid row is clicked (and not the header row which has an index of -1)
            if (e.RowIndex >= 0)
            {
                // Get the selected row
                DataGridViewRow row = this.dataGridViewSituation.Rows[e.RowIndex];

                // Get the value of the "SupplierID" column from the selected row
                object supplierIdValue = row.Cells["SupplierID"].Value;

                // You can now use the supplierIdValue. 
                // It's a good practice to check if it's not null and convert it to the desired type.
                if (supplierIdValue != null)
                {
                    // Example: Convert to an integer
                    // int supplierId = Convert.ToInt32(supplierIdValue);

                    // Example: Convert to a string
                    selectedSupID = Convert.ToInt32(supplierIdValue);

      
                }
            }
        }
    }
} 