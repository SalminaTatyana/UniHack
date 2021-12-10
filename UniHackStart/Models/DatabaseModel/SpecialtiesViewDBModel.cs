using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniHackStart.Models.DatabaseModel
{
    public class SpecialtiesViewDBModel
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public string Number { get; set; }

        public long? FacultyGroupId { get; set; }

        public string FacultyGroupName { get; set; }
    }
}
