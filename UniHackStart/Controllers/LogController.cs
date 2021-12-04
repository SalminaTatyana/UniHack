﻿using Microsoft.AspNetCore.Http;
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
        public ActionResult Index()
        {
            var role = UserRole();
            ViewBag.Role = role;
            return View();
        }

    }
}
