using EmployeeAPI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        static List<Employee> Employeelist = new List<Employee>()
        {
            new Employee() {Id = 1,Name="Vishnuraj", Department ="HR"},
            new Employee() {Id = 2,Name="Ram", Department ="IT"},
            new Employee() {Id = 3,Name="Som", Department ="HR"},
            new Employee() {Id = 4,Name="Shiva", Department ="IT"},
            new Employee() {Id = 5,Name="Antony", Department ="HR"}
        };

        //[HttpGet]
        //public IActionResult GetEmployees()
        //{
        //    return Ok(Employeelist);

        //}

        [HttpPost]
        public IActionResult AddEmployee(Employee employee)
        {
            employee.Id = Employeelist.Max(x => x.Id + 1);
            Employeelist.Add(employee);
            return Ok(employee);
        }


        [HttpGet]
        public IActionResult GetPaginatedEmployees(int page = 1, int pageSize = 5, 
            string? search = null, string? department = null) {

            for (int i = Employeelist.Count; i <= 50; i++) // simulate data
            {
                Employeelist.Add(new Employee
                {
                    Id = i,
                    Name = $"Employee {i}",
                    Department = i%2 == 0 ? "HR" : "IT" 
                });

            }

            //declare a IEnumerable to send the filtered data.
            var allEmployees = new List<Employee>();
            allEmployees = Employeelist;

            //search by name
            if (!string.IsNullOrEmpty(search))
            {
                allEmployees = Employeelist
                    .Where(e => e.Name.Contains(search,StringComparison.OrdinalIgnoreCase))
                    .ToList();
            }

            //Filter by department
            if (!string.IsNullOrEmpty(department)) { 
                allEmployees = Employeelist
                    .Where(e => e.Department.Equals(department,StringComparison.OrdinalIgnoreCase)) 
                    .ToList();
            }

            //var PagedData = Employeelist.Skip((page - 1) * pageSize)
            //                           .Take(pageSize)
            //                           .ToList();

            //sorting -- need to implement

            //changing the Employeelist to allEmployees
            var PagedData = allEmployees.Skip((page - 1) * pageSize)
                                       .Take(pageSize)
                                       .ToList();

            var result = new PaginatedResult<Employee>
            {
                Items = PagedData,
                TotalCount = Employeelist.Count

            };

            return Ok(result);

        }

    }
}
