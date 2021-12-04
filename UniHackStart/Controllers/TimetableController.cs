using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniHackStart.Models;

namespace UniHackStart.Controllers
{
    public class TimetableController : Controller
    {
        public IActionResult Index()
        {
            var role = UserRole();
            ViewBag.Role = role;
            return View();
        }
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
                StreamWriter writer = new StreamWriter(path);
                writer.Close();
                return "1";
            }
            if (userRole == "2")
            {
                StreamWriter writer = new StreamWriter(path);
                writer.Close();
                return "2";
            }
            return "0";
        }
        [HttpPost]
        public async Task<IActionResult> GetTimetable(string n)
        {
            var role = UserRole();
            ViewBag.Role = role;
            if (n == "1")
            {
                WeekTimetableModel response = new WeekTimetableModel
                {
                    dateOfWeek = "1",
                    weekNumber = 1,
                    name = "Электротехника",
                    teachername = "Шмигирилов Ю.Г.",
                    time = "",
                    place = "3-104"
                };
                return PartialView("_partialWeekTimetable", response);
            }
            if (n == "2")
            {
                WeekTimetableModel response = new WeekTimetableModel
                {
                    dateOfWeek = "2",
                    weekNumber = 2,
                    name = "Электротехника",
                    teachername = "Шмигирилов Ю.Г.",
                    time = "",
                    place = "3-204"
                };
                return PartialView("_partialWeekTimetable", response);
            }
            else {
                return PartialView("_partialTimetableAll");
            }
        }
    }
}
