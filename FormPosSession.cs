using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace TAPTAGPOS
{
    public partial class FormPosSession : Form
    {
        private string connectionString = DatabaseConnection.GetConnectionString();

        // Load these icons from your project's resources
        private Image openIcon = Properties.Resources.open_icon;
        private Image closedIcon = Properties.Resources.closed_icon;

        public FormPosSession()
        {
            InitializeComponent();
            InitializeEventHandlers();
        }

        private void InitializeEventHandlers()
        {
            this.Load += FormPosSession_Load;
            this.btnNew.Click += btnNew_Click;
            this.btnView.Click += btnView_Click;
            this.btnCloseSession.Click += btnCloseSession_Click;
            this.btnExit.Click += (s, e) => this.Close();
        }

        private void FormPosSession_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            dgvSessions.Rows.Clear();
            string query = "SELECT SessionID, UserID, StartDate, EndDate, Status FROM PosSessions ORDER BY StartDate DESC";
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
                            var status = reader["Status"].ToString();
                            var startDate = (DateTime)reader["StartDate"];

                            int rowIndex = dgvSessions.Rows.Add(
                                reader["SessionID"],
                                reader["UserID"],
                                startDate.ToShortDateString(),
                                startDate.ToShortTimeString(),
                                reader["EndDate"] == DBNull.Value ? "" : ((DateTime)reader["EndDate"]).ToShortDateString(),
                                reader["EndDate"] == DBNull.Value ? "" : ((DateTime)reader["EndDate"]).ToShortTimeString(),
                                (status == "Open") ? openIcon : closedIcon
                            );
                            // Store both the ID and the Status in the row's Tag for easy access
                            dgvSessions.Rows[rowIndex].Tag = new { SessionID = (int)reader["SessionID"], Status = status };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading POS sessions: " + ex.Message);
            }
        }

        // --- FIX: Check for open session before creating a new one ---
        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                bool isSessionOpen = false;
                using (var conn = new SqlConnection(connectionString))
                using (var cmd = new SqlCommand("SELECT COUNT(*) FROM PosSessions WHERE Status = 'Open'", conn))
                {
                    conn.Open();
                    isSessionOpen = (int)cmd.ExecuteScalar() > 0;
                }

                if (isSessionOpen)
                {
                    MessageBox.Show("لا يمكن فتح جلسة جديدة، هناك جلسة مفتوحة بالفعل.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // If no session is open, proceed to create a new one
                using (FormCaisseDetail editorForm = new FormCaisseDetail())
                {
                    editorForm.ShowDialog(this);
                    LoadData(); // Refresh list after form closes
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error checking for open sessions: " + ex.Message);
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (dgvSessions.SelectedRows.Count == 0) return;
            var tag = (dynamic)dgvSessions.SelectedRows[0].Tag;
            int idToView = tag.SessionID;

            using (FormCaisseDetail viewForm = new FormCaisseDetail(idToView))
            {
                viewForm.ShowDialog(this);
            }
        }

        // --- FIX: Check if session is already closed before trying to close it ---
        private void btnCloseSession_Click(object sender, EventArgs e)
        {
            if (dgvSessions.SelectedRows.Count == 0)
            {
                MessageBox.Show("الرجاء تحديد جلسة من القائمة.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var tag = (dynamic)dgvSessions.SelectedRows[0].Tag;
            int idToClose = tag.SessionID;
            string status = tag.Status;

            if (status == "Closed")
            {
                MessageBox.Show("هذه الجلسة مغلقة بالفعل.", "معلومات", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // If the session is Open, proceed to the closing form
            using (FormCaisseDetail closeForm = new FormCaisseDetail(idToClose))
            {
                if (closeForm.ShowDialog(this) == DialogResult.OK)
                {
                    LoadData(); // Refresh the list
                }
            }
        }
    }
}