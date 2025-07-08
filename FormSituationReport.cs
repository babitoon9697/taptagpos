using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace TAPTAGPOS
{
    public partial class FormSituationReport : Form
    {
        private string connectionString = DatabaseConnection.GetConnectionString();

        // Constructor for when the user will pick dates
        public FormSituationReport()
        {
            InitializeComponent();
            InitializeForm();
        }

        // Constructor for when dates are passed directly (e.g., "Today's Report")
        public FormSituationReport(DateTime startDate, DateTime endDate) : this()
        {
            dtpDateDebut.Value = startDate;
            dtpDateFin.Value = endDate;
        }

        private void InitializeForm()
        {
            this.Load += FormSituationReport_Load;
            this.btnValider.Click += (s, e) => LoadAllReports();

            // Add selection changed events to load details
            this.dgvCommandes.SelectionChanged += (s, e) => LoadDetailsForSelectedCommand();
            this.dgvLivraisons.SelectionChanged += (s, e) => LoadDetailsForSelectedLivraison();
            this.dgvFactures.SelectionChanged += (s, e) => LoadDetailsForSelectedFacture();
        }

        private void FormSituationReport_Load(object sender, EventArgs e)
        {
            LoadAllReports();
        }

        private void LoadAllReports()
        {
            DateTime startDate = dtpDateDebut.Value.Date;
            DateTime endDate = dtpDateFin.Value.Date.AddDays(1).AddSeconds(-1);

            LoadCommandes(startDate, endDate);
            LoadLivraisons(startDate, endDate);
            LoadFactures(startDate, endDate);
            LoadReglements(startDate, endDate);
        }

        #region Data Loading for Each Tab

        private void LoadCommandes(DateTime start, DateTime end)
        {
            dgvCommandes.Rows.Clear();
            decimal totalSum = 0;
            string query = @"
        SELECT bc.BC_ID, bc.BC_Date, bc.BC_Number, s.Name as ClientName, 'Bon de Commande' as Nature, bc.TotalTTC, 'N/A' as Etat, bc.CreatedBy as UserName
        FROM BonCommandes bc
        JOIN Suppliers s ON bc.SupplierID = s.SupplierID
        WHERE bc.BC_Date BETWEEN @StartDate AND @EndDate AND bc.IsActive = 1
        ORDER BY bc.BC_Date DESC";

            try
            {
                using (var conn = new SqlConnection(connectionString))
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@StartDate", start);
                    cmd.Parameters.AddWithValue("@EndDate", end);
                    conn.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            decimal totalTTC = Convert.ToDecimal(reader["TotalTTC"] ?? 0);
                            int rowIndex = dgvCommandes.Rows.Add(
                                ((DateTime)reader["BC_Date"]).ToString("HH:mm"),
                                reader["BC_Number"],
                                reader["ClientName"],
                                reader["Nature"],
                                totalTTC.ToString("N2"),
                                reader["Etat"],
                                reader["UserName"]
                            );
                            dgvCommandes.Rows[rowIndex].Tag = reader["BC_ID"];
                            totalSum += totalTTC;
                        }
                    }
                }
                labelCmdSomme.Text = $"Somme: {totalSum:N2}";
            }
            catch (Exception ex) { MessageBox.Show("Error loading Commandes: " + ex.Message); }
        }

        private void LoadLivraisons(DateTime start, DateTime end)
        {
            dgvLivraisons.Rows.Clear();
            decimal totalSum = 0;
            string query = @"
        SELECT bl.BL_ID, bl.BL_Number, c.CustomerName, bl.TotalTTC, bl.Status, f.InvoiceNumber
        FROM BonLivraisons bl
        JOIN Customers c ON bl.CustomerID = c.CustomerID
        LEFT JOIN SalesInvoices f ON bl.SalesInvoiceID = f.InvoiceID
        WHERE bl.BL_Date BETWEEN @StartDate AND @EndDate AND bl.IsActive = 1
        ORDER BY bl.BL_Date DESC";

            try
            {
                using (var conn = new SqlConnection(connectionString))
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@StartDate", start);
                    cmd.Parameters.AddWithValue("@EndDate", end);
                    conn.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            decimal totalTTC = Convert.ToDecimal(reader["TotalTTC"] ?? 0);
                            int rowIndex = dgvLivraisons.Rows.Add(
                                reader["BL_Number"],
                                reader["CustomerName"],
                                totalTTC.ToString("N2"),
                                reader["Status"],
                                reader["InvoiceNumber"] ?? "N/A"
                            );
                            dgvLivraisons.Rows[rowIndex].Tag = reader["BL_ID"];
                            totalSum += totalTTC;
                        }
                    }
                }
                labelBlSomme.Text = $"Somme: {totalSum:N2}";
            }
            catch (Exception ex) { MessageBox.Show("Error loading Livraisons: " + ex.Message); }
        }


        private void LoadFactures(DateTime start, DateTime end)
        {
            dgvFactures.Rows.Clear();
            decimal totalSum = 0;
            string query = @"
        SELECT si.InvoiceID, si.InvoiceNumber, si.InvoiceDate, c.CustomerName, si.TotalTTC
        FROM SalesInvoices si
        JOIN Customers c ON si.CustomerID = c.CustomerID
        WHERE si.InvoiceDate BETWEEN @StartDate AND @EndDate
        ORDER BY si.InvoiceDate DESC";

            try
            {
                using (var conn = new SqlConnection(connectionString))
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@StartDate", start);
                    cmd.Parameters.AddWithValue("@EndDate", end);
                    conn.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            decimal totalTTC = Convert.ToDecimal(reader["TotalTTC"] ?? 0);
                            int rowIndex = dgvFactures.Rows.Add(
                                ((DateTime)reader["InvoiceDate"]).ToShortDateString(),
                                reader["InvoiceNumber"],
                                reader["CustomerName"],
                                totalTTC.ToString("N2")
                            );
                            dgvFactures.Rows[rowIndex].Tag = reader["InvoiceID"];
                            totalSum += totalTTC;
                        }
                    }
                }
                labelFacSomme.Text = $"Somme: {totalSum:N2}";
            }
            catch (Exception ex) { MessageBox.Show("Error loading Factures: " + ex.Message); }
        }

        private void LoadReglements(DateTime start, DateTime end)
        {
            dgvReglements.Rows.Clear();
            decimal totalEspece = 0, totalCheque = 0, totalCarte = 0; //... and others

            string query = @"
        SELECT c.CustomerName, cp.PaymentMethod, cp.Notes, cp.Amount
        FROM CustomerPayments cp
        JOIN Customers c ON cp.CustomerID = c.CustomerID
        WHERE cp.PaymentDate BETWEEN @StartDate AND @EndDate";

            try
            {
                using (var conn = new SqlConnection(connectionString))
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@StartDate", start);
                    cmd.Parameters.AddWithValue("@EndDate", end);
                    conn.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string method = reader["PaymentMethod"].ToString();
                            decimal amount = Convert.ToDecimal(reader["Amount"]);

                            dgvReglements.Rows.Add(
                                reader["CustomerName"],
                                method,
                                reader["Notes"], // Justificatif
                                amount.ToString("N2")
                            );

                            if (method.Contains("نقداً")) totalEspece += amount;
                            if (method.Contains("شيك")) totalCheque += amount;
                            if (method.Contains("بطاقة")) totalCarte += amount;
                            // Add other payment types if needed
                        }
                    }
                }
                txtEspece.Text = totalEspece.ToString("N2");
                txtCheque.Text = totalCheque.ToString("N2");
                txtCarte.Text = totalCarte.ToString("N2");
            }
            catch (Exception ex) { MessageBox.Show("Error loading Règlements: " + ex.Message); }
        }

        #endregion

        #region Detail Loading for Each Tab

        #region Detail Loading for Each Tab

        private void LoadDetailsForSelectedCommand()
        {
            dgvCommandeDetails.Rows.Clear();
            if (dgvCommandes.SelectedRows.Count == 0 || dgvCommandes.SelectedRows[0].Tag == null) return;

            int bcId = Convert.ToInt32(dgvCommandes.SelectedRows[0].Tag);
            string query = @"
        SELECT a.Article, a.ArticleLongName, bci.Quantity, bci.UnitPriceHT
        FROM BonCommandeItems bci
        JOIN Articles a ON bci.ArticleID = a.Id
        WHERE bci.BC_ID = @ID";

            try
            {
                using (var conn = new SqlConnection(connectionString))
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ID", bcId);
                    conn.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            decimal qty = Convert.ToDecimal(reader["Quantity"]);
                            decimal price = Convert.ToDecimal(reader["UnitPriceHT"]);
                            dgvCommandeDetails.Rows.Add(
                                reader["Article"],
                                reader["ArticleLongName"],
                                qty,
                                price.ToString("N2"),
                                (qty * price).ToString("N2")
                            );
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading command details: " + ex.Message);
            }
        }

        private void LoadDetailsForSelectedLivraison()
        {
            dgvLivraisonDetails.Rows.Clear();
            if (dgvLivraisons.SelectedRows.Count == 0 || dgvLivraisons.SelectedRows[0].Tag == null) return;

            int blId = Convert.ToInt32(dgvLivraisons.SelectedRows[0].Tag);
            string query = @"
        SELECT a.Article, a.ArticleLongName, bli.Quantity, bli.UnitPriceHT
        FROM BonLivraisonItems bli
        JOIN Articles a ON bli.ArticleID = a.Id
        WHERE bli.BL_ID = @ID";

            try
            {
                using (var conn = new SqlConnection(connectionString))
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ID", blId);
                    conn.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            decimal qty = Convert.ToDecimal(reader["Quantity"]);
                            decimal price = Convert.ToDecimal(reader["UnitPriceHT"]);
                            dgvLivraisonDetails.Rows.Add(
                                reader["Article"],
                                reader["ArticleLongName"],
                                qty,
                                price.ToString("N2"),
                                (qty * price).ToString("N2")
                            );
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading delivery note details: " + ex.Message);
            }
        }

        private void LoadDetailsForSelectedFacture()
        {
            dgvFactureDetails.Rows.Clear();
            if (dgvFactures.SelectedRows.Count == 0 || dgvFactures.SelectedRows[0].Tag == null) return;

            int invoiceId = Convert.ToInt32(dgvFactures.SelectedRows[0].Tag);
            string query = @"
        SELECT a.Article, a.ArticleLongName, sii.Quantity, sii.UnitPriceHT
        FROM SalesInvoiceItems sii
        JOIN Articles a ON sii.ArticleID = a.Id
        WHERE sii.InvoiceID = @ID";

            try
            {
                using (var conn = new SqlConnection(connectionString))
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ID", invoiceId);
                    conn.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            decimal qty = Convert.ToDecimal(reader["Quantity"]);
                            decimal price = Convert.ToDecimal(reader["UnitPriceHT"]);
                            dgvFactureDetails.Rows.Add(
                                reader["Article"],
                                reader["ArticleLongName"],
                                qty,
                                price.ToString("N2"),
                                (qty * price).ToString("N2")
                            );
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading invoice details: " + ex.Message);
            }
        }

        #endregion

        #endregion
    }
}