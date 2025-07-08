using System;
using System.Windows.Forms;

namespace TAPTAGPOS
{
    public partial class FicheZone : Form
    {
        // Public property to return the final name to the main form
        public string ZoneName { get; private set; }

        // Constructor for a NEW zone
        public FicheZone()
        {
            InitializeComponent();
            lblTitle.Text = "Nouvelle Zone";
        }

        // Constructor for EDITING a zone
        public FicheZone(string currentName) : this()
        {
            lblTitle.Text = "Modifier Zone";
            txtZoneName.Text = currentName; // Pre-fill the textbox with the current name
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtZoneName.Text))
            {
                MessageBox.Show("Le nom de la zone est obligatoire.", "Validation", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }
            else
            {
                this.ZoneName = txtZoneName.Text;
                this.DialogResult = DialogResult.OK; // Confirm the dialog result
                this.Close();
            }
              
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnValider_Click_1(object sender, EventArgs e)
        {

        }
    }
}