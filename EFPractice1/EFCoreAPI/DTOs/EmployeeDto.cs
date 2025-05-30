using EFCoreAPI.Models;

namespace EFCoreAPI.DTOs
{
    public class EmployeeDto
    {
        public int EmployeeId { get; set; }

        public string Name { get; set; } = null!;

        public int? Age { get; set; }

        public DepartmentDto Department { get; set; }
    }
}
