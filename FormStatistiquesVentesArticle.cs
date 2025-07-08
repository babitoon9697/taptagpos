using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static TAPTAGPOS.PopupTableArticles;

namespace TAPTAGPOS
{
    public partial class FormStatistiquesVentesArticle : Form
    {
        private string connectionString = DatabaseConnection.GetConnectionString();
        private int _selectedArticleId = -1;

        public FormStatistiquesVentesArticle()
        {
            InitializeComponent();
            InitializeEventHandlers();
        }

        private void InitializeEventHandlers()
        {
            this.btnSearchArticle.Click += btnSearchArticle_Click;
            this.btnValider.Click += (s, e) => LoadData();
            this.btnFermer.Click += (s, e) => this.Close();
            // Add click event for Print button when ready
        }

        private void btnSearchArticle_Click(object sender, EventArgs e)
        {
            using (var articleSelector = new PopupTableArticles(ArticleSelectionMode.Single))
            {
                if (articleSelector.ShowDialog(this) == DialogResult.OK && articleSelector.SelectedArticle != null)
                {
                    var article = articleSelector.SelectedArticle;
                    _selectedArticleId = article.Id;
                    txtReference.Text = article.ArticleCode;
                    txtDesignation.Text = article.ArticleLongName;

                    // Automatically load data after selection
                    LoadData();
                }
            }
        }

        private void LoadData()
        {
            if (_selectedArticleId <= 0)
            {
                MessageBox.Show("Veuillez d'abord sélectionner un article.", "Article non sélectionné", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            dgvSales.Rows.Clear();
            chartSales.Series[0].Points.Clear();
            decimal grandTotalSales = 0;

            string query = @"
                SELECT 
                    FORMAT(t.TransactionDate, 'yyyy-MM') AS SalesMonth,
                    SUM(ti.Quantity) AS TotalQuantity,
                    SUM(ti.TotalPrice) AS TotalSales
                FROM TransactionItems ti
                JOIN Transactions t ON ti.TransactionID = t.TransactionID
                WHERE ti.ArticleID = @ArticleID
                GROUP BY FORMAT(t.TransactionDate, 'yyyy-MM')
                ORDER BY SalesMonth ASC";

            try
            {
                using (var conn = new SqlConnection(connectionString))
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ArticleID", _selectedArticleId);
                    conn.Open();

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string salesMonth = reader["SalesMonth"].ToString();
                            decimal totalQuantity = Convert.ToDecimal(reader["TotalQuantity"]);
                            decimal totalSales = Convert.ToDecimal(reader["TotalSales"]);

                            // Add to DataGridView
                            dgvSales.Rows.Add(salesMonth, totalQuantity.ToString("N2"), totalSales.ToString("N2"));

                            // Add to Chart
                            chartSales.Series[0].Points.AddXY(salesMonth, totalSales);

                            grandTotalSales += totalSales;
                        }
                    }
                }

                // Update totals and configure chart
                txtTotal.Text = grandTotalSales.ToString("C2");
                chartSales.Series[0].ChartType = SeriesChartType.Column; // Set chart type
                chartSales.ChartAreas[0].AxisX.Interval = 1; // Show every month label
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading sales statistics for article: " + ex.Message);
            }
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}