using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniHackStart.Models.DatabaseModel
{
    public class FacultiesGroupContentsViewDBModel
    {
        public long Id { get; set; }

        public long FacultyId { get; set; }

        public long FacultyGroupId { get; set; }
    }
}
