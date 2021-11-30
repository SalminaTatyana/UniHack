using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
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
        //TimetableDayModel Monday1 =new TimetableDayModel { dateOfWeek = "",
        //    weekNumber = 1, 
        //    lesson1={ name = "", teachername = "", time = "", place = "" },
        //    lesson2 = { name = "", teachername = "", time = "", place = "" }, 
        //    lesson3 = { name = "", teachername = "", time = "", place = "" }, 
        //    lesson4 = { name = "", teachername = "", time = "", place = "" }, 
        //    lesson5 = { name = "", teachername = "", time = "", place = "" }, 
        //    lesson6 = { name = "", teachername = "", time = "", place = "" } };
        //TimetableDayModel Tuesday1 =  new TimetableDayModel
        //{
        //    dateOfWeek = "",
        //    weekNumber = 1,
        //    lesson1 = { name = "", teachername = "", time = "", place = "" },
        //    lesson2 = { name = "", teachername = "", time = "", place = "" },
        //    lesson3 = { name = "", teachername = "", time = "", place = "" },
        //    lesson4 = { name = "", teachername = "", time = "", place = "" },
        //    lesson5 = { name = "", teachername = "", time = "", place = "" },
        //    lesson6 = { name = "", teachername = "", time = "", place = "" }
        //};
        //TimetableDayModel Wednesday1 =  new TimetableDayModel
        //{
        //    dateOfWeek = "",
        //    weekNumber = 1,
        //    lesson1 = { name = "", teachername = "", time = "", place = "" },
        //    lesson2 = { name = "", teachername = "", time = "", place = "" },
        //    lesson3 = { name = "", teachername = "", time = "", place = "" },
        //    lesson4 = { name = "", teachername = "", time = "", place = "" },
        //    lesson5 = { name = "", teachername = "", time = "", place = "" },
        //    lesson6 = { name = "", teachername = "", time = "", place = "" }
        //};
        //TimetableDayModel Thursday1 =  new TimetableDayModel
        //{
        //    dateOfWeek = "",
        //    weekNumber = 1,
        //    lesson1 = { name = "", teachername = "", time = "", place = "" },
        //    lesson2 = { name = "", teachername = "", time = "", place = "" },
        //    lesson3 = { name = "", teachername = "", time = "", place = "" },
        //    lesson4 = { name = "", teachername = "", time = "", place = "" },
        //    lesson5 = { name = "", teachername = "", time = "", place = "" },
        //    lesson6 = { name = "", teachername = "", time = "", place = "" }
        //};
        //TimetableDayModel Friday1 =  new TimetableDayModel
        //{
        //    dateOfWeek = "",
        //    weekNumber = 1,
        //    lesson1 = { name = "", teachername = "", time = "", place = "" },
        //    lesson2 = { name = "", teachername = "", time = "", place = "" },
        //    lesson3 = { name = "", teachername = "", time = "", place = "" },
        //    lesson4 = { name = "", teachername = "", time = "", place = "" },
        //    lesson5 = { name = "", teachername = "", time = "", place = "" },
        //    lesson6 = { name = "", teachername = "", time = "", place = "" }
        //};
        //TimetableDayModel Saturday1 =  new TimetableDayModel
        //{
        //    dateOfWeek = "",
        //    weekNumber = 1,
        //    lesson1 = { name = "", teachername = "", time = "", place = "" },
        //    lesson2 = { name = "", teachername = "", time = "", place = "" },
        //    lesson3 = { name = "", teachername = "", time = "", place = "" },
        //    lesson4 = { name = "", teachername = "", time = "", place = "" },
        //    lesson5 = { name = "", teachername = "", time = "", place = "" },
        //    lesson6 = { name = "", teachername = "", time = "", place = "" }
        //};
        public IActionResult Index()
        {
            return View();
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
