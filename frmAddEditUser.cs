using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace TAPTAGPOS
{
    public partial class frmAddEditUser : Form
    { 

        // متغيرات لتحديد وضع الفورم
        private bool isEditMode = false;
        private int currentUserId = 0;

        public frmAddEditUser()
        {
            InitializeComponent();
            // تحديد الاختيار الافتراضي للصلاحية
            cmbRole.SelectedIndex = 1; // اختيار "مستخدم" كقيمة افتراضية
                                       // ربط الأحداث
            txtFullName.Enter += TextBox_Enter;
            txtFullName.Leave += TextBox_Leave;

            txtUsername.Enter += TextBox_Enter;
            txtUsername.Leave += TextBox_Leave;

            txtPassword.Enter += TextBox_Enter;
            txtPassword.Leave += TextBox_Leave;

            txtConfirmPassword.Enter += TextBox_Enter;
            txtConfirmPassword.Leave += TextBox_Leave;
            cmbRole.SelectedIndex = 1; // "مستخدم" كقيمة افتراضية
        }
        public frmAddEditUser(int userId)
        {
            InitializeComponent();
            this.isEditMode = true;
            this.currentUserId = userId;
            this.Text = "تعديل بيانات المستخدم";
            this.btnConfirm.Text = "تعديل";
            txtFullName.Enter += TextBox_Enter;
            txtFullName.Leave += TextBox_Leave;

            txtUsername.Enter += TextBox_Enter;
            txtUsername.Leave += TextBox_Leave;

            txtPassword.Enter += TextBox_Enter;
            txtPassword.Leave += TextBox_Leave;

            txtConfirmPassword.Enter += TextBox_Enter;
            txtConfirmPassword.Leave += TextBox_Leave;
            // عند التعديل، كلمة المرور ليست مطلوبة إلا إذا أردت تغييرها
            lblPassword.Text = "كلمة مرور جديدة (اختياري)";
            lblConfirmPassword.Text = "تأكيد كلمة المرور الجديدة";
        }
        // --- دالة الحفظ الرئيسية ---
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            // --- 1. التحقق من المدخلات ---
            if (string.IsNullOrWhiteSpace(txtFullName.Text) ||
                string.IsNullOrWhiteSpace(txtUsername.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("الرجاء ملء كل الحقول المطلوبة (الاسم الكامل، اسم المستخدم، كلمة المرور).", "بيانات ناقصة", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!string.IsNullOrWhiteSpace(txtPassword.Text) && txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("كلمة المرور وتأكيدها غير متطابقين.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // (فقط في وضع الإضافة) التحقق مما إذا كان اسم المستخدم موجوداً
            if (!isEditMode && UsernameExists(txtUsername.Text))
            {
                MessageBox.Show("اسم المستخدم هذا موجود بالفعل.", "اسم مستخدم مكرر", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

         

            // --- 2. جمع البيانات من الواجهة ---
            string fullName = txtFullName.Text.Trim();
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;
            string userRole = cmbRole.SelectedItem.ToString();

            // --- 3. تشفير كلمة المرور ---
            string hashedPassword = HashPassword(password);

            // --- 4. حفظ البيانات في قاعدة البيانات ---
            string query;
            if (isEditMode)
            {
                // جملة التحديث
                // لاحظ: سنقوم بتحديث كلمة المرور فقط إذا تم إدخال كلمة جديدة
                if (!string.IsNullOrWhiteSpace(txtPassword.Text))
                {
                    query = @"UPDATE Users SET FullName=@FullName, Username=@Username, PasswordHash=@PasswordHash, UserRole=@UserRole
                              WHERE UserID = @UserID";
                }
                else
                {
                    // جملة التحديث بدون تغيير كلمة المرور
                    query = @"UPDATE Users SET FullName=@FullName, Username=@Username, UserRole=@UserRole
                              WHERE UserID = @UserID";
                }
            }
            else
            {
                // جملة الإضافة
                query = @"INSERT INTO Users (FullName, Username, PasswordHash, UserRole) 
                          VALUES (@FullName, @Username, @PasswordHash, @UserRole)";
            }

            string connectionString = DatabaseConnection.GetConnectionString();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // إضافة الـ Parameters
                        cmd.Parameters.AddWithValue("@FullName", txtFullName.Text.Trim());
                        cmd.Parameters.AddWithValue("@Username", txtUsername.Text.Trim());
                        cmd.Parameters.AddWithValue("@UserRole", cmbRole.SelectedItem.ToString());

                        if (!string.IsNullOrWhiteSpace(txtPassword.Text))
                        {
                            cmd.Parameters.AddWithValue("@PasswordHash", HashPassword(txtPassword.Text));
                        }

                        if (isEditMode)
                        {
                            cmd.Parameters.AddWithValue("@UserID", currentUserId);
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

        // --- دوال مساعدة ---

        // دالة لتشفير كلمة المرور باستخدام SHA256
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

        // دالة للتحقق مما إذا كان اسم المستخدم موجوداً مسبقاً
        private bool UsernameExists(string username)
        {
            string query = "SELECT COUNT(1) FROM Users WHERE Username = @Username";
            string connectionString = DatabaseConnection.GetConnectionString();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    conn.Open();
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }
        // لا تنس ربط زر الإلغاء بهذا الحدث إذا لم تكن قد فعلت
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        private Color accentColor = Color.FromArgb(0, 122, 204);
        private Color inactiveColor = Color.DarkGray;

        // دالة يتم استدعاؤها عند الدخول إلى أي مربع نص
        private void TextBox_Enter(object sender, EventArgs e)
        {
            var textBox = (TextBox)sender;
            // ابحث عن لوحة الخط السفلي المقابلة له وقم بتغيير لونها
            switch (textBox.Name)
            {
                case "txtFullName":
                    pnlFullNameUnderline.BackColor = accentColor;
                    break;
                case "txtUsername":
                    pnlUsernameUnderline.BackColor = accentColor;
                    break;
                case "txtPassword":
                    pnlPasswordUnderline.BackColor = accentColor;
                    break;
                case "txtConfirmPassword":
                    pnlConfirmPasswordUnderline.BackColor = accentColor;
                    break;
            }
        }

        // دالة يتم استدعاؤها عند الخروج من أي مربع نص
        private void TextBox_Leave(object sender, EventArgs e)
        {
            var textBox = (TextBox)sender;
            // ابحث عن لوحة الخط السفلي المقابلة له وأعد لونها للون غير النشط
            switch (textBox.Name)
            {
                case "txtFullName":
                    pnlFullNameUnderline.BackColor = inactiveColor;
                    break;
                case "txtUsername":
                    pnlUsernameUnderline.BackColor = inactiveColor;
                    break;
                case "txtPassword":
                    pnlPasswordUnderline.BackColor = inactiveColor;
                    break;
                case "txtConfirmPassword":
                    pnlConfirmPasswordUnderline.BackColor = inactiveColor;
                    break;
            }
        }

        private void frmAddEditUser_Load(object sender, EventArgs e)
        {
            if (isEditMode)
            {
                LoadUserDataForEdit(currentUserId);
            }
        }
        private void LoadUserDataForEdit(int userId)
        {
            string query = "SELECT FullName,Username,UserRole FROM Users WHERE UserID = @UserID";
            string connectionString = DatabaseConnection.GetConnectionString();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserID", userId);
                        conn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            txtFullName.Text = reader["FullName"]?.ToString();
                            txtUsername.Text = reader["Username"]?.ToString();
                            cmbRole.SelectedItem = reader["UserRole"]?.ToString();

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ في تحميل بيانات المستخدم: " + ex.Message);
                this.Close();
            }
        }
    }
}