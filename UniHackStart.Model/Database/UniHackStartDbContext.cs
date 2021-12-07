using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace UniHackStart.Model.Database
{
    public partial class UniHackStartDbContext : DbContext
    {
        public UniHackStartDbContext()
        {
        }

        public UniHackStartDbContext(DbContextOptions<UniHackStartDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Faculty> Faculties { get; set; }
        public virtual DbSet<FacultyLesson> FacultyLessons { get; set; }
        public virtual DbSet<FacultyLessonsView> FacultyLessonsViews { get; set; }
        public virtual DbSet<Group> Groups { get; set; }
        public virtual DbSet<GroupsView> GroupsViews { get; set; }
        public virtual DbSet<Lesson> Lessons { get; set; }
        public virtual DbSet<Portfolio> Portfolios { get; set; }
        public virtual DbSet<PortfolioView> PortfolioViews { get; set; }
        public virtual DbSet<Right> Rights { get; set; }
        public virtual DbSet<SpecialtiesView> SpecialtiesViews { get; set; }
        public virtual DbSet<Specialty> Specialties { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<StudentGradeList> StudentGradeLists { get; set; }
        public virtual DbSet<StudentGradeListView> StudentGradeListViews { get; set; }
        public virtual DbSet<StudentsView> StudentsViews { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; }
        public virtual DbSet<TeacherLesson> TeacherLessons { get; set; }
        public virtual DbSet<TeacherLessonsView> TeacherLessonsViews { get; set; }
        public virtual DbSet<TeachersView> TeachersViews { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserRight> UserRights { get; set; }
        public virtual DbSet<UserRightsView> UserRightsViews { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server = (local); Database = XakatonBD; Trusted_Connection = True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Cyrillic_General_CI_AS");

            modelBuilder.Entity<Faculty>(entity =>
            {
                entity.Property(e => e.Name).IsUnicode(false);
            });

            modelBuilder.Entity<FacultyLesson>(entity =>
            {
                entity.HasOne(d => d.Faculty)
                    .WithMany(p => p.FacultyLessons)
                    .HasForeignKey(d => d.FacultyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FacultyLessons_Faculties");

                entity.HasOne(d => d.Lesson)
                    .WithMany(p => p.FacultyLessons)
                    .HasForeignKey(d => d.LessonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FacultyLessons_Lessons");
            });

            modelBuilder.Entity<FacultyLessonsView>(entity =>
            {
                entity.ToView("FacultyLessonsView", "mifi");

                entity.Property(e => e.FacultyName).IsUnicode(false);

                entity.Property(e => e.LessonName).IsUnicode(false);
            });

            modelBuilder.Entity<Group>(entity =>
            {
                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.ShortName).IsUnicode(false);

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.Groups)
                    .HasForeignKey(d => d.CourseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Groups_Courses");

                entity.HasOne(d => d.Speciality)
                    .WithMany(p => p.Groups)
                    .HasForeignKey(d => d.SpecialityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Groups_Specialties");
            });

            modelBuilder.Entity<GroupsView>(entity =>
            {
                entity.ToView("GroupsView", "mifi");

                entity.Property(e => e.GroupName).IsUnicode(false);

                entity.Property(e => e.GroupShortName).IsUnicode(false);

                entity.Property(e => e.SpecialityName).IsUnicode(false);

                entity.Property(e => e.SpecialityNumber).IsUnicode(false);
            });

            modelBuilder.Entity<Lesson>(entity =>
            {
                entity.Property(e => e.Name).IsUnicode(false);
            });

            modelBuilder.Entity<Portfolio>(entity =>
            {
                entity.HasOne(d => d.Student)
                    .WithMany(p => p.Portfolios)
                    .HasForeignKey(d => d.StudentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Portfolio_Students");
            });

            modelBuilder.Entity<PortfolioView>(entity =>
            {
                entity.ToView("PortfolioView", "mifi");

                entity.Property(e => e.Fio).IsUnicode(false);
            });

            modelBuilder.Entity<Right>(entity =>
            {
                entity.Property(e => e.Name).IsUnicode(false);
            });

            modelBuilder.Entity<SpecialtiesView>(entity =>
            {
                entity.ToView("SpecialtiesView", "mifi");

                entity.Property(e => e.FacultyName).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Number).IsUnicode(false);
            });

            modelBuilder.Entity<Specialty>(entity =>
            {
                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Number).IsUnicode(false);

                entity.HasOne(d => d.Faculty)
                    .WithMany(p => p.Specialties)
                    .HasForeignKey(d => d.FacultyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Specialties_Faculties");
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.Property(e => e.Email).IsUnicode(false);

                entity.Property(e => e.FirstName).IsUnicode(false);

                entity.Property(e => e.LastName).IsUnicode(false);

                entity.Property(e => e.MiddleName).IsUnicode(false);

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.Students)
                    .HasForeignKey(d => d.CourseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Students_Courses");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.Students)
                    .HasForeignKey(d => d.GroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Students_Groups");

                entity.HasOne(d => d.Speciality)
                    .WithMany(p => p.Students)
                    .HasForeignKey(d => d.SpecialityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Students_Specialties");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Students)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Students_Users");
            });

            modelBuilder.Entity<StudentGradeList>(entity =>
            {
                entity.Property(e => e.Created).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Lesson)
                    .WithMany(p => p.StudentGradeLists)
                    .HasForeignKey(d => d.LessonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StudentGradeList_Lessons");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.StudentGradeLists)
                    .HasForeignKey(d => d.StudentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StudentGradeList_Students");

                entity.HasOne(d => d.Teacher)
                    .WithMany(p => p.StudentGradeLists)
                    .HasForeignKey(d => d.TeacherId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StudentGradeList_Teachers");
            });

            modelBuilder.Entity<StudentGradeListView>(entity =>
            {
                entity.ToView("StudentGradeListView", "mifi");

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.StudentFio).IsUnicode(false);

                entity.Property(e => e.TeacherFio).IsUnicode(false);
            });

            modelBuilder.Entity<StudentsView>(entity =>
            {
                entity.ToView("StudentsView", "mifi");

                entity.Property(e => e.Email).IsUnicode(false);

                entity.Property(e => e.Fio).IsUnicode(false);

                entity.Property(e => e.FirstName).IsUnicode(false);

                entity.Property(e => e.GroupName).IsUnicode(false);

                entity.Property(e => e.GroupShortName).IsUnicode(false);

                entity.Property(e => e.LastName).IsUnicode(false);

                entity.Property(e => e.MiddleName).IsUnicode(false);

                entity.Property(e => e.SpecialityName).IsUnicode(false);

                entity.Property(e => e.SpecialityNumber).IsUnicode(false);

                entity.Property(e => e.UserLogin).IsUnicode(false);
            });

            modelBuilder.Entity<Teacher>(entity =>
            {
                entity.Property(e => e.Email).IsUnicode(false);

                entity.Property(e => e.FirstName).IsUnicode(false);

                entity.Property(e => e.LastName).IsUnicode(false);

                entity.Property(e => e.MiddleName).IsUnicode(false);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Teachers)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Teachers_Users");
            });

            modelBuilder.Entity<TeacherLesson>(entity =>
            {
                entity.HasOne(d => d.Lesson)
                    .WithMany(p => p.TeacherLessons)
                    .HasForeignKey(d => d.LessonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TeacherLessons_Lessons");

                entity.HasOne(d => d.Teacher)
                    .WithMany(p => p.TeacherLessons)
                    .HasForeignKey(d => d.TeacherId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TeacherLessons_Teachers");
            });

            modelBuilder.Entity<TeacherLessonsView>(entity =>
            {
                entity.ToView("TeacherLessonsView", "mifi");

                entity.Property(e => e.LessonName).IsUnicode(false);

                entity.Property(e => e.TeacherFio).IsUnicode(false);
            });

            modelBuilder.Entity<TeachersView>(entity =>
            {
                entity.ToView("TeachersView", "mifi");

                entity.Property(e => e.Email).IsUnicode(false);

                entity.Property(e => e.Fio).IsUnicode(false);

                entity.Property(e => e.FirstName).IsUnicode(false);

                entity.Property(e => e.LastName).IsUnicode(false);

                entity.Property(e => e.Login).IsUnicode(false);

                entity.Property(e => e.MiddleName).IsUnicode(false);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.Email).IsUnicode(false);

                entity.Property(e => e.Login).IsUnicode(false);

                entity.Property(e => e.Password).IsUnicode(false);
            });

            modelBuilder.Entity<UserRight>(entity =>
            {
                entity.HasOne(d => d.Right)
                    .WithMany(p => p.UserRights)
                    .HasForeignKey(d => d.RightId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserRights_Rights");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserRights)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserRights_Users");
            });

            modelBuilder.Entity<UserRightsView>(entity =>
            {
                entity.ToView("UserRightsView", "mifi");

                entity.Property(e => e.Login).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
