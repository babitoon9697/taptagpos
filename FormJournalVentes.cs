using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TAPTAGPOS
{
    public partial class FormJournalVentes : Form
    {
        private string connectionString = DatabaseConnection.GetConnectionString();

        public FormJournalVentes()
        {
            InitializeComponent();
            InitializeEventHandlers();
        }

        private void InitializeEventHandlers()
        {
            this.Load += FormJournalVentes_Load;
            this.btnValider.Click += (s, e) => LoadData();
            this.chkTous.CheckedChanged += chkTous_CheckedChanged;
            // You can add logic for the Period and Print buttons here later
        }

        private void FormJournalVentes_Load(object sender, EventArgs e)
        {
            dtpDateDebut.Value = DateTime.Now.Date;
            dtpDateFin.Value = DateTime.Now.Date;
            LoadVendeurs();
            LoadData();
        }

        private void LoadVendeurs()
        {
            try
            {
                var dt = new DataTable();
                dt.Columns.Add("Nom");
                dt.Rows.Add("Tous"); // Add an "All" option to see sales from everyone

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

        private void chkTous_CheckedChanged(object sender, EventArgs e)
        {
            bool isChecked = chkTous.Checked;
            chkCredit.Checked = isChecked;
            chkEspece.Checked = isChecked;
            chkCarteCredit.Checked = isChecked;
            chkCheque.Checked = isChecked;
        }

        private void LoadData()
        {
            dgvJournal.Rows.Clear();
            decimal totalEspece = 0, totalCheque = 0, totalCarte = 0, totalCredit = 0;

            // --- Build the dynamic SQL query based on filters ---
            var queryBuilder = new StringBuilder(@"
        SELECT t.TransactionDate, t.TicketID, c.CustomerName, 
               t.Cash, t.CreditCard, t.Cheque, t.Loan
        FROM Transactions t
        JOIN Customers c ON t.CustomerID = c.CustomerID
        WHERE t.TransactionDate BETWEEN @StartDate AND @EndDate AND t.AmountPaid > 0 ");

            var parameters = new Dictionary<string, object>();
            parameters.Add("@StartDate", dtpDateDebut.Value.Date);
            parameters.Add("@EndDate", dtpDateFin.Value.Date.AddDays(1).AddSeconds(-1));

            if (cmbVendeur.Text != "Tous" && cmbVendeur.SelectedIndex > 0)
            {
                queryBuilder.Append(" AND t.CreatedBy = @Vendeur");
                parameters.Add("@Vendeur", cmbVendeur.Text);
            }

            var paymentFilters = new List<string>();
            if (chkEspece.Checked) paymentFilters.Add("t.Cash > 0");
            if (chkCarteCredit.Checked) paymentFilters.Add("t.CreditCard > 0");
            if (chkCheque.Checked) paymentFilters.Add("t.Cheque > 0");
            if (chkCredit.Checked) paymentFilters.Add("t.Loan > 0");

            if (paymentFilters.Any() && !chkTous.Checked)
            {
                queryBuilder.Append($" AND ({string.Join(" OR ", paymentFilters)})");
            }

            queryBuilder.Append(" ORDER BY t.TransactionDate DESC");

            // --- Execute the query and populate the grid ---
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
                            decimal cash = Convert.ToDecimal(reader["Cash"]);
                            decimal card = Convert.ToDecimal(reader["CreditCard"]);
                            decimal cheque = Convert.ToDecimal(reader["Cheque"]);
                            decimal loan = Convert.ToDecimal(reader["Loan"]);

                            // Add a row for each payment type that has a value
                            if (cash > 0) dgvJournal.Rows.Add(reader["TransactionDate"], reader["TicketID"], reader["CustomerName"], "Espèce", cash.ToString("N2"));
                            if (card > 0) dgvJournal.Rows.Add(reader["TransactionDate"], reader["TicketID"], reader["CustomerName"], "Carte Crédit", card.ToString("N2"));
                            if (cheque > 0) dgvJournal.Rows.Add(reader["TransactionDate"], reader["TicketID"], reader["CustomerName"], "Chèque", cheque.ToString("N2"));
                            if (loan > 0) dgvJournal.Rows.Add(reader["TransactionDate"], reader["TicketID"], reader["CustomerName"], "Crédit", loan.ToString("N2"));

                            // Sum up the totals
                            totalEspece += cash;
                            totalCarte += card;
                            totalCheque += cheque;
                            totalCredit += loan;
                        }
                    }
                }

                // --- Update the footer textboxes ---
                txtTotalEspece.Text = totalEspece.ToString("N2");
                txtTotalCarte.Text = totalCarte.ToString("N2");
                txtTotalCheque.Text = totalCheque.ToString("N2");
                txtTotalCredit.Text = totalCredit.ToString("N2");
                txtTotal.Text = (totalEspece + totalCarte + totalCheque + totalCredit).ToString("N2");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading sales journal: " + ex.Message);
            }
        }
    }
}