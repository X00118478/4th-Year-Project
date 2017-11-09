using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using _4th_Year_Project.Models;

namespace _4th_Year_Project.ViewModels
{
    public class DashboardCameraViewModel
    {
        public Cameras Cameras { get; set; }
        public List<User> Users { get; set; }
    }
}