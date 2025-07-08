using System;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace TAPTAGPOS
{
    public partial class FicheImpression : Form
    {
        // Public properties to get the data back
        public string ServiceName { get; private set; }
        public string PrinterName { get; private set; }

        public FicheImpression()
        {
            InitializeComponent();
            this.Load += FicheImpression_Load;
            this.btnOK.Click += btnOK_Click;
            this.btnAnnuler.Click += btnAnnuler_Click;
        }

        // Constructor for editing an existing assignment
        public FicheImpression(string service, string currentPrinter) : this()
        {
            this.Text = "Modifier Imprimante";
            txtService.Text = service;
            txtService.ReadOnly = true; // Service name cannot be changed
            cmbImprimantes.Text = currentPrinter;
        }

        private void FicheImpression_Load(object sender, EventArgs e)
        {
            LoadInstalledPrinters();
            // If we are editing, try to select the current printer
            if (!string.IsNullOrEmpty(this.PrinterName))
            {
                cmbImprimantes.Text = this.PrinterName;
            }
        }

        private void LoadInstalledPrinters()
        {
            try
            {
                foreach (string printer in PrinterSettings.InstalledPrinters)
                {
                    cmbImprimantes.Items.Add(printer);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not load printers: " + ex.Message);
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtService.Text) || cmbImprimantes.SelectedItem == null)
            {
                MessageBox.Show("Veuillez remplir tous les champs.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this.ServiceName = txtService.Text;
            this.PrinterName = cmbImprimantes.Text;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}