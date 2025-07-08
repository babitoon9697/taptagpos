using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAPTAGPOS
{
    public class ProductionSituationItem
    {
        public string Reference { get; set; }
        public string Designation { get; set; }
        public decimal QtePrevue { get; set; }
        public decimal QteProduite { get; set; }
        public decimal Ecart { get; set; }
    }
}
