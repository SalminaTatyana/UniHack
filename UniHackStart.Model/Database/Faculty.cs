using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace UniHackStart.Model.Database
{
    [Table("Faculties", Schema = "mifi")]
    public partial class Faculty
    {
        public Faculty()
        {
            FacultyLessons = new HashSet<FacultyLesson>();
            FacultyTeachers = new HashSet<FacultyTeacher>();
            Specialties = new HashSet<Specialty>();
        }

        [Key]
        [Column("id")]
        public long Id { get; set; }
        [Column("name")]
        [StringLength(255)]
        public string Name { get; set; }

        [InverseProperty(nameof(FacultyLesson.Faculty))]
        public virtual ICollection<FacultyLesson> FacultyLessons { get; set; }
        [InverseProperty(nameof(FacultyTeacher.Faculty))]
        public virtual ICollection<FacultyTeacher> FacultyTeachers { get; set; }
        [InverseProperty(nameof(Specialty.FacultyGroup))]
        public virtual ICollection<Specialty> Specialties { get; set; }
    }
}
