using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TAPTAGPOS
{
    public partial class frmAddExpense : Form
    {
        private string connectionString = DatabaseConnection.GetConnectionString();
        private bool isEditMode = false;
        private int currentExpenseId = 0;
        public frmAddExpense()
        {
            InitializeComponent();
            InitializeEventHandlers();
        }
        public frmAddExpense(int expenseId)
        {
            InitializeComponent();
            this.isEditMode = true;
            this.currentExpenseId = expenseId;
            this.Text = "تعديل المصروف"; // تغيير عنوان النافذة
            btnConfirm.Text = "تعديل";

        }
        private void InitializeEventHandlers()
        {
            this.Load += frmAddExpense_Load;
            this.btnConfirm.Click += btnConfirm_Click;
            this.btnCancel.Click += (s, e) => this.Close();
            this.btnAddType.Click += btnAddType_Click;
        }
        private void frmAddExpense_Load(object sender, EventArgs e)
        {
            LoadExpenseTypes();
            if (isEditMode)
            {
                this.Text = "تعديل المصروف";
                btnConfirm.Text = "تعديل";
                LoadExpenseDataForEdit(currentExpenseId);
            }
            else
            {
                this.Text = "إضافة مصروف جديد";
                btnConfirm.Text = "حفظ";
            }
        }
        private void LoadExpenseDataForEdit(int expenseId)
        {
            string query = @"SELECT E.ExpenseDate, ET.TypeName, E.Details, E.Amount 
                             FROM Expenses E JOIN ExpenseTypes ET ON E.TypeId = ET.TypeId 
                             WHERE E.ExpenseId = @ExpenseId";
            string connectionString = DatabaseConnection.GetConnectionString();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ExpenseId", expenseId);
                        conn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            dtpExpenseDate.Value = Convert.ToDateTime(reader["ExpenseDate"]);
                            cmbExpenseType.SelectedItem = reader["TypeName"].ToString();
                            txtDetails.Text = reader["Details"].ToString();
                            txtAmount.Text = Convert.ToDecimal(reader["Amount"]).ToString("F2");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ في تحميل بيانات المصروف للتعديل: " + ex.Message);
                this.Close();
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
        private void LoadExpenseTypes()
        {
            try
            {
                var dt = new DataTable();
                using (var conn = new SqlConnection(connectionString))
                {
                    // Select both the ID and the Name
                    var query = "SELECT TypeId, TypeName FROM ExpenseTypes ORDER BY TypeName";
                    new SqlDataAdapter(query, conn).Fill(dt);
                }

                // Add a placeholder item
                DataRow dr = dt.NewRow();
                dr["TypeId"] = 0;
                dr["TypeName"] = "اختر نوع المصروف...";
                dt.Rows.InsertAt(dr, 0);

                // Set the data binding properties
                cmbExpenseType.DataSource = dt;
                cmbExpenseType.DisplayMember = "TypeName";
                cmbExpenseType.ValueMember = "TypeId";
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ في تحميل أنواع المصروفات: " + ex.Message);
            }
        }
        // دالة يتم تنفيذها عند الضغط على زر "تأكيد"
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (cmbExpenseType.SelectedValue == null || (int)cmbExpenseType.SelectedValue == 0)
            {
                MessageBox.Show("الرجاء اختيار نوع المصروف.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!decimal.TryParse(txtAmount.Text, out decimal amount) || amount <= 0)
            {
                MessageBox.Show("الرجاء إدخال مبلغ صحيح وأكبر من صفر.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Get the current session ID automatically
            int? currentSessionId = GetCurrentSessionId();

            string query;
            if (isEditMode)
            {
                // Update statement now includes SessionID
                query = @"UPDATE Expenses SET 
                            ExpenseDate = @ExpenseDate, 
                            TypeId = @TypeId, 
                            Details = @Details, 
                            Amount = @Amount,
                            SessionID = @SessionID 
                          WHERE ExpenseId = @ExpenseId";
            }
            else
            {
                // Insert statement now includes SessionID
                query = @"INSERT INTO Expenses (ExpenseDate, TypeId, Details, Amount, UserID, SessionID) 
                          VALUES (@ExpenseDate, @TypeId, @Details, @Amount, @UserID, @SessionID)";
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ExpenseDate", dtpExpenseDate.Value.Date);
                        cmd.Parameters.AddWithValue("@TypeId", (int)cmbExpenseType.SelectedValue);
                        cmd.Parameters.AddWithValue("@Details", txtDetails.Text);
                        cmd.Parameters.AddWithValue("@Amount", amount);
                        cmd.Parameters.AddWithValue("@UserID", SessionManager.CurrentUserId);

                        // Add SessionID as a parameter, handling the possibility of no open session
                        cmd.Parameters.AddWithValue("@SessionID", (object)currentSessionId ?? DBNull.Value);

                        if (isEditMode)
                        {
                            cmd.Parameters.AddWithValue("@ExpenseId", currentExpenseId);
                        }

                        conn.Open();
                        cmd.ExecuteNonQuery();

                        MessageBox.Show(isEditMode ? "تم التعديل بنجاح." : "تم الحفظ بنجاح.", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("فشل حفظ البيانات: " + ex.Message, "خطأ فادح", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // دالة يتم تنفيذها عند الضغط على زر "إلغاء"
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        // ملاحظة: لم نقم ببرمجة وظيفة زر "+" بعد.
        // يمكننا في الخطوة التالية إنشاء فورم صغير لإضافة نوع مصروف جديد.
        private void btnAddType_Click(object sender, EventArgs e)
        {
            using (frmAddExpenseType addTypeForm = new frmAddExpenseType())
            {
                if (addTypeForm.ShowDialog() == DialogResult.OK)
                {
                    LoadExpenseTypes(); // Refresh the combobox
                }
            }
        }
    }
}
