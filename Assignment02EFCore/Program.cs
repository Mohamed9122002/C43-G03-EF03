using Assignment02EFCore.Data.DbContexts;
using Assignment02EFCore.Data.Model;
using Microsoft.EntityFrameworkCore;

namespace Assignment02EFCore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using ITIDbContext dbContext = new ITIDbContext();
            dbContext.Database.Migrate();
            #region  CRUD Operations
            #region Insert Data 
            //List<Department> departments = new List<Department>()
            //{
            //    new Department(){Name="IT" },
            //    new Department(){Name="CS" },
            //    new Department(){Name="IS" },
            //};

            //dbContext.Departments.AddRange(departments);
            //List<Student> students = new List<Student>()
            //{
            //    new Student(){FirstName="Ahmed",LastName="Ali",Address="Cairo",Age=20,DepartmentId=20 },
            //    new Student(){FirstName="Mohamed",LastName="Mahmoud",Address="Giza",Age=21,DepartmentId=30 },
            //    new Student(){FirstName="Omar",LastName="Ali",Address="Alex",Age=22,DepartmentId=40 },
            //};
            //dbContext.Students.AddRange(students);
            //dbContext.SaveChanges(); 
            #endregion
            #region Select 

            //var studentById = dbContext.Students.FirstOrDefault(S => S.Id == 3);
            //var studentByDepartment = dbContext.Students.Where(S => S.DepartmentId == 20).ToList();
            //foreach (var item in studentByDepartment)
            //{
            //   Console.WriteLine(item.FirstName);
            //}

            #endregion
            #region Udated 
            //var Student  =  dbContext.Students.AsNoTracking().FirstOrDefault(S => S.Id == 4);
            //if (Student is not null)
            //{
            //    Console.WriteLine($"FirstName {Student.FirstName} Last Name ,{Student.LastName} ,Age , {Student.Age}");
            //    Student.FirstName = "Alaa";
            //    Console.WriteLine($"After Changing ");
            //    dbContext.SaveChanges();
            //    Console.WriteLine($"FirstName {Student.FirstName} Last Name ,{Student.LastName} ,Age , {Student.Age}");

            //}
            #endregion
            #region Delete
            //Student student = new Student() { FirstName = "Ali", LastName = "Mohamed", Address = "Alex", Age = 23, DepartmentId = 40 };
            //dbContext.Students.Add(student);
            //dbContext.SaveChanges();
            //var studentToDelete = dbContext.Students.FirstOrDefault(S => S.Id == 6);
            //if (studentToDelete is not null)
            //{
            //    dbContext.Students.Remove(studentToDelete);
            //    dbContext.SaveChanges();
            //    //Console.WriteLine($"{studentToDelete.FirstName} , {studentToDelete.LastName}");
            //}
            #endregion
            #endregion

        }
    }
}
