
using EF6.Models;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace EF6.Controllers
{
    public class EmployeeViewModel
    {
        public List<EmployeeDto> Employees { get; set; }
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; } 

        public string Search { get;set; }   
        public string sortColumn { get; set; }
        public bool sortAscending { get; set; }

    
    }
    public class HomeController : Controller
    {
        public async Task<ActionResult> Index(int page = 1,int pageSize = 5,string sortColumn = "Id",bool SortAscending = true,string search="")
        {
            using (var context = new AppDbContext()) {

                var query = context.Employees
                    .Include("Department")
                    .Select(e => new EmployeeDto
                    {
                        EmployeeId = e.EmployeeId,
                        Name = e.Name,
                        Age = e.Age,
                        Department = new DepartmentDto
                        {
                            DepartmentId = e.Department.DepartmentId,
                            DepartmentName = e.Department.DepartmentName
                        }

                    });

                switch (sortColumn)
                {
                    case "Name":
                        query = SortAscending ? query.OrderBy(e => e.Name) : query.OrderByDescending(e => e.Name);
                        break;

                    default:
                        query = SortAscending ? query.OrderBy(e => e.EmployeeId) : query.OrderByDescending(e => e.EmployeeId);
                        break;
                }

                if (!search.IsNullOrWhiteSpace())
                {
                    query = query.Where(e => e.Name.Contains(search));
                }

                int totalRecords = await query.CountAsync();
                int totalPages = (int)Math.Ceiling((totalRecords / (double)pageSize));

                var employees = await query
                    
                    .Skip((page - 1)*pageSize)
                    .Take(pageSize)
                    .ToListAsync();
                    

                var viewmodel = new EmployeeViewModel()
                {
                    Employees = employees,
                    CurrentPage = page,
                    TotalPages = totalPages,
                    sortColumn = sortColumn,
                    sortAscending = SortAscending,
                    Search = search
                };


                return View(viewmodel);
                
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