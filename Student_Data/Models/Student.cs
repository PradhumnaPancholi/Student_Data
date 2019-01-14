using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Student_Data.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }

        [Required]
        public String FirstNAme { get; set; }

        [Required]
        public String LastName { get; set; }

        [Required]
        public String Address { get; set; }

        [Required]
        public int Phone { get; set; }

        [Required]
        public String Email { get; set; }

    }
}
