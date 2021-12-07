using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace UniHackStart.Model.Database
{
    [Table("Students", Schema = "mifi")]
    public partial class Student
    {
        public Student()
        {
            Portfolios = new HashSet<Portfolio>();
            StudentGradeLists = new HashSet<StudentGradeList>();
        }

        [Key]
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
        [Column("dateOfBirth", TypeName = "datetime")]
        public DateTime DateOfBirth { get; set; }
        [Required]
        [Column("email")]
        [StringLength(255)]
        public string Email { get; set; }
        [Column("specialityId")]
        public long SpecialityId { get; set; }
        [Column("courseId")]
        public long CourseId { get; set; }
        [Column("groupId")]
        public long GroupId { get; set; }
        [Column("userId")]
        public long UserId { get; set; }

        [ForeignKey(nameof(CourseId))]
        [InverseProperty("Students")]
        public virtual Course Course { get; set; }
        [ForeignKey(nameof(GroupId))]
        [InverseProperty("Students")]
        public virtual Group Group { get; set; }
        [ForeignKey(nameof(SpecialityId))]
        [InverseProperty(nameof(Specialty.Students))]
        public virtual Specialty Speciality { get; set; }
        [ForeignKey(nameof(UserId))]
        [InverseProperty("Students")]
        public virtual User User { get; set; }
        [InverseProperty(nameof(Portfolio.Student))]
        public virtual ICollection<Portfolio> Portfolios { get; set; }
        [InverseProperty(nameof(StudentGradeList.Student))]
        public virtual ICollection<StudentGradeList> StudentGradeLists { get; set; }
    }
}
