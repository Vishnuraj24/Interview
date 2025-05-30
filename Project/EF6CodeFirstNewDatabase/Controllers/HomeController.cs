using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EF6CodeFirstNewDatabase.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            using (var context = new AppDbContext())
            {
                var employees = context.Employees.Include("Department").ToList();
                return View(employees);
            }
            
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}