using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TAPTAGPOS
{
    public partial class frmFiltreSuiviArticle : Form
    {
        // Public properties to return the selected filter values
        public DateTime StartDate { get; private set; }
        public DateTime EndDate { get; private set; }
        public int SelectedCustomerID { get; private set; }

        private string connectionString = DatabaseConnection.GetConnectionString();

        public frmFiltreSuiviArticle()
        {
            InitializeComponent();
            this.Load += frmFiltreSuiviArticle_Load;
            this.btnOK.Click += btnOK_Click;
            this.btnCancel.Click += (s, e) => this.Close();
        }

        private void frmFiltreSuiviArticle_Load(object sender, EventArgs e)
        {
            dtpFrom.Value = DateTime.Today.AddMonths(-1);
            dtpTo.Value = DateTime.Today;
            LoadClients();
        }

        private void LoadClients()
        {
            try
            {
                var dt = new DataTable();
                dt.Columns.Add("CustomerID", typeof(int));
                dt.Columns.Add("CustomerName", typeof(string));
                dt.Rows.Add(0, "Tous les Clients"); // "All Customers" option

                using (var conn = new SqlConnection(connectionString))
                using (var adapter = new SqlDataAdapter("SELECT CustomerID, CustomerName FROM Customers ORDER BY CustomerName", conn))
                {
                    adapter.Fill(dt);
                }
                cmbClient.DataSource = dt;
                cmbClient.DisplayMember = "CustomerName";
                cmbClient.ValueMember = "CustomerID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading clients: " + ex.Message);
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.StartDate = dtpFrom.Value;
            this.EndDate = dtpTo.Value;
            this.SelectedCustomerID = (int)cmbClient.SelectedValue;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}