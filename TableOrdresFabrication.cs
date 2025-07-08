using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace TAPTAGPOS
{
    public partial class TableOrdresFabrication : Form
    {
        private string connectionString = DatabaseConnection.GetConnectionString();

        public TableOrdresFabrication()
        {
            InitializeComponent();
            this.btnFiltrer.Click += new System.EventHandler(this.btnFiltrer_Click);
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            this.btnConsulter.Click += new System.EventHandler(this.btnConsulter_Click);
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            this.btnImprimer.Click += new System.EventHandler(this.btnImprimer_Click);
            this.btnFermer.Click += (s, e) => this.Close();
        }

        private void LoadData(DateTime? start = null, DateTime? end = null, string machine = null, string responsable = null)
        {
            dgvOrders.Rows.Clear();
            var queryBuilder = new StringBuilder("SELECT OrderID, OrderNumber, StartDate, EndDate, LotNumber, Responsable FROM OrdresFabrication WHERE IsActive = 1 ");

            var parameters = new Dictionary<string, object>();

            // --- Dynamic Filtering Logic ---
            if (start.HasValue && end.HasValue)
            {
                queryBuilder.Append(" AND StartDate BETWEEN @StartDate AND @EndDate");
                parameters.Add("@StartDate", start.Value.Date);
                parameters.Add("@EndDate", end.Value.Date.AddDays(1).AddSeconds(-1));
            }
            if (!string.IsNullOrEmpty(machine) && machine != "All") // Assuming "All" is an option
            {
                queryBuilder.Append(" AND Machine = @Machine");
                parameters.Add("@Machine", machine);
            }
            if (!string.IsNullOrEmpty(responsable) && responsable != "All")
            {
                queryBuilder.Append(" AND Responsable = @Responsable");
                parameters.Add("@Responsable", responsable);
            }

            queryBuilder.Append(" ORDER BY StartDate DESC");

            try
            {
                using (var conn = new SqlConnection(connectionString))
                using (var cmd = new SqlCommand(queryBuilder.ToString(), conn))
                {
                    // Add parameters to the command
                    foreach (var p in parameters)
                    {
                        cmd.Parameters.AddWithValue(p.Key, p.Value);
                    }

                    conn.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int rowIndex = dgvOrders.Rows.Add();
                            DataGridViewRow row = dgvOrders.Rows[rowIndex];

                            row.Tag = reader["OrderID"]; // Store the ID for later use
                            row.Cells["colOF"].Value = reader["OrderNumber"];
                            row.Cells["colLot"].Value = reader["LotNumber"];
                            row.Cells["colResponsable"].Value = reader["Responsable"];

                            // Safely handle dates and times
                            DateTime startDate = (DateTime)reader["StartDate"];
                            row.Cells["colDateDebut"].Value = startDate.ToShortDateString();
                            row.Cells["colHeureDebut"].Value = startDate.ToShortTimeString();

                            if (reader["EndDate"] != DBNull.Value)
                            {
                                DateTime endDate = (DateTime)reader["EndDate"];
                                row.Cells["colDateFinGrid"].Value = endDate.ToShortDateString();
                                row.Cells["colHeureFin"].Value = endDate.ToShortTimeString();
                            }
                            else
                            {
                                row.Cells["colDateFinGrid"].Value = "N/A";
                                row.Cells["colHeureFin"].Value = "N/A";
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading manufacturing orders: " + ex.Message);
            }
        }
        private void btnNouveau_Click(object sender, EventArgs e)
        {
            using (FicheOrdreFabrication editorForm = new FicheOrdreFabrication())
            {
                if (editorForm.ShowDialog(this) == DialogResult.OK)
                {
                    LoadData();
                }
            }
        }

        // The Filter button applies the selected filters
        private void btnFiltrer_Click(object sender, EventArgs e)
        {
            LoadData(dtpDateDebut.Value, dtpDateFin.Value, cmbMachine.Text, cmbResponsable.Text);
        }

        // The "Show All" button, if you add one, would do this:
        // private void btnAfficherTous_Click(object sender, EventArgs e)
        // {
        //     LoadData();
        // }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (dgvOrders.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an order to modify.");
                return;
            }
            int idToEdit = (int)dgvOrders.SelectedRows[0].Tag;
            using (FicheOrdreFabrication editorForm = new FicheOrdreFabrication(idToEdit))
            {
                if (editorForm.ShowDialog(this) == DialogResult.OK)
                {
                    LoadData(); // Refresh the grid after editing
                }
            }
        }

        // The "Consulter" (View) button can do the same as Modify
        private void btnConsulter_Click(object sender, EventArgs e)
        {
            btnModifier_Click(sender, e);
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (dgvOrders.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an order to delete.");
                return;
            }
            if (MessageBox.Show("Are you sure?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                int idToDelete = (int)dgvOrders.SelectedRows[0].Tag;
                string query = "UPDATE OrdresFabrication SET IsActive = 0 WHERE OrderID = @ID";
                try
                {
                    using (var conn = new SqlConnection(connectionString))
                    using (var cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ID", idToDelete);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        LoadData(); // Refresh grid
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting order: " + ex.Message);
                }
            }
        }

        private void btnImprimer_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Print functionality for manufacturing orders will be implemented here.");
        }

        // Make sure to link all your buttons in the constructor
     
    }
}