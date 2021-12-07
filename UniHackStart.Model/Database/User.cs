using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace UniHackStart.Model.Database
{
    [Table("Users", Schema = "mifi")]
    public partial class User
    {
        public User()
        {
            Students = new HashSet<Student>();
            Teachers = new HashSet<Teacher>();
            TimeTableReesters = new HashSet<TimeTableReester>();
            UserRights = new HashSet<UserRight>();
        }

        [Key]
        [Column("id")]
        public long Id { get; set; }
        [Required]
        [Column("login")]
        [StringLength(255)]
        public string Login { get; set; }
        [Required]
        [Column("password")]
        [StringLength(255)]
        public string Password { get; set; }
        [Required]
        [Column("email")]
        [StringLength(255)]
        public string Email { get; set; }
        [Column("isLocked")]
        public bool IsLocked { get; set; }

        [InverseProperty(nameof(Student.User))]
        public virtual ICollection<Student> Students { get; set; }
        [InverseProperty(nameof(Teacher.User))]
        public virtual ICollection<Teacher> Teachers { get; set; }
        [InverseProperty(nameof(TimeTableReester.User))]
        public virtual ICollection<TimeTableReester> TimeTableReesters { get; set; }
        [InverseProperty(nameof(UserRight.User))]
        public virtual ICollection<UserRight> UserRights { get; set; }
    }
}
