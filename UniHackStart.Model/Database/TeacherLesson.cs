using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace UniHackStart.Model.Database
{
    [Table("TeacherLessons", Schema = "mifi")]
    public partial class TeacherLesson
    {
        [Key]
        [Column("id")]
        public long Id { get; set; }
        [Column("teacherId")]
        public long TeacherId { get; set; }
        [Column("lessonId")]
        public long LessonId { get; set; }

        [ForeignKey(nameof(LessonId))]
        [InverseProperty("TeacherLessons")]
        public virtual Lesson Lesson { get; set; }
        [ForeignKey(nameof(TeacherId))]
        [InverseProperty("TeacherLessons")]
        public virtual Teacher Teacher { get; set; }
    }
}
