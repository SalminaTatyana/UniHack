using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniHackStart.Controllers
{
    public class RoleController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult MenuPartial()
        {
            if (HttpContext.Session.GetString("role") == "Student")
            {
                return PartialView("_MainMenu_Student");
            }
            if (HttpContext.Session.GetString("role") == "Teacher")
            {
                return PartialView("_MainMenuTeacher");
            }
            if (HttpContext.Session.GetString("role") == "Admin")
            {
                return PartialView("_MainMenuAdmin");
            }
            else
            {
                return PartialView("_MainMenu_WithoutRole");
            }

        }
        public IActionResult HeaderPartial()
        {
            if (HttpContext.Session.GetString("role") == "Student")
            {
                return PartialView("_HeaderStudent");
            }
            if (HttpContext.Session.GetString("role") == "Teacher")
            {
                return PartialView("_HeaderTeacher");
            }
            if (HttpContext.Session.GetString("role") == "Admin")
            {
                return PartialView("_HeaderAdmin");
            }
            else
            {
                return PartialView("_HeaderWithoutRole");
            }

        }
    }
}
