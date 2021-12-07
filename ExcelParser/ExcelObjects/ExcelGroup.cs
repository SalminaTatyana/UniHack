using System.Collections.Generic;

namespace UniHackStart.Util.ExcelObjects
{
    public class ExcelGroup
    {
        public int weekNumber { get; set; }
        public string groupName { get; set; }
        public List<ExcelPara> paraList { get; set; }
    }
}
