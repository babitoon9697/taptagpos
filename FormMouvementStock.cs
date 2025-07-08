using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TAPTAGPOS
{
    public partial class FormMouvementStock : Form
    {
        private string connectionString = DatabaseConnection.GetConnectionString();

        public FormMouvementStock()
        {
            InitializeComponent();
            this.Load += FormMouvementStock_Load;
            this.btnAfficher.Click += (s, e) => LoadData();
        }

        private void FormMouvementStock_Load(object sender, EventArgs e)
        {
            dtpDate.Value = DateTime.Now;
            LoadFamilles();
            LoadData();
        }

        private void LoadFamilles()
        {
            try
            {
                var dt = new DataTable();
                dt.Columns.Add("CategoryName");
                dt.Rows.Add("Toutes");

                using (var conn = new SqlConnection(connectionString))
                using (var adapter = new SqlDataAdapter("SELECT DISTINCT CategoryName FROM ArticleCategories WHERE IsActive=1", conn))
                {
                    adapter.Fill(dt);
                }
                cmbFamille.DataSource = dt;
                cmbFamille.DisplayMember = "CategoryName";
            }
            catch (Exception ex) { MessageBox.Show("Error loading families: " + ex.Message); }
        }

        private void LoadData()
        {
            dgvStock.Rows.Clear();
            DateTime selectedDate = dtpDate.Value.Date;
            DateTime endDate = selectedDate.AddDays(1);

            // 1. UPDATED QUERY: Added a.MinStock to the SELECT statement
            string query = @"
        WITH InitialStock AS (
            SELECT ArticleID, SUM(Quantity) as StockInitial
            FROM ArticleStockHistory
            WHERE ChangeDate < @SelectedDate
            GROUP BY ArticleID
        ),
        DailyMovements AS (
            SELECT ArticleID, 
                   SUM(CASE WHEN Quantity > 0 THEN Quantity ELSE 0 END) as Entrees,
                   SUM(CASE WHEN Quantity < 0 THEN ABS(Quantity) ELSE 0 END) as Sorties
            FROM ArticleStockHistory
            WHERE ChangeDate >= @SelectedDate AND ChangeDate < @EndDate
            GROUP BY ArticleID
        )
        SELECT 
            a.Id, a.Article as Reference, a.ArticleLongName as Designation, a.MinStock,
            ISNULL(i.StockInitial, 0) as StockInitial,
            ISNULL(d.Entrees, 0) as Entrees,
            ISNULL(d.Sorties, 0) as Sorties
        FROM Articles a
        LEFT JOIN InitialStock i ON a.Id = i.ArticleID
        LEFT JOIN DailyMovements d ON a.Id = d.ArticleID
        WHERE a.IsActive = 1";

            if (cmbFamille.Text != "Toutes" && cmbFamille.SelectedIndex > 0)
            {
                query += " AND a.Categorie = @Famille";
            }

            try
            {
                using (var conn = new SqlConnection(connectionString))
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@SelectedDate", selectedDate);
                    cmd.Parameters.AddWithValue("@EndDate", endDate);
                    if (cmbFamille.Text != "Toutes" && cmbFamille.SelectedIndex > 0)
                    {
                        cmd.Parameters.AddWithValue("@Famille", cmbFamille.Text);
                    }

                    conn.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            decimal stockInitial = Convert.ToDecimal(reader["StockInitial"]);
                            decimal entrees = Convert.ToDecimal(reader["Entrees"]);
                            decimal sorties = Convert.ToDecimal(reader["Sorties"]);
                            decimal finalStock = stockInitial + entrees - sorties;

                            // Read the MinStock value, defaulting to 0 if it's null
                            decimal minStock = Convert.ToDecimal(reader["MinStock"] ?? 0);

                            int rowIndex = dgvStock.Rows.Add(
                                reader["Reference"],
                                reader["Designation"],
                                finalStock.ToString("N2"),
                                entrees.ToString("N2"),
                                sorties.ToString("N2")
                            );

                            // 2. COMPLETE COLOR CODING LOGIC
                            DataGridViewRow row = dgvStock.Rows[rowIndex];
                            if (finalStock <= 0)
                            {
                                // Rupture de Stock (Out of Stock)
                                row.DefaultCellStyle.BackColor = Color.Red;
                                row.DefaultCellStyle.ForeColor = Color.White;
                            }
                            else if (minStock > 0 && finalStock <= minStock)
                            {
                                // Stock en Alerte (Low Stock Alert)
                                row.DefaultCellStyle.BackColor = Color.Orange;
                            }
                            // No 'else' is needed, as the default color is white.
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading stock movement data: " + ex.Message);
            }
        }
    }
}