using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Azuredemoapp.Repository;

namespace Azuredemoapp.Controllers
{
    public class HomeController : Controller
    {
        IEnv objenv;

        public HomeController()
        {
            objenv = new Envdata();
        }

        public ActionResult Index()
        {
            ViewBag.Env = objenv.getDBEnvironment();
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
    }
}