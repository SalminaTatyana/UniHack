using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace UniHackStart.Model.Database
{
    [Table("FacultiesGroupContents", Schema = "mifi")]
    public partial class FacultiesGroupContent
    {
        [Key]
        [Column("id")]
        public long Id { get; set; }
        [Column("facultyId")]
        public long FacultyId { get; set; }
        [Column("facultyGroupId")]
        public long FacultyGroupId { get; set; }
    }
}
