using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniHackStart.Controllers
{
    public class LogController : Controller
    {
        // GET: LogController
        public ActionResult Index()
        {
            return View();
        }

    }
}
