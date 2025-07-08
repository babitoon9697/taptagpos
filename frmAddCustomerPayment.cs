using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Windows.Forms;

namespace TAPTAGPOS
{
    public partial class frmAddCustomerPayment : Form
    {
        private string connectionString = DatabaseConnection.GetConnectionString();
        private int _customerId;
        private string _customerName;

        public frmAddCustomerPayment()
        {
            InitializeComponent();
            InitializeDateRangeMenu();
            StyleDataGridView(this.dgvInvoices);
        }

        public frmAddCustomerPayment(int customerId, string customerName) : this()
        {
            _customerId = customerId;
            _customerName = customerName;
        }

        private void frmAddCustomerPayment_Load(object sender, EventArgs e)
        {
            dtpMainDate.Value = DateTime.Now;
            LoadCustomers();

            if (_customerId > 0)
            {
                cmbCustomer.SelectedValue = _customerId;
                cmbCustomer.Enabled = false;
                btnSelectCustomer.Enabled = false;
            }
        }

        // --- 1. تحميل قائمة الزبناء ---
        private void LoadCustomers()
        {
            try
            {
                var dt = new DataTable();
                dt.Columns.Add("CustomerID", typeof(int));
                dt.Columns.Add("CustomerName", typeof(string));
                dt.Rows.Add(0, "اختر زبون...");

                string query = "SELECT CustomerID, CustomerName FROM Customers WHERE ISNULL(AmountDue, 0) > 0 ORDER BY CustomerName";
                using (var conn = new SqlConnection(connectionString))
                using (var adapter = new SqlDataAdapter(query, conn))
                {
                    adapter.Fill(dt);
                }
                cmbCustomer.DataSource = dt;
                cmbCustomer.DisplayMember = "CustomerName";
                cmbCustomer.ValueMember = "CustomerID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ في تحميل قائمة الزبناء: " + ex.Message);
            }
        }

        // --- 2. جلب الفواتير عند اختيار زبون ---
        private void cmbCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCustomer.SelectedValue != null && int.TryParse(cmbCustomer.SelectedValue.ToString(), out int custId) && custId > 0)
            {
                _customerId = custId;
                LoadUnpaidInvoices(custId);
            }
            else
            {
                dgvInvoices.Rows.Clear();
                UpdateTotals();
            }
        }

        private void LoadUnpaidInvoices(int customerId)
        {
            dgvInvoices.Rows.Clear();
            decimal totalDebt = 0;
            string query = @"
                SELECT TransactionID, TransactionDate, TotalAmount, ISNULL(AmountPaid, 0) as AmountPaid, 
                       (TotalAmount - ISNULL(AmountPaid, 0)) AS AmountDue
                FROM Transactions 
                WHERE CustomerID = @CustomerID AND (PaymentStatus IS NULL OR PaymentStatus <> 'Paid') AND Loan > 0
                ORDER BY TransactionDate ASC";

            try
            {
                using (var conn = new SqlConnection(connectionString))
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@CustomerID", customerId);
                    conn.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            decimal amountDue = Convert.ToDecimal(reader["AmountDue"]);
                            dgvInvoices.Rows.Add(
                                false, // colSelect
                                Convert.ToDateTime(reader["TransactionDate"]).ToShortDateString(),
                                reader["TransactionID"],
                                Convert.ToDecimal(reader["TotalAmount"]),
                                Convert.ToDecimal(reader["AmountPaid"]),
                                amountDue,
                                0.00m
                            );
                            totalDebt += amountDue;
                        }
                    }
                }
                txtDebt.Text = totalDebt.ToString("N2");
                UpdateTotals();
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ في جلب فواتير الزبون: " + ex.Message);
            }
        }

        // --- 3 & 4. تحديث الحسابات عند تغيير التحديد ---
        private void dgvInvoices_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (this.Visible && e.ColumnIndex == dgvInvoices.Columns["colSelect"].Index && e.RowIndex >= 0)
            {
                UpdateTotals();
            }
        }

        private void dgvInvoices_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvInvoices.IsCurrentCellDirty)
            {
                dgvInvoices.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void UpdateTotals()
        {
            decimal totalToPay = 0;
            foreach (DataGridViewRow row in dgvInvoices.Rows)
            {
                if (Convert.ToBoolean(row.Cells["colSelect"].Value) == true)
                {
                    totalToPay += Convert.ToDecimal(row.Cells["colRemaining"].Value);
                }
            }
            txtSum.Text = totalToPay.ToString("N2");
            txtPayment.Text = totalToPay.ToString("N2");
        }

        // --- 5. منطق الحفظ الكامل ---
        #region Save Logic (Complete & Corrected)

        private void btnConfirmPayment_Click(object sender, EventArgs e)
        {
            var selectedRows = dgvInvoices.Rows.Cast<DataGridViewRow>()
                .Where(r => Convert.ToBoolean(r.Cells["colSelect"].Value) == true).ToList();

            if (!selectedRows.Any()) { MessageBox.Show("Veuillez sélectionner au moins une facture."); return; }
            if (!decimal.TryParse(txtPayment.Text, out decimal totalPaymentAmount) || totalPaymentAmount <= 0) { MessageBox.Show("Veuillez entrer un montant de paiement valide."); return; }

            string paymentMethod = grpPaymentMethod.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked)?.Text ?? "Espèces";

            if (paymentMethod.Equals("شيك", StringComparison.OrdinalIgnoreCase))
            {
                ProcessChequePayment(totalPaymentAmount, selectedRows);
            }
            else
            {
                ProcessCashOrCardPayment(totalPaymentAmount, paymentMethod, selectedRows);
            }
        }
        private int? GetCurrentSessionId()
        {
            string query = "SELECT TOP 1 SessionID FROM PosSessions WHERE Status = 'Open'";
            using (var conn = new SqlConnection(connectionString))
            using (var cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                object result = cmd.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    return Convert.ToInt32(result);
                }
            }
            return null; // Return null if no session is open
        }
        private void ProcessCashOrCardPayment(decimal amount, string method, List<DataGridViewRow> rows)
        {  // First, check for an open session. A payment cannot be made otherwise.
            int? sessionId = GetCurrentSessionId();
            if (sessionId == null)
            {
                MessageBox.Show("Impossible d'enregistrer un paiement. Aucune session de caisse n'est ouverte.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                var transaction = conn.BeginTransaction();
                try
                {
                    CreatePaymentTransaction(conn, transaction, sessionId.Value, amount, method);


                    // 1. Log the main payment record
                    //LogCustomerPayment(conn, transaction, amount, method, txtDocumentNumber.Text, txtNotes.Text);
                    // 2. Distribute payment across invoices
                    DistributePaymentToInvoices(conn, transaction, amount, rows);
                    // 3. Update customer's total debt
                    UpdateCustomerDebt(conn, transaction, _customerId, -amount); // Subtract payment from debt

                    transaction.Commit();
                    MessageBox.Show("Paiement enregistré avec succès!");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Échec de l'enregistrement du paiement: " + ex.Message, "Erreur");
                }
            }
        }

        private void ProcessChequePayment(decimal totalChequeAmount, List<DataGridViewRow> rows)
        {
            int? sessionId = GetCurrentSessionId();
            if (sessionId == null)
            {
                MessageBox.Show("Impossible d'enregistrer un paiement. Aucune session de caisse n'est ouverte.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string doc = txtDocumentNumber.Text;
            string bankname = txtBank.Text;
            using (var chequeForm = new ChequePaiement(totalChequeAmount, doc,bankname))
            {
                if (chequeForm.ShowDialog(this) != DialogResult.OK) return;

                var newChequeInfo = new ChequeInfo
                {
                    Amount = chequeForm.AmountPaid,
                    BankName = chequeForm.BankName,
                    CheckNumber = chequeForm.CheckNumber,
                    DueDate = chequeForm.DueDate,
                    PayerName = chequeForm.PayerName
                };

                using (var conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    var transaction = conn.BeginTransaction();
                    try
                    {
                        int paymentTransactionId = CreatePaymentTransaction(conn, transaction, sessionId.Value, newChequeInfo.Amount, "Chèque");

                        // 1. Log the cheque details
                        //LogCustomerCheque(conn, transaction, 0, newChequeInfo);
                        // 2. Distribute payment across invoices
                        DistributePaymentToInvoices(conn, transaction, newChequeInfo.Amount, rows);
                        // 3. Update customer's total debt
                        UpdateCustomerDebt(conn, transaction, _customerId, -newChequeInfo.Amount);

                        transaction.Commit();
                        MessageBox.Show("Paiement par chèque enregistré avec succès!");
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Échec de l'enregistrement du chèque: " + ex.Message);
                    }
                }
            }
        }
        // In frmAddCustomerPayment.cs
        private int CreatePaymentTransaction(SqlConnection conn, SqlTransaction trans, int sessionId, decimal amount, string method)
        {
            string query = @"
        INSERT INTO Transactions 
            (CustomerID, TransactionDate, SessionID, TotalAmount, AmountPaid, Loan, Cash, CreditCard, Cheque, IsReturn, PaymentStatus, CreatedBy)
        OUTPUT INSERTED.TransactionID
        VALUES 
            (@CID, @Date, @SID, 0, @Amount, -@Amount, @Cash, @Card, @Cheque, 0, 'Paid', @User)";

            using (var cmd = new SqlCommand(query, conn, trans))
            {
                cmd.Parameters.AddWithValue("@CID", _customerId);
                cmd.Parameters.AddWithValue("@Date", dtpMainDate.Value);
                cmd.Parameters.AddWithValue("@SID", sessionId);
                cmd.Parameters.AddWithValue("@Amount", amount);
                cmd.Parameters.AddWithValue("@Cash", (method == "Espèces") ? amount : 0);
                cmd.Parameters.AddWithValue("@Card", (method == "Carte") ? amount : 0);
                cmd.Parameters.AddWithValue("@Cheque", (method == "Chèque") ? amount : 0);
                cmd.Parameters.AddWithValue("@User", SessionManager.CurrentUser);

                return (int)cmd.ExecuteScalar();
            }
        }
        #endregion
        // --- 6. دالة الإغلاق ---

        #region Helper Methods (The Missing Parts)

        private void LogCustomerPayment(SqlConnection conn, SqlTransaction trans, decimal amount, string method, string docNum, string notes)
        {
            string query = "INSERT INTO CustomerPayments (CustomerID, PaymentDate, Amount, PaymentMethod, DocumentNumber, Notes, CreatedBy) VALUES (@CID, @Date, @Amount, @Method, @DocNum, @Notes, @User)";
            using (var cmd = new SqlCommand(query, conn, trans))
            {
                cmd.Parameters.AddWithValue("@CID", _customerId);
                cmd.Parameters.AddWithValue("@Date", dtpMainDate.Value);
                cmd.Parameters.AddWithValue("@Amount", amount);
                cmd.Parameters.AddWithValue("@Method", method);
                cmd.Parameters.AddWithValue("@DocNum", docNum);
                cmd.Parameters.AddWithValue("@Notes", notes);
                cmd.Parameters.AddWithValue("@User", SessionManager.CurrentUser);
                cmd.ExecuteNonQuery();
            }
        }

        private void LogCustomerCheque(SqlConnection conn, SqlTransaction trans, int transactionId, ChequeInfo cheque)
        {
            string query = @"INSERT INTO ClientChecks 
                                (TransactionID, CustomerID, CheckNumber, BankName, Amount, DueDate, PayerName, Status, ReceivedDate) 
                             VALUES 
                                (@TID, @CID, @Num, @Bank, @Amount, @DueDate, @Payer, 'Received', @RDate)";

            using (var cmd = new SqlCommand(query, conn, trans))
            {
                // If transactionId is 0, we save DBNull.Value to the database.
                cmd.Parameters.AddWithValue("@TID", (transactionId > 0) ? (object)transactionId : DBNull.Value);
                cmd.Parameters.AddWithValue("@CID", _customerId);
                cmd.Parameters.AddWithValue("@Num", cheque.CheckNumber);
                cmd.Parameters.AddWithValue("@Bank", cheque.BankName);
                cmd.Parameters.AddWithValue("@Amount", cheque.Amount);
                cmd.Parameters.AddWithValue("@DueDate", cheque.DueDate);
                cmd.Parameters.AddWithValue("@Payer", cheque.PayerName);
                cmd.Parameters.AddWithValue("@RDate", dtpMainDate.Value);
                cmd.ExecuteNonQuery();
            }
        }
        private void DistributePaymentToInvoices(SqlConnection conn, SqlTransaction trans, decimal totalPaymentAmount, List<DataGridViewRow> selectedRows)
        {
            decimal paymentRemaining = totalPaymentAmount;
            foreach (DataGridViewRow row in selectedRows)
            {
                if (paymentRemaining <= 0) break;

                int transactionId = Convert.ToInt32(row.Cells["colInvoice"].Value);
                decimal amountDue = Convert.ToDecimal(row.Cells["colRemaining"].Value);
                decimal amountToApply = Math.Min(paymentRemaining, amountDue);

                // Update AmountPaid for the invoice
                string queryInv = "UPDATE Transactions SET AmountPaid = ISNULL(AmountPaid, 0) + @Amount WHERE TransactionID = @TID";
                using (var cmd = new SqlCommand(queryInv, conn, trans))
                {
                    cmd.Parameters.AddWithValue("@Amount", amountToApply);
                    cmd.Parameters.AddWithValue("@TID", transactionId);
                    cmd.ExecuteNonQuery();
                }

                // If fully paid, update status
                if (amountToApply >= amountDue)
                {
                    string queryStatus = "UPDATE Transactions SET PaymentStatus = 'Paid' WHERE TransactionID = @TID";
                    using (var cmd = new SqlCommand(queryStatus, conn, trans))
                    {
                        cmd.Parameters.AddWithValue("@TID", transactionId);
                        cmd.ExecuteNonQuery();
                    }
                }
                paymentRemaining -= amountToApply;
            }
        }

        private void UpdateCustomerDebt(SqlConnection conn, SqlTransaction trans, int customerId, decimal amountChange)
        {
            if (customerId <= 1) return; // Do not update for default cash customer
            string query = "UPDATE Customers SET AmountDue = ISNULL(AmountDue, 0) + @Amount WHERE CustomerID = @CID";
            using (var cmd = new SqlCommand(query, conn, trans))
            {
                cmd.Parameters.AddWithValue("@Amount", amountChange);
                cmd.Parameters.AddWithValue("@CID", customerId);
                cmd.ExecuteNonQuery();
            }
        }

        #endregion
        private void btnCancelPayment_Click(object sender, EventArgs e) => this.Close();

        private void StyleDataGridView(DataGridView dgv)
        {
            // كود التنسيق الجمالي للجدول
        }
        private UnpaidInvoicesReportData _unpaidInvoicesReportData;
        private void btnConfirmFilter_Click(object sender, EventArgs e)
        {
            // هذا الزر يقوم فقط باستدعاء الدالة الرئيسية لجلب البيانات،
            // والتي بدورها ستقرأ قيم فلاتر التاريخ والزبون وتعرض النتائج الجديدة.
            LoadCustomers();
        }// افترضت أن اسم دالة جلب البيانات هو LoadData()
        private void btnTimePeriod_Click(object sender, EventArgs e)
        {
            // إظهار القائمة أسفل الزر مباشرة
            dateRangeMenu.Show(btnTimePeriod, new Point(0, btnTimePeriod.Height));
        }
        private void btnPrintList_Click(object sender, EventArgs e)
        {
            if (dgvInvoices.Rows.Count == 0)
            {
                MessageBox.Show("لا توجد فواتير لعرضها في التقرير.");
                return;
            }

            // 1. تجهيز البيانات
            _unpaidInvoicesReportData = new UnpaidInvoicesReportData
            {
                CustomerName = cmbCustomer.Text,
                PrintDate = DateTime.Now
            };

            foreach (DataGridViewRow row in dgvInvoices.Rows)
            {
                _unpaidInvoicesReportData.Items.Add(new UnpaidInvoicePrintItem
                {
                    InvoiceID = row.Cells["colInvoice"].Value.ToString(),
                    Date = row.Cells["colDate"].Value.ToString(),
                    Total = Convert.ToDecimal(row.Cells["colTotal"].Value),
                    Paid = Convert.ToDecimal(row.Cells["colOldPayment"].Value),
                    Due = Convert.ToDecimal(row.Cells["colRemaining"].Value)
                });
            }

            // 2. بدء الطباعة
            printDocument1.DocumentName = "Unpaid Invoices Report";
            printDocument1.DefaultPageSettings.Landscape = false; // A4 Portrait
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }
        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            // المرور على كل صف في الجدول
            foreach (DataGridViewRow row in dgvInvoices.Rows)
            {
                // الحصول على خلية مربع الاختيار
                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells["colSelect"];

                // تغيير قيمتها إلى "محدد"
                chk.Value = true;
            }
            // تحديث الإجمالي بعد تغيير التحديد
            UpdateTotals();
        }
        private void btnDeselectAll_Click(object sender, EventArgs e)
        {
            // المرور على كل صف في الجدول
            foreach (DataGridViewRow row in dgvInvoices.Rows)
            {
                // الحصول على خلية مربع الاختيار
                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells["colSelect"];

                // تغيير قيمتها إلى "غير محدد"
                chk.Value = false;
            }
            // تحديث الإجمالي بعد تغيير التحديد
            UpdateTotals();
        }
        private void dgvInvoices_CellContentClick(object sender, EventArgs e)
        {
        }
        private ContextMenuStrip dateRangeMenu;
        private void InitializeDateRangeMenu()
        {
            dateRangeMenu = new ContextMenuStrip();

            var todayItem = new ToolStripMenuItem("اليوم");
            todayItem.Click += (s, e) =>
            {
                dtpFrom.Value = DateTime.Today;
                dtpTo.Value = DateTime.Today;
            };

            var thisMonthItem = new ToolStripMenuItem("هذا الشهر");
            thisMonthItem.Click += (s, e) =>
            {
                var today = DateTime.Today;
                dtpFrom.Value = new DateTime(today.Year, today.Month, 1);
                dtpTo.Value = dtpFrom.Value.AddMonths(1).AddDays(-1);
            };

            var thisYearItem = new ToolStripMenuItem("هذه السنة");
            thisYearItem.Click += (s, e) =>
            {
                var today = DateTime.Today;
                dtpFrom.Value = new DateTime(today.Year, 1, 1);
                dtpTo.Value = new DateTime(today.Year, 12, 31);
            };

            dateRangeMenu.Items.Add(todayItem);
            dateRangeMenu.Items.Add(thisMonthItem);
            dateRangeMenu.Items.Add(thisYearItem);
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            if (_unpaidInvoicesReportData != null)
            {
                DrawUnpaidInvoicesReport(e.Graphics);
                _unpaidInvoicesReportData = null; // Reset after printing
            }
            // يمكنك إضافة else if لأنواع التقارير الأخرى لاحقاً
        }

        // دالة جديدة مخصصة لرسم هذا التقرير
        private void DrawUnpaidInvoicesReport(Graphics g)
        {
            // ... (هنا يتم وضع كود الرسم الكامل المشابه لتقاريرنا السابقة)
            // ... (رسم رأس التقرير، رأس الجدول، حلقة لرسم البيانات، والتذييل)
            // ...
            // مثال على الأعمدة:
            // g.DrawString("رقم الفاتورة", headerFont, ...);
            // g.DrawString("المبلغ الإجمالي", headerFont, ...);
            // g.DrawString("المدفوع", headerFont, ...);
            // g.DrawString("المتبقي", headerFont, ...);
        }

        private void txtDebt_DoubleClick(object sender, EventArgs e)
        {
            if (txtDebt.Text != string.Empty)
                txtPayment.Text = txtDebt.Text;
        }

        private void txtDebt_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (txtDebt.Text != string.Empty)
            {
                txtPayment.Text = txtDebt.Text;
                txtRemaining.Text = (Convert.ToDouble(txtDebt.Text) - Convert.ToDouble(txtPayment.Text)).ToString("N2");

                // المرور على كل صف في الجدول
                foreach (DataGridViewRow row in dgvInvoices.Rows)
                {
                    // الحصول على خلية مربع الاختيار
                    DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells["colSelect"];

                    // تغيير قيمتها إلى "محدد"
                    chk.Value = true;
                }
                // تحديث الإجمالي بعد تغيير التحديد
                UpdateTotals();
            }

           
        }

        private void txtPayment_Leave(object sender, EventArgs e)
        {
            if(txtPayment.Text != string.Empty && txtDebt.Text != string.Empty)
            {
                double payment = Convert.ToDouble(txtPayment.Text);
                double Remaining = (Convert.ToDouble(txtDebt.Text) - Convert.ToDouble(txtPayment.Text));
                txtRemaining.Text = Remaining.ToString("N2");
                txtPayment.Text = payment.ToString("N2");
            }
        }
    }
}