
using ClassLibrary1.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using WebApplication1.Controllers;
using WebApplication1.Helper;

namespace UnitTest
{
   [TestClass]
    public class JelovnikControllerTest
    {
        private mojDbContext db;

        public JelovnikControllerTest()
        {
            TestniContext test = new TestniContext();
            db = test.InMemoryContext();
        }

        [TestMethod]
        public void Proizvodi_View_Not_Null()
        {
           
            JelovnikController test = new JelovnikController(db);
            Assert.IsNotNull(test.Proizvodi());
        }

    }
}
