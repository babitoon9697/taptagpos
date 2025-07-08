using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace TAPTAGPOS
{
    public partial class ClientSituationForm : Form
    {
        private readonly string connectionString = DatabaseConnection.GetConnectionString();

        public ClientSituationForm()
        {
            InitializeComponent();
            SetupForm();
        }

        // A new constructor to open the form for a specific, pre-selected customer
        public ClientSituationForm(int customerId) : this()
        {
            // The Load event will handle selecting this customer
            comboBoxClient.SelectedValue = customerId;
        }

        private void SetupForm()
        {
            this.Load += ClientSituationForm_Load;
            this.buttonConfirm.Click += ButtonConfirm_Click;
            this.buttonSelectClient.Click += ButtonSelectClient_Click;
            this.dataGridViewSituation.CellDoubleClick += DataGridViewSituation_CellDoubleClick;
            // You can add this event handler to a "Close" button if you have one
            // this.buttonClose.Click += (s, e) => this.Close(); 
        }

        private void ClientSituationForm_Load(object sender, EventArgs e)
        {
            LoadClientsIntoComboBox();
            // Set default date range to the current month
            dateTimePickerFrom.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dateTimePickerTo.Value = DateTime.Now;

            // If the form was opened for a specific client, automatically load their data
            if (comboBoxClient.SelectedIndex > 0)
            {
                ButtonConfirm_Click(sender, e);
            }
        }

        private void LoadClientsIntoComboBox()
        {
            try
            {
                using (var conn = new SqlConnection(connectionString))
                {
                    // Query to get all customers who are allowed credit
                    var query = "SELECT CustomerID, CustomerName FROM Customers WHERE IsActive = 1 AND CreditAllowed = 1 ORDER BY CustomerName";
                    var adapter = new SqlDataAdapter(query, conn);
                    var dt = new DataTable();
                    adapter.Fill(dt);

                    // Add a placeholder "Select" row at the top
                    DataRow dr = dt.NewRow();
                    dr["CustomerID"] = 0;
                    dr["CustomerName"] = "-- Choisir un client --";
                    dt.Rows.InsertAt(dr, 0);

                    comboBoxClient.DataSource = dt;
                    comboBoxClient.DisplayMember = "CustomerName";
                    comboBoxClient.ValueMember = "CustomerID";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur chargement clients: " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonSelectClient_Click(object sender, EventArgs e)
        {
            // Use the existing customer list form to find a customer
            using (var listForm = new frmCustomersList())
            {
                if (listForm.ShowDialog(this) == DialogResult.OK)
                {
                    comboBoxClient.SelectedValue = listForm.SelectedCustomerId;
                }
            }
        }

        private void ButtonConfirm_Click(object sender, EventArgs e)
        {
            if (comboBoxClient.SelectedValue == null || (int)comboBoxClient.SelectedValue == 0)
            {
                MessageBox.Show("Veuillez sélectionner un client.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int customerId = Convert.ToInt32(comboBoxClient.SelectedValue);
            DateTime startDate = dateTimePickerFrom.Value.Date;
            DateTime endDate = dateTimePickerTo.Value.Date.AddDays(1).AddSeconds(-1);

            LoadClientSituation(customerId, startDate, endDate);
        }

        private void LoadClientSituation(int customerId, DateTime startDate, DateTime endDate)
        {
            DataTable situationData = new DataTable();
            situationData.Columns.Add("Date", typeof(DateTime));
            situationData.Columns.Add("Operation", typeof(string));
            situationData.Columns.Add("Debit", typeof(decimal)); // Sales are a debit to the customer
            situationData.Columns.Add("Credit", typeof(decimal)); // Payments are a credit
            situationData.Columns.Add("Balance", typeof(decimal));
            situationData.Columns.Add("TransactionID", typeof(int)); // Hidden column

            try
            {
                using (var conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // 1. Get the opening balance for the customer before the start date
                    decimal openingBalance = GetClientOpeningBalance(conn, customerId, startDate);
                    situationData.Rows.Add(startDate.AddDays(-1), "Solde Initial", null, null, openingBalance, -1);

                    // 2. Use UNION ALL to get both sales and payments in one query, ordered by date
                    string query = @"
                        -- Get Sales (Debit)
                        SELECT 
                            TransactionDate AS Date, 
                            'Vente #' + CAST(TransactionID AS nvarchar) AS Operation, 
                            TotalAmount AS Amount,
                            'Debit' AS Type,
                            TransactionID
                        FROM Transactions
                        WHERE CustomerID = @CustomerID AND TransactionDate BETWEEN @StartDate AND @EndDate

                        UNION ALL

                        -- Get Payments (Credit)
                        SELECT 
                            PaymentDate AS Date, 
                            'Paiement ' + ISNULL(PaymentMethod, '') + ' #' + CAST(PaymentID AS nvarchar) AS Operation, 
                            Amount,
                            'Credit' AS Type,
                            TransactionID
                        FROM CustomerPayments
                        WHERE CustomerID = @CustomerID AND PaymentDate BETWEEN @StartDate AND @EndDate
                        
                        ORDER BY Date";

                    decimal runningBalance = openingBalance;

                    using (var cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@CustomerID", customerId);
                        cmd.Parameters.AddWithValue("@StartDate", startDate);
                        cmd.Parameters.AddWithValue("@EndDate", endDate);

                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string type = reader["Type"].ToString();
                                decimal amount = Convert.ToDecimal(reader["Amount"]);
                                decimal debit = 0;
                                decimal credit = 0;

                                if (type == "Debit")
                                {
                                    debit = amount;
                                    runningBalance += amount;
                                }
                                else // Credit
                                {
                                    credit = amount;
                                    runningBalance -= amount;
                                }
                                situationData.Rows.Add(
                                    reader["Date"],
                                    reader["Operation"],
                                    debit,
                                    credit,
                                    runningBalance,
                                    reader["TransactionID"] == DBNull.Value ? -1 : Convert.ToInt32(reader["TransactionID"])
                                );
                            }
                        }
                    }

                    dataGridViewSituation.DataSource = situationData;
                    FormatGrid();
                    textBoxCurrentDebt.Text = runningBalance.ToString("N2");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement de la situation client: " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private decimal GetClientOpeningBalance(SqlConnection conn, int customerId, DateTime forDate)
        {
            decimal openingBalance = 0;
            // The logic is: (Total Sales before date) - (Total Payments before date)
            string query = @"
                SELECT 
                    (SELECT ISNULL(SUM(TotalAmount), 0) FROM Transactions WHERE CustomerID = @CustomerID AND TransactionDate < @ForDate) -
                    (SELECT ISNULL(SUM(Amount), 0) FROM CustomerPayments WHERE CustomerID = @CustomerID AND PaymentDate < @ForDate)";

            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@CustomerID", customerId);
                cmd.Parameters.AddWithValue("@ForDate", forDate);
                var result = cmd.ExecuteScalar();
                if (result != DBNull.Value)
                {
                    openingBalance = Convert.ToDecimal(result);
                }
            }
            return openingBalance;
        }

        private void FormatGrid()
        {
            // Assign data properties to the correct columns
            dataGridViewSituation.Columns["colDate"].DataPropertyName = "Date";
            dataGridViewSituation.Columns["colOperation"].DataPropertyName = "Operation";
            dataGridViewSituation.Columns["colSale"].DataPropertyName = "Debit";
            dataGridViewSituation.Columns["colPayment"].DataPropertyName = "Credit";

            // Add or use the Balance column
            if (!dataGridViewSituation.Columns.Contains("colBalance"))
            {
                dataGridViewSituation.Columns.Add("colBalance", "Solde");
            }
            dataGridViewSituation.Columns["colBalance"].DataPropertyName = "Balance";

            // Hide the TransactionID column
            if (!dataGridViewSituation.Columns.Contains("TransactionID"))
            {
                dataGridViewSituation.Columns.Add("TransactionID", "TransactionID");
            }
            dataGridViewSituation.Columns["TransactionID"].DataPropertyName = "TransactionID";
            dataGridViewSituation.Columns["TransactionID"].Visible = false;

            // Formatting
            dataGridViewSituation.Columns["colSale"].DefaultCellStyle.Format = "N2";
            dataGridViewSituation.Columns["colPayment"].DefaultCellStyle.Format = "N2";
            dataGridViewSituation.Columns["colBalance"].DefaultCellStyle.Format = "N2";
            dataGridViewSituation.Columns["colBalance"].DefaultCellStyle.Font = new Font(this.Font, FontStyle.Bold);
        }

        private void DataGridViewSituation_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Check if the double-clicked row is a sale
                string operationType = dataGridViewSituation.Rows[e.RowIndex].Cells["colOperation"].Value.ToString();
                if (operationType.StartsWith("Vente"))
                {
                    int transactionId = Convert.ToInt32(dataGridViewSituation.Rows[e.RowIndex].Cells["TransactionID"].Value);
                    if (transactionId > 0)
                    {
                        // Open the Caisse form in edit mode for this specific transaction
                        using (var caisseForm = new Caisse(transactionId))
                        {
                            caisseForm.ShowDialog(this);
                        }
                        // Refresh the data after editing
                        ButtonConfirm_Click(sender, e);
                    }
                }
            }
        }

        private void ButtonPrint_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La fonctionnalité d'impression n'est pas encore implémentée.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}