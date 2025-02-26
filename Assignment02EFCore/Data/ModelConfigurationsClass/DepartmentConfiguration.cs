using Assignment02EFCore.Data.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02EFCore.Data.ModelConfigurationsClass
{
    public class DepartmentConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.ToTable("Departments", "dbo");
            builder.HasKey(d => d.DepartmentID);
            builder.Property(d => d.DepartmentID).UseIdentityColumn(10, 10);
            builder.Property(d => d.Name).HasColumnName("DepartmentName")
                .HasMaxLength(50).IsRequired();
            builder.Property(D => D.HiringDate)
                  .HasComputedColumnSql("GETDATE()");
            // RelationShip => One To Many Department , Students 
            builder
                .HasMany(d => d.Students)
                .WithOne(s => s.StudentDepartment)
                .HasForeignKey(s => s.DepartmentId)
                .OnDelete(DeleteBehavior.NoAction);

            // Relation Ship => Manger  Departmnet , Instructor 
            builder.HasOne(d => d.Manger)
                .WithOne(i => i.MangedDepartment)
                .HasForeignKey<Department>(d => d.MangerId)
                .OnDelete(DeleteBehavior.NoAction);
            // RelationShip => Contains Department , Instructor
            builder.HasMany(i => i.Instructors)
                .WithOne(D => D.DepartmentContainInstructors)
                .HasForeignKey(i => i.DepartmentId)
                .OnDelete(DeleteBehavior.NoAction);




        }
    }
}
