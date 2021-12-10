using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniHackStart.Models.DatabaseModel
{
    public class StudentDBModel
    {
        public long Id { get; set; }

        public string LastName { get; set; }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string Email { get; set; }

        public long SpecialityId { get; set; }

        public long CourseId { get; set; }

        public long GroupId { get; set; }

        public long UserId { get; set; }
    }
}
