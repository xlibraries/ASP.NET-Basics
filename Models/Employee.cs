using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ModelDemo.Models
{
    public class Employee
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public DateTime JoiningDate { get; set; }

        public int Age {get; set;}
    }
}