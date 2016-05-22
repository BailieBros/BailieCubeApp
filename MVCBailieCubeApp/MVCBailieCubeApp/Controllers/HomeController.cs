using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

// This is why the Seahawks are so cool!
namespace MVCBailieCubeApp.Controllers
{
    public class HomeController : Controller
    {
        // This is a comment for testing purposes
        public ActionResult Index()
        {
            return View();
        }
        // Comment from Sky
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}