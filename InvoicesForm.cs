using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TAPTAGPOS
{
    public partial class InvoicesForm : Form
    {
        private readonly string connectionString = DatabaseConnection.GetConnectionString();
        private DataTable invoiceData; // Use a DataTable to hold the data for easy filtering

        public InvoicesForm()
        {
            InitializeComponent();
            SetupForm();
        }

        private void SetupForm()
        {
            // Set up the form and event handlers
            this.Load += InvoicesForm_Load;
            this.buttonConfirm.Click += ButtonConfirm_Click; // We will treat "Confirm" as "Edit"
            this.buttonPrint.Click += ButtonPrint_Click;
            this.textBoxSearch.TextChanged += TextBoxSearch_TextChanged;
            // Add a handler for double-clicking a row, which will also open the editor
            this.dataGridViewInvoices.CellDoubleClick += DataGridViewInvoices_CellDoubleClick;
        }

        private void InvoicesForm_Load(object sender, EventArgs e)
        {
            // Configure the grid and load the initial data
            SetupDataGridView();
            LoadInvoices();
        }

        private void SetupDataGridView()
        {
            // Improve visual style and performance
            dataGridViewInvoices.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewInvoices.RowHeadersVisible = false;
            dataGridViewInvoices.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewInvoices.MultiSelect = false;

            // Add a hidden column to store the InvoiceID
            if (!dataGridViewInvoices.Columns.Contains("InvoiceID"))
            {
                dataGridViewInvoices.Columns.Add("InvoiceID", "InvoiceID");
                dataGridViewInvoices.Columns["InvoiceID"].Visible = false;
            }
        }

        private void LoadInvoices()
        {
            try
            {
                // The SQL query joins Invoices with Customers to get the customer's name
                string query = @"
                    SELECT 
                        i.InvoiceID,
                        i.InvoiceDate,
                        i.InvoiceNumber,
                        c.CustomerName,
                        i.TotalTTC,
                        i.Status
                    FROM Invoices i
                    JOIN Customers c ON i.CustomerID = c.CustomerID
                    ORDER BY i.InvoiceDate DESC";

                using (var conn = new SqlConnection(connectionString))
                {
                    using (var adapter = new SqlDataAdapter(query, conn))
                    {
                        invoiceData = new DataTable();
                        adapter.Fill(invoiceData);

                        // Bind the DataTable to the grid
                        dataGridViewInvoices.DataSource = invoiceData;

                        // Map DataTable columns to the grid columns by name
                        dataGridViewInvoices.Columns["InvoiceID"].DataPropertyName = "InvoiceID";
                        dataGridViewInvoices.Columns["colDate"].DataPropertyName = "InvoiceDate";
                        dataGridViewInvoices.Columns["colInvoiceNumber"].DataPropertyName = "InvoiceNumber";
                        dataGridViewInvoices.Columns["colCustomer"].DataPropertyName = "CustomerName";
                        dataGridViewInvoices.Columns["colTotal"].DataPropertyName = "TotalTTC";

                        // You can format columns here if needed
                        dataGridViewInvoices.Columns["colTotal"].DefaultCellStyle.Format = "N2"; // Format as number with 2 decimal places
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load invoices: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OpenInvoiceForEditing(int invoiceId)
        {
            if (invoiceId > 0)
            {
                // Open the FicheFacture form in EDIT mode using the constructor we created
                using (var form = new FicheFacture(invoiceId))
                {
                    form.ShowDialog(this);
                }

                // After the form is closed, refresh the list to see any changes
                LoadInvoices();
            }
        }

        // --- EVENT HANDLERS FOR BUTTONS AND CONTROLS ---

        private void ButtonConfirm_Click(object sender, EventArgs e)
        {
            if (dataGridViewInvoices.SelectedRows.Count > 0)
            {
                int selectedInvoiceId = Convert.ToInt32(dataGridViewInvoices.SelectedRows[0].Cells["InvoiceID"].Value);
                OpenInvoiceForEditing(selectedInvoiceId);
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une facture à modifier.", "Aucune sélection", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void DataGridViewInvoices_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure the double click is on a valid row
            {
                int selectedInvoiceId = Convert.ToInt32(dataGridViewInvoices.Rows[e.RowIndex].Cells["InvoiceID"].Value);
                OpenInvoiceForEditing(selectedInvoiceId);
            }
        }

        private void ButtonPrint_Click(object sender, EventArgs e)
        {
            if (dataGridViewInvoices.SelectedRows.Count > 0)
            {
                int selectedInvoiceId = Convert.ToInt32(dataGridViewInvoices.SelectedRows[0].Cells["InvoiceID"].Value);
                // The easiest way to print is to just open the form, which has the print buttons.
                OpenInvoiceForEditing(selectedInvoiceId);
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une facture à imprimer.", "Aucune sélection", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void TextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // Filter the data in the grid without re-querying the database
                string searchValue = textBoxSearch.Text.Replace("'", "''"); // Basic protection against SQL injection-like errors in filter

                if (string.IsNullOrWhiteSpace(searchValue))
                {
                    invoiceData.DefaultView.RowFilter = string.Empty;
                }
                else
                {
                    invoiceData.DefaultView.RowFilter = $"InvoiceNumber LIKE '%{searchValue}%' OR CustomerName LIKE '%{searchValue}%'";
                }
            }
            catch (Exception ex)
            {
                // Can happen if filter syntax is bad
                Console.WriteLine("Filter error: " + ex.Message);
            }
        }

        // --- RECOMMENDED ADDITION: DELETE BUTTON ---
        // You should add a "Delete" button to your form's design and then connect it to this method.
        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewInvoices.SelectedRows.Count > 0)
            {
                int selectedInvoiceId = Convert.ToInt32(dataGridViewInvoices.SelectedRows[0].Cells["InvoiceID"].Value);
                string invoiceNumber = dataGridViewInvoices.SelectedRows[0].Cells["colInvoiceNumber"].Value.ToString();

                if (MessageBox.Show($"Êtes-vous sûr de vouloir supprimer la facture N° {invoiceNumber} ?\nCette action est irréversible.", "Confirmer la suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    try
                    {
                        using (var conn = new SqlConnection(connectionString))
                        using (var cmd = new SqlCommand("DELETE FROM Invoices WHERE InvoiceID = @ID", conn))
                        {
                            cmd.Parameters.AddWithValue("@ID", selectedInvoiceId);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                        }
                        MessageBox.Show("La facture a été supprimée avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadInvoices(); // Refresh the grid
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erreur lors de la suppression de la facture: " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une facture à supprimer.", "Aucune sélection", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}