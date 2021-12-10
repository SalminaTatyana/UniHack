using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniHackStart.Models.DatabaseModel
{
    public class TimeTableViewDBModel
    {
        public string WeekNumber { get; set; }

        public long? GroupId { get; set; }

        public string GroupName { get; set; }

        public long? DayOfWeekId { get; set; }

        public string DaysOfWeeks { get; set; }

        public string ParaNumber { get; set; }

        public string TimeStart1 { get; set; }

        public string TimeEnd1 { get; set; }

        public string TimeStart2 { get; set; }

        public string TimeEnd2 { get; set; }

        public long? LessonId { get; set; }

        public string LessonName { get; set; }

        public long? LessonTypeId { get; set; }

        public string LessonTypeShortName { get; set; }

        public long? TeacherId { get; set; }

        public string Fio { get; set; }

        public long? CorpsId { get; set; }

        public string CorpusName { get; set; }

        public long? ClassRoomId { get; set; }

        public string ClassRoomName { get; set; }
    }
}
