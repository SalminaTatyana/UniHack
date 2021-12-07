using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniHackStart.Model.Database;

namespace UniHackStart.Controllers
{
    public class TeachersController : Controller
    {
        public IActionResult Index()
        {
            //using (var db = new UniHackStartDbContext())
            //{
            //    var teachers = db.Teachers;
            //    Teacher teacher = teachers.FirstOrDefault();
            //    if (teacher != null)
            //    {
            //        teacher.Email = "example@mifi.ru";
            //        teacher.FirstName = "asd";
            //        db.SaveChanges();
            //    }
            //}
            return View();
        }
    }
}
