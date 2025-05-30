using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace CodeFirstApproach.Models
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public required string EmployeeName { get; set; } 
        public int Age { get; set; }
        public required string Department { get; set; }
        public double Salary{ get; set; }
    }
}
