﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniHackStart.Controllers
{
    public class StudentDayController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}