using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Student_Data.Models
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }

        [Required]
        public String CourseName { get; set; }
    }
}
