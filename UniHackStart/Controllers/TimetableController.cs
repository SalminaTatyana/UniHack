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
        public async Task<IActionResult> GetTimetable(string weekNumber /*, long groupId,*/ )
        {
            var groupId = 10;
            weekNumber = "1";
            
            if (weekNumber.Contains("1"))
            {
                foreach (var c in GetTimeTableWeek(groupId,weekNumber))
                {
                    return PartialView("_partialWeekTimetable", c);
                }
            }

            if (weekNumber.Contains("2"))
            {
                foreach (var c in GetTimeTableWeek(groupId,weekNumber))
                {
                    return PartialView("_partialWeekTimetable", c);
                }
            }

            foreach (var c in GetTimeTableAll(groupId,weekNumber))
            {

                return PartialView("_partialWeekTimetable",c);
            }

            return null;
        }

        private List<StudentTimeTableModel> GetTimeTableWeek(long groupId,string weekNumber)
        {
            using (var db = new UniHackStartDbContext())
            {
                List<TimeTableView> timeTableList = db.TimeTableViews.Where(w => w.GroupId == groupId).ToList();
                IOrderedEnumerable<IGrouping<long?, TimeTableView>> ttWeek = timeTableList
                    .Where(w => w.WeekNumber == weekNumber.ToString()).GroupBy(g => g.DayOfWeekId).OrderBy(o => o.Key);

                return CreateTimeTable(ttWeek);
            }
        }

        private List<StudentTimeTableModel> GetTimeTableAll(long groupId, string weekNumber)
        {
            using (var db = new UniHackStartDbContext())
            {
                long? courseId = db.Groups.FirstOrDefault(g => g.Id == groupId)?.CourseId;
                List<TimeTableView> ttv = db.TimeTableViews.Where(w =>
                    w.CourseId == courseId && w.GroupId == groupId && w.WeekNumber == weekNumber).ToList();
                IOrderedEnumerable<IGrouping<long?, TimeTableView>> ttWeek = ttv
                    .Where(w => w.WeekNumber == weekNumber.ToString()).GroupBy(g => g.DayOfWeekId).OrderBy(o => o.Key);

                return CreateTimeTable(ttWeek);
            }
        }

        private List<StudentTimeTableModel> CreateTimeTable(
            IOrderedEnumerable<IGrouping<long?, TimeTableView>> timeTable)
        {
            List<StudentTimeTableModel> resultList = new List<StudentTimeTableModel>();

            using (var db = new UniHackStartDbContext())
            {

                foreach (var t in timeTable)
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
                    resultList.Add(stud);
                }
            }

            return resultList;
        }
    }
}
