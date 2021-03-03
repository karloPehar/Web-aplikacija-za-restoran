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
    public class ObavijestControllerTest
    {
        private mojDbContext db;

        public ObavijestControllerTest()
        {
            TestniContext test = new TestniContext();
            db = test.InMemoryContext();
        }
       
        [TestMethod]
        public void Obavijesti_View_Not_Null()
        {
            ObavijestController test = new ObavijestController(db);
            Assert.IsNotNull(test.Novosti());
        }


        [TestMethod]
        public void Obavijesti_View_Broj_Razlicit_Od_0()
        {
            ObavijestController test = new ObavijestController(db);
            Assert.AreEqual(0, new ObavijestController(db).brojacObavijesti());

        }

    }
}
