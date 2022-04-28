using FranMotors.Controllers;
using FranMotors.Manager;
using FranMotors.Models;
using FranMotors.Repositories;
using Microsoft.AspNetCore.Mvc;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppTest.Controller
{
    class HomeTest
    {

        [Test]
        public void TestSearchClientes()
        {
            var mock = new Mock<IHomeRepository>();
            var viewBagMock = new Mock<IAccountViewBagManager>();
            mock.Setup(o => o.GetAllMotocicleta(new Motocicleta() { Placa = "kj34jk" }));
            var controller = new HomeController(mock.Object, viewBagMock.Object);
            var result = controller.Privacy(new Motocicleta() { Placa = "kj34jk" }) as ViewResult; //RedirectToActionResult

            Assert.IsInstanceOf<ViewResult>(result);  //RedirectToActionResult
        }
    }
}
