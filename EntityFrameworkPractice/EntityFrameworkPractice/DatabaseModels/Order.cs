using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata.Ecma335;

namespace EntityFrameworkPractice.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public string OrderNumber { get; set; } = null!;
        public string SupplierILN { get; set; } = null!;
        public DateTime OrderCreationDate { get; set; }
        public DateTime? OrderFulfilled { get; set; }
        public string OrderCurrency { get; set; } = null!;
        public string TargetCurrency { get; set; } = null!;
        public DateTime? ExpectedDeliveryDate { get; set; }
        public TimeOnly? ExpectedDeliveryTime { get; set; }
        public string OrderType { get; set; } = null!;
        public string MessageType { get; set; } = null!;
        public string? Remarks { get; set; }
        public string OrderTransport { get; set; } = null!;
        [ForeignKey("Retailer")]
        public int RetailerFK { get; set; }
        public Retailer Retailer { get; set; } = null!;
        public ICollection<OrderItem> OrderItems { get; set; } = null!;

    }
}
