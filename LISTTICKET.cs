// In LISTTICKET.cs
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Runtime.InteropServices.ComTypes;
using System.Windows.Forms;

namespace TAPTAGPOS
{
    public partial class LISTTICKET : Form
    {
        public Caisse ParentCaisseForm { get; set; }
        public CaisseCafe ParentCaisseForm2 { get; set; }
        private string connectionString = DatabaseConnection.GetConnectionString();

        private ContextMenuStrip ticketMenu;
        private int _selectedTicketIdForMenu;

        public LISTTICKET()
        {
            InitializeComponent();
            InitializeContextMenu();
            this.Load += LISTTICKET_Load;
            this.TICKETDATE.ValueChanged += (s, e) => ShowTicketSummaries();
            this.TICKETDATE_periode.ValueChanged += (s, e) => ShowTicketSummaries();
        }

        // In LISTTICKET.cs
        private void InitializeContextMenu()
        {
            ticketMenu = new ContextMenuStrip();
            var modifyItem = new ToolStripMenuItem("Voir / Modifier Ticket");
            var printItem = new ToolStripMenuItem("Imprimer Duplicata");
            var deleteItem = new ToolStripMenuItem("Traiter un Retour (Annuler)"); // New text

            modifyItem.Click += (s, e) => LoadTicketForEditing(_selectedTicketIdForMenu);
            printItem.Click += (s, e) => {
                using (var tempCaisse = new Caisse())
                {
                    tempCaisse.PrintReceiptForTransaction(_selectedTicketIdForMenu);
                }
            };

            // --- THIS IS THE CORRECTED DELETE LOGIC ---
            deleteItem.Click += (s, e) => {
                if (MessageBox.Show($"Êtes-vous sûr de vouloir annuler complètement le ticket N°{_selectedTicketIdForMenu}?\nCette action créera une transaction de retour et remettra les articles en stock.",
                                    "Confirmation de l'Annulation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    // Use a Caisse instance to perform the complex return logic
                    using (var tempCaisse = new Caisse())
                    {
                        tempCaisse.CreateReturnForTransaction(_selectedTicketIdForMenu);
                    }
                    // Refresh the list to show the change in status
                    ShowTicketSummaries();
                }
            };

            ticketMenu.Items.AddRange(new ToolStripItem[] { modifyItem, printItem, new ToolStripSeparator(), deleteItem });
        }
        private void LISTTICKET_Load(object sender, EventArgs e)
        {
            TICKETDATE.Value = DateTime.Today;
        }

        private void ShowTicketSummaries()
        {
            flowLayoutPanelListeAttente.Controls.Clear();
            List<TicketSummary> summaries = GetTicketSummaries(TICKETDATE.Value.Date);
            foreach (var summary in summaries)
            {
                var ticketControl = new Ticketli();
                ticketControl.PopulateTicketSummary(summary);
                ticketControl.OnTicketMouseClick += Ticket_MouseClick;
                flowLayoutPanelListeAttente.Controls.Add(ticketControl);
            }
        }

        private List<TicketSummary> GetTicketSummaries(DateTime selectedDate)
        {
            var summaries = new List<TicketSummary>();
            string query = @"
        SELECT 
            t.TransactionID, 
            t.TransactionDate, 
            c.CustomerName, 
            ISNULL(t.TotalAmount, 0) AS TotalAmount,
            ISNULL(t.AmountPaid, 0) AS AmountPaid,
            (SELECT COUNT(*) FROM TransactionItems ti WHERE ti.TransactionID = t.TransactionID) AS ArticlesCount
        FROM Transactions t
        JOIN Customers c ON t.CustomerID = c.CustomerID
        WHERE t.TransactionDate BETWEEN @StartDate AND @EndDate 
          AND ISNULL(t.PaymentStatus, '') != 'Returned'
        ORDER BY t.TransactionDate DESC;";
            try
            {
                using (var conn = new SqlConnection(connectionString))
                using (var cmd = new SqlCommand(query, conn))
                {
                    // Set the start and end date parameters for the query
                    cmd.Parameters.Add("@StartDate", SqlDbType.DateTime).Value = TICKETDATE.Value;
                    // Add 1 day to the end date to include all times on that day
                    cmd.Parameters.Add("@EndDate", SqlDbType.DateTime).Value = TICKETDATE_periode.Value.AddDays(1).AddSeconds(-1);
                    conn.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            summaries.Add(new TicketSummary
                            {
                                TicketID = Convert.ToInt32(reader["TransactionID"]),
                                Date = Convert.ToDateTime(reader["TransactionDate"]),
                                ClientName = reader["CustomerName"].ToString(),
                                TotalAmount = Convert.ToDecimal(reader["TotalAmount"]),
                                AmountPaid = Convert.ToDecimal(reader["AmountPaid"]),
                                ArticlesCount = Convert.ToInt32(reader["ArticlesCount"])
                            });
                        }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show($"Database Error: {ex.Message}"); }
            return summaries;
        }

        private void Ticket_MouseClick(int ticketId, MouseEventArgs e)
        {
            _selectedTicketIdForMenu = ticketId;
            if (e.Button == MouseButtons.Left)
            {
                LoadTicketForEditing(ticketId);
            }
            else if (e.Button == MouseButtons.Right)
            {
                ticketMenu.Show(Cursor.Position);
            }
        }

        private void LoadTicketForEditing(int ticketId)
        {
            if (ParentCaisseForm != null && !ParentCaisseForm.IsDisposed)
            {
                ParentCaisseForm.FillDataGridForEditing(ticketId);
            }
            else if (ParentCaisseForm2 != null && !ParentCaisseForm2.IsDisposed)
            {
                ParentCaisseForm2.FillDataGridForEditing(ticketId);
            }
            else
            {
                Caisse newCaisse = new Caisse(ticketId);
                newCaisse.Show();
            }
            this.Close();
        }
    }
}