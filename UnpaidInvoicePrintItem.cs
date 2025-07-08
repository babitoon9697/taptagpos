using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAPTAGPOS
{
    public class UnpaidInvoicePrintItem
    {
        public string InvoiceID { get; set; }
        public string Date { get; set; }
        public decimal Total { get; set; }
        public decimal Paid { get; set; }
        public decimal Due { get; set; }
    }

    public class UnpaidInvoicesReportData
    {
        public string ReportTitle { get; set; } = "لائحة الفواتير غير المدفوعة";
        public string CustomerName { get; set; }
        public DateTime PrintDate { get; set; }
        public List<UnpaidInvoicePrintItem> Items { get; set; } = new List<UnpaidInvoicePrintItem>();
    }
}
