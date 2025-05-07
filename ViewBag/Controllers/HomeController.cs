using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using ViewBag.Models;

namespace ViewBag.Controllers
{
    public class HomeController : Controller
    {
       
        public IActionResult Index()
        {
            ViewBag.Title = "Home";
            ViewData["Key"] = "Vishnuraj";
            TempData["success"] = "This is the success message";
            return View();
        }

        public IActionResult Privacy()
        {
            string str = (string)ViewData["Key"];
            string str2 = ViewBag.Title;
            //string temp = (string)TempData["success"];
            return View();

        }

        public IActionResult Success()
        {
            string temp = (string)TempData["success"];

            return View();
        }

        
    }
}
