using System;
using System.Collections.Generic;

namespace DatabaseFirstApproach.Models;

public partial class EmployeesDatum
{
    public int EmployeeId { get; set; }

    public string? EmployeeName { get; set; }

    public string? Department { get; set; }

    public int? ManagerId { get; set; }
}
