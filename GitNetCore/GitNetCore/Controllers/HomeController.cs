using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GitNetCore.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        public ActionResult first()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
        public ActionResult two()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
        
         public ActionResult WroteFromGit()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
         public ActionResult WroteFromGit1()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
    }
}
