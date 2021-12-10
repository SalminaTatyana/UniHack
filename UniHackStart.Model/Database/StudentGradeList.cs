using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace UniHackStart.Model.Database
{
    [Table("StudentGradeList", Schema = "mifi")]
    public partial class StudentGradeList
    {
        [Key]
        [Column("id")]
        public long Id { get; set; }
        [Column("studentId")]
        public long StudentId { get; set; }
        [Column("lessonId")]
        public long LessonId { get; set; }
        [Column("teacherId")]
        public long TeacherId { get; set; }
        [Column("created", TypeName = "datetime")]
        public DateTime Created { get; set; }
        [Column("points", TypeName = "decimal(18, 2)")]
        public decimal Points { get; set; }

        [ForeignKey(nameof(LessonId))]
        [InverseProperty("StudentGradeLists")]
        public virtual Lesson Lesson { get; set; }
        [ForeignKey(nameof(StudentId))]
        [InverseProperty("StudentGradeLists")]
        public virtual Student Student { get; set; }
        [ForeignKey(nameof(TeacherId))]
        [InverseProperty("StudentGradeLists")]
        public virtual Teacher Teacher { get; set; }
    }
}
