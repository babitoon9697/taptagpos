using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TAPTAGPOS
{
    public partial class FicheBanque : Form
    {
        private bool isEditMode = false;
        private int banqueId = 0;
        private string connectionString = DatabaseConnection.GetConnectionString();

        public FicheBanque()
        {
            InitializeComponent();
            this.Text = "Nouvelle Banque";
        }

        public FicheBanque(int idToEdit) : this()
        {
            this.isEditMode = true;
            this.banqueId = idToEdit;
            this.Text = "Modifier Banque";
            LoadDataForEdit();
        }

        private void LoadDataForEdit()
        {
            string query = "SELECT NomBanque, NumCompte FROM Banques WHERE BanqueID = @ID";
            try
            {
                using (var conn = new SqlConnection(connectionString))
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ID", this.banqueId);
                    conn.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtBanque.Text = reader["NomBanque"]?.ToString();
                            txtNumCompte.Text = reader["NumCompte"]?.ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading bank data: " + ex.Message);
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBanque.Text))
            {
                MessageBox.Show("Le nom de la banque est obligatoire.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = isEditMode
                ? "UPDATE Banques SET NomBanque=@Nom, NumCompte=@NumCompte WHERE BanqueID=@ID"
                : "INSERT INTO Banques (NomBanque, NumCompte) VALUES (@Nom, @NumCompte)";

            try
            {
                using (var conn = new SqlConnection(connectionString))
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Nom", txtBanque.Text);
                    cmd.Parameters.AddWithValue("@NumCompte", txtNumCompte.Text);
                    if (isEditMode)
                    {
                        cmd.Parameters.AddWithValue("@ID", this.banqueId);
                    }
                    conn.Open();
                    cmd.ExecuteNonQuery();

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving bank data: " + ex.Message);
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}