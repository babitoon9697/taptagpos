using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

// Ensure this namespace matches your project's name
namespace TAPTAGPOS
{
    public partial class paycreditclient : Form
    {
        #region Fields and Properties

        // Get the connection string from your central class
        private readonly string _connectionString = DatabaseConnection.GetConnectionString();

        // A data-bound list to hold the debt items shown in the grid.
        // Using BindingList automatically updates the DataGridView when items are added, removed, or changed.
        private BindingList<DebtInvoiceItem> _debtItems;

        #endregion

        #region Constructor and Form Load

        public paycreditclient()
        {
            InitializeComponent();
            SetupEventHandlers();
        }

        /// <summary>
        /// Wires up all necessary event handlers for the form controls.
        /// </summary>
        private void SetupEventHandlers()
        {
            this.Load += paycreditclient_Load;
            this.cmbCustomer.SelectionChangeCommitted += cmbCustomer_SelectionChangeCommitted;

            // DataGridView events for interactive checkbox and totals calculation
            this.dgvDebts.CurrentCellDirtyStateChanged += dgvDebts_CurrentCellDirtyStateChanged;
            this.dgvDebts.CellValueChanged += dgvDebts_CellValueChanged;

            // Button click events
            this.btnSelectAll.Click += btnSelectAll_Click;
            this.btnDeselectAll.Click += btnDeselectAll_Click;
            this.btnConfirm.Click += btnConfirm_Click;
            this.btnCancel.Click += btnCancel_Click;
            this.btnPrintList.Click += btnPrintList_Click;
        }

        /// <summary>
        /// Handles the form's Load event. Marked as async to allow for non-blocking UI.
        /// </summary>
        private async void paycreditclient_Load(object sender, EventArgs e)
        {
            // Set the DataGridView to not generate columns automatically, as we've defined them in the designer.
            dgvDebts.AutoGenerateColumns = false;
            await LoadCustomersIntoComboBoxAsync();
        }

        #endregion

        #region Data Loading Methods

        /// <summary>
        /// Asynchronously loads all customers from the database into the ComboBox.
        /// </summary>
        private async Task LoadCustomersIntoComboBoxAsync()
        {
            var customers = new List<CustomerListItem>
            {
                // Add a default, non-selectable item
                new CustomerListItem { CustomerID = 0, CustomerName = "--- اختر زبون ---" }
            };

            string query = "SELECT CustomerID, CustomerName FROM dbo.Customers ORDER BY CustomerName;";

            try
            {
                using (var conn = new SqlConnection(_connectionString))
                {
                    await conn.OpenAsync();
                    using (var cmd = new SqlCommand(query, conn))
                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            customers.Add(new CustomerListItem
                            {
                                CustomerID = reader.GetInt32(reader.GetOrdinal("CustomerID")),
                                CustomerName = reader.GetString(reader.GetOrdinal("CustomerName"))
                            });
                        }
                    }
                }

                cmbCustomer.DataSource = customers;
                cmbCustomer.DisplayMember = nameof(CustomerListItem.CustomerName);
                cmbCustomer.ValueMember = nameof(CustomerListItem.CustomerID);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while fetching the customer list: " + ex.Message, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Asynchronously loads all debt details for a selected customer.
        /// </summary>
        private async Task LoadCustomerDebtDetailsAsync(int customerId)
        {
            // Clear previous data
            dgvDebts.DataSource = null;
            txtDebt.Text = "0.00";

            // Part 1: Get the total debt amount from the Customers table
            try
            {
                string queryTotalDebt = "SELECT AmountDue FROM dbo.Customers WHERE CustomerID = @CustomerID;";
                using (var conn = new SqlConnection(_connectionString))
                {
                    await conn.OpenAsync();
                    using (var cmd = new SqlCommand(queryTotalDebt, conn))
                    {
                        cmd.Parameters.AddWithValue("@CustomerID", customerId);
                        var result = await cmd.ExecuteScalarAsync();
                        txtDebt.Text = (result != null && result != DBNull.Value) ? Convert.ToDecimal(result).ToString("N2") : "0.00";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching total debt: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Part 2: Fetch the list of unpaid invoices and bind to the DataGridView
            var unpaidInvoices = new List<DebtInvoiceItem>();
            string queryUnpaidInvoices = @"
                SELECT 
                    TR.TicketID,
                    T.ticket_date AS InvoiceDate, 
                    TR.TotalAmount, 
                    TR.AmountPaid,
                    (TR.TotalAmount - TR.AmountPaid) AS RemainingAmount
                FROM dbo.Transactions TR
                JOIN dbo.Ticket T ON TR.TicketID = T.id_ticket
                WHERE TR.CustomerID = @CustomerID AND (TR.TotalAmount - TR.AmountPaid) > 0.001
                ORDER BY T.ticket_date DESC;";

            try
            {
                using (var conn = new SqlConnection(_connectionString))
                {
                    await conn.OpenAsync();
                    using (var cmd = new SqlCommand(queryUnpaidInvoices, conn))
                    {
                        cmd.Parameters.AddWithValue("@CustomerID", customerId);
                        using (var reader = await cmd.ExecuteReaderAsync())
                        {
                            while (await reader.ReadAsync())
                            {
                                unpaidInvoices.Add(new DebtInvoiceItem
                                {
                                    TicketID = reader.GetInt32(reader.GetOrdinal("TicketID")),
                                    InvoiceDate = reader.GetDateTime(reader.GetOrdinal("InvoiceDate")),
                                    TotalAmount = reader.GetDecimal(reader.GetOrdinal("TotalAmount")),
                                    AmountPaid = reader.GetDecimal(reader.GetOrdinal("AmountPaid")),
                                    RemainingAmount = reader.GetDecimal(reader.GetOrdinal("RemainingAmount")),
                                    CurrentPayment = 0 // Initialize current payment to 0
                                });
                            }
                        }
                    }
                }

                // Use BindingList for two-way data binding with the DataGridView
                _debtItems = new BindingList<DebtInvoiceItem>(unpaidInvoices);
                dgvDebts.DataSource = _debtItems;

                // Manually map DataGridView columns to the properties of the DebtInvoiceItem class
                colSelect.DataPropertyName = nameof(DebtInvoiceItem.IsSelected);
                colCurrentPayment.DataPropertyName = nameof(DebtInvoiceItem.CurrentPayment);
                colRemaining.DataPropertyName = nameof(DebtInvoiceItem.RemainingAmount);
                colOldPayment.DataPropertyName = nameof(DebtInvoiceItem.AmountPaid);
                colTotal.DataPropertyName = nameof(DebtInvoiceItem.TotalAmount);
                colInvoice.DataPropertyName = nameof(DebtInvoiceItem.TicketID);
                colDate.DataPropertyName = nameof(DebtInvoiceItem.InvoiceDate);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching unpaid invoices: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region UI Event Handlers

        private async void cmbCustomer_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmbCustomer.SelectedIndex > 0 && cmbCustomer.SelectedValue is int customerId)
            {
                await LoadCustomerDebtDetailsAsync(customerId);
            }
            else
            {
                // Clear the form if no customer is selected
                _debtItems?.Clear();
                txtDebt.Text = "0.00";
                RecalculateTotals();
            }
        }

        // --- DataGridView Interaction ---
        private void dgvDebts_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvDebts.IsCurrentCellDirty)
            {
                dgvDebts.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void dgvDebts_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure the change is on the checkbox column and the data source is valid
            if (e.ColumnIndex == colSelect.Index && e.RowIndex >= 0 && _debtItems != null)
            {
                DebtInvoiceItem item = _debtItems[e.RowIndex];
                item.CurrentPayment = item.IsSelected ? item.RemainingAmount : 0;
                RecalculateTotals();
            }
        }

        // --- Button Events ---
        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            if (_debtItems == null) return;
            foreach (var item in _debtItems)
            {
                item.IsSelected = true;
                item.CurrentPayment = item.RemainingAmount;
            }
            RecalculateTotals();
        }

        private void btnDeselectAll_Click(object sender, EventArgs e)
        {
            if (_debtItems == null) return;
            foreach (var item in _debtItems)
            {
                item.IsSelected = false;
                item.CurrentPayment = 0;
            }
            RecalculateTotals();
        }

        private async void btnConfirm_Click(object sender, EventArgs e)
        {
            // --- 1. Validate Inputs ---
            if (!(cmbCustomer.SelectedValue is int customerId) || customerId <= 0)
            {
                MessageBox.Show("Please select a customer.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var invoicesToPay = _debtItems?.Where(item => item.IsSelected).ToList();
            if (invoicesToPay == null || !invoicesToPay.Any())
            {
                MessageBox.Show("Please select at least one invoice to pay.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string paymentMethod = GetSelectedPaymentMethod();
            if (string.IsNullOrEmpty(paymentMethod))
            {
                MessageBox.Show("Please select a payment method.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal totalPaid = invoicesToPay.Sum(i => i.CurrentPayment);

            // --- 2. Confirm with User ---
            var confirmation = MessageBox.Show($"Are you sure you want to register a payment of {totalPaid:N2} for {cmbCustomer.Text}?", "Confirm Payment", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmation == DialogResult.No) return;

            // --- 3. Execute Database Transaction ---
            bool success = await SavePaymentTransactionAsync(customerId, totalPaid, paymentMethod, txtNotes.Text, invoicesToPay);

            // --- 4. Handle Result ---
            if (success)
            {
                MessageBox.Show("Payment was successfully registered.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await LoadCustomerDebtDetailsAsync(customerId); // Refresh the UI
                RecalculateTotals();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrintList_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Print functionality has not been implemented yet.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #endregion

        #region Business Logic and Helper Methods

        /// <summary>
        /// Recalculates the total payment amount from the selected items in the grid.
        /// </summary>
        private void RecalculateTotals()
        {
            decimal currentPaymentTotal = _debtItems?.Where(item => item.IsSelected).Sum(item => item.CurrentPayment) ?? 0m;
            txtPayment.Text = currentPaymentTotal.ToString("N2");
            txtTotalSum.Text = currentPaymentTotal.ToString("N2");
        }

        /// <summary>
        /// Gets the selected payment method text from the radio buttons.
        /// </summary>
        private string GetSelectedPaymentMethod()
        {
            if (rbCash.Checked) return "Cash";
            if (rbCreditCard.Checked) return "Credit Card";
            if (rbCheck.Checked) return "Check";
            if (rbBankTransfer.Checked) return "Bank Transfer";
            if (rbEffect.Checked) return "Effet";
            return null;
        }

        /// <summary>
        /// Saves the entire payment operation within a single database transaction.
        /// </summary>
        /// <returns>True if the transaction was successful, otherwise false.</returns>
        private async Task<bool> SavePaymentTransactionAsync(int customerId, decimal totalPaid, string paymentMethod, string notes, List<DebtInvoiceItem> invoices)
        {
            using (var conn = new SqlConnection(_connectionString))
            {
                await conn.OpenAsync();
                using (var transaction = conn.BeginTransaction())
                {
                    try
                    {
                        // Step 1: Insert a master record into a new CustomerPayments table for auditing.
                        string insertPaymentQuery = @"
                            INSERT INTO CustomerPayments (CustomerID, PaymentDate, TotalAmount, PaymentMethod, Notes)
                            VALUES (@CustomerID, GETDATE(), @TotalAmount, @PaymentMethod, @Notes);";

                        using (var cmd = new SqlCommand(insertPaymentQuery, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@CustomerID", customerId);
                            cmd.Parameters.AddWithValue("@TotalAmount", totalPaid);
                            cmd.Parameters.AddWithValue("@PaymentMethod", paymentMethod);
                            cmd.Parameters.AddWithValue("@Notes", notes);
                            await cmd.ExecuteNonQueryAsync();
                        }

                        // Step 2: Loop through each selected invoice and update its record.
                        foreach (var invoice in invoices)
                        {
                            string updateTransQuery = @"
                                UPDATE dbo.Transactions 
                                SET AmountPaid = AmountPaid + @AmountToPay 
                                WHERE TicketID = @TicketID;";
                            using (var cmd = new SqlCommand(updateTransQuery, conn, transaction))
                            {
                                cmd.Parameters.AddWithValue("@AmountToPay", invoice.CurrentPayment);
                                cmd.Parameters.AddWithValue("@TicketID", invoice.TicketID);
                                await cmd.ExecuteNonQueryAsync();
                            }
                        }

                        // Step 3: Update the customer's total due amount.
                        string updateCustomerQuery = @"
                            UPDATE dbo.Customers 
                            SET AmountDue = AmountDue - @TotalPaid 
                            WHERE CustomerID = @CustomerID;";
                        using (var cmd = new SqlCommand(updateCustomerQuery, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@TotalPaid", totalPaid);
                            cmd.Parameters.AddWithValue("@CustomerID", customerId);
                            await cmd.ExecuteNonQueryAsync();
                        }

                        // If all commands succeeded, commit the transaction.
                        transaction.Commit();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        // If any command fails, roll back the entire transaction.
                        transaction.Rollback();
                        MessageBox.Show("Failed to save the payment due to a database error:\n" + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
        }

        #endregion
    }

    #region Helper/Model Classes

    /// <summary>
    /// Represents a customer item in the ComboBox.
    /// </summary>
    public class CustomerListItem
    {
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
    }

    /// <summary>
    /// Represents an invoice item in the DataGridView.
    /// Implements INotifyPropertyChanged to support live UI updates with BindingList.
    /// </summary>
    public class DebtInvoiceItem : INotifyPropertyChanged
    {
        private bool _isSelected;
        private decimal _currentPayment;

        public int TicketID { get; set; }
        public DateTime InvoiceDate { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal AmountPaid { get; set; }
        public decimal RemainingAmount { get; set; }

        public bool IsSelected
        {
            get => _isSelected;
            set
            {
                if (_isSelected != value)
                {
                    _isSelected = value;
                    OnPropertyChanged(nameof(IsSelected));
                }
            }
        }

        public decimal CurrentPayment
        {
            get => _currentPayment;
            set
            {
                if (_currentPayment != value)
                {
                    _currentPayment = value;
                    OnPropertyChanged(nameof(CurrentPayment));
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    #endregion
}