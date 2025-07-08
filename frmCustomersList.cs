using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Text;
using System.Windows.Forms;

namespace TAPTAGPOS
{
    public partial class frmCustomersList : Form
    {
        private string connectionString = DatabaseConnection.GetConnectionString();
        private DataTable customerData; // To hold the main data for filtering
        private int printRowIndex = 0; // For printing pagination

        public int SelectedCustomerId { get; private set; }
        public string SelectedCustomerName { get; private set; }
        private bool _isSelectionMode = false;

        public frmCustomersList()
        {
            InitializeComponent();
            InitializeEvents();
        }

        public frmCustomersList(bool isSelectionMode) : this()
        {
            _isSelectionMode = isSelectionMode;
        }

        private void InitializeEvents()
        {
            this.Load += new System.EventHandler(this.frmCustomersList_Load);
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            this.dgvCustomers.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomers_CellDoubleClick);
            this.btnExit.Click += (s, e) => this.Close();
            this.cmbFilter.SelectedIndexChanged += new System.EventHandler(this.Filter_Changed);
            this.btnPrintList.Click += new System.EventHandler(this.btnPrintList_Click);
        }

        private void frmCustomersList_Load(object sender, EventArgs e)
        {
            if (_isSelectionMode)
            {
                this.Text = "Choisir un Client";
                pnlActions.Visible = true; // Hide action buttons in selection mode
                pnlFilter.Visible = false;  // Hide filter panel in selection mode
            }
            StyleDataGridView();
            LoadFilterOptions();
            LoadCustomersData();
        }

        #region Data Loading and Filtering

        private void StyleDataGridView()
        {
            dgvCustomers.AutoGenerateColumns = false;
            colID.DataPropertyName = "CustomerID";
            colCode.DataPropertyName = "CustomerID";
            colName.DataPropertyName = "CustomerName";
            colPhone.DataPropertyName = "Phone";
            colAddress.DataPropertyName = "Addresse";
            colCreditAllowed.DataPropertyName = "CreditAllowed";
            colDebtCeiling.DataPropertyName = "DebtCeiling";
            colDebtCeiling.DefaultCellStyle.Format = "N2";
        }

        private void LoadFilterOptions()
        {
            cmbFilter.Items.Clear();
            cmbFilter.Items.Add("Tous les clients");
            cmbFilter.Items.Add("Clients avec crédit");
            cmbFilter.Items.Add("Clients sans crédit");
            cmbFilter.SelectedIndex = 0;
        }

        private void LoadCustomersData()
        {
            try
            {
                customerData = new DataTable();
                string query = "SELECT CustomerID, CustomerName, Phone, Addresse, CreditAllowed, DebtCeiling FROM Customers WHERE ISNULL(IsActive, 1) = 1 ORDER BY CustomerName";

                using (var conn = new SqlConnection(connectionString))
                using (var adapter = new SqlDataAdapter(query, conn))
                {
                    adapter.Fill(customerData);
                }
                ApplyFilters();
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ في تحميل بيانات الزبناء: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Filter_Changed(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void ApplyFilters()
        {
            if (customerData == null) return;

            string filter = "1=1"; // Start with a filter that shows all rows
            switch (cmbFilter.SelectedIndex)
            {
                case 1: // Clients avec crédit
                    filter = "CreditAllowed = true";
                    break;
                case 2: // Clients sans crédit
                    filter = "CreditAllowed = false";
                    break;
            }

            customerData.DefaultView.RowFilter = filter;
            dgvCustomers.DataSource = customerData.DefaultView;
        }

        #endregion

        #region CRUD and Selection Logic

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (frmAddEditCustomer addForm = new frmAddEditCustomer())
            {
                if (addForm.ShowDialog(this) == DialogResult.OK)
                {
                    LoadCustomersData();
                }
            }
        }

        private void HandleEditAction()
        {
            if (dgvCustomers.SelectedRows.Count > 0)
            {
                int customerId = Convert.ToInt32(dgvCustomers.SelectedRows[0].Cells["colID"].Value);
                using (frmAddEditCustomer editForm = new frmAddEditCustomer(customerId))
                {
                    if (editForm.ShowDialog(this) == DialogResult.OK)
                    {
                        LoadCustomersData();
                    }
                }
            }
            else
            {
                MessageBox.Show("الرجاء تحديد زبون من القائمة لتعديله.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SelectCustomerAndClose()
        {
            if (dgvCustomers.SelectedRows.Count > 0)
            {
                var selectedRow = (dgvCustomers.SelectedRows[0].DataBoundItem as DataRowView).Row;
                this.SelectedCustomerId = Convert.ToInt32(selectedRow["CustomerID"]);
                this.SelectedCustomerName = selectedRow["CustomerName"].ToString();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            HandleEditAction();
        }

        private void dgvCustomers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (_isSelectionMode)
                {
                    SelectCustomerAndClose();
                }
                else
                {
                    HandleEditAction();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvCustomers.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("هل أنت متأكد من أنك تريد حذف هذا الزبون؟", "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    int customerId = Convert.ToInt32(dgvCustomers.SelectedRows[0].Cells["colID"].Value);
                    string query = "UPDATE Customers SET IsActive = 0 WHERE CustomerID = @CustomerID";
                    try
                    {
                        using (var conn = new SqlConnection(connectionString))
                        using (var cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@CustomerID", customerId);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            LoadCustomersData();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("حدث خطأ غير متوقع: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        #endregion

        #region Printing Logic
        private void btnPrintList_Click(object sender, EventArgs e)
        {
            if (dgvCustomers.Rows.Count == 0) return;
            printRowIndex = 0; // Reset for new print job

            PrintDocument pd = new PrintDocument();
            pd.DocumentName = "Liste des Clients";
            pd.DefaultPageSettings.Landscape = true;

            string printerName = AppSettingsManager.PrinterA4A5;
            if (!string.IsNullOrEmpty(printerName))
            {
                pd.PrinterSettings.PrinterName = printerName;
            }

            pd.PrintPage += PrintPage_Handler;

            PrintPreviewDialog preview = new PrintPreviewDialog { Document = pd, WindowState = FormWindowState.Maximized };
            preview.ShowDialog(this);
        }

        private void PrintPage_Handler(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            float yPos = e.MarginBounds.Top;
            float leftMargin = e.MarginBounds.Left;
            float pageWidth = e.MarginBounds.Width;
            float rowHeight = 30;

            using (Font titleFont = new Font("Arial", 16, FontStyle.Bold))
            using (Font headerFont = new Font("Arial", 10, FontStyle.Bold))
            using (Font bodyFont = new Font("Arial", 9))
            {
                g.DrawString("Liste des Clients", titleFont, Brushes.Black, leftMargin, yPos);
                yPos += 40;

                float[] colWidths = { 0.10f, 0.25f, 0.15f, 0.35f, 0.15f };
                string[] headers = { "Code", "Nom", "Téléphone", "Adresse", "Plafond Crédit" };
                float currentX = leftMargin;
                g.FillRectangle(Brushes.LightGray, leftMargin, yPos, pageWidth, rowHeight);
                for (int i = 0; i < headers.Length; i++)
                {
                    g.DrawString(headers[i], headerFont, Brushes.Black, currentX + 5, yPos + 5);
                    currentX += pageWidth * colWidths[i];
                }
                yPos += rowHeight;

                while (printRowIndex < dgvCustomers.Rows.Count)
                {
                    if (yPos + rowHeight > e.MarginBounds.Bottom)
                    {
                        e.HasMorePages = true;
                        return;
                    }
                    DataGridViewRow row = dgvCustomers.Rows[printRowIndex];
                    currentX = leftMargin;

                    string[] values = {
                        row.Cells["colCode"].FormattedValue.ToString(),
                        row.Cells["colName"].FormattedValue.ToString(),
                        row.Cells["colPhone"].FormattedValue.ToString(),
                        row.Cells["colAddress"].FormattedValue.ToString(),
                        row.Cells["colDebtCeiling"].FormattedValue.ToString()
                    };

                    for (int i = 0; i < values.Length; i++)
                    {
                        g.DrawString(values[i], bodyFont, Brushes.Black, currentX + 5, yPos + 5);
                        currentX += pageWidth * colWidths[i];
                    }
                    yPos += rowHeight;
                    printRowIndex++;
                }

                e.HasMorePages = false;
            }
        }
        #endregion
    }
}