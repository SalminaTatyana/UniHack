using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace UniHackStart.Model.Database
{
    [Table("Lessons", Schema = "mifi")]
    public partial class Lesson
    {
        public Lesson()
        {
            FacultyLessons = new HashSet<FacultyLesson>();
            StudentGradeLists = new HashSet<StudentGradeList>();
            TeacherLessons = new HashSet<TeacherLesson>();
            TimeTableReesterRecords = new HashSet<TimeTableReesterRecord>();
            TimeTables = new HashSet<TimeTable>();
        }

        [Key]
        [Column("id")]
        public long Id { get; set; }
        [Required]
        [Column("name")]
        [StringLength(255)]
        public string Name { get; set; }

        [InverseProperty(nameof(FacultyLesson.Lesson))]
        public virtual ICollection<FacultyLesson> FacultyLessons { get; set; }
        [InverseProperty(nameof(StudentGradeList.Lesson))]
        public virtual ICollection<StudentGradeList> StudentGradeLists { get; set; }
        [InverseProperty(nameof(TeacherLesson.Lesson))]
        public virtual ICollection<TeacherLesson> TeacherLessons { get; set; }
        [InverseProperty(nameof(TimeTableReesterRecord.Lesson))]
        public virtual ICollection<TimeTableReesterRecord> TimeTableReesterRecords { get; set; }
        [InverseProperty(nameof(TimeTable.Lesson))]
        public virtual ICollection<TimeTable> TimeTables { get; set; }
    }
}
