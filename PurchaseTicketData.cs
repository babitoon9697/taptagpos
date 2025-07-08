using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAPTAGPOS
{
    public class PurchaseTicketData
    {
        // --- Your Company Details (The Purchaser) ---
        public string YourCompanyName { get; set; } = "NOM DE VOTRE ENTREPRISE"; // 👈 Customize
        public string YourCompanyAddress { get; set; } = "Votre Adresse, Ville";   // 👈 Customize
        public string YourCompanyPhone { get; set; } = "Votre Téléphone: 05XX-XXXXXX"; // 👈 Customize
        public string YourCompanyVatNumber { get; set; } = "Votre N° RC/IF/ICE";     // 👈 Customize (if applicable)
                                                                                     // public string YourCompanyLogoPath { get; set; } = "C:\\path\\to\\your_company_logo.png"; // 👈 Optional: Customize

        // --- Purchase Details ---
        public string PurchaseInvoiceNumber { get; set; }
        public DateTime PurchaseDate { get; set; }
        public string TicketTitle { get; set; } = "BON DE RÉCEPTION / FACTURE D'ACHAT"; // Or just "FACTURE D'ACHAT"

        // --- Supplier Details ---
        public string SupplierName { get; set; }
        // public string SupplierAddress { get; set; } // Add if you store and want to print more supplier details
        // public string SupplierVatNumber { get; set; }

        // --- Items ---
        public List<PurchaseTicketItem> Items { get; set; }

        // --- Totals & Payment ---
        public decimal SubTotalAmount { get; set; } // Total before discount/tax
        public decimal DiscountAmount { get; set; }
        public decimal TaxAmount { get; set; } // If you implement tax calculation
        public decimal GrandTotalAmount { get; set; }
        public decimal AmountPaid { get; set; } // Avance
        public decimal AmountDue { get; set; }  // Reste

        public string PaymentType { get; set; }
        public string PaymentStatus { get; set; }

        // --- Footer ---
        public string FooterMessage1 { get; set; } = "Marchandise reçue en bon état."; // 👈 Customize
        public string FooterMessage2 { get; set; } = "Merci.";                     // 👈 Customize

        public PurchaseTicketData()
        {
            Items = new List<PurchaseTicketItem>();
        }
    }
}
