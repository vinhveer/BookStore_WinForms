using System;
using System.Collections.Generic;

namespace BookStore.Data;

public partial class Invoicedetail
{
    public long BookId { get; set; }

    public long InvoiceId { get; set; }

    public long OrderedQuantity { get; set; }

    public virtual Book Book { get; set; } = null!;

    public virtual Invoice Invoice { get; set; } = null!;
}
