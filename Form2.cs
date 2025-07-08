using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace TAPTAGPOS
{
    public partial class Form2 : Form
    {
        private string connectionString = DatabaseConnection.GetConnectionString();
        private Button currentButton; // To track the active button

        public Form2()
        {
            InitializeComponent();
            this.Load += Form2_Load;
            InitializeEventHandlers();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // Set the first button as active and load initial data
            ActivateButton(btnCaisse);
            LoadDashboardData();
        }

        private void InitializeEventHandlers()
        {
            // Connect all sidebar buttons to their respective actions
            btnCaisse.Click += (s, e) => { ActivateButton(s as Button); new Caisse().Show(); };
            btn_facture.Click += (s, e) => { ActivateButton(s as Button); new LISTTICKET().Show(); };
            btnAchat.Click += (s, e) => { ActivateButton(s as Button); new Achat().Show(); };
            btn_fournisseurs.Click += (s, e) => { ActivateButton(s as Button); new SupplierTableForm().Show(); };
            Btn_CreditCustomer.Click += (s, e) => { ActivateButton(s as Button); new ClientSituationForm().Show(); };
            btnStock.Click += (s, e) => { ActivateButton(s as Button); new Stock().Show(); };
            btnArticles.Click += (s, e) => { ActivateButton(s as Button); new ListArticles().Show(); };
            btnBarcode.Click += (s, e) => { ActivateButton(s as Button); new FormImpressionBarcode().Show(); };
            btn_Statistic.Click += (s, e) => { ActivateButton(s as Button); new FormStatistiquesVentes().Show(); };
            Btn_ListePosSession.Click += (s, e) => { ActivateButton(s as Button); new FormPosSession().Show(); };
            btnSettings.Click += (s, e) => { ActivateButton(s as Button); new FicheParametres().Show(); };
            btnClose.Click += (s, e) => this.Close();
        }

        // --- NEW: Method to load all dashboard data ---
        private void LoadDashboardData()
        {
            try
            {
                using (var conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // 1. Get Total Customer Debt
                    var cmdCredit = new SqlCommand("SELECT SUM(AmountDue) FROM Customers", conn);
                    object resultCredit = cmdCredit.ExecuteScalar();
                    if (resultCredit != DBNull.Value)
                    {
                        lblCard1Value_creditclient.Text = Convert.ToDecimal(resultCredit).ToString("C2");
                    }

                    // 2. Get Total Supplier Debt
                    var cmdSupplier = new SqlCommand("SELECT SUM(CurrentBalance) FROM Suppliers", conn);
                    object resultSupplier = cmdSupplier.ExecuteScalar();
                    if (resultSupplier != DBNull.Value)
                    {
                        lblCard2Value_creditsuppliers.Text = Convert.ToDecimal(resultSupplier).ToString("C2");
                    }
                }

                // 3. Load the sales statistics chart
                LoadSalesChart();
                LoadClientCreditChart();
                LoadSupplierCreditChart();
            }
            catch (Exception ex)
            {
                // Display a friendly error if data cannot be loaded
                lblCard1Value_creditclient.Text = "Error";
                lblCard2Value_creditsuppliers.Text = "Error";
                MessageBox.Show("Failed to load dashboard data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // --- NEW: Method to generate and display the sales chart ---
        // In Form2.cs
        private void LoadClientCreditChart()
        {
            var data = new Dictionary<string, decimal>();
            string query = "SELECT TOP 4 CustomerName, AmountDue FROM Customers WHERE AmountDue > 0 ORDER BY AmountDue DESC";
            try
            {
                using (var conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (var cmd = new SqlCommand(query, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            data.Add(reader["CustomerName"].ToString(), Convert.ToDecimal(reader["AmountDue"]));
                        }
                    }
                }
                DrawPieChart(picChart1_clientcredit, data, "Top 4 Clients par Dette");
            }
            catch (Exception ex) { Console.WriteLine("Client Chart Error: " + ex.Message); }
        }

        // --- NEW: Method to generate the Supplier Credit chart ---
        private void LoadSupplierCreditChart()
        {
            var data = new Dictionary<string, decimal>();
            string query = "SELECT TOP 4 Name, AmountDue FROM Suppliers WHERE AmountDue > 0 ORDER BY AmountDue DESC";
            try
            {
                using (var conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (var cmd = new SqlCommand(query, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            data.Add(reader["Name"].ToString(), Convert.ToDecimal(reader["AmountDue"]));
                        }
                    }
                }
                DrawPieChart(picChart2_suppliercredit, data, "Top 4 Fournisseurs par Dette");
            }
            catch (Exception ex) { Console.WriteLine("Supplier Chart Error: " + ex.Message); }
        }

        // --- NEW: Reusable method to draw any Pie Chart ---
        private void DrawPieChart(PictureBox pb, Dictionary<string, decimal> data, string title)
        {
            var chart = new Chart { Size = pb.Size };
            chart.Titles.Add(new Title(title, Docking.Top, new Font("Segoe UI", 10F, FontStyle.Bold), Color.White));
            var chartArea = new ChartArea();
            chart.ChartAreas.Add(chartArea);
            var series = new Series("Data") { ChartType = SeriesChartType.Pie };
            chart.Series.Add(series);

            chart.BackColor = Color.FromArgb(22, 27, 34);
            chartArea.BackColor = Color.Transparent;
            chart.Legends.Add(new Legend("Legend") { ForeColor = Color.White, BackColor = Color.Transparent });

            series.Points.DataBind(data, "Key", "Value", "Label=Key,YValueType=Double");
            series.Label = "#PERCENT{P0}";
            series.LegendText = "#VALX";

            Bitmap bmp = new Bitmap(chart.Width, chart.Height);
            chart.DrawToBitmap(bmp, new Rectangle(0, 0, chart.Width, chart.Height));
            pb.Image = bmp;
        }

        private void LoadSalesChart()
        {
            var salesData = new Dictionary<DateTime, decimal>();
            string query = @"SELECT CAST(TransactionDate AS DATE) as SaleDay, SUM(TotalAmount) as DailyTotal 
                     FROM Transactions 
                     WHERE TransactionDate >= DATEADD(day, -30, GETDATE()) 
                     GROUP BY CAST(TransactionDate AS DATE) 
                     ORDER BY SaleDay";
            try
            {
                using (var conn = new SqlConnection(connectionString))
                using (var cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            salesData.Add(Convert.ToDateTime(reader["SaleDay"]), Convert.ToDecimal(reader["DailyTotal"]));
                        }
                    }
                }

                var chart = new Chart { Size = picChart3_statistics.Size };
                var chartArea = new ChartArea();
                chart.ChartAreas.Add(chartArea);
                var series = new Series("Sales") { ChartType = SeriesChartType.Spline, BorderWidth = 3 };
                chart.Series.Add(series);

                // --- START OF FIX ---
                // Set both the main chart and the plot area backgrounds to transparent
                chart.BackColor = Color.Transparent;
                chartArea.BackColor = Color.Transparent;
                // --- END OF FIX ---

                // Customize appearance for dark theme
                chartArea.AxisX.MajorGrid.LineColor = Color.FromArgb(45, 52, 70);
                chartArea.AxisY.MajorGrid.LineColor = Color.FromArgb(45, 52, 70);
                chartArea.AxisX.LineColor = Color.DarkGray;
                chartArea.AxisY.LineColor = Color.DarkGray;
                chartArea.AxisX.LabelStyle.ForeColor = Color.Black;
                chartArea.AxisY.LabelStyle.ForeColor = Color.Black;
                chartArea.AxisX.MajorTickMark.LineColor = Color.DarkGray;
                chartArea.AxisY.MajorTickMark.LineColor = Color.DarkGray;
                series.Color = Color.FromArgb(59, 130, 246);
                series.IsValueShownAsLabel = true;
                series.LabelForeColor = Color.Black;
                series.Font = new Font("Segoe UI", 8, FontStyle.Bold);

                chart.DataSource = salesData;
                series.XValueMember = "Key";
                series.YValueMembers = "Value";
                series.XValueType = ChartValueType.Date;
                chartArea.AxisX.LabelStyle.Format = "ddd, MMM d";

                Bitmap bmp = new Bitmap(chart.Width, chart.Height);
                chart.DrawToBitmap(bmp, new Rectangle(0, 0, chart.Width, chart.Height));
                picChart3_statistics.Image = bmp;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Chart Error: " + ex.Message);
            }
        }
        // --- NEW: Helper method to manage active button style ---
        private void ActivateButton(Button clickedButton)
        {
            if (currentButton != null)
            {
                // Deactivate the previously active button
                currentButton.BackColor = Color.FromArgb(22, 27, 34); // Back to sidebar color
                currentButton.ForeColor = Color.FromArgb(148, 163, 184); // Back to gray text
            }

            // Activate the new button
            currentButton = clickedButton;
            currentButton.BackColor = Color.FromArgb(59, 130, 246); // Blue background
            currentButton.ForeColor = Color.White; // White text
        }
    }
}