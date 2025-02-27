using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02EFCore.Data.Model
{
    public class StudentCourse
    {
        [ForeignKey(nameof(StudentCourse.Student))]
        public int StudentId { get; set; }
        [ForeignKey(nameof(StudentCourse.Course))]
        public int CourseId { get; set; }
        public int Grade    { get; set; }
        #region Mapping RelationShip Between Student,Course  => Many To Many  
        public Student Student { get; set; } = null!;
        public Course Course { get; set; } = null!;

        #endregion
    }
}
