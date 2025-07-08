using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TAPTAGPOS
{
    public partial class ClientChecksForm : Form
    {
        private string connectionString = DatabaseConnection.GetConnectionString();
        private ContextMenuStrip bulkUpdateMenu;
        private ContextMenuStrip dateRangeMenu;
        private ClientChecksReportData _currentCheckReportData;
        private int printRowIndex = 0;
        private int pageNumber = 1;
        private DataTable checksData; // Use a DataTable to hold all data for filtering

        public ClientChecksForm()
        {
            InitializeComponent();
            InitializeBulkUpdateMenu();
            InitializeDateRangeMenu();
            InitializeContextMenu();
            
            this.Load += ClientChecksForm_Load;
        }
        // In ClientChecksForm.cs

        private void StyleDataGridView()
        {
            // --- General Style Settings (Your existing code is good) ---
            dataGridViewChecks.AutoGenerateColumns = false;
            dataGridViewChecks.BorderStyle = BorderStyle.None;
            dataGridViewChecks.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 247, 251);
            dataGridViewChecks.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewChecks.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 122, 204);
            dataGridViewChecks.DefaultCellStyle.SelectionForeColor = Color.Black;
            dataGridViewChecks.BackgroundColor = Color.White;
            dataGridViewChecks.RowHeadersVisible = false;
            dataGridViewChecks.EnableHeadersVisualStyles = false;
            dataGridViewChecks.DefaultCellStyle.Font = new Font("Segoe UI", 9.75F);
            dataGridViewChecks.RowTemplate.Height = 30;

            // Header Style
            dataGridViewChecks.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            var headerStyle = new DataGridViewCellStyle
            {
                BackColor = Color.FromArgb(45, 52, 54),
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                Alignment = DataGridViewContentAlignment.MiddleCenter
            };
            dataGridViewChecks.ColumnHeadersDefaultCellStyle = headerStyle;
            dataGridViewChecks.ColumnHeadersHeight = 40;

            // --- START OF FIX: Linking Grid Columns to Database Columns ---
            // This is the part that was missing. It tells each column which data to display.
            // The string names like "CheckID" must exactly match the column names from your SQL query.
            dataGridViewChecks.Columns["colCheckID"].DataPropertyName = "CheckID";
            dataGridViewChecks.Columns["colCustomerName"].DataPropertyName = "CustomerName";
            dataGridViewChecks.Columns["colCheckNumber"].DataPropertyName = "CheckNumber";
            dataGridViewChecks.Columns["colBank"].DataPropertyName = "BankName";
            dataGridViewChecks.Columns["colDueDate"].DataPropertyName = "DueDate";
            dataGridViewChecks.Columns["colAmount"].DataPropertyName = "Amount";
            dataGridViewChecks.Columns["colIsPaid"].DataPropertyName = "IsPaid";
            dataGridViewChecks.Columns["colIsTransferred"].DataPropertyName = "IsTransferred";
            dataGridViewChecks.Columns["colStatus"].DataPropertyName = "Status";
            // --- END OF FIX ---

            // Format the numeric and date columns
            dataGridViewChecks.Columns["colAmount"].DefaultCellStyle.Format = "C2"; // Format as currency
            dataGridViewChecks.Columns["colDueDate"].DefaultCellStyle.Format = "dd/MM/yyyy";
        }
        private void InitializeDateRangeMenu()
        {
            dateRangeMenu = new ContextMenuStrip();

            var todayItem = new ToolStripMenuItem("اليوم");
            todayItem.Click += (s, e) => {
                dateTimePickerStartDate.Value = DateTime.Today;
                dateTimePickerEndDate.Value = DateTime.Today;
                LoadChecksData(); // Reload data after changing dates
            };

            var thisMonthItem = new ToolStripMenuItem("هذا الشهر");
            thisMonthItem.Click += (s, e) => {
                var today = DateTime.Today;
                dateTimePickerStartDate.Value = new DateTime(today.Year, today.Month, 1);
                dateTimePickerEndDate.Value = dateTimePickerStartDate.Value.AddMonths(1).AddDays(-1);
                LoadChecksData();
            };

            var thisYearItem = new ToolStripMenuItem("هذه السنة");
            thisYearItem.Click += (s, e) => {
                var today = DateTime.Today;
                dateTimePickerStartDate.Value = new DateTime(today.Year, 1, 1);
                dateTimePickerEndDate.Value = new DateTime(today.Year, 12, 31);
                LoadChecksData();
            };

            dateRangeMenu.Items.Add(todayItem);
            dateRangeMenu.Items.Add(thisMonthItem);
            dateRangeMenu.Items.Add(thisYearItem);
        }
        private void ClientChecksForm_Load(object sender, EventArgs e)
        {

            StyleDataGridView();
            // Connect event handlers
            buttonValidate.Click += (s, ev) => ApplyFilters();
            comboBoxClient.SelectedIndexChanged += (s, ev) => ApplyFilters();
            checkBoxAll.CheckedChanged += FilterCheckBox_CheckedChanged;
            checkBoxPaid.CheckedChanged += FilterCheckBox_CheckedChanged;
            checkBoxTransferred.CheckedChanged += FilterCheckBox_CheckedChanged;
            dateTimePickerStartDate.Value = DateTime.Now.AddMonths(-3); // Default to last 3 months
            dateTimePickerEndDate.Value = DateTime.Now;
            checkBoxAll.Checked = true; // --- FIX: Show ALL checks by default ---
            InitializeNoResultsLabel();
            LoadClients();
            LoadChecksData();
           
        }

        #region Data Loading and Filtering
        private void LoadClients()
        {
            try
            {
                var dt = new DataTable();
                dt.Columns.Add("CustomerID", typeof(int));
                dt.Columns.Add("CustomerName", typeof(string));
                dt.Rows.Add(0, "Tous"); // "All" option

                using (var conn = new SqlConnection(connectionString))
                using (var adapter = new SqlDataAdapter("SELECT CustomerID, CustomerName FROM Customers ORDER BY CustomerName", conn))
                {
                    adapter.Fill(dt);
                }
                comboBoxClient.DataSource = dt;
                comboBoxClient.DisplayMember = "CustomerName";
                comboBoxClient.ValueMember = "CustomerID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading clients: " + ex.Message);
            }
        }
        private void MarkAsPaid_Click(object sender, EventArgs e)
        {
            UpdateChecksStatus(isPaid: true, isTransferred: false, statusText: "Payé");
        }

        private void MarkAsTransferred_Click(object sender, EventArgs e)
        {
            UpdateChecksStatus(isPaid: false, isTransferred: true, statusText: "Transféré");
        }

  
        private void UpdateChecksStatus(bool isPaid, bool isTransferred, string statusText)
        {
            var selectedChecks = new List<Tuple<int, int, decimal>>(); // CheckID, CustomerID, Amount
            foreach (DataGridViewRow row in dataGridViewChecks.SelectedRows)
            {
                var viewRow = (DataRowView)row.DataBoundItem;
                selectedChecks.Add(Tuple.Create(
                    Convert.ToInt32(viewRow["CheckID"]),
                    Convert.ToInt32(viewRow["CustomerID"]),
                    Convert.ToDecimal(viewRow["Amount"])
                ));
            }

            if (MessageBox.Show($"Mettre à jour {selectedChecks.Count} chèque(s) vers '{statusText}'?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                var transaction = conn.BeginTransaction();
                try
                {
                    foreach (var check in selectedChecks)
                    {
                        string query = "UPDATE ClientChecks SET IsPaid = @IsPaid, IsTransferred = @IsTransferred, Status = @Status WHERE CheckID = @CheckID";
                        using (var cmd = new SqlCommand(query, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@IsPaid", isPaid);
                            cmd.Parameters.AddWithValue("@IsTransferred", isTransferred);
                            cmd.Parameters.AddWithValue("@Status", statusText);
                            cmd.Parameters.AddWithValue("@CheckID", check.Item1);
                            cmd.ExecuteNonQuery();
                        }

                        // --- IMPORTANT: Update customer debt if the check is marked as paid ---
                        if (isPaid)
                        {
                            string debtQuery = "UPDATE Customers SET AmountDue = AmountDue - @Amount WHERE CustomerID = @CustomerID";
                            using (var debtCmd = new SqlCommand(debtQuery, conn, transaction))
                            {
                                debtCmd.Parameters.AddWithValue("@Amount", check.Item3); // Cheque Amount
                                debtCmd.Parameters.AddWithValue("@CustomerID", check.Item2); // Customer ID
                                debtCmd.ExecuteNonQuery();
                            }
                        }
                    }
                    transaction.Commit();
                    MessageBox.Show("Mise à jour réussie.");
                    LoadChecksData();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Failed to update checks: " + ex.Message, "Error");
                }
            }
        }
        private Label lblNoResults; // NEW: Label for showing "No results" message

        private void InitializeNoResultsLabel()
        {
            lblNoResults = new Label
            {
                Text = "Aucun chèque trouvé pour les filtres actuels.",
                AutoSize = false,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Segoe UI", 12F, FontStyle.Italic),
                ForeColor = Color.Gray,
                Visible = false,
                Dock = DockStyle.Fill
            };
            dataGridViewChecks.Controls.Add(lblNoResults);
        }

        private void LoadChecksData()
        {
            checksData = new DataTable();
            string query = "SELECT cc.*, c.CustomerName FROM ClientChecks cc JOIN Customers c ON cc.CustomerID = c.CustomerID";
            try
            {
                using (var adapter = new SqlDataAdapter(query, connectionString))
                {
                    adapter.Fill(checksData);
                }
                dataGridViewChecks.DataSource = checksData;
                ApplyFilters();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading checks: " + ex.Message);
            }
        }

        private void ApplyFilters()
        {
            if (checksData == null) return;
            var filter = new StringBuilder();

            // Date Filter
            filter.Append($"ReceivedDate >= '{dateTimePickerStartDate.Value.Date:yyyy-MM-dd}' AND ReceivedDate <= '{dateTimePickerEndDate.Value.AddDays(1).AddSeconds(-1).Date:yyyy-MM-dd}'");

            // Client Filter
            if (comboBoxClient.SelectedValue != null && (int)comboBoxClient.SelectedValue > 0)
            {
                filter.Append($" AND CustomerID = {(int)comboBoxClient.SelectedValue}");
            }

            // Status Filter
            if (!checkBoxAll.Checked)
            {
                var statusFilters = new List<string>();
                if (checkBoxPaid.Checked) statusFilters.Add("IsPaid = 1");
                else statusFilters.Add("IsPaid = 0");
                if (checkBoxTransferred.Checked) statusFilters.Add("IsTransferred = 1");
                else statusFilters.Add("IsTransferred = 0");

                if (statusFilters.Any())
                    filter.Append($" AND ({string.Join(" OR ", statusFilters)})");

            }

            checksData.DefaultView.RowFilter = filter.ToString();

            // --- NEW: Show a message if the grid is empty after filtering ---
            if (dataGridViewChecks.Rows.Count == 0)
            {
                lblNoResults.Visible = true;
            }
            else
            {
                lblNoResults.Visible = false;
            }

            CalculateTotals();
        }
        private void FilterCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox changedCheckBox = sender as CheckBox;
            if (changedCheckBox.Checked)
            {
                if (changedCheckBox == checkBoxAll)
                {
                    checkBoxPaid.Checked = false;
                    checkBoxTransferred.Checked = false;
                }
                else
                {
                    checkBoxAll.Checked = false;
                }
            }
            ApplyFilters();
        }
        #endregion

        #region UI Event Handlers
        private void InitializeContextMenu()
        {
            bulkUpdateMenu = new ContextMenuStrip();
            var markAsPaidItem = new ToolStripMenuItem("Marquer comme Soldé (تسديد)");
            var markAsTransferredItem = new ToolStripMenuItem("Marquer comme Transféré (تحويل)");
            markAsPaidItem.Click += (s, e) => UpdateChecksStatus(true, false, "Payé");
            markAsTransferredItem.Click += (s, e) => UpdateChecksStatus(false, true, "Transféré");
            bulkUpdateMenu.Items.AddRange(new ToolStripItem[] { markAsPaidItem, markAsTransferredItem });
        }
        // When any filter is changed, reload the data
        private void buttonValidate_Click(object sender, EventArgs e)
        {
            LoadChecksData();
        }


        private void CalculateTotals()
        {
            int countTotal = 0, countPaid = 0, countTransferred = 0;
            decimal amountTotal = 0m, amountPaid = 0m, amountTransferred = 0m;

            foreach (DataGridViewRow row in dataGridViewChecks.Rows)
            {
                countTotal++;
                amountTotal += Convert.ToDecimal(row.Cells["colAmount"].Value);

                if (Convert.ToBoolean(row.Cells["colIsPaid"].Value))
                {
                    countPaid++;
                    amountPaid += Convert.ToDecimal(row.Cells["colAmount"].Value);
                }
                if (Convert.ToBoolean(row.Cells["colIsTransferred"].Value))
                {
                    countTransferred++;
                    amountTransferred += Convert.ToDecimal(row.Cells["colAmount"].Value);
                }
            }

            textBoxCountTotal.Text = countTotal.ToString();
            textBoxCountPaid.Text = countPaid.ToString();
            textBoxCountTransferred.Text = countTransferred.ToString();
            textBoxCountRemaining.Text = (countTotal - countPaid - countTransferred).ToString();

            textBoxAmountTotal.Text = amountTotal.ToString("C2");
            textBoxAmountPaid.Text = amountPaid.ToString("C2");
            textBoxAmountTransferred.Text = amountTransferred.ToString("C2");
            textBoxAmountRemaining.Text = (amountTotal - amountPaid - amountTransferred).ToString("C2");
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            // This button saves changes made to the IsPaid and IsTransferred checkboxes in the grid
            try
            {
                using (var conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    foreach (DataGridViewRow row in dataGridViewChecks.Rows)
                    {
                        int checkId = (int)row.Tag;
                        bool isPaid = Convert.ToBoolean(row.Cells["colIsPaid"].Value);
                        bool isTransferred = Convert.ToBoolean(row.Cells["colIsTransferred"].Value);

                        string query = "UPDATE ClientChecks SET IsPaid = @IsPaid, IsTransferred = @IsTransferred WHERE CheckID = @CheckID";
                        using (var cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@IsPaid", isPaid);
                            cmd.Parameters.AddWithValue("@IsTransferred", isTransferred);
                            cmd.Parameters.AddWithValue("@CheckID", checkId);
                            cmd.ExecuteNonQuery();
                        }
                    }
                }
                MessageBox.Show("Changes saved successfully!");
                LoadChecksData(); // Refresh to reflect any server-side logic
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving changes: " + ex.Message);
            }
        }
        private void InitializeBulkUpdateMenu()
        {
            bulkUpdateMenu = new ContextMenuStrip();

            var markAsPaidItem = new ToolStripMenuItem("Marquer comme Soldé (تسديد)");
            markAsPaidItem.Click += MarkAsPaid_Click; // ربط بوظيفة التسديد

            var markAsTransferredItem = new ToolStripMenuItem("Marquer comme Transféré (تحويل)");
            markAsTransferredItem.Click += MarkAsTransferred_Click; // ربط بوظيفة التحويل

            bulkUpdateMenu.Items.Add(markAsPaidItem);
            bulkUpdateMenu.Items.Add(markAsTransferredItem);
        }
        private void buttonSolderOuTransferer_Click(object sender, EventArgs e)
        {
            if (dataGridViewChecks.SelectedRows.Count == 0)
            {
                MessageBox.Show("الرجاء تحديد شيك واحد على الأقل.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            bulkUpdateMenu.Show(buttonSolderOuTransferer, new Point(0, buttonSolderOuTransferer.Height));
        }

        #endregion

        private void buttonPeriod_Click(object sender, EventArgs e)
        {
            dateRangeMenu.Show(buttonPeriod, new Point(0, buttonPeriod.Height));
        }

        public class ClientCheckPrintItem
        {
            public string CheckNumber { get; set; }
            public string BankName { get; set; }
            public string DueDate { get; set; }
            public decimal Amount { get; set; }
            public string Status { get; set; }
            public string ClientName { get; set; }
        }

        public class ClientChecksReportData
        {
            public string ReportTitle { get; set; } = "Situation des Chèques Client";
            public string DateRange { get; set; }
            public DateTime PrintDate { get; set; }
            public List<ClientCheckPrintItem> Items { get; set; } = new List<ClientCheckPrintItem>();

            // Summary Fields
            public int TotalCount { get; set; }
            public decimal TotalAmount { get; set; }
            public int PaidCount { get; set; }
            public decimal PaidAmount { get; set; }
        }
        // In ClientChecksForm.cs

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            if (dataGridViewChecks.Rows.Count == 0) return;

            // 1. Define Headers and their widths
            var headers = new List<string> { "Client", "N° Chèque", "Banque", "Montant", "Statut" };
            var columnWidths = new List<float> { 0.30f, 0.20f, 0.20f, 0.15f, 0.15f };

            // 2. Create a table with only the visible data from the grid
            var dtToPrint = new DataTable();
            foreach (string header in headers) { dtToPrint.Columns.Add(header); }

            foreach (DataGridViewRow row in dataGridViewChecks.Rows)
            {
                if (row.Visible)
                {
                    dtToPrint.Rows.Add(
                        row.Cells["colCustomerName"].FormattedValue,
                        row.Cells["colCheckNumber"].FormattedValue,
                        row.Cells["colBank"].FormattedValue,
                        row.Cells["colAmount"].FormattedValue,
                        row.Cells["colStatus"].FormattedValue
                    );
                }
            }

            // 3. Create a dictionary for the summary totals
            var summary = new Dictionary<string, string>
            {
                { "Total Chèques", textBoxAmountTotal.Text },
                { "Total Payé", textBoxAmountPaid.Text },
                { "Total Restant", textBoxAmountRemaining.Text }
            };

            // 4. Create the printer and call Print(), now with all the correct arguments
            string dateRange = $"Période: {dateTimePickerStartDate.Value:dd/MM/yyyy} - {dateTimePickerEndDate.Value:dd/MM/yyyy}";
            var printer = new ReportPrinter(dtToPrint, headers, columnWidths, "Rapport des Chèques Clients", dateRange, summary);

            printer.Print(true); // 'true' for Landscape
        }
        private void InitiateCheckReportPrint()
        {
            printRowIndex = 0; // Reset for a new print job
            pageNumber = 1;

            printDocument1.DocumentName = "Situation des Chèques";
            printDocument1.DefaultPageSettings.Landscape = true; // Set to Landscape as requested

            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void dateTimePickerStartDate_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePickerStartDate.Value.ToString("dd-MM-yyyy") == dateTimePickerEndDate.Value.ToString("dd-MM-yyyy"))
            {
                dateTimePickerEndDate.Value = dateTimePickerStartDate.Value.AddDays(1);
            }
        }

        private void dateTimePickerEndDate_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePickerStartDate.Value.ToString("dd-MM-yyyy") == dateTimePickerEndDate.Value.ToString("dd-MM-yyyy"))
            {
                dateTimePickerEndDate.Value = dateTimePickerStartDate.Value.AddDays(1);
            }
        }
    }
}