﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniHackStart.Models
{
    public class TimetableModel
    {
        public string name { get; set; }
        public string teachername { get; set; }
        public string time { get; set; }
        public string place { get; set; }

    }
    public class TimetableDayModel
    {
        public string dateOfWeek { get; set; }
        public int weekNumber { get; set; }
        public TimetableModel lesson { get; set; }
        

    }
}
