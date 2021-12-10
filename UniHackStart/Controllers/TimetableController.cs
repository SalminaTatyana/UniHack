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
    public class TimetableController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> GetTimetable(string n)
        {
            Student student = new Student();
            student.GroupId = 10;
            List<List<StudentTimeTableModel>> timetableWeekList = new List<List<StudentTimeTableModel>>();


            using (var db = new UniHackStartDbContext())
            {
                List<TimeTableView> timeTableList = db.TimeTableViews.Where(w => w.GroupId == student.GroupId).ToList();


                for (int i = 1; i < 3; i++)
                {
                    List<StudentTimeTableModel> stundetList = new List<StudentTimeTableModel>();
                    IOrderedEnumerable<IGrouping<long?, TimeTableView>> ttWeek = timeTableList
                        .Where(w => w.WeekNumber == i.ToString()).GroupBy(g => g.DayOfWeekId).OrderBy(o => o.Key);

                    foreach (var t in ttWeek)
                    {
                        var stud = new StudentTimeTableModel();
                        stud.DayOfWeek = db.DaysOfWeeks.Where(w => w.Id == t.Key).FirstOrDefault().Name;
                        stud.ParaList = new List<Para>();


                        foreach (TimeTableView item in t)
                        {
                            Para p = new Para();
                            p.TimeStart_1 = item.TimeStart1;
                            p.TimeEnd_1 = item.TimeEnd1;
                            p.TimeStart_2 = item.TimeStart2;
                            p.TimeEnd_2 = item.TimeEnd2;
                            p.paraNumber = item.ParaNumber;
                            p.TeacherName = item.Fio;
                            p.LessonName = item.LessonName;
                            p.LessonShortType = item.LessonTypeShortName;

                            if (string.IsNullOrEmpty(item.CorpusName))
                                p.CorpClassRoom = item.ClassRoomName;

                            if (string.IsNullOrEmpty(item.ClassRoomName))
                                p.CorpClassRoom = item.LessonTypeShortName;

                            if (!string.IsNullOrEmpty(item.CorpusName) && !string.IsNullOrEmpty(item.ClassRoomName))
                                p.CorpClassRoom = $"{item.CorpusName}-{item.ClassRoomName}";

                            stud.ParaList.Add(p);
                        }

                        stud.ParaList = stud.ParaList.OrderBy(o => o.paraNumber).ToList();
                        stundetList.Add(stud);
                    }

                    timetableWeekList.Add(stundetList);
                }
            }

            if (n == "1")
            {
                List<StudentTimeTableModel> WeekOne = timetableWeekList[0];
                foreach (var c in WeekOne)
                {
                    return PartialView("_partialWeekTimetable", c);
                }
            }

            if (n == "2")
            {
                List<StudentTimeTableModel> WeekOne = timetableWeekList[1];
                foreach (var c in WeekOne)
                {
                    return PartialView("_partialWeekTimetable", c);
                }
            }

            return PartialView("_partialWeekTimetable");

        }
    }
}
