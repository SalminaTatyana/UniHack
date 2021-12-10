using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniHackStart.Models.DatabaseModel
{
    public class FacultyLessonsViewDBModel
    {
        public long Id { get; set; }

        public long FacultyId { get; set; }

        public string FacultyName { get; set; }

        public long LessonId { get; set; }

        public string LessonName { get; set; }
    }
}
