using System;
using System.Windows.Forms;

namespace TAPTAGPOS
{
    public partial class FicheResponsable : Form
    {
        // Public property to return the entered name
        public string NomComplet { get; private set; }

        public FicheResponsable()
        {
            InitializeComponent();
            this.Text = "Nouveau Responsable";
        }

        public FicheResponsable(string currentName) : this()
        {
            this.Text = "Modifier Responsable";
            txtNomComplet.Text = currentName;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNomComplet.Text))
            {
                MessageBox.Show("Le nom du responsable est obligatoire.", "Validation");
                return;
            }
            this.NomComplet = txtNomComplet.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}