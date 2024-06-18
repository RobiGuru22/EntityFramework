using System;
using System.Collections.Generic;
using EntityFrameworkPractice.DatabaseAccess;
using EntityFrameworkPractice.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkPractice.Data;

public partial class TrackerContext : DbContext
{
    public DbSet<Invoice> Invoices { get; set; } = null!;
    public DbSet<InvoiceItem> InvoiceItems { get; set; } = null!;
    public DbSet<Order> Orders { get; set; } = null!;
    public DbSet<OrderItem> OrderItems { get; set; } = null!;
    public DbSet<Retailer> Retailers { get; set; } = null!;
    public DbSet<Supplier> Suppliers { get; set; } = null!;
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(CnnHelper.GetCnnString("MyDB"));
    }
}
