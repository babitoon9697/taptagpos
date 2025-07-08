using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace TAPTAGPOS
{
    public partial class FicheBordereau : Form
    {
        private string connectionString = DatabaseConnection.GetConnectionString();
        // Class-level variables to hold selected IDs
        private int _selectedClientId = -1;
        private int selectedTransportId = -1;
        private int _selectedTransportId = -1;
        private List<int> _selectedBlIds = new List<int>();


        public FicheBordereau()
        {
            InitializeComponent();
            InitializeEventHandlers();
            this.Load += FicheBordereau_Load;

        }
        // In FicheBordereau.cs
        private void InitializeEventHandlers()
        {
            this.Load += FicheBordereau_Load;
            this.btnSelectClient.Click += btnSelectClient_Click;
            this.cmbClient.SelectedIndexChanged += cmbClient_SelectedIndexChanged;
            this.btnOK.Click += btnOK_Click;
            this.btnFermer.Click += (s, e) => this.Close();
        }
        private void cmbClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbClient.SelectedValue is int clientId && clientId > 0)
            {
                _selectedClientId = clientId;

                // Open the TableBonLivraison form in selection mode
                using (var blSelector = new TableBonLivraison(clientId))
                {
                    if (blSelector.ShowDialog(this) == DialogResult.OK)
                    {
                        _selectedBlIds = blSelector.SelectedBlIds;
                        if (_selectedBlIds.Any())
                        {
                            LoadSelectedBlsIntoGrid(_selectedBlIds);
                        }
                    }
                }
            }
        }
        private void FicheBordereau_Load(object sender, EventArgs e)
        {
            LoadClients();
            LoadTransports();
            GenerateNewBordereauNumber();
        }
        private void GenerateNewBordereauNumber()
        {
            txtNumBordereau.Text = $"BR-{DateTime.Now:yyyy}-{AppSettingsManager.SerieBordereau:D5}";
        }

        private void LoadClients()
        {
            try
            {
                var dt = new DataTable();
                dt.Columns.Add("CustomerID", typeof(int));
                dt.Columns.Add("CustomerName", typeof(string));
                dt.Rows.Add(0, "Choisir un client...");

                // This query only selects clients who have available delivery notes
                string query = @"SELECT DISTINCT c.CustomerID, c.CustomerName 
                               FROM Customers c JOIN BonLivraisons bl ON c.CustomerID = bl.CustomerID 
                               WHERE bl.IsActive = 1 AND bl.BordereauID IS NULL 
                               ORDER BY c.CustomerName";

                using (var conn = new SqlConnection(connectionString))
                using (var adapter = new SqlDataAdapter(query, conn))
                {
                    adapter.Fill(dt);
                }
                cmbClient.DataSource = dt;
                cmbClient.DisplayMember = "CustomerName";
                cmbClient.ValueMember = "CustomerID";
            }
            catch (Exception ex) { MessageBox.Show("Erreur chargement clients: " + ex.Message); }
        }

        private void LoadTransports()
        {
            try
            {
                var dt = new DataTable();
                using (var conn = new SqlConnection(connectionString))
                using (var adapter = new SqlDataAdapter("SELECT TransportID, RaisonSociale FROM Transports WHERE IsActive=1", conn))
                {
                    adapter.Fill(dt);
                }
                cmbTransport.DataSource = dt;
                cmbTransport.DisplayMember = "RaisonSociale";
                cmbTransport.ValueMember = "TransportID";
            }
            catch (Exception ex) { MessageBox.Show("Erreur chargement transporteurs: " + ex.Message); }
        }
        private void btnSelectClient_Click(object sender, EventArgs e)
        {
            // We will re-use the main customer list form in "selection mode"
            using (frmCustomersList customerSelector = new frmCustomersList(isSelectionMode: true))
            {
                // Show the form as a dialog and wait for the user to make a choice
                if (customerSelector.ShowDialog(this) == DialogResult.OK)
                {
                    // If the user clicked OK and a customer was selected,
                    // get the ID from the form's public property.
                    int selectedId = customerSelector.SelectedCustomerId;

                    // Set the ComboBox's value. This will automatically update its
                    // displayed text and trigger the existing 'SelectedIndexChanged' event.
                    if (selectedId > 0)
                    {
                        cmbClient.SelectedValue = selectedId;
                    }
                }
            }
        }


        private void LoadSelectedBlsIntoGrid(List<int> blIds)
        {
            dgvLignes.Rows.Clear();
            if (!blIds.Any())
            {
                RecalculateTotals();
                return;
            }

            var paramNames = blIds.Select((id, index) => "@ID" + index).ToList();
            string query = $"SELECT BL_ID, BL_Number, TotalTTC FROM BonLivraisons WHERE BL_ID IN ({string.Join(",", paramNames)})";

            try
            {
                using (var conn = new SqlConnection(connectionString))
                using (var cmd = new SqlCommand(query, conn))
                {
                    for (int i = 0; i < paramNames.Count; i++)
                    {
                        cmd.Parameters.AddWithValue(paramNames[i], blIds[i]);
                    }
                    conn.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int rowIndex = dgvLignes.Rows.Add();
                            DataGridViewRow row = dgvLignes.Rows[rowIndex];
                            row.Tag = reader["BL_ID"];
                            row.Cells["colRef"].Value = reader["BL_Number"];
                            row.Cells["colTotal"].Value = reader["TotalTTC"];
                        }
                    }
                }
                RecalculateTotals();
            }
            catch (Exception ex) { MessageBox.Show("Erreur chargement bons de livraison: " + ex.Message); }
        }

        private void RecalculateTotals()
        {
            decimal totalTTC = 0m;
            foreach (DataGridViewRow row in dgvLignes.Rows)
            {
                totalTTC += Convert.ToDecimal(row.Cells["colTotal"].Value ?? 0);
            }
            txtTotalTTC.Text = totalTTC.ToString("N2");
            // You can add logic to back-calculate HT and TVA if needed
            txtTotalHT.Text = (totalTTC / 1.20m).ToString("N2"); // Assuming 20% TVA
            txtTVA.Text = (totalTTC - (totalTTC / 1.20m)).ToString("N2");
        }


        #region Save Logic

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (_selectedClientId <= 0 || _selectedBlIds.Count == 0 || cmbTransport.SelectedValue == null)
            {
                MessageBox.Show("Veuillez sélectionner un client, des bons de livraison, et un transporteur.", "Validation");
                return;
            }

            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                var transaction = conn.BeginTransaction();
                try
                {
                    // 1. Create main Bordereau record
                    int newBordereauId = SaveBordereauHeader(conn, transaction);

                    // 2. Link the selected BonLivraisons to this new Bordereau
                    LinkBlsToBordereau(conn, transaction, newBordereauId);

                    // 3. Increment the serial number
                    IncrementBordereauNumber(conn, transaction);

                    transaction.Commit();
                    MessageBox.Show("Bordereau enregistré avec succès!");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Erreur lors de la sauvegarde du bordereau: " + ex.Message);
                }
            }
        }

        private int SaveBordereauHeader(SqlConnection conn, SqlTransaction tran)
        {
            string paymentMethod = groupPaiement.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked)?.Text ?? "N/A";

            string query = @"INSERT INTO Bordereaux (BordereauNumber, BordereauDate, TransportID, TotalAmount, NumberOfBoxes, PaymentMethod) 
                             OUTPUT INSERTED.BordereauID 
                             VALUES (@Num, @Date, @TID, @Total, @Boxes, @Payment)";

            using (var cmd = new SqlCommand(query, conn, tran))
            {
                cmd.Parameters.AddWithValue("@Num", txtNumBordereau.Text);
                cmd.Parameters.AddWithValue("@Date", dtpDate.Value);
                cmd.Parameters.AddWithValue("@TID", (int)cmbTransport.SelectedValue);
                cmd.Parameters.AddWithValue("@Total", Convert.ToDecimal(txtTotalTTC.Text));
                cmd.Parameters.AddWithValue("@Boxes", Convert.ToInt32(string.IsNullOrWhiteSpace(txtNombreCaisse.Text) ? "0" : txtNombreCaisse.Text));
                cmd.Parameters.AddWithValue("@Payment", paymentMethod);
                return (int)cmd.ExecuteScalar();
            }
        }

        private void LinkBlsToBordereau(SqlConnection conn, SqlTransaction tran, int bordereauId)
        {
            foreach (int blId in _selectedBlIds)
            {
                // First, create the link in BordereauItems
                string queryItems = "INSERT INTO BordereauItems (BordereauID, BL_ID) VALUES (@BID, @BLID)";
                using (var cmd = new SqlCommand(queryItems, conn, tran))
                {
                    cmd.Parameters.AddWithValue("@BID", bordereauId);
                    cmd.Parameters.AddWithValue("@BLID", blId);
                    cmd.ExecuteNonQuery();
                }

                // Second, update the BonLivraison itself to mark it as dispatched
                string queryUpdate = "UPDATE BonLivraisons SET BordereauID = @BID WHERE BL_ID = @BLID";
                using (var cmd = new SqlCommand(queryUpdate, conn, tran))
                {
                    cmd.Parameters.AddWithValue("@BID", bordereauId);
                    cmd.Parameters.AddWithValue("@BLID", blId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void IncrementBordereauNumber(SqlConnection conn, SqlTransaction tran)
        {
            int nextSerial = AppSettingsManager.SerieBordereau + 1;
            string query = "UPDATE AppSettings SET SettingValue = @Val WHERE SettingKey = 'SerieBordereau'";
            using (var cmd = new SqlCommand(query, conn, tran))
            {
                cmd.Parameters.AddWithValue("@Val", nextSerial.ToString());
                cmd.ExecuteNonQuery();
            }
            AppSettingsManager.LoadSettings();
        }
        #endregion
    }
}