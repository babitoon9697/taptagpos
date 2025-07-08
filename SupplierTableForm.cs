using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TAPTAGPOS
{
    public partial class SupplierTableForm : Form
    {
        private string connectionString = DatabaseConnection.GetConnectionString();
        private bool _isSelectionMode = false;

        // --- Public properties to return data to the calling form ---
        public int SelectedSupplierId { get; private set; }
        public string SelectedSupplierCode { get; private set; }
        public string SelectedSupplierName { get; private set; }

        // Default constructor for general management
        public SupplierTableForm()
        {
            InitializeComponent();
            InitializeEvents();
        }

        // Constructor for selection mode
        public SupplierTableForm(bool isSelectionMode) : this()
        {
            _isSelectionMode = isSelectionMode;
            this.Text = "Choisir un Fournisseur";
        }

        private void InitializeEvents()
        {
            this.Load += SupplierTableForm_Load;
            this.buttonAdd.Click += buttonAdd_Click;
            this.buttonEdit.Click += buttonEdit_Click;
            this.buttonDelete.Click += buttonDelete_Click;
            this.dataGridViewSuppliers.CellDoubleClick += dataGridViewSuppliers_CellDoubleClick;
        }

        private void SupplierTableForm_Load(object sender, EventArgs e)
        {
            LoadSuppliers();
        }

        private void LoadSuppliers()
        {
            dataGridViewSuppliers.Rows.Clear();
            // Using the column names from your database schema
            string query = "SELECT SupplierID, SupplierCode, Name, Address, Phone, ContactPerson, Mobile FROM Suppliers WHERE Status = 'Active' ORDER BY Name";
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
                            int rowIndex = dataGridViewSuppliers.Rows.Add();
                            DataGridViewRow row = dataGridViewSuppliers.Rows[rowIndex];
                            row.Tag = reader["SupplierID"];
                            row.Cells["colSupplierCode"].Value = reader["SupplierCode"];
                            row.Cells["colSupplierName"].Value = reader["Name"];
                            row.Cells["colAddress"].Value = reader["Address"];
                            row.Cells["colPhone"].Value = reader["Phone"];
                            row.Cells["colContactPerson"].Value = reader["ContactPerson"];
                            row.Cells["colMobile"].Value = reader["Mobile"];
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading suppliers: " + ex.Message);
            }
        }

        private void dataGridViewSuppliers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (_isSelectionMode && e.RowIndex >= 0)
            {
                SelectAndClose();
            }
            else if (!_isSelectionMode && e.RowIndex >= 0)
            {
                // If not in selection mode, double-click should edit
                buttonEdit_Click(sender, e);
            }
        }

        private void SelectAndClose()
        {
            if (dataGridViewSuppliers.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewSuppliers.SelectedRows[0];
                this.SelectedSupplierId = (int)selectedRow.Tag;
                this.SelectedSupplierCode = selectedRow.Cells["colSupplierCode"].Value?.ToString();
                this.SelectedSupplierName = selectedRow.Cells["colSupplierName"].Value?.ToString();

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            // Open your existing AddSupplier form for adding a new one
            using (AddSupplier editor = new AddSupplier())
            {
                if (editor.ShowDialog(this) == DialogResult.OK)
                {
                    LoadSuppliers(); // Refresh the list
                }
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewSuppliers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un fournisseur à modifier.", "Aucune sélection");
                return;
            }
            int id = (int)dataGridViewSuppliers.SelectedRows[0].Tag;

            // Open your existing AddSupplier form in edit mode
            using (AddSupplier editor = new AddSupplier(id))
            {
                if (editor.ShowDialog(this) == DialogResult.OK)
                {
                    LoadSuppliers(); // Refresh the list
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewSuppliers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un fournisseur à supprimer.", "Aucune sélection");
                return;
            }
            if (MessageBox.Show("Are you sure you want to delete this supplier?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                int id = (int)dataGridViewSuppliers.SelectedRows[0].Tag;
                // Using a soft delete is always safer
                string query = "UPDATE Suppliers SET Status = 'Inactive' WHERE SupplierID = @ID";
                try
                {
                    using (var conn = new SqlConnection(connectionString))
                    using (var cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ID", id);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        LoadSuppliers(); // Refresh the list
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting supplier: " + ex.Message);
                }
            }
        }
    }
}