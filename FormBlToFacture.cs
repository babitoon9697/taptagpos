using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TAPTAGPOS
{
    public partial class FormBlToFacture : Form
    {
        private string connectionString = DatabaseConnection.GetConnectionString();
        private int selectedClientId = -1;

        public FormBlToFacture()
        {
            InitializeComponent();
            InitializeEventHandlers();
        }

        private void InitializeEventHandlers()
        {
            this.Load += FormBlToFacture_Load;
            this.cmbClient.SelectedIndexChanged += cmbClient_SelectedIndexChanged;
            this.btnSelectClient.Click += btnSelectClient_Click;
            this.chkSelectAll.CheckedChanged += chkSelectAll_CheckedChanged;
            this.btnToggleSelection.Click += btnToggleSelection_Click;
            this.btnFacturer.Click += btnFacturer_Click;
        }

        private void FormBlToFacture_Load(object sender, EventArgs e)
        {
            LoadClients();
        }

        private void LoadClients()
        {
            try
            {
                var dt = new DataTable();
                dt.Columns.Add("CustomerID", typeof(int));
                dt.Columns.Add("CustomerName", typeof(string));
                dt.Rows.Add(0, "Choisir un client...");

                using (var conn = new SqlConnection(connectionString))
                using (var adapter = new SqlDataAdapter("SELECT CustomerID, CustomerName FROM Customers WHERE IsActive=1 ORDER BY CustomerName", conn))
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

        private void cmbClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbClient.SelectedValue != null && (int)cmbClient.SelectedValue > 0)
            {
                this.selectedClientId = (int)cmbClient.SelectedValue;
                this.txtClientName.Text = cmbClient.Text;
                LoadUninvoicedDeliveryNotes(this.selectedClientId);
            }
            else
            {
                this.selectedClientId = -1;
                this.txtClientName.Clear();
                dgvDeliveryNotes.Rows.Clear();
            }
        }

        private void btnSelectClient_Click(object sender, EventArgs e)
        {
            // Assuming frmCustomersList can be used as a selector
            using (var customerSelector = new frmCustomersList())
            {
                if (customerSelector.ShowDialog() == DialogResult.OK)
                {
                    cmbClient.SelectedValue = customerSelector.SelectedCustomerId;
                }
            }
        }

        private void LoadUninvoicedDeliveryNotes(int customerId)
        {
            dgvDeliveryNotes.Rows.Clear();
            // This query gets all BLs for the client where SalesInvoiceID is NULL
            string query = @"
                SELECT BL_ID, BL_Number, BL_Date, TotalTTC 
                FROM BonLivraisons 
                WHERE CustomerID = @CID AND SalesInvoiceID IS NULL AND IsActive = 1
                ORDER BY BL_Date";
            try
            {
                using (var conn = new SqlConnection(connectionString))
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@CID", customerId);
                    conn.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            dgvDeliveryNotes.Rows.Add(
                                false, // colSelect checkbox
                                reader["BL_Number"],
                                ((DateTime)reader["BL_Date"]).ToShortDateString(),
                                Convert.ToDecimal(reader["TotalTTC"]).ToString("N2")
                            );
                            // Store the BL_ID in the Tag for easy access
                            dgvDeliveryNotes.Rows[dgvDeliveryNotes.Rows.Count - 1].Tag = reader["BL_ID"];
                        }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Error loading delivery notes: " + ex.Message); }
        }

        private void chkSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvDeliveryNotes.Rows)
            {
                if (row.Cells["colSelect"] is DataGridViewCheckBoxCell checkBoxCell)
                {
                    checkBoxCell.Value = chkSelectAll.Checked;
                }
            }
        }

        private void btnToggleSelection_Click(object sender, EventArgs e)
        {
            // Invert the selection of all checkboxes
            foreach (DataGridViewRow row in dgvDeliveryNotes.Rows)
            {
                bool currentValue = Convert.ToBoolean(row.Cells["colSelect"].Value);
                row.Cells["colSelect"].Value = !currentValue;
            }
        }

        private void btnFacturer_Click(object sender, EventArgs e)
        {
            List<int> selectedBlIds = new List<int>();
            foreach (DataGridViewRow row in dgvDeliveryNotes.Rows)
            {
                if (Convert.ToBoolean(row.Cells["colSelect"].Value) == true)
                {
                    selectedBlIds.Add((int)row.Tag);
                }
            }

            if (selectedBlIds.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner au moins un bon de livraison à facturer.", "Aucune sélection");
                return;
            }

            // Open the final transformation form, passing the client ID and the list of BL IDs
            using (FormTransformationBlFacture transformationForm = new FormTransformationBlFacture(this.selectedClientId, selectedBlIds))
            {
                if (transformationForm.ShowDialog(this) == DialogResult.OK)
                {
                    // Refresh the list, the invoiced BLs should now be gone
                    LoadUninvoicedDeliveryNotes(this.selectedClientId);
                }
            }
        }
    }
}