using System;
using System.Configuration;
using System.Windows.Forms;

namespace TAPTAGPOS
{
    public partial class TableImpression : Form
    {
        public TableImpression()
        {
            InitializeComponent();
            this.Load += TableImpression_Load;
            this.btnModifier.Click += btnModifier_Click;
        }

        private void TableImpression_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            dgvImpression.Rows.Clear();

            // The "Services" are predefined parts of your application
            AddRowToGrid("Ticket de Caisse", GetPrinterForService("PrinterTicket"));
            AddRowToGrid("Facture A4/A5", GetPrinterForService("PrinterA4A5"));
            AddRowToGrid("Etiquette Code Barre", GetPrinterForService("PrinterBarcode"));
        }

        private void AddRowToGrid(string service, string printer)
        {
            int rowIndex = dgvImpression.Rows.Add();
            DataGridViewRow row = dgvImpression.Rows[rowIndex];
            row.Cells["colService"].Value = service;
            row.Cells["colImprimante"].Value = printer;
        }

        private string GetPrinterForService(string settingKey)
        {
            return ConfigurationManager.AppSettings[settingKey] ?? "Non défini";
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (dgvImpression.SelectedRows.Count == 0) return;

            string serviceToEdit = dgvImpression.SelectedRows[0].Cells["colService"].Value.ToString();
            string currentPrinter = dgvImpression.SelectedRows[0].Cells["colImprimante"].Value.ToString();

            using (FicheImpression editorForm = new FicheImpression(serviceToEdit, currentPrinter))
            {
                if (editorForm.ShowDialog(this) == DialogResult.OK)
                {
                    string settingKey = GetKeyForService(editorForm.ServiceName);
                    if (!string.IsNullOrEmpty(settingKey))
                    {
                        SaveSetting(settingKey, editorForm.PrinterName);
                        LoadData(); // Refresh the grid to show the change
                    }
                }
            }
        }

        private string GetKeyForService(string serviceName)
        {
            switch (serviceName)
            {
                case "Ticket de Caisse": return "PrinterTicket";
                case "Facture A4/A5": return "PrinterA4A5";
                case "Etiquette Code Barre": return "PrinterBarcode";
                default: return null;
            }
        }

        private void SaveSetting(string key, string value)
        {
            try
            {
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                if (config.AppSettings.Settings[key] != null)
                    config.AppSettings.Settings[key].Value = value;
                else
                    config.AppSettings.Settings.Add(key, value);

                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving setting: " + ex.Message);
            }
        }
    }
}