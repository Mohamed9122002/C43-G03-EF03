using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;

namespace Assignment02EFCore.Data.Model
{
    public class Instructor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Inst_Id { get; set; }
        [Column("InstructorName", TypeName = "VarChar")]
        [MaxLength(60)]
        public string? Name { get; set; }
        [Column(TypeName = "decimal(12,2)")]
        [DataType(DataType.Currency)]
        public decimal Bouns { get; set; }
        [Column(TypeName = "decimal(12,2)")]
        [DataType(DataType.Currency)]
        public decimal Salary { get; set; }
        [Column("InstructorAdres", TypeName = "VarChar")]
        [MaxLength(10)]
        public string Address { get; set; }
        public int HourRate { get; set; }

        #region Mapping Relationalship  one to one 
        // optional - Mandatory 
        // Manger 
        // Navigation Property => One
        // 
        [InverseProperty(nameof(Department.Manger))]
        public virtual Department MangedDepartment { get; set; }
        #endregion
        #region Mapping Relationalship  one to Many  -> Contains 
        // Many is Mandatory 
        // Many To One 
        [ForeignKey(nameof(Instructor.DepartmentContainInstructors))]
        public int DepartmentId { get; set; }
        // Navigation Property =>  one 
        
        [InverseProperty(nameof(Department.Instructors))]
        public virtual Department DepartmentContainInstructors { get; set; } = null!;

        #endregion
        #region Many To Many RelationalShip Between Course  Instructor 
        public virtual ICollection<CourseInstructor> Instructorcourse { get; set; } = new HashSet<CourseInstructor>();
        #endregion
    }
}
