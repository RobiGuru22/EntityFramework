using System;
using System.Collections.Generic;
using EntityFrameworkPractice.DatabaseAccess;
using EntityFrameworkPractice.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkPractice.Data;

public partial class TrackerContext : DbContext
{
    public TrackerContext()
    {
    }

    public TrackerContext(DbContextOptions<TrackerContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Invoice> Invoices { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(CnnHelper.GetCnnString("MyServer"));
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
