using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02EFCore.Data.Model
{
    public class Course
    {
        public int Id { get; set; }
        public double Duration { get; set; }
        public int Age { get; set; }
        [Required]
        public string Name { get; set; }
        public string? Description { get; set; }
        #region one to Many  course , Topic
        // Many is Mandatroy 
        [ForeignKey(nameof(Course.Topics))]
        public int TopicId { get; set; }
        // Navigational Proerty of one 
        [InverseProperty(nameof(Topic.Courses))]
        public Topic Topics{ get; set; } = null!;

        #endregion

        #region Many To Many Using Table RelationShip bettween Course and Student

        public ICollection<StudentCourse> CourseStudents { get; set; } = new HashSet<StudentCourse>();
        #endregion
        #region Many To Many RelationShip Bettween Course and Instructor
        public ICollection<CourseInstructor> CourseInstructors { get; set; } = new HashSet<CourseInstructor>();
        #endregion


    }
}
