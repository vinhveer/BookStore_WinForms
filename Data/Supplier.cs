using System;
using System.Collections.Generic;

namespace BookStore.Data;

public partial class Supplier
{
    public long SupplierId { get; set; }

    public string SupplierName { get; set; } = null!;

    public string SupplierAddress { get; set; } = null!;

    public string ContactEmail { get; set; } = null!;

    public string ContactPhone { get; set; } = null!;

    public virtual ICollection<Book> Books { get; set; } = new List<Book>();
}
