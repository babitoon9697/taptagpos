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
    public partial class ListArticles : Form
    {
        public ListArticles()
        {
            InitializeComponent();
        }
        string connectionString = DatabaseConnection.GetConnectionString();
        private void ListArticles_Load(object sender, EventArgs e)
        {
            LoadArticles();
        }
        private void LoadArticles()
        {
            try
            {
                // Define the SQL query to retrieve article data
                string query = "SELECT Id, Article, DetailsPrice, SemigrosPrice, GrosPrice, SpecialPrice, QuantiteBox FROM  [TaptagCaisse].[dbo].[Articles]";

                // Set up the SQL connection
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    // Open the connection
                    conn.Open();

                    // Create the SQL command
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Create a DataTable to hold the data
                        DataTable dt = new DataTable();

                        // Fill the DataTable with data from the query
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            dt.Load(reader);
                        }

                        // Clear existing rows if any, to avoid duplicate data
                        dgvlistArticles.Rows.Clear();

                        // Loop through each row in the DataTable and add it to the DataGridView
                        foreach (DataRow row in dt.Rows)
                        {
                            int rowIndex = dgvlistArticles.Rows.Add(); // Add a new empty row to the DataGridView
                            DataGridViewRow dgvRow = dgvlistArticles.Rows[rowIndex];

                            // Assign values from the DataTable row to each DataGridView column
                            dgvRow.Cells["Id"].Value = row["Id"];
                            dgvRow.Cells["ArticleName"].Value = row["Article"];
                            dgvRow.Cells["prixdetail"].Value = row["DetailsPrice"];
                            dgvRow.Cells["prixdemigros"].Value = row["SemigrosPrice"];
                            dgvRow.Cells["prixgros"].Value = row["GrosPrice"];
                            dgvRow.Cells["prixspecial"].Value = row["SpecialPrice"];
                            dgvRow.Cells["ArticlePerbox"].Value = row["QuantiteBox"];
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions (e.g., database connection issues)
                MessageBox.Show($"Error loading articles: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bunifuButton23_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_AddArticlesForm_Click(object sender, EventArgs e)
        {

         
            OverlayForm overlay = new OverlayForm(this);
            overlay.Show();

            // Create and show the centered Category form
            AddArticles arts = new AddArticles();
            arts.StartPosition = FormStartPosition.CenterScreen;

            // Attach an event to close the overlay and refocus the main form when Category closes
            arts.FormClosed += (s, args) =>
            {
                overlay.Close();        // Close the overlay form
                this.Activate();        // Bring main form back to focus
            };

            // Show the Category form as a dialog
            arts.ShowDialog();
        }

        private void Btn_AddCatForm_Click(object sender, EventArgs e)
        {
            OverlayForm overlay = new OverlayForm(this);
            overlay.Show();

            // Create and show the centered Category form
            Category categoryForm = new Category();
            categoryForm.StartPosition = FormStartPosition.CenterScreen;

            // Attach an event to close the overlay and refocus the main form when Category closes
            categoryForm.FormClosed += (s, args) =>
            {
                overlay.Close();        // Close the overlay form
                this.Activate();        // Bring main form back to focus
            };

            // Show the Category form as a dialog
            categoryForm.ShowDialog();

        }

        private void dgvlistArticles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // تأكد من أن الضغط كان على صف صالح وليس على رأس الجدول
            if (e.RowIndex >= 0)
            {
                // احصل على رقم المنتج من الخلية الأولى في الصف المحدد
                var cellValue = dgvlistArticles.Rows[e.RowIndex].Cells["Id"].Value;

                if (cellValue != null)
                {
                    // --- الكود الجديد الصحيح ---

                    // 1. قم بتحويل الـ ID إلى رقم صحيح (int)
                    if (int.TryParse(cellValue.ToString(), out int selectedArticleIdAsInt))
                    {
                        // 2. قم بإنشاء فورم التعديل ومرر له رقم المنتج مباشرة في الـ Constructor
                        AddArticles editArticleForm = new AddArticles(selectedArticleIdAsInt);

                        // 3. قم بإظهار الفورم، وبعد إغلاقه قم بتحديث قائمة المنتجات
                        // لقد قمنا بربط DialogResult في زر الحفظ في الرد السابق
                        if (editArticleForm.ShowDialog() == DialogResult.OK)
                        {
                            // أعد تحميل قائمة المنتجات لإظهار التعديلات الجديدة
                            LoadArticles();
                        }
                    }
                    else
                    {
                        MessageBox.Show("رقم المنتج غير صالح.");
                    }
                }
            }
        }
    }
}
