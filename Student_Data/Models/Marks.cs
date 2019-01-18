using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Student_Data.Models
{
    public class Marks
    {
        public virtual Student StudentId { get; set; } 

        public virtual Course CourseId { get; set; }

        public String Grade { get; set; }
    }
}
