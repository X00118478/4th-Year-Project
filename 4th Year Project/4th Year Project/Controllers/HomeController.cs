using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _4th_Year_Project.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }





        public ActionResult Contact()
        {
            ViewBag.Message = "Contact Traffic Management Ltd.";

            return View();
        }

       
    }
}