using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAPTAGPOS
{
    public class PurchaseTicketItem // Similar to ReceiptItem, but can be specific if needed
    {
        public string Name { get; set; }
        public decimal Quantity { get; set; }
        public int ArticleID { get; set; }
        public decimal UnitPrice { get; set; } // This will be the BuyPrice
        public decimal TotalPrice => Quantity * UnitPrice;
        public string Barcode { get; set; }
    }
}
