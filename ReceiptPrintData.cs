using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAPTAGPOS
{
    public class ReceiptPrintData
    {
        // Company Info (will be loaded from settings)
        public string CompanyName { get; set; }
        public string CompanyAddress { get; set; }
        public string CompanyPhone { get; set; }
        public string VatNumber { get; set; }
        public string FooterMessage1 { get; set; }

        // Transaction Info
        public int TicketId { get; set; }
        public DateTime PrintDateTime { get; set; }
        public string ClientName { get; set; }

        // Items
        public List<ReceiptItem> Items { get; set; } = new List<ReceiptItem>();

        // Financial Summary
        public decimal SubTotal { get; set; } // NEW
        public decimal TotalDiscount { get; set; } // NEW
        public decimal TotalAmount { get; set; }
        public decimal AmountPaid { get; set; }
        public string PaymentMethod { get; set; } // e.g., "نقداً + شيك"
        public decimal RemainingDebt { get; set; }

        public ReceiptPrintData()
        {
            Items = new List<ReceiptItem>();
        }
    }
}
