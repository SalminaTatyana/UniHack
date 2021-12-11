using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniHackStart.Model.Database;
using UniHackStart.Models;
using UniHackStart.Util;

namespace UniHackStart.Controllers
{
    public class LogController : Controller
    {

        //ApplicationContext _context;
        IWebHostEnvironment _appEnvironment;
        public LogController(/*ApplicationContext context,*/ IWebHostEnvironment appEnvironment)
        {
            //_context = context;
            _appEnvironment = appEnvironment;
        }
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddFile(IFormFile uploadedFile)
        {
            var time = DateTime.Now.ToString("dd.MM.yyyy HH-mm-ss");
            if (uploadedFile != null)
            {
                string path = _appEnvironment.WebRootPath + "\\Files\\" + time + "_" + uploadedFile.FileName;
                using (var fileStream = new FileStream(path, FileMode.Create))
                {
                    await uploadedFile.CopyToAsync(fileStream);
                }

                FileModel file = new FileModel {Name = uploadedFile.FileName, Path = path};

                var reester = new TimeTableReester();
                using (var db = new UniHackStartDbContext())
                {
                    reester.Created = DateTime.Now;
                    reester.FileName = file.Name;
                    reester.FilePath = file.Path;
                    reester.UserId = 1;

                    db.TimeTableReesters.Add(reester);
                    db.SaveChanges();
                }

                ExcelParser.Start(reester);
                ExcelParser.RegistryProcessingTimeTable(reester.Id);
                ExcelParser.SetCurrentTimeTable(reester.Id);

            }

            return RedirectToAction("AdminLog");
        }

        public IActionResult AdminLog()
        {
            if (HttpContext.Session.GetString("role") == "Admin")
            {
                using (var db = new UniHackStartDbContext())
                {
                    var ttr = db.TimeTableReestersView.ToList();
                    return PartialView("_partialExcelFiles",ttr);
                }
            }
            else { return PartialView("_partialExcelFiles"); }

        }
    }
}
