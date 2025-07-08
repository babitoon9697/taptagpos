using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace TAPTAGPOS
{
    public partial class frmProfitsByCustomer : Form
    {
        public frmProfitsByCustomer()
        {
            InitializeComponent();
            StyleDataGridView(this.dgvProfits);// استدعاء دالة التنسيق التي أنشأناها
        }

        private void frmProfitsByCustomer_Load(object sender, EventArgs e)
        {
            // إعداد التواريخ الافتراضية وتحميل البيانات
            dtpStartDate.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtpEndDate.Value = DateTime.Now;
            LoadCustomersIntoComboBox();
            LoadProfitsData();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            LoadProfitsData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadCustomersIntoComboBox()
        {
            try
            {
                using (var conn = new SqlConnection(DatabaseConnection.GetConnectionString()))
                {
                    var adapter = new SqlDataAdapter("SELECT CustomerID, CustomerName FROM Customers ORDER BY CustomerName", conn);
                    var dt = new DataTable();
                    adapter.Fill(dt);

                    // إضافة خيار "الكل" يدوياً في بداية القائمة
                    DataRow allRow = dt.NewRow();
                    allRow["CustomerID"] = 0; // استخدم 0 كقيمة مميزة للكل
                    allRow["CustomerName"] = "الكل";
                    dt.Rows.InsertAt(allRow, 0);

                    cmbCustomer.DataSource = dt;
                    cmbCustomer.DisplayMember = "CustomerName";
                    cmbCustomer.ValueMember = "CustomerID";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ في تحميل قائمة الزبناء: " + ex.Message);
            }
        }
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
        private void LoadProfitsData()
        {
            dgvProfits.Rows.Clear();
            string connectionString = DatabaseConnection.GetConnectionString();

            string query = @"
    SELECT 
        a.Id AS Code,
        a.Article AS ArticleName,
        SUM(ti.Quantity) AS Sales,
        ISNULL(SUM(ti.Quantity * a.BuyPrice), 0) AS PurchaseValue,
        ISNULL(SUM(ti.TotalPrice), 0) AS SaleValue,
        (ISNULL(SUM(ti.TotalPrice), 0) - ISNULL(SUM(ti.Quantity * a.BuyPrice), 0)) AS Profit,
        CASE 
            WHEN ISNULL(SUM(ti.TotalPrice), 0) <= 0 THEN 0 
            ELSE ((ISNULL(SUM(ti.TotalPrice), 0) - ISNULL(SUM(ti.Quantity * a.BuyPrice), 0)) * 100) / SUM(ti.TotalPrice) 
        END AS Percentage
    FROM 
        TransactionItems ti
    JOIN 
        Transactions t ON ti.TransactionID = t.TransactionID
    -- <<-- التعديل الرئيسي هنا: الربط بـ ID المنتج مباشرة -->>
    JOIN 
        Articles a ON ti.ArticleID = a.Id 
    WHERE 
        (t.TransactionDate BETWEEN @StartDate AND @EndDate)
        AND (@CustomerID = 0 OR t.CustomerID = @CustomerID) 
    GROUP BY 
        a.Id, a.Article
    HAVING
        SUM(ti.Quantity) > 0
    ORDER BY 
        Profit DESC";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@StartDate", dtpStartDate.Value.Date);
                        cmd.Parameters.AddWithValue("@EndDate", dtpEndDate.Value.Date);
                        cmd.Parameters.AddWithValue("@CustomerID", (int)(cmbCustomer.SelectedValue ?? 0));

                        conn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();

                        decimal grandTotalProfit = 0;
                        decimal grandTotalSalesValue = 0;

                        while (reader.Read())
                        {
                            decimal profit = Convert.ToDecimal(reader["Profit"]);
                            grandTotalProfit += profit;
                            grandTotalSalesValue += Convert.ToDecimal(reader["SaleValue"]);

                            dgvProfits.Rows.Add(
                                reader["Code"],
                                reader["ArticleName"],
                                reader["Sales"],
                                Convert.ToDecimal(reader["PurchaseValue"]),
                                Convert.ToDecimal(reader["SaleValue"]),
                                profit,
                                (Convert.ToDecimal(reader["Percentage"]) / 100)
                            );
                        }
                        reader.Close();

                        // تحديث الملخصات
                        txtTotalProfitTop.Text = grandTotalProfit.ToString("N2");
                        txtTotalProfitBottom.Text = grandTotalProfit.ToString("N2");

                        if (grandTotalSalesValue > 0)
                        {
                            decimal overallPercentage = (grandTotalProfit / grandTotalSalesValue);
                            txtTotalPercentage.Text = overallPercentage.ToString("P1"); // P1 = نسبة عشرية واحدة
                        }
                        else
                        {
                            txtTotalPercentage.Text = "0.0 %";
                        }

                        decimal totalExpenses = GetTotalExpenses(dtpStartDate.Value, dtpEndDate.Value);
                        txtExpenses.Text = totalExpenses.ToString("N2");
                        txtNetProfit.Text = (grandTotalProfit - totalExpenses).ToString("N2");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء جلب تقرير الأرباح: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private decimal GetTotalExpenses(DateTime start, DateTime end)
        {
            decimal total = 0;
            string query = "SELECT SUM(Amount) FROM Expenses WHERE ExpenseDate BETWEEN @StartDate AND @EndDate";
            try
            {
                using (var conn = new SqlConnection(DatabaseConnection.GetConnectionString()))
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@StartDate", start.Date);
                    cmd.Parameters.AddWithValue("@EndDate", end.Date);
                    conn.Open();
                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value && result != null)
                    {
                        total = Convert.ToDecimal(result);
                    }
                }
            }
            catch { /* تجاهل الخطأ في حالة عدم وجود مصاريف */ }
            return total;
        }

        // دالة تنسيق الجدول التي أنشأناها في الرد السابق
    }
}