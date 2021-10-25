using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CourseReg3.Models
{
    public class Instructors
    {
        [Key]
        public int InstructorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string CourseName { get; set; }
    }
}
