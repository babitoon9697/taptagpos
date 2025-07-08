using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TAPTAGPOS
{
    public partial class Login : Form
    {
        private string connectionString = DatabaseConnection.GetConnectionString();

        public Login()
        {
            InitializeComponent();
            InitializeEvents();
        }

        private void InitializeEvents()
        {
            // Attach all the number buttons (0-9) to the SAME event handler
            bunifuButton21.Click += NumberButton_Click; // 1
            bunifuButton22.Click += NumberButton_Click; // 2
            bunifuButton23.Click += NumberButton_Click; // 3
            bunifuButton24.Click += NumberButton_Click; // 4
            bunifuButton25.Click += NumberButton_Click; // 5
            bunifuButton26.Click += NumberButton_Click; // 6
            bunifuButton27.Click += NumberButton_Click; // 7
            bunifuButton28.Click += NumberButton_Click; // 8
            bunifuButton29.Click += NumberButton_Click; // 9
            bunifuButton211.Click += NumberButton_Click; // 0

            // Attach the Clear and Validate buttons
            bunifuButton210.Click += ClearButton_Click; // CL
            bunifuButton212.Click += ValidateButton_Click; // VALIDER

            // Allow pressing Enter on the keyboard to also validate
            this.AcceptButton = bunifuButton212;
        }

        /// <summary>
        /// A single event handler for all number buttons (0-9).
        /// </summary>
        private void NumberButton_Click(object sender, EventArgs e)
        {
            // 'sender' is the button that was clicked. We get its text to know which digit to add.
            var button = (Button)sender;
            txt_password.Text += button.Text;
        }

        /// <summary>
        /// Handles the "CL" (Clear) button click.
        /// </summary>
        private void ClearButton_Click(object sender, EventArgs e)
        {
            txt_password.Clear();
        }

        /// <summary>
        /// Handles the "VALIDER" (Validate) button click.
        /// </summary>
        private void ValidateButton_Click(object sender, EventArgs e)
        {
            string enteredPin = txt_password.Text;

            if (string.IsNullOrWhiteSpace(enteredPin))
            {
                MessageBox.Show("الرجاء إدخال الرمز السري.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check the PIN against the database
            if (AuthenticateUser(enteredPin))
            {
                // If authentication is successful, set the DialogResult and close the form
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("الرمز السري غير صحيح. الرجاء المحاولة مرة أخرى.", "فشل المصادقة", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_password.Clear();
                txt_password.Focus();
            }
        }

        /// <summary>
        /// Queries the database to check if the provided PIN matches any active user.
        /// </summary>
        /// <param name="pin">The PIN entered by the user.</param>
        /// <returns>True if authentication is successful, otherwise false.</returns>
        private bool AuthenticateUser(string pin)
        {
            // Assuming your Users table has columns: UserName, Password, IsActive
            string query = "SELECT UserName FROM Users WHERE Password = @Password AND IsActive = 1";

            try
            {
                using (var conn = new SqlConnection(connectionString))
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Password", pin);
                    conn.Open();
                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        // User found, authentication successful!
                        string userName = result.ToString();

                        // Store the logged-in user's name in our static SessionManager class
                        SessionManager.CurrentUser = userName;

                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred during authentication: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // User not found or an error occurred
            return false;
        }
    }
}