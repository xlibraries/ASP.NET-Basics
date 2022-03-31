using MVC_Trainning.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MVC_Trainning.Controllers
{
    public class StudentController : ApiController
    {
        Student[] students = new Student[]
        {
            new Student
            {
                SID = 1,
                Name = "Xlib",
                Course = ".NET"
            },
             new Student
            {
                SID = 1,
                Name = "Xlib",
                Course = ".NET"
            },
        };

        [HttpGet]
        public IEnumerable<Student> Get()
        {
            return students;
        }
    }
}
