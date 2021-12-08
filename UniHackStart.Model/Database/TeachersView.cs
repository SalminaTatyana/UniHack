using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace UniHackStart.Model.Database
{
    [Keyless]
    public partial class TeachersView
    {
        [Column("id")]
        public long Id { get; set; }
        [Required]
        [Column("lastName")]
        [StringLength(255)]
        public string LastName { get; set; }
        [Required]
        [Column("firstName")]
        [StringLength(255)]
        public string FirstName { get; set; }
        [Required]
        [Column("middleName")]
        [StringLength(255)]
        public string MiddleName { get; set; }
        [Required]
        [Column("FIO")]
        [StringLength(767)]
        public string Fio { get; set; }
        [Column("dateOfBirth", TypeName = "datetime")]
        public DateTime DateOfBirth { get; set; }
        [Required]
        [Column("email")]
        [StringLength(255)]
        public string Email { get; set; }
        [Column("userId")]
        public long UserId { get; set; }
        [Required]
        [Column("login")]
        [StringLength(255)]
        public string Login { get; set; }
    }
}
