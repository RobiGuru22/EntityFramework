using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFrameworkPractice.Data;
using EntityFrameworkPractice.Models;

namespace EntityFrameworkPractice
{
    public class InsertionQuerys
    {
        public static void InsertSupplier(Supplier supplier)
        {
            using TrackerContext context = new TrackerContext();
            context.Suppliers.Add(supplier);
            context.SaveChanges();
        }
        public static void InsertRetailer(Retailer retailer)
        {
            using TrackerContext context = new TrackerContext();
            context.Retailers.Add(retailer);
            context.SaveChanges();
        }
        public static void InsertInvoice(Invoice invoice)
        {
            using TrackerContext context = new TrackerContext();
            context.Invoices.Add(invoice);
            context.SaveChanges();
        }
        public static void InsertOrder(Order order)
        {
            using TrackerContext context = new TrackerContext();
            context.Orders.Add(order);
            context.SaveChanges();
        }
    }
}
