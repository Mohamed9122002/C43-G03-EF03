using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02EFCore.Data.Model
{
    public class Department
    {
        public int DepartmentID { get; set; }
        public string Name { get; set; }
        public DateTime HiringDate { get; set; }
        #region RelationShip one To Many   , students , Department 
        // Many is Mandatory 
        // Navigational Property => Many 
        [InverseProperty(nameof(Student.StudentDepartment))]
        public ICollection<Student> Students { get; set; } = new HashSet<Student>();
        #endregion
        #region Mapping Relationalship  one to one  Department , Instructor  --> Mange
        //  Mandatory - optional
        // Manger 
        // Department Must be Manger 
        [ForeignKey(nameof(Department.Manger))]
        public int? MangerId { get; set; }
        // Navigation Property => One
        [InverseProperty(nameof(Instructor.MangedDepartment))]
        public Instructor Manger { get; set; } = null!;

        #endregion
        #region One To Many RelationShip Department , Instructor  --> Contains
        // one to Many
        // Contains
        // Many is Mandatory
        // Navigation Property => Many
        [InverseProperty(nameof(Instructor.DepartmentContainInstructors))]
        public ICollection<Instructor> Instructors { get; set; } = new HashSet<Instructor>();
        #endregion

    }
}
