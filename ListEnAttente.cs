using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TAPTAGPOS
{
    public partial class ListEnAttente : Form
    {
        private Caisse _parentCaisse;
        private CaisseCafe _parentCaisse2;
        private string connectionString = DatabaseConnection.GetConnectionString();

        public ListEnAttente(Caisse parent)
        {
            InitializeComponent();
            _parentCaisse = parent;
        }
        public ListEnAttente(CaisseCafe parent)
        {
            InitializeComponent();
            _parentCaisse2 = parent;
        }

        private void ListEnAttente_Load(object sender, EventArgs e)
        {
            LoadPendingTickets();
        }

        private void LoadPendingTickets()
        {
            flowLayoutPanelListeAttente.Controls.Clear();

            // This query gets the summary of each on-hold ticket
            string query = @"
        SELECT 
            t.id_ticket, 
            t.ClientName, 
            t.ticket_date, 
            t.total_amount,
            COUNT(a.id) AS ArticlesCount
        FROM 
            Ticket t
        LEFT JOIN 
            Attente a ON t.id_ticket = a.id_ticket
        WHERE 
            t.validated = 0
        GROUP BY
            t.id_ticket, t.ClientName, t.ticket_date, t.total_amount
        ORDER BY 
            t.ticket_date DESC;";
            try
            {
                using (var conn = new SqlConnection(connectionString))
                using (var cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var ticketControl = new AttenteLi();
                            ticketControl.SetData(
                                Convert.ToInt32(reader["id_ticket"]),
                                reader["ClientName"].ToString(),
                                Convert.ToDateTime(reader["ticket_date"]),
                                Convert.ToDecimal(reader["total_amount"]),
                                Convert.ToInt32(reader["ArticlesCount"])
                            );

                            ticketControl.OnTicketSelected += Ticket_Selected;
                            flowLayoutPanelListeAttente.Controls.Add(ticketControl);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading pending tickets: " + ex.Message);
            }
        }

        private void Ticket_Selected(int ticketId)
        {
            // Call the public method on the Caisse form to load the ticket
            _parentCaisse.LoadPendingTicket(ticketId);
            this.Close();
        }
    }
}