using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace UniHackStart.Controllers
{
    public class RoleController : Controller
    {
        public IActionResult ChooseUserRole()
        {
            string  fileName;
            string userRole;
            string path = @"C:\Институт\Uni\UniHackStart\wwwroot\role\";
            DirectoryInfo dir = Directory.CreateDirectory(path);
            bool lastUpdatedFile = System.IO.File.Exists(path );
            
            if (lastUpdatedFile != true)
            {
                fileName = "Role.txt";
                path = path + fileName;
            }
            else
                path = path + "Role.txt"; 

            using (FileStream fstream = new FileStream(path, FileMode.Open))
            {
                byte[] output = new byte[1];
                fstream.Read(output, 0, output.Length);
                userRole = Encoding.Default.GetString(output);
            }
            if (userRole == "1")
            {
                StreamWriter writer = new StreamWriter(path + "Role.txt");
                writer.Write(("2"));
                writer.Close();
                return Json("2");
            }
            if (userRole == "2")
            {
                StreamWriter writer = new StreamWriter(path + "Role.txt");
                writer.Write(("1"));
                writer.Close();
            }
            return Json("1");
        }
        public IActionResult UserRole()
        {
            string fileName;
            string userRole;
            string path = @"C:\Институт\Uni\UniHackStart\wwwroot\role\";
            DirectoryInfo dir = Directory.CreateDirectory(path);
            bool lastUpdatedFile = System.IO.File.Exists(path);

            if (lastUpdatedFile != true)
            {
                fileName = "Role.txt";
                path = path + fileName;
            }
            else
                path = path + "Role.txt";

            using (FileStream fstream = new FileStream(path, FileMode.Open))
            {
                byte[] output = new byte[1];
                fstream.Read(output, 0, output.Length);
                userRole = Encoding.Default.GetString(output);
            }
            if (userRole == "1")
            {
                StreamWriter writer = new StreamWriter(path + "Role.txt");
                writer.Close();
                return Json("1");
            }
            if (userRole == "2")
            {
                StreamWriter writer = new StreamWriter(path + "Role.txt");
                writer.Close();
            }
            return Json("1");
        }
    }
}
