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
    public partial class ClientSituationByItemForm : Form
    {
        private string connectionString = DatabaseConnection.GetConnectionString();
        private DataTable reportData;
        private ContextMenuStrip dateRangeMenu;
        private int printRowIndex = 0;

        public ClientSituationByItemForm()
        {
            InitializeComponent();
            InitializeEventHandlers();
            InitializeDateRangeMenu();
        }

        private void InitializeEventHandlers()
        {
            this.Load += ClientSituationByItemForm_Load;
            this.buttonView.Click += (s, e) => LoadReportData();
            this.buttonClose.Click += (s, e) => this.Close();
            this.buttonPrint.Click += buttonPrint_Click;
            this.buttonItemDetails.Click += buttonItemDetails_Click;
            this.buttonTimePeriod.Click += buttonTimePeriod_Click;
            this.comboBoxClient.SelectedIndexChanged += (s, e) => LoadReportData();
            this.comboBoxFamily.SelectedIndexChanged += (s, e) => LoadReportData();
        }

        private void ClientSituationByItemForm_Load(object sender, EventArgs e)
        {
            dateTimePickerStartDate.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dateTimePickerEndDate.Value = DateTime.Now;

            StyleDataGridView();
            LoadClients();
            LoadFamilies();

            LoadReportData();
        }

        #region Data Loading & Filtering

        private void StyleDataGridView()
        {
            dataGridViewSituation.AutoGenerateColumns = false;
            colCode.DataPropertyName = "Code";
            colItem.DataPropertyName = "Article";
            colQuantity.DataPropertyName = "TotalQuantity";
            colTotal.DataPropertyName = "TotalSum";
        }

        private void LoadClients()
        {
            LoadGenericComboBox(comboBoxClient, "SELECT CustomerID, CustomerName FROM Customers WHERE IsActive=1 ORDER BY CustomerName", "CustomerName", "CustomerID", "Tous les Clients");
        }

        private void LoadFamilies()
        {
            LoadGenericComboBox(comboBoxFamily, "SELECT CategoryID, CategoryName FROM ArticleCategories WHERE IsActive=1 ORDER BY CategoryName", "CategoryName", "CategoryID", "Toutes les Familles");
        }

        private void LoadGenericComboBox(ComboBox cmb, string query, string displayMember, string valueMember, string placeholder)
        {
            try
            {
                var dt = new DataTable();
                using (var conn = new SqlConnection(connectionString))
                {
                    new SqlDataAdapter(query, conn).Fill(dt);
                }
                DataRow dr = dt.NewRow();
                dr[valueMember] = 0;
                dr[displayMember] = placeholder;
                dt.Rows.InsertAt(dr, 0);

                cmb.DataSource = dt;
                cmb.DisplayMember = displayMember;
                cmb.ValueMember = valueMember;
            }
            catch (Exception ex) { MessageBox.Show($"Error loading {displayMember}: {ex.Message}"); }
        }

        private void LoadReportData()
        {
            var queryBuilder = new StringBuilder(@"
                SELECT 
                    a.Id AS Code, a.Article,
                    SUM(ti.Quantity) AS TotalQuantity,
                    SUM(ti.TotalPrice) AS TotalSum,
                    a.CategoryID 
                FROM TransactionItems ti
                JOIN Transactions t ON ti.TransactionID = t.TransactionID
                JOIN Articles a ON ti.ArticleID = a.Id
                WHERE t.TransactionDate BETWEEN @StartDate AND @EndDate ");

            var parameters = new Dictionary<string, object>
            {
                { "@StartDate", dateTimePickerStartDate.Value.Date },
                { "@EndDate", dateTimePickerEndDate.Value.Date.AddDays(1).AddSeconds(-1) }
            };

            // Safely get the selected Customer ID
            int customerId = 0;
            if (comboBoxClient.SelectedIndex > 0 && comboBoxClient.SelectedValue != DBNull.Value)
            {
                customerId = Convert.ToInt32(comboBoxClient.SelectedValue);
            }
            if (customerId > 0)
            {
                queryBuilder.Append(" AND t.CustomerID = @CustomerID");
                parameters.Add("@CustomerID", customerId);
            }

            // Safely get the selected Category ID
            int categoryId = 0;
            if (comboBoxFamily.SelectedIndex > 0 && comboBoxFamily.SelectedValue != DBNull.Value)
            {
                categoryId = Convert.ToInt32(comboBoxFamily.SelectedValue);
            }
            if (categoryId > 0)
            {
                queryBuilder.Append(" AND a.CategoryID = @CategoryID");
                parameters.Add("@CategoryID", categoryId);
            }

            queryBuilder.Append(" GROUP BY a.Id, a.Article, a.CategoryID ORDER BY a.Article");

            try
            {
                reportData = new DataTable();
                using (var conn = new SqlConnection(connectionString))
                using (var cmd = new SqlCommand(queryBuilder.ToString(), conn))
                {
                    foreach (var p in parameters)
                    {
                        cmd.Parameters.AddWithValue(p.Key, p.Value);
                    }
                    new SqlDataAdapter(cmd).Fill(reportData);
                }

                dataGridViewSituation.AutoGenerateColumns = false; // Prevent duplicate columns
                dataGridViewSituation.DataSource = reportData;
                CalculateTotals();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading report data: " + ex.Message);
            }
        }
        private void CalculateTotals()
        {
            if (reportData == null) return;
            textBoxTotalQuantity.Text = Convert.ToDecimal(reportData.Compute("SUM(TotalQuantity)", "")).ToString("N2");
            textBoxTotalSum.Text = Convert.ToDecimal(reportData.Compute("SUM(TotalSum)", "")).ToString("C2");
        }

        #endregion

        #region UI Events

        private void InitializeDateRangeMenu()
        {
            dateRangeMenu = new ContextMenuStrip();
            var items = new ToolStripMenuItem[]
            {
                new ToolStripMenuItem("Aujourd'hui") { Name = "today" },
                new ToolStripMenuItem("Hier") { Name = "yesterday" },
                new ToolStripMenuItem("Ce mois-ci") { Name = "thisMonth" },
                new ToolStripMenuItem("Cette année") { Name = "thisYear" }
            };
            foreach (var item in items) item.Click += PeriodeMenuItem_Click;
            dateRangeMenu.Items.AddRange(items);
        }

        private void buttonTimePeriod_Click(object sender, EventArgs e)
        {
            dateRangeMenu.Show(buttonTimePeriod, new Point(0, buttonTimePeriod.Height));
        }

        private void PeriodeMenuItem_Click(object sender, EventArgs e)
        {
            var today = DateTime.Today;
            var menuItem = sender as ToolStripMenuItem;
            switch (menuItem.Name)
            {
                case "today": SetDateRange(today, today); break;
                case "yesterday": SetDateRange(today.AddDays(-1), today.AddDays(-1)); break;
                case "thisMonth": SetDateRange(new DateTime(today.Year, today.Month, 1), today); break;
                case "thisYear": SetDateRange(new DateTime(today.Year, 1, 1), today); break;
            }
        }

        private void SetDateRange(DateTime start, DateTime end)
        {
            dateTimePickerStartDate.Value = start;
            dateTimePickerEndDate.Value = end;
            LoadReportData();
        }

        private void buttonItemDetails_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Printing

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            if (dataGridViewSituation.Rows.Count == 0) return;
            printRowIndex = 0;

            PrintDocument pd = new PrintDocument();
            pd.DocumentName = "Situation Client par Article";
            pd.DefaultPageSettings.Landscape = true;

            string printerName = AppSettingsManager.PrinterA4A5;
            if (!string.IsNullOrEmpty(printerName)) pd.PrinterSettings.PrinterName = printerName;

            pd.PrintPage += PrintPage_Handler;
            PrintPreviewDialog preview = new PrintPreviewDialog { Document = pd, WindowState = FormWindowState.Maximized };
            preview.ShowDialog(this);
        }

        private void PrintPage_Handler(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            float yPos = e.MarginBounds.Top;
            float leftMargin = e.MarginBounds.Left;
            float pageWidth = e.MarginBounds.Width;
            int rowHeight = 30;

            using (Font titleFont = new Font("Arial", 16, FontStyle.Bold))
            using (Font headerFont = new Font("Arial", 10, FontStyle.Bold))
            using (Font bodyFont = new Font("Arial", 9))
            {
                g.DrawString($"Situation par Article: {comboBoxClient.Text}", titleFont, Brushes.Black, leftMargin, yPos);
                yPos += 30;
                g.DrawString($"Période: {dateTimePickerStartDate.Value:dd/MM/yyyy} - {dateTimePickerEndDate.Value:dd/MM/yyyy}", bodyFont, Brushes.Gray, leftMargin, yPos);
                yPos += 40;

                float[] colWidths = { 0.20f, 0.50f, 0.15f, 0.15f };
                string[] headers = { "Code", "Article", "Quantité", "Total" };
                float currentX = leftMargin;
                g.FillRectangle(Brushes.LightGray, leftMargin, yPos, pageWidth, rowHeight);
                for (int i = 0; i < headers.Length; i++)
                {
                    g.DrawString(headers[i], headerFont, Brushes.Black, currentX + 5, yPos + 5);
                    currentX += pageWidth * colWidths[i];
                }
                yPos += rowHeight;

                while (printRowIndex < dataGridViewSituation.Rows.Count)
                {
                    if (yPos + rowHeight > e.MarginBounds.Bottom)
                    {
                        e.HasMorePages = true; return;
                    }
                    DataGridViewRow row = dataGridViewSituation.Rows[printRowIndex];
                    currentX = leftMargin;
                    for (int i = 0; i < headers.Length; i++)
                    {
                        g.DrawString(row.Cells[i].FormattedValue.ToString(), bodyFont, Brushes.Black, currentX + 5, yPos + 5);
                        currentX += pageWidth * colWidths[i];
                    }
                    yPos += rowHeight;
                    printRowIndex++;
                }

                yPos += 20;
                g.DrawLine(Pens.Black, leftMargin, yPos, leftMargin + pageWidth, yPos);
                yPos += 10;
                g.DrawString($"Total Quantité: {textBoxTotalQuantity.Text}", headerFont, Brushes.Black, leftMargin, yPos);
                g.DrawString($"Total Ventes: {textBoxTotalSum.Text}", headerFont, Brushes.Black, leftMargin + 300, yPos);

                e.HasMorePages = false;
            }
        }
        #endregion
    }
}