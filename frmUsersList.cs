using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TAPTAGPOS
{
    public partial class frmUsersList : Form
    {
        private string connectionString = DatabaseConnection.GetConnectionString();
        public int SelectedUserId { get; private set; }
        public string SelectedUserName { get; private set; }

        public frmUsersList()
        {
            InitializeComponent();
            InitializeEvents();
        }

        private void InitializeEvents()
        {
            this.Load += frmUsersList_Load;
            this.btnAdd.Click += btnAdd_Click;
            this.btnEdit.Click += btnEdit_Click;
            this.btnDelete.Click += btnDelete_Click;
            this.btnClose.Click += (s, e) => this.Close();
            this.dgvUsers.CellDoubleClick += dgvUsers_CellDoubleClick;
        }

        private void frmUsersList_Load(object sender, EventArgs e)
        {
            StyleDataGridView();
            LoadUsers();
        }

        private void StyleDataGridView()
        {
            // This prevents the grid from creating extra columns automatically
            dgvUsers.AutoGenerateColumns = false;

            // Map your designer columns to the data we will load from the database
            colName.DataPropertyName = "FullName";
            colCardNumber.DataPropertyName = "CardNumber";
            colPhone.DataPropertyName = "Phone";
            colAddress.DataPropertyName = "Address";

            // Add a hidden column to store the UserID
            if (!dgvUsers.Columns.Contains("UserID"))
            {
                dgvUsers.Columns.Add("UserID", "UserID");
                dgvUsers.Columns["UserID"].DataPropertyName = "UserID";
                dgvUsers.Columns["UserID"].Visible = false;
            }
        }

        public void LoadUsers()
        {
            try
            {
                // We will load data into a DataTable and bind it to the grid.
                // This is more efficient and safer than adding rows manually.
                var dt = new DataTable();
                string query = "SELECT UserID, FullName, Username, UserRole, CardNumber, Phone, Address FROM Users WHERE IsActive = 1";

                using (var conn = new SqlConnection(connectionString))
                using (var adapter = new SqlDataAdapter(query, conn))
                {
                    adapter.Fill(dt);
                }

                dgvUsers.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء تحميل قائمة المستخدمين: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (frmAddEditUser addUserForm = new frmAddEditUser())
            {
                if (addUserForm.ShowDialog(this) == DialogResult.OK)
                {
                    LoadUsers(); // Refresh the list after adding
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            HandleEditAction();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count == 0)
            {
                MessageBox.Show("الرجاء تحديد مستخدم لحذفه.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("هل أنت متأكد من أنك تريد حذف هذا المستخدم؟", "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int selectedUserId = Convert.ToInt32(dgvUsers.SelectedRows[0].Cells["UserID"].Value);

                if (selectedUserId == 1)
                {
                    MessageBox.Show("لا يمكن حذف المستخدم الرئيسي.", "عملية مرفوضة", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // --- FIX: Use a 'soft delete' by deactivating the user instead of permanently deleting ---
                string query = "UPDATE Users SET IsActive = 0 WHERE UserID = @UserID";
                try
                {
                    using (var conn = new SqlConnection(connectionString))
                    using (var cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserID", selectedUserId);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        LoadUsers(); // Refresh the list
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("فشل حذف المستخدم: " + ex.Message);
                }
            }
        }

        private void dgvUsers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // This form can also be used to select a user
                SelectUserAndClose();
            }
        }

        private void HandleEditAction()
        {
            if (dgvUsers.SelectedRows.Count > 0)
            {
                int selectedUserId = Convert.ToInt32(dgvUsers.SelectedRows[0].Cells["UserID"].Value);
                using (frmAddEditUser editForm = new frmAddEditUser(selectedUserId))
                {
                    if (editForm.ShowDialog(this) == DialogResult.OK)
                    {
                        LoadUsers(); // Refresh after editing
                    }
                }
            }
            else
            {
                MessageBox.Show("الرجاء تحديد مستخدم من القائمة لتعديله.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SelectUserAndClose()
        {
            if (dgvUsers.SelectedRows.Count > 0)
            {
                var selectedRow = dgvUsers.SelectedRows[0];
                this.SelectedUserId = Convert.ToInt32(selectedRow.Cells["UserID"].Value);
                this.SelectedUserName = selectedRow.Cells["colName"].Value.ToString();

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}