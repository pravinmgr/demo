using Microsoft.AspNetCore.Mvc;
using PracticePro.Models;
using System.ComponentModel;
using System.Diagnostics;

namespace PracticePro.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {

            return View(GetAll());
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

        public List<Employee> GetAll()
        {
            return new ()
        {
            new Employee { Id = 1, FirstName = "pravn", LastName = "m", Company = "asw", Designation = "wdewew" },
            new Employee { Id = 2, FirstName = "pravn", LastName = "m", Company = "asw", Designation = "wdewew" }
            
        };          
        }

        public ActionResult CustomAjaxBinding_Read()
        {
            
                var result = new
                {
                    Data = GetAll(),
                    Total = 10
                };

                return Json(result);
            
        }
    }
}

