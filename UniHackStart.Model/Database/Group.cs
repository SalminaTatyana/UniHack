using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace UniHackStart.Model.Database
{
    [Table("Groups", Schema = "mifi")]
    public partial class Group
    {
        public Group()
        {
            Students = new HashSet<Student>();
            TimeTableReesterRecords = new HashSet<TimeTableReesterRecord>();
        }

        [Key]
        [Column("id")]
        public long Id { get; set; }
        [Column("name")]
        public long? Name { get; set; }
        [Column("shortName")]
        [StringLength(255)]
        public string ShortName { get; set; }
        [Column("specialityId")]
        public long? SpecialityId { get; set; }
        [Column("courseId")]
        public long? CourseId { get; set; }

        [ForeignKey(nameof(CourseId))]
        [InverseProperty("Groups")]
        public virtual Course Course { get; set; }
        [ForeignKey(nameof(SpecialityId))]
        [InverseProperty(nameof(Specialty.Groups))]
        public virtual Specialty Speciality { get; set; }
        [InverseProperty(nameof(Student.Group))]
        public virtual ICollection<Student> Students { get; set; }
        [InverseProperty(nameof(TimeTableReesterRecord.Group))]
        public virtual ICollection<TimeTableReesterRecord> TimeTableReesterRecords { get; set; }
    }
}
