using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniHackStart.Controllers
{
    public class StatmentsController : Controller
    {
        public IActionResult Index()
        {
           return View();
        }
        public IActionResult TeacherStatments()
        {
            if (HttpContext.Session.GetString("role") == "Teacher")
            {
                return View();
            }
            else
            {
                return View("_partialErrorAcces");
            }
        }
    }
}
