using System;
using System.Collections.Generic;

namespace BookStore.Data;

public partial class Employee
{
    public long EmployeeId { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public DateTime DateOfBirth { get; set; }

    public string Gender { get; set; } = null!;

    public string EmployeeEmail { get; set; } = null!;

    public string EmployeePhone { get; set; } = null!;

    public string EmployeeAddress { get; set; } = null!;

    public string RoleName { get; set; } = null!;

    public DateTime HireDate { get; set; }

    public virtual Employeeaccount? Employeeaccount { get; set; }

    public virtual ICollection<Invoice> Invoices { get; set; } = new List<Invoice>();
}
