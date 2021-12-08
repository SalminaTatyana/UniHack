using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace UniHackStart.Model.Database
{
    [Keyless]
    public partial class SpecialtiesView
    {
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
        [Column("facultyName")]
        [StringLength(255)]
        public string FacultyName { get; set; }
    }
}
