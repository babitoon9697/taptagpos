using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;

namespace TAPTAGPOS
{
    public partial class frmCustomerStatus : Form
    {
        private string connectionString = DatabaseConnection.GetConnectionString();
        private DataTable reportData;
        private int printRowIndex = 0;
        private ContextMenuStrip dateRangeMenu; // Make sure this is declared


        public frmCustomerStatus()
        {
            InitializeComponent();
            InitializeEventHandlers();
            InitializeDateRangeMenu(); // Call the menu setup
        }
        // In frmCustomerStatus.cs

        // 1. Add this method to handle the button click
        private void btnTimePeriod_Click(object sender, EventArgs e)
        {
            // This shows the date range context menu below the button
            dateRangeMenu.Show(btnTimePeriod, new Point(0, btnTimePeriod.Height));
        }

        // 2. Add this method to handle the menu item clicks
        private void PeriodeMenuItem_Click(object sender, EventArgs e)
        {
            var today = DateTime.Today;
            var menuItem = sender as ToolStripMenuItem;

            switch (menuItem.Name)
            {
                case "aujourdhuiToolStripMenuItem":
                    SetDateRange(today, today);
                    break;
                case "hierToolStripMenuItem":
                    SetDateRange(today.AddDays(-1), today.AddDays(-1));
                    break;
                case "semaineEnCoursToolStripMenuItem":
                    int diff = (7 + (today.DayOfWeek - DayOfWeek.Monday)) % 7;
                    SetDateRange(today.AddDays(-1 * diff), today);
                    break;
                case "moisEnCoursToolStripMenuItem":
                    SetDateRange(new DateTime(today.Year, today.Month, 1), today);
                    break;
                    // You can add logic for the other time periods here if you wish
            }
        }

        // 3. Add this helper method to apply the new dates
        private void SetDateRange(DateTime start, DateTime end)
        {
            dtpFrom.Value = start;
            dtpTo.Value = end;
            // Automatically refresh the report when a period is chosen
            LoadReportData();
        }
        private void InitializeDateRangeMenu()
        {
            dateRangeMenu = new ContextMenuStrip();
            var items = new ToolStripMenuItem[]
            {
                new ToolStripMenuItem("اليوم") { Name = "aujourdhuiToolStripMenuItem" },
                new ToolStripMenuItem("أمس") { Name = "hierToolStripMenuItem" },
                new ToolStripMenuItem("هذا الأسبوع") { Name = "semaineEnCoursToolStripMenuItem" },
                new ToolStripMenuItem("هذا الشهر") { Name = "moisEnCoursToolStripMenuItem" }
            };

            foreach (var item in items)
            {
                item.Click += PeriodeMenuItem_Click;
            }
            dateRangeMenu.Items.AddRange(items);
        }

        private void InitializeEventHandlers()
        {
            this.Load += new System.EventHandler(this.frmCustomerStatus_Load);
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            this.btnClose.Click += (s, e) => this.Close();
            this.dgvCustomerStatus.CellDoubleClick += dgvCustomerStatus_CellDoubleClick;
            // --- ADD THIS LINE TO FIX THE BUTTON ---
            this.btnTimePeriod.Click += new System.EventHandler(this.btnTimePeriod_Click);

        }

        private void frmCustomerStatus_Load(object sender, EventArgs e)
        {
            dtpFrom.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtpTo.Value = DateTime.Now;
            StyleDataGridView();
            LoadReportData();
        }

        #region Data Loading

        private void StyleDataGridView()
        {
            dgvCustomerStatus.AutoGenerateColumns = false;
            colCode.DataPropertyName = "CustomerID";
            colCustomer.DataPropertyName = "CustomerName";
            colSales.DataPropertyName = "TotalSales";
            colPaid.DataPropertyName = "TotalPaid";
            colDebt.DataPropertyName = "Debt";
        }

        private void LoadReportData()
        {
            string query = @"
                WITH Sales AS (
                    SELECT CustomerID, SUM(TotalAmount) AS SalesAmount
                    FROM Transactions
                    WHERE TransactionDate BETWEEN @StartDate AND @EndDate
                    GROUP BY CustomerID
                ),
                Payments AS (
                    SELECT CustomerID, SUM(Amount) AS PaidAmount
                    FROM CustomerPayments
                    WHERE PaymentDate BETWEEN @StartDate AND @EndDate
                    GROUP BY CustomerID
                )
                SELECT 
                    c.CustomerID,
                    c.CustomerName,
                    ISNULL(s.SalesAmount, 0) AS TotalSales,
                    ISNULL(p.PaidAmount, 0) AS TotalPaid,
                    (ISNULL(s.SalesAmount, 0) - ISNULL(p.PaidAmount, 0)) AS Debt
                FROM Customers c
                LEFT JOIN Sales s ON c.CustomerID = s.CustomerID
                LEFT JOIN Payments p ON c.CustomerID = p.CustomerID
                WHERE c.CustomerID > 1 AND (ISNULL(s.SalesAmount, 0) <> 0 OR ISNULL(p.PaidAmount, 0) <> 0)
                ORDER BY c.CustomerName;";

            try
            {
                reportData = new DataTable();
                using (var conn = new SqlConnection(connectionString))
                using (var adapter = new SqlDataAdapter(query, conn))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@StartDate", dtpFrom.Value.Date);
                    adapter.SelectCommand.Parameters.AddWithValue("@EndDate", dtpTo.Value.Date.AddDays(1).AddSeconds(-1));
                    adapter.Fill(reportData);
                }

                dgvCustomerStatus.DataSource = reportData;
                CalculateTotals();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading customer status: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CalculateTotals()
        {
            if (reportData == null) return;
            // Use the DataTable's Compute method for fast and easy totals
            txtTotalSales.Text = Convert.ToDecimal(reportData.Compute("SUM(TotalSales)", string.Empty)).ToString("C2");
            txtTotalPaid.Text = Convert.ToDecimal(reportData.Compute("SUM(TotalPaid)", string.Empty)).ToString("C2");
            txtTotalDebt.Text = Convert.ToDecimal(reportData.Compute("SUM(Debt)", string.Empty)).ToString("C2");
        }

        #endregion

        #region Event Handlers
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            LoadReportData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvCustomerStatus_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int customerId = Convert.ToInt32(dgvCustomerStatus.Rows[e.RowIndex].Cells["colCode"].Value);
                // Open the detailed situation form for the selected customer
                using (var detailForm = new ClientSituationForm(customerId))
                {
                    detailForm.ShowDialog(this);
                }
            }
        }
        #endregion

        #region Printing Logic
        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (dgvCustomerStatus.Rows.Count == 0) return;

            printRowIndex = 0; // Reset for new print job

            PrintDocument pd = new PrintDocument();
            pd.DocumentName = "Rapport sur la Situation des Clients";
            pd.DefaultPageSettings.Landscape = true; // --- SET TO A4 LANDSCAPE ---

            string printerName = AppSettingsManager.PrinterA4A5;
            if (!string.IsNullOrEmpty(printerName))
            {
                pd.PrinterSettings.PrinterName = printerName;
            }

            pd.PrintPage += printDocument1_PrintPage;

            printPreviewDialog1.Document = pd;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            float yPos = e.MarginBounds.Top;
            float leftMargin = e.MarginBounds.Left;
            float pageWidth = e.MarginBounds.Width;
            float rowHeight = 30;

            using (Font titleFont = new Font("Arial", 16, FontStyle.Bold))
            using (Font headerFont = new Font("Arial", 10, FontStyle.Bold))
            using (Font bodyFont = new Font("Arial", 9))
            {
                // --- 1. Report Header ---
                g.DrawString("Rapport sur la Situation des Clients", titleFont, Brushes.Black, leftMargin, yPos);
                yPos += 30;
                g.DrawString($"Période: {dtpFrom.Value:dd/MM/yyyy} - {dtpTo.Value:dd/MM/yyyy}", bodyFont, Brushes.Gray, leftMargin, yPos);
                yPos += 40;

                // --- 2. Table Header ---
                // Responsive widths based on percentages
                float[] colWidths = { 0.10f, 0.40f, 0.16f, 0.16f, 0.18f };
                string[] headers = { "Code", "Client", "Total Ventes", "Total Payé", "Solde (Dette)" };
                float currentX = leftMargin;
                g.FillRectangle(Brushes.LightGray, leftMargin, yPos, pageWidth, rowHeight);
                for (int i = 0; i < headers.Length; i++)
                {
                    g.DrawString(headers[i], headerFont, Brushes.Black, currentX + 5, yPos + 5);
                    currentX += pageWidth * colWidths[i];
                }
                yPos += rowHeight;

                // --- 3. Table Rows with Pagination ---
                while (printRowIndex < dgvCustomerStatus.Rows.Count)
                {
                    if (yPos + rowHeight > e.MarginBounds.Bottom)
                    {
                        e.HasMorePages = true;
                        return;
                    }
                    DataGridViewRow row = dgvCustomerStatus.Rows[printRowIndex];
                    currentX = leftMargin;
                    for (int i = 0; i < headers.Length; i++)
                    {
                        string cellValue = row.Cells[i].FormattedValue.ToString();
                        g.DrawString(cellValue, bodyFont, Brushes.Black, currentX + 5, yPos + 5);
                        currentX += pageWidth * colWidths[i];
                    }
                    yPos += rowHeight;
                    printRowIndex++;
                }

                // --- 4. Grand Totals (on the last page) ---
                yPos += 20;
                g.DrawLine(Pens.Black, leftMargin, yPos, leftMargin + pageWidth, yPos);
                yPos += 10;

                float totalsX = leftMargin + (pageWidth * (colWidths[0] + colWidths[1])); // Align with 'Total Sales' column
                g.DrawString("TOTAL GÉNÉRAL:", headerFont, Brushes.Black, totalsX - 120, yPos);
                g.DrawString(txtTotalSales.Text, headerFont, Brushes.Black, totalsX + (pageWidth * colWidths[2] * 0.5f) - g.MeasureString(txtTotalSales.Text, headerFont).Width / 2, yPos);
                g.DrawString(txtTotalPaid.Text, headerFont, Brushes.Black, totalsX + (pageWidth * colWidths[2]) + (pageWidth * colWidths[3] * 0.5f) - g.MeasureString(txtTotalPaid.Text, headerFont).Width / 2, yPos);
                g.DrawString(txtTotalDebt.Text, headerFont, Brushes.Red, totalsX + (pageWidth * (colWidths[2] + colWidths[3])) + (pageWidth * colWidths[4] * 0.5f) - g.MeasureString(txtTotalDebt.Text, headerFont).Width / 2, yPos);

                e.HasMorePages = false;
            }
        }
        #endregion
        public class CustomerStatusPrintItem

        {

            public string Code { get; set; }

            public string CustomerName { get; set; }

            public decimal TotalSales { get; set; }

            public decimal TotalPaid { get; set; }

            public decimal Debt { get; set; }

        }



        public class CustomerStatusReportData

        {

            public string ReportTitle { get; set; } = "تقرير حالة الزبناء";

            public string CompanyName { get; set; } = "اسم شركتك هنا";

            public string DateRange { get; set; }

            public DateTime PrintDate { get; set; }

            public List<CustomerStatusPrintItem> Items { get; set; } = new List<CustomerStatusPrintItem>();



            // الإجماليات

            public decimal GrandTotalSales { get; set; }

            public decimal GrandTotalPaid { get; set; }

            public decimal GrandTotalDebt { get; set; }

        }
    }
}