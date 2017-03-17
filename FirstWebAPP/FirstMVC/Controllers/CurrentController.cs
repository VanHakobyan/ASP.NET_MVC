using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstMVC.Controllers
{
    public class CurrentController : Controller
    {
        // GET: Current
        public ActionResult Index()
        {
            return View();
        }
    }
}