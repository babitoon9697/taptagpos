using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAPTAGPOS
{
    public class ZReportData
    {
        public int SessionID { get; set; }
        public string UserName { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public decimal StartingCash { get; set; }
        public decimal CashSales { get; set; }
        public decimal CardSales { get; set; }
        public decimal ChequeSales { get; set; }
        public decimal CreditSales { get; set; }
        public decimal TotalSales => CashSales + CardSales + ChequeSales + CreditSales;
        public decimal Returns { get; set; }
        public decimal Discounts { get; set; }
        public decimal Expenses { get; set; }
        public decimal CashInDrawer { get; set; }
        public decimal DeclaredCash { get; set; }
        public decimal Difference => DeclaredCash - CashInDrawer;
    }
}
