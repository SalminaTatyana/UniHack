using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace UniHackStart.Model.Database
{
    [Keyless]
    public partial class FacultyLessonsView
    {
        [Column("id")]
        public long Id { get; set; }
        [Column("facultyId")]
        public long FacultyId { get; set; }
        [Column("facultyName")]
        [StringLength(255)]
        public string FacultyName { get; set; }
        [Column("lessonId")]
        public long LessonId { get; set; }
        [Required]
        [Column("lessonName")]
        [StringLength(255)]
        public string LessonName { get; set; }
    }
}
