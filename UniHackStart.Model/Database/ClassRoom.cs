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
            CorpusContents = new HashSet<CorpusContent>();
            TimeTableReesterRecords = new HashSet<TimeTableReesterRecord>();
        }

        [Key]
        [Column("id")]
        public long Id { get; set; }
        [Column("name")]
        [StringLength(10)]
        public string Name { get; set; }

        [InverseProperty(nameof(CorpusContent.Corpus))]
        public virtual ICollection<CorpusContent> CorpusContents { get; set; }
        [InverseProperty(nameof(TimeTableReesterRecord.ClassRoom))]
        public virtual ICollection<TimeTableReesterRecord> TimeTableReesterRecords { get; set; }
    }
}
