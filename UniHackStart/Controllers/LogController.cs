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
    public class LogController : Controller
    {
       public IActionResult Index()
        {
            return View();
        }
        public IActionResult AdminLog() {
            return View();
        }
    }
}
