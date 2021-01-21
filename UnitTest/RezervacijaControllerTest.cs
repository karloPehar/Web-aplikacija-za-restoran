using ClassLibrary1.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using WebApplication1.Controllers;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Helper;
using Microsoft.Extensions.Configuration;

namespace UnitTest
{
    [TestClass]
    public class RezervacijaControllerTest
    {
       

        private mojDbContext db;
        private IConfiguration conf;

        public RezervacijaControllerTest()
        {
            TestniContext test = new TestniContext();
            db = test.InMemoryContext();
            

        }



        [TestMethod]
        public void Lista_View_Not_null()
        {

            RezervacijaController pc = new RezervacijaController(db,conf);
            ViewResult vr = (ViewResult)pc.ListaRezervacija();
            Assert.IsNotNull(vr);


        }
        [TestMethod]
        public void Index_view_not_null()
        {

            RezervacijaController pc = new RezervacijaController(db, conf);
            ViewResult vr = (ViewResult)pc.Index();
            Assert.IsNotNull(vr);



        }

        [TestMethod]
        public void RezervacijaPartial_view_not_null()
        {

            RezervacijaController pc = new RezervacijaController(db, conf);
            PartialViewResult vr = (PartialViewResult)pc.RezervacijaPartial(null);
            Assert.IsNotNull(vr);



        }

        [TestMethod]
        public void Lista_Partial_View_Not_null()
        {

            RezervacijaController pc = new RezervacijaController(db,conf);
            PartialViewResult vr = (PartialViewResult)pc.PrikazRezervacija(33);
            Assert.IsNotNull(vr);


        }
    }
}