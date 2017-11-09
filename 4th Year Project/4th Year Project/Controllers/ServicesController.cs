using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _4th_Year_Project.Models;
using _4th_Year_Project.ViewModels;

namespace _4th_Year_Project.Controllers
{
    public class ServicesController : Controller
    {

        // GET: Cameras/Dashboard
        public ActionResult Services()
        {
            ViewBag.Message = "The Services Page.";
            var camera = new Cameras() {Name = "Camera 1" ,Id = 1};

            var users = new List<User>
            {
                new User {Name = "Alex Mac Uaid"},
                new User {Name = "Admin"}
            };
            var viewModel = new DashboardCameraViewModel
            {
                Cameras = camera,
                Users =  users
            };

            return View(viewModel);
        }

        public ActionResult Edit(int id)
        {
            return Content("id = " + id);
        }

        //cameras
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (pageIndex.HasValue)
            {
                pageIndex = 1;
            }

            if (String.IsNullOrWhiteSpace(sortBy))
            {
                sortBy = "Name";
            }

            return Content(String.Format("pageIndex={0}&sortBy={1}",pageIndex, sortBy));

        }
        //attribute route with a constraint allowing a camera to be linked with year and month
        [Route("services/cameras/{month:regex(\\d{4}):range(1, 12)}/{year}")]
        public ActionResult ByReleaseDate(int month, int year)
        {
            return Content( month + "/" + year);
        }
    }
}