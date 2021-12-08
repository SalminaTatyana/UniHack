using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace UniHackStart.Model.Database
{
    [Table("Portfolio", Schema = "mifi")]
    public partial class Portfolio
    {
        [Key]
        [Column("id")]
        public long Id { get; set; }
        [Column("studentId")]
        public long StudentId { get; set; }
        [Column("achievement")]
        public long Achievement { get; set; }
        [Column("numberMark")]
        public long NumberMark { get; set; }

        [ForeignKey(nameof(StudentId))]
        [InverseProperty("Portfolios")]
        public virtual Student Student { get; set; }
    }
}
