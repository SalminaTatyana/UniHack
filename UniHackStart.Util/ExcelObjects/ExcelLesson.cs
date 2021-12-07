using System.Linq;

namespace UniHackStart.Util.ExcelObjects
{
    public class ExcelLesson
    {
        public string name { get; set; }
        public string type { get; set; }
        public string teacher { get; set; }
        public string corpus { get; set; }
        public string classRoom { get; set; }

        public static ExcelLesson GetLesson(string rowFirst, string rowSecond)
        {
            if (string.IsNullOrWhiteSpace(rowFirst))
                return new ExcelLesson();

            ExcelLesson l = new ExcelLesson();

            string[] s1 = rowFirst.Split('-');

            if (s1.Length > 2)
                l.name = s1[0] + "-" + s1[1];

            if (s1.Length == 2)
                l.name = s1[0] ?? "";

            if (s1.Length > 2)
                l.type = s1[2] ?? "";
            else if (s1.Length > 1)
                l.type = s1[1] ?? "";

            string[] s2 = rowSecond.Split(' ').Where(w => !string.IsNullOrWhiteSpace(w)).ToArray();

            if (!string.IsNullOrWhiteSpace(rowSecond))
            {
                if (s1.Length > 2)
                    l.teacher = s2[0] ?? "" + s1[1] ?? "";
                else
                    l.teacher = s2[0] ?? "";

                if (s2.Length > 1)
                {
                    string[] s3 = s2[1]?.Split('-');
                    if (s3.Length > 1)
                    {
                        l.corpus = s3[0] ?? "";
                        l.classRoom = s3[1] ?? "";
                    }
                    else
                        l.classRoom = s3[0] ?? "";
                }
            }

            return l;
        }
    }
}
