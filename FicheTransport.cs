using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TAPTAGPOS
{
    public partial class FicheTransport : Form
    {
        private bool isEditMode = false;
        private int transportId = 0;
        private string connectionString = DatabaseConnection.GetConnectionString();

        public FicheTransport()
        {
            InitializeComponent();
            this.btnValider.Click += btnValider_Click;
            this.btnFermer.Click += (s, e) => this.Close();
        }

        public FicheTransport(int idToEdit) : this()
        {
            this.isEditMode = true;
            this.transportId = idToEdit;
            this.Text = "Modifier Transport";
            LoadDataForEdit();
        }

        private void LoadDataForEdit()
        {
            string query = "SELECT * FROM Transports WHERE TransportID = @ID";
            try
            {
                using (var conn = new SqlConnection(connectionString))
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ID", this.transportId);
                    conn.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtCode.Text = reader["Code"]?.ToString();
                            txtRaisonSociale.Text = reader["RaisonSociale"]?.ToString();
                            txtAdresse.Text = reader["Adresse"]?.ToString();
                            txtTelephone.Text = reader["Telephone"]?.ToString();
                            txtFax.Text = reader["Fax"]?.ToString();
                            txtEmail.Text = reader["Email"]?.ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading transport data: " + ex.Message);
            }
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRaisonSociale.Text))
            {
                MessageBox.Show("La raison sociale est obligatoire.", "Validation");
                return;
            }

            string query = isEditMode
                ? "UPDATE Transports SET Code=@Code, RaisonSociale=@Raison, Adresse=@Adresse, Telephone=@Tel, Fax=@Fax, Email=@Email WHERE TransportID=@ID"
                : "INSERT INTO Transports (Code, RaisonSociale, Adresse, Telephone, Fax, Email) VALUES (@Code, @Raison, @Adresse, @Tel, @Fax, @Email)";

            try
            {
                using (var conn = new SqlConnection(connectionString))
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Code", txtCode.Text);
                    cmd.Parameters.AddWithValue("@Raison", txtRaisonSociale.Text);
                    cmd.Parameters.AddWithValue("@Adresse", txtAdresse.Text);
                    cmd.Parameters.AddWithValue("@Tel", txtTelephone.Text);
                    cmd.Parameters.AddWithValue("@Fax", txtFax.Text);
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text);

                    if (isEditMode)
                    {
                        cmd.Parameters.AddWithValue("@ID", this.transportId);
                    }

                    conn.Open();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show(isEditMode ? "Mise à jour réussie!" : "Ajouté avec succès!", "Succès");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving data: " + ex.Message);
            }
        }
    }
}