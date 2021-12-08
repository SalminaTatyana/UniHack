using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace UniHackStart.Model.Database
{
    [Table("DaysOfWeeks", Schema = "mifi")]
    public partial class DaysOfWeek
    {
        public DaysOfWeek()
        {
            TimeTableReesterRecords = new HashSet<TimeTableReesterRecord>();
        }

        [Key]
        [Column("id")]
        public long Id { get; set; }
        [Required]
        [Column("name")]
        [StringLength(30)]
        public string Name { get; set; }

        [InverseProperty(nameof(TimeTableReesterRecord.DayOfWeek))]
        public virtual ICollection<TimeTableReesterRecord> TimeTableReesterRecords { get; set; }
    }
}
