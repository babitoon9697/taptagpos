using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TAPTAGPOS
{
    public partial class frmProfits : Form
    {  // --- متغيرات جديدة للطباعة ---
        private List<ProfitPrintRecord> dataToPrint;
        private ProfitSummaryData summaryToPrint;
        private int printRowIndex = 0;
        private int pageNumber = 1;
        public frmProfits()
        {
            InitializeComponent();
            StyleDataGridView();
        }
        private void StyleDataGridView()
        {
            // --- إعدادات عامة للجدول ---
            this.dgvProfits.BorderStyle = BorderStyle.None;
            this.dgvProfits.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 247, 251);
            this.dgvProfits.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvProfits.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 122, 204);
            this.dgvProfits.DefaultCellStyle.SelectionForeColor = Color.White;
            this.dgvProfits.BackgroundColor = Color.White;
            this.dgvProfits.RowHeadersVisible = false; // إخفاء العمود الأول الافتراضي
            this.dgvProfits.EnableHeadersVisualStyles = false;
            this.dgvProfits.DefaultCellStyle.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular);
            this.dgvProfits.RowTemplate.Height = 30; // زيادة ارتفاع الصفوف

            // --- تنسيق رأس الجدول ---
            this.dgvProfits.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DataGridViewCellStyle headerStyle = new DataGridViewCellStyle();
            headerStyle.BackColor = Color.FromArgb(45, 52, 54); // لون أزرق داكن
            headerStyle.ForeColor = Color.White;
            headerStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            headerStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgvProfits.ColumnHeadersDefaultCellStyle = headerStyle;
            this.dgvProfits.ColumnHeadersHeight = 40;

            // --- تنسيق الأعمدة ---
            // محاذاة الأرقام إلى اليسار (لأن الواجهة عربية)
            this.dgvProfits.Columns["colSales"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            this.dgvProfits.Columns["colPurchaseValue"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            this.dgvProfits.Columns["colSaleValue"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            this.dgvProfits.Columns["colProfit"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            // تنسيق الأرقام كعملة
            this.dgvProfits.Columns["colPurchaseValue"].DefaultCellStyle.Format = "N2";
            this.dgvProfits.Columns["colSaleValue"].DefaultCellStyle.Format = "N2";
            this.dgvProfits.Columns["colProfit"].DefaultCellStyle.Format = "N2";
        }
        private void frmProfits_Load(object sender, EventArgs e)
        {
            // تعيين فترة افتراضية (مثلاً، الشهر الحالي)
            dtpStartDate.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtpEndDate.Value = DateTime.Now;

            // تحميل التقرير عند فتح الشاشة
            LoadProfitsReport();
        }
        private void LoadProfitsReport()
        {
            dgvProfits.Rows.Clear();
            string connectionString = DatabaseConnection.GetConnectionString();

            // جملة SQL متقدمة لجلب وتجميع البيانات
            string query = @"
                WITH SalesData AS (
                    SELECT 
                        ti.Barcode,
                        SUM(ti.Quantity) as TotalQuantity,
                        SUM(ti.TotalPrice) as TotalSaleValue
                    FROM TransactionItems ti
                    JOIN Transactions t ON ti.TransactionID = t.TransactionID
                    WHERE t.TransactionDate BETWEEN @StartDate AND @EndDate
                    GROUP BY ti.Barcode
                )
                SELECT 
                    a.Id,
                    a.Article,
                    sd.TotalQuantity,
                    (sd.TotalQuantity * a.BuyPrice) as TotalPurchaseValue,
                    sd.TotalSaleValue,
                    (sd.TotalSaleValue - (sd.TotalQuantity * a.BuyPrice)) as Profit
                FROM SalesData sd
                JOIN Articles a ON sd.Barcode = JSON_VALUE(a.Barcodes, '$[0]') -- أو طريقة الربط المناسبة للباركود
                ORDER BY Profit DESC;
            ";

            decimal totalProfitSum = 0;
            decimal totalSalesValueSum = 0;
            decimal totalPurchaseValueSum = 0;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@StartDate", dtpStartDate.Value.Date);
                        cmd.Parameters.AddWithValue("@EndDate", dtpEndDate.Value.Date.AddDays(1).AddTicks(-1)); // لضمان شمل اليوم كاملاً

                        conn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            decimal profit = Convert.ToDecimal(reader["Profit"]);
                            decimal saleValue = Convert.ToDecimal(reader["TotalSaleValue"]);
                            decimal purchaseValue = Convert.ToDecimal(reader["TotalPurchaseValue"]);

                            dgvProfits.Rows.Add(
                                reader["Id"],
                                reader["Article"],
                                reader["TotalQuantity"],
                                purchaseValue,
                                saleValue,
                                profit
                            );

                            // تجميع الإجماليات
                            totalProfitSum += profit;
                            totalSalesValueSum += saleValue;
                            totalPurchaseValueSum += purchaseValue;
                        }
                    }
                }

                // --- حساب وعرض الإجماليات في الشريط السفلي ---
                decimal totalExpenses = GetTotalExpenses(dtpStartDate.Value.Date, dtpEndDate.Value.Date);
                decimal netProfit = totalProfitSum - totalExpenses;

                // يمكنك استخدام مربعات النصوص هذه لعرض إجماليات أخرى إذا أردت
                // txtTotalPurchase.Text = totalPurchaseValueSum.ToString("N2");
                // txtTotalSales.Text = totalSalesValueSum.ToString("N2");

                txtTotalProfit.Text = totalProfitSum.ToString("N2");
                txtExpenses.Text = totalExpenses.ToString("N2");
                txtNetProfit.Text = netProfit.ToString("N2");

            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء تحميل تقرير الأرباح: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // دالة منفصلة لجلب إجمالي المصروفات خلال فترة معينة
        private decimal GetTotalExpenses(DateTime startDate, DateTime endDate)
        {
            string query = "SELECT SUM(Amount) FROM Expenses WHERE ExpenseDate BETWEEN @StartDate AND @EndDate";
            decimal totalExpenses = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(DatabaseConnection.GetConnectionString()))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@StartDate", startDate);
                        cmd.Parameters.AddWithValue("@EndDate", endDate);
                        conn.Open();
                        object result = cmd.ExecuteScalar();
                        if (result != DBNull.Value)
                        {
                            totalExpenses = Convert.ToDecimal(result);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // يمكنك تجاهل الخطأ أو عرضه
                Console.WriteLine("Error fetching expenses: " + ex.Message);
            }
            return totalExpenses;
        }

        // ربط الأزرار بالدوال
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            LoadProfitsReport();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (dgvProfits.Rows.Count == 0)
            {
                MessageBox.Show("لا توجد بيانات لطباعتها.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // --- 1. تجهيز البيانات للطباعة ---
            PrepareDataForPrinting();

            // --- 2. إعداد مستند الطباعة ---
            printDocument1.DocumentName = "تقرير الأرباح";
            printDocument1.DefaultPageSettings.Landscape = false; // **تحديد الطباعة بالعرض**
            System.Drawing.Printing.PaperSize a4Landscape = new System.Drawing.Printing.PaperSize("A4 Landscape", 1169, 827);
            printDocument1.DefaultPageSettings.PaperSize = a4Landscape; // **تحديد حجم A4**

            // إعادة تعيين متغيرات الطباعة
            printRowIndex = 0;
            pageNumber = 1;

            // --- 3. عرض نافذة المعاينة ---
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.WindowState = FormWindowState.Maximized;
            printPreviewDialog1.Text = "معاينة تقرير الأرباح";
            printPreviewDialog1.ShowDialog();
        }

        private void PrepareDataForPrinting()
        {
            // جمع بيانات الجدول
            dataToPrint = new List<ProfitPrintRecord>();
            foreach (DataGridViewRow row in dgvProfits.Rows)
            {
                dataToPrint.Add(new ProfitPrintRecord
                {
                    Code = row.Cells["colCode"].Value?.ToString(),
                    Article = row.Cells["colArticle"].Value?.ToString(),
                    Sales = row.Cells["colSales"].Value?.ToString(),
                    PurchaseValue = Convert.ToDecimal(row.Cells["colPurchaseValue"].Value),
                    SaleValue = Convert.ToDecimal(row.Cells["colSaleValue"].Value),
                    Profit = Convert.ToDecimal(row.Cells["colProfit"].Value)
                });
            }

            // جمع بيانات الملخص
            summaryToPrint = new ProfitSummaryData
            {
                TotalProfit = decimal.Parse(txtTotalProfit.Text),
                TotalExpenses = decimal.Parse(txtExpenses.Text),
                NetProfit = decimal.Parse(txtNetProfit.Text)
            };
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            Font titleFont = new Font("Segoe UI", 20, FontStyle.Bold);
            Font headerFont = new Font("Segoe UI", 11, FontStyle.Bold);
            Font bodyFont = new Font("Segoe UI", 10, FontStyle.Regular);
            SolidBrush mainBrush = new SolidBrush(Color.Black);
            SolidBrush headerBrush = new SolidBrush(Color.White);
            SolidBrush rowBrushAlternate = new SolidBrush(Color.FromArgb(245, 247, 251));
            Pen gridPen = new Pen(Color.DarkGray, 1);

            RectangleF drawArea = e.MarginBounds;
            float currentY = drawArea.Top;

            // --- رسم رأس التقرير ---
            g.DrawString("تقرير الأرباح", titleFont, mainBrush, drawArea.Left, currentY);
            string dateRange = $"من {dtpStartDate.Value:dd/MM/yyyy} إلى {dtpEndDate.Value:dd/MM/yyyy}";
            g.DrawString(dateRange, bodyFont, mainBrush, drawArea.Right - g.MeasureString(dateRange, bodyFont).Width, currentY + 10);
            currentY += titleFont.GetHeight(g) + 30;

            // --- تعريف ورسم رأس الجدول ---
            float colCodeX = drawArea.Left;
            float colArticleX = colCodeX + 100;
            float colSalesX = colArticleX + 350;
            float colPurchaseX = colSalesX + 100;
            float colSaleX = colPurchaseX + 150;
            float colProfitX = colSaleX + 150;

            RectangleF headerRect = new RectangleF(drawArea.Left, currentY, drawArea.Width, headerFont.GetHeight(g) + 10);
            g.FillRectangle(new SolidBrush(Color.FromArgb(45, 52, 54)), headerRect);
            g.DrawString("كود", headerFont, headerBrush, colCodeX + 5, currentY + 5);
            g.DrawString("السلعة", headerFont, headerBrush, colArticleX + 5, currentY + 5);
            g.DrawString("المبيعات", headerFont, headerBrush, colSalesX + 5, currentY + 5);
            g.DrawString("قيمة الشراء", headerFont, headerBrush, colPurchaseX + 5, currentY + 5);
            g.DrawString("قيمة البيع", headerFont, headerBrush, colSaleX + 5, currentY + 5);
            g.DrawString("الربح", headerFont, headerBrush, colProfitX + 5, currentY + 5);
            currentY += headerRect.Height;

            // --- حلقة طباعة البيانات ---
            float rowHeight = bodyFont.GetHeight(g) + 12;
            int rowsPrintedOnThisPage = 0;

            while (printRowIndex < dataToPrint.Count)
            {
                if (currentY + rowHeight > drawArea.Bottom)
                {
                    e.HasMorePages = true;
                    pageNumber++;
                    return;
                }

                var item = dataToPrint[printRowIndex];
                RectangleF rowRect = new RectangleF(drawArea.Left, currentY, drawArea.Width, rowHeight);
                if (printRowIndex % 2 != 0) { g.FillRectangle(rowBrushAlternate, rowRect); }
                g.DrawRectangle(gridPen, Rectangle.Round(rowRect));

                g.DrawString(item.Code, bodyFont, mainBrush, colCodeX + 5, currentY + 6);
                g.DrawString(item.Article, bodyFont, mainBrush, colArticleX + 5, currentY + 6);
                g.DrawString(item.Sales, bodyFont, mainBrush, colSalesX + 15, currentY + 6); // Add padding for alignment
                g.DrawString(item.PurchaseValue.ToString("N2"), bodyFont, mainBrush, colPurchaseX + 15, currentY + 6);
                g.DrawString(item.SaleValue.ToString("N2"), bodyFont, mainBrush, colSaleX + 15, currentY + 6);
                g.DrawString(item.Profit.ToString("N2"), bodyFont, mainBrush, colProfitX + 15, currentY + 6);

                currentY += rowHeight;
                printRowIndex++;
                rowsPrintedOnThisPage++;
            }

            // --- رسم الملخص النهائي في آخر صفحة ---
            currentY += 25;
            g.DrawLine(gridPen, colPurchaseX - 20, currentY, drawArea.Right, currentY);
            currentY += 10;

            StringFormat rightAlign = new StringFormat { Alignment = StringAlignment.Far };
            g.DrawString($"إجمالي الأرباح: {summaryToPrint.TotalProfit:N2}", headerFont, mainBrush, drawArea.Right, currentY, rightAlign);
            currentY += headerFont.GetHeight(g) + 5;
            g.DrawString($"إجمالي المصروفات: {summaryToPrint.TotalExpenses:N2}", bodyFont, mainBrush, drawArea.Right, currentY, rightAlign);
            currentY += bodyFont.GetHeight(g) + 10;
            g.DrawString($"الربح الصافي: {summaryToPrint.NetProfit:N2}", headerFont, Brushes.Green, drawArea.Right, currentY, rightAlign);

            // --- رسم تذييل الصفحة ---
            string pageString = $"صفحة {pageNumber}";
            g.DrawString(pageString, bodyFont, mainBrush, drawArea.Left, drawArea.Bottom + 5);

            e.HasMorePages = false;
        }

        private void btnPeriod_Click(object sender, EventArgs e)
        {

        }
    }
}
