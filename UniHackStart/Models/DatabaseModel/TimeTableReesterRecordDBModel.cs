using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniHackStart.Models.DatabaseModel
{
    public class TimeTableReesterRecordDBModel
    {
        public long Id { get; set; }

        public long ReesterId { get; set; }

        public DateTime Created { get; set; }


        public string WeekNumber { get; set; }

        public long? GroupId { get; set; }

        public long? DayOfWeekId { get; set; }


        public string ParaNumber { get; set; }

        public string TimeStart1 { get; set; }

        public string TimeEnd1 { get; set; }

        public string TimeStart2 { get; set; }

        public string TimeEnd2 { get; set; }

        public long? LessonId { get; set; }

        public long? LessonTypeId { get; set; }

        public long? TeacherId { get; set; }

        public long? CorpsId { get; set; }

        public long? ClassRoomId { get; set; }

        public string Apx { get; set; }
    }
}
