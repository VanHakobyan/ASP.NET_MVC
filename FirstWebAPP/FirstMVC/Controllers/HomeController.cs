using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstMVC.Controllers
{
    public class HomeController: Controller
    {
        public ActionResult Index()
        {
            ViewBag.Variable = RouteData.Values["id"];
            return View();
        }

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
        public ActionResult Test()
        {
            return View();
        }
        public ActionResult Custom(int? id)
        {
            ViewBag.Variable = id;
            return View("Index");
        }
        public ActionResult newCustom()
        {
            return View();
        }
      
    }
}