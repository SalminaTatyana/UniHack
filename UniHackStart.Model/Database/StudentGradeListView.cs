using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace UniHackStart.Model.Database
{
    [Keyless]
    public partial class StudentGradeListView
    {
        [Column("id")]
        public long Id { get; set; }
        [Column("studentId")]
        public long StudentId { get; set; }
        [Required]
        [Column("studentFIO")]
        [StringLength(767)]
        public string StudentFio { get; set; }
        [Column("lessonId")]
        public long LessonId { get; set; }
        [Required]
        [Column("name")]
        [StringLength(255)]
        public string Name { get; set; }
        [Column("teacherId")]
        public long TeacherId { get; set; }
        [Required]
        [Column("teacherFIO")]
        [StringLength(767)]
        public string TeacherFio { get; set; }
        [Column("created", TypeName = "datetime")]
        public DateTime Created { get; set; }
        [Column("points", TypeName = "decimal(18, 0)")]
        public decimal Points { get; set; }
    }
}
