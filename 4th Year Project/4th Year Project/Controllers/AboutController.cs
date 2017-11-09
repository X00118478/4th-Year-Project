using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _4th_Year_Project.Controllers
{
    public class AboutController : Controller
    {
        // GET: About

        public ActionResult About()
        {
            ViewBag.Message = "Information about the Traffic Management System here.";

            return View();
        }
    }
}