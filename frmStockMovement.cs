using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Text;
using System.Windows.Forms;

namespace TAPTAGPOS
{
    public partial class frmStockMovement : Form
    {
        private string connectionString = DatabaseConnection.GetConnectionString();
        private DataTable stockMovementData;
        private int printRowIndex = 0;

        public frmStockMovement()
        {
            InitializeComponent();
            InitializeEventHandlers();
        }

        private void InitializeEventHandlers()
        {
            this.Load += frmStockMovement_Load;
            this.dgvStockMovement.CellFormatting += dgvStockMovement_CellFormatting;
            this.txtDesignation.TextChanged += Filter_Changed;
            this.cmbCategory.SelectedIndexChanged += Filter_Changed;
            this.btnDetail.Click += btnDetail_Click;
            this.btnPrint.Click += btnPrint_Click;
        }

        private void frmStockMovement_Load(object sender, EventArgs e)
        {
            StyleDataGridView();
            LoadCategories();
            LoadStockMovementData();
        }

        #region Data Loading & Filtering

        private void LoadCategories()
        {
            try
            {
                var dt = new DataTable();
                using (var conn = new SqlConnection(connectionString))
                {
                    new SqlDataAdapter("SELECT CategoryID, CategoryName FROM ArticleCategories WHERE IsActive=1", conn).Fill(dt);
                }
                DataRow dr = dt.NewRow();
                dr["CategoryID"] = 0;
                dr["CategoryName"] = "Toutes les Familles";
                dt.Rows.InsertAt(dr, 0);

                cmbCategory.DataSource = dt;
                cmbCategory.DisplayMember = "CategoryName";
                cmbCategory.ValueMember = "CategoryID";
            }
            catch (Exception ex) { MessageBox.Show("Error loading categories: " + ex.Message); }
        }

        private void LoadStockMovementData()
        {
            // For this complex report, we use a Stored Procedure for clarity and performance.
            // You will need to create this stored procedure in your database (see instructions below).
            try
            {
                stockMovementData = new DataTable();
                using (var conn = new SqlConnection(connectionString))
                using (var cmd = new SqlCommand("sp_GetStockMovement", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    // Pass the date range to the stored procedure
                    cmd.Parameters.AddWithValue("@StartDate", dtpDateDebut.Value.Date);
                    cmd.Parameters.AddWithValue("@EndDate", dtpDateFin.Value.Date.AddDays(1).AddSeconds(-1));

                    var adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(stockMovementData);
                }

                ApplyFilters(); // Apply filters to the loaded data
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading stock movement data: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Filter_Changed(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void ApplyFilters()
        {
            if (stockMovementData == null) return;

            var filter = new StringBuilder("1=1");

            if (!string.IsNullOrWhiteSpace(txtDesignation.Text))
            {
                filter.Append($" AND Designation LIKE '%{txtDesignation.Text.Replace("'", "''")}%'");
            }
            if (cmbCategory.SelectedValue != null && cmbCategory.SelectedValue != DBNull.Value)
            {
                int categoryId = Convert.ToInt32(cmbCategory.SelectedValue);
                if (categoryId > 0) // Only apply the filter if a specific category is chosen
                {
                    filter.Append($" AND CategoryID = {categoryId}");
                }
            }

            stockMovementData.DefaultView.RowFilter = filter.ToString();
            dgvStockMovement.DataSource = stockMovementData.DefaultView;
        }

        #endregion

        #region UI and Event Handlers

        private void StyleDataGridView()
        {
            dgvStockMovement.AutoGenerateColumns = false;
            colReference.DataPropertyName = "ArticleCode";
            colDesignation.DataPropertyName = "Designation";
            colStockInitial.DataPropertyName = "InitialStock";
            colEntries.DataPropertyName = "Entries";
            colExits.DataPropertyName = "Exits";
            colStock.DataPropertyName = "FinalStock";
            colStockAlert.DataPropertyName = "StockAlert";
        }

        private void dgvStockMovement_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dgvStockMovement.Rows[e.RowIndex];

            decimal.TryParse(row.Cells["colStock"].Value?.ToString(), out decimal stock);
            decimal.TryParse(row.Cells["colStockAlert"].Value?.ToString(), out decimal alertStock);

            if (stock <= 0)
            {
                row.DefaultCellStyle.BackColor = Color.FromArgb(255, 204, 204);
            }
            else if (alertStock > 0 && stock <= alertStock)
            {
                row.DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 204);
            }
            else
            {
                row.DefaultCellStyle.BackColor = Color.White;
            }
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            if (dgvStockMovement.SelectedRows.Count == 0) return;

            // Assuming the first column 'colReference' holds the ArticleID or a unique code.
            int articleId = Convert.ToInt32(dgvStockMovement.SelectedRows[0].Cells["colReference"].Value);
            using (var detailForm = new FormSuiviArticle(articleId))
            {
                detailForm.ShowDialog(this);
            }
        }

        #endregion

        #region Printing
        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (dgvStockMovement.Rows.Count == 0) return;

            printRowIndex = 0;

            PrintDocument pd = new PrintDocument();
            pd.DocumentName = "Mouvement Du Stock";
            pd.DefaultPageSettings.Landscape = true;
            pd.PrintPage += printDocument1_PrintPage;

            PrintPreviewDialog preview = new PrintPreviewDialog { Document = pd, WindowState = FormWindowState.Maximized };
            preview.ShowDialog(this);
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            // This is a simplified printing logic. You can expand it as needed.
            Graphics g = e.Graphics;
            float yPos = e.MarginBounds.Top;
            float leftMargin = e.MarginBounds.Left;
            int rowHeight = 30;

            using (Font titleFont = new Font("Arial", 14, FontStyle.Bold))
            using (Font headerFont = new Font("Arial", 9, FontStyle.Bold))
            using (Font bodyFont = new Font("Arial", 9))
            {
                g.DrawString("Mouvement du Stock", titleFont, Brushes.Black, leftMargin, yPos);
                yPos += 40;

                // Draw header
                float[] colWidths = { 0.10f, 0.30f, 0.12f, 0.12f, 0.12f, 0.12f, 0.12f };
                string[] headers = { "Réf.", "Désignation", "Stock Initial", "Entrées", "Sorties", "Stock Final", "Stock Alerte" };
                float currentX = leftMargin;
                for (int i = 0; i < headers.Length; i++)
                {
                    g.DrawString(headers[i], headerFont, Brushes.Black, currentX + 3, yPos);
                    currentX += e.MarginBounds.Width * colWidths[i];
                }
                yPos += rowHeight;

                // Draw rows
                while (printRowIndex < dgvStockMovement.Rows.Count)
                {
                    if (yPos + rowHeight > e.MarginBounds.Bottom)
                    {
                        e.HasMorePages = true;
                        return;
                    }
                    DataGridViewRow row = dgvStockMovement.Rows[printRowIndex];
                    currentX = leftMargin;
                    for (int i = 0; i < dgvStockMovement.Columns.Count; i++)
                    {
                        g.DrawString(row.Cells[i].FormattedValue.ToString(), bodyFont, Brushes.Black, currentX + 3, yPos);
                        currentX += e.MarginBounds.Width * colWidths[i];
                    }
                    yPos += rowHeight;
                    printRowIndex++;
                }

                e.HasMorePages = false;
            }
        }
        #endregion
        private class StockMovementPrintRecord

        {

            public string Reference { get; set; }

            public string Designation { get; set; }

            public decimal InitialStock { get; set; }

            public decimal Entries { get; set; }

            public decimal Exits { get; set; }

            public decimal Stock { get; set; }

            public decimal StockAlert { get; set; }

        }

        public class StockMovementPrintItem

        {

            public string Reference { get; set; }

            public string Designation { get; set; }

            public decimal StockInitial { get; set; }

            public decimal Entries { get; set; }

            public decimal Exits { get; set; }

            public decimal Stock { get; set; }

            public decimal StockAlert { get; set; }

        }

        public class StockMovementReportData

        {

            public string ReportTitle { get; set; }

            public string CompanyName { get; set; }

            public string CompanyAddress { get; set; }

            public string CompanyPhone { get; set; }

            public DateTime PrintDate { get; set; }

            public List<StockMovementPrintItem> Items { get; set; }



            public StockMovementReportData()

            {

                Items = new List<StockMovementPrintItem>();

            }

        }
    }
}