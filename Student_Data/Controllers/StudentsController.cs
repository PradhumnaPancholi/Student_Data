using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Student_Data.Models;

namespace Student_Data.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        //db ref//
        private StudentDataModel db;

        public StudentsController(StudentDataModel db)
        {
            this.db = db;
        }
        [HttpGet]
        public IEnumerable<Student> GET()
        {
            return db.Students.ToList();
        }
    }
}