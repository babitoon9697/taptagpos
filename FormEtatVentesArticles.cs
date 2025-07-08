using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TAPTAGPOS
{
    public partial class FormEtatVentesArticles : Form
    {
        private string connectionString = DatabaseConnection.GetConnectionString();

        public FormEtatVentesArticles()
        {
            InitializeComponent();
            InitializeEventHandlers();
        }

        private void InitializeEventHandlers()
        {
            this.Load += FormEtatVentesArticles_Load;
            this.btnValider.Click += (s, e) => LoadData();
            this.btnDetail.Click += btnDetail_Click;
            this.btnFermer.Click += (s, e) => this.Close();
            this.dgvVentes.CellDoubleClick += (s, e) => btnDetail_Click(s, e);
            // You can add logic for the Period and Print buttons here
        }

        private void FormEtatVentesArticles_Load(object sender, EventArgs e)
        {
            // Set a default date range (e.g., this month)
            dtpDateDebut.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtpDateFin.Value = DateTime.Now;
            LoadData(); // Load data automatically on start
        }

        private void LoadData()
        {
            dgvVentes.Rows.Clear();
            decimal totalQty = 0;
            decimal totalValue = 0;

            // This query groups all sales by Article, summing the quantity and total price
            string query = @"
                SELECT 
                    ti.ArticleID,
                    a.Article AS Reference,
                    a.ArticleLongName AS Designation,
                    SUM(ti.Quantity) AS TotalVentes,
                    SUM(ti.TotalPrice) AS TotalValeur
                FROM TransactionItems ti
                JOIN Transactions t ON ti.TransactionID = t.TransactionID
                JOIN Articles a ON ti.ArticleID = a.Id
                WHERE t.TransactionDate BETWEEN @StartDate AND @EndDate
                GROUP BY ti.ArticleID, a.Article, a.ArticleLongName
                ORDER BY TotalValeur DESC";

            try
            {
                using (var conn = new SqlConnection(connectionString))
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@StartDate", dtpDateDebut.Value.Date);
                    cmd.Parameters.AddWithValue("@EndDate", dtpDateFin.Value.Date.AddDays(1).AddSeconds(-1));
                    conn.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            decimal qte = Convert.ToDecimal(reader["TotalVentes"]);
                            decimal valeur = Convert.ToDecimal(reader["TotalValeur"]);

                            int rowIndex = dgvVentes.Rows.Add(
                                reader["Reference"],
                                reader["Designation"],
                                qte.ToString("N2"),
                                valeur.ToString("N2")
                            );
                            // Store the ArticleID in the Tag for the "Detail" button
                            dgvVentes.Rows[rowIndex].Tag = reader["ArticleID"];

                            totalQty += qte;
                            totalValue += valeur;
                        }
                    }
                }

                // Update the footer totals
                txtTotalQty.Text = totalQty.ToString("N2");
                txtTotalValue.Text = totalValue.ToString("C2");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading article sales data: " + ex.Message);
            }
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            if (dgvVentes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un article pour voir le détail.", "Aucune sélection");
                return;
            }

            int articleId = (int)dgvVentes.SelectedRows[0].Tag;
            string articleName = dgvVentes.SelectedRows[0].Cells["colDesignation"].Value.ToString();

            // Open the Article Tracking form we created before
            FormSuiviArticle suiviForm = new FormSuiviArticle(articleId, articleName);
            suiviForm.ShowDialog(this);
        }
    }
}