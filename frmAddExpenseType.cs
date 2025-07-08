using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TAPTAGPOS
{
    public partial class frmAddExpenseType : Form
    {
        public frmAddExpenseType()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string typeName = txtTypeName.Text.Trim();

            if (string.IsNullOrWhiteSpace(typeName))
            {
                MessageBox.Show("الرجاء إدخال اسم نوع المصروف.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = "INSERT INTO ExpenseTypes (TypeName) VALUES (@TypeName)";
            string connectionString = DatabaseConnection.GetConnectionString();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@TypeName", typeName);
                        conn.Open();
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("تم حفظ النوع بنجاح.", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
            }
            catch (SqlException ex) when (ex.Number == 2627) // خطأ تكرار القيمة الفريدة
            {
                MessageBox.Show("هذا النوع من المصروفات موجود بالفعل.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("فشل حفظ النوع: " + ex.Message, "خطأ فادح", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}