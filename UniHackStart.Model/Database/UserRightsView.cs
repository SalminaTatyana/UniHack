using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace UniHackStart.Model.Database
{
    [Keyless]
    public partial class UserRightsView
    {
        [Column("id")]
        public long Id { get; set; }
        [Column("userId")]
        public long UserId { get; set; }
        [Required]
        [Column("login")]
        [StringLength(255)]
        public string Login { get; set; }
        [Column("rightId")]
        public long RightId { get; set; }
        [Required]
        [Column("name")]
        [StringLength(255)]
        public string Name { get; set; }
    }
}
