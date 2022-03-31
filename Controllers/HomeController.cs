using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVC_Trainning.Controllers
{
    [Route("API/Home")]
    public class HomeController : Controller
    {
        [HttpGet]
        public string Show()
        {
            return "Batao";
        }
    }
}