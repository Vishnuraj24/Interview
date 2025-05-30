using System.Diagnostics;
using DatabaseFirstApproach.Models;
using Microsoft.AspNetCore.Mvc;

namespace DatabaseFirstApproach.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DemoContext _demoContext;

        public HomeController(ILogger<HomeController> logger, DemoContext demoContext)
        {
            _logger = logger;
            _demoContext = demoContext;
        }

        public IActionResult Index()
        {
            var employeelist = _demoContext.EmployeesData.ToList();
            return View(employeelist);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
