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
        public ActionResult Index()
        {
            return View();
        }

        public string MyController()
        {
            return "Hellow, I am the controller";
        }

        public ActionResult MyView()
        {
            return View();
        }
    }
}