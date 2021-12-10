using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniHackStart.Models
{
    public class StudentDayModel
    {
        public string DayOfTheWeek { get; set; }
        public int ParaNumber { get; set;}
        public DateTime timeStart1 { get; set; }
        public DateTime timeEnd1 { get; set; }
        public DateTime timeStart2 { get; set; }
        public DateTime timeEnd2 { get; set; }
        public string ParaName { get; set; }
        public string ClassRoom { get; set; }
        public string TeacherName { get; set; }
    }
}
