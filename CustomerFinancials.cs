using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAPTAGPOS
{
    public class CustomerFinancials
    {
        public int CustomerID { get; set; }
        public bool IsCreditAllowed { get; set; }
        public decimal CurrentDebt { get; set; }
        public decimal? DebtCeiling { get; set; } // Nullable in case it's not set
        public decimal? CheckCeiling { get; set; } // Nullable
    }
}
