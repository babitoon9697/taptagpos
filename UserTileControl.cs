using System;
using System.Drawing;
using System.Windows.Forms;

namespace TAPTAGPOS
{
    public partial class UserTileControl : UserControl
    {
        // A simple class to hold user data. You can expand this if needed.
        public class UserData
        {
            public int UserId { get; set; }
            public string UserName { get; set; }
        }

        // Event that the parent form (UserPickForm) will listen to
        public event EventHandler<UserData> UserSelected;

        private UserData _currentUser;

        public UserTileControl()
        {
            InitializeComponent();
            // Make all child controls and the panel itself respond to a click
            this.Click += new EventHandler(OnUserTileClick);
            this.lblUserName.Click += new EventHandler(OnUserTileClick);
            this.bunifuPanel1.Click += new EventHandler(OnUserTileClick);
            if (this.pbUserIcon != null)
            {
                this.pbUserIcon.Click += new EventHandler(OnUserTileClick);
            }
        }

        /// <summary>
        /// Populates the control with a user's information.
        /// </summary>
        public void SetUserData(UserData user)
        {
            _currentUser = user;
            lblUserName.Text = user.UserName;
            // You could set a user-specific icon here if you have one
        }

        /// <summary>
        /// When the tile is clicked, raise the UserSelected event.
        /// </summary>
        private void OnUserTileClick(object sender, EventArgs e)
        {
            UserSelected?.Invoke(this, _currentUser);
        }
    }
}