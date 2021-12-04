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
        public string UserRole()
        {
            string userRole;
            string path = @"C:\Институт\Uni\UniHackStart\wwwroot\role\Role.txt";
            using (StreamReader fstream = new StreamReader(path))
            {
                byte[] output = new byte[1];
                userRole = fstream.ReadLine();

                fstream.Close();
            }
            if (userRole == "1")
            {
                StreamWriter writer = new StreamWriter(path );
                writer.Close();
                return "1";
            }
            if (userRole == "2")
            {
                StreamWriter writer = new StreamWriter(path );
                writer.Close();
                return "2";
            }
            return "0";
        }
        public string ChooseUserRole()
        {
            string fileName;
            string userRole;
            string path = @"C:\Институт\Uni\UniHackStart\wwwroot\role\Role.txt";
            using (StreamReader fstream = new StreamReader(path))
            {
                byte[] output = new byte[1];
                userRole = fstream.ReadLine();

                fstream.Close();
            }
            if (userRole == "1")
            {
                StreamWriter writer = new StreamWriter(path );
                writer.Write("2");
                writer.Close();
                return "2";
            }
            if (userRole == "2")
            {
                StreamWriter writer = new StreamWriter(path );
                writer.Write("1");
                writer.Close();
                return "1";
            }
            return "0";
        }
        public IActionResult ChooseStudent()
        {
            string userRole;
            string path = @"C:\Институт\Uni\UniHackStart\wwwroot\role\Role.txt";
            StreamWriter writer = new StreamWriter(path);
            writer.Write(("1"));
            writer.Close();
            ViewBag.Role = "1";
            return View("Index");
        }
        public IActionResult ChooseTeacher()
        {
            string userRole;
            string path = @"C:\Институт\Uni\UniHackStart\wwwroot\role\Role.txt";
            StreamWriter writer = new StreamWriter(path);
            writer.Write(("2"));
            writer.Close();
            ViewBag.Role = "2";
            return View("Index");
        }
        public IActionResult ChooseUser()
        {
            var role = UserRole();
            ViewBag.Role = role;
            return View("_partialChooseRole");
        }
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {
            var role = UserRole();
            ViewBag.Role = role;
            return View();
        }

        public IActionResult Privacy()
        {
            var role = UserRole();
            ViewBag.Role = role;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            var role = UserRole();
            ViewBag.Role = role;
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
