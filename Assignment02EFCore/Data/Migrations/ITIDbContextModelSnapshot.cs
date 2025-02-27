﻿// <auto-generated />
using System;
using Assignment02EFCore.Data.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Assignment02EFCore.Data.Migrations
{
    [DbContext(typeof(ITIDbContext))]
    partial class ITIDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Assignment02EFCore.Data.Model.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Duration")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TopicId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TopicId");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("Assignment02EFCore.Data.Model.CourseInstructor", b =>
                {
                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<int>("InstructorId")
                        .HasColumnType("int");

                    b.Property<int>("evaluate")
                        .HasColumnType("int");

                    b.HasKey("CourseId", "InstructorId");

                    b.HasIndex("InstructorId");

                    b.ToTable("CourseInstructor");
                });

            modelBuilder.Entity("Assignment02EFCore.Data.Model.Department", b =>
                {
                    b.Property<int>("DepartmentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DepartmentID"), 10L, 10);

                    b.Property<DateTime>("HiringDate")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2")
                        .HasComputedColumnSql("GETDATE()");

                    b.Property<int?>("MangerId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("DepartmentName");

                    b.HasKey("DepartmentID");

                    b.HasIndex("MangerId")
                        .IsUnique()
                        .HasFilter("[MangerId] IS NOT NULL");

                    b.ToTable("Departments", "dbo");
                });

            modelBuilder.Entity("Assignment02EFCore.Data.Model.Instructor", b =>
                {
                    b.Property<int>("Inst_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Inst_Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("VarChar")
                        .HasColumnName("InstructorAdres");

                    b.Property<decimal>("Bouns")
                        .HasColumnType("decimal(12,2)");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<int>("HourRate")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasMaxLength(60)
                        .HasColumnType("VarChar")
                        .HasColumnName("InstructorName");

                    b.Property<decimal>("Salary")
                        .HasColumnType("decimal(12,2)");

                    b.HasKey("Inst_Id");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Instructors");
                });

            modelBuilder.Entity("Assignment02EFCore.Data.Model.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("Assignment02EFCore.Data.Model.StudentCourse", b =>
                {
                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<int>("Grade")
                        .HasColumnType("int");

                    b.HasKey("StudentId", "CourseId");

                    b.HasIndex("CourseId");

                    b.ToTable("StudentCourse");
                });

            modelBuilder.Entity("Assignment02EFCore.Data.Model.Topic", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Topics");
                });

            modelBuilder.Entity("Assignment02EFCore.Data.Model.Course", b =>
                {
                    b.HasOne("Assignment02EFCore.Data.Model.Topic", "Topics")
                        .WithMany("Courses")
                        .HasForeignKey("TopicId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Topics");
                });

            modelBuilder.Entity("Assignment02EFCore.Data.Model.CourseInstructor", b =>
                {
                    b.HasOne("Assignment02EFCore.Data.Model.Course", "Courses")
                        .WithMany("CourseInstructors")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Assignment02EFCore.Data.Model.Instructor", "Instructors")
                        .WithMany("Instructorcourse")
                        .HasForeignKey("InstructorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Courses");

                    b.Navigation("Instructors");
                });

            modelBuilder.Entity("Assignment02EFCore.Data.Model.Department", b =>
                {
                    b.HasOne("Assignment02EFCore.Data.Model.Instructor", "Manger")
                        .WithOne("MangedDepartment")
                        .HasForeignKey("Assignment02EFCore.Data.Model.Department", "MangerId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.Navigation("Manger");
                });

            modelBuilder.Entity("Assignment02EFCore.Data.Model.Instructor", b =>
                {
                    b.HasOne("Assignment02EFCore.Data.Model.Department", "DepartmentContainInstructors")
                        .WithMany("Instructors")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("DepartmentContainInstructors");
                });

            modelBuilder.Entity("Assignment02EFCore.Data.Model.Student", b =>
                {
                    b.HasOne("Assignment02EFCore.Data.Model.Department", "StudentDepartment")
                        .WithMany("Students")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("StudentDepartment");
                });

            modelBuilder.Entity("Assignment02EFCore.Data.Model.StudentCourse", b =>
                {
                    b.HasOne("Assignment02EFCore.Data.Model.Course", "Course")
                        .WithMany("CourseStudents")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Assignment02EFCore.Data.Model.Student", "Student")
                        .WithMany("StudentCourses")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("Assignment02EFCore.Data.Model.Course", b =>
                {
                    b.Navigation("CourseInstructors");

                    b.Navigation("CourseStudents");
                });

            modelBuilder.Entity("Assignment02EFCore.Data.Model.Department", b =>
                {
                    b.Navigation("Instructors");

                    b.Navigation("Students");
                });

            modelBuilder.Entity("Assignment02EFCore.Data.Model.Instructor", b =>
                {
                    b.Navigation("Instructorcourse");

                    b.Navigation("MangedDepartment")
                        .IsRequired();
                });

            modelBuilder.Entity("Assignment02EFCore.Data.Model.Student", b =>
                {
                    b.Navigation("StudentCourses");
                });

            modelBuilder.Entity("Assignment02EFCore.Data.Model.Topic", b =>
                {
                    b.Navigation("Courses");
                });
#pragma warning restore 612, 618
        }
    }
}
