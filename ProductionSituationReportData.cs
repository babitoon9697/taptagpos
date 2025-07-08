using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAPTAGPOS
{
    public class ProductionSituationReportData
    {
        public string ReportTitle { get; set; } = "Situation de Production par Article";
        public string CompanyName { get; set; }
        public string FilterInfo { get; set; }
        public List<ProductionSituationItem> Items { get; set; } = new List<ProductionSituationItem>();
        public decimal TotalPrevue { get; set; }
        public decimal TotalProduite { get; set; }
        public decimal TotalEcart { get; set; }
    }

}
