﻿using EntityFrameworkPractice.Data;
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
        public static void RemoveSupplier(Supplier supplier)
        {
            using TrackerContext context = new TrackerContext();
            context.Suppliers.Remove(supplier);
            context.SaveChanges();
        }

        public static void RemoveRetailer(Retailer retailer)
        {
            using TrackerContext context = new TrackerContext();
            context.Retailers.Remove(retailer);
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