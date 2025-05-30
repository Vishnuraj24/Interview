using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace EF6Pagination.Controllers
{
    public class EmployeeDto
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public DepartmentDto Department { get; set; }
    }

    public class DepartmentDto
    {
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
    }

    public class EmployeeViewModel
    {
        public List<EmployeeDto> Employees { get; set; }
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
        public int PageSize { get; set; }
        public string SortColumn { get; set; }
        public bool SortAscending { get; set; }
    }
    public class HomeController : Controller
    {
        public async Task<ActionResult> Index(int page = 1, int pageSize = 5,
             string sortColumn = "EmployeeId", bool sortAscending = true)
        {
            using(var context = new AppDbContext())
            {
                var query = context.Employees
                    .Include("Department")
                    .Select(e => new EmployeeDto
                    {
                        EmployeeId = e.EmployeeId,
                        Name = e.Name,
                        Age = (int)e.Age,
                        Department = new DepartmentDto
                        {
                            DepartmentId = e.Department.DepartmentId,
                            DepartmentName = e.Department.DepartmentName
                        }
                    });

                switch (sortColumn)
                {
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
                    int totalPages = (int)Math.Ceiling((totalRecords / (double)pageSize));

                var employees = await query.Skip((page -1) * pageSize).Take(pageSize).ToListAsync();

                var viewModel = new EmployeeViewModel
                {
                    Employees = employees,
                    CurrentPage = page,
                    TotalPages = totalPages,
                    PageSize = pageSize,
                    SortAscending = sortAscending,
                    SortColumn = sortColumn
                };

                return View(viewModel);

            }
            
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}