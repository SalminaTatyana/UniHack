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
            return View();
        }
        
        [HttpPost]
        public async Task<IActionResult> GetTimetable(string n)
        {
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
