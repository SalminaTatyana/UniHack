using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniHackStart.Models
{
    public class WeekTimetableModel
    {
        public string dateOfWeek { get; set; }
        public int weekNumber { get; set; }
        public string name { get; set; }
        public string teachername { get; set; }
        public string time { get; set; }
        public string place { get; set; }
    }
}
