using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using WebApplication1.Controllers;

namespace UnitTest
{
   [TestClass]
    public class JelovnikControllerTest
    {
        [TestMethod]
        public void Proizvodi_View_Not_Null()
        {
            JelovnikController test = new JelovnikController();
            Assert.IsNotNull(test.Proizvodi());
        }

    }
}
