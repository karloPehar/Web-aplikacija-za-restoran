using ClassLibrary1.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using WebApplication1.Controllers;

namespace UnitTest
{
    [TestClass]
    public class KomentarControllerTest
    {
        private mojDbContext db;

        public KomentarControllerTest(mojDbContext c)
        {
            db = c;
        }
        [TestMethod]
        public void Komentari_View_Not_Null()
        {
            KomentarController test = new KomentarController(db);
            Assert.IsNotNull(test.Lista());
        }

        [TestMethod]
        public void Komentari_Dodaj_Not_Null()
        {
            KomentarController test = new KomentarController(db);
            Assert.IsNotNull(test.Dodaj());
        }
        [TestMethod]
        public void Komentari_Ponisti_Not_Null()
        {
            KomentarController test = new KomentarController(db);
            Assert.IsNotNull(test.Ponisti());
        }
    }
}
