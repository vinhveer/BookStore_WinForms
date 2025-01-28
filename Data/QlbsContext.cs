using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Data;

public partial class QlbsContext : DbContext
{
    public QlbsContext()
    {
    }

    public QlbsContext(DbContextOptions<QlbsContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Book> Books { get; set; }

    public virtual DbSet<BookAuthor> BookAuthors { get; set; }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<Employeeaccount> Employeeaccounts { get; set; }

    public virtual DbSet<Invoice> Invoices { get; set; }

    public virtual DbSet<Invoicedetail> Invoicedetails { get; set; }

    public virtual DbSet<Supplier> Suppliers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-QDP6VSH\\VINHNQ;Initial Catalog=QLBS;Integrated Security=True;Trust Server Certificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Book>(entity =>
        {
            entity.ToTable("BOOK");

            entity.Property(e => e.BookId).HasColumnName("BOOK_ID");
            entity.Property(e => e.AuthorId).HasColumnName("AUTHOR_ID");
            entity.Property(e => e.BookImage)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("BOOK_IMAGE");
            entity.Property(e => e.BookName)
                .HasMaxLength(100)
                .HasColumnName("BOOK_NAME");
            entity.Property(e => e.CategoryId).HasColumnName("CATEGORY_ID");
            entity.Property(e => e.Price)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("PRICE");
            entity.Property(e => e.PublicationDate)
                .HasColumnType("datetime")
                .HasColumnName("PUBLICATION_DATE");
            entity.Property(e => e.StockQuantity).HasColumnName("STOCK_QUANTITY");
            entity.Property(e => e.SupplierId).HasColumnName("SUPPLIER_ID");
            entity.Property(e => e.Unit)
                .HasMaxLength(30)
                .HasColumnName("UNIT");

            entity.HasOne(d => d.Author).WithMany(p => p.Books)
                .HasForeignKey(d => d.AuthorId)
                .HasConstraintName("FK_BOOK_BELONGTOB_BOOK_AUT");

            entity.HasOne(d => d.Category).WithMany(p => p.Books)
                .HasForeignKey(d => d.CategoryId)
                .HasConstraintName("FK_BOOK_HAS_CATEGORY");

            entity.HasOne(d => d.Supplier).WithMany(p => p.Books)
                .HasForeignKey(d => d.SupplierId)
                .HasConstraintName("FK_BOOK_PROVIDEDB_SUPPLIER");
        });

        modelBuilder.Entity<BookAuthor>(entity =>
        {
            entity.HasKey(e => e.AuthorId);

            entity.ToTable("BOOK_AUTHOR");

            entity.Property(e => e.AuthorId).HasColumnName("AUTHOR_ID");
            entity.Property(e => e.FirstName)
                .HasMaxLength(30)
                .HasColumnName("FIRST_NAME");
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .HasColumnName("LAST_NAME");
        });

        modelBuilder.Entity<Category>(entity =>
        {
            entity.ToTable("CATEGORY");

            entity.Property(e => e.CategoryId).HasColumnName("CATEGORY_ID");
            entity.Property(e => e.CategoryName)
                .HasMaxLength(100)
                .HasColumnName("CATEGORY_NAME");
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.ToTable("CUSTOMER");

            entity.Property(e => e.CustomerId).HasColumnName("CUSTOMER_ID");
            entity.Property(e => e.CustomerAddress)
                .HasMaxLength(255)
                .HasColumnName("CUSTOMER_ADDRESS");
            entity.Property(e => e.CustomerEmail)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CUSTOMER_EMAIL");
            entity.Property(e => e.CustomerPhone)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("CUSTOMER_PHONE");
            entity.Property(e => e.DateOfBirth)
                .HasColumnType("datetime")
                .HasColumnName("DATE_OF_BIRTH");
            entity.Property(e => e.FirstName)
                .HasMaxLength(30)
                .HasColumnName("FIRST_NAME");
            entity.Property(e => e.Gender)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("GENDER");
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .HasColumnName("LAST_NAME");
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.ToTable("EMPLOYEE");

            entity.Property(e => e.EmployeeId).HasColumnName("EMPLOYEE_ID");
            entity.Property(e => e.DateOfBirth)
                .HasColumnType("datetime")
                .HasColumnName("DATE_OF_BIRTH");
            entity.Property(e => e.EmployeeAddress)
                .HasMaxLength(255)
                .HasColumnName("EMPLOYEE_ADDRESS");
            entity.Property(e => e.EmployeeEmail)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EMPLOYEE_EMAIL");
            entity.Property(e => e.EmployeePhone)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("EMPLOYEE_PHONE");
            entity.Property(e => e.FirstName)
                .HasMaxLength(30)
                .HasColumnName("FIRST_NAME");
            entity.Property(e => e.Gender)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("GENDER");
            entity.Property(e => e.HireDate)
                .HasColumnType("datetime")
                .HasColumnName("HIRE_DATE");
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .HasColumnName("LAST_NAME");
            entity.Property(e => e.RoleName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ROLE_NAME");
        });

        modelBuilder.Entity<Employeeaccount>(entity =>
        {
            entity.HasKey(e => e.EmployeeId);

            entity.ToTable("EMPLOYEEACCOUNT");

            entity.HasIndex(e => e.EmployeeUsername, "UQ__EMPLOYEE__3FCE21EC6C3A0676").IsUnique();

            entity.Property(e => e.EmployeeId)
                .ValueGeneratedNever()
                .HasColumnName("EMPLOYEE_ID");
            entity.Property(e => e.EmployeePassword)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EMPLOYEE_PASSWORD");
            entity.Property(e => e.EmployeeUsername)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EMPLOYEE_USERNAME");

            entity.HasOne(d => d.Employee).WithOne(p => p.Employeeaccount)
                .HasForeignKey<Employeeaccount>(d => d.EmployeeId)
                .HasConstraintName("FK_EMPLOYEE_HASEMPLOY_EMPLOYEE");
        });

        modelBuilder.Entity<Invoice>(entity =>
        {
            entity.ToTable("INVOICE");

            entity.Property(e => e.InvoiceId).HasColumnName("INVOICE_ID");
            entity.Property(e => e.CustomerId).HasColumnName("CUSTOMER_ID");
            entity.Property(e => e.EmployeeId).HasColumnName("EMPLOYEE_ID");
            entity.Property(e => e.PaymentDate)
                .HasColumnType("datetime")
                .HasColumnName("PAYMENT_DATE");
            entity.Property(e => e.PaymentStatus)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("PAYMENT_STATUS");
            entity.Property(e => e.TotalAmount).HasColumnName("TOTAL_AMOUNT");

            entity.HasOne(d => d.Customer).WithMany(p => p.Invoices)
                .HasForeignKey(d => d.CustomerId)
                .HasConstraintName("FK_INVOICE_CUSTOMER");

            entity.HasOne(d => d.Employee).WithMany(p => p.Invoices)
                .HasForeignKey(d => d.EmployeeId)
                .HasConstraintName("FK_INVOICE_ISSUEDBYE_EMPLOYEE");
        });

        modelBuilder.Entity<Invoicedetail>(entity =>
        {
            entity.HasKey(e => new { e.BookId, e.InvoiceId }).HasName("PK__INVOICED__9583B6143AEC73D8");

            entity.ToTable("INVOICEDETAIL");

            entity.Property(e => e.BookId).HasColumnName("BOOK_ID");
            entity.Property(e => e.InvoiceId).HasColumnName("INVOICE_ID");
            entity.Property(e => e.OrderedQuantity).HasColumnName("ORDERED_QUANTITY");

            entity.HasOne(d => d.Book).WithMany(p => p.Invoicedetails)
                .HasForeignKey(d => d.BookId)
                .HasConstraintName("FK_INVOICEDETAIL_BOOK");

            entity.HasOne(d => d.Invoice).WithMany(p => p.Invoicedetails)
                .HasForeignKey(d => d.InvoiceId)
                .HasConstraintName("FK_INVOICEDETAIL_INVOICE");
        });

        modelBuilder.Entity<Supplier>(entity =>
        {
            entity.ToTable("SUPPLIER");

            entity.Property(e => e.SupplierId).HasColumnName("SUPPLIER_ID");
            entity.Property(e => e.ContactEmail)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CONTACT_EMAIL");
            entity.Property(e => e.ContactPhone)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("CONTACT_PHONE");
            entity.Property(e => e.SupplierAddress)
                .HasMaxLength(255)
                .HasColumnName("SUPPLIER_ADDRESS");
            entity.Property(e => e.SupplierName)
                .HasMaxLength(100)
                .HasColumnName("SUPPLIER_NAME");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
