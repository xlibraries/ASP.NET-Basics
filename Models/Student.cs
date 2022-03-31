using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace MVC_Trainning.Models
{
    public class Student
    {
        public int SID { get; set; }

        [Required(ErrorMessage =  "Name is required")]
        public string Name { get; set; }

        [Range(10,10, ErrorMessage = "must be a valid phone number")]
        public int ContactNo { get; set; }
    }
}