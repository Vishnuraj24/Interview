using System;
using System.Collections.Generic;

namespace EFCoreAPI.Models;

public partial class Employee
{
    public int EmployeeId { get; set; }

    public string Name { get; set; } = null!;

    public int? Age { get; set; }

    public int? DepartmentId { get; set; }

    public virtual Department? Department { get; set; }
}
