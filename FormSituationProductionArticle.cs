using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Text;
using System.Windows.Forms;

namespace TAPTAGPOS
{
    public partial class FormSituationProductionArticle : Form
    {
        private string connectionString = DatabaseConnection.GetConnectionString();

        private ProductionSituationReportData _currentReportData;
        private int printRowIndex = 0;
        private int pageNumber = 1;

        private void FormSituationProductionArticle_Load(object sender, EventArgs e)
        {
            dtpDateDebut.Value = DateTime.Now.AddMonths(-1);
            dtpDateFin.Value = DateTime.Now;
            LoadArticles();
        }
        // Add this variable at the top of your class
        private ContextMenuStrip periodMenu;

        // Add this new method to initialize the menu
        private void InitializePeriodMenu()
        {
            periodMenu = new ContextMenuStrip();
            var todayItem = new ToolStripMenuItem("Aujourd'hui");
            var thisMonthItem = new ToolStripMenuItem("Ce mois-ci");
            var thisYearItem = new ToolStripMenuItem("Cette année");

            todayItem.Click += (s, e) => SetDateRange(DateTime.Today, DateTime.Today);
            thisMonthItem.Click += (s, e) => SetDateRange(new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1), DateTime.Today);
            thisYearItem.Click += (s, e) => SetDateRange(new DateTime(DateTime.Today.Year, 1, 1), DateTime.Today);

            periodMenu.Items.AddRange(new ToolStripItem[] { todayItem, thisMonthItem, thisYearItem });
        }

        // Add this helper method to set the dates and reload the data
        private void SetDateRange(DateTime start, DateTime end)
        {
            dtpDateDebut.Value = start;
            dtpDateFin.Value = end;
            LoadData(); // Automatically filter when a period is selected
        }

        // Now, replace your empty button methods with these
        private void btnPeriode_Click(object sender, EventArgs e)
        {
            // Show the menu just below the button
            periodMenu.Show(btnPeriode, new Point(0, btnPeriode.Height));
        }

        private void btnFiltrer_Click(object sender, EventArgs e)
        {
            // Simply call LoadData, which will use the values from the controls
            LoadData();
        }

        // Finally, update your form's constructor to call the initialization method
        public FormSituationProductionArticle()
        {
            InitializeComponent();
            this.Load += FormSituationProductionArticle_Load;
            this.btnFiltrer.Click += btnFiltrer_Click;
            this.btnPeriode.Click += btnPeriode_Click; // Link the new button
            this.btnImprimer.Click += btnImprimer_Click; // Link the print button
            InitializePeriodMenu(); // Call the new menu setup method
        }
        private void LoadArticles()
        {
            try
            {
                var dt = new DataTable();
                dt.Columns.Add("Id", typeof(int));
                dt.Columns.Add("ArticleLongName", typeof(string));
                dt.Rows.Add(0, "Tous les Articles"); // "All Articles" option

                // Only load articles that can be produced (i.e., they have a FicheTechnique)
                string query = @"
                    SELECT DISTINCT a.Id, a.ArticleLongName 
                    FROM Articles a
                    JOIN FichesTechniques ft ON a.Id = ft.ArticleID
                    ORDER BY a.ArticleLongName";

                using (var conn = new SqlConnection(connectionString))
                using (var adapter = new SqlDataAdapter(query, conn))
                {
                    adapter.Fill(dt);
                }
                cmbArticle.DataSource = dt;
                cmbArticle.DisplayMember = "ArticleLongName";
                cmbArticle.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading articles: " + ex.Message);
            }
        }

        private void LoadData()
        {
            dgvSituation.Rows.Clear();
            decimal totalPrevue = 0, totalProduite = 0, totalEcart = 0;

            var queryBuilder = new StringBuilder(@"
                SELECT 
                    ofab.StartDate,
                    ofab.OrderNumber,
                    ofab.LotNumber,
                    ofp.QuantityExpected,
                    ofp.QuantityProduced
                FROM OF_ProduitsFinis ofp
                JOIN OrdresFabrication ofab ON ofp.OrderID = ofab.OrderID
                WHERE ofab.IsActive = 1 ");

            var parameters = new Dictionary<string, object>();

            // --- Dynamic Filtering Logic ---
            queryBuilder.Append(" AND ofab.StartDate BETWEEN @StartDate AND @EndDate");
            parameters.Add("@StartDate", dtpDateDebut.Value.Date);
            parameters.Add("@EndDate", dtpDateFin.Value.Date.AddDays(1).AddSeconds(-1));

            if (cmbArticle.SelectedValue != null && (int)cmbArticle.SelectedValue > 0)
            {
                queryBuilder.Append(" AND ofp.ArticleID = @ArticleID");
                parameters.Add("@ArticleID", (int)cmbArticle.SelectedValue);
            }

            queryBuilder.Append(" ORDER BY ofab.StartDate DESC");

            try
            {
                using (var conn = new SqlConnection(connectionString))
                using (var cmd = new SqlCommand(queryBuilder.ToString(), conn))
                {
                    foreach (var p in parameters)
                    {
                        cmd.Parameters.AddWithValue(p.Key, p.Value);
                    }
                    conn.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            decimal qtePrevue = Convert.ToDecimal(reader["QuantityExpected"]);
                            decimal qteProduite = Convert.ToDecimal(reader["QuantityProduced"]);
                            decimal ecart = qteProduite - qtePrevue;

                            dgvSituation.Rows.Add(
                                ((DateTime)reader["StartDate"]).ToShortDateString(),
                                reader["OrderNumber"],
                                reader["LotNumber"],
                                qtePrevue.ToString("N2"),
                                qteProduite.ToString("N2"),
                                ecart.ToString("N2")
                            );

                            totalPrevue += qtePrevue;
                            totalProduite += qteProduite;
                            totalEcart += ecart;
                        }
                    }
                }
                // Display the calculated totals in the footer label
                labelTotaux.Text = $"Totaux -- Qte prévue: {totalPrevue:N2} | Qte produite: {totalProduite:N2} | Ecart: {totalEcart:N2}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading production situation: " + ex.Message);
            }
        }



        // This is the code for the Print button
        private void btnImprimer_Click(object sender, EventArgs e)
        {
            if (dgvSituation.Rows.Count == 0)
            {
                MessageBox.Show("Il n'y a aucune donnée à imprimer.");
                return;
            }

            // 1. Prepare the data for the report
            _currentReportData = new ProductionSituationReportData
            {
                CompanyName = AppSettingsManager.CompanyName, // Loaded from settings
                FilterInfo = $"Période du: {dtpDateDebut.Value:dd/MM/yyyy} au {dtpDateFin.Value:dd/MM/yyyy} | Article: {cmbArticle.Text}"
            };

            decimal totalPrevue = 0, totalProduite = 0, totalEcart = 0;
            foreach (DataGridViewRow row in dgvSituation.Rows)
            {
                var item = new ProductionSituationItem
                {
                    Reference = row.Cells["colReference"].Value.ToString(),
                    Designation = row.Cells["colDesignation"].Value.ToString(),
                    QtePrevue = Convert.ToDecimal(row.Cells["colQtePrevue"].Value),
                    QteProduite = Convert.ToDecimal(row.Cells["colQteProduite"].Value),
                    Ecart = Convert.ToDecimal(row.Cells["colEcart"].Value)
                };
                _currentReportData.Items.Add(item);
                totalPrevue += item.QtePrevue;
                totalProduite += item.QteProduite;
                totalEcart += item.Ecart;
            }
            _currentReportData.TotalPrevue = totalPrevue;
            _currentReportData.TotalProduite = totalProduite;
            _currentReportData.TotalEcart = totalEcart;

            // 2. Start the printing process
            InitiateReportPrint();
        }
        private void InitiateReportPrint()
        {
            // Reset counters for new print job
            this.printRowIndex = 0;
            this.pageNumber = 1;

            using (PrintDocument pd = new PrintDocument())
            {
                pd.DocumentName = "Situation de Production";
                pd.PrinterSettings.PrinterName = AppSettingsManager.PrinterA4A5;
                pd.DefaultPageSettings.Landscape = true; // Report is wide, so landscape is better
                pd.DefaultPageSettings.PaperSize = new PaperSize("A4", 1169, 827);
                pd.DefaultPageSettings.Margins = new Margins(40, 40, 50, 50);

                pd.PrintPage += ProductionReport_PrintPage;

                PrintPreviewDialog ppd = new PrintPreviewDialog { Document = pd, WindowState = FormWindowState.Maximized };
                ppd.ShowDialog(this);

                pd.PrintPage -= ProductionReport_PrintPage;
            }
        }


        private void ProductionReport_PrintPage(object sender, PrintPageEventArgs e)
        {
            if (_currentReportData == null) return;

            Graphics g = e.Graphics;
            using (Font titleFont = new Font("Arial", 16, FontStyle.Bold))
            using (Font headerFont = new Font("Arial", 10, FontStyle.Bold))
            using (Font bodyFont = new Font("Arial", 9))
            using (Pen blackPen = new Pen(Color.Black, 1))
            {
                float yPos = e.MarginBounds.Top;
                float leftMargin = e.MarginBounds.Left;
                float printableWidth = e.MarginBounds.Width;

                // --- 1. Report Header ---
                g.DrawString(_currentReportData.CompanyName, titleFont, Brushes.Black, leftMargin, yPos);
                g.DrawString(_currentReportData.ReportTitle, titleFont, Brushes.Black, e.MarginBounds.Right - g.MeasureString(_currentReportData.ReportTitle, titleFont).Width, yPos);
                yPos += titleFont.GetHeight(g) + 5;
                g.DrawString(_currentReportData.FilterInfo, bodyFont, Brushes.Gray, e.MarginBounds.Right - g.MeasureString(_currentReportData.FilterInfo, bodyFont).Width, yPos);
                yPos += bodyFont.GetHeight(g) + 20;

                // --- 2. Table Header ---
                float tableHeaderY = yPos;
                float colRefWidth = printableWidth * 0.15f;
                float colDesignationWidth = printableWidth * 0.35f;
                float colQtyPrevWidth = printableWidth * 0.15f;
                float colQtyProdWidth = printableWidth * 0.15f;
                float colEcartWidth = printableWidth * 0.20f;

                float xDesignation = leftMargin + colRefWidth;
                float xQtyPrev = xDesignation + colDesignationWidth;
                float xQtyProd = xQtyPrev + colQtyPrevWidth;
                float xEcart = xQtyProd + colQtyProdWidth;

                g.FillRectangle(Brushes.Gainsboro, leftMargin, tableHeaderY, printableWidth, headerFont.GetHeight(g) + 10);
                g.DrawString("Référence", headerFont, Brushes.Black, leftMargin + 5, tableHeaderY + 5);
                g.DrawString("Désignation", headerFont, Brushes.Black, xDesignation + 5, tableHeaderY + 5);
                g.DrawString("Qte prévue", headerFont, Brushes.Black, xQtyPrev + 5, tableHeaderY + 5);
                g.DrawString("Qte produite", headerFont, Brushes.Black, xQtyProd + 5, tableHeaderY + 5);
                g.DrawString("Ecart", headerFont, Brushes.Black, xEcart + 5, tableHeaderY + 5);
                yPos += headerFont.GetHeight(g) + 10;

                // --- 3. Table Rows (with Pagination) ---
                int rowsPerPage = (int)((e.MarginBounds.Height - yPos) / bodyFont.GetHeight(g)) - 2; // Subtract space for summary
                int rowsPrinted = 0;
                while (printRowIndex < _currentReportData.Items.Count && rowsPrinted < rowsPerPage)
                {
                    var item = _currentReportData.Items[printRowIndex];
                    g.DrawString(item.Reference, bodyFont, Brushes.Black, leftMargin + 5, yPos);
                    g.DrawString(item.Designation, bodyFont, Brushes.Black, xDesignation + 5, yPos);
                    g.DrawString(item.QtePrevue.ToString("N2"), bodyFont, Brushes.Black, xQtyPrev + 5, yPos);
                    g.DrawString(item.QteProduite.ToString("N2"), bodyFont, Brushes.Black, xQtyProd + 5, yPos);
                    g.DrawString(item.Ecart.ToString("N2"), bodyFont, Brushes.Black, xEcart + 5, yPos);
                    yPos += bodyFont.GetHeight(g) + 5;

                    printRowIndex++;
                    rowsPrinted++;
                }

                // --- 4. Summary & Footer ---
                if (printRowIndex >= _currentReportData.Items.Count)
                {
                    e.HasMorePages = false;
                    // Draw summary totals at the end
                    yPos += 20;
                    g.DrawLine(blackPen, leftMargin, yPos, leftMargin + printableWidth, yPos);
                    yPos += 10;
                    g.DrawString($"Total Qte Prévue: {_currentReportData.TotalPrevue:N2}", headerFont, Brushes.Black, leftMargin, yPos);
                    g.DrawString($"Total Qte Produite: {_currentReportData.TotalProduite:N2}", headerFont, Brushes.Black, leftMargin + 300, yPos);
                    g.DrawString($"Total Ecart: {_currentReportData.TotalEcart:N2}", headerFont, Brushes.Black, leftMargin + 600, yPos);
                }
                else
                {
                    e.HasMorePages = true;
                    pageNumber++;
                }

                // Draw page number
                g.DrawString($"Page {pageNumber}", bodyFont, Brushes.Gray, leftMargin, e.MarginBounds.Bottom + 10);
            }
        }
    }
}