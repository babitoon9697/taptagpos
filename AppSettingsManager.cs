using System.Collections.Generic;
using System.Data.SqlClient;

namespace TAPTAGPOS
{
    public static class AppSettingsManager
    {
        private static Dictionary<string, string> _settings = new Dictionary<string, string>();

        // --- خصائص عامة للوصول إلى الإعدادات من أي مكان ---
        // In AppSettingsManager.cs
        public static int DefaultSaleWarehouseId = GetSettingAsInt("DefaultSaleWarehouseId", 1); // Default to 1 if not set
        public static bool AllowNegativeStock => GetSettingAsBool("StockNegatif");
        public static bool HideCreditOnTicket => GetSettingAsBool("CacherCredit");
        public static string DefaultTarif => GetSetting("DefaultTarif", "Détail");
        public static string PrinterTicket => GetSetting("PrinterTicket");
        public static string HeaderReceipt => GetSetting("EnTeteTicket");
        public static string FooterReceipt => GetSetting("BasTicket");
        public static int SerieFacture => GetSettingAsInt("SerieFacture", 1);
        public static int SerieAchat => GetSettingAsInt("SerieAchat", 1);
        public static int SerieBonCmd => GetSettingAsInt("SerieBonCmd", 1);
        public static int SerieDevis => GetSettingAsInt("SerieDevis", 1);
        public static int SerieProforma => GetSettingAsInt("SerieProforma", 1);
        public static int SerieBL => GetSettingAsInt("SerieBL", 1);
        public static int SerieBordereau => GetSettingAsInt("SerieBordereau", 1);
        // Company Info
        public static string CompanyName => GetSetting("EnTeteTicket"); // Using EnTeteTicket as company name
        public static string CompanyAddress => GetSetting("CompanyAddress"); // Requires a setting with this key
        public static string CompanyPhone => GetSetting("CompanyPhone");   // Requires a setting with this key
        public static string VatNumber => GetSetting("VatNumber");       // Requires a setting with this key
        public static string LogoPath => GetSetting("LogoPath");
        // In AppSettingsManager.cs
        // Report Texts
        public static string HeaderPage => GetSetting("EnTetePage");
        public static string FooterPage => GetSetting("BasDePage");

        // Printers
        public static string PrinterA4A5 => GetSetting("PrinterA4A5");
        public static string PrinterBarcode => GetSetting("PrinterBarcode");
        private static int GetSettingAsInt(string key, int defaultValue = 0)
        {
            if (_settings.ContainsKey(key) && int.TryParse(_settings[key], out int result))
            {
                return result;
            }
            return defaultValue;
        }
        public static void LoadSettings()
        {
            _settings.Clear();
            string connectionString = DatabaseConnection.GetConnectionString();
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
                            _settings[reader["SettingKey"].ToString()] = reader["SettingValue"]?.ToString();
                        }
                    }
                }
            }
            catch (System.Exception ex)
            {
                // التعامل مع الخطأ إذا لم يتم العثور على الجدول أو حدث خطأ آخر
                System.Windows.Forms.MessageBox.Show("Failed to load application settings: " + ex.Message);
            }
        }

        // --- دوال مساعدة لجلب القيم بشكل آمن ---
        private static string GetSetting(string key, string defaultValue = "")
        {
            return _settings.ContainsKey(key) ? _settings[key] : defaultValue;
        }

        private static bool GetSettingAsBool(string key, bool defaultValue = false)
        {
            if (_settings.ContainsKey(key) && bool.TryParse(_settings[key], out bool result))
            {
                return result;
            }
            return defaultValue;
        }
    }
}