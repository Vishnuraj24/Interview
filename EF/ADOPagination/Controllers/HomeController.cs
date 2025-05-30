using ADOPagination.Models;
using Antlr.Runtime.Tree;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace ADOPagination.Controllers
{
    public class EmployeeViewModel
    {
        public List<Employee> Employees { get; set; }
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
        public int PageSize { get; set; }
        public string SortColumn { get; set; }
        public bool SortAscending { get; set; }
    }
    public class HomeController : Controller
    {
        public string connstr = "Server=laptop-r713v9qm;Database=Database_110525;Trusted_Connection=true;TrustServerCertificate=true;";

        public async Task<ActionResult> Index(int page = 1, int pageSize = 5, string sortColumn = "EmployeeId",bool sortAscending = true)
        {
            int skip = (page - 1) * pageSize;

            // Validate sort column to prevent SQL injection
            sortColumn = sortColumn == "Name" ? "Name" : "DepartmentName";
            string sortDirection = sortAscending ? "ASC" : "DESC";

            string countQuery = @"
            SELECT COUNT(*)
            FROM Employee e
            INNER JOIN Department d ON e.DepartmentId = d.DepartmentId";

            string paginatedQuery = @"SELECT e.EmployeeId,e.Name,e.Age,e.DepartmentId,d.DepartmentName FROM Employee e
                                    INNER JOIN Department d ON e.DepartmentId = d.DepartmentId
                                    ORDER BY " + sortColumn + " " + sortDirection + @"
                                    OFFSET @Skip ROWS FETCH NEXT @pageSize ROWS ONLY";

            var employees = new List<Employee>();
            int totalRecords = 0;

            using (var conn = new SqlConnection(connstr)) { 
                conn.Open();
                using (var cmd = new SqlCommand(countQuery, conn)) {
                    totalRecords = (int) cmd.ExecuteScalar();
                }

                using (var datacmd = new SqlCommand(paginatedQuery, conn)) {
                    datacmd.Parameters.AddWithValue("@Skip", skip);
                    datacmd.Parameters.AddWithValue("@pageSize", 5);
                    using(var reader = datacmd.ExecuteReader()){
                        while (reader.Read()) {
                            employees.Add(new Employee
                            {
                                EmployeeId = reader.GetInt32(reader.GetOrdinal("EmployeeId")),
                                Name = reader.GetString(reader.GetOrdinal("Name")),
                                Age = reader.GetInt32(reader.GetOrdinal("Age")),
                                DepartmentId = reader.GetInt32(reader.GetOrdinal("DepartmentId")),
                                Department = reader.GetString(reader.GetOrdinal("DepartmentName"))

                            });
                        }
                    }

                }



            }

            int totalPages = (int)Math.Ceiling(totalRecords / (double)pageSize);

            // Create view model
            var viewModel = new EmployeeViewModel
            {
                Employees = employees,
                CurrentPage = page,
                TotalPages = totalPages,
                PageSize = pageSize,
                SortColumn = sortColumn,
                SortAscending = sortAscending
            };

            return View(viewModel);
        }

      
    }
}