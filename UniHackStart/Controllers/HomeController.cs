using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniHackStart.Models;

namespace UniHackStart.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult ChooseUser() {
            return View("_partialChooseRole");
        }   
        public IActionResult ChooseStudent() {
            HttpContext.Session.Clear();
            HttpContext.Session.SetString("role", "Student");
            return View("Index");
        }
        public IActionResult ChooseTeacher()
        {
            HttpContext.Session.Clear();
            HttpContext.Session.SetString("role", "Teacher");
            return View("Index");
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult IndexPartial() {
            if (HttpContext.Session.GetString("role") == "Student") {
                return PartialView("_partialIndexStudent");
            }
            if (HttpContext.Session.GetString("role") == "Teacher")
            {
                return PartialView("_partialIndexStudent");
            }
            else {
                return PartialView("_partialIndexWithoutRole");
            }

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
