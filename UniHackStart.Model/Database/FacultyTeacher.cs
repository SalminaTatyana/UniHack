using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace UniHackStart.Model.Database
{
    [Table("FacultyTeachers", Schema = "mifi")]
    public partial class FacultyTeacher
    {
        [Key]
        [Column("id")]
        public long Id { get; set; }
        [Column("facultyId")]
        public long FacultyId { get; set; }
        [Column("teacherId")]
        public long TeacherId { get; set; }

        [ForeignKey(nameof(FacultyId))]
        [InverseProperty("FacultyTeachers")]
        public virtual Faculty Faculty { get; set; }
        [ForeignKey(nameof(FacultyId))]
        [InverseProperty(nameof(Teacher.FacultyTeachers))]
        public virtual Teacher FacultyNavigation { get; set; }
    }
}
