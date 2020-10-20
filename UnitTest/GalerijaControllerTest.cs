using ClassLibrary1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
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
        private mojDbContext db;

        public GalerijaControllerTest(mojDbContext c)
        {
           
            db = c;
        }

        [TestMethod]
        public void Slike_View_Not_Null()
        {
            GalerijaController test = new GalerijaController(db);
            Assert.IsNotNull(test.Slike());
        }

        [TestMethod]
        public void Obavijesti_View_Broj_Razlicit_Od_0()
        {
            ObavijestController test = new ObavijestController(db);
            Assert.AreNotEqual(0, new ObavijestController(db).brojacObavijesti());

        }
    }
}
