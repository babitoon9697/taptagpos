using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAPTAGPOS
{
    // Holds all data for the A4 invoice print job
    public class A4InvoicePrintData
    {
        // Company Info (from AppSettings)
        public string CompanyName { get; set; }
        public string CompanyAddress { get; set; }
        public string CompanyPhone { get; set; }
        public string CompanyVatNumber { get; set; }
        public Image CompanyLogo { get; set; }

        // Customer Info
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public string CustomerPhone { get; set; }
        public string CustomerVatNumber { get; set; }

        // Invoice Info
        public string InvoiceNumber { get; set; }
        public DateTime InvoiceDate { get; set; }
        public List<InvoicePrintItem> Items { get; set; }

        // Totals
        public decimal TotalHT { get; set; }
        public decimal DiscountAmount { get; set; }
        public decimal NetHT { get; set; }
        public decimal TotalTVA { get; set; }
        public decimal TotalTTC { get; set; }
        public string TotalTTCInWords { get; set; } // e.g., "One Hundred and Fifty Dinars"

        public A4InvoicePrintData()
        {
            Items = new List<InvoicePrintItem>();
        }
    }

    // Represents a single line item in the printed invoice
    public class InvoicePrintItem
    {
        public string Reference { get; set; }
        public string Description { get; set; }
        public decimal Quantity { get; set; }
        public decimal UnitPriceHT { get; set; }
        public decimal TvaRate { get; set; }
        public decimal TotalHT { get; set; }
    }
}
