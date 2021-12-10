using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace UniHackStart.Model.Database
{
    [Keyless]
    public partial class FacultiesGroupContentsView
    {
        [Column("id")]
        public long Id { get; set; }
        [Column("facultyId")]
        public long FacultyId { get; set; }
        [Column("facultyName")]
        [StringLength(255)]
        public string FacultyName { get; set; }
        [Column("facultyGroupId")]
        public long FacultyGroupId { get; set; }
        [Column("facultyGroupName")]
        [StringLength(30)]
        public string FacultyGroupName { get; set; }
    }
}
