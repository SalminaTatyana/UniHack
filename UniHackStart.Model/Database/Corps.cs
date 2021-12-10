using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace UniHackStart.Model.Database
{
    [Table("Corps", Schema = "mifi")]
    public partial class Corps
    {
        public Corps()
        {
            CorpsContents = new HashSet<CorpsContent>();
            TimeTableReesterRecords = new HashSet<TimeTableReesterRecord>();
            TimeTables = new HashSet<TimeTable>();
        }

        [Key]
        [Column("id")]
        public long Id { get; set; }
        [Required]
        [Column("name")]
        [StringLength(10)]
        public string Name { get; set; }

        [InverseProperty(nameof(CorpsContent.CorpsNavigation))]
        public virtual ICollection<CorpsContent> CorpsContents { get; set; }
        [InverseProperty(nameof(TimeTableReesterRecord.Corps))]
        public virtual ICollection<TimeTableReesterRecord> TimeTableReesterRecords { get; set; }
        [InverseProperty(nameof(TimeTable.Corps))]
        public virtual ICollection<TimeTable> TimeTables { get; set; }
    }
}
