using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02EFCore.Data.Model
{
    public class CourseInstructor
    {
        [ForeignKey(nameof(CourseInstructor.Courses))]
        public int CourseId { get; set; }
        [ForeignKey(nameof(CourseInstructor.Instructors))]
        public int InstructorId { get; set; }
        public int evaluate { get; set; }
        #region Mapping RelationShip Between Course ,Instructor => Many To Many 
        [InverseProperty(nameof(Course.CourseInstructors))]
        public Course Courses { get; set; }
        [InverseProperty(nameof(Instructor.Instructorcourse))]
        public Instructor Instructors { get; set; } 
        #endregion
    }
}
