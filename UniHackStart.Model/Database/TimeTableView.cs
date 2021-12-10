using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace UniHackStart.Model.Database
{
    [Keyless]
    public partial class TimeTableView
    {
        [Column("weekNumber")]
        [StringLength(255)]
        public string WeekNumber { get; set; }
        [Column("groupId")]
        public long? GroupId { get; set; }
        [Column("groupName")]
        [StringLength(50)]
        public string GroupName { get; set; }
        [Column("dayOfWeekId")]
        public long? DayOfWeekId { get; set; }
        [Column("daysOfWeeks")]
        [StringLength(30)]
        public string DaysOfWeeks { get; set; }
        [Column("paraNumber")]
        [StringLength(1)]
        public string ParaNumber { get; set; }
        [Column("timeStart_1")]
        [StringLength(20)]
        public string TimeStart1 { get; set; }
        [Column("timeEnd_1")]
        [StringLength(20)]
        public string TimeEnd1 { get; set; }
        [Column("timeStart_2")]
        [StringLength(20)]
        public string TimeStart2 { get; set; }
        [Column("timeEnd_2")]
        [StringLength(20)]
        public string TimeEnd2 { get; set; }
        [Column("lessonId")]
        public long? LessonId { get; set; }
        [Column("lessonName")]
        [StringLength(255)]
        public string LessonName { get; set; }
        [Column("lessonTypeId")]
        public long? LessonTypeId { get; set; }
        [Column("lessonTypeShortName")]
        [StringLength(100)]
        public string LessonTypeShortName { get; set; }
        [Column("teacherId")]
        public long? TeacherId { get; set; }
        [Column("FIO")]
        [StringLength(767)]
        public string Fio { get; set; }
        [Column("corpsId")]
        public long? CorpsId { get; set; }
        [Column("corpusName")]
        [StringLength(10)]
        public string CorpusName { get; set; }
        [Column("classRoomId")]
        public long? ClassRoomId { get; set; }
        [Column("classRoomName")]
        [StringLength(10)]
        public string ClassRoomName { get; set; }
    }
}
