using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace TAPTAGPOS
{
    public partial class FormStockCorrection : Form
    {
        private string connectionString = DatabaseConnection.GetConnectionString();

        public FormStockCorrection()
        {
            InitializeComponent();
            this.Load += FormStockCorrection_Load;
            this.btnConfirm.Click += (s, e) => LoadData(); // "Confirm" button acts as a filter
            this.btnAdd.Click += btnAdd_Click;
            this.btnView.Click += btnView_Click;
        }

        private void FormStockCorrection_Load(object sender, EventArgs e)
        {
            dtpStartDate.Value = DateTime.Now.AddMonths(-1);
            dtpEndDate.Value = DateTime.Now;
            LoadWarehouses();
            LoadData();
        }

        private void LoadWarehouses()
        {
            // Logic to load all warehouses into cmbWarehouse1 and cmbWarehouse2
        }

        private void LoadData()
        {
            dgvCorrections.Rows.Clear();
            string query = @"
                SELECT sc.CorrectionID, sc.CorrectionDate, sc.UserID, w.WarehouseName
                FROM StockCorrections sc
                JOIN Warehouses w ON sc.WarehouseID = w.WarehouseID
                WHERE sc.IsActive = 1 AND sc.CorrectionDate BETWEEN @StartDate AND @EndDate
                ORDER BY sc.CorrectionDate DESC";

            try
            {
                using (var conn = new SqlConnection(connectionString))
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@StartDate", dtpStartDate.Value.Date);
                    cmd.Parameters.AddWithValue("@EndDate", dtpEndDate.Value.Date.AddDays(1));
                    conn.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int rowIndex = dgvCorrections.Rows.Add();
                            DataGridViewRow row = dgvCorrections.Rows[rowIndex];
                            row.Tag = reader["CorrectionID"];
                            row.Cells["colDate"].Value = ((DateTime)reader["CorrectionDate"]).ToShortDateString();
                            row.Cells["colUser"].Value = reader["UserID"];
                            row.Cells["colWarehouse"].Value = reader["WarehouseName"];
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading stock corrections: " + ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (FicheStockCorrection editorForm = new FicheStockCorrection())
            {
                editorForm.ShowDialog(this);
                LoadData(); // Refresh list after adding
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (dgvCorrections.SelectedRows.Count == 0) return;
            int idToView = (int)dgvCorrections.SelectedRows[0].Tag;

            // This now correctly calls the new constructor
            using (FicheStockCorrection viewForm = new FicheStockCorrection(idToView))
            {
                viewForm.ShowDialog(this);
            }
        }
    }
}