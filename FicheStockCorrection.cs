using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace TAPTAGPOS
{
    public partial class FicheStockCorrection : Form
    {
        private string connectionString = DatabaseConnection.GetConnectionString();
        private int _selectedWarehouseId = -1;
        // You would add pagination logic here if you have many articles
        private bool isEditMode = false;
        private int correctionId = 0;
        public FicheStockCorrection()
        {
            InitializeComponent();
            InitializeEventHandlers();
        }
        public FicheStockCorrection(int correctionIdToView) : this()
        {
            this.isEditMode = true;
            this.correctionId = correctionIdToView; // Make sure you have a "private int correctionId" variable at the top of the class
            this.Text = "Détail de la Correction de Stock";

            // Disable controls since this is a view-only mode for now
            panelTop.Enabled = false;
            panelBottomLeft.Enabled = false;
            panelRight.Enabled = false;
            dgvCorrectionLines.ReadOnly = true;
        }

        // Add this new method to load the data when viewing an existing correction
        private void LoadDataForView()
        {
            // First, load the main details
            string queryHeader = "SELECT * FROM StockCorrections WHERE CorrectionID = @ID";
            using (var conn = new SqlConnection(connectionString))
            using (var cmd = new SqlCommand(queryHeader, conn))
            {
                cmd.Parameters.AddWithValue("@ID", this.correctionId);
                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        dtpDate.Value = (DateTime)reader["CorrectionDate"];
                        cmbWarehouse.SelectedValue = reader["WarehouseID"];
                    }
                }
            }

            // Now, load the corrected items into the grid
            dgvCorrectionLines.Rows.Clear();
            string queryItems = @"
        SELECT a.Article, a.ArticleLongName, sci.OldStock, sci.NewStock, sci.Difference
        FROM StockCorrectionItems sci
        JOIN Articles a ON sci.ArticleID = a.Id
        WHERE sci.CorrectionID = @ID";
            using (var conn = new SqlConnection(connectionString))
            using (var cmd = new SqlCommand(queryItems, conn))
            {
                cmd.Parameters.AddWithValue("@ID", this.correctionId);
                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        dgvCorrectionLines.Rows.Add(
                            reader["Article"],
                            reader["ArticleLongName"],
                            reader["OldStock"],
                            reader["NewStock"],
                            reader["Difference"]
                        );
                    }
                }
            }
        }

        private void InitializeEventHandlers()
        {
            this.Load += FicheStockCorrection_Load;
            this.btnConfirm.Click += btnConfirm_Click;
            this.cmbWarehouse.SelectedIndexChanged += (s, e) => LoadArticlesForSelectedWarehouse();
            this.dgvCorrectionLines.CellValueChanged += dgvCorrectionLines_CellValueChanged;
            this.btnClose.Click += (s, e) => this.Close();
        }

        #region Data Loading and UI Setup

        private void FicheStockCorrection_Load(object sender, EventArgs e)
        {
            LoadWarehouses();
            if (isEditMode)
            {
                LoadDataForView(); // Call the new method for viewing
            }
            else
            {
                // Logic for a new correction (this part is already correct)
                if (cmbWarehouse.Items.Count > 0)
                {
                    cmbWarehouse.SelectedIndex = 0;
                }
            }
        }

        private void LoadWarehouses()
        {
            try
            {
                var dt = new DataTable();
                using (var conn = new SqlConnection(connectionString))
                using (var adapter = new SqlDataAdapter("SELECT WarehouseID, WarehouseName FROM Warehouses WHERE IsActive=1 ORDER BY WarehouseName", conn))
                {
                    adapter.Fill(dt);
                }
                cmbWarehouse.DataSource = dt;
                cmbWarehouse.DisplayMember = "WarehouseName";
                cmbWarehouse.ValueMember = "WarehouseID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ في تحميل المستودعات: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadArticlesForSelectedWarehouse()
        {
            if (cmbWarehouse.SelectedValue == null) return;
            _selectedWarehouseId = (int)cmbWarehouse.SelectedValue;

            // Clear existing article tiles
            tablelayout_articlescontroluser.Controls.Clear();

            string query = @"
                SELECT a.Id, a.Article, a.ArticleLongName, a.ArticlePicture, ISNULL(s.Quantity, 0) as Stock
                FROM Articles a
                LEFT JOIN ArticleStock s ON a.Id = s.ArticleID AND s.WarehouseID = @WarehouseID
                WHERE a.IsActive = 1
                ORDER BY a.Article";
            try
            {
                using (var conn = new SqlConnection(connectionString))
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@WarehouseID", _selectedWarehouseId);
                    conn.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Image articleImage = null;
                            if (reader["ArticlePicture"] != DBNull.Value)
                            {
                                byte[] imgBytes = (byte[])reader["ArticlePicture"];
                                using (var ms = new System.IO.MemoryStream(imgBytes))
                                {
                                    articleImage = Image.FromStream(ms);
                                }
                            }

                            var tile = new ArticleTileControl(
                                (int)reader["Id"],
                                reader["Article"].ToString(),
                                reader["ArticleLongName"].ToString(),
                                (decimal)reader["Stock"],
                                articleImage
                            );

                            tile.Click += ArticleTile_Click; // Wire up the click event
                            tablelayout_articlescontroluser.Controls.Add(tile);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading articles: " + ex.Message);
            }
        }

        #endregion

        #region Interaction Logic

        private void ArticleTile_Click(object sender, EventArgs e)
        {
            var tile = sender as ArticleTileControl;
            if (tile == null) return;

            // Check if the item is already in the correction grid
            foreach (DataGridViewRow existingRow in dgvCorrectionLines.Rows)
            {
                if ((int)existingRow.Tag == tile.ArticleID)
                {
                    dgvCorrectionLines.ClearSelection();
                    existingRow.Selected = true;
                    return;
                }
            }

            string newQtyStr = Interaction.InputBox($"أدخل المخزون الفعلي الجديد لـ:\n{tile.Text}", "تصحيح المخزون", "0");
            if (decimal.TryParse(newQtyStr, out decimal newStock))
            {
                decimal oldStock = GetCurrentStock(tile.ArticleID, _selectedWarehouseId);
                int rowIndex = dgvCorrectionLines.Rows.Add();
                var row = dgvCorrectionLines.Rows[rowIndex];
                row.Tag = tile.ArticleID;
                row.Cells["colRef"].Value = tile.ArticleCode;
                row.Cells["colDesignation"].Value = tile.Text;
                row.Cells["colOldStock"].Value = oldStock;
                row.Cells["colNewStock"].Value = newStock;
                row.Cells["colDifference"].Value = newStock - oldStock;
            }
        }

        private decimal GetCurrentStock(int articleId, int warehouseId)
        {
            string query = "SELECT Quantity FROM ArticleStock WHERE ArticleID = @AID AND WarehouseID = @WID";
            using (var conn = new SqlConnection(connectionString))
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@AID", articleId);
                cmd.Parameters.AddWithValue("@WID", warehouseId);
                conn.Open();
                object result = cmd.ExecuteScalar();
                return result != null ? Convert.ToDecimal(result) : 0;
            }
        }

        private void dgvCorrectionLines_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvCorrectionLines.Columns[e.ColumnIndex].Name == "colNewStock")
            {
                var row = dgvCorrectionLines.Rows[e.RowIndex];
                decimal oldStock = Convert.ToDecimal(row.Cells["colOldStock"].Value ?? 0);
                decimal newStock;
                if (decimal.TryParse(row.Cells["colNewStock"].Value?.ToString(), out newStock))
                {
                    row.Cells["colDifference"].Value = newStock - oldStock;
                }
            }
        }

        #endregion

        #region Save Logic

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            SaveStockCorrection();
        }

        private void SaveStockCorrection()
        {
            if (dgvCorrectionLines.Rows.Count == 0)
            {
                MessageBox.Show("الرجاء إضافة سلعة واحدة على الأقل تم تصحيحها قبل الحفظ.", "خطأ في الإدخال", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                var transaction = conn.BeginTransaction();
                try
                {
                    // Step 1: Create the main StockCorrections record
                    string queryMain = "INSERT INTO StockCorrections (CorrectionDate, WarehouseID, UserID) OUTPUT INSERTED.CorrectionID VALUES (@Date, @WID, @User)";
                    int newCorrectionId;
                    using (var cmd = new SqlCommand(queryMain, conn, transaction))
                    {
                        cmd.Parameters.AddWithValue("@Date", dtpDate.Value);
                        cmd.Parameters.AddWithValue("@WID", _selectedWarehouseId);
                        cmd.Parameters.AddWithValue("@User", "Admin"); // Replace with actual logged-in user
                        newCorrectionId = (int)cmd.ExecuteScalar();
                    }

                    // Step 2: Loop through the grid and process each correction
                    foreach (DataGridViewRow row in dgvCorrectionLines.Rows)
                    {
                        int articleId = (int)row.Tag;
                        decimal oldStock = Convert.ToDecimal(row.Cells["colOldStock"].Value);
                        decimal newStock = Convert.ToDecimal(row.Cells["colNewStock"].Value);
                        decimal difference = newStock - oldStock;

                        // a. INSERT into StockCorrectionItems
                        string queryItem = "INSERT INTO StockCorrectionItems (CorrectionID, ArticleID, OldStock, NewStock) VALUES (@CID, @AID, @Old, @New)";
                        using (var cmd = new SqlCommand(queryItem, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@CID", newCorrectionId);
                            cmd.Parameters.AddWithValue("@AID", articleId);
                            cmd.Parameters.AddWithValue("@Old", oldStock);
                            cmd.Parameters.AddWithValue("@New", newStock);
                            cmd.ExecuteNonQuery();
                        }

                        // b. INSERT into ArticleStockHistory
                        string queryHistory = "INSERT INTO ArticleStockHistory (ChangeDate, ArticleID, WarehouseID, Quantity, Reason) VALUES (@Date, @AID, @WID, @Qty, @Reason)";
                        using (var cmd = new SqlCommand(queryHistory, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@Date", dtpDate.Value);
                            cmd.Parameters.AddWithValue("@AID", articleId);
                            cmd.Parameters.AddWithValue("@WID", _selectedWarehouseId);
                            cmd.Parameters.AddWithValue("@Qty", difference);
                            cmd.Parameters.AddWithValue("@Reason", "Stock Correction");
                            cmd.ExecuteNonQuery();
                        }

                        // c. UPDATE (or INSERT) ArticleStock table
                        string queryStock = @"
                            MERGE ArticleStock AS target
                            USING (SELECT @AID AS ArticleID, @WID AS WarehouseID) AS source
                            ON (target.ArticleID = source.ArticleID AND target.WarehouseID = source.WarehouseID)
                            WHEN MATCHED THEN UPDATE SET Quantity = @NewStock
                            WHEN NOT MATCHED THEN INSERT (ArticleID, WarehouseID, Quantity) VALUES (@AID, @WID, @NewStock);";
                        using (var cmd = new SqlCommand(queryStock, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@AID", articleId);
                            cmd.Parameters.AddWithValue("@WID", _selectedWarehouseId);
                            cmd.Parameters.AddWithValue("@NewStock", newStock);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    // 3. Recalculate and UPDATE aggregate stock in the main Articles table
                    var updatedArticleIds = dgvCorrectionLines.Rows.Cast<DataGridViewRow>().Select(r => (int)r.Tag).Distinct().ToList();
                    foreach (int id in updatedArticleIds)
                    {
                        string queryUpdateTotal = "UPDATE Articles SET QuantityStock = (SELECT SUM(Quantity) FROM ArticleStock WHERE ArticleID = @AID) WHERE Id = @AID";
                        using (var cmd = new SqlCommand(queryUpdateTotal, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@AID", id);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    transaction.Commit();
                    MessageBox.Show("تم حفظ تصحيح المخزون بنجاح!", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("خطأ في حفظ تصحيح المخزون: " + ex.Message, "خطأ فادح", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        #endregion
    }
}