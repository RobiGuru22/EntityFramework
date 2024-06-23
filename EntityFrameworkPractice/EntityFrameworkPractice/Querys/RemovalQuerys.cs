using EntityFrameworkPractice.Data;
using EntityFrameworkPractice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkPractice
{
    public class RemovalQuerys
    {
        public static void RemoveSupplier(string checkGLN)
        {
            using TrackerContext context = new TrackerContext();
            var removable = context.Suppliers.Where(x => x.GLN == checkGLN).FirstOrDefault();
            if (!(removable is Supplier))
            {
                Console.WriteLine("Nono");
                return;
            }
            context.Suppliers.Remove(removable);
            context.SaveChanges();
        }

        public static void RemoveRetailer(string checkGLN)
        {
            using TrackerContext context = new TrackerContext();
            var removable = context.Retailers.Where(x => x.GLN == checkGLN).FirstOrDefault();
            if (!(removable is Retailer))
            {
                Console.WriteLine("Nono");
                return;
            }
            context.Retailers.Remove(removable);
            context.SaveChanges();
        }
        public static void RemoveInvoice(Invoice invoice)
        {
            using TrackerContext context = new TrackerContext();
            context.Invoices.Remove(invoice);
            context.SaveChanges();
        }
        public static void RemoveOrder(Order order)
        {
            using TrackerContext context = new TrackerContext();
            context.Orders.Remove(order);
            context.SaveChanges();
        }
    }
}
