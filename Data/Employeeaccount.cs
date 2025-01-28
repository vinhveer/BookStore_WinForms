using System;
using System.Collections.Generic;

namespace BookStore.Data;

public partial class Employeeaccount
{
    public long EmployeeId { get; set; }

    public string EmployeeUsername { get; set; } = null!;

    public string EmployeePassword { get; set; } = null!;

    public virtual Employee Employee { get; set; } = null!;
}
