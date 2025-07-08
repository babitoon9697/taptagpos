using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic; // For Interaction.InputBox

namespace TAPTAGPOS
{
    public partial class FormCaisseDetail : Form
    {
        private string connectionString = DatabaseConnection.GetConnectionString();
        private int _sessionId = 0;
        private bool isNewSession = true;

        // Constructor for starting a NEW session
        public FormCaisseDetail()
        {
            InitializeComponent();
            InitializeEventHandlers();
        }

        // Constructor for viewing/closing an EXISTING session
        public FormCaisseDetail(int sessionId) : this()
        {
            _sessionId = sessionId;
            isNewSession = false;
        }

        private void InitializeEventHandlers()
        {
            this.Load += FormCaisseDetail_Load;
            this.btnConfirm.Click += btnConfirm_Click;
            this.btnExit.Click += (s, e) => this.Close();
        }

        private void FormCaisseDetail_Load(object sender, EventArgs e)
        {
            if (isNewSession)
            {
                OpenNewSession();
            }
            else
            {
                LoadSessionData();
            }
        }

        #region Session Management

        private void OpenNewSession()
        {
            string startingCashStr = Interaction.InputBox("أدخل مبلغ الصندوق عند البدأ", "فتح جلسة جديدة", "0");
            if (decimal.TryParse(startingCashStr, out decimal startingCash))
            {
                try
                {
                    string query = "INSERT INTO PosSessions (UserNam,UserID, StartDate, StartingCash, Status) OUTPUT INSERTED.SessionID VALUES (@Username,@USERID ,@Date, @Cash, 'Open')";
                    using (var conn = new SqlConnection(connectionString))
                    using (var cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", SessionManager.CurrentUser);
                        cmd.Parameters.AddWithValue("@UserID", SessionManager.CurrentUserId);

                        cmd.Parameters.AddWithValue("@Date", DateTime.Now);
                        cmd.Parameters.AddWithValue("@Cash", startingCash);
                        conn.Open();
                        _sessionId = (int)cmd.ExecuteScalar();
                    }
                    isNewSession = false;
                    LoadSessionData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("خطأ في فتح الجلسة: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }
        }
        int useridd = 1;
        private void LoadSessionData()
        {
            if (_sessionId == 0) return;

            string querySession = "SELECT * FROM PosSessions WHERE SessionID = @ID";
            using (var conn = new SqlConnection(connectionString))
            using (var cmd = new SqlCommand(querySession, conn))
            {
                cmd.Parameters.AddWithValue("@ID", _sessionId);
                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        useridd = Convert.ToInt32(reader["UserID"].ToString());
                        txtUser.Text = reader["UserNam"].ToString();
                        txtStartDate.Text = ((DateTime)reader["StartDate"]).ToShortDateString();
                        txtStartTime.Text = ((DateTime)reader["StartDate"]).ToShortTimeString();
                        txtStartingCash.Text = Convert.ToDecimal(reader["StartingCash"]).ToString("N2");

                        if (reader["Status"].ToString() == "Closed")
                        {
                            txtEndDate.Text = ((DateTime)reader["EndDate"]).ToShortDateString();
                            txtEndTime.Text = ((DateTime)reader["EndDate"]).ToShortTimeString();
                            btnConfirm.Enabled = false;
                        }
                    }
                }
            }
            CalculateSessionTotals();
        }

        private void CalculateSessionTotals()
        {
            if (_sessionId == 0) return;
            try
            {
                using (var conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Calculate Payment Totals from Transactions
                    string queryPayments = "SELECT ISNULL(SUM(Cash), 0) as TotalCash, ISNULL(SUM(CreditCard), 0) as TotalCard, ISNULL(SUM(Cheque), 0) as TotalCheque, ISNULL(SUM(Loan), 0) as TotalCredit, ISNULL(SUM(DiscountAmount), 0) as TotalDiscount FROM Transactions WHERE SessionID = @ID";
                    using (var cmd = new SqlCommand(queryPayments, conn))
                    {
                        cmd.Parameters.AddWithValue("@ID", _sessionId);
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtCash.Text = Convert.ToDecimal(reader["TotalCash"]).ToString("N2");
                                txtBankCard.Text = Convert.ToDecimal(reader["TotalCard"]).ToString("N2");
                                txtChecks.Text = Convert.ToDecimal(reader["TotalCheque"]).ToString("N2");
                                txtCredit.Text = Convert.ToDecimal(reader["TotalCredit"]).ToString("N2");
                                txtDiscount.Text = Convert.ToDecimal(reader["TotalDiscount"]).ToString("N2");
                            }
                        }
                    }

                    // --- FIX: Use correct table name 'Expenses' and column 'Amount' ---
                    string queryExpenses = "SELECT ISNULL(SUM(Amount), 0) FROM Expenses WHERE SessionID = @ID";
                    using (var cmd = new SqlCommand(queryExpenses, conn))
                    {
                        cmd.Parameters.AddWithValue("@ID", _sessionId);
                        txtExpenses.Text = Convert.ToDecimal(cmd.ExecuteScalar() ?? 0).ToString("N2");
                    }
                }

                // Final Calculation for Cash Drawer
                decimal startingCash = decimal.Parse(txtStartingCash.Text);
                decimal cashIn = decimal.Parse(txtCash.Text);
                decimal expenses = decimal.Parse(txtExpenses.Text);
                txtTotalCash.Text = (startingCash + cashIn - expenses).ToString("N2");
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ في حساب إجماليات الجلسة: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            // This button is for closing the session
            string endingCashStr = Interaction.InputBox("أدخل المبلغ النهائي في الصندوق", "إغلاق الجلسة", "0");
            if (decimal.TryParse(endingCashStr, out decimal endingCash))
            {
                if (MessageBox.Show("هل أنت متأكد من رغبتك في إغلاق هذه الجلسة؟", "تأكيد الإغلاق", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        decimal totalSales = Convert.ToDecimal(txtCash.Text) + Convert.ToDecimal(txtBankCard.Text) + Convert.ToDecimal(txtChecks.Text) + Convert.ToDecimal(txtCredit.Text);

                        string query = "UPDATE PosSessions SET EndDate=@EndDate, EndingCash=@EndingCash, TotalSales=@TotalSales, Status='Closed' WHERE SessionID=@ID";
                        using (var conn = new SqlConnection(connectionString))
                        using (var cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@EndDate", DateTime.Now);
                            cmd.Parameters.AddWithValue("@EndingCash", endingCash);
                            cmd.Parameters.AddWithValue("@TotalSales", totalSales);
                            cmd.Parameters.AddWithValue("@ID", _sessionId);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                        }
                        MessageBox.Show("تم إغلاق الجلسة بنجاح.", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("خطأ في إغلاق الجلسة: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        #endregion
    }
}