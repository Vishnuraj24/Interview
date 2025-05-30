
using Project2;

var employees = new List<Employee>
{
    new Employee()
    {
        Id = 1,
        Name = "Ram",
        DeptId = 1
    },
    new Employee()
    {
        Id = 2,
        Name = "Abhay",
        DeptId = 2
    },
    new Employee()
    {
        Id = 3,
        Name = "Shoban",
        DeptId = 3
    },
    new Employee()
    {
        Id = 4,
        Name = "Shiva",
        DeptId = 4
    },
    new Employee()
    {
        Id = 5,
        Name = "emp1",
        DeptId = 1
    },
    new Employee()
    {
        Id = 6,
        Name = "emp2",
        DeptId = 2
    },
    new Employee()
    {
        Id = 7,
        Name = "emp3",
        DeptId = 3
    },
    new Employee()
    {
        Id = 8,
        Name = "emp4",
        DeptId = 4
    }
};


var departments = new List<Department>
{
    new Department()
    {
        DeptId = 1,
        DeptName = "HR"
    },
     new Department()
    {
        DeptId = 2,
        DeptName = "IT"
    },
      new Department()
    {
        DeptId = 3,
        DeptName = "ENG"
    },
       new Department()
    {
        DeptId = 4,
        DeptName = "SUPP"
    }

};

var groupresult = employees.Join(
    departments,
    employee => employee.DeptId,
    department => department.DeptId,
    (employee,department) => new
    {
        employee.Name,
        department.DeptName
    }
).GroupBy(x => x.DeptName);

foreach(var group in groupresult)
{
    Console.WriteLine($"Group Name: {group.Key}");
    foreach(var emp in group)
    {
        Console.WriteLine($" -{emp.Name}");
    }
}

