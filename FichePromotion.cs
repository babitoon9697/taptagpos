using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using static TAPTAGPOS.PopupTableArticles;

namespace TAPTAGPOS
{
    public partial class FichePromotion : Form
    {
        private bool isEditMode = false;
        private int promotionId = 0;
        private string connectionString = DatabaseConnection.GetConnectionString();

        // This list will hold the IDs of the articles selected for this promotion
        public List<int> SelectedArticleIDs { get; set; } = new List<int>();

        public FichePromotion()
        {
            InitializeComponent();
            this.Text = "Nouvelle Promotion";
        }

        public FichePromotion(int idToEdit) : this()
        {
            this.isEditMode = true;
            this.promotionId = idToEdit;
            this.Text = "Modifier Promotion";
            LoadDataForEdit();
        }

        private void LoadDataForEdit()
        {
            // Load main promotion details
            string query = "SELECT * FROM Promotions WHERE PromotionID = @ID";
            try
            {
                using (var conn = new SqlConnection(connectionString))
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ID", this.promotionId);
                    conn.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtPromotion.Text = reader["PromotionName"]?.ToString();
                            dtpDateDebut.Value = (DateTime)reader["StartDate"];
                            dtpDateFin.Value = (DateTime)reader["EndDate"];
                            numRemise.Value = Convert.ToDecimal(reader["DiscountPercentage"]);
                            txtObservations.Text = reader["Observations"]?.ToString();
                        }
                    }
                }

                // Load the list of currently associated articles
                SelectedArticleIDs.Clear();
                query = "SELECT ArticleID FROM PromotionArticles WHERE PromotionID = @ID";
                using (var conn = new SqlConnection(connectionString))
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ID", this.promotionId);
                    conn.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            SelectedArticleIDs.Add((int)reader["ArticleID"]);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading promotion data: " + ex.Message);
                this.Close();
            }
        }
        // This code in FichePromotion.cs is now correct
        private void btnAjouterArticles_Click(object sender, EventArgs e)
        {
            using (PopupTableArticles articleSelector = new PopupTableArticles(ArticleSelectionMode.Multiple, this.SelectedArticleIDs))
            {
                if (articleSelector.ShowDialog(this) == DialogResult.OK)
                {
                    // We get the list of IDs from the correct property
                    this.SelectedArticleIDs = articleSelector.FinalSelectedArticleIDs;
                    MessageBox.Show($"{this.SelectedArticleIDs.Count} articles selected.");
                }
            }
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPromotion.Text) || numRemise.Value <= 0)
            {
                MessageBox.Show("Promotion Name and a Discount > 0 are required.", "Validation");
                return;
            }

            string query = isEditMode
                ? "UPDATE Promotions SET PromotionName=@Name, StartDate=@Start, EndDate=@End, DiscountPercentage=@Discount, Observations=@Notes WHERE PromotionID=@ID"
                : "INSERT INTO Promotions (PromotionName, StartDate, EndDate, DiscountPercentage, Observations) OUTPUT INSERTED.PromotionID VALUES (@Name, @Start, @End, @Discount, @Notes)";

            try
            {
                using (var conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (var transaction = conn.BeginTransaction())
                    {
                        // Step 1: Save the main promotion and get its ID
                        using (var cmd = new SqlCommand(query, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@Name", txtPromotion.Text);
                            cmd.Parameters.AddWithValue("@Start", dtpDateDebut.Value);
                            cmd.Parameters.AddWithValue("@End", dtpDateFin.Value);
                            cmd.Parameters.AddWithValue("@Discount", numRemise.Value);
                            cmd.Parameters.AddWithValue("@Notes", txtObservations.Text);

                            if (isEditMode)
                            {
                                cmd.Parameters.AddWithValue("@ID", this.promotionId);
                                cmd.ExecuteNonQuery();
                            }
                            else
                            {
                                this.promotionId = Convert.ToInt32(cmd.ExecuteScalar());
                            }
                        }

                        // Step 2: Clear any existing article links for this promotion
                        using (var cmd = new SqlCommand("DELETE FROM PromotionArticles WHERE PromotionID = @PromoID", conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@PromoID", this.promotionId);
                            cmd.ExecuteNonQuery();
                        }

                        // Step 3: Insert the new links for the selected articles
                        if (SelectedArticleIDs.Any())
                        {
                            string insertItemQuery = "INSERT INTO PromotionArticles (PromotionID, ArticleID) VALUES (@PromoID, @ArticleID)";
                            foreach (int articleId in SelectedArticleIDs)
                            {
                                using (var cmd = new SqlCommand(insertItemQuery, conn, transaction))
                                {
                                    cmd.Parameters.AddWithValue("@PromoID", this.promotionId);
                                    cmd.Parameters.AddWithValue("@ArticleID", articleId);
                                    cmd.ExecuteNonQuery();
                                }
                            }
                        }

                        transaction.Commit();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving promotion: " + ex.Message);
                return; // Stay on the form if there's an error
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
