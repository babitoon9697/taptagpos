using System;
using System.Drawing;
using System.Windows.Forms;

namespace TAPTAGPOS
{
    public partial class AttenteLi : UserControl
    {
        // --- Public properties to hold the ticket's data ---
        public int TicketID { get; private set; }
        public string ClientName { get; private set; }
        public DateTime TicketDate { get; private set; }
        public decimal TotalAmount { get; private set; }
        public decimal CountArticle { get; private set; }

        // --- A single, clean event to notify the parent form when this control is clicked ---
        public event Action<int> OnTicketSelected;

        public AttenteLi()
        {
            InitializeComponent();

            // This helper method makes the entire control clickable
            WireUpClickEvents(this);
        }


        public void SetData(int ticketId, string clientName, DateTime ticketDate, decimal totalAmount,int countarticles)
        {
            // Store the data
            this.TicketID = ticketId;
            this.ClientName = clientName;
            this.TicketDate = ticketDate;
            this.TotalAmount = totalAmount;
            this.CountArticle= countarticles;
            // Update the display labels
            lbl_ticketNumber.Text = ticketId.ToString();
            lbl_client.Text = clientName;
            lblDate.Text = ticketDate.ToString("dd/MM/yyyy HH:mm");
            lbl_total.Text = totalAmount.ToString("N2");
            lbl_articlescount.Text = countarticles.ToString()+" Articles";
        }


        private void HandleControlClick(object sender, EventArgs e)
        {
            OnTicketSelected?.Invoke(this.TicketID);
        }

        private void WireUpClickEvents(Control container)
        {
            container.Click += HandleControlClick;
            foreach (Control c in container.Controls)
            {
                WireUpClickEvents(c);
            }
        }
    }
}