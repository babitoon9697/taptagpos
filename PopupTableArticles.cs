using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace TAPTAGPOS
{
    public partial class PopupTableArticles : Form
    {
        private string connectionString = DatabaseConnection.GetConnectionString();
        private List<int> _initialSelectedIDs;
        private ArticleSelectionMode _currentMode;

        // Public properties to return the results
        public Article SelectedArticle { get; private set; } // For Single mode
        public List<int> FinalSelectedArticleIDs { get; private set; } = new List<int>(); // For Multiple mode

        public enum ArticleSelectionMode
        {
            Single, // For selecting one article
            Multiple // For selecting multiple articles with checkboxes
        }

        // This list will hold the IDs of articles that were already selected
        // In PopupTableArticles.cs, at the top of the class
        public string selectform { get;  set; }

        // This public property will return the final selection to the parent form

        public PopupTableArticles(ArticleSelectionMode mode, List<int> initialSelection = null)
        {
            InitializeComponent();
            _currentMode = mode;
            _initialSelectedIDs = initialSelection ?? new List<int>();

            // --- Configure the form based on the selection mode ---
            if (_currentMode == ArticleSelectionMode.Single)
            {
                this.Text = "Choisir un Article";
                dgvArticles.MultiSelect = false;
                // You can hide the checkbox column if you have one
            }
            else // Multiple
            {
                this.Text = "Choisir des Articles";
                dgvArticles.MultiSelect = true; // Allow selecting multiple rows
            }

            this.Load += PopupTableArticles_Load;
            this.txtSearch.TextChanged += txtSearch_TextChanged;
            this.btnChoisir.Click += btnChoisir_Click;
            this.dgvArticles.CellDoubleClick += dgvArticles_CellDoubleClick;
        }
        private void dgvArticles_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // If in single selection mode, a double-click is a shortcut for choosing
            if (_currentMode == ArticleSelectionMode.Single && e.RowIndex >= 0)
            {
                btnChoisir.PerformClick();
            }
        }
        private void PopupTableArticles_Load(object sender, EventArgs e)
        {
            LoadAllArticles();
        }

        private void LoadAllArticles()
        {
            dgvArticles.Rows.Clear();
            string query = "SELECT Id, Article, ArticleLongName, DetailsPrice FROM Articles WHERE IsActive = 1 ORDER BY Article";
            try
            {
                using (var conn = new SqlConnection(connectionString))
                using (var cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int articleId = (int)reader["Id"];
                            int rowIndex = dgvArticles.Rows.Add();
                            DataGridViewRow row = dgvArticles.Rows[rowIndex];

                            // Check if this article was previously selected
                            bool isSelected = _initialSelectedIDs.Contains(articleId);

                            row.Cells["colSelect"].Value = isSelected;
                            row.Cells["colRef"].Value = reader["Article"];
                            row.Cells["colDesignation"].Value = reader["ArticleLongName"];
                            row.Cells["colPrix"].Value = Convert.ToDecimal(reader["DetailsPrice"] ?? 0).ToString("N2");
                            row.Tag = articleId;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading articles: " + ex.Message);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.ToLower();
            foreach (DataGridViewRow row in dgvArticles.Rows)
            {
                if (row.IsNewRow) continue;

                string reference = row.Cells["colRef"].Value?.ToString().ToLower() ?? "";
                string designation = row.Cells["colDesignation"].Value?.ToString().ToLower() ?? "";

                if (reference.Contains(searchText) || designation.Contains(searchText))
                {
                    row.Visible = true;
                }
                else
                {
                    row.Visible = false;
                }
            }
        }

        private void btnChoisir_Click(object sender, EventArgs e)
        {
            if (dgvArticles.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner au moins un article.", "Aucune sélection");
                return;
            }

            if (_currentMode == ArticleSelectionMode.Single)
            {
                int articleId = (int)dgvArticles.SelectedRows[0].Tag;
                this.SelectedArticle = GetArticleById(articleId); // You need this helper method
            }
            else // Multiple
            {
                foreach (DataGridViewRow row in dgvArticles.SelectedRows)
                {
                    FinalSelectedArticleIDs.Add((int)row.Tag);
                }
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private Article GetArticleById(int id)
        {
            Article foundArticle = null;
            // Query to select all relevant fields for a single article
            string query = "SELECT * FROM Articles WHERE Id = @ArticleID";

            try
            {
                using (var conn = new SqlConnection(connectionString)) // Assumes 'connectionString' is a class member
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ArticleID", id);
                    conn.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            foundArticle = new Article
                            {
                                Id = (int)reader["Id"],
                                ArticleCode = reader["Article"]?.ToString(),
                                ArticleLongName = reader["ArticleLongName"]?.ToString(),
                                BuyPrice = reader.IsDBNull(reader.GetOrdinal("BuyPrice")) ? 0 : Convert.ToDecimal(reader["BuyPrice"]),
                                SellPrice = reader.IsDBNull(reader.GetOrdinal("DetailsPrice")) ? 0 : Convert.ToDecimal(reader["DetailsPrice"]),

                                // Safely read the JSON barcodes and get the first one
                                Barcode = GetFirstBarcode(reader["Barcodes"]?.ToString())

                                // Add any other properties from your Article class that you need
                            };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching article details by ID: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return foundArticle;
        }

        // It's good practice to add a helper for the barcode JSON
        private string GetFirstBarcode(string barcodeJson)
        {
            if (string.IsNullOrWhiteSpace(barcodeJson))
            {
                return string.Empty;
            }
            try
            {
                // Assuming the 'Barcodes' column stores a JSON array like ["123", "456"]
                var barcodes = Newtonsoft.Json.JsonConvert.DeserializeObject<List<string>>(barcodeJson);
                return barcodes?.FirstOrDefault() ?? string.Empty;
            }
            catch
            {
                // If it's not a JSON array but a single string/number, return it directly
                return barcodeJson;
            }
        }
    }
}