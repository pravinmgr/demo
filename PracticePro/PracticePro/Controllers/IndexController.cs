﻿using Microsoft.AspNetCore.Mvc;

namespace PracticePro.Controllers
{
    public class IndexController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
