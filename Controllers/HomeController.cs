using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Trainning.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home

        [Route("MVC TEST")]
        public String Index()
        {
            return "Home home";
        }
    }
}