using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace TAPTAGPOS
{
    public partial class FichePda : Form
    {
        private bool isEditMode = false;
        private int pdaId = 0;
        private string connectionString = DatabaseConnection.GetConnectionString();

        public FichePda()
        {
            InitializeComponent();
            this.Text = "Nouveau PDA";
            this.Load += FichePda_Load;
        }

        public FichePda(int idToEdit) : this()
        {
            this.isEditMode = true;
            this.pdaId = idToEdit;
            this.Text = "Modifier PDA";
        }

        private void FichePda_Load(object sender, EventArgs e)
        {
            LoadVendeurs();
            if (isEditMode)
            {
                LoadDataForEdit();
            }
        }

        private void LoadVendeurs()
        {
            try
            {
                var dt = new DataTable();
                dt.Columns.Add("CommercialID", typeof(int));
                dt.Columns.Add("Nom", typeof(string));
                dt.Rows.Add(-1, "Aucun"); // No salesperson option

                using (var conn = new SqlConnection(connectionString))
                using (var adapter = new SqlDataAdapter("SELECT CommercialID, Nom FROM Commerciaux WHERE IsActive=1", conn))
                {
                    adapter.Fill(dt);
                }
                cmbVendeur.DataSource = dt;
                cmbVendeur.DisplayMember = "Nom";
                cmbVendeur.ValueMember = "CommercialID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading salespeople: " + ex.Message);
            }
        }

        private void LoadDataForEdit()
        {
            string query = "SELECT NomPda, CommercialID, Couleur, Commission FROM PDAs WHERE PdaID = @ID";
            try
            {
                using (var conn = new SqlConnection(connectionString))
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ID", this.pdaId);
                    conn.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Fill the form controls with data from the database
                            txtNomPda.Text = reader["NomPda"]?.ToString();

                            // Set the color and its text representation
                            string colorHex = reader["Couleur"]?.ToString();
                            if (!string.IsNullOrEmpty(colorHex))
                            {
                                try
                                {
                                    txtCouleur.Text = colorHex;
                                    txtCouleur.BackColor = ColorTranslator.FromHtml(colorHex);
                                }
                                catch
                                {
                                    // In case of an invalid color code in DB, do nothing
                                    txtCouleur.BackColor = SystemColors.Control;
                                }
                            }

                            // Safely select the salesperson in the ComboBox
                            if (reader["CommercialID"] != DBNull.Value)
                            {
                                cmbVendeur.SelectedValue = reader["CommercialID"];
                            }
                            else
                            {
                                cmbVendeur.SelectedValue = -1; // Select "Aucun"
                            }

                            // Set the commission value
                            numCommission.Value = reader["Commission"] != DBNull.Value ? Convert.ToDecimal(reader["Commission"]) : 0;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading PDA data for editing: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close(); // Close the form if data cannot be loaded
            }
        }

        private void btnSelectCouleur_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    txtCouleur.BackColor = colorDialog.Color;
                    txtCouleur.Text = ColorTranslator.ToHtml(colorDialog.Color);
                }
            }
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            // Validation and Save logic for Add/Edit
        }
    }
}