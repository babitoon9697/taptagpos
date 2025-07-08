using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace TAPTAGPOS
{
    public partial class FormReleveBancaire : Form
    {
        private string connectionString = DatabaseConnection.GetConnectionString();

        public FormReleveBancaire()
        {
            InitializeComponent();
            InitializeEventHandlers();
        }

        private void InitializeEventHandlers()
        {
            this.Load += FormReleveBancaire_Load;
            this.btnValider.Click += (s, e) => LoadData();
            // Add click events for btnPeriode and btnImprimer when ready
        }

        private void FormReleveBancaire_Load(object sender, EventArgs e)
        {
            dtpDateDebut.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtpDateFin.Value = DateTime.Now;
            LoadComptes();
        }

        private void LoadComptes()
        {
            try
            {
                var dt = new DataTable();
                using (var conn = new SqlConnection(connectionString))
                using (var adapter = new SqlDataAdapter("SELECT BanqueID, NomBanque FROM Banques WHERE IsActive=1 ORDER BY NomBanque", conn))
                {
                    adapter.Fill(dt);
                }
                cmbCompte.DataSource = dt;
                cmbCompte.DisplayMember = "NomBanque";
                cmbCompte.ValueMember = "BanqueID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading bank accounts: " + ex.Message);
            }
        }

        private void LoadData()
        {
            if (cmbCompte.SelectedValue == null)
            {
                MessageBox.Show("Veuillez sélectionner un compte bancaire.");
                return;
            }

            dgvStatement.Rows.Clear();
            int banqueId = (int)cmbCompte.SelectedValue;
            DateTime startDate = dtpDateDebut.Value.Date;
            DateTime endDate = dtpDateFin.Value.Date.AddDays(1).AddSeconds(-1);
            decimal runningBalance = 0;

            // This is the query to get the initial balance BEFORE the start date
            string queryInitialBalance = @"
        SELECT ISNULL(SUM(Credit - Debit), 0) 
        FROM MouvementsBancaires 
        WHERE BanqueID = @BanqueID AND MouvementDate < @StartDate AND IsActive = 1;";

            // This query gets all transactions WITHIN the date range
            string queryTransactions = @"
        SELECT MouvementDate, Libelle, NumeroPiece, Debit, Credit 
        FROM MouvementsBancaires
        WHERE BanqueID = @BanqueID AND MouvementDate BETWEEN @StartDate AND @EndDate AND IsActive = 1
        ORDER BY MouvementDate ASC, MouvementID ASC;";

            try
            {
                using (var conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // --- Step 1: Execute the first query to get the initial balance ---
                    using (var cmdInitial = new SqlCommand(queryInitialBalance, conn))
                    {
                        cmdInitial.Parameters.AddWithValue("@BanqueID", banqueId);
                        cmdInitial.Parameters.AddWithValue("@StartDate", startDate);
                        object initialBalanceResult = cmdInitial.ExecuteScalar();
                        if (initialBalanceResult != DBNull.Value)
                        {
                            runningBalance = Convert.ToDecimal(initialBalanceResult);
                        }
                    }

                    // Add the initial balance row to the grid
                    dgvStatement.Rows.Add(
                        null, "Solde Initial", "", null, null, runningBalance.ToString("N2")
                    );

                    // --- Step 2: Execute the second query to get the transactions ---
                    using (var cmdTransactions = new SqlCommand(queryTransactions, conn))
                    {
                        cmdTransactions.Parameters.AddWithValue("@BanqueID", banqueId);
                        cmdTransactions.Parameters.AddWithValue("@StartDate", startDate);
                        cmdTransactions.Parameters.AddWithValue("@EndDate", endDate);

                        using (var reader = cmdTransactions.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                decimal credit = Convert.ToDecimal(reader["Credit"]);
                                decimal debit = Convert.ToDecimal(reader["Debit"]);
                                runningBalance += credit - debit; // Update the running balance

                                dgvStatement.Rows.Add(
                                    ((DateTime)reader["MouvementDate"]).ToShortDateString(),
                                    reader["Libelle"],
                                    reader["NumeroPiece"],
                                    debit > 0 ? debit.ToString("N2") : "",
                                    credit > 0 ? credit.ToString("N2") : "",
                                    runningBalance.ToString("N2")
                                );
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading bank statement: " + ex.Message);
            }
        }
    }
}