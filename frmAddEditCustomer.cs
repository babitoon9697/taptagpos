using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TAPTAGPOS
{
    public partial class frmAddEditCustomer : Form
    {
        private bool isEditMode = false;
        private int currentCustomerId = 0;
        private string connectionString = DatabaseConnection.GetConnectionString();

        public frmAddEditCustomer()
        {
            InitializeComponent();
            this.Load += frmAddEditCustomer_Load;
            this.Text = "إضافة زبون جديد";
            btnConfirm.Text = "حفظ";
        }

        public frmAddEditCustomer(int customerId) : this()
        {
            this.isEditMode = true;
            this.currentCustomerId = customerId;
            this.Text = "تعديل بيانات الزبون";
            btnConfirm.Text = "تعديل";
        }

        private void frmAddEditCustomer_Load(object sender, EventArgs e)
        {
            // Load data for dropdowns
            LoadComboBoxData();

            if (isEditMode)
            {
                LoadCustomerForEditing(currentCustomerId);
            }
        }

     

        // In frmAddEditCustomer.cs

        private void LoadCustomerForEditing(int customerId)
        {
            // This query is correct
            string query = "SELECT * FROM Customers WHERE CustomerID = @CustomerID";

            try
            {
                using (var conn = new SqlConnection(connectionString))
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@CustomerID", customerId);
                    conn.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // --- START OF FIX: This section now safely handles NULL data from the database ---

                            // Text fields (safe with ? operator)
                            txtCode.Text = reader["CustomerID"]?.ToString();
                            txtCustomerName.Text = reader["CustomerName"]?.ToString();
                            txtAddress.Text = reader["Addresse"]?.ToString();
                            txtCity.Text = reader["City"]?.ToString();
                            txtPhone.Text = reader["Phone"]?.ToString();
                            txtFax.Text = reader["Fax"]?.ToString();
                            txtEmail.Text = reader["Email"]?.ToString();
                            cmbTariff.Text = reader["Tarifs"]?.ToString();
                            txtIF.Text = reader["IF"]?.ToString();
                            txtICE.Text = reader["ICE"]?.ToString();
                            txtPatente.Text = reader["CustomerPatente"]?.ToString();
                            txtCIN.Text = reader["CIN"]?.ToString();

                            // CheckBox (requires a specific DBNull check)
                            chkCreditAllowed.Checked = reader["CreditAllowed"] != DBNull.Value && Convert.ToBoolean(reader["CreditAllowed"]);

                            // Numeric fields (each requires a DBNull check before converting)
                            txtDebtCeiling.Text = reader["DebtCeiling"] != DBNull.Value ? Convert.ToDecimal(reader["DebtCeiling"]).ToString("F2") : "0.00";
                            txtPaymentTerm.Text = reader["PaymentTerm"] != DBNull.Value ? Convert.ToInt32(reader["PaymentTerm"]).ToString() : "0";
                            txtCheckCeiling.Text = reader["CheckCeiling"] != DBNull.Value ? Convert.ToDecimal(reader["CheckCeiling"]).ToString("F2") : "0.00";

                            // --- END OF FIX ---
                        }
                        else
                        {
                            MessageBox.Show("لم يتم العثور على الزبون المحدد.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ في تحميل بيانات الزبون: " + ex.Message, "خطأ فادح", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCustomerName.Text))
            {
                MessageBox.Show("الرجاء إدخال اسم الزبون.", "بيانات ناقصة", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query;
            if (isEditMode)
            {
                // CORRECTED: Query now uses the new ID columns
                query = @"UPDATE Customers SET 
                            CustomerName = @Name, Addresse = @Address, Phone = @Phone, Tarifs = @Tariff, 
                            CreditAllowed = @CreditAllowed, DebtCeiling = @DebtCeiling, 
                            AreaID = @AreaID, SalespersonID = @SalespersonID 
                          WHERE CustomerID = @CustomerID";
            }
            else
            {
                // CORRECTED: Query now uses the new ID columns
                query = @"INSERT INTO Customers 
                            (CustomerName, Addresse, Phone, Tarifs, CreditAllowed, DebtCeiling, AreaID, SalespersonID, IsActive, AmountDue) 
                          VALUES 
                            (@Name, @Address, @Phone, @Tariff, @CreditAllowed, @DebtCeiling, @AreaID, @SalespersonID, 1, 0)";
            }

            try
            {
                using (var conn = new SqlConnection(connectionString))
                using (var cmd = new SqlCommand(query, conn))
                {
                    // --- FIX: Add parameters for the new ID columns ---
                    cmd.Parameters.AddWithValue("@Name", txtCustomerName.Text);
                    cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@Phone", txtPhone.Text);
                    cmd.Parameters.AddWithValue("@Tariff", cmbTariff.Text);
                    cmd.Parameters.AddWithValue("@CreditAllowed", chkCreditAllowed.Checked);
                    cmd.Parameters.AddWithValue("@DebtCeiling", decimal.TryParse(txtDebtCeiling.Text, out var dc) ? dc : 0);

                    // Save the selected ID, or DBNull if nothing is selected
                    cmd.Parameters.AddWithValue("@AreaID", (int)cmbArea.SelectedValue > 0 ? cmbArea.SelectedValue : DBNull.Value);
                    cmd.Parameters.AddWithValue("@SalespersonID", (int)cmbSalesperson.SelectedValue > 0 ? cmbSalesperson.SelectedValue : DBNull.Value);

                    if (isEditMode)
                    {
                        cmd.Parameters.AddWithValue("@CustomerID", this.currentCustomerId);
                    }

                    conn.Open();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show(isEditMode ? "تم تعديل البيانات بنجاح." : "تمت إضافة الزبون بنجاح.", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("فشل حفظ البيانات: " + ex.Message, "خطأ فادح", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadComboBoxData()
        {
            // Load Areas (Zones)
            LoadGenericComboBox(cmbArea, "SELECT ZoneID, ZoneName FROM Zones WHERE IsActive = 1", "ZoneName", "ZoneID", "اختر منطقة...");
            // Load Salespeople (Users)
            LoadGenericComboBox(cmbSalesperson, "SELECT UserID, FullName FROM Users WHERE IsActive = 1", "FullName", "UserID", "اختر بائع...");

            // Load Tariffs manually as before
            cmbTariff.Items.Clear();
            cmbTariff.Items.AddRange(new object[] { "Détail", "Gros", "Semigros", "Special" });
            cmbTariff.SelectedIndex = 0;
        }

        // Helper method to load any ComboBox

        // Helper method to load any ComboBox
        private void LoadGenericComboBox(ComboBox cmb, string query, string displayMember, string valueMember, string placeholder)
        {
            try
            {
                var dt = new DataTable();
                using (var conn = new SqlConnection(connectionString))
                {
                    new SqlDataAdapter(query, conn).Fill(dt);
                }
                DataRow dr = dt.NewRow();
                dr[valueMember] = 0; // Use 0 or DBNull for the placeholder
                dr[displayMember] = placeholder;
                dt.Rows.InsertAt(dr, 0);

                cmb.DataSource = dt;
                cmb.DisplayMember = displayMember;
                cmb.ValueMember = valueMember;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data for {displayMember}: {ex.Message}");
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}