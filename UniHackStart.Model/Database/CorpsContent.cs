using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace UniHackStart.Model.Database
{
    [Table("CorpsContent", Schema = "mifi")]
    public partial class CorpsContent
    {
        [Key]
        [Column("id")]
        public long Id { get; set; }
        [Column("corpsId")]
        public long CorpsId { get; set; }
        [Column("classRoomId")]
        public long ClassRoomId { get; set; }

        [ForeignKey(nameof(CorpsId))]
        [InverseProperty(nameof(ClassRoom.CorpsContents))]
        public virtual ClassRoom Corps { get; set; }
        [ForeignKey(nameof(CorpsId))]
        [InverseProperty("CorpsContents")]
        public virtual Corps CorpsNavigation { get; set; }
    }
}
