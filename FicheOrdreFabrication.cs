using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using static TAPTAGPOS.PopupTableArticles;

namespace TAPTAGPOS
{
    public partial class FicheOrdreFabrication : Form
    {
        private bool isEditMode = false;
        private int orderId = 0;
        private string connectionString = DatabaseConnection.GetConnectionString();

        public FicheOrdreFabrication()
        {
            InitializeComponent();
            this.Load += FicheOrdreFabrication_Load;
            this.btnMatAjouter.Click += btnMatAjouter_Click;
            this.btnMatEnlever.Click += btnMatEnlever_Click;
            this.btnMatAjouter.Click += btnMatAjouter_Click;
        }

        public FicheOrdreFabrication(int idToEdit) : this()
        {
            this.isEditMode = true;
            this.orderId = idToEdit;
            this.Text = "Modifier Ordre de Fabrication";
        }

        private void FicheOrdreFabrication_Load(object sender, EventArgs e)
        {
            LoadComboBoxes();
            if (isEditMode)
            {
                LoadDataForEdit();
            }
            else
            {
                GenerateNewOrderNumber();
                dtpDateDebut.Value = DateTime.Now;
                dtpDateFin.Value = DateTime.Now;
            }
        }

        private void LoadComboBoxes()
        {
            // Load Machines
            try
            {
                var dtMachines = new DataTable();
                using (var conn = new SqlConnection(connectionString))
                using (var adapter = new SqlDataAdapter("SELECT MachineName FROM Machines WHERE IsActive=1", conn))
                {
                    adapter.Fill(dtMachines);
                }
                cmbMachine.DataSource = dtMachines;
                cmbMachine.DisplayMember = "MachineName";
            }
            catch (Exception ex) { MessageBox.Show("Error loading machines: " + ex.Message); }

            // Load Responsables (from Commerciaux table)
            try
            {
                var dtResponsables = new DataTable();
                using (var conn = new SqlConnection(connectionString))
                using (var adapter = new SqlDataAdapter("SELECT Nom FROM Commerciaux WHERE IsActive=1", conn))
                {
                    adapter.Fill(dtResponsables);
                }
                cmbResponsable.DataSource = dtResponsables;
                cmbResponsable.DisplayMember = "Nom";
            }
            catch (Exception ex) { MessageBox.Show("Error loading responsables: " + ex.Message); }
        }

        private void GenerateNewOrderNumber()
        {
            // Simplified: generates number based on date. You can use the settings logic here later.
            txtOF.Text = $"OF-{DateTime.Now:yyyyMMddHHmmss}";
        }

        private void LoadDataForEdit()
        {
            // This is a complex function to load all data for an existing order.
            // We will implement this in a future step. For now, it does nothing.
            MessageBox.Show("Edit mode is not yet implemented.");
            this.btnOK.Enabled = false;
        }


        // --- Methods for btnAjouter/btnEnlever for both grids ---

        private void btnMatAjouter_Click(object sender, EventArgs e)
        {
            using (var articleSelector = new PopupTableArticles(ArticleSelectionMode.Single))
            {
                if (articleSelector.ShowDialog(this) == DialogResult.OK && articleSelector.SelectedArticle != null)
                {
                    var selectedArticle = articleSelector.SelectedArticle;

                    string qtyStr = Interaction.InputBox($"Enter quantity for component: {selectedArticle.ArticleCode}", "Component Quantity", "1");

                    if (decimal.TryParse(qtyStr, out decimal quantity) && quantity > 0)
                    {
                        int rowIndex = dgvMatiere.Rows.Add();
                        DataGridViewRow row = dgvMatiere.Rows[rowIndex];
                        row.Tag = selectedArticle.Id; // Store the ComponentArticleID
                        row.Cells["colMatRef"].Value = selectedArticle.ArticleCode;
                        row.Cells["colMatDesignation"].Value = selectedArticle.ArticleLongName;
                        row.Cells["colMatQte"].Value = quantity;
                        row.Cells["colMatDepot"].Value = "Principal"; // Placeholder - you can change this
                    }
                }
            }
        }

        private void btnMatEnlever_Click(object sender, EventArgs e)
        {
            if (dgvMatiere.SelectedRows.Count > 0)
            {
                dgvMatiere.Rows.Remove(dgvMatiere.SelectedRows[0]);
            }
        }

        private void btnProdAjouter_Click(object sender, EventArgs e)
        {
            // 1. Select the finished product
            using (var articleSelector = new PopupTableArticles(ArticleSelectionMode.Single))
            {
                if (articleSelector.ShowDialog(this) == DialogResult.OK && articleSelector.SelectedArticle != null)
                {
                    var finishedProduct = articleSelector.SelectedArticle;

                    // 2. Ask for the quantity to produce
                    string qtyToProduceStr = Interaction.InputBox($"Enter quantity to produce for: {finishedProduct.ArticleCode}", "Quantity to Produce", "1");

                    if (int.TryParse(qtyToProduceStr, out int qtyToProduce) && qtyToProduce > 0)
                    {
                        // 3. Add the finished product to the bottom grid
                        int rowIndex = dgvProduits.Rows.Add();
                        DataGridViewRow productRow = dgvProduits.Rows[rowIndex];
                        productRow.Tag = finishedProduct.Id;
                        productRow.Cells["colProdRef"].Value = finishedProduct.ArticleCode;
                        productRow.Cells["colProdDesignation"].Value = finishedProduct.ArticleLongName;
                        productRow.Cells["colProdQtePrevue"].Value = qtyToProduce; // Planned quantity
                        productRow.Cells["colProdQteProduite"].Value = 0; // Produced is 0 initially
                        productRow.Cells["colProdEcart"].Value = -qtyToProduce; // Difference

                        // 4. Automatically load its components into the raw materials grid
                        LoadComponentsForProduct(finishedProduct.Id, qtyToProduce);
                    }
                }
            }
        }
        private void LoadComponentsForProduct(int finishedProductId, int quantityToProduce)
        {
            string query = @"
        SELECT 
            fti.ComponentArticleID, 
            a.Article, 
            a.ArticleLongName, 
            fti.Quantity 
        FROM FicheTechniqueItems fti
        JOIN Articles a ON fti.ComponentArticleID = a.Id
        WHERE fti.FicheID = (SELECT FicheID FROM FichesTechniques WHERE ArticleID = @FinishedProductID)";

            try
            {
                using (var conn = new SqlConnection(connectionString))
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@FinishedProductID", finishedProductId);
                    conn.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (!reader.HasRows)
                        {
                            MessageBox.Show("No Fiche Technique (recipe) found for the selected product.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }

                        while (reader.Read())
                        {
                            int rowIndex = dgvMatiere.Rows.Add();
                            DataGridViewRow row = dgvMatiere.Rows[rowIndex];
                            row.Tag = reader["ComponentArticleID"];
                            row.Cells["colMatRef"].Value = reader["Article"];
                            row.Cells["colMatDesignation"].Value = reader["ArticleLongName"];
                            // Calculate total quantity needed
                            row.Cells["colMatQte"].Value = (decimal)reader["Quantity"] * quantityToProduce;
                            row.Cells["colMatDepot"].Value = "Principal"; // Default warehouse
                        }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Error loading components: " + ex.Message); }
        }
        private void btnProdEnlever_Click(object sender, EventArgs e)
        {
            if (dgvProduits.SelectedRows.Count > 0)
            {
                dgvProduits.Rows.Remove(dgvProduits.SelectedRows[0]);
            }
        }

        // --- Method for btnOK to save all data in a transaction ---

        private void btnOK_Click(object sender, EventArgs e)
        {
            // --- Validation ---
            if (string.IsNullOrWhiteSpace(txtOF.Text))
            {
                MessageBox.Show("Order Number is missing."); return;
            }
            if (dgvMatiere.Rows.Count == 0 || dgvProduits.Rows.Count == 0)
            {
                MessageBox.Show("Please add raw materials and finished products."); return;
            }

            // --- Save Logic (for Add New mode) ---
            if (isEditMode)
            {
                MessageBox.Show("Update logic is not yet implemented.");
                return;
            }

            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                var transaction = conn.BeginTransaction();
                try
                {
                    // 1. Insert main order and get its new ID
                    string query = "INSERT INTO OrdresFabrication (OrderNumber, LotNumber, StartDate, EndDate, Machine, Responsable, Observations) OUTPUT INSERTED.OrderID VALUES (@ON, @Lot, @Start, @End, @Machine, @Resp, @Notes)";
                    int newOrderId;
                    using (var cmd = new SqlCommand(query, conn, transaction))
                    {
                        // ... Add all parameters for the main order ...
                        newOrderId = (int)cmd.ExecuteScalar();
                    }

                    // 2. Loop through Raw Materials grid, save them, and DEDUCT stock
                    string itemQuery = "INSERT INTO OF_MatierePremieres (OrderID, ArticleID, QuantityUsed, WarehouseID) VALUES (@Oid, @Aid, @Qty, @Wid)";
                    foreach (DataGridViewRow row in dgvMatiere.Rows)
                    {
                        // ... (Save each row to OF_MatierePremieres) ...

                        // ... (Deduct stock using the UpdateStock method) ...
                    }

                    // 3. Loop through Finished Products grid, save them, and ADD stock
                    itemQuery = "INSERT INTO OF_ProduitsFinis (OrderID, ArticleID, QuantityExpected, QuantityProduced) VALUES (@Oid, @Aid, @QtyE, @QtyP)";
                    foreach (DataGridViewRow row in dgvProduits.Rows)
                    {
                        // ... (Save each row to OF_ProduitsFinis) ...

                        // ... (ADD stock using the UpdateStock method with a negative value) ...
                    }

                    transaction.Commit();
                    MessageBox.Show("Manufacturing order saved successfully!");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Error saving order: " + ex.Message);
                }
            }
        }
    }
}