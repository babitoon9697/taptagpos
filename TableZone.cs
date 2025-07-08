using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TAPTAGPOS
{
    public partial class TableZone : Form
    {
        private string connectionString = DatabaseConnection.GetConnectionString();

        public TableZone()
        {
            InitializeComponent();
            // Link all events
            this.Load += (s, e) => LoadData();
            this.btnNouveau.Click += btnNouveau_Click;
            this.btnModifier.Click += btnModifier_Click;
            this.btnSupprimer.Click += btnSupprimer_Click;
            this.btnFermer.Click += (s, e) => this.Close();
            this.dgvZone.CellDoubleClick += (s, e) => btnModifier_Click(s, e);
        }

        private void LoadData()
        {
            dgvZone.Rows.Clear();
            string query = "SELECT ZoneID, ZoneName FROM Zones WHERE ISNULL(IsActive, 1) = 1 ORDER BY ZoneName";
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
                            int rowIndex = dgvZone.Rows.Add();
                            DataGridViewRow row = dgvZone.Rows[rowIndex];
                            row.Tag = reader["ZoneID"];
                            row.Cells["colZone"].Value = reader["ZoneName"];
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading zones: " + ex.Message);
            }
        }

        private void btnNouveau_Click(object sender, EventArgs e)
        {
            using (FicheZone editorForm = new FicheZone())
            {
                if (editorForm.ShowDialog(this) == DialogResult.OK)
                {
                    string newName = editorForm.ZoneName;
                    string query = "INSERT INTO Zones (ZoneName) VALUES (@Name)";
                    try
                    {
                        using (var conn = new SqlConnection(connectionString))
                        using (var cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@Name", newName);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                        }
                        LoadData(); // Refresh the grid
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("خطأ في إضافة المنطقة: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (dgvZone.SelectedRows.Count == 0) return;
            int idToEdit = (int)dgvZone.SelectedRows[0].Tag;
            string currentName = dgvZone.SelectedRows[0].Cells["colZone"].Value.ToString();

            using (FicheZone editorForm = new FicheZone(currentName))
            {
                if (editorForm.ShowDialog(this) == DialogResult.OK)
                {
                    string newName = editorForm.ZoneName;
                    string query = "UPDATE Zones SET ZoneName = @Name WHERE ZoneID = @ID";
                    try
                    {
                        using (var conn = new SqlConnection(connectionString))
                        using (var cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@Name", newName);
                            cmd.Parameters.AddWithValue("@ID", idToEdit);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                        }
                        LoadData(); // Refresh the grid
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("خطأ في تعديل المنطقة: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (dgvZone.SelectedRows.Count == 0)
            {
                MessageBox.Show("الرجاء اختيار منطقة للحذف.", "لم يتم تحديد أي شيء", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("هل أنت متأكد من أنك تريد الحذف؟", "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                int idToDelete = (int)dgvZone.SelectedRows[0].Tag;
                string query = "UPDATE Zones SET IsActive = 0 WHERE ZoneID = @ID";
                try
                {
                    using (var conn = new SqlConnection(connectionString))
                    using (var cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ID", idToDelete);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                    LoadData(); // Refresh the grid
                }
                catch (Exception ex)
                {
                    MessageBox.Show("خطأ في حذف المنطقة: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}