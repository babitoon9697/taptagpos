using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TAPTAGPOS
{
    public partial class FormSuiviArticle : Form
    {
        private string connectionString = DatabaseConnection.GetConnectionString();
        private int _articleId;
        private string _articleName;

        // Add this new constructor to the class
        public FormSuiviArticle(int articleId) : this()
        {
            _articleId = articleId;
        }
        public FormSuiviArticle(int articleId, string articleName)
        {
            InitializeComponent();
            _articleId = articleId;
            _articleName = articleName;

            this.Text = $"Suivi d'article: {articleName}";

            // Link events
            this.Load += FormSuiviArticle_Load;
            // Add click events for ToolStrip buttons later if needed
            // this.tsbFiltrer.Click += tsbFiltrer_Click;
            // this.tsbAfficherTous.Click += (s, e) => LoadData();
        }
        
        public FormSuiviArticle()
        {
            InitializeComponent();

            // Link events
            this.Load += FormSuiviArticle_Load;
            // Add click events for ToolStrip buttons later if needed
            // this.tsbFiltrer.Click += tsbFiltrer_Click;
            // this.tsbAfficherTous.Click += (s, e) => LoadData();
        }

        private void FormSuiviArticle_Load(object sender, EventArgs e)
        {
            if(_articleId != 0)
            {

                LoadData(_articleId);
            }
            else
            {
                LoadData();
            }
        }

        private void LoadData(int id)
        {
            dgvSuivi.Rows.Clear();
            decimal totalQuantity = 0;

            // This query gets all sales for the specific article and joins to get the client name
            string query = @"
                SELECT 
                    t.TransactionDate, 
                    t.TicketID, -- Using TicketID as 'N° B.L.'
                    a.Article AS Reference,
                    ti.ItemName AS Libelle,
                    ti.Quantity AS Qte,
                    ti.Price AS Prix,
                    c.CustomerName AS Client
                FROM TransactionItems ti
                JOIN Transactions t ON ti.TransactionID = t.TransactionID
                JOIN Customers c ON t.CustomerID = c.CustomerID
                JOIN Articles a ON ti.ArticleID = a.Id
                WHERE ti.ArticleID = @ArticleID
                ORDER BY t.TransactionDate DESC";

            try
            {
                using (var conn = new SqlConnection(connectionString))
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ArticleID", id);
                    conn.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            decimal quantity = Convert.ToDecimal(reader["Qte"]);
                            dgvSuivi.Rows.Add(
                                ((DateTime)reader["TransactionDate"]).ToShortDateString(),
                                reader["TicketID"],
                                reader["Reference"],
                                reader["Libelle"],
                                quantity.ToString("N3"),
                                Convert.ToDecimal(reader["Prix"]).ToString("N4"),
                                reader["Client"]
                            );
                            totalQuantity += quantity;
                        }
                    }
                }
                txtSumQte.Text = totalQuantity.ToString("N3");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading article tracking data: " + ex.Message);
            }
        }
        private void LoadData()
        {
            dgvSuivi.Rows.Clear();
            decimal totalQuantity = 0;

            // This query gets all sales for the specific article and joins to get the client name
            string query = @"
                SELECT 
                    t.TransactionDate, 
                    t.TicketID, -- Using TicketID as 'N° B.L.'
                    a.Article AS Reference,
                    ti.ItemName AS Libelle,
                    ti.Quantity AS Qte,
                    ti.Price AS Prix,
                    c.CustomerName AS Client
                FROM TransactionItems ti
                JOIN Transactions t ON ti.TransactionID = t.TransactionID
                JOIN Customers c ON t.CustomerID = c.CustomerID
                JOIN Articles a ON ti.ArticleID = a.Id
                ORDER BY t.TransactionDate DESC";

            try
            {
                using (var conn = new SqlConnection(connectionString))
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ArticleID", _articleId);
                    conn.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            decimal quantity = Convert.ToDecimal(reader["Qte"]);
                            dgvSuivi.Rows.Add(
                                ((DateTime)reader["TransactionDate"]).ToShortDateString(),
                                reader["TicketID"],
                                reader["Reference"],
                                reader["Libelle"],
                                quantity.ToString("N3"),
                                Convert.ToDecimal(reader["Prix"]).ToString("N4"),
                                reader["Client"]
                            );
                            totalQuantity += quantity;
                        }
                    }
                }
                txtSumQte.Text = totalQuantity.ToString("N3");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading article tracking data: " + ex.Message);
            }
        }

        private void tsbFiltrer_Click(object sender, EventArgs e)
        {

        }

        private void tsbAfficherTous_Click(object sender, EventArgs e)
        {

        }
    }
}