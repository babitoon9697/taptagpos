using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TAPTAGPOS
{
    public partial class TableEchantillons : Form
    {
        private string connectionString = DatabaseConnection.GetConnectionString();

        public TableEchantillons()
        {
            InitializeComponent();
            // Link events in the constructor
            this.Load += TableEchantillons_Load;
            this.dgvEchantillons.CellValueChanged += dgvEchantillons_CellValueChanged;
            this.dgvEchantillons.CurrentCellDirtyStateChanged += dgvEchantillons_CurrentCellDirtyStateChanged;
        }

        private void TableEchantillons_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            // Detach the event handler while loading to prevent it from firing
            this.dgvEchantillons.CellValueChanged -= dgvEchantillons_CellValueChanged;

            dgvEchantillons.Rows.Clear();
            // This query gets all articles and their sample status
            string query = "SELECT Id, Article, ArticleLongName, ISNULL(IsSample, 0) as IsSample FROM Articles ORDER BY Article";

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
                            int rowIndex = dgvEchantillons.Rows.Add();
                            DataGridViewRow row = dgvEchantillons.Rows[rowIndex];

                            // Store the Article ID in the Tag property for easy access
                            row.Tag = reader["Id"];

                            row.Cells["colReference"].Value = reader["Article"];
                            row.Cells["colDesignation"].Value = reader["ArticleLongName"];
                            row.Cells["colEchantillon"].Value = Convert.ToBoolean(reader["IsSample"]);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading articles: " + ex.Message);
            }
            finally
            {
                // Re-attach the event handler after loading is complete
                this.dgvEchantillons.CellValueChanged += dgvEchantillons_CellValueChanged;
            }
        }

        // This makes the checkbox click reflect immediately
        private void dgvEchantillons_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvEchantillons.IsCurrentCellDirty)
            {
                dgvEchantillons.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        // This event fires right after the user clicks a checkbox
        private void dgvEchantillons_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure the change was in the checkbox column and it's a valid row
            if (e.RowIndex < 0 || e.ColumnIndex != dgvEchantillons.Columns["colEchantillon"].Index)
            {
                return;
            }

            // Get the ID and the new checkbox value
            int articleId = (int)dgvEchantillons.Rows[e.RowIndex].Tag;
            bool isSample = (bool)dgvEchantillons.Rows[e.RowIndex].Cells["colEchantillon"].Value;

            // Save the change to the database immediately
            string query = "UPDATE Articles SET IsSample = @IsSample WHERE Id = @ArticleID";
            try
            {
                using (var conn = new SqlConnection(connectionString))
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@IsSample", isSample);
                    cmd.Parameters.AddWithValue("@ArticleID", articleId);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to update sample status: " + ex.Message);
                // Optionally, revert the checkbox state if the save fails
                dgvEchantillons.Rows[e.RowIndex].Cells["colEchantillon"].Value = !isSample;
            }
        }
    }
}