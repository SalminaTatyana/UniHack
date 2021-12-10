using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniHackStart.Models.DatabaseModel
{
    public class StudentsViewDBModel
    {
        public long Id { get; set; }

        public string LastName { get; set; }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string Fio { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string Email { get; set; }

        public long SpecialityId { get; set; }

        public string SpecialityName { get; set; }
  
        public string SpecialityNumber { get; set; }

        public long CourseId { get; set; }

        public int CourseName { get; set; }

        public long GroupId { get; set; }

        public string GroupName { get; set; }

        public string GroupShortName { get; set; }

        public long UserId { get; set; }

        public string UserLogin { get; set; }
    }
}
