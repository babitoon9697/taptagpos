using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TAPTAGPOS
{
    public partial class Stock : Form
    {
        public Stock()
        {
            InitializeComponent();
            // تطبيق التنسيق على الجدول
            StyleDataGridView(this.dgv_StockeState);

            // --- ربط كل الفلاتر بحدث واحد ---
            this.cmbDepot.SelectedIndexChanged += new System.EventHandler(this.Filter_Changed);
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.Filter_Changed);
            this.cmbStockstate.SelectedIndexChanged += new System.EventHandler(this.Filter_Changed);
            this.TxtArticleName.TextChanged += new System.EventHandler(this.Filter_Changed);
        }

        private void Stock_Load(object sender, EventArgs e)
        {
            // تعبئة القوائم المنسدلة وتحميل البيانات
            LoadCategories();
            LoadDepots();
            cmbStockstate.SelectedIndex = 0;
            LoadStockStateData();
        }

        // --- دوال أزرار شريط العنوان ---
        private void bunifuIconButton1_Click(object sender, EventArgs e) => this.Close();
        private void bunifuIconButton2_Click(object sender, EventArgs e) => this.WindowState = FormWindowState.Minimized;

        // --- دوال تعبئة القوائم المنسدلة ---
        private void LoadCategories()
        {
            try
            {
                var dt = new DataTable();
                dt.Columns.Add("CategoryName", typeof(string));
                dt.Rows.Add("الكل");

                using (var conn = new SqlConnection(DatabaseConnection.GetConnectionString()))
                using (var adapter = new SqlDataAdapter("SELECT DISTINCT Categorie FROM Articles WHERE Categorie IS NOT NULL AND Categorie <> ''", conn))
                {
                    adapter.Fill(dt);
                }
                cmbCategory.DataSource = dt;
                cmbCategory.DisplayMember = "CategoryName";
            }
            catch (Exception ex) { MessageBox.Show("خطأ في تحميل الفئات: " + ex.Message); }
        }

        private void LoadDepots()
        {
            try
            {
                var dt = new DataTable();
                // إضافة خيار "الكل"
                dt.Columns.Add("WarehouseID", typeof(int));
                dt.Columns.Add("WarehouseName", typeof(string));
                dt.Rows.Add(0, "الكل"); // 0 هي القيمة المميزة لخيار "الكل"

                using (var conn = new SqlConnection(DatabaseConnection.GetConnectionString()))
                using (var adapter = new SqlDataAdapter("SELECT WarehouseID, WarehouseName FROM Warehouses ORDER BY WarehouseName", conn))
                {
                    adapter.Fill(dt);
                }
                cmbDepot.DataSource = dt;
                cmbDepot.DisplayMember = "WarehouseName";
                cmbDepot.ValueMember = "WarehouseID";
            }
            catch (Exception ex) { MessageBox.Show("خطأ في تحميل المخازن: " + ex.Message); }
        }

        // --- الدالة الرئيسية لجلب البيانات ---
        private void LoadStockStateData()
        {
            dgv_StockeState.Rows.Clear();
            string connectionString = DatabaseConnection.GetConnectionString();

            var queryBuilder = new StringBuilder(@"
                SELECT 
                    a.Id, 
                    a.Article, 
                    ISNULL(ast.Quantity, 0) as Quantity, 
                    (ISNULL(ast.Quantity, 0) * a.BuyPrice) as TotalValue
                FROM Articles a
                LEFT JOIN ArticleStock ast ON a.Id = ast.ArticleID
                WHERE 1=1");

            var parameters = new Dictionary<string, object>();

            // فلترة حسب اسم المنتج
            if (!string.IsNullOrWhiteSpace(TxtArticleName.Text))
            {
                queryBuilder.Append(" AND a.Article LIKE @ArticleName");
                parameters["@ArticleName"] = "%" + TxtArticleName.Text + "%";
            }
            // فلترة حسب الفئة
            if (cmbCategory.SelectedIndex > 0)
            {
                queryBuilder.Append(" AND a.Categorie = @Category");
                parameters["@Category"] = cmbCategory.Text;
            }
            // فلترة حسب المخزن
            if (cmbDepot.SelectedIndex > 0)
            {
                queryBuilder.Append(" AND ast.WarehouseID = @WarehouseID");
                parameters["@WarehouseID"] = (int)cmbDepot.SelectedValue;
            }
            // فلترة حسب حالة المخزون
            string stockState = cmbStockstate.Text;
            if (stockState == "متوفر")
            {
                queryBuilder.Append(" AND ISNULL(ast.Quantity, 0) > 0");
            }
            else if (stockState == "الغير متوفر")
            {
                queryBuilder.Append(" AND ISNULL(ast.Quantity, 0) <= 0");
            }

            queryBuilder.Append(" ORDER BY a.Article");

            try
            {
                using (var conn = new SqlConnection(connectionString))
                using (var cmd = new SqlCommand(queryBuilder.ToString(), conn))
                {
                    foreach (var p in parameters)
                    {
                        cmd.Parameters.Add(new SqlParameter(p.Key, p.Value));
                    }

                    conn.Open();
                    var reader = cmd.ExecuteReader();
                    decimal totalStockValue = 0;

                    dgv_StockeState.Rows.Clear();
                    while (reader.Read())
                    {
                        decimal quantity = Convert.ToDecimal(reader["Quantity"]);
                        decimal value = Convert.ToDecimal(reader["TotalValue"]);

                        int rowIndex = dgv_StockeState.Rows.Add(
                            reader["Id"],
                            reader["Article"],
                            quantity,
                            value
                        );

                        if (quantity <= 0)
                        {
                            dgv_StockeState.Rows[rowIndex].DefaultCellStyle.BackColor = Color.FromArgb(255, 204, 204);
                        }

                        totalStockValue += value;
                    }
                    txtTotalValue.Text = totalStockValue.ToString("C2");
                }
            }
            catch (Exception ex) { MessageBox.Show("خطأ في تحميل حالة المخزون: " + ex.Message); }
        }

        // دالة يتم استدعاؤها عند تغيير أي فلتر
        private void Filter_Changed(object sender, EventArgs e)
        {
            LoadStockStateData();
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

        // --- متغيرات للطباعة على مستوى الكلاس ---
        private List<StockStatePrintItem> dataToPrint;
        private int printRowIndex = 0;
        private int pageNumber = 1;

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (dgv_StockeState.Rows.Count == 0)
            {
                MessageBox.Show("لا توجد بيانات لطباعتها.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // 1. تجهيز البيانات للطباعة
            dataToPrint = new List<StockStatePrintItem>();
            foreach (DataGridViewRow row in dgv_StockeState.Rows)
            {
                if (row.IsNewRow) continue;
                dataToPrint.Add(new StockStatePrintItem
                {
                    ID = row.Cells["ID"].Value?.ToString() ?? "",
                    ArticleName = row.Cells["ArticleName"].Value?.ToString() ?? "",
                    Quantity = Convert.ToDecimal(row.Cells["Quantity"].Value ?? 0),
                    TotalPrice = Convert.ToDecimal(row.Cells["TotalPrice"].Value ?? 0)
                });
            }

            // 2. إعداد مستند الطباعة
            PrintDocument pd = new PrintDocument();
            pd.DocumentName = "تقرير حالة المخزون";
            pd.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("A4", 827, 1169);
            pd.DefaultPageSettings.Margins = new Margins(50, 50, 50, 50);

            printRowIndex = 0;
            pageNumber = 1;

            // 3. عرض المعاينة
            pd.PrintPage += new PrintPageEventHandler(this.printDocument1_PrintPage);
            printPreviewDialog1.Document = pd;
            printPreviewDialog1.ShowDialog();
            pd.PrintPage -= new PrintPageEventHandler(this.printDocument1_PrintPage);
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            using (Font titleFont = new Font("Arial", 16, FontStyle.Bold))
            using (Font headerFont = new Font("Arial", 10, FontStyle.Bold))
            using (Font bodyFont = new Font("Arial", 10))
            using (Pen blackPen = new Pen(Color.Black, 1))
            {
                float yPos = e.MarginBounds.Top;
                float leftMargin = e.MarginBounds.Left;
                float printableWidth = e.MarginBounds.Width;

                // رسم رأس التقرير
                g.DrawString("تقرير حالة المخزون", titleFont, Brushes.Black, new PointF(printableWidth / 2, yPos), new StringFormat { Alignment = StringAlignment.Center });
                yPos += titleFont.GetHeight(g) + 30;

                // رسم رأس الجدول
                float tableHeaderY = yPos;
                float colIdX = leftMargin;
                float colNameX = colIdX + 100;
                float colQtyX = colNameX + 350;
                float colValueX = colQtyX + 150;

                g.FillRectangle(Brushes.LightGray, leftMargin, tableHeaderY, printableWidth, headerFont.GetHeight(g) + 4);
                g.DrawString("ID", headerFont, Brushes.Black, colIdX + 5, tableHeaderY + 2);
                g.DrawString("إسم المنتوج", headerFont, Brushes.Black, colNameX + 5, tableHeaderY + 2);
                g.DrawString("الكمية المتوفرة", headerFont, Brushes.Black, colQtyX + 5, tableHeaderY + 2);
                g.DrawString("القيمة بالدرهم", headerFont, Brushes.Black, colValueX + 5, tableHeaderY + 2);
                yPos += headerFont.GetHeight(g) + 4;

                // رسم البيانات
                float rowHeight = bodyFont.GetHeight(g) + 8;
                while (printRowIndex < dataToPrint.Count)
                {
                    if (yPos + rowHeight > e.MarginBounds.Bottom)
                    {
                        e.HasMorePages = true;
                        pageNumber++;
                        return;
                    }
                    var item = dataToPrint[printRowIndex];
                    g.DrawLine(Pens.Gray, leftMargin, yPos, e.MarginBounds.Right, yPos);
                    g.DrawString(item.ID, bodyFont, Brushes.Black, colIdX + 5, yPos + 4);
                    g.DrawString(item.ArticleName, bodyFont, Brushes.Black, colNameX + 5, yPos + 4);
                    g.DrawString(item.Quantity.ToString("N2"), bodyFont, Brushes.Black, colQtyX + 5, yPos + 4);
                    g.DrawString(item.TotalPrice.ToString("C2"), bodyFont, Brushes.Black, colValueX + 5, yPos + 4);

                    yPos += rowHeight;
                    printRowIndex++;
                }

                // رسم الإجمالي والتذييل
                decimal grandTotal = dataToPrint.Sum(item => item.TotalPrice);
                yPos += 20;
                g.DrawString($"القيمة الإجمالية للمخزون: {grandTotal:C2}", headerFont, Brushes.Black, new PointF(e.MarginBounds.Right, yPos), new StringFormat { Alignment = StringAlignment.Far });

                g.DrawString($"صفحة {pageNumber}", bodyFont, Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Bottom + 10);

                e.HasMorePages = false;
            }
        }
    }
}