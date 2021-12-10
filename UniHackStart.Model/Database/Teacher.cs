using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace UniHackStart.Model.Database
{
    [Table("Teachers", Schema = "mifi")]
    public partial class Teacher
    {
        public Teacher()
        {
            FacultyTeachers = new HashSet<FacultyTeacher>();
            StudentGradeLists = new HashSet<StudentGradeList>();
            TeacherLessons = new HashSet<TeacherLesson>();
            TimeTableReesterRecords = new HashSet<TimeTableReesterRecord>();
            TimeTables = new HashSet<TimeTable>();
        }

        [Key]
        [Column("id")]
        public long Id { get; set; }
        [Required]
        [Column("lastName")]
        [StringLength(255)]
        public string LastName { get; set; }
        [Required]
        [Column("firstName")]
        [StringLength(255)]
        public string FirstName { get; set; }
        [Required]
        [Column("middleName")]
        [StringLength(255)]
        public string MiddleName { get; set; }
        [Column("dateOfBirth", TypeName = "datetime")]
        public DateTime? DateOfBirth { get; set; }
        [Column("email")]
        [StringLength(255)]
        public string Email { get; set; }
        [Column("phone")]
        [StringLength(20)]
        public string Phone { get; set; }
        [Column("userId")]
        public long? UserId { get; set; }

        [ForeignKey(nameof(UserId))]
        [InverseProperty("Teachers")]
        public virtual User User { get; set; }
        [InverseProperty(nameof(FacultyTeacher.FacultyNavigation))]
        public virtual ICollection<FacultyTeacher> FacultyTeachers { get; set; }
        [InverseProperty(nameof(StudentGradeList.Teacher))]
        public virtual ICollection<StudentGradeList> StudentGradeLists { get; set; }
        [InverseProperty(nameof(TeacherLesson.Teacher))]
        public virtual ICollection<TeacherLesson> TeacherLessons { get; set; }
        [InverseProperty(nameof(TimeTableReesterRecord.Teacher))]
        public virtual ICollection<TimeTableReesterRecord> TimeTableReesterRecords { get; set; }
        [InverseProperty(nameof(TimeTable.Teacher))]
        public virtual ICollection<TimeTable> TimeTables { get; set; }
    }
}
