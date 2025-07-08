using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace TAPTAGPOS
{
    public partial class frmStockDetailReport : Form
    {
        private int _articleId;
        private string _articleName;
        private int _customerId;

        // Constructor يستقبل بيانات المنتج من الفورم السابق
        public frmStockDetailReport(int articleId, string articleName)
        {
            InitializeComponent();
            _articleId = articleId;
            _articleName = articleName;
            StyleDataGridView(this.dgvDetails); // تطبيق التنسيق الاحترافي
        }
        public frmStockDetailReport(int articleId, string articleName, int customerId) : this(articleId, articleName)
        {
            _customerId = customerId;
        }
        private void frmStockDetailReport_Load(object sender, EventArgs e)
        {
            lblArticleName.Text = $"تفاصيل حركة المنتج: {_articleName}";
            LoadReportData();
        }

        private void LoadReportData()
        {
            dgvDetails.Rows.Clear();
            string connectionString = DatabaseConnection.GetConnectionString();

            string query = @"
                SELECT MovementDate, MovementType, QuantityChange FROM (
                    SELECT t.TransactionDate AS MovementDate, N'بيع' AS MovementType, (-1 * ti.Quantity) AS QuantityChange, t.CustomerID
                    FROM TransactionItems ti JOIN Transactions t ON ti.TransactionID = t.TransactionID
                    WHERE ti.ArticleID = @ArticleID
                    UNION ALL
                    SELECT pi.PurchaseDate AS MovementDate, N'شراء' AS MovementType, pii.Quantity AS QuantityChange, NULL as CustomerID
                    FROM PurchaseInvoiceItems pii JOIN PurchaseInvoices pi ON pii.InvoiceID = pi.InvoiceID
                    WHERE pii.ArticleID = @ArticleID
                ) AS Movements
                WHERE (@CustomerID = 0 OR CustomerID = @CustomerID)
                ORDER BY MovementDate ASC";

            try
            {
                using (var conn = new SqlConnection(DatabaseConnection.GetConnectionString()))
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ArticleID", _articleId);
                    cmd.Parameters.AddWithValue("@CustomerID", _customerId); // إضافة باراميتر الزبون
                    conn.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            dgvDetails.Rows.Add(
                                Convert.ToDateTime(reader["MovementDate"]).ToString("yyyy/MM/dd HH:mm"),
                                reader["MovementType"],
                                Convert.ToDecimal(reader["QuantityChange"])
                            );
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ في تحميل تفاصيل الحركة: " + ex.Message);
            }
        }
        
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // دالة التنسيق الجمالي
        private void StyleDataGridView(DataGridView dgv)
        {
            // --- إعدادات المظهر العام للجدول ---
            dgv.BorderStyle = BorderStyle.None;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 247, 251);
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 122, 204); // لون التحديد
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;
            dgv.BackgroundColor = Color.White;
            dgv.RowHeadersVisible = false; // إخفاء العمود الرمادي الأول
            dgv.EnableHeadersVisualStyles = false; // السماح بتطبيق تنسيقنا الخاص على الرأس
            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular); // خط عصري للبيانات
            dgv.RowTemplate.Height = 30; // زيادة ارتفاع الصفوف لإعطاء مساحة

            // --- تنسيق رأس الجدول (العناوين) ---
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DataGridViewCellStyle headerStyle = new DataGridViewCellStyle
            {
                BackColor = Color.FromArgb(45, 52, 54), // لون أزرق داكن/فحمي
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                Alignment = DataGridViewContentAlignment.MiddleCenter
            };
            dgv.ColumnHeadersDefaultCellStyle = headerStyle;
            dgv.ColumnHeadersHeight = 40; // زيادة ارتفاع رأس الجدول
        }

    }
}