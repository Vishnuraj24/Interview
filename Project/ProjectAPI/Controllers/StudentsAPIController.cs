using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using ProjectAPI.Models;

namespace ProjectAPI.Controllers
{
    [Route("api/[controller]")] 
    [ApiController]
    public class StudentsAPIController : ControllerBase
    {
        public static List<Student> studentlist = new List<Student>()
        {
            new Student()
            {
                Id = 1,
                StudentName = "Rahul",
                StudentGender = "Male",
                Age = 14,
                Standard = 8,
                FatherName = "Rajesh Kumar"
            },
            new Student()
            {
                Id = 2,
                StudentName = "Sneha",
                StudentGender = "Female",
                Age = 13,
                Standard = 7,
                FatherName = "Suresh Sharma"
            },
            new Student()
            {
                Id = 3,
                StudentName = "Amit",
                StudentGender = "Male",
                Age = 15,
                Standard = 9,
                FatherName = "Anil Verma"
            },
            new Student()
            {
                Id = 4,
                StudentName = "Priya",
                StudentGender = "Female",
                Age = 12,
                Standard = 6,
                FatherName = "Mahesh Reddy"
            },
            new Student()
            {
                Id = 5,
                StudentName = "Karan",
                StudentGender = "Male",
                Age = 13,
                Standard = 7,
                FatherName = "Vijay Patil"

            }
        };

        [HttpGet]
        public ActionResult<List<Student>> GetStudent()
        {
            return Ok(studentlist);
        }

        [HttpGet("{id}")]
        public ActionResult<Student> GetStudent(int id) {
            var std = studentlist.Find(x => x.Id == id);
            if (std == null) return NotFound();
            return Ok(std);
        }

        [HttpPost]
        public ActionResult<Student> CreateStudent(Student student)
        {
            if (student == null) return BadRequest();

            studentlist.Add(student);
            student.Id = studentlist.Max(s => s.Id) + 1;
            return Ok(student);

        }

        [HttpPut("{id}")]
        public ActionResult<Student> UpdateStudent(int id, Student student)
        {
            var std = studentlist.Find(x => x.Id == id);
            if (std == null) return BadRequest();
            std.StudentName = student.StudentName;
            std.StudentGender = student.StudentGender;
            std.Age = student.Age;
            std.Standard = student.Standard;
            std.FatherName = student.FatherName;
            return Ok(student);
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteStudent(int id)
        {
            if(id == 0) return BadRequest();
            var std = studentlist.Find(x => x.Id ==id);
            if (std == null) return NotFound();
            studentlist.Remove(std);
            return Ok();
        }
    }
}
