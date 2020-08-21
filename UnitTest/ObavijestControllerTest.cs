using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using WebApplication1.Controllers;

namespace UnitTest
{
    [TestClass]
    public class ObavijestControllerTest
    {

        [TestMethod]
        public void Proizvodi_View_Not_Null()
        {
            ObavijestController test = new ObavijestController();
            Assert.IsNotNull(test.Novosti());
        }

    }
}
