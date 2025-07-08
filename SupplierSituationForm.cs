using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace TAPTAGPOS
{
    public partial class SupplierSituationForm : Form
    {
        private readonly string connectionString = DatabaseConnection.GetConnectionString();
        private int _supplierIdToLoad = 0; // To hold the ID passed from another form
                                           // --- FIX: Declare the ContextMenuStrip at the class level ---
        private ContextMenuStrip dateRangeMenu;


        public SupplierSituationForm(int supplierId = 0)
        {
            InitializeComponent();
            SetupForm();

            _supplierIdToLoad = supplierId;
            this.Load += SupplierSituationForm_Load;
            InitializeDateRangeMenu();
        }

        public SupplierSituationForm()
        {
            InitializeComponent();
            SetupForm();
            dataGridViewSituation.AutoGenerateColumns = false;
        }

        // Corrected constructor to receive a supplier ID


        private void SetupForm()
        {
            this.Load += SupplierSituationForm_Load;
            this.buttonView.Click += ButtonView_Click;
            this.buttonClose.Click += (s, e) => this.Close();
            this.comboBoxSupplier.SelectedIndexChanged += ComboBoxSupplier_SelectedIndexChanged;
            buttonPrint.Click += buttonPrint_Click;
            buttonItemDetails.Click += buttonItemDetails_Click;
            // --- FIX ---
            // Make the supplier dropdown visible, as it was hidden in the designer
            this.labelSupplier.Visible = true;
            this.comboBoxSupplier.Visible = true;
        }
        private void InitializeEventHandlers()
        {
            buttonView.Click += ButtonView_Click;
            buttonPrint.Click += buttonPrint_Click;
            buttonItemDetails.Click += buttonItemDetails_Click;
            buttonClose.Click += (s, e) => this.Close();
        }
        private void StyleDataGridView()
        {
            dataGridViewSituation.AutoGenerateColumns = false;
            // ... (Your other styling code for colors, fonts, etc. is good)

            // Correctly map the grid columns to the data we will load
            colCode.DataPropertyName = "Reference";
            colItem.DataPropertyName = "Type";
            colQuantity.DataPropertyName = "Debit";
            colTotal.DataPropertyName = "Credit";

            // Add new columns if they don't exist from the designer
            if (!dataGridViewSituation.Columns.Contains("colBalance"))
            {
                dataGridViewSituation.Columns.Add(new DataGridViewTextBoxColumn { Name = "colBalance", HeaderText = "Solde" });
            }
            dataGridViewSituation.Columns["colBalance"].DataPropertyName = "Solde";

            if (!dataGridViewSituation.Columns.Contains("colDate"))
            {
                dataGridViewSituation.Columns.Add(new DataGridViewTextBoxColumn { Name = "colDate", HeaderText = "Date" });
            }
            dataGridViewSituation.Columns["colDate"].DataPropertyName = "Date";
            dataGridViewSituation.Columns["colDate"].DisplayIndex = 0; // Move to the beginning

            // Add a hidden column to store the ID of the invoice or payment
            if (!dataGridViewSituation.Columns.Contains("ID"))
            {
                dataGridViewSituation.Columns.Add(new DataGridViewTextBoxColumn { Name = "ID", Visible = false });
            }
            dataGridViewSituation.Columns["ID"].DataPropertyName = "ID";

            // Format numeric and date columns
            string currencyFormat = "N2";
            dataGridViewSituation.Columns["colQuantity"].DefaultCellStyle.Format = currencyFormat;
            dataGridViewSituation.Columns["colTotal"].DefaultCellStyle.Format = currencyFormat;
            dataGridViewSituation.Columns["colBalance"].DefaultCellStyle.Format = currencyFormat;
            dataGridViewSituation.Columns["colDate"].DefaultCellStyle.Format = "dd/MM/yyyy";
        }

        private void SupplierSituationForm_Load(object sender, EventArgs e)
        {
            StyleDataGridView();
            InitializeEventHandlers();
            LoadSuppliersIntoComboBox();

            // If a specific supplier was passed to the form, select them
            if (_supplierIdToLoad > 0)
            {
                comboBoxSupplier.SelectedValue = _supplierIdToLoad;
                comboBoxSupplier.Enabled = false;
            }
        }

        private void LoadSuppliersIntoComboBox()
        {
            try
            {
                var dt = new DataTable();
                using (var conn = new SqlConnection(connectionString))
                {
                    var query = "SELECT SupplierID, Name FROM Suppliers WHERE Status = 'Active' ORDER BY Name";
                    var adapter = new SqlDataAdapter(query, conn);
                    adapter.Fill(dt);
                }

                // Add a "Select All" row at the very top
                DataRow dr = dt.NewRow();
                dr["SupplierID"] = 0; // Use 0 to represent "All"
                dr["Name"] = "-- Choisir un fournisseur --";
                dt.Rows.InsertAt(dr, 0);

                // --- These three lines are the key to making it work ---
                comboBoxSupplier.DataSource = dt;
                comboBoxSupplier.DisplayMember = "Name";       // The column to SHOW to the user
                comboBoxSupplier.ValueMember = "SupplierID";   // The hidden ID value of the item
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur chargement fournisseurs: " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // --- NEW: Event handler for the ComboBox ---
        private void ComboBoxSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            // When a supplier is selected, automatically show their situation.
            ButtonView_Click(sender, e);
        }

        private void ButtonView_Click(object sender, EventArgs e)
        {
            if (comboBoxSupplier.SelectedValue == null || !(comboBoxSupplier.SelectedValue is int) || (int)comboBoxSupplier.SelectedValue == 0)
            {
                // Clear the grid if no supplier is selected
                dataGridViewSituation.DataSource = null;
                textBoxTotalSum.Text = "0.00";
                return;
            }

            int supplierId = Convert.ToInt32(comboBoxSupplier.SelectedValue);
            DateTime startDate = dateTimePickerStartDate.Value.Date;
            DateTime endDate = dateTimePickerEndDate.Value.Date.AddDays(1).AddSeconds(-1);

            LoadSituation(supplierId, startDate, endDate);
        }

        private void LoadSituation(int supplierId, DateTime startDate, DateTime endDate)
        {
            DataTable situationData = new DataTable();
            situationData.Columns.Add("Date", typeof(DateTime));
            situationData.Columns.Add("Reference", typeof(string));
            situationData.Columns.Add("Type", typeof(string));
            situationData.Columns.Add("Debit", typeof(decimal));
            situationData.Columns.Add("Credit", typeof(decimal));
            situationData.Columns.Add("Solde", typeof(decimal));
            situationData.Columns.Add("ID", typeof(int)); // Hidden ID column

            try
            {
                using (var conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    decimal openingBalance = GetSupplierOpeningBalance(conn, supplierId, startDate);
                    situationData.Rows.Add(startDate.AddDays(-1), "Solde Initial", "", DBNull.Value, DBNull.Value, openingBalance, -1);

                    string query = @"
                        SELECT PurchaseDate AS Date, InvoiceNumber AS Reference, 'Facture Achat' AS Type, GrandTotal AS Amount, 'Debit' as TransactionType, InvoiceID as ID FROM PurchaseInvoices
                        WHERE SupplierID = @SupplierID AND PurchaseDate BETWEEN @StartDate AND @EndDate
                        UNION ALL
                        SELECT PaymentDate AS Date, ISNULL(DocumentNumber, 'Paiement #' + CAST(PaymentID AS nvarchar)), 'Paiement', Amount, 'Credit' as TransactionType, PaymentID as ID FROM SupplierPayments
                        WHERE SupplierID = @SupplierID AND PaymentDate BETWEEN @StartDate AND @EndDate
                        ORDER BY Date";

                    decimal runningBalance = openingBalance;

                    using (var cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@SupplierID", supplierId);
                        cmd.Parameters.AddWithValue("@StartDate", startDate);
                        cmd.Parameters.AddWithValue("@EndDate", endDate);
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string type = reader["TransactionType"].ToString();
                                decimal amount = Convert.ToDecimal(reader["Amount"]);
                                decimal debit = (type == "Debit") ? amount : 0;
                                decimal credit = (type == "Credit") ? amount : 0;
                                runningBalance = runningBalance + debit - credit;

                                situationData.Rows.Add(reader["Date"], reader["Reference"], reader["Type"], debit, credit, runningBalance, reader["ID"]);
                            }
                        }
                    }

                    dataGridViewSituation.DataSource = situationData;
                    FormatSituationGrid();
                    textBoxTotalSum.Text = runningBalance.ToString("N2");
                    textBoxTotalQuantity.Text = "";
                    buttonPrint.Enabled = true;
                    buttonItemDetails.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement de la situation: " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private decimal GetSupplierOpeningBalance(SqlConnection conn, int supplierId, DateTime forDate)
        {
            decimal balance = 0;
            string query = @"SELECT (SELECT ISNULL(SUM(GrandTotal), 0) FROM PurchaseInvoices WHERE SupplierID = @SupplierID AND PurchaseDate < @ForDate) - (SELECT ISNULL(SUM(Amount), 0) FROM SupplierPayments WHERE SupplierID = @SupplierID AND PaymentDate < @ForDate)";
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@SupplierID", supplierId);
                cmd.Parameters.AddWithValue("@ForDate", forDate);
                var result = cmd.ExecuteScalar();
                if (result != DBNull.Value) balance = Convert.ToDecimal(result);
            }
            return balance;
        }

        private void FormatSituationGrid()
        {
            // Use your existing column names
            dataGridViewSituation.Columns["colCode"].DataPropertyName = "Reference";
            dataGridViewSituation.Columns["colItem"].DataPropertyName = "Type";
            dataGridViewSituation.Columns["colQuantity"].DataPropertyName = "Debit";
            dataGridViewSituation.Columns["colTotal"].DataPropertyName = "Credit";

            // Add or use a Balance column
            if (!dataGridViewSituation.Columns.Contains("Solde"))
            {
                dataGridViewSituation.Columns.Add("Solde", "Solde");
            }
            dataGridViewSituation.Columns["Solde"].DataPropertyName = "Solde";

            // Add hidden ID column
            if (!dataGridViewSituation.Columns.Contains("ID"))
            {
                dataGridViewSituation.Columns.Add("ID", "ID");
            }
            dataGridViewSituation.Columns["ID"].DataPropertyName = "ID";
            dataGridViewSituation.Columns["ID"].Visible = false;

            // Re-label headers for clarity in this context
            dataGridViewSituation.Columns["colCode"].HeaderText = "Référence";
            dataGridViewSituation.Columns["colItem"].HeaderText = "Type";
            dataGridViewSituation.Columns["colQuantity"].HeaderText = "Débit";
            dataGridViewSituation.Columns["colTotal"].HeaderText = "Crédit";

            // Formatting
            string currencyFormat = "N2";
            dataGridViewSituation.Columns["colQuantity"].DefaultCellStyle.Format = currencyFormat;
            dataGridViewSituation.Columns["colTotal"].DefaultCellStyle.Format = currencyFormat;
            dataGridViewSituation.Columns["Solde"].DefaultCellStyle.Format = currencyFormat;
            dataGridViewSituation.Columns["Solde"].DefaultCellStyle.Font = new Font(this.Font, FontStyle.Bold);
        }
        private void InitializeDateRangeMenu()
        {
            dateRangeMenu = new ContextMenuStrip();

            var todayItem = new ToolStripMenuItem("اليوم");
            todayItem.Click += (s, e) => {
                dateTimePickerStartDate.Value = DateTime.Today;
                dateTimePickerEndDate.Value = DateTime.Today;
                ButtonView_Click(s, e); // Automatically refresh the view
            };

            var thisMonthItem = new ToolStripMenuItem("هذا الشهر");
            thisMonthItem.Click += (s, e) => {
                var today = DateTime.Today;
                dateTimePickerStartDate.Value = new DateTime(today.Year, today.Month, 1);
                dateTimePickerEndDate.Value = dateTimePickerStartDate.Value.AddMonths(1).AddDays(-1);
                ButtonView_Click(s, e);
            };

            var thisYearItem = new ToolStripMenuItem("هذه السنة");
            thisYearItem.Click += (s, e) => {
                var today = DateTime.Today;
                dateTimePickerStartDate.Value = new DateTime(today.Year, 1, 1);
                dateTimePickerEndDate.Value = new DateTime(today.Year, 12, 31);
                ButtonView_Click(s, e);
            };

            dateRangeMenu.Items.Add(todayItem);
            dateRangeMenu.Items.Add(thisMonthItem);
            dateRangeMenu.Items.Add(thisYearItem);
        }

        // --- REPLACE your empty buttonTimePeriod_Click with this ---
        private void buttonTimePeriod_Click(object sender, EventArgs e)
        {
            // Show the menu just below the button
            dateRangeMenu.Show(buttonTimePeriod, new Point(0, buttonTimePeriod.Height));
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            if (dataGridViewSituation.Rows.Count == 0) return;

            var headers = new List<string> { "Date", "Référence", "Type", "Débit", "Crédit", "Solde" };
            var columnWidths = new List<float> { 0.15f, 0.25f, 0.15f, 0.15f, 0.15f, 0.15f };

            var dtToPrint = new DataTable();
            foreach (string header in headers) { dtToPrint.Columns.Add(header); }

            foreach (DataGridViewRow row in dataGridViewSituation.Rows)
            {
                dtToPrint.Rows.Add(
                    row.Cells["colDate"].FormattedValue,
                    row.Cells["colCode"].FormattedValue,
                    row.Cells["colItem"].FormattedValue,
                    row.Cells["colQuantity"].FormattedValue,
                    row.Cells["colTotal"].FormattedValue,
                    row.Cells["colBalance"].FormattedValue
                );
            }

            var summary = new Dictionary<string, string> { { "Solde Final", textBoxTotalSum.Text } };
            string dateRange = $"Période: {dateTimePickerStartDate.Value:dd/MM/yyyy} - {dateTimePickerEndDate.Value:dd/MM/yyyy}";
            var printer = new ReportPrinter(dtToPrint, headers, columnWidths, $"Situation Fournisseur: {comboBoxSupplier.Text}", dateRange, summary);

            printer.Print(true); // Print in Landscape
        }
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void buttonItemDetails_Click(object sender, EventArgs e)
        {
            if (dataGridViewSituation.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner une ligne dans le tableau.", "Aucune Sélection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var selectedRow = dataGridViewSituation.SelectedRows[0];
            string type = selectedRow.Cells["colItem"].Value?.ToString();
            int id = Convert.ToInt32(selectedRow.Cells["ID"].Value);

            if (type == "Facture Achat")
            {
                // Open the Achat form in edit mode for this specific invoice
                Achat editPurchaseForm = new Achat(id);
                editPurchaseForm.ShowDialog(this);
                // After closing the edit form, refresh the data
                ButtonView_Click(sender, e);
            }
            else if (type == "Paiement")
            {
                // You can add logic here later to open a payment view form
                MessageBox.Show("Affichage des détails de paiement n'est pas encore implémenté.", "Information");
            }
        }
    }
}