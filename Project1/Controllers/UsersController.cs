using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project1.Models;

namespace Project1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        public List<User> users = new List<User>
        {
            new User()
            {
                Id = 1,
                Name = "Admin",
                Password = "password123"
            },
            new User() {
                Id = 2,
                Name = "Vishnuraj",
                Password = "password"
            }
        };

        [HttpPost("{username}/{password}")]
        public ActionResult Login(string username,string password)
        {
            var u = users.FirstOrDefault(x => x.Name == username && x.Password == password);
            if(u == null)
            {
                return Unauthorized("Invalid username or Password");
            }
            return Ok($"Login Successful : {u.Name}");
        }
        

    }
}
