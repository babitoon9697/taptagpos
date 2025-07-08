using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAPTAGPOS
{
    public class StockStatePrintItem
    {
        public string ID { get; set; }
        public string ArticleName { get; set; }
        public decimal Quantity { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
