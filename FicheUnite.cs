using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TAPTAGPOS
{
    public partial class FicheUnite : Form
    {
        private bool isEditMode = false;
        private int uniteId = 0;
        private string connectionString = DatabaseConnection.GetConnectionString();

        // Public property to get the new/edited name
        public string UniteName { get; private set; }

        public FicheUnite()
        {
            InitializeComponent();
            this.Text = "Nouvelle Unité";
        }

        public FicheUnite(int idToEdit, string currentName) : this()
        {
            this.isEditMode = true;
            this.uniteId = idToEdit;
            this.Text = "Modifier Unité";
            txtUnite.Text = currentName;
            this.UniteName = currentName;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUnite.Text))
            {
                MessageBox.Show("Le nom de l'unité est obligatoire.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this.UniteName = txtUnite.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}