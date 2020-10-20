using ClassLibrary1.Models;
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
        private mojDbContext db;

        public RezervacijaControllerTest(mojDbContext c)
        {
            db = c;
        }
        [TestMethod]
        public void Rezervacija_View_Not_Null()
        {
            RezervacijaController test = new RezervacijaController(db);
            Assert.IsNotNull(test.Index());
        }

        [TestMethod]
        public void broj_Poslovnica_vece_od_0()
        {
            RezervacijaController test = new RezervacijaController(db);
            Assert.AreNotEqual(test.brojPrikazanihPoslovnica(), 0);
        }
        [TestMethod]
        public void broj_osoba_vece_od_0()
        {
            RezervacijaController test = new RezervacijaController(db);
            Assert.AreNotEqual(test.brojPrikazanihBrOsoba(), 0);
        }
        [TestMethod]
        public void broj_termina_vece_od_0()
        {
            RezervacijaController test = new RezervacijaController(db);
            Assert.AreNotEqual(test.brojPrikazanihTermina(), 0);
        }
    }
}
