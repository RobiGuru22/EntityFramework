using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFrameworkPractice.Data;
using EntityFrameworkPractice.Models;

namespace EntityFrameworkPractice
{
    public class GetSingleItemQuerys
    {
        public static Retailer? GetRetailerByGLN(string gln)
        {
            using TrackerContext context = new TrackerContext();
            return context.Retailers.Where(x => x.GLN == gln).FirstOrDefault();
        }
        public static Supplier? GetSupplierByGLN(string gln)
        {
            using TrackerContext context = new TrackerContext();
            return context.Suppliers.Where(x => x.GLN == gln).FirstOrDefault();
        }
        public static Order? GetOrderByNumber(string orderNumber)
        {
            using TrackerContext context = new TrackerContext();
            return context.Orders.Where(x => x.OrderNumber == orderNumber).FirstOrDefault();
        }
        public static Invoice? GetInvoiceByNumber(string invoiceNumber)
        {
            using TrackerContext context = new TrackerContext();
            return context.Invoices.Where(x => x.InvoiceNumber == invoiceNumber).FirstOrDefault();
        }
    }
}
