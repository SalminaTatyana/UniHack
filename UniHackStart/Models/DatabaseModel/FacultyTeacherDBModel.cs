using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniHackStart.Models.DatabaseModel
{
    public class FacultyTeacherDBModel
    {
        public long Id { get; set; }

        public long FacultyId { get; set; }

        public long TeacherId { get; set; }
    }
}
