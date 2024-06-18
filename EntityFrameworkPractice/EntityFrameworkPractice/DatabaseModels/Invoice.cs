using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkPractice.Models;

public class Invoice
{
    [Key]
    public int Id { get; set; }
    public string InvoiceNumber { get; set; } = null!;
    public DateTime InvoiceCreationDate { get; set; }
    public DateTime? TransactionDate { get; set; }
    public DateTime? PaymentDate { get; set; }
    public string InvoiceCurrency { get; set; } = null!;
    public string PaymentType { get; set; } = null!;
    public string InvoiceType { get; set; } = null!;
    public string? Remarks { get; set; }
    public double TaxAmount { get; set; }
    public double ForeignCurrencyRate { get; set; }
    [ForeignKey("Supplier")]
    public int SupplierFK { get; set; }
    [ForeignKey("Order")]
    public int OrderFK { get; set; }
    public Supplier Supplier { get; set; } = null!;
    public Order Order { get; set; } = null!;
    public ICollection<InvoiceItem> InvoiceItems { get; set; } = null!;
}
