using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace TAPTAGPOS
{
    public partial class FormVentesParMois : Form
    {
        private string connectionString = DatabaseConnection.GetConnectionString();

        public FormVentesParMois()
        {
            InitializeComponent();
            InitializeEventHandlers();
        }

        private void InitializeEventHandlers()
        {
            this.Load += FormVentesParMois_Load;
            this.btnValider.Click += (s, e) => LoadData();
            this.btnFermer.Click += (s, e) => this.Close();
            // You can add logic for the Print button here later
        }

        private void FormVentesParMois_Load(object sender, EventArgs e)
        {
            // Set the year to the current year by default
            numAnnee.Value = DateTime.Now.Year;
            LoadData(); // Load data for the current year automatically
        }

        private void LoadData()
        {
            dgvSales.Rows.Clear();
            chartSales.Series[0].Points.Clear();
            decimal grandTotal = 0;
            int year = (int)numAnnee.Value;

            // This query groups all transaction totals by month for the selected year
            string query = @"
                SELECT 
                    MONTH(TransactionDate) AS SalesMonth,
                    SUM(Quantity) AS TotalQuantity,
                    SUM(TotalPrice) AS TotalSales
                FROM TransactionItems
                JOIN Transactions ON TransactionItems.TransactionID = Transactions.TransactionID
                WHERE YEAR(TransactionDate) = @Year
                GROUP BY MONTH(TransactionDate)
                ORDER BY SalesMonth";

            try
            {
                // Use a Dictionary to store results for all 12 months
                var monthlySales = new Dictionary<int, (decimal Quantity, decimal Sales)>();
                for (int i = 1; i <= 12; i++)
                {
                    monthlySales[i] = (0, 0);
                }

                using (var conn = new SqlConnection(connectionString))
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Year", year);
                    conn.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int month = Convert.ToInt32(reader["SalesMonth"]);
                            decimal quantity = Convert.ToDecimal(reader["TotalQuantity"]);
                            decimal sales = Convert.ToDecimal(reader["TotalSales"]);
                            monthlySales[month] = (quantity, sales);
                        }
                    }
                }

                // Now populate the grid and chart for all 12 months
                for (int i = 1; i <= 12; i++)
                {
                    string monthName = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(i);
                    var data = monthlySales[i];

                    dgvSales.Rows.Add(monthName, data.Quantity.ToString("N2"), data.Sales.ToString("N2"));

                    DataPoint dataPoint = new DataPoint();
                    dataPoint.SetValueXY(monthName, (double)data.Sales);
                    dataPoint.Label = data.Sales > 0 ? data.Sales.ToString("N2") : "";
                    chartSales.Series[0].Points.Add(dataPoint);

                    grandTotal += data.Sales;
                }

                txtTotal.Text = grandTotal.ToString("C2");
                labelChartTitle.Text = $"Ventes Mensuelles pour l'année {year}";
                chartSales.Series[0].ChartType = SeriesChartType.Column;
                chartSales.ChartAreas[0].AxisX.Interval = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading monthly sales data: " + ex.Message);
            }
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}