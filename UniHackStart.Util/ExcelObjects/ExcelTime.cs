namespace UniHackStart.Util.ExcelObjects
{
    public class ExcelTime
    {
        public string timeStart { get; set; }
        public string timeEnd { get; set; }

        public static ExcelTime GetTime(string startTime, string endTime)
        {
            ExcelTime t = new ExcelTime();

            //Начало
            if (string.IsNullOrWhiteSpace(startTime))
                t.timeStart = string.Empty;

            if (!string.IsNullOrWhiteSpace(startTime) && startTime.Length == 3)
                t.timeStart = startTime.Insert(0, "0").Insert(2, ":");

            if (!string.IsNullOrWhiteSpace(startTime) && startTime.Length == 4)
                t.timeStart = startTime.Insert(2, ":");

            //Конец
            if (string.IsNullOrWhiteSpace(endTime))
                t.timeEnd = string.Empty;

            if (!string.IsNullOrWhiteSpace(endTime) && endTime.Length == 3)
                t.timeEnd = endTime.Insert(0, "0").Insert(2, ":");

            if (!string.IsNullOrWhiteSpace(endTime) && endTime.Length == 4)
                t.timeEnd = endTime.Insert(2, ":");

            return t;
        }
    }
}
