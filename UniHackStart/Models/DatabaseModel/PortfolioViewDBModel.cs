using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniHackStart.Models.DatabaseModel
{
    public class PortfolioViewDBModel
    {
        public long Id { get; set; }

        public long StudentId { get; set; }

        public string Fio { get; set; }

        public long Achievement { get; set; }

        public long NumberMark { get; set; }
    }
}
