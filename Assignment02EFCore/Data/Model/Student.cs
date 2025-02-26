using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02EFCore.Data.Model
{
    public class Student
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        #region RelationShip one To Many  
        // Many is Mandatory 
        // Navigation Property => One 
        [ForeignKey(nameof(Student.StudentDepartment))]
        public int DepartmentId { get; set; }
        // Navigation Property => One 
        [InverseProperty(nameof(Department.Students))]
        public Department StudentDepartment { get; set; } = null!;
        #endregion
        #region Many To Many  using Table RelationShipe 

        public ICollection<StudentCourse> StudentCourses { get; set; } = new HashSet<StudentCourse>();

        #endregion

    }
}
