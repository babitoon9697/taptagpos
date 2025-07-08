using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAPTAGPOS
{
    public class ReceiptItem
    {
        public string Name { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal Total => Quantity * Price;
        // public string Barcode {get; set;} // Include if you want to print item barcodes
    }
}
