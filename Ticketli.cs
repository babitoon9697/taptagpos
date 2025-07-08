// In Ticketli.cs
using System;
using System.Windows.Forms;

namespace TAPTAGPOS
{
    public partial class Ticketli : UserControl
    {
        public int TicketID { get; private set; }

        // This event now sends the MouseEventArgs so we can check which button was clicked
        public event Action<int, MouseEventArgs> OnTicketMouseClick;

        public Ticketli()
        {
            InitializeComponent();
            WireUpClickEvents(this);
        }

        public void PopulateTicketSummary(TicketSummary summary)
        {
            this.TicketID = summary.TicketID;
            lbl_ticketNumber.Text = summary.TicketID.ToString();
            lblDate.Text = summary.Date.ToString("g");
            lbl_client.Text = summary.ClientName;
            lbl_total.Text = summary.TotalAmount.ToString("C2");
            lbl_paid.Text = summary.AmountPaid.ToString("C2");
            lbl_articlescount.Text = summary.ArticlesCount.ToString()+" Articles";
            if(summary.TotalAmount> summary.AmountPaid)
            {
                this.BackColor= System.Drawing.Color.Red;
                lbl_total.ForeColor = System.Drawing.Color.White;
                lbl_paid.ForeColor = System.Drawing.Color.White;
                lbl_client.ForeColor = System.Drawing.Color.White;
                label2.ForeColor = System.Drawing.Color.White;
                label3.ForeColor = System.Drawing.Color.White;
                lbl_articlescount.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void HandleMouseClick(object sender, MouseEventArgs e)
        {
            OnTicketMouseClick?.Invoke(this.TicketID, e);
        }

        private void WireUpClickEvents(Control container)
        {
            container.MouseClick += HandleMouseClick;
            foreach (Control c in container.Controls)
            {
                WireUpClickEvents(c);
            }
        }
    }
}