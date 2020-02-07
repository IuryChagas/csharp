using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SalesWebMvc.Models.ViewModels;

namespace SalesWebMvc.Controllers {
    public class HomeController : Controller {
        private readonly ILogger<HomeController> _logger;

        public HomeController (ILogger<HomeController> logger) {
            _logger = logger;
        }

        public IActionResult Index () {
            ViewData["Message"] = "New MVC tutorials - WebApplication from C# Course ";
            ViewData["Description"] = "Development dotnetCore";
            ViewData["Nome"] = "Douglas Iury";
            ViewData["email"] = "iurychagas@icloud.com";
            return View ();
        }

        public IActionResult Privacy () {

            return View ();
        }

        [ResponseCache (Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error () {
            return View (new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}