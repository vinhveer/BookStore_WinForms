using System;
using System.Collections.Generic;

namespace BookStore.Data;

public partial class Book
{
    public long BookId { get; set; }

    public long SupplierId { get; set; }

    public long AuthorId { get; set; }

    public long CategoryId { get; set; }

    public string BookName { get; set; } = null!;

    public string Unit { get; set; } = null!;

    public int StockQuantity { get; set; }

    public decimal Price { get; set; }

    public DateTime PublicationDate { get; set; }

    public string BookImage { get; set; } = null!;

    public virtual BookAuthor Author { get; set; } = null!;

    public virtual Category Category { get; set; } = null!;

    public virtual ICollection<Invoicedetail> Invoicedetails { get; set; } = new List<Invoicedetail>();

    public virtual Supplier Supplier { get; set; } = null!;
}
