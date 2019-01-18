using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Student_Data.Models
{
    public class Marks
    {
        [Required]
        public virtual Student StudentId { get; set; } 

        [Required]
        public virtual Course CourseId { get; set; }

        [Required]
        public String Grade { get; set; }
    }
}
