using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Student_Data.Models
{
    public class StudentDataModel:DbContext
    {
        public StudentDataModel(DbContextOptions<StudentDataModel> options):base (options)
        {

        }
        //reference to student class//
        public DbSet<Student> Students { get; set; }
    }

}
