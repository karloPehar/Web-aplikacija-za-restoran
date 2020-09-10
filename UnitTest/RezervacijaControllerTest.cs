using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using WebApplication1.Controllers;

namespace UnitTest
{
    [TestClass]
    public class RezervacijaControllerTest
    {

        [TestMethod]
        public void Slike_View_Not_Null()
        {
            RezervacijaController test = new RezervacijaController();
            Assert.IsNotNull(test.Index());
        }

       
    }
}
