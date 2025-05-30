using ADO.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ADO.Controllers
{

    public class EmployeeViewModel
    {
        public List<Employee> Employees { get; set; }
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
        public string sortColumn { get; set; }
        public bool sortDirection { get; set; }
        public string Search {  get; set; }
    }

    public class HomeController : Controller
    {
        public string connstr = "Server=laptop-r713v9qm;Database=Database_110525;Trusted_Connection=true;TrustServerCertificate=true;";

        public ActionResult Index(int page=1,int pageSize = 5,
           string sortColumn = "EmployeeId", bool sortDirection = true, string Search = "")
        {
            int skip = (page - 1) * pageSize;
            sortColumn = sortColumn == "Name" ? "Name" : "EmployeeId";
            string sortMethod = sortDirection ? "ASC" : "DESC";
            string countQuery = @"
                                    SELECT COUNT(*)
                                    FROM Employee e
                                    INNER JOIN Department d ON e.DepartmentId = d.DepartmentId";

            string paginatedQuery = $@"SELECT e.EmployeeId,e.Name,e.Age,e.DepartmentId,d.DepartmentName FROM Employee e
                                    INNER JOIN Department d ON e.DepartmentId = d.DepartmentId
                                    WHERE (@search IS NULL OR e.Name LIKE '%' + @search + '%')
                                    ORDER BY e.{sortColumn} {sortMethod}  
                                    OFFSET @Skip ROWS FETCH NEXT @pageSize ROWS ONLY";
            var employees = new List<Employee>();
            int totalRecords = 0;
            using (var conn = new SqlConnection(connstr))
            {
                conn.Open();
               

                using (var cmd = new SqlCommand(countQuery, conn))
                {
                    
                    totalRecords = (int)cmd.ExecuteScalar();
                }

                using(var datacmd = new SqlCommand(paginatedQuery, conn))
                {
                    datacmd.Parameters.AddWithValue("@Skip", skip);
                    datacmd.Parameters.AddWithValue("@pageSize", 5);
                    datacmd.Parameters.AddWithValue("@Search", string.IsNullOrWhiteSpace(Search)
                                                        ? (object)DBNull.Value
                                                        : Search);
                   

                    using (var reader = datacmd.ExecuteReader())
                    {
                        while (reader.Read()) {
                            employees.Add(new Employee()
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
                sortDirection = sortDirection,
                sortColumn = sortColumn,
                Search = Search

             
            };

            return View(viewModel);

        }

       
    }
}