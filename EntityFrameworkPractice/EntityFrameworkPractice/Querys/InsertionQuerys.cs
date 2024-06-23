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
            
            if (context.Suppliers.Where(x => x.GLN == supplier.GLN).FirstOrDefault() is Supplier)
            {
                Console.WriteLine("Nono");
                return;
            }
            context.Suppliers.Add(supplier);
            context.SaveChanges();
        }
        public static void InsertRetailer(Retailer retailer)
        {
            using TrackerContext context = new TrackerContext();
            if(context.Retailers.Where(x => x.GLN == retailer.GLN).FirstOrDefault() is Retailer)
            {
                Console.WriteLine("Nono");
                return;
            }
            context.Retailers.Add(retailer);
            context.SaveChanges();
        }
        public static void InsertInvoice(Invoice invoice, Supplier baseSupplier, Order referenceOrder)
        {
            using TrackerContext context = new TrackerContext();
            invoice.SupplierFK = baseSupplier.Id;
            invoice.OrderFK = referenceOrder.Id;
            context.Invoices.Add(invoice);
            context.SaveChanges();
        }
        public static void InsertOrder(Order order, Retailer baseRetailer)
        {
            using TrackerContext context = new TrackerContext();
            order.RetailerFK = baseRetailer.Id;
            context.Orders.Add(order);
            context.SaveChanges();
        }
        public static void InsertOrderItem(OrderItem orderItem, Order referenceOrder)
        {
            using TrackerContext context = new TrackerContext();
            orderItem.OrderFK = referenceOrder.Id;
            context.OrderItems.Add(orderItem);
            context.SaveChanges();
        }
        public static void InsertInvoiceItem(InvoiceItem invoiceItem, Invoice referenceInvoice)
        {
            using TrackerContext context = new TrackerContext();
            invoiceItem.InvoiceFK = referenceInvoice.Id;
            context.InvoiceItems.Add(invoiceItem);
            context.SaveChanges();
        }
    }
}
