using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkPractice.Models
{
    public class OrderItem
    {
        public int Id { get; set; }
        public string EAN { get; set; } = null!;
        public string? BuyerItemCode { get; set; }
        public string? SupplierItemCode { get; set; }
        public string? ProductGroupCode { get; set; }
        public string ItemDescription { get; set; } = null!;
        public string ItemType { get; set; } = null!;
        public int OrderQuantity { get; set; }
        public int? OrderUnitPacksize { get; set; }
        public string UnitOfMeasure { get; set; } = null!;
        public double OrderUnitNetPrice { get; set; }
        public double? OrderUnitPackSize { get; set; }

    }
}
