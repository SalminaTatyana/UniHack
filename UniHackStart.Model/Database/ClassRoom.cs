using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace UniHackStart.Model.Database
{
    [Table("ClassRooms", Schema = "mifi")]
    public partial class ClassRoom
    {
        public ClassRoom()
        {
            CorpsContents = new HashSet<CorpsContent>();
            TimeTableReesterRecords = new HashSet<TimeTableReesterRecord>();
            TimeTables = new HashSet<TimeTable>();
        }

        [Key]
        [Column("id")]
        public long Id { get; set; }
        [Column("name")]
        [StringLength(10)]
        public string Name { get; set; }

        [InverseProperty(nameof(CorpsContent.Corps))]
        public virtual ICollection<CorpsContent> CorpsContents { get; set; }
        [InverseProperty(nameof(TimeTableReesterRecord.ClassRoom))]
        public virtual ICollection<TimeTableReesterRecord> TimeTableReesterRecords { get; set; }
        [InverseProperty(nameof(TimeTable.ClassRoom))]
        public virtual ICollection<TimeTable> TimeTables { get; set; }
    }
}
