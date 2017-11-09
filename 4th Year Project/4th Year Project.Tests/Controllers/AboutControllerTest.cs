using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _4th_Year_Project.Controllers;

namespace _4th_Year_Project.Tests.Controllers
{
    class AboutControllerTest
    {
        [TestMethod]
        public void About()
        {
            // Arrange
            AboutController controller = new AboutController();

            // Act
            ViewResult result = controller.About() as ViewResult;

            // Assert
            Assert.AreEqual("Your application description page.", result.ViewBag.Message);
        }

    }
}
