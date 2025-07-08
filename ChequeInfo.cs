using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAPTAGPOS
{
    public class ChequeInfo
    {
        public decimal Amount { get; set; }
        public string BankName { get; set; }
        public string CheckNumber { get; set; }
        public DateTime DueDate { get; set; }
        public string PayerName { get; set; }
    }
}
