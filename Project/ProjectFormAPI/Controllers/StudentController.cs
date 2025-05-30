using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectFormAPI.Models;

namespace ProjectFormAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        public static List<Student> studentslist = new List<Student>()
        {
            new Student(){Id=1, Name="Ram", FatherName="Venkat", Age=12, Standard=10},
            new Student(){Id=2, Name="Sita", FatherName="Ramesh", Age=11, Standard=9},
            new Student(){Id=3, Name="Lakshman", FatherName="Suresh", Age=13, Standard=10},
            new Student(){Id=4, Name="Hanuman", FatherName="Anjaneya", Age=12, Standard=10},
            new Student(){Id=5, Name="Bharath", FatherName="Raju", Age=10, Standard=8},
        };

        [HttpGet]
        public ActionResult<List<Student>> GetStudents()
        {
            return Ok(studentslist);
        }
        [HttpGet("{id}")]
        public ActionResult<Student> GetStudents(int id)
        {
            if (studentslist != null)
            {
                Student s = studentslist.Find(x => x.Id == id);

                return Ok(s);

            }

            return NotFound();

        }

        [HttpPost]
        public ActionResult<Student> AddStudent(Student s)
        {
            if (s == null || s.Age == 0 || s.Standard == 0) {
                return BadRequest();
            }
            s.Id = studentslist.Max(x => x.Id + 1);
            studentslist.Add(s);
            return Ok(s);
        }

        [HttpPut("{id}")]
        public ActionResult<Student> UpdateStudent(int id, Student s)
        {
            Student student = studentslist.Find(x => x.Id == id);
            student.Name = s.Name;
            student.Age = s.Age;
            student.Standard = s.Standard;
            student.FatherName = s.FatherName;

            return Ok(student);

        }
        [HttpDelete("{id}")]
        public ActionResult DeleteStudent(int id) {
            Student student = studentslist.Find(x => x.Id == id);
            studentslist.Remove(student);
            return Ok();
        }
    }
}
