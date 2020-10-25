using ClassLibrary1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using WebApplication1.Controllers;
using WebApplication1.Helper;

namespace UnitTest
{
    [TestClass]
    public class KontaktControllerTest
    {

        private mojDbContext db;


        public KontaktControllerTest()
        {
            TestniContext test = new TestniContext();
            db = test.InMemoryContext();


        }

        [TestMethod]
        public void Email_View_Not_null()
        {

            KontaktController pc = new KontaktController(db);
            ViewResult vr = (ViewResult)pc.Email();
            Assert.IsNotNull(vr);


        }

    }
}
