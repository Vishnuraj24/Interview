using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EF6.Models
{
    public class EmployeeDto
    {
        public int EmployeeId { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public DepartmentDto Department { get; set; }
    }
}