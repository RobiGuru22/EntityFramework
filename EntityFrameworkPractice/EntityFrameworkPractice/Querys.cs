using EntityFrameworkPractice.Data;
using EntityFrameworkPractice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkPractice
{
    public class Querys
    {
        public static void InsertSupplier(Supplier supplier)
        {
            using TrackerContext context = new TrackerContext();
            context.Suppliers.Add(supplier);
            context.SaveChanges();
        }
        public static void RemoveSupplier(Supplier supplier)
        {
            using TrackerContext context = new TrackerContext();
            context.Suppliers.Remove(supplier);
            context.SaveChanges();
        }
    }
}
