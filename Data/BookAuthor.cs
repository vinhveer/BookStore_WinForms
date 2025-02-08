using System;
using System.Collections.Generic;

namespace BookStore.Data;

public partial class BookAuthor
{
    public long AuthorId { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public virtual ICollection<Book> Books { get; set; } = new List<Book>();

    public string FullName => $"{FirstName} {LastName}";
}
