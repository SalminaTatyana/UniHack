using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniHackStart.Models.DatabaseModel
{
    public class UserDBModel
    {
        public long Id { get; set; }

        public string Login { get; set; }
 
        public string Password { get; set; }

        public string Email { get; set; }

        public bool IsLocked { get; set; }
    }
}
