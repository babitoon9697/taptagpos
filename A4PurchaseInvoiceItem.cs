using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAPTAGPOS
{
    // In A4PurchaseInvoiceData.cs (or wherever A4PurchaseInvoiceItem is defined)
    public class A4PurchaseInvoiceItem
    {
        public int LineNumber { get; set; }
        public string ItemCode { get; set; }        // This will store Article.Article (from your DB)
        public string Barcode { get; set; }         // <<< ADD THIS PROPERTY
        public string Description { get; set; }
        public int Quantity { get; set; }
        public string UnitOfMeasure { get; set; } = "PCE";
        public decimal UnitPrice { get; set; }
        public decimal TotalLinePrice => Quantity * UnitPrice;
    }
    public class A4PurchaseInvoiceData
    {
        // --- Your Company Details (The Purchaser) ---
        public string PurchaserCompanyName { get; set; } = "NOM DE VOTRE SOCIÉTÉ"; // 👈 Customize
        public string PurchaserAddress { get; set; } = "Votre Adresse Ligne 1\nVotre Ville, Code Postal"; // 👈 Customize
        public string PurchaserPhone { get; set; } = "Tél: Votre Numéro";    // 👈 Customize
        public string PurchaserEmail { get; set; } = "Email: votre.email@example.com";  // 👈 Customize
        public string PurchaserVatId { get; set; } = "ICE/RC/IF: XXXXXXXX"; // 👈 Customize
        public string PurchaserLogoPath { get; set; } = ""; // Optional: "C:\\path\\to\\logo.png" 👈 Customize

        // --- Supplier Details (The Seller) ---
        public string SupplierName { get; set; }
        public string SupplierAddress { get; set; } // Fetch from Suppliers table
        public string SupplierContactPerson { get; set; }
        public string SupplierPhone { get; set; }
        public string SupplierVatId { get; set; }

        // --- Invoice Header ---
        public string InvoiceTitle { get; set; } = "FACTURE D'ACHAT"; // Or "BON DE COMMANDE" etc.
        public string InvoiceNumber { get; set; } // From PurchaseInvoices.InvoiceNumber
        public DateTime InvoiceDate { get; set; }   // From PurchaseInvoices.PurchaseDate
        public string PaymentTerms { get; set; }    // From Suppliers.PaymentTerms or PurchaseInvoices
        // public DateTime DueDate { get; set; } // Calculate if needed based on InvoiceDate and PaymentTerms

        // --- Items ---
        public List<A4PurchaseInvoiceItem> Items { get; set; }

        // --- Totals ---
        public decimal SubtotalAmount { get; set; }     // Sum of TotalLinePrice before discount/tax
        public decimal DiscountAmount { get; set; }     // From PurchaseInvoices.Discount
        public decimal TaxableAmount => SubtotalAmount - DiscountAmount;
        public decimal TaxRate { get; set; } = 0.20m; // Example 20% VAT, make this dynamic if needed
        public decimal TaxAmount { get; set; }          // From PurchaseInvoices.Tax or calculated
        public decimal ShippingAmount { get; set; } = 0m; // If applicable
        public decimal GrandTotalAmount { get; set; }   // From PurchaseInvoices.GrandTotal

        // --- Payment Details ---
        public string PaymentMethod { get; set; }       // From PurchaseInvoices.PaymentType
        public string PaymentStatus { get; set; }       // From PurchaseInvoices.PaymentType
        public decimal AmountPaid { get; set; }          // Advance payment made for this purchase
        public decimal AmountDue => GrandTotalAmount - AmountPaid;

        // --- Footer ---
        public string Notes { get; set; }               // From PurchaseInvoices.Notes (if exists) or general notes
        public string BankDetails { get; set; } = "Nos Coordonnées Bancaires: XXXXXXX"; // 👈 Customize if you pay by transfer

        public A4PurchaseInvoiceData()
        {
            Items = new List<A4PurchaseInvoiceItem>();
            Notes = "Veuillez vérifier la marchandise à la réception. Aucune réclamation ne sera admise après signature."; // Example
        }
    }
}
