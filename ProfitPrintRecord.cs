using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAPTAGPOS
{
    public class ProfitPrintRecord
    {
        public string Code { get; set; }
        public string Article { get; set; }
        public string Sales { get; set; }
        public decimal PurchaseValue { get; set; }
        public decimal SaleValue { get; set; }
        public decimal Profit { get; set; }
    }

    // كلاس لتخزين بيانات الملخص النهائي
    public class ProfitSummaryData
    {
        public decimal TotalProfit { get; set; }
        public decimal TotalExpenses { get; set; }
        public decimal NetProfit { get; set; }
    }
}
