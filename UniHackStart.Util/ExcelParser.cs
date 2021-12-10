using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using ExcelDataReader;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient;
using UniHackStart.Util.ExcelObjects;
using UniHackStart.Model.Database;

namespace UniHackStart.Util
{
    public class ExcelParser
    {
        public static void Start(TimeTableReester reester)
        {
            List<ExcelGroup> groupList = new List<ExcelGroup>();

            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            using (var stream = File.Open(reester.FilePath, FileMode.Open, FileAccess.Read))
            {
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {

                    do
                    {
                        while (reader.Read())
                        {
                            // reader.GetDouble(0);
                        }
                    } while (reader.NextResult());

                    // Преобразовываем excel в dataSet
                    var result = reader.AsDataSet();

                    List<ExcelGroup> listGroups = new List<ExcelGroup>();

                    foreach (DataTable dt in result.Tables)
                    {
                        var indexs = GetValueIndexs(dt.TableName);
                        int fWeekIndexStart = indexs.f1;
                        int fWeekIndexEnd = indexs.f2;
                        int sWeekIndexStart = indexs.f3;
                        int sWeekIndexEnd = indexs.f4;

                        //Первая неделя расписания
                        for (int i = fWeekIndexStart; i <= fWeekIndexEnd; i++)
                        {
                            ExcelGroup group = new ExcelGroup();
                            group.paraList = new List<ExcelPara>();
                            group.weekNumber = 1;
                            group.groupName = dt.Rows[0][i].ToString();

                            int indexDay = 1;
                            for (int j = 1; j < dt.Rows.Count; j++)
                            {
                                if (!string.IsNullOrWhiteSpace(dt.Rows[j][0].ToString()) && indexDay < 7)
                                {
                                    //Встали на строку с днем недели и от нее начинаем бегать по всем парам
                                    for (int k = j; k < dt.Rows.Count - 1; k++)
                                    {
                                        //Производим полную инициализацию
                                        ExcelPara para = new ExcelPara();
                                        para.timeList = new List<ExcelTime>();
                                        para.lesson = new ExcelLesson();

                                        //Получаем день недели
                                        para.dayOfWeek = dt.Rows[j][0].ToString();

                                        //Получаем время
                                        for (int l = 0; l < 2; l++)
                                        {
                                            string[] t = dt.Rows[k + l][1].ToString().Split("-");
                                            if (t.Length > 1)
                                                para.timeList.Add(ExcelTime.GetTime(t[0], t[1]));
                                        }

                                        //Получаем занятия и приписку с Преподавателем, корпусом и кабинетом; i - колонка группы
                                        para.lesson = ExcelLesson.GetLesson(dt.Rows[k][i].ToString(),
                                            dt.Rows[k + 1][i].ToString());

                                        //Получаем номер пары
                                        //Где то в конце расписания нет номера пары, но есть время, значит она восьмая
                                        para.Number = string.IsNullOrWhiteSpace(dt.Rows[k][2].ToString())
                                            ? 8
                                            : int.Parse(dt.Rows[k][2].ToString());

                                        if (para.Number == 8 && !group.paraList
                                                .Where(w => w.dayOfWeek == para.dayOfWeek).ToList()
                                                .Exists(e => e.Number == 7))
                                        {
                                            para.Number = 7;
                                        }

                                        if (group.paraList.Where(w => w.dayOfWeek == para.dayOfWeek).ToList()
                                            .Exists(e => e.Number == para.Number))
                                            break;

                                        k++;
                                        group.paraList.Add(para);
                                    }

                                    indexDay++;
                                }
                            }

                            listGroups.Add(group);
                        }

                        //Вторая неделя расписания
                        for (int i = sWeekIndexStart; i <= sWeekIndexEnd; i++)
                        {
                            ExcelGroup group = new ExcelGroup();
                            group.paraList = new List<ExcelPara>();
                            group.weekNumber = 2;
                            group.groupName = dt.Rows[0][i].ToString();

                            int indexDay = 1;
                            for (int j = 1; j < dt.Rows.Count; j++)
                            {
                                if (!string.IsNullOrWhiteSpace(dt.Rows[j][0].ToString()) && indexDay < 7)
                                {
                                    //Встали на строку с днем недели и от нее начинаем бегать по всем парам
                                    for (int k = j; k < dt.Rows.Count - 1; k++)
                                    {
                                        //Производим полную инициализацию
                                        ExcelPara para = new ExcelPara();
                                        para.timeList = new List<ExcelTime>();
                                        para.lesson = new ExcelLesson();

                                        //Получаем день недели
                                        para.dayOfWeek = dt.Rows[j][0].ToString();

                                        //Получаем время
                                        for (int l = 0; l < 2; l++)
                                        {
                                            string[] t = dt.Rows[k + l][1].ToString().Split("-");
                                            if (t.Length > 1)
                                                para.timeList.Add(ExcelTime.GetTime(t[0], t[1]));
                                        }

                                        //Получаем занятия и приписку с Преподавателем, корпусом и кабинетом; i - колонка группы
                                        para.lesson = ExcelLesson.GetLesson(dt.Rows[k][i].ToString(),
                                            dt.Rows[k + 1][i].ToString());

                                        //Получаем номер пары
                                        //Где то в конце расписания нет номера пары, но есть время, значит она восьмая
                                        para.Number = string.IsNullOrWhiteSpace(dt.Rows[k][2].ToString())
                                            ? 8
                                            : int.Parse(dt.Rows[k][2].ToString());

                                        if (para.Number == 8 && !group.paraList
                                                .Where(w => w.dayOfWeek == para.dayOfWeek).ToList()
                                                .Exists(e => e.Number == 7))
                                        {
                                            para.Number = 7;
                                        }

                                        if (group.paraList.Where(w => w.dayOfWeek == para.dayOfWeek).ToList()
                                            .Exists(e => e.Number == para.Number))
                                            break;

                                        k++;
                                        group.paraList.Add(para);
                                    }

                                    indexDay++;
                                }
                            }

                            listGroups.Add(group);
                        }
                    }

                    groupList = listGroups;
                }
            }

            SaveParsing(groupList, reester.Id);
        }

        private static void SaveParsing(List<ExcelGroup> groupList, long reesterId)
        {
            /*
             * 1 - день недели;
             * 2 - группа;
             * 3 - день недели;
             * 4 - номер пары;
             * 5 - время первой половины пары;
             * 6 - время второй половины пары;
             * 7 - наименование урока;
             * 8 - тип урока;
             * 9 - фио преподавателя;
             * 10 - корпус;
             * 11 - кабинет;
             */

            using (var db = new UniHackStartDbContext())
            {
                List<TimeTableReesterRecord> listRecords = new List<TimeTableReesterRecord>();

                foreach (ExcelGroup g in groupList)
                {
                    var headerApx = $"{g.weekNumber};{g.groupName};";


                    foreach (ExcelPara p in g.paraList)
                    {
                        string apx = headerApx;

                        string paraStart = $"{p.timeList[0].timeStart}+{p.timeList[0].timeEnd}";
                        string paraEnd = $"{p.timeList[1].timeStart}+{p.timeList[1].timeEnd}";

                        apx += $"{p.dayOfWeek};{p.Number};{paraStart};{paraEnd};";
                        apx +=
                            $"{p.lesson.name}+{p.lesson.type}+{p.lesson.teacher}+{p.lesson.corpus}+{p.lesson.classRoom};";

                        TimeTableReesterRecord rr = new TimeTableReesterRecord();
                        rr.ReesterId = reesterId;
                        rr.Apx = apx;
                        listRecords.Add(rr);
                    }
                }

                //Инсертим список записей
                db.TimeTableReesterRecords.AddRange(listRecords);
                db.SaveChanges();
            }
        }

        public static string RegistryProcessingTimeTable(long reesterId)
        {
            string msg = string.Empty;

            using (var db = new UniHackStartDbContext())
            {
                SqlParameter[] sp = new SqlParameter[2];
                sp[0] = new SqlParameter("@reesterId", SqlDbType.BigInt);
                sp[0].Value = reesterId;
                sp[1] = new SqlParameter("@msg", SqlDbType.VarChar);
                sp[1].Direction = ParameterDirection.Output;
                sp[1].Value = msg;

                db.Database.ExecuteSqlRaw("mifi.RegistryProcessingTimeTable @reesterId, @msg OUT", sp);

                string errorMessage = sp[1].Value.ToString();

                return errorMessage;
            }
        }

        public static void SetCurrentTimeTable(long reesterId)
        {
            using (var db = new UniHackStartDbContext())
            {

                TimeTableReester ttr = db.TimeTableReesters.FirstOrDefault(w => w.IsCurrent);
                if (ttr != null)
                {
                    ttr.IsCurrent = false;
                    db.SaveChanges();
                }

                SqlParameter[] sp = new SqlParameter[1];
                sp[0] = new SqlParameter("@reesterId", SqlDbType.BigInt);
                sp[0].Value = reesterId;
                db.Database.ExecuteSqlRaw("mifi.UpdateTimeTable @reesterId", sp);

                ttr = db.TimeTableReesters.FirstOrDefault(w => w.Id == reesterId);

                if (ttr != null)
                {
                    ttr.IsCurrent = true;
                    db.SaveChanges();
                }
            }
        }

        private static (int f1, int f2, int f3, int f4) GetValueIndexs(string tableName)
        {
            switch (tableName)
            {
                case "5 курс":
                    return (3, 7, 11, 15);
                case "магистратура":
                    return (3, 18, 22, 37);
                default:
                    return (3, 14, 18, 28);
            }
        }
    }
}

