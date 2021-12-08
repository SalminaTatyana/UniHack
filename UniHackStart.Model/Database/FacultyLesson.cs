using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace UniHackStart.Model.Database
{
    [Table("FacultyLessons", Schema = "mifi")]
    public partial class FacultyLesson
    {
        [Key]
        [Column("id")]
        public long Id { get; set; }
        [Column("facultyId")]
        public long FacultyId { get; set; }
        [Column("lessonId")]
        public long LessonId { get; set; }

        [ForeignKey(nameof(FacultyId))]
        [InverseProperty("FacultyLessons")]
        public virtual Faculty Faculty { get; set; }
        [ForeignKey(nameof(LessonId))]
        [InverseProperty("FacultyLessons")]
        public virtual Lesson Lesson { get; set; }
    }
}
