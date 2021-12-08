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
            CorpusContents = new HashSet<CorpusContent>();
            TimeTableReesterRecords = new HashSet<TimeTableReesterRecord>();
        }

        [Key]
        [Column("id")]
        public long Id { get; set; }
        [Required]
        [Column("name")]
        [StringLength(10)]
        public string Name { get; set; }

        [InverseProperty(nameof(CorpusContent.CorpusNavigation))]
        public virtual ICollection<CorpusContent> CorpusContents { get; set; }
        [InverseProperty(nameof(TimeTableReesterRecord.Corps))]
        public virtual ICollection<TimeTableReesterRecord> TimeTableReesterRecords { get; set; }
    }
}
