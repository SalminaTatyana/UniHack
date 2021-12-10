using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniHackStart.Models.DatabaseModel
{
    public class Group
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public long? SpecialityId { get; set; }

        public long? CourseId { get; set; }
    }
}
