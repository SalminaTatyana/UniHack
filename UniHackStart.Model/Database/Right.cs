using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace UniHackStart.Model.Database
{
    [Table("Rights", Schema = "mifi")]
    public partial class Right
    {
        public Right()
        {
            UserRights = new HashSet<UserRight>();
        }

        [Key]
        [Column("id")]
        public long Id { get; set; }
        [Required]
        [Column("name")]
        [StringLength(255)]
        public string Name { get; set; }

        [InverseProperty(nameof(UserRight.Right))]
        public virtual ICollection<UserRight> UserRights { get; set; }
    }
}
