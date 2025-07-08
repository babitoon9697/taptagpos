using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TAPTAGPOS
{
    public partial class UserPickForm : Form
    {
        // Public property to hold the result after a user is selected
        public string SelectedUserName { get; private set; }

        private readonly string connectionString = DatabaseConnection.GetConnectionString();

        public UserPickForm()
        {
            InitializeComponent();
            this.Load += UserPickForm_Load;
        }

        private void UserPickForm_Load(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void LoadUsers()
        {
            // Fetch all active users/sellers from the database
            // IMPORTANT: Adjust the query if your table/column names are different.
            string query = "SELECT UserID, UserName FROM Users WHERE IsActive = 1 ORDER BY UserName";
            var users = new List<UserTileControl.UserData>();

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
                            users.Add(new UserTileControl.UserData
                            {
                                UserId = Convert.ToInt32(reader["UserID"]),
                                UserName = reader["UserName"].ToString()
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load users: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Create a tile for each user and add it to the form
            foreach (var user in users)
            {
                var userTile = new UserTileControl();
                userTile.SetUserData(user);
                userTile.UserSelected += UserTile_UserSelected; // Subscribe to the click event
                flowLayoutPanelUsers.Controls.Add(userTile);
            }
        }

        // This event handler runs when a user tile is clicked
        private void UserTile_UserSelected(object sender, UserTileControl.UserData selectedUser)
        {
            // Store the selected user's name
            this.SelectedUserName = selectedUser.UserName;

            // Set the dialog result to OK and close the form
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}