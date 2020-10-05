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
        [TestMethod]
        public void Komentari_View_Not_Null()
        {
            KomentarController test = new KomentarController();
            Assert.IsNotNull(test.Lista());
        }

        [TestMethod]
        public void Komentari_Dodaj_Not_Null()
        {
            KomentarController test = new KomentarController();
            Assert.IsNotNull(test.Dodaj());
        }
        [TestMethod]
        public void Komentari_Ponisti_Not_Null()
        {
            KomentarController test = new KomentarController();
            Assert.IsNotNull(test.Ponisti());
        }
    }
}
