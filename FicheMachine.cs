using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TAPTAGPOS
{
    public partial class FicheMachine : Form
    {
        private bool isEditMode = false;
        private int machineId = 0;
        private string connectionString = DatabaseConnection.GetConnectionString();

        public FicheMachine()
        {
            InitializeComponent();
            this.Text = "Nouvelle Machine";
        }

        public FicheMachine(int idToEdit) : this()
        {
            this.isEditMode = true;
            this.machineId = idToEdit;
            this.Text = "Modifier Machine";
            LoadDataForEdit();
        }

        private void LoadDataForEdit()
        {
            string query = "SELECT * FROM Machines WHERE MachineID = @ID";
            try
            {
                using (var conn = new SqlConnection(connectionString))
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ID", this.machineId);
                    conn.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtMachine.Text = reader["MachineName"]?.ToString();
                            txtMarque.Text = reader["Marque"]?.ToString();
                            txtCapacite.Text = reader["Capacite"]?.ToString();
                            if (reader["DateAcquisition"] != DBNull.Value)
                            {
                                dtpDateAcquisition.Value = (DateTime)reader["DateAcquisition"];
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading machine data: " + ex.Message);
            }
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMachine.Text))
            {
                MessageBox.Show("Le nom de la machine est obligatoire.", "Validation");
                return;
            }

            string query = isEditMode
                ? "UPDATE Machines SET MachineName=@Name, Marque=@Marque, DateAcquisition=@Date, Capacite=@Capacite WHERE MachineID=@ID"
                : "INSERT INTO Machines (MachineName, Marque, DateAcquisition, Capacite) VALUES (@Name, @Marque, @Date, @Capacite)";

            try
            {
                using (var conn = new SqlConnection(connectionString))
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", txtMachine.Text);
                    cmd.Parameters.AddWithValue("@Marque", txtMarque.Text);
                    cmd.Parameters.AddWithValue("@Date", dtpDateAcquisition.Value);
                    cmd.Parameters.AddWithValue("@Capacite", txtCapacite.Text);
                    if (isEditMode)
                    {
                        cmd.Parameters.AddWithValue("@ID", this.machineId);
                    }
                    conn.Open();
                    cmd.ExecuteNonQuery();

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving machine data: " + ex.Message);
            }
        }
    }
}