using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniHackStart.Models.DatabaseModel
{
    public class StudentGradeListDBModel
    {
        public long Id { get; set; }

        public long StudentId { get; set; }

        public long LessonId { get; set; }

        public long TeacherId { get; set; }

        public DateTime Created { get; set; }

        public decimal Points { get; set; }
    }
}
