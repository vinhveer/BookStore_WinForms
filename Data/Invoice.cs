using System;
using System.Collections.Generic;

namespace BookStore.Data;

public partial class Invoice
{
    public long InvoiceId { get; set; }

    public long EmployeeId { get; set; }

    public DateTime PaymentDate { get; set; }

    public long CustomerId { get; set; }

    public string PaymentStatus { get; set; } = null!;

    public long TotalAmount { get; set; }

    public virtual Customer Customer { get; set; } = null!;

    public virtual Employee Employee { get; set; } = null!;

    public virtual ICollection<Invoicedetail> Invoicedetails { get; set; } = new List<Invoicedetail>();
}
