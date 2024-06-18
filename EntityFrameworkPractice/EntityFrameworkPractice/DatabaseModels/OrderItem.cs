using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFrameworkPractice.Models
{
    public class OrderItem
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Order")]
        public int OrderFK { get; set; }
        public Order Order { get; set; } = null!;
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
    }
}
