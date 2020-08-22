using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using WebApplication1.Controllers;

namespace UnitTest
{
    [TestClass]
    class GalerijaControllerTest
    {

        [TestMethod]
        public void Slike_View_Not_Null()
        {
            GalerijaController test = new GalerijaController();
            Assert.IsNotNull(test.Slike());
        }


    }
}
