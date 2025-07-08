using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace TAPTAGPOS
{
    public partial class TableBonLivraison : Form
    {
        private string connectionString = DatabaseConnection.GetConnectionString();
        private bool _isSelectionMode = false;
        private int _clientIdForSelection = 0;

        // --- Public property to return the selected IDs ---
        public List<int> SelectedBlIds { get; private set; } = new List<int>();
        public TableBonLivraison()
        {
            InitializeComponent();
          
        }
        // New constructor for when we use it as a selector
        public TableBonLivraison(int clientId) : this()
        {
            _isSelectionMode = true;
            _clientIdForSelection = clientId;
        }
        private void InitializeEvents()
        {
            this.Load += TableBonLivraison_Load;
            this.btnFiltrer.Click += (s, e) => LoadData();
            this.btnNouveau.Click += btnNouveau_Click;
            this.btnModifier.Click += btnModifier_Click;
            this.btnSupprimer.Click += btnSupprimer_Click;
            this.btnFermer.Click += (s, e) => this.Close();
            this.dgvBonLivraison.CellDoubleClick += (s, e) => btnModifier_Click(s, e);
            this.btnValiderSelection.Click += btnValiderSelection_Click;
        }
        private void TableBonLivraison_Load(object sender, EventArgs e)
        {
            {
                if (_isSelectionMode)
                {
                    // In selection mode, hide unnecessary controls
                    panelFilters.Visible = false;
                    btnNouveau.Visible = false;
                    btnModifier.Visible = false;
                    btnSupprimer.Visible = false;
                    btnImprimer.Visible = false;
                    btnImprimerListe.Visible = false;
                    btnBLtoFacture.Visible = false;

                    // Show the "Confirm Selection" button
                    btnValiderSelection.Visible = true;

                    // Make the checkbox column visible
                    colSelect.Visible = true;

                    this.Text = "Sélectionner des Bons de Livraison";
                    LoadDataForSelection(); // Load only the specific client's BLs
                }
                else
                {
                    // Normal mode
                    dtpDateDebut.Value = DateTime.Now.AddMonths(-1);
                    dtpDateFin.Value = DateTime.Now;
                    LoadClients();
                    LoadData();
                    colSelect.Visible = false;
                    btnValiderSelection.Visible = false;
                    LoadData(); // Load all BLs
                }
            } 
        }
        private void LoadDataForSelection()
        {
            dgvBonLivraison.Rows.Clear();
            string query = "SELECT BL_ID, BL_Number, BL_Date, TotalTTC FROM BonLivraisons WHERE CustomerID = @CID AND BordereauID IS NULL AND IsActive = 1";
            try
            {
                using (var conn = new SqlConnection(connectionString))
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@CID", _clientIdForSelection);
                    conn.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int rowIndex = dgvBonLivraison.Rows.Add(
                               false, // Checkbox column
                               reader["BL_Number"],
                               ((DateTime)reader["BL_Date"]).ToShortDateString(),
                               Convert.ToDecimal(reader["TotalTTC"]).ToString("N2")
                           );
                            dgvBonLivraison.Rows[rowIndex].Tag = reader["BL_ID"];
                        }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Error loading delivery notes: " + ex.Message); }
        }

        private void btnValiderSelection_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvBonLivraison.Rows)
            {
                if (Convert.ToBoolean(row.Cells["colSelect"].Value) == true)
                {
                    SelectedBlIds.Add((int)row.Tag);
                }
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private void LoadClients()
        {
            try
            {
                var dt = new DataTable();
                dt.Columns.Add("CustomerID", typeof(int));
                dt.Columns.Add("CustomerName", typeof(string));
                dt.Rows.Add(0, "Tous les Clients");

                using (var conn = new SqlConnection(connectionString))
                using (var adapter = new SqlDataAdapter("SELECT CustomerID, CustomerName FROM Customers WHERE IsActive=1", conn))
                {
                    adapter.Fill(dt);
                }
                cmbClient.DataSource = dt;
                cmbClient.DisplayMember = "CustomerName";
                cmbClient.ValueMember = "CustomerID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading clients: " + ex.Message);
            }
        }

        private void LoadData()
        {
            dgvBonLivraison.Rows.Clear();
            decimal totalGeneral = 0;
            



            // This query now joins with the Transactions table to get payment details.
            // It assumes a "BL" in the Transactions table is linked by its TicketID.
            var query = new StringBuilder(@"
        SELECT 
            bl.BL_ID, 
            bl.BL_Number, 
            bl.BL_Date, 
            c.CustomerName, 
            bl.TotalTTC,
            ISNULL(tr.AmountPaid, 0) as Reglement,
            (bl.TotalTTC - ISNULL(tr.AmountPaid, 0)) as Reste
        FROM BonLivraisons bl
        JOIN Customers c ON bl.CustomerID = c.CustomerID
        LEFT JOIN Transactions tr ON bl.BL_ID = tr.TicketID 
        WHERE bl.IsActive = 1 
        ORDER BY bl.BL_Date DESC");

            var parameters = new Dictionary<string, object>();
            parameters.Add("@StartDate", dtpDateDebut.Value.Date);
            parameters.Add("@EndDate", dtpDateFin.Value.Date.AddDays(1).AddSeconds(-1));
            query.Append(" AND bl.BL_Date BETWEEN @StartDate AND @EndDate");
            try
            {
                using (var conn = new SqlConnection(connectionString))
                using (var cmd = new SqlCommand(query.ToString(), conn))
                {
                    foreach (var p in parameters)

                    {

                        cmd.Parameters.AddWithValue(p.Key, p.Value);

                    }
                    conn.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            decimal totalTTC = Convert.ToDecimal(reader["TotalTTC"]);
                            int rowIndex = dgvBonLivraison.Rows.Add(
                                ((DateTime)reader["BL_Date"]).ToShortDateString(),
                                reader["BL_Number"],
                                reader["CustomerName"],
                                totalTTC.ToString("N2"),
                                Convert.ToDecimal(reader["Reglement"]).ToString("N2"),
                                Convert.ToDecimal(reader["Reste"]).ToString("N2")
                            );
                            dgvBonLivraison.Rows[rowIndex].Tag = reader["BL_ID"];
                            totalGeneral += totalTTC;
                        }
                    }
                }
                labelTotal.Text = $"TOTAL: {totalGeneral:N2}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading delivery notes: " + ex.Message);
            }
        }
        private void btnNouveau_Click(object sender, EventArgs e)
        {
            using (FicheBonLivraison editorForm = new FicheBonLivraison())
            {
                if (editorForm.ShowDialog(this) == DialogResult.OK)
                {
                    LoadData();
                }
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (dgvBonLivraison.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un bon de livraison à modifier.", "Aucune sélection");
                return;
            }

            int idToEdit = (int)dgvBonLivraison.SelectedRows[0].Tag;

            // We open the editor form, passing the ID of the record to edit
            using (FicheBonLivraison editorForm = new FicheBonLivraison(idToEdit))
            {
                if (editorForm.ShowDialog(this) == DialogResult.OK)
                {
                    // Refresh the grid if changes were saved
                    LoadData();
                }
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (dgvBonLivraison.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un bon de livraison à supprimer.", "Aucune sélection");
                return;
            }

            if (MessageBox.Show("Are you sure you want to delete this delivery note?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                int idToDelete = (int)dgvBonLivraison.SelectedRows[0].Tag;

                // Soft delete query (safer than permanent deletion)
                string query = "UPDATE BonLivraisons SET IsActive = 0 WHERE BL_ID = @ID";
                try
                {
                    using (var conn = new SqlConnection(connectionString))
                    using (var cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ID", idToDelete);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        LoadData(); // Refresh the grid to show the change
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting delivery note: " + ex.Message);
                }
            }
        }
    }
}