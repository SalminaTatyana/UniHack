using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniHackStart.Models
{
    public class StudentTimeTableModel
    {
        public string DayOfWeek { get; set; }
        public List<Para> ParaList { get; set; }
    }



    public class Para
    {
        public string paraNumber { get; set; }
        public string TimeStart_1 { get; set; }
        public string TimeEnd_1 { get; set; }
        public string TimeStart_2 { get; set; }
        public string TimeEnd_2 { get; set; }
        public string TeacherName { get; set; }
        public string LessonName { get; set; }
        public string LessonShortType { get; set; }
        public string CorpClassRoom { get; set; }
    }
}
