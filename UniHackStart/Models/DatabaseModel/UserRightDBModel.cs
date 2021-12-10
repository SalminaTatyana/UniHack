using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniHackStart.Models.DatabaseModel
{
    public class UserRightDBModel
    {
        public long Id { get; set; }

        public long UserId { get; set; }

        public long RightId { get; set; }
    }
}
