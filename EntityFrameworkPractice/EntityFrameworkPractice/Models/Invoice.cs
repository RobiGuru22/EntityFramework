using System;
using System.Collections.Generic;

namespace EntityFrameworkPractice.Models;

public partial class Invoice
{
    public int? Id { get; set; }

    public int? InvoiceNumber { get; set; }

    public string? TestSample { get; set; }
}
