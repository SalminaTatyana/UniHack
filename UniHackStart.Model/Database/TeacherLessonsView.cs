using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace UniHackStart.Model.Database
{
    [Keyless]
    public partial class TeacherLessonsView
    {
        [Column("id")]
        public long Id { get; set; }
        [Column("teacherId")]
        public long TeacherId { get; set; }
        [Required]
        [Column("teacherFIO")]
        [StringLength(767)]
        public string TeacherFio { get; set; }
        [Column("lessonId")]
        public long LessonId { get; set; }
        [Required]
        [Column("lessonName")]
        [StringLength(255)]
        public string LessonName { get; set; }
    }
}
