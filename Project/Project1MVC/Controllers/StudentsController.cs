using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ProjectAPI.Models;
using System.Text;

namespace Project1MVC.Controllers
{
    public class StudentsController : Controller
    {
        private readonly string url = "https://localhost:44362/api/StudentsAPI/";
        private HttpClient client = new HttpClient();
        [HttpGet]
        public IActionResult Index()
        {
            List<Student> students = new List<Student>();
            HttpResponseMessage response = client.GetAsync(url).Result;
            if (response.IsSuccessStatusCode)
            {
                string result = response.Content.ReadAsStringAsync().Result;
                var data = JsonConvert.DeserializeObject<List<Student>>(result);
                if (data != null) { 
                    students = data;
                }
            }
            return View(students);
        }

        [HttpGet]
        public IActionResult Create()
        {
            Student student = new Student();

            return View();
        }

        [HttpPost]
        public IActionResult Create(Student student)
        {
            string data = JsonConvert.SerializeObject(student);
            StringContent content = new StringContent(data,Encoding.UTF8,"application/json");
            HttpResponseMessage httpResponse = client.PostAsync(url, content).Result;
            if (httpResponse.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }

            return View();
        }
    }
}
