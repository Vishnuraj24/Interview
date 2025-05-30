using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples
{
    //Demonstration of the Single Responsibility Principle ( 1 Class = 1 Responsibility)
    class Employee
    {
        public void SaveToDatabase(){ /* logic for saving to the database */}

        public void GenerateReport() { /* logic for generating the reports */ }


        /* The above class is having the two responsibilities so split it in to the two classes */

    }

    //With SRP principle followed and 1 class = 1 Responsibility
    class Employees
    {
        public string Name { get; set; }
    }

    class EmployeeRepository
    {
        public void SaveToDatabase() { /* LOGIC */ }

    }

    class GenearateEmployeeReports
    {
        public void GenerateReport() { /* LOGIC */ }
    }
}
