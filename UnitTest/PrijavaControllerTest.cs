using ClassLibrary1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using WebApplication1.Controllers;
using ClassLibrary1.ViewModels;

namespace UnitTest
{
   
    [TestClass]
    public class PrijavaControllerTest
    {

        public mojDbContext InMemoryContext()
        {
            var option = new DbContextOptionsBuilder<mojDbContext>().UseInMemoryDatabase(databaseName: "Test_Database").Options;

            var db = new mojDbContext(option);
            if (db != null)
            {
                db.Database.EnsureDeleted();
                db.Database.EnsureCreated();
            }

            return db;
        }

        private mojDbContext db;


        public PrijavaControllerTest()
        {
            db = InMemoryContext();

                        
        }

       

        [TestMethod]
        public void prijava_View_Not_null()
        {

            PrijavaController pc = new PrijavaController(db);
            PartialViewResult vr = (PartialViewResult)pc.Index();
            Assert.IsNotNull(vr);


        }
       




    }
}
