using ClassLibrary1.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using WebApplication1.Controllers;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Helper;

namespace UnitTest
{
    [TestClass]
    public class RezervacijaControllerTest
    {
        //private mojDbContext db;

        //public RezervacijaControllerTest(mojDbContext c)
        //{
        //    db = c;
        //}
        //[TestMethod]
        //public void Rezervacija_View_Not_Null()
        //{
        //    RezervacijaController test = new RezervacijaController(db);
        //    Assert.IsNotNull(test.Index());
        //}

        //[TestMethod]
        //public void broj_Poslovnica_vece_od_0()
        //{
        //    RezervacijaController test = new RezervacijaController(db);
        //    Assert.AreNotEqual(test.brojPrikazanihPoslovnica(), 0);
        //}
        //[TestMethod]
        //public void broj_osoba_vece_od_0()
        //{
        //    RezervacijaController test = new RezervacijaController(db);
        //    Assert.AreNotEqual(test.brojPrikazanihBrOsoba(), 0);
        //}
        //[TestMethod]
        //public void broj_termina_vece_od_0()
        //{
        //    RezervacijaController test = new RezervacijaController(db);
        //    Assert.AreNotEqual(test.brojPrikazanihTermina(), 0);
        //}

        //public mojDbContext InMemoryContext()
        //{
        //    var option = new DbContextOptionsBuilder<mojDbContext>().UseInMemoryDatabase(databaseName: "Test_Database").Options;

        //    var db = new mojDbContext(option);
        //    if (db != null)
        //    {
        //        db.Database.EnsureDeleted();
        //        db.Database.EnsureCreated();
        //    }

        //    return db;
        //}

        private mojDbContext db;


        public RezervacijaControllerTest()
        {
            TestniContext test = new TestniContext();
            db = test.InMemoryContext();


        }



        [TestMethod]
        public void Lista_View_Not_null()
        {

            RezervacijaController pc = new RezervacijaController(db);
            ViewResult vr = (ViewResult)pc.ListaRezervacija();
            Assert.IsNotNull(vr);


        }

        [TestMethod]
        public void Lista_Partial_View_Not_null()
        {

            RezervacijaController pc = new RezervacijaController(db);
            PartialViewResult vr = (PartialViewResult)pc.PrikazRezervacija();
            Assert.IsNotNull(vr);


        }
    }
}
