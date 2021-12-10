using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniHackStart.Model.Database;

namespace UniHackStart.Controllers
{
    public class TimeTableReestersController : Controller
    {
        // GET: TimeTableReestersController
        public ActionResult Index()
        {
            using (var db = new UniHackStartDbContext())
            {
                var ttr = db.TimeTableReesters.ToList();
                return View();
            }
        }


        // GET: TimeTableReestersController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TimeTableReestersController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }


        // GET: TimeTableReestersController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TimeTableReestersController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
