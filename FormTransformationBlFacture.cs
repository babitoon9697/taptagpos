using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TAPTAGPOS
{
    public class BonLivraisonItemData
    {
        public int BL_ID { get; set; }
        public int ArticleID { get; set; }
        public string BL_Number { get; set; }
        public string Reference { get; set; }
        public string Designation { get; set; }
        public decimal Quantity { get; set; }
        public decimal UnitPriceHT { get; set; }
        public decimal TVA_Rate { get; set; }
        public decimal TotalTTC { get; set; }
    }
    public partial class FormTransformationBlFacture : Form
    {
        private string connectionString = DatabaseConnection.GetConnectionString();
        private int _clientId;
        private List<int> _blIds; // The IDs of the delivery notes to be invoiced
        private List<BonLivraisonItemData> _sourceItems = new List<BonLivraisonItemData>();

        public FormTransformationBlFacture(int clientId, List<int> blIds)
        {
            InitializeComponent();
            _clientId = clientId;
            _blIds = blIds;

            // Link all events to their methods
            this.Load += FormTransformationBlFacture_Load;
            this.btnAjouterUn.Click += (s, e) => MoveSelectedRows(dgvSource, dgvDestination);
            this.btnAjouterTous.Click += (s, e) => MoveAllRows(dgvSource, dgvDestination);
            this.btnSupprimerUn.Click += (s, e) => MoveSelectedRows(dgvDestination, dgvSource);
            this.btnSupprimerTous.Click += (s, e) => MoveAllRows(dgvDestination, dgvSource);
            this.btnValider.Click += btnValider_Click;
        }

        private void FormTransformationBlFacture_Load(object sender, EventArgs e)
        {
            LoadHeaderInfo();
            LoadSourceItems();
            GenerateNewInvoiceNumber();
        }
        private void MoveSelectedRows(DataGridView source, DataGridView destination)
        {
            var selectedRows = source.SelectedRows.Cast<DataGridViewRow>().ToList();
            foreach (DataGridViewRow row in selectedRows)
            {
                var itemData = (BonLivraisonItemData)row.Tag;
                AddRowToGrid(destination, itemData);
                source.Rows.Remove(row);
            }
            RecalculateTotals();
        }
        private void MoveAllRows(DataGridView source, DataGridView destination)
        {
            var allRows = source.Rows.Cast<DataGridViewRow>().ToList();
            foreach (DataGridViewRow row in allRows)
            {
                var itemData = (BonLivraisonItemData)row.Tag;
                AddRowToGrid(destination, itemData);
            }
            source.Rows.Clear();
            RecalculateTotals();
        }

        private void AddRowToGrid(DataGridView grid, BonLivraisonItemData item)
        {
            int rowIndex = grid.Rows.Add();
            DataGridViewRow row = grid.Rows[rowIndex];
            row.Tag = item; // Store the full object

            if (grid == dgvSource)
            {
                row.Cells["colSourceBL"].Value = item.BL_Number;
                // ... populate other source columns ...
            }
            else // dgvDestination
            {
                row.Cells["colDestBL"].Value = item.BL_Number;
                // ... populate other destination columns ...
            }
        }

        private void LoadHeaderInfo()
        {
            try
            {
                using (var conn = new SqlConnection(connectionString))
                using (var cmd = new SqlCommand("SELECT CustomerCode, CustomerName FROM Customers WHERE CustomerID = @ID", conn))
                {
                    cmd.Parameters.AddWithValue("@ID", _clientId);
                    conn.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtClientCode.Text = reader["CustomerCode"]?.ToString();
                            txtClientName.Text = reader["CustomerName"]?.ToString();
                        }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Error loading client info: " + ex.Message); }
        }

        private void LoadSourceItems()
        {
            _sourceItems.Clear();
            dgvSource.Rows.Clear();
            if (_blIds == null || !_blIds.Any()) return;

            var paramNames = _blIds.Select((id, index) => "@ID" + index).ToList();
            string inClause = string.Join(",", paramNames);

            string query = $@"
                SELECT bl.BL_ID, bl.BL_Number, bli.ArticleID, a.Article, bli.Quantity, bli.UnitPriceHT, bli.TVA_Rate
                FROM BonLivraisonItems bli
                JOIN BonLivraisons bl ON bli.BL_ID = bl.BL_ID
                JOIN Articles a ON bli.ArticleID = a.Id
                WHERE bli.BL_ID IN ({inClause})";

            try
            {
                using (var conn = new SqlConnection(connectionString))
                using (var cmd = new SqlCommand(query, conn))
                {
                    for (int i = 0; i < paramNames.Count; i++)
                    {
                        cmd.Parameters.AddWithValue(paramNames[i], _blIds[i]);
                    }
                    conn.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var item = new BonLivraisonItemData
                            {
                                BL_ID = (int)reader["BL_ID"],
                                BL_Number = reader["BL_Number"].ToString(),
                                ArticleID = (int)reader["ArticleID"],
                                Reference = reader["Article"].ToString(),
                                Designation = reader["ArticleLongName"].ToString(),
                                Quantity = (decimal)reader["Quantity"],
                                UnitPriceHT = (decimal)reader["UnitPriceHT"],
                                TVA_Rate = (decimal)reader["TVA_Rate"]
                            };
                            _sourceItems.Add(item);
                            AddRowToGrid(dgvSource, item);
                        }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Error loading delivery note items: " + ex.Message); }
        }
        // --- Helper method to generate the new invoice number ---
        private void GenerateNewInvoiceNumber()
        {
            // Fetches the next available number from your central settings
            int nextSerial = AppSettingsManager.SerieFacture;
            txtNumFacture.Text = $"FAC-{DateTime.Now:yyyy}-{nextSerial:D5}";
        }

        // --- Helper method to save the main invoice header ---
        // This returns the ID of the newly created invoice.
        private int SaveInvoiceHeader(SqlConnection conn, SqlTransaction transaction)
        {
            RecalculateTotals(); // Ensure totals are correct before saving

            string query = @"
        INSERT INTO SalesInvoices (InvoiceNumber, InvoiceDate, CustomerID, TotalHT, TotalTVA, TotalTTC) 
        OUTPUT INSERTED.InvoiceID 
        VALUES (@Num, @Date, @CID, @HT, @TVA, @TTC)";

            using (var cmd = new SqlCommand(query, conn, transaction))
            {
                cmd.Parameters.AddWithValue("@Num", txtNumFacture.Text);
                cmd.Parameters.AddWithValue("@Date", dtpDate.Value);
                cmd.Parameters.AddWithValue("@CID", _clientId);
                cmd.Parameters.AddWithValue("@HT", Convert.ToDecimal(txtTotalHT.Text));
                cmd.Parameters.AddWithValue("@TVA", Convert.ToDecimal(txtTVA.Text));
                cmd.Parameters.AddWithValue("@TTC", Convert.ToDecimal(txtTotalTTC.Text));

                return (int)cmd.ExecuteScalar();
            }
        }

        // --- Helper method to save a single line item of the invoice ---
        private void SaveInvoiceItem(SqlConnection conn, SqlTransaction transaction, int newInvoiceId, BonLivraisonItemData item)
        {
            string query = @"
        INSERT INTO SalesInvoiceItems (InvoiceID, ArticleID, Quantity, UnitPriceHT, TVA_Rate, DiscountPercentage) 
        VALUES (@InvID, @ArtID, @Qty, @Price, @TVA, @Discount)";

            using (var cmd = new SqlCommand(query, conn, transaction))
            {
                cmd.Parameters.AddWithValue("@InvID", newInvoiceId);
                cmd.Parameters.AddWithValue("@ArtID", item.ArticleID);
                cmd.Parameters.AddWithValue("@Qty", item.Quantity);
                cmd.Parameters.AddWithValue("@Price", item.UnitPriceHT);
                cmd.Parameters.AddWithValue("@TVA", item.TVA_Rate);
                cmd.Parameters.AddWithValue("@Discount", 0); // Assuming no extra discount for now
                cmd.ExecuteNonQuery();
            }
        }
        // --- Helper method to mark the original delivery notes as "Invoiced" ---
        private void UpdateBonLivraisonsStatus(SqlConnection conn, SqlTransaction transaction, int newInvoiceId, HashSet<int> blIdsToUpdate)
        {
            if (!blIdsToUpdate.Any()) return;

            var paramNames = blIdsToUpdate.Select((id, index) => "@ID" + index).ToList();
            string query = $"UPDATE BonLivraisons SET SalesInvoiceID = @InvID, Status = 'Facturé' WHERE BL_ID IN ({string.Join(",", paramNames)})";

            using (var cmd = new SqlCommand(query, conn, transaction))
            {
                cmd.Parameters.AddWithValue("@InvID", newInvoiceId);
                int i = 0;
                foreach (int id in blIdsToUpdate)
                {
                    cmd.Parameters.AddWithValue(paramNames[i], id);
                    i++;
                }
                cmd.ExecuteNonQuery();
            }
        }

        // --- Helper method to increment the invoice serial number in settings ---
        private void IncrementInvoiceNumber(SqlConnection conn, SqlTransaction transaction)
        {
            int nextSerial = AppSettingsManager.SerieFacture + 1;
            string query = "UPDATE AppSettings SET SettingValue = @NewValue WHERE SettingKey = 'SerieFacture'";
            using (var cmd = new SqlCommand(query, conn, transaction))
            {
                cmd.Parameters.AddWithValue("@NewValue", nextSerial.ToString());
                cmd.ExecuteNonQuery();
            }
        }


        private void RecalculateTotals()
        {
            decimal totalHT = 0, totalTVA = 0, totalTTC = 0;
            foreach (DataGridViewRow row in dgvDestination.Rows)
            {
                if (row.IsNewRow) continue;
                totalTTC += Convert.ToDecimal(row.Cells["colDestTotal"].Value ?? 0);
                // More detailed calculation if needed
            }
            // Update footer textboxes
            txtTotalTTC.Text = totalTTC.ToString("C2");
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            if (dgvDestination.Rows.Count == 0)
            {
                MessageBox.Show("Veuillez déplacer les articles à facturer dans la grille de destination.", "Validation");
                return;
            }

            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                var transaction = conn.BeginTransaction();
                try
                {
                    // Step 1: Create the main SalesInvoice record and get its new ID
                    int newInvoiceId = SaveInvoiceHeader(conn, transaction);

                    // Step 2: Get a unique list of all BLs that contributed items to the invoice
                    var processedBlIds = new HashSet<int>();

                    // Step 3: Loop through the destination grid to save each item to the new invoice
                    foreach (DataGridViewRow row in dgvDestination.Rows)
                    {
                        if (row.Tag is BonLivraisonItemData itemData)
                        {
                            SaveInvoiceItem(conn, transaction, newInvoiceId, itemData);
                            processedBlIds.Add(itemData.BL_ID); // Add the original BL_ID to our set
                        }
                    }

                    // Step 4: Update the original BonLivraisons to link them to the new invoice
                    UpdateBonLivraisonsStatus(conn, transaction, newInvoiceId, processedBlIds);

                    // Step 5: Increment the invoice serial number in settings
                    IncrementInvoiceNumber(conn, transaction);

                    transaction.Commit();
                    MessageBox.Show("Facture créée avec succès!", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Error creating invoice: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}