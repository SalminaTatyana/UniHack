using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace UniHackStart.Model.Database
{
    [Table("UserRights", Schema = "mifi")]
    public partial class UserRight
    {
        [Key]
        [Column("id")]
        public long Id { get; set; }
        [Column("userId")]
        public long UserId { get; set; }
        [Column("rightId")]
        public long RightId { get; set; }

        [ForeignKey(nameof(RightId))]
        [InverseProperty("UserRights")]
        public virtual Right Right { get; set; }
        [ForeignKey(nameof(UserId))]
        [InverseProperty("UserRights")]
        public virtual User User { get; set; }
    }
}
