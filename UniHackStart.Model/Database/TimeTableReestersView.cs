using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace UniHackStart.Model.Database
{
    [Keyless]
    public partial class TimeTableReestersView
    {
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
        [Column("login")]
        [StringLength(255)]
        public string Login { get; set; }
        [Column("filePath")]
        [StringLength(255)]
        public string FilePath { get; set; }
        [Column("isCurrent")]
        public bool IsCurrent { get; set; }
    }
}
