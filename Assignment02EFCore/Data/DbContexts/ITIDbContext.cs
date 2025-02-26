using Assignment02EFCore.Data.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02EFCore.Data.DbContexts
{
    public class ITIDbContext : DbContext
    {
        public ITIDbContext() : base()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(" Server = .; Database = ITI ; Trusted_Connection = True; Encrypt = True; TrustServerCertificate = True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Apply all configurations
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            // Composite Primary Key 
            modelBuilder.Entity<StudentCourse>().HasKey(SC => new { SC.StudentId, SC.CourseId });
            modelBuilder.Entity<CourseInstructor>().HasKey(CI => new { CI.CourseId,CI.InstructorId });

        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Topic > Topics { get; set; }
        public DbSet<Course> Courses { get; set; }


    }
}
