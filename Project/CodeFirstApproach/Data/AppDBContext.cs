using CodeFirstApproach.Models;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstApproach.Data
{
    public class AppDBContext:DbContext
    {
        public AppDBContext()
        {
            
        }

        public AppDBContext(DbContextOptions<AppDBContext> options):base(options)
        {
            
        }

        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var employeelist = new List<Employee>();

            for(int i = 1; i < 51; i++)
            {
                employeelist.Add(new Employee
                {
                    EmployeeID = i,
                    EmployeeName = $"Employee{i}",
                    Age = i,
                    Department = i % 2 == 0 ? "HR" : "IT",
                    Salary = i%2==0? 500 * (i) : 200 * (i)
                });
            }


            //seeddata
            modelBuilder.Entity<Employee>().HasData(employeelist);
        }
    }
}
