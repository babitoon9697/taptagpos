// TAPTAGPOS/AddSupplier.cs

using System;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace TAPTAGPOS
{
    public partial class AddSupplier : Form // Renamed from AddSUpplier to follow C# conventions
    {
        private bool isEditMode = false;
        private int currentSupplierId = -1;
        // Assuming DatabaseConnection.GetConnectionString() is a static method in your project
        // Example: public static class DatabaseConnection { public static string GetConnectionString() { return "your_connection_string_here"; } }


        public AddSupplier()
        {
            InitializeComponent();
            // Set default for CreditLimit if txtCreditLimit exists and is a TextBox
            if (this.Controls.Find("txtCreditLimit", true).FirstOrDefault() is TextBox creditLimitBox)
            {
                creditLimitBox.Text = "0.00";
            }

        }

        // Constructor for Edit Mode
        public AddSupplier(int supplierIdToEdit) : this() // Calls the default constructor first
        {
            this.isEditMode = true;
            this.currentSupplierId = supplierIdToEdit;
            this.Text = "Modifier Fournisseur"; // Change form title
            // Assuming btn_AddUpdate is the name of your Save/Update button
            if (this.Controls.Find("btn_AddUpdate", true).FirstOrDefault() is Button addButton)
            {
                addButton.Text = "Mettre à jour"; // Change button text
            }
            LoadSupplierDetails(supplierIdToEdit);
        }


        private void LoadSupplierDetails(int supplierId)
        {
            string connectionString = DatabaseConnection.GetConnectionString();
            string query = "SELECT * FROM Suppliers WHERE SupplierID = @SupplierID";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@SupplierID", supplierId);
                    try
                    {
                        conn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            txtSupplierName.Text = reader["Name"]?.ToString();
                            txtContactPerson.Text = reader["ContactPerson"]?.ToString();
                            txtPhone.Text = reader["Phone"]?.ToString();
                            txtMobile.Text = reader["Mobile"]?.ToString();
                            txtEmail.Text = reader["Email"]?.ToString();
                            txtAddress.Text = reader["Address"]?.ToString();
                            txtCity.Text = reader["City"]?.ToString();
                            txtCountry.Text = reader["Country"]?.ToString();
                            txtVATNumber.Text = reader["VATNumber"]?.ToString();
                            txtAccountNumber.Text = reader["AccountNumber"]?.ToString();
                            txtCreditLimit.Text = Convert.ToDecimal(reader["CreditLimit"]).ToString("0.00");
                            txtNotes.Text = reader["Notes"]?.ToString();
                        }
                        else
                        {
                            MessageBox.Show("Fournisseur non trouvé.");
                            this.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erreur lors du chargement des détails du fournisseur: " + ex.Message);
                        this.Close();
                    }
                }
            }
        }


        // Assuming bunifuButton21 is not relevant to this logic, or it's a typo for btn_AddUpdate
        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            // If this is your "Save" or "Add/Update" button, its logic should be in btn_AddUpdate_Click
            // If it's a different button, its specific logic goes here.
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel; // Optional: set dialog result
            this.Close();
        }

        private bool ValidateSupplierInputs()
        {
            if (string.IsNullOrWhiteSpace(txtSupplierName.Text))
            {
                MessageBox.Show("Le nom du fournisseur est obligatoire.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSupplierName.Focus();
                return false;
            }
            // Add more validations if needed (e.g., email format, phone format, numeric for credit limit)
            if (!string.IsNullOrWhiteSpace(txtCreditLimit.Text) && !decimal.TryParse(txtCreditLimit.Text, out _))
            {
                MessageBox.Show("La limite de crédit doit être un nombre valide.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCreditLimit.Focus();
                return false;
            }
            return true;
        }

        private void ClearForm()
        {
            txtSupplierName.Text = "";
            txtContactPerson.Text = "";
            txtPhone.Text = "";
            txtMobile.Text = "";
            txtEmail.Text = "";
            txtAddress.Text = "";
            txtCity.Text = "";
            txtCountry.Text = "";
            txtVATNumber.Text = "";
            txtAccountNumber.Text = "";
            txtCreditLimit.Text = "0.00";
            txtNotes.Text = "";

            // Reset edit mode specifics only if truly clearing for a new entry after an edit
            // If the form is closed after edit, this isn't strictly necessary here.
            // isEditMode = false;
            // currentSupplierId = -1;
            // this.Text = "Ajouter Fournisseur";
            // if (this.Controls.Find("btn_AddUpdate", true).FirstOrDefault() is Button addButton)
            // {
            //    addButton.Text = "Ajouter";
            // }
        }
        // In AddSupplier.cs

        private void btn_AddUpdate_Click(object sender, EventArgs e)
        {
            if (!ValidateSupplierInputs()) return;

            string connectionString = DatabaseConnection.GetConnectionString();

            if (!isEditMode) // Add new supplier
            {
                string query = @"
            INSERT INTO Suppliers (
                SupplierCode, Name, ContactPerson, Phone, Mobile, Email, Address, City, Country,
                VATNumber, AccountNumber, CreditLimit, Notes, CreatedAt, Status
            ) VALUES (
                @Code, @Name, @ContactPerson, @Phone, @Mobile, @Email, @Address, @City, @Country,
                @VATNumber, @AccountNumber, @CreditLimit, @Notes, @DateAdded, 'Active'
            )";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Auto-generate a simple supplier code for now
                        cmd.Parameters.AddWithValue("@Code", "FOUR" + DateTime.Now.Ticks.ToString().Substring(10));
                        SetupSupplierParameters(cmd);
                        cmd.Parameters.AddWithValue("@DateAdded", DateTime.Now);

                        try
                        {
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Fournisseur ajouté avec succès!", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Erreur lors de l'ajout: " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else // Update existing supplier
            {
                string query = @"
            UPDATE Suppliers SET
                Name = @Name, ContactPerson = @ContactPerson, Phone = @Phone, Mobile = @Mobile,
                Email = @Email, Address = @Address, City = @City, Country = @Country,
                VATNumber = @VATNumber, AccountNumber = @AccountNumber, CreditLimit = @CreditLimit,
                Notes = @Notes, UpdatedAt = @DateModified
            WHERE SupplierID = @SupplierID";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@SupplierID", currentSupplierId);
                        SetupSupplierParameters(cmd);
                        cmd.Parameters.AddWithValue("@DateModified", DateTime.Now);

                        try
                        {
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Fournisseur mis à jour avec succès!", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Erreur lors de la mise à jour: " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }
        private void SetupSupplierParameters(SqlCommand cmd)
        {
            cmd.Parameters.AddWithValue("@Name", txtSupplierName.Text.Trim());
            // Use DBNull.Value for optional fields if they are empty,
            // assuming your database columns allow NULLs for these.
            cmd.Parameters.AddWithValue("@ContactPerson", string.IsNullOrWhiteSpace(txtContactPerson.Text) ? (object)DBNull.Value : txtContactPerson.Text.Trim());
            cmd.Parameters.AddWithValue("@Phone", string.IsNullOrWhiteSpace(txtPhone.Text) ? (object)DBNull.Value : txtPhone.Text.Trim());
            cmd.Parameters.AddWithValue("@Mobile", string.IsNullOrWhiteSpace(txtMobile.Text) ? (object)DBNull.Value : txtMobile.Text.Trim());
            cmd.Parameters.AddWithValue("@Email", string.IsNullOrWhiteSpace(txtEmail.Text) ? (object)DBNull.Value : txtEmail.Text.Trim());
            cmd.Parameters.AddWithValue("@Address", string.IsNullOrWhiteSpace(txtAddress.Text) ? (object)DBNull.Value : txtAddress.Text.Trim());
            cmd.Parameters.AddWithValue("@City", string.IsNullOrWhiteSpace(txtCity.Text) ? (object)DBNull.Value : txtCity.Text.Trim());
            cmd.Parameters.AddWithValue("@Country", string.IsNullOrWhiteSpace(txtCountry.Text) ? (object)DBNull.Value : txtCountry.Text.Trim());
            cmd.Parameters.AddWithValue("@VATNumber", string.IsNullOrWhiteSpace(txtVATNumber.Text) ? (object)DBNull.Value : txtVATNumber.Text.Trim());
            cmd.Parameters.AddWithValue("@AccountNumber", string.IsNullOrWhiteSpace(txtAccountNumber.Text) ? (object)DBNull.Value : txtAccountNumber.Text.Trim());
            cmd.Parameters.AddWithValue("@CreditLimit", decimal.TryParse(txtCreditLimit.Text, out var cl) ? cl : 0m); // Ensure 'm' for decimal literal
            cmd.Parameters.AddWithValue("@Notes", string.IsNullOrWhiteSpace(txtNotes.Text) ? (object)DBNull.Value : txtNotes.Text.Trim());
        }

    }
}