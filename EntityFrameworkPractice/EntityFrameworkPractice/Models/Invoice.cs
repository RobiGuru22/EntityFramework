using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkPractice.Models;

[Keyless]
public partial class Invoice
{
    [Column("id")]
    public int? Id { get; set; }

    public int? InvoiceNumber { get; set; }

    public string? TestSample { get; set; }
}
