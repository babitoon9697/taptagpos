using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static TAPTAGPOS.PopupTableArticles;

namespace TAPTAGPOS
{
    public partial class FicheTechnique : Form
    {
        private bool isEditMode = false;
        private int ficheId = 0;
        private string connectionString = DatabaseConnection.GetConnectionString();

        public FicheTechnique()
        {
            InitializeComponent();
            this.Load += FicheTechnique_Load;
            // ... Other event handlers ...
        }

        public FicheTechnique(int idToEdit) : this()
        {
            this.isEditMode = true;
            this.ficheId = idToEdit;
        }

        private void FicheTechnique_Load(object sender, EventArgs e)
        {
            LoadArticlesIntoComboBox();
            if (isEditMode)
            {
                LoadDataForEdit();
            }
        }

        private void LoadArticlesIntoComboBox()
        {
            // This method loads articles that can be a "finished product"
            try
            {
                var dt = new DataTable();
                // You might want to filter this list to only show manufactured goods
                string query = "SELECT Id, ArticleLongName FROM Articles WHERE IsActive = 1 ORDER BY ArticleLongName";
                using (var conn = new SqlConnection(connectionString))
                using (var adapter = new SqlDataAdapter(query, conn))
                {
                    adapter.Fill(dt);
                }
                cmbArticle.DataSource = dt;
                cmbArticle.DisplayMember = "ArticleLongName";
                cmbArticle.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading articles: " + ex.Message);
            }
        }

        // --- 2. LoadDataForEdit Method ---
        private void LoadDataForEdit()
        {
            // Load main Fiche details
            string query = "SELECT ArticleID FROM FichesTechniques WHERE FicheID = @ID";
            try
            {
                using (var conn = new SqlConnection(connectionString))
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ID", this.ficheId);
                    conn.Open();
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        cmbArticle.SelectedValue = result;
                        cmbArticle.Enabled = false; // Cannot change the main article during an edit
                        btnNouveauArticle.Enabled = false;
                    }
                }

                // Load the components into the grid
                dgvComposants.Rows.Clear();
                query = @"SELECT f.ComponentArticleID, a.Article, a.ArticleLongName, f.Quantity, a.BuyPrice 
                  FROM FicheTechniqueItems f 
                  JOIN Articles a ON f.ComponentArticleID = a.Id
                  WHERE f.FicheID = @ID";

                using (var conn = new SqlConnection(connectionString))
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ID", this.ficheId);
                    conn.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int rowIndex = dgvComposants.Rows.Add();
                            DataGridViewRow row = dgvComposants.Rows[rowIndex];
                            row.Tag = reader["ComponentArticleID"];
                            row.Cells["colCompReference"].Value = reader["Article"];
                            row.Cells["colCompDesignation"].Value = reader["ArticleLongName"];
                            row.Cells["colCompQte"].Value = reader["Quantity"];
                            row.Cells["colCompPrixAchat"].Value = reader["BuyPrice"];
                        }
                    }
                }
                RecalculateCostPrice();
            }
            catch (Exception ex) { MessageBox.Show("Error loading data for edit: " + ex.Message); }
        }

        // --- 3. btnAjouter_Click Method ---
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            // We will reuse the PopupTableArticles form to select a component
            // NEW, CORRECTED CODE
            using (var articleSelector = new PopupTableArticles(ArticleSelectionMode.Single))
            {
                if (articleSelector.ShowDialog(this) == DialogResult.OK)
                {
                    // You'll need to modify PopupTableArticles to return the selected article's ID and BuyPrice
                    // For now, let's assume it has public properties:
                    // int selectedId = articleSelector.SelectedArticleId;
                    // string selectedRef = articleSelector.SelectedArticleRef;
                    // string selectedName = articleSelector.SelectedArticleName;
                    // decimal selectedPrice = articleSelector.SelectedArticleBuyPrice;

                    // string quantityStr = Interaction.InputBox("Enter quantity for the component:", "Component Quantity", "1");
                    // if (decimal.TryParse(quantityStr, out decimal quantity))
                    // {
                    //    dgvComposants.Rows.Add(selectedRef, selectedName, selectedPrice, quantity);
                    //    dgvComposants.Rows[dgvComposants.Rows.Count - 1].Tag = selectedId;
                    //    RecalculateCostPrice();
                    // }
                    MessageBox.Show("Placeholder: Add logic to get selected article and quantity.");
                }
            }
        }

        // --- 4. btnEnlever_Click Method ---
        private void btnEnlever_Click(object sender, EventArgs e)
        {
            if (dgvComposants.SelectedRows.Count > 0)
            {
                dgvComposants.Rows.Remove(dgvComposants.SelectedRows[0]);
                RecalculateCostPrice();
            }
        }

        // --- 5. RecalculateCostPrice Method ---
        private void RecalculateCostPrice()
        {
            decimal totalCost = 0m;
            foreach (DataGridViewRow row in dgvComposants.Rows)
            {
                if (row.IsNewRow) continue;
                decimal price = Convert.ToDecimal(row.Cells["colCompPrixAchat"].Value ?? 0);
                decimal qty = Convert.ToDecimal(row.Cells["colCompQte"].Value ?? 0);
                totalCost += price * qty;
            }
            numCoutRevient.Value = totalCost;
            lblSumValue.Text = totalCost.ToString("C2");
        }

        // --- 6. btnOK_Click (Save) Method ---
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (cmbArticle.SelectedValue == null || dgvComposants.Rows.Count == 0)
            {
                MessageBox.Show("Please select a finished article and add at least one component.", "Validation Error");
                return;
            }

            RecalculateCostPrice();
            int finishedArticleId = (int)cmbArticle.SelectedValue;
            decimal costPrice = numCoutRevient.Value;

            string query = isEditMode
                ? "UPDATE FichesTechniques SET CostPrice=@Cost WHERE FicheID=@ID"
                : "INSERT INTO FichesTechniques (ArticleID, CostPrice) OUTPUT INSERTED.FicheID VALUES (@ArticleID, @Cost)";

            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (var transaction = conn.BeginTransaction())
                {
                    try
                    {
                        using (var cmd = new SqlCommand(query, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@Cost", costPrice);
                            if (isEditMode)
                            {
                                cmd.Parameters.AddWithValue("@ID", this.ficheId);
                                cmd.ExecuteNonQuery();
                            }
                            else
                            {
                                cmd.Parameters.AddWithValue("@ArticleID", finishedArticleId);
                                this.ficheId = (int)cmd.ExecuteScalar();
                            }
                        }

                        using (var cmd = new SqlCommand("DELETE FROM FicheTechniqueItems WHERE FicheID = @FicheID", conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@FicheID", this.ficheId);
                            cmd.ExecuteNonQuery();
                        }

                        string insertItemQuery = "INSERT INTO FicheTechniqueItems (FicheID, ComponentArticleID, Quantity) VALUES (@FicheID, @CompID, @Qty)";
                        foreach (DataGridViewRow row in dgvComposants.Rows)
                        {
                            if (row.IsNewRow) continue;
                            using (var cmd = new SqlCommand(insertItemQuery, conn, transaction))
                            {
                                cmd.Parameters.AddWithValue("@FicheID", this.ficheId);
                                cmd.Parameters.AddWithValue("@CompID", (int)row.Tag);
                                cmd.Parameters.AddWithValue("@Qty", Convert.ToDecimal(row.Cells["colCompQte"].Value));
                                cmd.ExecuteNonQuery();
                            }
                        }

                        transaction.Commit();
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Error saving Fiche Technique: " + ex.Message);
                    }
                }
            }
        }
    }
}