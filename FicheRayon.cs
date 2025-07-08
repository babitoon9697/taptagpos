using System;
using System.Windows.Forms;

namespace TAPTAGPOS
{
    public partial class FicheRayon : Form
    {
        // Public property to return the entered name
        public string RayonName { get; private set; }

        public FicheRayon()
        {
            InitializeComponent();
            this.Text = "Nouveau Rayon";
        }

        // Constructor for editing, pre-fills the name
        public FicheRayon(string currentName) : this()
        {
            this.Text = "Modifier Rayon";
            txtRayonName.Text = currentName;
            this.RayonName = currentName;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRayonName.Text))
            {
                MessageBox.Show("Le nom du rayon est obligatoire.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this.RayonName = txtRayonName.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}