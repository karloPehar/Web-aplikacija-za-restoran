using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using WebApplication1.Controllers;

namespace UnitTest
{
    [TestClass]
    public class PrijavaControllerTest
    {
        [TestMethod]
        public void Index_View_Not_Null()
        {
            PrijavaController test = new PrijavaController();
            Assert.IsNotNull(test.Index());
        }
      
       

    }
}
