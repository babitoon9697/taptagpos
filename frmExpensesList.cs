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
    public partial class frmExpensesList : Form
    {

        // --- متغيرات جديدة للطباعة الاحترافية ---
        private List<ExpensePrintRecord> dataToPrint;
        private int printRowIndex = 0;
        private int pageNumber = 1;
        private int totalPages = 1;

        public frmExpensesList()
        {
            InitializeComponent();
        }

        private void bunifuIconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuIconButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void LoadExpenses()
        {
            dgvExpenses.Rows.Clear();
            string connectionString = DatabaseConnection.GetConnectionString();

            // **تعديل:** أضف E.ExpenseId إلى جملة SELECT
            string query = @"SELECT E.ExpenseId, E.ExpenseDate, ET.TypeName, E.Details, E.Amount 
                     FROM Expenses E JOIN ExpenseTypes ET ON E.TypeId = ET.TypeId
                     WHERE E.ExpenseDate BETWEEN @DateFrom AND @DateTo
                     ORDER BY E.ExpenseDate DESC";
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@DateFrom", dtpFrom.Value.Date);
                        cmd.Parameters.AddWithValue("@DateTo", dtpTo.Value.Date);
                        conn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            int rowIndex = dgvExpenses.Rows.Add(
                                Convert.ToDateTime(reader["ExpenseDate"]).ToString("yyyy/MM/dd"),
                                reader["TypeName"].ToString(),
                                reader["Details"].ToString(),
                                Convert.ToDecimal(reader["Amount"]).ToString("N2")
                            );

                            // **إضافة:** تخزين الـ ID في خاصية Tag الخاصة بالصف
                            dgvExpenses.Rows[rowIndex].Tag = reader["ExpenseId"];
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء تحميل المصروفات: " + ex.Message);
            }
        }
        // عند الضغط على زر البحث، يتم إعادة تحميل البيانات حسب التاريخ الجديد
        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadExpenses();
        }

        // عند الضغط على زر "إضافة"، يتم فتح فورم الإضافة
        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (frmAddExpense addForm = new frmAddExpense())
            {
                // إظهار الفورم وانتظار رد المستخدم
                // إذا قام المستخدم بالحفظ بنجاح، سيغلق الفورم مع نتيجة OK
                if (addForm.ShowDialog() == DialogResult.OK)
                {
                    // بعد الإضافة الناجحة، أعد تحميل القائمة لإظهار المصروف الجديد
                    LoadExpenses();
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmExpensesList_Load(object sender, EventArgs e)
        {
            // اضبط التاريخ الافتراضي (مثلاً، بداية الشهر الحالي ونهايته)
            dtpFrom.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtpTo.Value = DateTime.Now;

            // قم بتحميل البيانات مباشرة عند فتح الشاشة
            LoadExpenses();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvExpenses.SelectedRows.Count == 0)
            {
                MessageBox.Show("الرجاء تحديد مصروف من القائمة لتعديله.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // احصل على الـ ID من خاصية Tag التي خزنّاه فيها
            int selectedExpenseId = Convert.ToInt32(dgvExpenses.SelectedRows[0].Tag);

            // افتح فورم الإضافة في وضع التعديل
            using (frmAddExpense editForm = new frmAddExpense(selectedExpenseId))
            {
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    // بعد التعديل الناجح، قم بتحديث القائمة
                    LoadExpenses();
                }
            }
        }

        // في ملف frmExpensesList.cs
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvExpenses.SelectedRows.Count == 0)
            {
                MessageBox.Show("الرجاء تحديد مصروف من القائمة لحذفه.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // رسالة تأكيد قبل الحذف
            if (MessageBox.Show("هل أنت متأكد من أنك تريد حذف هذا المصروف؟ لا يمكن التراجع عن هذه العملية.", "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int selectedExpenseId = Convert.ToInt32(dgvExpenses.SelectedRows[0].Tag);
                string query = "DELETE FROM Expenses WHERE ExpenseId = @ExpenseId";
                string connectionString = DatabaseConnection.GetConnectionString();

                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@ExpenseId", selectedExpenseId);
                            conn.Open();
                            cmd.ExecuteNonQuery();

                            // بعد الحذف الناجح، قم بتحديث القائمة
                            LoadExpenses();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("فشل حذف المصروف: " + ex.Message);
                }
            }
        }

        // في أعلى الكلاس frmExpensesList، أضف هذا المتغير لتتبع الصفوف عند الطباعة

        // أضف هذه الدالة لزر الطباعة
        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (dgvExpenses.Rows.Count == 0)
            {
                MessageBox.Show("لا توجد بيانات لطباعتها.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // تجهيز البيانات للطباعة (هذه الدالة تبقى كما هي)
            PrepareDataForPrinting();

            // إعداد مستند الطباعة
            printDocument1.DocumentName = "تقرير المصروفات";

            // ==========================================================
            //  الكود الجديد لتحديد حجم واتجاه A4 Landscape
            // ==========================================================

            // 1. تعيين اتجاه الصفحة إلى الوضع الأفقي (بالعرض)

            // 2. إنشاء وتعيين حجم الورق A4 بالأبعاد الصحيحة (1169 عرض, 827 ارتفاع)
            // هذه الأبعاد بوحدة 1/100 من البوصة
            System.Drawing.Printing.PaperSize a4Landscape = new System.Drawing.Printing.PaperSize("A4 Landscape", 1169, 827);
            printDocument1.DefaultPageSettings.PaperSize = a4Landscape;


            // إعادة تعيين متغيرات الطباعة لكل عملية جديدة
            printRowIndex = 0;
            pageNumber = 1;

            // --- 3. عرض نافذة المعاينة ---
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.WindowState = FormWindowState.Maximized;
            printPreviewDialog1.Text = "معاينة طباعة تقرير المصروفات";
            printPreviewDialog1.ShowDialog();
        }
        private void PrepareDataForPrinting()
        {
            dataToPrint = new List<ExpensePrintRecord>();
            foreach (DataGridViewRow row in dgvExpenses.Rows)
            {
                dataToPrint.Add(new ExpensePrintRecord
                {
                    Date = row.Cells["colDate"].Value.ToString(),
                    Type = row.Cells["colExpenseType"].Value.ToString(),
                    Details = row.Cells["colDetails"].Value.ToString(),
                    Amount = Convert.ToDecimal(row.Cells["colAmount"].Value)
                });
            }
        }
        // أضف هذه الدالة الجديدة بالكامل، وهي التي ستقوم بالرسم على الصفحة
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;

            // --- تعريف الخطوط والألوان ---
            Font titleFont = new Font("Segoe UI", 20, FontStyle.Bold);
            Font headerFont = new Font("Segoe UI", 11, FontStyle.Bold);
            Font bodyFont = new Font("Segoe UI", 10, FontStyle.Regular);
            SolidBrush mainBrush = new SolidBrush(Color.Black);
            SolidBrush headerBrush = new SolidBrush(Color.White);
            SolidBrush rowBrushAlternate = new SolidBrush(Color.FromArgb(240, 240, 240));
            Pen gridPen = new Pen(Color.DarkGray, 1);

            // --- تعريف منطقة الرسم ---
            RectangleF drawArea = e.MarginBounds;
            float currentY = drawArea.Top;

            // --- رسم رأس التقرير (يتم رسمه مرة واحدة لكل صفحة جديدة) ---
            // إذا كنا في بداية التقرير، اطبع العنوان الرئيسي
            if (pageNumber == 1)
            {
                g.DrawString("تقرير المصروفات", titleFont, mainBrush, drawArea.Left, currentY);
            }
            string dateRange = $"من {dtpFrom.Value:dd/MM/yyyy} إلى {dtpTo.Value:dd/MM/yyyy}";
            g.DrawString(dateRange, bodyFont, mainBrush, drawArea.Right - g.MeasureString(dateRange, bodyFont).Width, currentY + 10);
            currentY += titleFont.GetHeight(g) + 30;

            // --- رسم رأس الجدول ---
            float colDateX = drawArea.Left;
            float colTypeX = colDateX + 120;
            float colDetailsX = colTypeX + 220;
            float colAmountX = drawArea.Right - 150;

            RectangleF headerRect = new RectangleF(drawArea.Left, currentY, drawArea.Width, headerFont.GetHeight(g) + 10);
            g.FillRectangle(new SolidBrush(Color.FromArgb(45, 52, 54)), headerRect);
            g.DrawString("التاريخ", headerFont, headerBrush, colDateX + 5, currentY + 5);
            g.DrawString("نوع المصروف", headerFont, headerBrush, colTypeX + 5, currentY + 5);
            g.DrawString("التفاصيل", headerFont, headerBrush, colDetailsX + 5, currentY + 5);
            g.DrawString("المبلغ", headerFont, headerBrush, colAmountX + 5, currentY + 5);
            currentY += headerRect.Height;

            // --- حلقة طباعة البيانات والمنطق الجديد للصفحات ---
            float rowHeight = bodyFont.GetHeight(g) + 12;
            int rowsPrintedOnThisPage = 0;

            while (printRowIndex < dataToPrint.Count)
            {
                // **التحقق من المساحة قبل الرسم**
                if (currentY + rowHeight > drawArea.Bottom)
                {
                    // إذا لم نتمكن من طباعة أي سطر في هذه الصفحة (بسبب حجم الهيدر)
                    // هذا الشرط يمنع الحلقة اللانهائية
                    if (rowsPrintedOnThisPage == 0)
                    {
                        // لا يمكن احتواء أي بيانات، هذا يعني وجود مشكلة في التصميم (الهيدر كبير جداً)
                        g.DrawString("خطأ: محتوى الصفحة أكبر من حجم الورقة.", headerFont, Brushes.Red, drawArea.Left, currentY);
                        e.HasMorePages = false; // أوقف الطباعة تماماً
                        return;
                    }

                    // هناك مساحة نفذت، اطلب صفحة جديدة
                    e.HasMorePages = true;
                    pageNumber++;
                    return; // اخرج من الدالة، سيتم استدعاؤها مرة أخرى للصفحة الجديدة
                }

                var item = dataToPrint[printRowIndex];
                RectangleF rowRect = new RectangleF(drawArea.Left, currentY, drawArea.Width, rowHeight);

                if (printRowIndex % 2 != 0)
                {
                    g.FillRectangle(rowBrushAlternate, rowRect);
                }

                g.DrawRectangle(gridPen, Rectangle.Round(rowRect));
                g.DrawString(item.Date, bodyFont, mainBrush, colDateX + 5, currentY + 6);
                g.DrawString(item.Type, bodyFont, mainBrush, colTypeX + 5, currentY + 6);
                g.DrawString(item.Details, bodyFont, mainBrush, colDetailsX + 5, currentY + 6);
                g.DrawString(item.Amount.ToString("N2"), bodyFont, mainBrush, colAmountX + 5, currentY + 6);

                currentY += rowHeight;
                printRowIndex++; // **مهم جداً: تحديث العداد بعد رسم الصف بنجاح**
                rowsPrintedOnThisPage++;
            }

            // --- رسم المجموع النهائي وتذييل الصفحة ---
            decimal grandTotal = dataToPrint.Sum(item => item.Amount);
            currentY += 15;
            g.DrawLine(gridPen, colAmountX - 20, currentY, drawArea.Right, currentY);
            string totalText = $"المجموع الإجمالي: {grandTotal:N2} درهم";
            g.DrawString(totalText, headerFont, mainBrush, drawArea.Right - g.MeasureString(totalText, headerFont).Width, currentY + 5);

            string pageString = $"صفحة {pageNumber}";
            g.DrawString(pageString, bodyFont, mainBrush, drawArea.Left, drawArea.Bottom + 5);

            // --- إنهاء عملية الطباعة ---
            e.HasMorePages = false;
            // لا تقم بإعادة تعيين العدادات هنا، بل في زر الطباعة نفسه
        }

        // **تأكد من أن كود زر الطباعة يعيد تعيين العدادات**
        
        private class ExpensePrintRecord
        {
            public string Date { get; set; }
            public string Type { get; set; }
            public string Details { get; set; }
            public decimal Amount { get; set; }
        }
    }

}
