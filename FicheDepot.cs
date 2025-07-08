using System;
using System.Data.SqlClient;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace TAPTAGPOS
{
    public partial class FicheDepot : Form
    {
        private bool isEditMode = false;
        private int depotId = 0;
        private string connectionString = DatabaseConnection.GetConnectionString();

        public FicheDepot()
        {
            InitializeComponent();
            this.Text = "Nouveau Dépôt";
            this.Load += FicheDepot_Load;
        }

        public FicheDepot(int idToEdit) : this()
        {
            this.isEditMode = true;
            this.depotId = idToEdit;
            this.Text = "Modifier Dépôt";
        }

        private void FicheDepot_Load(object sender, EventArgs e)
        {
            LoadInstalledPrinters();
            if (isEditMode)
            {
                LoadDataForEdit();
            }
        }

        private void LoadInstalledPrinters()
        {
            try
            {
                foreach (string printer in PrinterSettings.InstalledPrinters)
                {
                    cmbImprimante.Items.Add(printer);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not load printers: " + ex.Message);
            }
        }

        private void LoadDataForEdit()
        {
            string query = "SELECT WarehouseName, PrintSeparateTicket, PrinterName FROM Warehouses WHERE WarehouseID = @ID";
            try
            {
                using (var conn = new SqlConnection(connectionString))
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ID", this.depotId);
                    conn.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtDepot.Text = reader["WarehouseName"]?.ToString();
                            chkImprimerTicketSepare.Checked = reader["PrintSeparateTicket"] != DBNull.Value && Convert.ToBoolean(reader["PrintSeparateTicket"]);
                            cmbImprimante.Text = reader["PrinterName"]?.ToString();
                        }
                    }
                }
            }
            catch (Exception ex) { /* Error handling */ }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDepot.Text))
            {
                MessageBox.Show("Le nom du dépôt est obligatoire.", "Validation");
                return;
            }

            string query = isEditMode
                ? "UPDATE Warehouses SET WarehouseName=@Name, PrintSeparateTicket=@Print, PrinterName=@Printer WHERE WarehouseID=@ID"
                : "INSERT INTO Warehouses (WarehouseName, PrintSeparateTicket, PrinterName) VALUES (@Name, @Print, @Printer)";

            try
            {
                using (var conn = new SqlConnection(connectionString))
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", txtDepot.Text);
                    cmd.Parameters.AddWithValue("@Print", chkImprimerTicketSepare.Checked);
                    cmd.Parameters.AddWithValue("@Printer", cmbImprimante.SelectedItem?.ToString() ?? "");
                    if (isEditMode)
                    {
                        cmd.Parameters.AddWithValue("@ID", this.depotId);
                    }
                    conn.Open();
                    cmd.ExecuteNonQuery();

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving data: " + ex.Message);
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}