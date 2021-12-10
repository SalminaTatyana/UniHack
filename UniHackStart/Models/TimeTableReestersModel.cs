using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniHackStart.Models
{
    public class TimeTableReestersModel
    {
        public long Id { get; set; }
        public DateTime Created { get; set; }
        public string FileName { get; set; }
        public long UserId { get; set; }
        public string FilePath { get; set; }
        public bool IsCurrent { get; set; }
    }
}
