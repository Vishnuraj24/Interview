using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectFormAPI.Models;

namespace ProjectFormAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class LoginController : ControllerBase
    {
        [HttpPost]
        public ActionResult Login(User user)
        {
            Console.WriteLine("entered in to the login method");
            if (user == null) { 
                return Unauthorized();
            }

            if(user.UserName == "Admin" &&  user.Password == "Password")
            {
                return Ok("Login Successful");
            }

            else
            {
                return NotFound("Invalid Username or Password");
            }
        }
    }
}
