using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace UniHackStart.Model.Database
{
    [Table("TimeTableReesters", Schema = "mifi")]
    public partial class TimeTableReester
    {
        public TimeTableReester()
        {
            TimeTableReesterRecords = new HashSet<TimeTableReesterRecord>();
        }

        [Key]
        [Column("id")]
        public long Id { get; set; }
        [Column("created", TypeName = "datetime")]
        public DateTime Created { get; set; }
        [Required]
        [Column("fileName")]
        [StringLength(255)]
        public string FileName { get; set; }
        [Column("userId")]
        public long UserId { get; set; }
        [Column("filePath")]
        [StringLength(255)]
        public string FilePath { get; set; }

        [ForeignKey(nameof(UserId))]
        [InverseProperty("TimeTableReesters")]
        public virtual User User { get; set; }
        [InverseProperty(nameof(TimeTableReesterRecord.Reester))]
        public virtual ICollection<TimeTableReesterRecord> TimeTableReesterRecords { get; set; }
    }
}
