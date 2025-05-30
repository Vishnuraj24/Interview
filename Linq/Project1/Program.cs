
using Project1;

var students = new List<Student>
{
    new Student { StudentId = 1, StudentName = "Alice" },
    new Student { StudentId = 2, StudentName = "Bob" },
    new Student { StudentId = 3, StudentName = "Charlie" }
};

var grades = new List<Grade>
{
    new Grade { GradeId = 1,StudentId =1,GradeName = "A" },
    new Grade { GradeId = 2,StudentId =2,GradeName = "B" },
    new Grade { GradeId = 3,StudentId =5,GradeName = "A" },
    new Grade { GradeId = 4,StudentId =4,GradeName = "C" }
};

//Join

var result = students.Join(
    grades,
    student => student.StudentId,
    grade => grade.StudentId,
    (student,grade) => new
    {
        student.StudentName,
        grade.GradeName,
    });

foreach (var item in result)
{
    Console.WriteLine($"{item.StudentName} has Grade {item.GradeName}");
}