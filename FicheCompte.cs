using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TAPTAGPOS
{
    public partial class FicheCompte : Form
    {
        private bool isEditMode = false;
        private int mouvementId = 0;
        private string connectionString = DatabaseConnection.GetConnectionString();

        public FicheCompte()
        {
            InitializeComponent();
            this.Load += FicheCompte_Load;
            this.btnOK.Click += btnOK_Click;
        }

        public FicheCompte(int idToEdit) : this()
        {
            this.isEditMode = true;
            this.mouvementId = idToEdit;
            this.Text = "Modifier Mouvement";
        }

        private void FicheCompte_Load(object sender, EventArgs e)
        {
            LoadComptes();
            if (isEditMode)
            {
                LoadDataForEdit();
            }
        }

        private void LoadComptes()
        {
            try
            {
                var dt = new DataTable();
                using (var conn = new SqlConnection(connectionString))
                using (var adapter = new SqlDataAdapter("SELECT BanqueID, NomBanque FROM Banques WHERE IsActive=1", conn))
                {
                    adapter.Fill(dt);
                }
                cmbCompte.DataSource = dt;
                cmbCompte.DisplayMember = "NomBanque";
                cmbCompte.ValueMember = "BanqueID";
            }
            catch (Exception ex) { MessageBox.Show("Error loading bank accounts: " + ex.Message); }
        }

        private void LoadDataForEdit()
        {
            string query = "SELECT * FROM MouvementsBancaires WHERE MouvementID = @ID";
            try
            {
                using (var conn = new SqlConnection(connectionString))
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ID", this.mouvementId);
                    conn.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Select the correct bank account in the ComboBox
                            cmbCompte.SelectedValue = reader["BanqueID"];

                            dtpDate.Value = (DateTime)reader["MouvementDate"];
                            txtLibelle.Text = reader["Libelle"]?.ToString();
                            txtPJ.Text = reader["NumeroPiece"]?.ToString();
                            numCredit.Value = Convert.ToDecimal(reader["Credit"]);
                            numDebit.Value = Convert.ToDecimal(reader["Debit"]);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading transaction data for editing: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close(); // Close if data cannot be loaded
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            // --- Validation ---
            if (cmbCompte.SelectedValue == null || (int)cmbCompte.SelectedValue <= 0)
            {
                MessageBox.Show("Veuillez sélectionner un compte bancaire.", "Validation");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtLibelle.Text))
            {
                MessageBox.Show("Le libellé est obligatoire.", "Validation");
                return;
            }
            if (numCredit.Value == 0 && numDebit.Value == 0)
            {
                MessageBox.Show("Veuillez saisir un montant de crédit ou de débit.", "Validation");
                return;
            }
            if (numCredit.Value > 0 && numDebit.Value > 0)
            {
                MessageBox.Show("Vous ne pouvez pas saisir un crédit et un débit en même temps.", "Validation");
                return;
            }

            // --- Save Logic ---
            string query = isEditMode
                ? "UPDATE MouvementsBancaires SET BanqueID=@BID, MouvementDate=@Date, Libelle=@Libelle, NumeroPiece=@PJ, Credit=@Credit, Debit=@Debit WHERE MouvementID=@ID"
                : "INSERT INTO MouvementsBancaires (BanqueID, MouvementDate, Libelle, NumeroPiece, Credit, Debit) VALUES (@BID, @Date, @Libelle, @PJ, @Credit, @Debit)";

            try
            {
                using (var conn = new SqlConnection(connectionString))
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@BID", cmbCompte.SelectedValue);
                    cmd.Parameters.AddWithValue("@Date", dtpDate.Value);
                    cmd.Parameters.AddWithValue("@Libelle", txtLibelle.Text);
                    cmd.Parameters.AddWithValue("@PJ", (object)txtPJ.Text ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Credit", numCredit.Value);
                    cmd.Parameters.AddWithValue("@Debit", numDebit.Value);

                    if (isEditMode)
                    {
                        cmd.Parameters.AddWithValue("@ID", this.mouvementId);
                    }

                    conn.Open();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show(isEditMode ? "Mouvement mis à jour avec succès!" : "Mouvement ajouté avec succès!", "Succès");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving transaction: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}