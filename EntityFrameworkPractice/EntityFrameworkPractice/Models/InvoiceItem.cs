using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkPractice.Models
{
    public class InvoiceItem
    {
        public int Id { get; set; }
        public int InvoiceId { get; set; }
        public string EAN { get; set; } = null!;
        public string? BuyerItemCode { get; set; }
        public string? SupplierItemCode { get; set; }
        public string ItemDescription { get; set; } = null!;
        public int InvoiceQuantity { get; set; }
        public string UnitOfMeasure { get; set; } = null!;
        public double InvoiceUnitNetPrice { get; set; }
        public double? InvoiceUnitListPrice { get; set; }
        public double TaxRate { get; set; }
        public char TaxCategoryCode { get; set; }
        public double TaxAmount { get; set; }
        public double NetAmount { get; set; }
        public double GrossAmount { get; set; }
    }
}
