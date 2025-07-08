using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace TAPTAGPOS
{
    public partial class FormStatistiquesVentes : Form
    {
        private string connectionString = DatabaseConnection.GetConnectionString();
        private DataTable salesData; // Store data at class level for printing

        public FormStatistiquesVentes()
        {
            InitializeComponent();
            InitializeEventHandlers();
        }

        private void InitializeEventHandlers()
        {
            this.Load += FormStatistiquesVentes_Load;
            this.btnValider.Click += (s, e) => LoadData();
            this.btnPeriode.Click += btnPeriode_Click;
            this.btnFermer.Click += (s, e) => this.Close();
            this.btnImprimer.Click += btnImprimer_Click; // Link the print button

            foreach (ToolStripMenuItem item in contextMenuPeriode.Items)
            {
                item.Click += PeriodeMenuItem_Click;
            }
        }

        private void FormStatistiquesVentes_Load(object sender, EventArgs e)
        {
            dtpDateDebut.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtpDateFin.Value = DateTime.Now;
            LoadData();
        }

        #region Date Filtering Logic
        private void btnPeriode_Click(object sender, EventArgs e)
        {
            btnPeriode.ContextMenuStrip = contextMenuPeriode;
            contextMenuPeriode.Show(btnPeriode, new Point(0, btnPeriode.Height));
            btnPeriode.ContextMenuStrip = null;
        }

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
            }
        }

        private void SetDateRange(DateTime start, DateTime end)
        {
            dtpDateDebut.Value = start;
            dtpDateFin.Value = end;
            LoadData();
        }
        #endregion

        private void LoadData()
        {
            dgvSales.Rows.Clear();
            chartSales.Series[0].Points.Clear();
            decimal totalSales = 0;

            // Improved query using LEFT JOIN for better handling of uncategorized items
            string query = @"
                SELECT 
                    ISNULL(c.CategoryName, 'Non Catégorisé') AS Famille,
                    SUM(ti.Quantity) AS TotalQuantity,
                    SUM(ti.TotalPrice) AS TotalVentes
                FROM TransactionItems ti
                JOIN Transactions t ON ti.TransactionID = t.TransactionID
                JOIN Articles a ON ti.ArticleID = a.Id
                LEFT JOIN ArticleCategories c ON a.CategoryID = c.CategoryID
                WHERE t.TransactionDate BETWEEN @StartDate AND @EndDate
                GROUP BY ISNULL(c.CategoryName, 'Non Catégorisé')
                HAVING SUM(ti.TotalPrice) > 0
                ORDER BY TotalVentes DESC";

            salesData = new DataTable(); // Use the class-level DataTable

            try
            {
                using (var conn = new SqlConnection(connectionString))
                using (var adapter = new SqlDataAdapter(query, conn))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@StartDate", dtpDateDebut.Value.Date);
                    adapter.SelectCommand.Parameters.AddWithValue("@EndDate", dtpDateFin.Value.Date.AddDays(1).AddSeconds(-1));
                    adapter.Fill(salesData);
                }

                foreach (DataRow row in salesData.Rows)
                {
                    string famille = row["Famille"].ToString();
                    decimal quantite = Convert.ToDecimal(row["TotalQuantity"]);
                    decimal ventes = Convert.ToDecimal(row["TotalVentes"]);

                    dgvSales.Rows.Add(famille, quantite.ToString("N2"), ventes.ToString("N2"));

                    DataPoint dataPoint = new DataPoint();
                    dataPoint.SetValueXY(famille, (double)ventes);
                    dataPoint.Label = $"{ventes:N2}";
                    dataPoint.LegendText = famille;
                    chartSales.Series[0].Points.Add(dataPoint);

                    totalSales += ventes;
                }

                txtTotal.Text = totalSales.ToString("C2");
                labelChartTotal.Text = $"Total des Ventes: {totalSales:C2}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading sales statistics: " + ex.Message);
            }
        }

        #region Printing Logic

        private void btnImprimer_Click(object sender, EventArgs e)
        {
            if (salesData == null || salesData.Rows.Count == 0)
            {
                MessageBox.Show("Il n'y a rien à imprimer.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            PrintDocument pd = new PrintDocument();
            pd.DocumentName = "Statistiques des Ventes";
            pd.DefaultPageSettings.Landscape = true; // Set to Landscape for better layout

            string printerName = AppSettingsManager.PrinterA4A5;
            if (!string.IsNullOrEmpty(printerName))
            {
                pd.PrinterSettings.PrinterName = printerName;
            }

            pd.PrintPage += new PrintPageEventHandler(PrintPage_Handler);

            PrintPreviewDialog previewDialog = new PrintPreviewDialog { Document = pd, WindowState = FormWindowState.Maximized };
            previewDialog.ShowDialog();
        }

        private void PrintPage_Handler(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            float yPos = e.MarginBounds.Top;
            float leftMargin = e.MarginBounds.Left;
            float pageWidth = e.MarginBounds.Width;
            float rowHeight = 25f;

            using (Font titleFont = new Font("Arial", 14, FontStyle.Bold))
            using (Font headerFont = new Font("Arial", 10, FontStyle.Bold))
            using (Font bodyFont = new Font("Arial", 10))
            {
                // --- 1. Report Header ---
                string reportTitle = "Statistiques des Ventes par Famille";
                string dateRange = $"Période: {dtpDateDebut.Value:dd/MM/yyyy} - {dtpDateFin.Value:dd/MM/yyyy}";
                g.DrawString(reportTitle, titleFont, Brushes.Black, leftMargin, yPos);
                yPos += 30;
                g.DrawString(dateRange, bodyFont, Brushes.Black, leftMargin, yPos);
                yPos += 40;

                // --- 2. Draw Chart (on the right) ---
                float chartWidth = pageWidth * 0.45f; // 45% of page width
                float tableWidth = pageWidth - chartWidth - 20; // The rest for the table
                float chartX = leftMargin + tableWidth + 20;

                // Draw chart to an image in memory for better quality, then draw the image
                using (MemoryStream ms = new MemoryStream())
                {
                    chartSales.SaveImage(ms, ChartImageFormat.Png);
                    using (Image chartImage = Image.FromStream(ms))
                    {
                        g.DrawImage(chartImage, chartX, yPos, chartWidth, chartWidth * 0.75f); // Maintain aspect ratio
                    }
                }

                // --- 3. Draw Data Table (on the left) ---
                float currentX = leftMargin;
                string[] headers = { "Famille", "Quantité", "Ventes" };
                float[] colWidths = { tableWidth * 0.50f, tableWidth * 0.25f, tableWidth * 0.25f };

                // Draw header
                g.FillRectangle(Brushes.LightGray, leftMargin, yPos, tableWidth, rowHeight);
                for (int i = 0; i < headers.Length; i++)
                {
                    g.DrawString(headers[i], headerFont, Brushes.Black, currentX + 5, yPos + 5);
                    currentX += colWidths[i];
                }
                yPos += rowHeight;

                // Draw rows
                foreach (DataRow row in salesData.Rows)
                {
                    currentX = leftMargin;
                    g.DrawString(row["Famille"].ToString(), bodyFont, Brushes.Black, currentX + 5, yPos + 5);
                    currentX += colWidths[0];
                    g.DrawString(Convert.ToDecimal(row["TotalQuantity"]).ToString("N2"), bodyFont, Brushes.Black, currentX + 5, yPos + 5);
                    currentX += colWidths[1];
                    g.DrawString(Convert.ToDecimal(row["TotalVentes"]).ToString("C2"), bodyFont, Brushes.Black, currentX + 5, yPos + 5);
                    yPos += rowHeight;
                }

                // Draw total line
                g.DrawLine(Pens.Black, leftMargin, yPos, leftMargin + tableWidth, yPos);
                yPos += 2;
                g.DrawString("TOTAL", headerFont, Brushes.Black, leftMargin + colWidths[0] + 5, yPos + 5);
                g.DrawString(txtTotal.Text, headerFont, Brushes.Black, leftMargin + colWidths[0] + colWidths[1] + 5, yPos + 5);
            }
        }

        #endregion
    }
}