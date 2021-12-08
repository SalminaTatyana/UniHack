using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace UniHackStart.Model.Database
{
    [Table("Specialties", Schema = "mifi")]
    public partial class Specialty
    {
        public Specialty()
        {
            Groups = new HashSet<Group>();
            Students = new HashSet<Student>();
        }

        [Key]
        [Column("id")]
        public long Id { get; set; }
        [Required]
        [Column("name")]
        [StringLength(255)]
        public string Name { get; set; }
        [Column("number")]
        [StringLength(255)]
        public string Number { get; set; }
        [Column("facultyId")]
        public long FacultyId { get; set; }

        [ForeignKey(nameof(FacultyId))]
        [InverseProperty("Specialties")]
        public virtual Faculty Faculty { get; set; }
        [InverseProperty(nameof(Group.Speciality))]
        public virtual ICollection<Group> Groups { get; set; }
        [InverseProperty(nameof(Student.Speciality))]
        public virtual ICollection<Student> Students { get; set; }
    }
}
