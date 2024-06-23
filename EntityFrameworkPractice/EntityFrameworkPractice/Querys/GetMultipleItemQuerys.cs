using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFrameworkPractice.Data;
using EntityFrameworkPractice.Models;

namespace EntityFrameworkPractice.Querys
{
    public class GetMultipleItemQuerys
    {
        public static List<Order> GetOrdersFormConnection(Retailer baseRetailer, Supplier baseSupplier)
        {
            using TrackerContext context = new TrackerContext();
            return context.Orders.Where(x => x.RetailerFK == baseRetailer.Id && x.SupplierILN == baseSupplier.GLN).ToList();
        }
        public static List<Invoice> GetInvoicesFromConnection(Retailer baseRetailer, Supplier baseSupplier)
        {
            using TrackerContext context = new TrackerContext();
            return context.Invoices.Where(x => x.SupplierFK == baseSupplier.Id && x.RetailerILN == baseRetailer.GLN).ToList();
        }
    }
}
