using System;
using System.Windows.Forms;

namespace TAPTAGPOS
{
    public partial class PopupCodeBarre : Form
    {
        // Public property to return the barcode
        public string EnteredBarcode { get; private set; }

        public PopupCodeBarre()
        {
            InitializeComponent();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtBarcode.Text))
            {
                this.EnteredBarcode = txtBarcode.Text.Trim();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Please enter a barcode.", "Input Required");
            }
        }
    }
}