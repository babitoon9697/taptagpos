using System;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace TAPTAGPOS
{
    public partial class frmIdentification : Form
    {
        public frmIdentification()
        {
            InitializeComponent();
            // ربط كل الأزرار الرقمية بنفس دالة الحدث
            btn1.Click += NumberButton_Click;
            btn2.Click += NumberButton_Click;
            btn3.Click += NumberButton_Click;
            btn4.Click += NumberButton_Click;
            btn5.Click += NumberButton_Click;
            btn6.Click += NumberButton_Click;
            btn7.Click += NumberButton_Click;
            btn8.Click += NumberButton_Click;
            btn9.Click += NumberButton_Click;
            btn0.Click += NumberButton_Click;
        }

        // دالة واحدة لكل الأزرار الرقمية
        private void NumberButton_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            txtPin.Text += button.Text;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPin.Clear();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        private string HashPassword(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // تحويل النص إلى مصفوفة بايت وحساب الـ hash
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));

                // تحويل مصفوفة البايت إلى نص سداسي عشري (hexadecimal)
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string enteredPin = txtPin.Text;

            //  string enteredPin = txtPin.Text;

            if (string.IsNullOrWhiteSpace(enteredPin))
            {
                MessageBox.Show("الرجاء إدخال الرمز السري.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // --- **السطر الجديد الأول: تشفير الرمز المُدخَل** ---
            string hashedPin = HashPassword(enteredPin);

            // جملة SQL للبحث عن الهاش المطابق لمستخدم بصلاحية مدير
            string query = "SELECT COUNT(*) FROM dbo.Users WHERE PasswordHash = @HashedPin AND UserRole = 'Admin'";
            string connectionString = DatabaseConnection.GetConnectionString();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // --- **السطر الجديد الثاني: استخدام الهاش في الـ Parameter** ---
                        cmd.Parameters.AddWithValue("@HashedPin", hashedPin);

                        conn.Open();
                        int adminUserCount = (int)cmd.ExecuteScalar();

                        if (adminUserCount > 0)
                        {
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("رمز سري خاطئ أو أن المستخدم لا يملك صلاحيات المدير!", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtPin.Clear();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء الاتصال بقاعدة البيانات: " + ex.Message, "خطأ فادح", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}