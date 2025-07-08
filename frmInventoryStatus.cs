using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Text;
using System.Windows.Forms;

namespace TAPTAGPOS
{
    public partial class frmInventoryStatus : Form
    {
        private string connectionString = DatabaseConnection.GetConnectionString();
        private DataTable inventoryData; // To hold data for filtering and printing

        // For printing
        private int currentRowToPrint = 0;

        public frmInventoryStatus()
        {
            InitializeComponent();
            // Connect events
            this.Load += frmInventoryStatus_Load;
            this.txtArticleName.TextChanged += Filter_Changed;
            this.cmbCategory.SelectedIndexChanged += Filter_Changed;
            this.btnPrint.Click += btnPrint_Click;
        }

        private void frmInventoryStatus_Load(object sender, EventArgs e)
        {
            StyleDataGridView();
            LoadCategoriesIntoComboBox();
            LoadInventoryData();
        }

        private void StyleDataGridView()
        {
            dgvInventory.AutoGenerateColumns = false;
            colArticleName.DataPropertyName = "ArticleLongName";
            colStock.DataPropertyName = "QuantityStock";
            colValue.DataPropertyName = "StockValue";
            colMinStock.DataPropertyName = "MinStock";
            colStatus.DataPropertyName = "Status";

            colValue.DefaultCellStyle.Format = "N2";
        }

        private void LoadCategoriesIntoComboBox()
        {
            try
            {
                var dt = new DataTable();
                using (var conn = new SqlConnection(connectionString))
                {
                    new SqlDataAdapter("SELECT CategoryID, CategoryName FROM ArticleCategories WHERE IsActive=1 ORDER BY CategoryName", conn).Fill(dt);
                }
                DataRow dr = dt.NewRow();
                dr["CategoryID"] = 0;
                dr["CategoryName"] = "Toutes les catégories";
                dt.Rows.InsertAt(dr, 0);

                cmbCategory.DataSource = dt;
                cmbCategory.DisplayMember = "CategoryName";
                cmbCategory.ValueMember = "CategoryID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading categories: " + ex.Message);
            }
        }

        private void Filter_Changed(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void LoadInventoryData()
        {
            try
            {
                inventoryData = new DataTable();
                string query = @"
                    SELECT 
                        a.Article as ArticleLongName, 
                        a.QuantityStock, 
                        (a.QuantityStock * a.BuyPrice) AS StockValue, 
                        a.MinStock,
                        CASE 
                            WHEN a.QuantityStock <= 0 THEN 'En Rupture'
                            WHEN a.QuantityStock < a.MinStock THEN 'Stock Bas'
                            ELSE 'OK'
                        END AS Status,
                        a.CategoryID
                    FROM Articles a
                    WHERE a.IsActive = 1
                    ORDER BY a.Article";

                using (var conn = new SqlConnection(connectionString))
                {
                    new SqlDataAdapter(query, conn).Fill(inventoryData);
                }
                ApplyFilters(); // Apply initial empty filters
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading inventory data: " + ex.Message);
            }
        }

        private void ApplyFilters()
        {
            if (inventoryData == null) return;

            StringBuilder filter = new StringBuilder("1=1"); // Start with a condition that is always true

            // Article Name Filter
            if (!string.IsNullOrWhiteSpace(txtArticleName.Text))
            {
                filter.Append($" AND Article LIKE '%{txtArticleName.Text.Replace("'", "''")}%'");
            }

            // Category Filter
            if (cmbCategory.SelectedValue != null && (int)cmbCategory.SelectedValue > 0)
            {
                filter.Append($" AND CategoryID = {(int)cmbCategory.SelectedValue}");
            }

            inventoryData.DefaultView.RowFilter = filter.ToString();
            dgvInventory.DataSource = inventoryData.DefaultView;

            CalculateTotalValue();
        }

        private void CalculateTotalValue()
        {
            decimal totalValue = 0;
            foreach (DataGridViewRow row in dgvInventory.Rows)
            {
                totalValue += Convert.ToDecimal(row.Cells["colValue"].Value ?? 0);
            }
            txtTotalValue.Text = totalValue.ToString("C2");
        }

        private void dgvInventory_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dgvInventory.Rows[e.RowIndex];

            string status = row.Cells["colStatus"].Value?.ToString() ?? "";

            if (status == "En Rupture")
            {
                row.DefaultCellStyle.BackColor = Color.FromArgb(255, 204, 204); // Light Red
            }
            else if (status == "Stock Bas")
            {
                row.DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 204); // Light Yellow
            }
            else
            {
                row.DefaultCellStyle.BackColor = Color.White;
            }
        }

        #region Printing Logic
        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (dgvInventory.Rows.Count == 0) return;

            currentRowToPrint = 0; // Reset for new print job

            PrintDocument pd = new PrintDocument();
            pd.DocumentName = "Etat du Stock";
            pd.DefaultPageSettings.Landscape = false; // Portrait is better for this list

            string printerName = AppSettingsManager.PrinterA4A5;
            if (!string.IsNullOrEmpty(printerName))
            {
                pd.PrinterSettings.PrinterName = printerName;
            }

            pd.PrintPage += PrintPage_Handler;

            PrintPreviewDialog preview = new PrintPreviewDialog { Document = pd, WindowState = FormWindowState.Maximized };
            preview.ShowDialog(this);
        }

        private void PrintPage_Handler(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            float yPos = e.MarginBounds.Top;
            float leftMargin = e.MarginBounds.Left;
            float pageWidth = e.MarginBounds.Width;
            int rowHeight = 30;

            using (Font titleFont = new Font("Arial", 16, FontStyle.Bold))
            using (Font headerFont = new Font("Arial", 10, FontStyle.Bold))
            using (Font bodyFont = new Font("Arial", 10))
            {
                g.DrawString("État Global du Stock", titleFont, Brushes.Black, leftMargin, yPos);
                yPos += 40;

                // --- Table Header ---
                float[] colWidths = { 0.40f, 0.15f, 0.15f, 0.15f, 0.15f };
                string[] headers = { "Article", "Stock Actuel", "Valeur Stock", "Stock Min", "Statut" };
                float currentX = leftMargin;
                g.FillRectangle(Brushes.LightGray, leftMargin, yPos, pageWidth, rowHeight);
                for (int i = 0; i < headers.Length; i++)
                {
                    g.DrawString(headers[i], headerFont, Brushes.Black, currentX + 5, yPos + 5);
                    currentX += pageWidth * colWidths[i];
                }
                yPos += rowHeight;

                // --- Table Rows ---
                while (currentRowToPrint < dgvInventory.Rows.Count)
                {
                    if (yPos + rowHeight > e.MarginBounds.Bottom)
                    {
                        e.HasMorePages = true;
                        return;
                    }
                    DataGridViewRow row = dgvInventory.Rows[currentRowToPrint];
                    currentX = leftMargin;
                    for (int i = 0; i < headers.Length; i++)
                    {
                        string cellValue = row.Cells[i].FormattedValue.ToString();
                        g.DrawString(cellValue, bodyFont, Brushes.Black, currentX + 5, yPos + 5);
                        currentX += pageWidth * colWidths[i];
                    }
                    yPos += rowHeight;
                    currentRowToPrint++;
                }

                // --- Footer ---
                yPos += 10;
                g.DrawString("Valeur Totale du Stock: " + txtTotalValue.Text, headerFont, Brushes.Black, leftMargin, yPos);
                e.HasMorePages = false;
            }
        }
        #endregion

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}