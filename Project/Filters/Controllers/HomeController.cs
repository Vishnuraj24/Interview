using Filters.Filters;
using Filters.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;


namespace Filters.Controllers
{
    public class HomeController : Controller
    {
        [LogActionAttribute]
       public IActionResult Login()
        {
            return View();

        }
        [HttpPost]

        public IActionResult Login(User user)
        {
            
            if(user.Username == "Admin" && user.Password == "Password")
            {
                HttpContext.Session.SetString("Username",user.Username);
                TempData["Success"] = "Login Successfull";
                return RedirectToAction("Dashboard");
            }
            else
            {
                ViewBag.Message = "Invalid Login";
                return View();
            }
            //return View();
        }
        [MyAuthorizationAttribute]
        public IActionResult DashBoard() 
        {

            return View();
        }

        public ActionResult Logout()
        {
            HttpContext.Session.Clear(); // Clear session on logout
            return RedirectToAction("Login");
        }

        [ServiceFilter(typeof(MyExceptionAttrribute))]
        public IActionResult Error()
        {
            throw new Exception("Something went wrong");
        }
       
    }
}
