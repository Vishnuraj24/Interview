using EFCoreAPI.DTOs;
using EFCoreAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Globalization;

namespace EFCoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly Database110525Context _context;
        public EmployeeController(Database110525Context context)
        {
            _context = context;
        }

        //[HttpGet]
        //public async Task<IActionResult> GetEmployees()
        //{
        //    var employees = await _context.Employees
        //        .Include(e => e.Department)
        //        .Select(e => new EmployeeDto()
        //        {
        //            EmployeeId = e.EmployeeId,
        //            Name = e.Name,
        //            Age = e.Age,
        //            Department = new DepartmentDto()
        //            {
        //                DepartmentId = e.Department.DepartmentId,
        //                DepartmentName = e.Department.DepartmentName
        //            }
        //        })
        //        .ToListAsync();
        //    return Ok(employees);
        //}

        [HttpGet]
        public async Task<IActionResult> GetPaginatedResult(int page = 1, int pageSize =5,string sortColumn = "")
        {
            var query = _context.Employees
                .Include(e => e.Department)
                .Select(e => new EmployeeDto()
                {
                    EmployeeId = e.EmployeeId,
                    Name = e.Name,
                    Age = e.Age,
                    Department = new DepartmentDto()
                    {
                        DepartmentId = e.Department.DepartmentId,
                        DepartmentName = e.Department.DepartmentName
                    }
                });

            query = sortColumn.IsNullOrEmpty() ? query : query.OrderBy(e => e.Name);

            int totalRecords = await query.CountAsync();
            int toatalPages = (int)Math.Ceiling(totalRecords / (double)pageSize);

            var employees = await query
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();

            return Ok(employees);   
        }
    }
}
