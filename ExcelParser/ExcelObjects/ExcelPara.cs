using System.Collections.Generic;

namespace UniHackStart.Util.ExcelObjects
{
    public class ExcelPara
    {
        public string dayOfWeek { get; set; }
        public List<ExcelTime> timeList { get; set; }
        public int Number { get; set; }
        public ExcelLesson lesson { get; set; }
    }
}
