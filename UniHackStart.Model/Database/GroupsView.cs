using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace UniHackStart.Model.Database
{
    [Keyless]
    public partial class GroupsView
    {
        [Column("id")]
        public long Id { get; set; }
        [Required]
        [Column("groupName")]
        [StringLength(255)]
        public string GroupName { get; set; }
        [Column("groupShortName")]
        [StringLength(255)]
        public string GroupShortName { get; set; }
        [Column("specialityId")]
        public long SpecialityId { get; set; }
        [Required]
        [Column("specialityName")]
        [StringLength(255)]
        public string SpecialityName { get; set; }
        [Column("specialityNumber")]
        [StringLength(255)]
        public string SpecialityNumber { get; set; }
        [Column("courseId")]
        public long CourseId { get; set; }
        [Column("courseName")]
        public int CourseName { get; set; }
    }
}
