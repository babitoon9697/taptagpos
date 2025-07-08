using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TAPTAGPOS
{
    public partial class FicheCommercial : Form
    {
        private bool isEditMode = false;
        private int commercialId = 0;
        private string connectionString = DatabaseConnection.GetConnectionString();

        // Constructor for adding a new salesperson
        public FicheCommercial()
        {
            InitializeComponent();
            this.Text = "Nouveau Commercial";
        }

        // Constructor for editing an existing salesperson
        public FicheCommercial(int idToEdit) : this()
        {
            this.isEditMode = true;
            this.commercialId = idToEdit;
            this.Text = "Modifier Commercial";
            LoadDataForEdit();
        }

        private void LoadDataForEdit()
        {
            string query = "SELECT * FROM Commerciaux WHERE CommercialID = @ID";
            try
            {
                using (var conn = new SqlConnection(connectionString))
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ID", this.commercialId);
                    conn.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtNom.Text = reader["Nom"]?.ToString();
                            txtAdresse.Text = reader["Adresse"]?.ToString();
                            txtTelephone.Text = reader["Telephone"]?.ToString();
                            txtEmail.Text = reader["Email"]?.ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNom.Text))
            {
                MessageBox.Show("Le nom est obligatoire.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = isEditMode
                ? "UPDATE Commerciaux SET Nom=@Nom, Adresse=@Adresse, Telephone=@Telephone, Email=@Email WHERE CommercialID=@ID"
                : "INSERT INTO Commerciaux (Nom, Adresse, Telephone, Email) VALUES (@Nom, @Adresse, @Telephone, @Email)";

            try
            {
                using (var conn = new SqlConnection(connectionString))
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Nom", txtNom.Text);
                    cmd.Parameters.AddWithValue("@Adresse", txtAdresse.Text);
                    cmd.Parameters.AddWithValue("@Telephone", txtTelephone.Text);
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                    if (isEditMode)
                    {
                        cmd.Parameters.AddWithValue("@ID", this.commercialId);
                    }
                    conn.Open();
                    cmd.ExecuteNonQuery();

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving data: " + ex.Message);
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}