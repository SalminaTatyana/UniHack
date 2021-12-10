using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniHackStart.Models.DatabaseModel
{
    public class UserRightsViewDBModel
    {
        public long Id { get; set; }

        public long UserId { get; set; }

        public string Login { get; set; }

        public long RightId { get; set; }

        public string Name { get; set; }
    }
}
