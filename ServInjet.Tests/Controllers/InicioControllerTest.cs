using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ServInjet;
using ServInjet.Controllers;

namespace ServInjet.Tests.Controllers
{
    [TestClass]
    public class InicioControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            InicioController controller = new InicioController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.AreEqual("Modify this template to jump-start your ASP.NET MVC application.", result.ViewBag.Message);
        }

        [TestMethod]
        public void Sobre()
        {
            // Arrange
            InicioController controller = new InicioController();

            // Act
            ViewResult result = controller.Sobre() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Contato()
        {
            // Arrange
            InicioController controller = new InicioController();

            // Act
            ViewResult result = controller.Contato() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
