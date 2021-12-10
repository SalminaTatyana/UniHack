using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace UniHackStart.Model.Database
{
    [Table("TimeTable", Schema = "mifi")]
    public partial class TimeTable
    {
        [Key]
        [Column("id")]
        public long Id { get; set; }
        [Column("weekNumber")]
        [StringLength(255)]
        public string WeekNumber { get; set; }
        [Column("groupId")]
        public long? GroupId { get; set; }
        [Column("dayOfWeekId")]
        public long? DayOfWeekId { get; set; }
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
        [Column("lessonTypeId")]
        public long? LessonTypeId { get; set; }
        [Column("teacherId")]
        public long? TeacherId { get; set; }
        [Column("corpsId")]
        public long? CorpsId { get; set; }
        [Column("classRoomId")]
        public long? ClassRoomId { get; set; }

        [ForeignKey(nameof(ClassRoomId))]
        [InverseProperty("TimeTables")]
        public virtual ClassRoom ClassRoom { get; set; }
        [ForeignKey(nameof(CorpsId))]
        [InverseProperty("TimeTables")]
        public virtual Corps Corps { get; set; }
        [ForeignKey(nameof(DayOfWeekId))]
        [InverseProperty(nameof(DaysOfWeek.TimeTables))]
        public virtual DaysOfWeek DayOfWeek { get; set; }
        [ForeignKey(nameof(GroupId))]
        [InverseProperty("TimeTables")]
        public virtual Group Group { get; set; }
        [ForeignKey(nameof(LessonId))]
        [InverseProperty("TimeTables")]
        public virtual Lesson Lesson { get; set; }
        [ForeignKey(nameof(LessonTypeId))]
        [InverseProperty(nameof(LessonsType.TimeTables))]
        public virtual LessonsType LessonType { get; set; }
        [ForeignKey(nameof(TeacherId))]
        [InverseProperty("TimeTables")]
        public virtual Teacher Teacher { get; set; }
    }
}
