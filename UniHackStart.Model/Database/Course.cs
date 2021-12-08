using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace UniHackStart.Model.Database
{
    [Table("Courses", Schema = "mifi")]
    public partial class Course
    {
        public Course()
        {
            Groups = new HashSet<Group>();
            Students = new HashSet<Student>();
        }

        [Key]
        [Column("id")]
        public long Id { get; set; }
        [Column("name")]
        public int Name { get; set; }

        [InverseProperty(nameof(Group.Course))]
        public virtual ICollection<Group> Groups { get; set; }
        [InverseProperty(nameof(Student.Course))]
        public virtual ICollection<Student> Students { get; set; }
    }
}
