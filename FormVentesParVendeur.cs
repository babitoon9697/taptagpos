using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TAPTAGPOS
{
    public partial class FormVentesParVendeur : Form
    {
        private string connectionString = DatabaseConnection.GetConnectionString();

        public FormVentesParVendeur()
        {
            InitializeComponent();
            InitializeEventHandlers();
        }

        private void InitializeEventHandlers()
        {
            this.Load += FormVentesParVendeur_Load;
            this.btnValider.Click += (s, e) => LoadData();
            this.btnPeriode.Click += btnPeriode_Click;
            this.btnFermer.Click += (s, e) => this.Close();

            // Link all context menu items
            aujourdhuiToolStripMenuItem.Click += (s, e) => SetDateRange(DateTime.Today, DateTime.Today);
            hierToolStripMenuItem.Click += (s, e) => SetDateRange(DateTime.Today.AddDays(-1), DateTime.Today.AddDays(-1));
            semaineEnCoursToolStripMenuItem.Click += (s, e) => SetDateRange(DateTime.Today.AddDays(-(int)DateTime.Today.DayOfWeek), DateTime.Today);
            moisEnCoursToolStripMenuItem.Click += (s, e) => SetDateRange(new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1), DateTime.Today);
            // ... Add other period handlers similarly
        }

        private void FormVentesParVendeur_Load(object sender, EventArgs e)
        {
            dtpDateDebut.Value = DateTime.Now.AddMonths(-1);
            dtpDateFin.Value = DateTime.Now;
            LoadVendeurs();
        }

        private void LoadVendeurs()
        {
            try
            {
                var dt = new DataTable();
                dt.Columns.Add("Nom");
                dt.Rows.Add("Tous"); // Add an "All" option
                using (var conn = new SqlConnection(connectionString))
                using (var adapter = new SqlDataAdapter("SELECT Nom FROM Commerciaux WHERE IsActive=1 ORDER BY Nom", conn))
                {
                    adapter.Fill(dt);
                }
                cmbVendeur.DataSource = dt;
                cmbVendeur.DisplayMember = "Nom";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading salespeople: " + ex.Message);
            }
        }

        private void btnPeriode_Click(object sender, EventArgs e)
        {
            // Show the context menu at the button's location
            btnPeriode.ContextMenuStrip = contextMenuPeriode;
            contextMenuPeriode.Show(btnPeriode, new Point(0, btnPeriode.Height));
        }

        private void SetDateRange(DateTime start, DateTime end)
        {
            dtpDateDebut.Value = start;
            dtpDateFin.Value = end;
            LoadData();
        }

        private void LoadData()
        {
            dgvSales.Rows.Clear();

            var queryBuilder = new StringBuilder(@"
                SELECT 
                    a.Article AS Code,
                    ti.ItemName,
                    SUM(ti.Quantity) AS TotalQuantity,
                    SUM(ti.TotalPrice) AS TotalValue,
                    p.Commission AS CommissionRate
                FROM Transactions t
                JOIN TransactionItems ti ON t.TransactionID = ti.TransactionID
                JOIN Articles a ON ti.ArticleID = a.Id
                LEFT JOIN Commerciaux c ON t.CreatedBy = c.Nom -- Assuming CreatedBy stores the name
                LEFT JOIN PDAs p ON c.CommercialID = p.CommercialID -- Join to get commission
                WHERE t.TransactionDate BETWEEN @StartDate AND @EndDate ");

            var parameters = new Dictionary<string, object>();
            parameters.Add("@StartDate", dtpDateDebut.Value.Date);
            parameters.Add("@EndDate", dtpDateFin.Value.Date.AddDays(1).AddSeconds(-1));

            if (cmbVendeur.Text != "Tous")
            {
                queryBuilder.Append(" AND c.Nom = @Vendeur");
                parameters.Add("@Vendeur", cmbVendeur.Text);
            }

            queryBuilder.Append(" GROUP BY a.Article, ti.ItemName, p.Commission ORDER BY ti.ItemName");

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
                            decimal totalValue = Convert.ToDecimal(reader["TotalValue"]);
                            decimal commissionRate = Convert.ToDecimal(reader["CommissionRate"] ?? 0);
                            decimal commissionAmount = totalValue * (commissionRate / 100);

                            dgvSales.Rows.Add(
                                reader["Code"],
                                reader["ItemName"],
                                reader["TotalQuantity"],
                                totalValue.ToString("N2"),
                                commissionRate.ToString("N2"),
                                commissionAmount.ToString("N2")
                            );
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading sales data: " + ex.Message);
            }
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}