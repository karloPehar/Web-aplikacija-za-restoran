using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using WebApplication1.Controllers;

namespace UnitTest
{
    [TestClass]
    public class GalerijaControllerTest
    {

        [TestMethod]
        public void Slike_View_Not_Null()
        {
            GalerijaController test = new GalerijaController();
            Assert.IsNotNull(test.Slike());
        }

        [TestMethod]
        public void Obavijesti_View_Broj_Razlicit_Od_0()
        {
            ObavijestController test = new ObavijestController();
            Assert.AreNotEqual(0, new ObavijestController().brojacObavijesti());

        }
    }
}
