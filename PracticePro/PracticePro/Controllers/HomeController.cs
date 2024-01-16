using Kendo.Mvc.UI;
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
            new Employee { Id = 2, FirstName = "prgfgdavnsss", LastName = "am", Company = "jkkksw", Designation = "wdewew" },
             new Employee { Id = 3, FirstName = "gergrpravnsss", LastName = "am", Company = "jkkksw", Designation = "wdewew" },
              new Employee { Id = 4, FirstName = "kjkhpravnsss", LastName = "am", Company = "jkkksw", Designation = "wdewew" },

                 new Employee { Id = 1, FirstName = "pravn", LastName = "m", Company = "asw", Designation = "wdewew" },
            new Employee { Id = 287, FirstName = "prgfgdavnsss", LastName = "am", Company = "jkkksw", Designation = "wdewew" },
             new Employee { Id = 3787, FirstName = "gergrpravnsss", LastName = "am", Company = "jkkksw", Designation = "wdewew" },
              new Employee { Id = 499, FirstName = "kjkhpravnsss", LastName = "am", Company = "jkkksw", Designation = "wdewew" },

                 new Employee { Id = 1, FirstName = "pravn", LastName = "m", Company = "asw", Designation = "wdewew" },
            new Employee { Id = 2, FirstName = "prgfgdavnsss", LastName = "am", Company = "jkkksw", Designation = "wdewew" },
             new Employee { Id = 3, FirstName = "gergrpravnsss", LastName = "am", Company = "jkkksw", Designation = "wdewew" },
              new Employee { Id = 4, FirstName = "kjkhpravnsss", LastName = "am", Company = "jkkksw", Designation = "wdewew" },

                 new Employee { Id = 1, FirstName = "pravn", LastName = "m", Company = "asw", Designation = "wdewew" },
            new Employee { Id = 2, FirstName = "prgfgdavnsss", LastName = "am", Company = "jkkksw", Designation = "wdewew" },
             new Employee { Id = 3, FirstName = "gergrpravnsss", LastName = "am", Company = "jkkksw", Designation = "wdewew" },
              new Employee { Id = 4, FirstName = "kjkhpravnsss", LastName = "am", Company = "jkkksw", Designation = "wdewew" },
                 new Employee { Id = 1, FirstName = "pravn", LastName = "m", Company = "asw", Designation = "wdewew" },
            new Employee { Id = 2, FirstName = "prgfgdavnsss", LastName = "am", Company = "jkkksw", Designation = "wdewew" },
             new Employee { Id = 3, FirstName = "gergrpravnsss", LastName = "am", Company = "jkkksw", Designation = "wdewew" },
              new Employee { Id = 4, FirstName = "kjkhpravnsss", LastName = "am", Company = "jkkksw", Designation = "wdewew" },

                 new Employee { Id = 1, FirstName = "pravn", LastName = "m", Company = "asw", Designation = "wdewew" },
            new Employee { Id = 2, FirstName = "prgfgdavnsss", LastName = "am", Company = "jkkksw", Designation = "wdewew" },
             new Employee { Id = 3, FirstName = "gergrpravnsss", LastName = "am", Company = "jkkksw", Designation = "wdewew" },
              new Employee { Id = 4, FirstName = "kjkhpravnsss", LastName = "am", Company = "jkkksw", Designation = "wdewew" },

                 new Employee { Id = 1, FirstName = "pravn", LastName = "m", Company = "asw", Designation = "wdewew" },
            new Employee { Id = 2, FirstName = "prgfgdavnsss", LastName = "am", Company = "jkkksw", Designation = "wdewew" },
             new Employee { Id = 3, FirstName = "gergrpravnsss", LastName = "am", Company = "jkkksw", Designation = "wdewew" },
              new Employee { Id = 4, FirstName = "kjkhpravnsss", LastName = "am", Company = "jkkksw", Designation = "wdewew" },

                 new Employee { Id = 1, FirstName = "pravn", LastName = "m", Company = "asw", Designation = "wdewew" },
            new Employee { Id = 2, FirstName = "prgfgdavnsss", LastName = "am", Company = "jkkksw", Designation = "wdewew" },
             new Employee { Id = 3, FirstName = "gergrpravnsss", LastName = "am", Company = "jkkksw", Designation = "wdewew" },
              new Employee { Id = 4, FirstName = "kjkhpravnsss", LastName = "am", Company = "jkkksw", Designation = "wdewew" },
   new Employee { Id = 1, FirstName = "pravn", LastName = "m", Company = "asw", Designation = "wdewew" },
            new Employee { Id = 2, FirstName = "prgfgdavnsss", LastName = "am", Company = "jkkksw", Designation = "wdewew" },
             new Employee { Id = 3, FirstName = "gergrpravnsss", LastName = "am", Company = "jkkksw", Designation = "wdewew" },
              new Employee { Id = 4, FirstName = "kjkhpravnsss", LastName = "am", Company = "jkkksw", Designation = "wdewew" },

                 new Employee { Id = 1, FirstName = "pravn", LastName = "m", Company = "asw", Designation = "wdewew" },
            new Employee { Id = 2, FirstName = "prgfgdavnsss", LastName = "am", Company = "jkkksw", Designation = "wdewew" },
             new Employee { Id = 3, FirstName = "gergrpravnsss", LastName = "am", Company = "jkkksw", Designation = "wdewew" },
              new Employee { Id = 4, FirstName = "kjkhpravnsss", LastName = "am", Company = "jkkksw", Designation = "wdewew" },

                 new Employee { Id = 1, FirstName = "pravn", LastName = "m", Company = "asw", Designation = "wdewew" },
            new Employee { Id = 2, FirstName = "prgfgdavnsss", LastName = "am", Company = "jkkksw", Designation = "wdewew" },
             new Employee { Id = 3, FirstName = "gergrpravnsss", LastName = "am", Company = "jkkksw", Designation = "wdewew" },
              new Employee { Id = 4, FirstName = "kjkhpravnsss", LastName = "am", Company = "jkkksw", Designation = "wdewew" },

                 new Employee { Id = 1, FirstName = "pravn", LastName = "m", Company = "asw", Designation = "wdewew" },
            new Employee { Id = 2, FirstName = "prgfgdavnsss", LastName = "am", Company = "jkkksw", Designation = "wdewew" },
             new Employee { Id = 3, FirstName = "gergrpravnsss", LastName = "am", Company = "jkkksw", Designation = "wdewew" },
              new Employee { Id = 4, FirstName = "kjkhpravnsss", LastName = "am", Company = "jkkksw", Designation = "wdewew" },
   new Employee { Id = 1, FirstName = "pravn", LastName = "m", Company = "asw", Designation = "wdewew" },
            new Employee { Id = 2, FirstName = "prgfgdavnsss", LastName = "am", Company = "jkkksw", Designation = "wdewew" },
             new Employee { Id = 3, FirstName = "gergrpravnsss", LastName = "am", Company = "jkkksw", Designation = "wdewew" },
              new Employee { Id = 4, FirstName = "kjkhpravnsss", LastName = "am", Company = "jkkksw", Designation = "wdewew" },

                 new Employee { Id = 1, FirstName = "pravn", LastName = "m", Company = "asw", Designation = "wdewew" },
            new Employee { Id = 2, FirstName = "prgfgdavnsss", LastName = "am", Company = "jkkksw", Designation = "wdewew" },
             new Employee { Id = 3, FirstName = "gergrpravnsss", LastName = "am", Company = "jkkksw", Designation = "wdewew" },
              new Employee { Id = 4, FirstName = "kjkhpravnsss", LastName = "am", Company = "jkkksw", Designation = "wdewew" },

                 new Employee { Id = 1, FirstName = "pravn", LastName = "m", Company = "asw", Designation = "wdewew" },
            new Employee { Id = 2, FirstName = "prgfgdavnsss", LastName = "am", Company = "jkkksw", Designation = "wdewew" },
             new Employee { Id = 3, FirstName = "gergrpravnsss", LastName = "am", Company = "jkkksw", Designation = "wdewew" },
              new Employee { Id = 4, FirstName = "kjkhpravnsss", LastName = "am", Company = "jkkksw", Designation = "wdewew" },

                 new Employee { Id = 1, FirstName = "pravn", LastName = "m", Company = "asw", Designation = "wdewew" },
            new Employee { Id = 2, FirstName = "prgfgdavnsss", LastName = "am", Company = "jkkksw", Designation = "wdewew" },
             new Employee { Id = 3, FirstName = "gergrpravnsss", LastName = "am", Company = "jkkksw", Designation = "wdewew" },
              new Employee { Id = 4, FirstName = "kjkhpravnsss", LastName = "am", Company = "jkkksw", Designation = "wdewew" },
   new Employee { Id = 1, FirstName = "pravn", LastName = "m", Company = "asw", Designation = "wdewew" },
            new Employee { Id = 2, FirstName = "prgfgdavnsss", LastName = "am", Company = "jkkksw", Designation = "wdewew" },
             new Employee { Id = 3, FirstName = "gergrpravnsss", LastName = "am", Company = "jkkksw", Designation = "wdewew" },
              new Employee { Id = 4, FirstName = "kjkhpravnsss", LastName = "am", Company = "jkkksw", Designation = "wdewew" },

                 new Employee { Id = 1, FirstName = "pravn", LastName = "m", Company = "asw", Designation = "wdewew" },
            new Employee { Id = 2, FirstName = "prgfgdavnsss", LastName = "am", Company = "jkkksw", Designation = "wdewew" },
             new Employee { Id = 3, FirstName = "gergrpravnsss", LastName = "am", Company = "jkkksw", Designation = "wdewew" },
              new Employee { Id = 4, FirstName = "kjkhpravnsss", LastName = "am", Company = "jkkksw", Designation = "wdewew" },

                 new Employee { Id = 1, FirstName = "pravn", LastName = "m", Company = "asw", Designation = "wdewew" },
            new Employee { Id = 2, FirstName = "prgfgdavnsss", LastName = "am", Company = "jkkksw", Designation = "wdewew" },
             new Employee { Id = 3, FirstName = "gergrpravnsss", LastName = "am", Company = "jkkksw", Designation = "wdewew" },
              new Employee { Id = 4, FirstName = "kjkhpravnsss", LastName = "am", Company = "jkkksw", Designation = "wdewew" },

                 new Employee { Id = 1, FirstName = "pravn", LastName = "m", Company = "asw", Designation = "wdewew" },
            new Employee { Id = 2, FirstName = "prgfgdavnsss", LastName = "am", Company = "jkkksw", Designation = "wdewew" },
             new Employee { Id = 3, FirstName = "gergrpravnsss", LastName = "am", Company = "jkkksw", Designation = "wdewew" },
              new Employee { Id = 4, FirstName = "kjkhpravnsss", LastName = "am", Company = "jkkksw", Designation = "wdewew" },
   new Employee { Id = 1, FirstName = "pravn", LastName = "m", Company = "asw", Designation = "wdewew" },
            new Employee { Id = 2, FirstName = "prgfgdavnsss", LastName = "am", Company = "jkkksw", Designation = "wdewew" },
             new Employee { Id = 3, FirstName = "gergrpravnsss", LastName = "am", Company = "jkkksw", Designation = "wdewew" },
              new Employee { Id = 4, FirstName = "kjkhpravnsss", LastName = "am", Company = "jkkksw", Designation = "wdewew" },

                 new Employee { Id = 1, FirstName = "pravn", LastName = "m", Company = "asw", Designation = "wdewew" },
            new Employee { Id = 2, FirstName = "prgfgdavnsss", LastName = "am", Company = "jkkksw", Designation = "wdewew" },
             new Employee { Id = 3, FirstName = "gergrpravnsss", LastName = "am", Company = "jkkksw", Designation = "wdewew" },
              new Employee { Id = 4, FirstName = "kjkhpravnsss", LastName = "am", Company = "jkkksw", Designation = "wdewew" },

                 new Employee { Id = 1, FirstName = "pravn", LastName = "m", Company = "asw", Designation = "wdewew" },
            new Employee { Id = 2, FirstName = "prgfgdavnsss", LastName = "am", Company = "jkkksw", Designation = "wdewew" },
             new Employee { Id = 3, FirstName = "gergrpravnsss", LastName = "am", Company = "jkkksw", Designation = "wdewew" },
              new Employee { Id = 4, FirstName = "kjkhpravnsss", LastName = "am", Company = "jkkksw", Designation = "wdewew" },

                 new Employee { Id = 1, FirstName = "pravn", LastName = "m", Company = "asw", Designation = "wdewew" },
            new Employee { Id = 2, FirstName = "prgfgdavnsss", LastName = "am", Company = "jkkksw", Designation = "wdewew" },
             new Employee { Id = 3, FirstName = "gergrpravnsss", LastName = "am", Company = "jkkksw", Designation = "wdewew" },
              new Employee { Id = 4, FirstName = "kjkhpravnsss", LastName = "am", Company = "jkkksw", Designation = "wdewew" },
   new Employee { Id = 1, FirstName = "pravn", LastName = "m", Company = "asw", Designation = "wdewew" },
            new Employee { Id = 2, FirstName = "prgfgdavnsss", LastName = "am", Company = "jkkksw", Designation = "wdewew" },
             new Employee { Id = 3, FirstName = "gergrpravnsss", LastName = "am", Company = "jkkksw", Designation = "wdewew" },
              new Employee { Id = 4, FirstName = "kjkhpravnsss", LastName = "am", Company = "jkkksw", Designation = "wdewew" },

                 new Employee { Id = 1, FirstName = "pravn", LastName = "m", Company = "asw", Designation = "wdewew" },
            new Employee { Id = 2, FirstName = "prgfgdavnsss", LastName = "am", Company = "jkkksw", Designation = "wdewew" },
             new Employee { Id = 3, FirstName = "gergrpravnsss", LastName = "am", Company = "jkkksw", Designation = "wdewew" },
              new Employee { Id = 4, FirstName = "kjkhpravnsss", LastName = "am", Company = "jkkksw", Designation = "wdewew" },

                 new Employee { Id = 1, FirstName = "pravn", LastName = "m", Company = "asw", Designation = "wdewew" },
            new Employee { Id = 2, FirstName = "prgfgdavnsss", LastName = "am", Company = "jkkksw", Designation = "wdewew" },
             new Employee { Id = 3, FirstName = "gergrpravnsss", LastName = "am", Company = "jkkksw", Designation = "wdewew" },
              new Employee { Id = 4, FirstName = "kjkhpravnsss", LastName = "am", Company = "jkkksw", Designation = "wdewew" },

                 new Employee { Id = 1, FirstName = "pravn", LastName = "m", Company = "asw", Designation = "wdewew" },
            new Employee { Id = 2, FirstName = "prgfgdavnsss", LastName = "am", Company = "jkkksw", Designation = "wdewew" },
             new Employee { Id = 3, FirstName = "gergrpravnsss", LastName = "am", Company = "jkkksw", Designation = "wdewew" },
              new Employee { Id = 4, FirstName = "kjkhpravnsss", LastName = "am", Company = "jkkksw", Designation = "wdewew" },
   new Employee { Id = 1, FirstName = "pravn", LastName = "m", Company = "asw", Designation = "wdewew" },
            new Employee { Id = 2, FirstName = "prgfgdavnsss", LastName = "am", Company = "jkkksw", Designation = "wdewew" },
             new Employee { Id = 3, FirstName = "gergrpravnsss", LastName = "am", Company = "jkkksw", Designation = "wdewew" },
              new Employee { Id = 4, FirstName = "kjkhpravnsss", LastName = "am", Company = "jkkksw", Designation = "wdewew" },

                 new Employee { Id = 1, FirstName = "pravn", LastName = "m", Company = "asw", Designation = "wdewew" },
            new Employee { Id = 2, FirstName = "prgfgdavnsss", LastName = "am", Company = "jkkksw", Designation = "wdewew" },
             new Employee { Id = 3, FirstName = "gergrpravnsss", LastName = "am", Company = "jkkksw", Designation = "wdewew" },
              new Employee { Id = 4, FirstName = "kjkhpravnsss", LastName = "am", Company = "jkkksw", Designation = "wdewew" },

                 new Employee { Id = 1, FirstName = "pravn", LastName = "m", Company = "asw", Designation = "wdewew" },
            new Employee { Id = 2, FirstName = "prgfgdavnsss", LastName = "am", Company = "jkkksw", Designation = "wdewew" },
             new Employee { Id = 3, FirstName = "gergrpravnsss", LastName = "am", Company = "jkkksw", Designation = "wdewew" },
              new Employee { Id = 4, FirstName = "kjkhpravnsss", LastName = "am", Company = "jkkksw", Designation = "wdewew" },

                 new Employee { Id = 1, FirstName = "pravn", LastName = "m", Company = "asw", Designation = "wdewew" },
            new Employee { Id = 2, FirstName = "prgfgdavnsss", LastName = "am", Company = "jkkksw", Designation = "wdewew" },
             new Employee { Id = 3, FirstName = "gergrpravnsss", LastName = "am", Company = "jkkksw", Designation = "wdewew" },
              new Employee { Id = 4, FirstName = "kjkhpravnsss", LastName = "am", Company = "jkkksw", Designation = "wdewew" },
   new Employee { Id = 1, FirstName = "pravn", LastName = "m", Company = "asw", Designation = "wdewew" },
            new Employee { Id = 2, FirstName = "prgfgdavnsss", LastName = "am", Company = "jkkksw", Designation = "wdewew" },
             new Employee { Id = 3, FirstName = "gergrpravnsss", LastName = "am", Company = "jkkksw", Designation = "wdewew" },
              new Employee { Id = 4, FirstName = "kjkhpravnsss", LastName = "am", Company = "jkkksw", Designation = "wdewew" },

                 new Employee { Id = 1, FirstName = "pravn", LastName = "m", Company = "asw", Designation = "wdewew" },
            new Employee { Id = 2, FirstName = "prgfgdavnsss", LastName = "am", Company = "jkkksw", Designation = "wdewew" },
             new Employee { Id = 3, FirstName = "gergrpravnsss", LastName = "am", Company = "jkkksw", Designation = "wdewew" },
              new Employee { Id = 4, FirstName = "kjkhpravnsss", LastName = "am", Company = "jkkksw", Designation = "wdewew" },

                 new Employee { Id = 1, FirstName = "pravn", LastName = "m", Company = "asw", Designation = "wdewew" },
            new Employee { Id = 2, FirstName = "prgfgdavnsss", LastName = "am", Company = "jkkksw", Designation = "wdewew" },
             new Employee { Id = 3, FirstName = "gergrpravnsss", LastName = "am", Company = "jkkksw", Designation = "wdewew" },
              new Employee { Id = 4, FirstName = "kjkhpravnsss", LastName = "am", Company = "jkkksw", Designation = "wdewew" },

                 new Employee { Id = 1, FirstName = "pravn", LastName = "m", Company = "asw", Designation = "wdewew" },
            new Employee { Id = 2, FirstName = "prgfgdavnsss", LastName = "am", Company = "jkkksw", Designation = "wdewew" },
             new Employee { Id = 3, FirstName = "gergrpravnsss", LastName = "am", Company = "jkkksw", Designation = "wdewew" },
              new Employee { Id = 4, FirstName = "kjkhpravnsss", LastName = "am", Company = "jkkksw", Designation = "wdewew" },
   new Employee { Id = 1, FirstName = "pravn", LastName = "m", Company = "asw", Designation = "wdewew" },
            new Employee { Id = 2, FirstName = "prgfgdavnsss", LastName = "am", Company = "jkkksw", Designation = "wdewew" },
             new Employee { Id = 3, FirstName = "gergrpravnsss", LastName = "am", Company = "jkkksw", Designation = "wdewew" },
              new Employee { Id = 4, FirstName = "kjkhpravnsss", LastName = "am", Company = "jkkksw", Designation = "wdewew" },

                 new Employee { Id = 1, FirstName = "pravn", LastName = "m", Company = "asw", Designation = "wdewew" },
            new Employee { Id = 2, FirstName = "prgfgdavnsss", LastName = "am", Company = "jkkksw", Designation = "wdewew" },
             new Employee { Id = 3, FirstName = "gergrpravnsss", LastName = "am", Company = "jkkksw", Designation = "wdewew" },
              new Employee { Id = 4, FirstName = "kjkhpravnsss", LastName = "am", Company = "jkkksw", Designation = "wdewew" },

                 new Employee { Id = 1, FirstName = "pravn", LastName = "m", Company = "asw", Designation = "wdewew" },
            new Employee { Id = 2, FirstName = "prgfgdavnsss", LastName = "am", Company = "jkkksw", Designation = "wdewew" },
             new Employee { Id = 3, FirstName = "gergrpravnsss", LastName = "am", Company = "jkkksw", Designation = "wdewew" },
              new Employee { Id = 4, FirstName = "kjkhpravnsss", LastName = "am", Company = "jkkksw", Designation = "wdewew" },

                 new Employee { Id = 1, FirstName = "pravn", LastName = "m", Company = "asw", Designation = "wdewew" },
            new Employee { Id = 2, FirstName = "prgfgdavnsss", LastName = "am", Company = "jkkksw", Designation = "wdewew" },
             new Employee { Id = 3, FirstName = "gergrpravnsss", LastName = "am", Company = "jkkksw", Designation = "wdewew" },
              new Employee { Id = 4, FirstName = "kjkhpravnsss", LastName = "am", Company = "jkkksw", Designation = "wdewew" },
   new Employee { Id = 1, FirstName = "pravn", LastName = "m", Company = "asw", Designation = "wdewew" },
            new Employee { Id = 2, FirstName = "prgfgdavnsss", LastName = "am", Company = "jkkksw", Designation = "wdewew" },
             new Employee { Id = 3, FirstName = "gergrpravnsss", LastName = "am", Company = "jkkksw", Designation = "wdewew" },
              new Employee { Id = 4, FirstName = "kjkhpravnsss", LastName = "am", Company = "jkkksw", Designation = "wdewew" },

                 new Employee { Id = 1, FirstName = "pravn", LastName = "m", Company = "asw", Designation = "wdewew" },
            new Employee { Id = 2, FirstName = "prgfgdavnsss", LastName = "am", Company = "jkkksw", Designation = "wdewew" },
             new Employee { Id = 3, FirstName = "gergrpravnsss", LastName = "am", Company = "jkkksw", Designation = "wdewew" },
              new Employee { Id = 4, FirstName = "kjkhpravnsss", LastName = "am", Company = "jkkksw", Designation = "wdewew" },

                 new Employee { Id = 1, FirstName = "pravn", LastName = "m", Company = "asw", Designation = "wdewew" },
            new Employee { Id = 2, FirstName = "prgfgdavnsss", LastName = "am", Company = "jkkksw", Designation = "wdewew" },
             new Employee { Id = 3, FirstName = "gergrpravnsss", LastName = "am", Company = "jkkksw", Designation = "wdewew" },
              new Employee { Id = 4, FirstName = "kjkhpravnsss", LastName = "am", Company = "jkkksw", Designation = "wdewew" },

                 new Employee { Id = 1, FirstName = "pravn", LastName = "m", Company = "asw", Designation = "wdewew" },
            new Employee { Id = 2, FirstName = "prgfgdavnsss", LastName = "am", Company = "jkkksw", Designation = "wdewew" },
             new Employee { Id = 3, FirstName = "gergrpravnsss", LastName = "am", Company = "jkkksw", Designation = "wdewew" },
              new Employee { Id = 4, FirstName = "kjkhpravnsss", LastName = "am", Company = "jkkksw", Designation = "wdewew" },
   new Employee { Id = 1, FirstName = "pravn", LastName = "m", Company = "asw", Designation = "wdewew" },
            new Employee { Id = 2, FirstName = "prgfgdavnsss", LastName = "am", Company = "jkkksw", Designation = "wdewew" },
             new Employee { Id = 3, FirstName = "gergrpravnsss", LastName = "am", Company = "jkkksw", Designation = "wdewew" },
              new Employee { Id = 4, FirstName = "kjkhpravnsss", LastName = "am", Company = "jkkksw", Designation = "wdewew" },

                 new Employee { Id = 1, FirstName = "pravn", LastName = "m", Company = "asw", Designation = "wdewew" },
            new Employee { Id = 2, FirstName = "prgfgdavnsss", LastName = "am", Company = "jkkksw", Designation = "wdewew" },
             new Employee { Id = 3, FirstName = "gergrpravnsss", LastName = "am", Company = "jkkksw", Designation = "wdewew" },
              new Employee { Id = 4, FirstName = "kjkhpravnsss", LastName = "am", Company = "jkkksw", Designation = "wdewew" },

                 new Employee { Id = 1, FirstName = "pravn", LastName = "m", Company = "asw", Designation = "wdewew" },
            new Employee { Id = 2, FirstName = "prgfgdavnsss", LastName = "am", Company = "jkkksw", Designation = "wdewew" },
             new Employee { Id = 3, FirstName = "gergrpravnsss", LastName = "am", Company = "jkkksw", Designation = "wdewew" },
              new Employee { Id = 4, FirstName = "kjkhpravnsss", LastName = "am", Company = "jkkksw", Designation = "wdewew" },

                 new Employee { Id = 1, FirstName = "pravn", LastName = "m", Company = "asw", Designation = "wdewew" },
            new Employee { Id = 2, FirstName = "prgfgdavnsss", LastName = "am", Company = "jkkksw", Designation = "wdewew" },
             new Employee { Id = 3, FirstName = "gergrpravnsss", LastName = "am", Company = "jkkksw", Designation = "wdewew" },
              new Employee { Id = 4, FirstName = "kjkhpravnsss", LastName = "am", Company = "jkkksw", Designation = "wdewew" },

        };          
        }

        public ActionResult CustomAjaxBinding_Read()
        {
            
                var result = new
                {
                    Data = GetAll(),
                    Total = GetAll().Count()
                };

                return Json(result);
            
        }
        public ActionResult CustomAjaxBinding_Reasd([DataSourceRequest] DataSourceRequest request)
        {
            using (var dataContext = GetContext())
            {
                // Convert to view model to avoid JSON serialization problems due to circular references.
                List<Employee> orders = GetAll();

                orders = orders.ApplyOrdersFiltering(request.Filters);

                var total = orders.Count();

                orders = orders.ApplyOrdersSorting(request.Groups, request.Sorts);

                if (!request.Sorts.Any() && !request.Groups.Any() && !request.Groups.Where(descriptor => descriptor.SortDirection != ListSortDirection.Descending).Any())
                {
                    // Entity Framework doesn't support paging on unsorted data.
                    orders = orders.OrderBy(o => o.OrderID);
                }

                orders = orders.ApplyOrdersPaging(request.Page, request.PageSize);

                IEnumerable data = orders.ApplyOrdersGrouping(request.Groups);

                var result = new DataSourceResult()
                {
                    Data = data,
                    Total = total
                };

                return Json(result);
            }
        }
    }
}
}

