using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAPTAGPOS
{
    public class Article
    {
        public int Id { get; set; }
        public string ArticleCode { get; set; }
        public string ArticleColor { get; set; }
        public string ArticleLongName { get; set; }
        public string Barcode { get; set; }
        public decimal BuyPrice { get; set; }
        public decimal SellPrice { get; set; }
        public decimal QuantityStock { get; set; }
        public string ImagePath { get; set; }
    }
   


}
