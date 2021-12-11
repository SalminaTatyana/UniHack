using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniHackStart.Model.Database;
using UniHackStart.Models;

namespace UniHackStart.Controllers
{
    public class TeachersController : Controller
    {
        public IActionResult Index()
        {   List <TeacherModel> teacher = new List<TeacherModel>();
            using (var db = new UniHackStartDbContext())
            {
                var teachers = db.FacultyTeachersViews.ToList().GroupBy(g => g.FacultyId).OrderBy(o => o.Key).ToList();

                for (int i = 0; i < teachers.Count; i++)
                {
                    TeacherModel tm = new TeacherModel();
                    tm.MyTeacherList = new List<MyTeacher>();
                    tm.FacultyName = teachers[i].FirstOrDefault().Name;
                    foreach (var item in teachers[i])
                    {
                        MyTeacher t = new MyTeacher();
                        t.FIO = item.Fio;
                        t.Email = db.Teachers.FirstOrDefault(w => w.Id == item.TeacherId).Email;
                        t.Phone = db.Teachers.FirstOrDefault(w => w.Id == item.TeacherId).Phone;
                        tm.MyTeacherList.Add(t);
                    }
                    teacher.Add(tm);
                }

            }
            return View(teacher);
        }
    }
}
