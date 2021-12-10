using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniHackStart.Models.DatabaseModel
{
    public class TeachersViewDBModel
    {
        public long Id { get; set; }

        public string LastName { get; set; }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string Fio { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public string Email { get; set; }

        public long? UserId { get; set; }

        public string Login { get; set; }
    }
}
