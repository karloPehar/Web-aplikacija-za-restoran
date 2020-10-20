
using ClassLibrary1.Models;
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
        private mojDbContext db;

        public JelovnikControllerTest(mojDbContext c)
        {
            db = c;
        }

        [TestMethod]
        public void Proizvodi_View_Not_Null()
        {
           
            JelovnikController test = new JelovnikController(db);
            Assert.IsNotNull(test.Proizvodi());
        }

    }
}
