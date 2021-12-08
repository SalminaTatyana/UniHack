using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace UniHackStart.Model.Database
{
    [Table("LessonsTypes", Schema = "mifi")]
    public partial class LessonsType
    {
        public LessonsType()
        {
            TimeTableReesterRecords = new HashSet<TimeTableReesterRecord>();
        }

        [Key]
        [Column("id")]
        public long Id { get; set; }
        [Column("name")]
        [StringLength(100)]
        public string Name { get; set; }
        [Column("shortName")]
        [StringLength(100)]
        public string ShortName { get; set; }

        [InverseProperty(nameof(TimeTableReesterRecord.LessonType))]
        public virtual ICollection<TimeTableReesterRecord> TimeTableReesterRecords { get; set; }
    }
}
