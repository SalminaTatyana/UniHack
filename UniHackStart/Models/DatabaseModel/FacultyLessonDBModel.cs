using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniHackStart.Models.DatabaseModel
{
    public class FacultyLessonDBModel
    {
        public long Id { get; set; }

        public long FacultyId { get; set; }

        public long LessonId { get; set; }
    }
}
