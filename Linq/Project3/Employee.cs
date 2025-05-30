using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    public class Employee
    {
        public int Id { get; set; }
        public int DeptId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public Employee(int id, int deptId, string firstName, string lastName, string email, string phone)
        {
            Id = id;
            DeptId = deptId;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Phone = phone;
        }



    }
}
