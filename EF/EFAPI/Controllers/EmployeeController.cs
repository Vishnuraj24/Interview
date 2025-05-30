using EFAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Globalization;

namespace EFAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly Database110525Context _context;
        public EmployeeController(Database110525Context context) { 
            _context = context;
        }

        //[HttpGet]
        //public async Task<IActionResult> GetEmployees()
        //{
        //    var employees = await _context.Employees
        //                    .Include(e => e.Department) // optional if you want navigation properties
        //                    .Select(e => new
        //                    {
        //                        e.EmployeeId,
        //                        e.Name,
        //                        e.Age,
        //                        Department = new
        //                        {
        //                            e.Department.DepartmentId,
        //                            e.Department.DepartmentName
        //                        }
        //                    })
        //                    .ToListAsync();

        //    return Ok(employees);
        //}

        [HttpGet]
        public async Task<IActionResult> GetPaginatedEmployees(int page = 1,int pageSize = 5,
            string sortColumn = "EmployeeId",bool sortAscending = true)
        {
            var query = _context.Employees
                            .Include(e => e.Department) // optional if you want navigation properties
                            .Select(e => new
                            {
                                e.EmployeeId,
                                e.Name,
                                e.Age,
                                Department = new
                                {
                                    e.Department.DepartmentId,
                                    e.Department.DepartmentName
                                }
                            });


            switch (sortColumn) {

                case "DepartmentName":
                    query = sortAscending ? query.OrderBy(e => e.Department.DepartmentName) : query.OrderByDescending(e => e.Department.DepartmentName);
                    break;

                case "Name":
                    query = sortAscending ? query.OrderBy(e => e.Name) : query.OrderByDescending(e => e.Name);
                    break;
                case "Age":
                    query = sortAscending ? query.OrderBy(e => e.Age) : query.OrderByDescending(e => e.Age);
                    break;
                default:
                    query = query.OrderBy(e => e.EmployeeId);
                    break;
            }

            int totalRecords = await query.CountAsync();
            int totalPages = (int)Math.Ceiling(totalRecords / (double)pageSize);

            var employees = await query
                                  .Skip((page - 1) * pageSize)
                                  .Take(pageSize)
                                  .ToListAsync();
            return Ok(employees);
        }
    }
}
