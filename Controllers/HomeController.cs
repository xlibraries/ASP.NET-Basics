using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVC_Trainning.Controllers
{

    [RoutePrefix("Pura Home")]
    public class HomeController : Controller
    {
        // GET: Home
        
        [Route("~/MVC TEST")]
        public String Index()
        {
            return "Home home";
        }

        [Route("~/OLD MVC TEST")]
        public String OldMethod()
        {
            return "Purana Home";
        }
    }
}