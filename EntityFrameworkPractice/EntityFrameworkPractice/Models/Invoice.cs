using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkPractice.Models;

public class Invoice
{
    public int Id { get; set; }
    public string InvoiceNumber { get; set; } = null!;
    public DateTime InvoiceCreationDate { get; set; }
    public DateTime? TransactionDate { get; set; }
    public DateTime? PaymentDate { get; set; }
    public string InvoiceCurrency { get; set; } = null!;
    public string PaymentType { get; set; } = null!;
    public string InvoiceType { get; set; } = null!;
    public string? Remarks { get; set; }
    public int RetailerId { get; set; }
    public int SupplierId { get; set; }
    public Retailer Retailer { get; set; } = null!;
    public Supplier Supplier { get; set; } = null!;
    public double TaxAmount { get; set; }
    public double ForeignCurrencyRate { get; set; }
    public int OrderId { get; set; }
    public Order Order { get; set; } = null!;
    public ICollection<InvoiceItem> InvoiceItems { get; set; } = null!;
}
