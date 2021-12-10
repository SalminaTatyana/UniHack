using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace UniHackStart.Model.Database
{
    [Keyless]
    public partial class FacultyTeachersView
    {
        [Column("id")]
        public long Id { get; set; }
        [Column("facultyId")]
        public long FacultyId { get; set; }
        [Column("name")]
        [StringLength(255)]
        public string Name { get; set; }
        [Column("teacherId")]
        public long TeacherId { get; set; }
        [Required]
        [Column("FIO")]
        [StringLength(767)]
        public string Fio { get; set; }
    }
}
