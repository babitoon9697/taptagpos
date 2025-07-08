using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace TAPTAGPOS
{
    public partial class frmAddSupplierPayment : Form
    {
        private int _preselectedSupplierId = 0;
        private readonly string connectionString = DatabaseConnection.GetConnectionString();

        public frmAddSupplierPayment()
        {
            InitializeComponent();
        }

        public frmAddSupplierPayment(int supplierId) : this()
        {
            _preselectedSupplierId = supplierId;
        }

        private void frmAddSupplierPayment_Load(object sender, EventArgs e)
        {
            LoadSuppliersAndSetSelection();
        }

        private void LoadSuppliersAndSetSelection()
        {
            try
            {
                var dt = new DataTable();
                string query = "SELECT SupplierID, Name FROM Suppliers WHERE Status = 'Active' ORDER BY Name";

                using (var conn = new SqlConnection(connectionString))
                using (var adapter = new SqlDataAdapter(query, conn))
                {
                    adapter.Fill(dt);
                }

                DataRow dr = dt.NewRow();
                dr["SupplierID"] = 0;
                dr["Name"] = "اختر مورد...";
                dt.Rows.InsertAt(dr, 0);

                cmbSupplier.DataSource = dt;
                cmbSupplier.DisplayMember = "Name";
                cmbSupplier.ValueMember = "SupplierID";

                if (_preselectedSupplierId > 0)
                {
                    cmbSupplier.SelectedValue = _preselectedSupplierId;
                    cmbSupplier.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ في تحميل الموردين: " + ex.Message);
            }
        }

        // --- START OF FIX ---
        // This is the corrected event handler that prevents the crash.
        private void cmbSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            int supplierId = 0;
            // Safely check and convert the SelectedValue
            if (cmbSupplier.SelectedValue != null && cmbSupplier.SelectedValue != DBNull.Value)
            {
                // This correctly handles the conversion from the underlying data type.
                if (int.TryParse(cmbSupplier.SelectedValue.ToString(), out int id))
                {
                    supplierId = id;
                }
            }

            if (supplierId > 0)
            {
                // A valid supplier is selected, so load their invoices.
                LoadUnpaidInvoices(supplierId);
            }
            else
            {
                // No supplier is selected, so clear the grid.
                dgvUnpaidInvoices.DataSource = null;
            }
        }
        // --- END OF FIX ---

        private void LoadUnpaidInvoices(int supplierId)
        {
            string query = @"
                SELECT 
                    InvoiceID, InvoiceNumber, PurchaseDate, GrandTotal, AmountPaid, 
                    (GrandTotal - ISNULL(AmountPaid, 0)) AS AmountDue
                FROM PurchaseInvoices 
                WHERE SupplierID = @SupplierID AND (GrandTotal - ISNULL(AmountPaid, 0)) > 0.01
                ORDER BY PurchaseDate ASC";

            try
            {
                var dt = new DataTable();
                using (var conn = new SqlConnection(connectionString))
                using (var adapter = new SqlDataAdapter(query, conn))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@SupplierID", supplierId);
                    adapter.Fill(dt);
                    dgvUnpaidInvoices.DataSource = dt;
                    if (dgvUnpaidInvoices.Columns.Contains("InvoiceID") && dgvUnpaidInvoices.Columns["InvoiceID"] != null)
                    {
                        dgvUnpaidInvoices.Columns["InvoiceID"].Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ في جلب الفواتير غير المدفوعة: " + ex.Message);
            }
        }

        private void dgvUnpaidInvoices_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvUnpaidInvoices.SelectedRows.Count > 0)
            {
                var selectedRow = dgvUnpaidInvoices.SelectedRows[0];
                decimal amountDue = Convert.ToDecimal(selectedRow.Cells["AmountDue"].Value);
                txtPaymentAmount.Text = amountDue.ToString("F2");
            }
        }

        // --- START OF FIX: Corrected Save Logic ---
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            // 1. Validation
            if (dgvUnpaidInvoices.SelectedRows.Count == 0)
            {
                MessageBox.Show("الرجاء تحديد فاتورة لتسديدها.");
                return;
            }
            if (!decimal.TryParse(txtPaymentAmount.Text, out decimal paymentAmount) || paymentAmount <= 0)
            {
                MessageBox.Show("الرجاء إدخال مبلغ صحيح للدفع.");
                return;
            }

            var selectedRow = dgvUnpaidInvoices.SelectedRows[0];
            int invoiceId = Convert.ToInt32(selectedRow.Cells["InvoiceID"].Value);
            int supplierId = (int)cmbSupplier.SelectedValue;
            decimal amountDue = Convert.ToDecimal(selectedRow.Cells["AmountDue"].Value);

            if (paymentAmount > amountDue)
            {
                MessageBox.Show("المبلغ المدفوع أكبر من المبلغ المتبقي على الفاتورة.");
                return;
            }

            // 2. Database Transaction
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();
                try
                {
                    string paymentMethod = grpPaymentMethod.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked)?.Text ?? "N/A";

                    // STEP A: Insert the payment record, linking it to the specific invoice
                    string queryPay = "INSERT INTO SupplierPayments (SupplierID, PaymentDate, Amount, InvoiceID, PaymentMethod, DocumentNumber, Notes) VALUES (@SID, @Date, @Amount, @InvID, @Method, @DocNum, @Notes)";
                    using (SqlCommand cmd = new SqlCommand(queryPay, conn, transaction))
                    {
                        cmd.Parameters.AddWithValue("@SID", supplierId);
                        cmd.Parameters.AddWithValue("@Date", DateTime.Today);
                        cmd.Parameters.AddWithValue("@Amount", paymentAmount);
                        cmd.Parameters.AddWithValue("@InvID", invoiceId);
                        cmd.Parameters.AddWithValue("@Method", paymentMethod);
                        cmd.Parameters.AddWithValue("@DocNum", txtDocumentNumber.Text);
                        cmd.Parameters.AddWithValue("@Notes", txtNotes.Text);
                        cmd.ExecuteNonQuery();
                    }

                    // STEP B: Update the PurchaseInvoices table to reflect the payment
                    string queryInv = "UPDATE PurchaseInvoices SET AmountPaid = ISNULL(AmountPaid, 0) + @Amount WHERE InvoiceID = @InvID";
                    using (SqlCommand cmd = new SqlCommand(queryInv, conn, transaction))
                    {
                        cmd.Parameters.AddWithValue("@Amount", paymentAmount);
                        cmd.Parameters.AddWithValue("@InvID", invoiceId);
                        cmd.ExecuteNonQuery();
                    }

                    // STEP C: If the payment covers the remaining amount, mark the invoice as 'Paid'
                    if (paymentAmount >= amountDue)
                    {
                        string queryStatus = "UPDATE PurchaseInvoices SET PaymentStatus = 'Paid', AmountPaid = ISNULL(AmountPaid, 0) + @Amount WHERE InvoiceID = @InvID";
                        using (SqlCommand cmd = new SqlCommand(queryStatus, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@InvID", invoiceId);
                            cmd.Parameters.AddWithValue("@Amount", paymentAmount);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    // STEP D: Update the supplier's total debt in the main Suppliers table
                    string querySupplier = "UPDATE Suppliers SET [CurrentBalance] = ISNULL([CurrentBalance], 0) - @Amount WHERE SupplierID = @SID";
                    using (SqlCommand cmd = new SqlCommand(querySupplier, conn, transaction))
                    {
                        cmd.Parameters.AddWithValue("@Amount", paymentAmount);
                        cmd.Parameters.AddWithValue("@SID", supplierId);
                        cmd.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    MessageBox.Show("تم تسجيل الدفعة بنجاح!");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("فشل حفظ الدفعة: " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        // --- END OF FIX ---
        private void btnClose_Click(object sender, EventArgs e) => this.Close();
    }
}