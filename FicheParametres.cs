using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Windows.Forms;

namespace TAPTAGPOS
{
    public partial class FicheParametres : Form
    {
        private string connectionString = DatabaseConnection.GetConnectionString();
        // A dictionary to hold settings for easy access
        private Dictionary<string, string> settings = new Dictionary<string, string>();

        public FicheParametres()
        {
            InitializeComponent();
            this.Load += FicheParametres_Load;
            this.btnOK.Click += btnOK_Click;
            this.btnAnnuler.Click += btnAnnuler_Click;
            this.btnSelectLogo.Click += btnSelectLogo_Click;
            this.btnClearLogo.Click += btnClearLogo_Click;
        }

        private void FicheParametres_Load(object sender, EventArgs e)
        {
            LoadInstalledPrinters();
            LoadTarifsIntoDropdown();
            LoadAllSettings();
        }

        #region Data Loading and Saving

        // --- THIS IS THE MISSING METHOD ---
        private void LoadInstalledPrinters()
        {
            try
            {
                // Add "None" as the first option
                string defaultOption = "Aucune";
                cmbPrinterBarcode.Items.Add(defaultOption);
                cmbPrinterA4A5.Items.Add(defaultOption);
                cmbPrinterTicket.Items.Add(defaultOption);

                // Load all installed printers on the computer
                foreach (string printer in PrinterSettings.InstalledPrinters)
                {
                    cmbPrinterBarcode.Items.Add(printer);
                    cmbPrinterA4A5.Items.Add(printer);
                    cmbPrinterTicket.Items.Add(printer);
                }

                // Set the default selection to "None"
                cmbPrinterBarcode.Text = defaultOption;
                cmbPrinterA4A5.Text = defaultOption;
                cmbPrinterTicket.Text = defaultOption;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not load installed printers. " + ex.Message, "Printer Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void LoadAllSettings()
        {
            // 1. Fetch all settings from the database
            try
            {
                using (var conn = new SqlConnection(connectionString))
                using (var cmd = new SqlCommand("SELECT SettingKey, SettingValue FROM AppSettings", conn))
                {
                    conn.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            settings[reader["SettingKey"].ToString()] = reader["SettingValue"]?.ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading settings: " + ex.Message);
                return;
            }

            // 2. Populate form controls with the loaded settings
            PopulateControls();
        }

        private void PopulateControls()
        {
            // دالة مساعدة صغيرة لجلب الإعدادات بأمان وتجنب الأخطاء
            Func<string, string> GetSetting = (key) => settings.ContainsKey(key) ? settings[key] : "";

            // --- Tab: Etablissement ---
            rtfEnTetePage.Text = GetSetting("EnTetePage");
            rtfBasDePage.Text = GetSetting("BasDePage");
            chkDifferentTicket.Checked = GetSetting("DifferentTicket").ToLower() == "true";

            // Printers
            cmbPrinterBarcode.Text = GetSetting("PrinterBarcode");
            cmbPrinterA4A5.Text = GetSetting("PrinterA4A5");
            cmbPrinterTicket.Text = GetSetting("PrinterTicket");

            // Logo
            string logoPath = GetSetting("LogoPath");
            if (!string.IsNullOrEmpty(logoPath) && File.Exists(logoPath))
            {
                pictureBoxLogo.ImageLocation = logoPath;
            }

            // Series GroupBox
            numSerieBL.Value = decimal.TryParse(GetSetting("SerieBL"), out decimal bl) ? bl : 0;
            numSerieAvoirClient.Value = decimal.TryParse(GetSetting("SerieAvoirClient"), out decimal ac) ? ac : 0;
            numSerieBonCmd.Value = decimal.TryParse(GetSetting("SerieBonCmd"), out decimal bc) ? bc : 0;
            numSerieFacture.Value = decimal.TryParse(GetSetting("SerieFacture"), out decimal fact) ? fact : 0;
            numSerieAvoirFour.Value = decimal.TryParse(GetSetting("SerieAvoirFour"), out decimal af) ? af : 0;
            numSerieBC.Value = decimal.TryParse(GetSetting("SerieBC"), out decimal sbc) ? sbc : 0;
            numSerieAchat.Value = decimal.TryParse(GetSetting("SerieAchat"), out decimal achat) ? achat : 0;
            numSerieDevis.Value = decimal.TryParse(GetSetting("SerieDevis"), out decimal devis) ? devis : 0;

            // --- Tab: POS -> Ticket de caisse ---
            rtfEnTeteTicket.Text = GetSetting("EnTeteTicket");
            rtfBasTicket.Text = GetSetting("BasTicket");

            // --- Tab: POS -> Autre ---
            chkStockNegatif.Checked = GetSetting("StockNegatif").ToLower() == "true";
            chkCacherCredit.Checked = GetSetting("CacherCredit").ToLower() == "true";
            textBoxTarif.Text = GetSetting("DefaultTarif");

            // --- Tab: POS -> Balance ---
            numBalance1Code.Value = decimal.TryParse(GetSetting("Balance1Code"), out decimal b1c) ? b1c : 0;
            numBalance1Val.Value = decimal.TryParse(GetSetting("Balance1Val"), out decimal b1v) ? b1v : 0;
            numBalance2Code.Value = decimal.TryParse(GetSetting("Balance2Code"), out decimal b2c) ? b2c : 0;
            numBalance2Val.Value = decimal.TryParse(GetSetting("Balance2Val"), out decimal b2v) ? b2v : 0;
            numBalance3Code.Value = decimal.TryParse(GetSetting("Balance3Code"), out decimal b3c) ? b3c : 0;
            numBalance3Val.Value = decimal.TryParse(GetSetting("Balance3Val"), out decimal b3v) ? b3v : 0;
            numBalance4Code.Value = decimal.TryParse(GetSetting("Balance4Code"), out decimal b4c) ? b4c : 0;
            numBalance4Val.Value = decimal.TryParse(GetSetting("Balance4Val"), out decimal b4v) ? b4v : 0;
            numBalance5Code.Value = decimal.TryParse(GetSetting("Balance5Code"), out decimal b5c) ? b5c : 0;
            numBalance5Val.Value = decimal.TryParse(GetSetting("Balance5Val"), out decimal b5v) ? b5v : 0;
        }
        private void LoadTarifsIntoDropdown()
        {
            try
            {
                // افترضت أن اسم الكومبو بوكس هو dropdown_Tarifs
                dropdown_Tarifs.Items.Clear();
                string query = "SELECT TarifID , TarifName FROM Tarifs ORDER BY TarifID";

                using (var conn = new SqlConnection(connectionString))
                using (var cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            dropdown_Tarifs.Items.Add(reader["TarifName"].ToString());
                            dropdown_Tarifs.ValueMember = reader["TarifID"].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ في تحميل قائمة التسعيرات: " + ex.Message);
            }
        }
        private void SaveAllSettings()
        {
            // Collect all settings from controls into the dictionary
            settings["EnTetePage"] = rtfEnTetePage.Text;
            settings["BasDePage"] = rtfBasDePage.Text;
            settings["DifferentTicket"] = chkDifferentTicket.Checked.ToString().ToLower();
            settings["PrinterBarcode"] = cmbPrinterBarcode.Text;
            settings["PrinterA4A5"] = cmbPrinterA4A5.Text;
            settings["PrinterTicket"] = cmbPrinterTicket.Text;
            settings["SerieBL"] = numSerieBL.Value.ToString();
            settings["SerieFacture"] = numSerieFacture.Value.ToString();
            // --- Series ---
            settings["SerieAvoirClient"] = numSerieAvoirClient.Value.ToString();
            settings["SerieBonCmd"] = numSerieBonCmd.Value.ToString();
            settings["SerieAvoirFour"] = numSerieAvoirFour.Value.ToString();
            settings["SerieBC"] = numSerieBC.Value.ToString();
            settings["SerieAchat"] = numSerieAchat.Value.ToString();
            settings["SerieDevis"] = numSerieDevis.Value.ToString();

            // --- POS Tab -> Ticket de caisse ---
            settings["EnTeteTicket"] = rtfEnTeteTicket.Text;
            settings["BasTicket"] = rtfBasTicket.Text;

            // --- POS Tab -> Autre ---
            settings["StockNegatif"] = chkStockNegatif.Checked.ToString().ToLower();
            settings["CacherCredit"] = chkCacherCredit.Checked.ToString().ToLower();
            settings["DefaultTarif"] = dropdown_Tarifs.Text;

            // --- POS Tab -> Balance ---
            settings["Balance1Code"] = numBalance1Code.Value.ToString();
            settings["Balance1Val"] = numBalance1Val.Value.ToString();
            settings["Balance2Code"] = numBalance2Code.Value.ToString();
            settings["Balance2Val"] = numBalance2Val.Value.ToString();
            settings["Balance3Code"] = numBalance3Code.Value.ToString();
            settings["Balance3Val"] = numBalance3Val.Value.ToString();
            settings["Balance4Code"] = numBalance4Code.Value.ToString();
            settings["Balance4Val"] = numBalance4Val.Value.ToString();
            settings["Balance5Code"] = numBalance5Code.Value.ToString();
            settings["Balance5Val"] = numBalance5Val.Value.ToString(); settings["LogoPath"] = pictureBoxLogo.ImageLocation;

            // Use a transaction to save all settings
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                var transaction = conn.BeginTransaction();
                try
                {
                    // Use MERGE to INSERT a new setting or UPDATE an existing one
                    string query = @"
                        MERGE AppSettings AS target
                        USING (SELECT @Key AS SettingKey, @Value AS SettingValue) AS source
                        ON (target.SettingKey = source.SettingKey)
                        WHEN MATCHED THEN
                            UPDATE SET SettingValue = source.SettingValue
                        WHEN NOT MATCHED THEN
                            INSERT (SettingKey, SettingValue) VALUES (source.SettingKey, source.SettingValue);";

                    foreach (var setting in settings)
                    {
                        using (var cmd = new SqlCommand(query, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@Key", setting.Key);
                            cmd.Parameters.AddWithValue("@Value", setting.Value ?? "");
                            cmd.ExecuteNonQuery();
                        }
                    }
                    transaction.Commit();
                    MessageBox.Show("Settings saved successfully!");
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Error saving settings: " + ex.Message);
                }
            }
        }

        #endregion

        #region Button Click Events

        private void btnOK_Click(object sender, EventArgs e)
        {
            SaveAllSettings();
            this.DialogResult = DialogResult.OK;
            AppSettingsManager.LoadSettings();
            this.Close();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSelectLogo_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pictureBoxLogo.ImageLocation = ofd.FileName;
                }
            }
        }

        private void btnClearLogo_Click(object sender, EventArgs e)
        {
            pictureBoxLogo.ImageLocation = null;
            pictureBoxLogo.Image = null;
        }

        #endregion

      
    }
}