namespace EF6CodeFirstNewDatabase.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EF6CodeFirstNewDatabase.AppDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(EF6CodeFirstNewDatabase.AppDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.


            context.Departments.AddOrUpdate(
                d => d.DeptName,
                new Department { DeptName = "Human Resources" },
                new Department { DeptName = "Engineering" }
                );

            context.SaveChanges();

            context.Employees.AddOrUpdate(
                e => e.Id,
                new Employee
                {
                    Name = "Jhon",
                    DeptId = context.Departments.Single(d => d.DeptName == "Human Resources").Id,
                    Age = 27
                },
                new Employee
                {
                    Name = "Jane",
                    DeptId = context.Departments.Single(d => d.DeptName == "Engineering").Id,
                    Age = 29
                },
                new Employee
                {
                    Name = "Bob",
                    DeptId = context.Departments.Single(d => d.DeptName == "Engineering").Id,
                    Age = 76
                },
                new Employee
                {
                    Name = "Kane",
                    DeptId = context.Departments.Single(d => d.DeptName == "Human Resources").Id,
                    Age = 54
                }
            );
        }
    }
}
