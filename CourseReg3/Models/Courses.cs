using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CourseReg3.Models
{
    public class Courses
    {
        [Key]
        public int CourseId { get; set; }
        public long CourseNumber { get; set; }
        public string CourseName { get; set; }
        public string Description { get; set; }
    }
}
