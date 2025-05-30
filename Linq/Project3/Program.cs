// Create dummy Employee data (10 records)
using Project3;

List<Employee> employees = new List<Employee>
            {
                new Employee(101, 1, "Alice", "Smith", "alice.s@example.com", "123-456-7890"),
                new Employee(102, 2, "Bob", "Johnson", "bob.j@example.com", "098-765-4321"),
                new Employee(103, 2, "Charlie", "Brown", "charlie.b@example.com", "555-111-2222"),
                new Employee(104, 3, "Diana", "Miller", "diana.m@example.com", "555-333-4444"),
                new Employee(105, 2, "Eve", "Davis", "eve.d@example.com", "111-222-3333"),
                new Employee(106, 3, "Frank", "White", "frank.w@example.com", "222-333-4444"),
                new Employee(107, 4, "Grace", "Taylor", "grace.t@example.com", "777-888-9999"),
                new Employee(108, 2, "Henry", "Wilson", "henry.w@example.com", "333-444-5555"),
                new Employee(109, 1, "Ivy", "Moore", "ivy.m@example.com", "666-777-8888"),
                new Employee(110, 4, "Jack", "Hall", "jack.h@example.com", "999-000-1111")
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
        employee.Id,
        employee.FirstName,
        employee.LastName,
        department.DeptName,
        employee.Email,
        employee.Phone
    }
    ).Select(x => new
    {
        employeeId = x.Id,
        employeeName = x.FirstName + " " + x.LastName,
        employeeEmail = x.Email,
        deptName = x.DeptName
    }).OrderByDescending(x => x.employeeName);

foreach(var item in groupresult)
{
    Console.WriteLine($"EmployeeId: {item.employeeId} - " +
        $"EmployeeName: {item.employeeName} - " +
        $"Email: {item.employeeEmail} - " +
        $"Department: {item.deptName}");
}