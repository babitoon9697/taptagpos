using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Windows.Forms;
using Zen.Barcode;

namespace TAPTAGPOS
{
    public partial class FormImpressionBarcode : Form
    {
        private enum PrintLabelType { StickerItem, StickerPrice }

        private Article _selectedArticle;
        private PrintLabelType _currentPrintMode;
        private string connectionString = DatabaseConnection.GetConnectionString();

        public FormImpressionBarcode()
        {
            InitializeComponent();
            InitializeEventHandlers();
        }

        private void InitializeEventHandlers()
        {
            this.Load += FormImpressionBarcode_Load;
            this.btnStickerItem.Click += (s, e) => InitiatePrint(PrintLabelType.StickerItem);
            this.btnStickerPrice.Click += (s, e) => InitiatePrint(PrintLabelType.StickerPrice);
            this.textBox2.KeyDown += (s, e) => { if (e.KeyCode == Keys.Enter) FindArticleByBarcode(textBox2.Text); };
            this.cmbFamily.SelectedIndexChanged += CmbFamily_SelectedIndexChanged;
            this.comboBox2.SelectedIndexChanged += CmbArticle_SelectedIndexChanged; // This is cmbArticle
        }

        private void FormImpressionBarcode_Load(object sender, EventArgs e)
        {
            LoadFamilies();
        }

        #region Data Loading and Selection

        private void LoadFamilies()
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
                dr["CategoryName"] = "Choisir une famille...";
                dt.Rows.InsertAt(dr, 0);

                cmbFamily.DataSource = dt;
                cmbFamily.DisplayMember = "CategoryName";
                cmbFamily.ValueMember = "CategoryID";
            }
            catch (Exception ex) { MessageBox.Show("Error loading families: " + ex.Message); }
        }

        private void CmbFamily_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFamily.SelectedValue == null || !(cmbFamily.SelectedValue is int) || (int)cmbFamily.SelectedValue == 0)
            {
                comboBox2.DataSource = null;
                ClearArticleInfo();
                return;
            }
            String familyId = cmbFamily.Text;
            LoadArticlesByFamily(familyId);
        }

        // --- START OF FIX ---
        private void LoadArticlesByFamily(string categoryId)
        {
            // Temporarily unsubscribe from the event to prevent it from firing while we change the data
            this.comboBox2.SelectedIndexChanged -= CmbArticle_SelectedIndexChanged;

            try
            {
                var dt = new DataTable();
                using (var conn = new SqlConnection(connectionString))
                {
                    var query = "SELECT Id,[Article] as ArticleLongName FROM Articles WHERE Categorie = @CategoryID AND IsActive=1 ORDER BY ArticleLongName";
                    var adapter = new SqlDataAdapter(query, conn);
                    adapter.SelectCommand.Parameters.AddWithValue("@CategoryID", categoryId);
                    adapter.Fill(dt);
                }
                comboBox2.DataSource = dt;
                comboBox2.DisplayMember = "ArticleLongName";
                comboBox2.ValueMember = "Id";
            }
            catch (Exception ex) { MessageBox.Show("Error loading articles: " + ex.Message); }
            finally
            {
                // Re-subscribe to the event so it works for user interaction
                this.comboBox2.SelectedIndexChanged += CmbArticle_SelectedIndexChanged;
                // Manually trigger the event once to load the first article in the new list
                CmbArticle_SelectedIndexChanged(null, null);
            }
        }
        // --- END OF FIX ---

        private void CmbArticle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedValue != null && comboBox2.SelectedValue is int)
            {
                FindArticleById((int)comboBox2.SelectedValue);
            }
            else
            {
                ClearArticleInfo();
            }
        }

        private void FindArticleByBarcode(string barcode)
        {
            if (string.IsNullOrWhiteSpace(barcode)) return;
            string query = "SELECT TOP 1 Id FROM Articles WHERE JSON_VALUE(Barcodes, '$[0]') = @Barcode";
            try
            {
                using (var conn = new SqlConnection(connectionString))
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Barcode", barcode);
                    conn.Open();
                    object result = cmd.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        FindArticleById(Convert.ToInt32(result));
                    }
                    else
                    {
                        MessageBox.Show("Article not found.");
                        ClearArticleInfo();
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Error finding article: " + ex.Message); }
        }

        private void FindArticleById(int articleId)
        {
            string query = "SELECT * FROM Articles WHERE Id = @ArticleID";
            try
            {
                using (var conn = new SqlConnection(connectionString))
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ArticleID", articleId);
                    conn.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            _selectedArticle = new Article
                            {
                                Id = articleId,
                                ArticleLongName = reader["Article"].ToString(),
                                SellPrice = Convert.ToDecimal(reader["DetailsPrice"]),
                                Barcode = reader["Barcodes"] == DBNull.Value ? "" : System.Text.Json.JsonDocument.Parse(reader["Barcodes"].ToString()).RootElement.EnumerateArray().FirstOrDefault().GetString()
                            };
                            DisplayArticleInfo();
                        }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Error loading article details: " + ex.Message); }
        }

        #endregion

        #region UI and Barcode Generation

        private void DisplayArticleInfo()
        {
            if (_selectedArticle == null) return;
            textBox1.Text = _selectedArticle.ArticleLongName;
            numPrice.Value = _selectedArticle.SellPrice;
            textBox2.Text = _selectedArticle.Barcode;
            GenerateBarcodeImage(_selectedArticle.Barcode);
        }

        private void ClearArticleInfo()
        {
            _selectedArticle = null;
            textBox1.Text = "";
            numPrice.Value = 0;
            picBarcode.Image = null;
            lblBarcodeNumber.Text = "";
        }

        private void GenerateBarcodeImage(string barcodeText)
        {
            if (string.IsNullOrWhiteSpace(barcodeText))
            {
                picBarcode.Image = null;
                lblBarcodeNumber.Text = "";
                return;
            }
            try
            {
                Code128BarcodeDraw barcodeDraw = BarcodeDrawFactory.Code128WithChecksum;
                // --- START OF FIX ---
                // We will now use a scaling factor to create a high-quality image.
                // A scale of 2 or 3 is recommended.
                int scale = 3;

                // Use the Draw method that includes the scale parameter.
                // This will create a much sharper image.
                picBarcode.Image = barcodeDraw.Draw(barcodeText, 60, scale);
                // --- END OF FIX ---
                lblBarcodeNumber.Text = barcodeText;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error generating barcode image: " + ex.Message);
            }
        }
        #endregion

        #region Printing Logic
        private void InitiatePrint(PrintLabelType labelType)
        {
            if (_selectedArticle == null)
            {
                MessageBox.Show("Please select an article first.");
                return;
            }
            _currentPrintMode = labelType;

            using (PrintDocument pd = new PrintDocument())
            {
                pd.DocumentName = "Barcode Sticker";
                pd.PrinterSettings.PrinterName = AppSettingsManager.PrinterBarcode;
                pd.PrinterSettings.Copies = (short)numCopies.Value;

                // --- START OF FIX: Define a custom paper size for the barcode label ---

                // Common size: 50mm x 25mm. You can change these values.
                float widthInMM = 50;
                float heightInMM = 25;

                // Convert mm to 1/100ths of an inch (which the printer uses)
                int widthInHundredthsOfInch = (int)(widthInMM / 25.4 * 100);
                int heightInHundredthsOfInch = (int)(heightInMM / 25.4 * 100);

                pd.DefaultPageSettings.PaperSize = new PaperSize("Custom Sticker", widthInHundredthsOfInch, heightInHundredthsOfInch);

                // Set very small margins for label printers
                pd.DefaultPageSettings.Margins = new Margins(5, 5, 5, 5);

                // --- END OF FIX ---

                pd.PrintPage += Barcode_PrintPage;

                using (PrintPreviewDialog ppd = new PrintPreviewDialog())
                {
                    ppd.Document = pd;
                    ppd.ShowDialog(this);
                }
                pd.PrintPage -= Barcode_PrintPage;
            }
        }

        private void Barcode_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            float x = 5;
            float y = 5;

            using (Font itemFont = new Font("Arial", 8, FontStyle.Bold))
            using (Font priceFont = new Font("Arial", 10, FontStyle.Bold))
            {
                g.DrawString(_selectedArticle.ArticleLongName, itemFont, Brushes.Black, x, y);
                y += itemFont.GetHeight(g);

                if (_currentPrintMode == PrintLabelType.StickerPrice)
                {
                    decimal priceToPrint = chkTogglePrice.Checked ? numPrice.Value : _selectedArticle.SellPrice;
                    g.DrawString(priceToPrint.ToString("C2"), priceFont, Brushes.Black, x, y);
                    y += priceFont.GetHeight(g);
                }

                if (picBarcode.Image != null)
                {
                    g.DrawImage(picBarcode.Image, x, y, 150, 40);
                }
            }
            e.HasMorePages = false;
        }
        #endregion
    }
}