using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02EFCore.Data.Model
{
    public class Topic
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;

        // one To Many 

        [InverseProperty(nameof(Course.Topics))]
        public ICollection<Course> Courses { get; set; } = new HashSet<Course>();
    }
}
