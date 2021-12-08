using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace UniHackStart.Model.Database
{
    [Keyless]
    public partial class PortfolioView
    {
        [Column("id")]
        public long Id { get; set; }
        [Column("studentId")]
        public long StudentId { get; set; }
        [Required]
        [Column("FIO")]
        [StringLength(767)]
        public string Fio { get; set; }
        [Column("achievement")]
        public long Achievement { get; set; }
        [Column("numberMark")]
        public long NumberMark { get; set; }
    }
}
