using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace TAPTAGPOS
{
    public partial class FormSituationArticlesProduits : Form
    {
        private string connectionString = DatabaseConnection.GetConnectionString();

        public FormSituationArticlesProduits()
        {
            InitializeComponent();
            // Link events in the constructor
            this.Load += FormSituationArticlesProduits_Load;
            this.btnFiltrer.Click += btnFiltrer_Click;
            // You can also add a "Show All" button that calls LoadData() with no parameters
        }

        private void FormSituationArticlesProduits_Load(object sender, EventArgs e)
        {
            // Set a default date range for the last month
            dtpDateDebut.Value = DateTime.Now.AddMonths(-1);
            dtpDateFin.Value = DateTime.Now;

            LoadComboBoxes();
            LoadData(); // Load initial data
        }

        private void LoadComboBoxes()
        {
            // Load Machines
            try
            {
                var dtMachines = new DataTable();
                dtMachines.Columns.Add("MachineName");
                dtMachines.Rows.Add("Toutes"); // All Machines option
                using (var conn = new SqlConnection(connectionString))
                using (var adapter = new SqlDataAdapter("SELECT MachineName FROM Machines WHERE IsActive=1", conn))
                {
                    adapter.Fill(dtMachines);
                }
                cmbMachine.DataSource = dtMachines;
                cmbMachine.DisplayMember = "MachineName";
            }
            catch (Exception ex) { MessageBox.Show("Error loading machines: " + ex.Message); }

            // Load Responsables
            try
            {
                var dtResponsables = new DataTable();
                dtResponsables.Columns.Add("Nom");
                dtResponsables.Rows.Add("Tous"); // All Responsables option
                using (var conn = new SqlConnection(connectionString))
                using (var adapter = new SqlDataAdapter("SELECT Nom FROM Commerciaux WHERE IsActive=1", conn))
                {
                    adapter.Fill(dtResponsables);
                }
                cmbResponsable.DataSource = dtResponsables;
                cmbResponsable.DisplayMember = "Nom";
            }
            catch (Exception ex) { MessageBox.Show("Error loading responsables: " + ex.Message); }
        }

        private void btnFiltrer_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            dgvSituation.Rows.Clear();

            var queryBuilder = new StringBuilder(@"
                SELECT 
                    a.Article AS Reference,
                    a.ArticleLongName AS Designation,
                    SUM(ofp.QuantityExpected) AS QtePrevue,
                    SUM(ofp.QuantityProduced) AS QteProduite,
                    SUM(ofp.QuantityProduced - ofp.QuantityExpected) AS Ecart
                FROM OF_ProduitsFinis ofp
                JOIN Articles a ON ofp.ArticleID = a.Id
                JOIN OrdresFabrication ofab ON ofp.OrderID = ofab.OrderID
                WHERE ofab.IsActive = 1 ");

            var parameters = new Dictionary<string, object>();

            // --- Dynamic Filtering Logic ---
            queryBuilder.Append(" AND ofab.StartDate BETWEEN @StartDate AND @EndDate");
            parameters.Add("@StartDate", dtpDateDebut.Value.Date);
            parameters.Add("@EndDate", dtpDateFin.Value.Date.AddDays(1).AddSeconds(-1));

            if (cmbMachine.Text != "Toutes")
            {
                queryBuilder.Append(" AND ofab.Machine = @Machine");
                parameters.Add("@Machine", cmbMachine.Text);
            }
            if (cmbResponsable.Text != "Tous")
            {
                queryBuilder.Append(" AND ofab.Responsable = @Responsable");
                parameters.Add("@Responsable", cmbResponsable.Text);
            }

            queryBuilder.Append(" GROUP BY a.Article, a.ArticleLongName ORDER BY a.Article");

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
                            dgvSituation.Rows.Add(
                                reader["Reference"],
                                reader["Designation"],
                                reader["QtePrevue"],
                                reader["QteProduite"],
                                reader["Ecart"]
                            );
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading production data: " + ex.Message);
            }
        }
    }
}