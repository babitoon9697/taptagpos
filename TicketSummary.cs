using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAPTAGPOS
{
    public class TicketSummary
    {
        public int TicketID { get; set; }
        public DateTime Date { get; set; }
        public string ClientName { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal AmountPaid { get; set; }
        public int ArticlesCount { get; set; }
    }
}
