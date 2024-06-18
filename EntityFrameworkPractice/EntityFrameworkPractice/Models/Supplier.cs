using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EntityFrameworkPractice.Models
{
    public class Supplier
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string GLN { get; set; } = null!;
        public string TaxID { get; set; } = null!;
        public string? AccountNumber { get; set; }
        public string? CodeByBuyer { get; set; }
        public string? PublicAreaName { get; set; }
        public string? CityName { get; set; }
        public string? PostalCode { get; set; }
        public string? Country { get; set; }
    }
}
