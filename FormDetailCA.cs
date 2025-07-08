using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace TAPTAGPOS
{
    public partial class FormDetailCA : Form
    {
        private readonly string connectionString = DatabaseConnection.GetConnectionString();

        public FormDetailCA()
        {
            InitializeComponent();
            SetupForm();
        }

        private void SetupForm()
        {
            this.Load += FormDetailCA_Load;
            this.btnConfirm.Click += BtnConfirm_Click;
            this.btnClose.Click += (s, e) => this.Close();
            this.btnPrint.Click += (s, e) => MessageBox.Show("La fonctionnalité d'impression sera ajoutée ultérieurement.", "Info");
        }

        private void FormDetailCA_Load(object sender, EventArgs e)
        {
            dtpDateDebut.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtpDateFin.Value = DateTime.Now;

            // Automatically load data for the current month when the form opens
            BtnConfirm_Click(sender, e);
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            LoadReportData();
        }

        private void LoadReportData()
        {
            DateTime startDate = dtpDateDebut.Value.Date;
            DateTime endDate = dtpDateFin.Value.Date.AddDays(1).AddSeconds(-1);

            // This query calculates sales, cost, and profit for every item sold in the period.
            string query = @"
                SELECT
                    a.Article AS ArticleCode,
                    a.ArticleLongName,
                    SUM(ti.Quantity) AS TotalQuantitySold,
                    SUM(ti.TotalPrice) AS TotalSaleValue,
                    (SUM(ti.Quantity) * a.BuyPrice) AS TotalCostValue,
                    (SUM(ti.TotalPrice) - (SUM(ti.Quantity) * a.BuyPrice)) AS GrossProfit
                FROM TransactionItems ti
                JOIN Transactions t ON ti.TransactionID = t.TransactionID
                JOIN Articles a ON ti.ArticleID = a.Id
                WHERE t.TransactionDate BETWEEN @StartDate AND @EndDate
                GROUP BY a.Article, a.ArticleLongName, a.BuyPrice
                HAVING SUM(ti.Quantity) > 0
                ORDER BY GrossProfit DESC";

            try
            {
                using (var conn = new SqlConnection(connectionString))
                {
                    var adapter = new SqlDataAdapter(query, conn);
                    adapter.SelectCommand.Parameters.AddWithValue("@StartDate", startDate);
                    adapter.SelectCommand.Parameters.AddWithValue("@EndDate", endDate);

                    var dt = new DataTable();
                    adapter.Fill(dt);
                    dgvCA.DataSource = dt;

                    FormatGrid();
                    CalculateFooterTotals(conn, startDate, endDate);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la génération du rapport de rentabilité: " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormatGrid()
        {
            dgvCA.Columns["ArticleCode"].HeaderText = "Code";
            dgvCA.Columns["ArticleLongName"].HeaderText = "Article";
            dgvCA.Columns["TotalQuantitySold"].HeaderText = "Quantité Vendue";
            dgvCA.Columns["TotalSaleValue"].HeaderText = "Valeur Vente";
            dgvCA.Columns["TotalCostValue"].HeaderText = "Coût d'Achat";
            dgvCA.Columns["GrossProfit"].HeaderText = "Marge Brute";

            string currencyFormat = "N2";
            dgvCA.Columns["TotalSaleValue"].DefaultCellStyle.Format = currencyFormat;
            dgvCA.Columns["TotalCostValue"].DefaultCellStyle.Format = currencyFormat;
            dgvCA.Columns["GrossProfit"].DefaultCellStyle.Format = currencyFormat;
            dgvCA.Columns["GrossProfit"].DefaultCellStyle.Font = new Font(this.Font, FontStyle.Bold);
        }

        private void CalculateFooterTotals(SqlConnection conn, DateTime startDate, DateTime endDate)
        {
            decimal grossProfit = 0m;
            foreach (DataGridViewRow row in dgvCA.Rows)
            {
                grossProfit += Convert.ToDecimal(row.Cells["GrossProfit"].Value ?? 0);
            }
            txtGrossProfit.Text = grossProfit.ToString("C2");

            // Now, get total expenses for the same period
            decimal totalExpenses = 0m;
            string expensesQuery = "SELECT ISNULL(SUM(Amount), 0) FROM Expenses WHERE ExpenseDate BETWEEN @StartDate AND @EndDate";
            using (var cmd = new SqlCommand(expensesQuery, conn))
            {
                cmd.Parameters.AddWithValue("@StartDate", startDate);
                cmd.Parameters.AddWithValue("@EndDate", endDate);
                var result = cmd.ExecuteScalar();
                if (result != DBNull.Value)
                {
                    totalExpenses = Convert.ToDecimal(result);
                }
            }
            txtExpenses.Text = totalExpenses.ToString("C2");

            // Calculate Net Profit
            decimal netProfit = grossProfit - totalExpenses;
            txtNetProfit.Text = netProfit.ToString("C2");

            // Color the net profit based on value
            if (netProfit < 0)
            {
                txtNetProfit.ForeColor = Color.Red;
            }
            else
            {
                txtNetProfit.ForeColor = Color.DarkGreen;
            }
        }
    }
}