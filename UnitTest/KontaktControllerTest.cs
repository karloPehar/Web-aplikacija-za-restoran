using ClassLibrary1.Models;
using ClassLibrary1.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
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
        private IConfiguration conf;

        public KontaktControllerTest()
        {
            TestniContext test = new TestniContext();
            db = test.InMemoryContext();
            

        }

        [TestMethod]
        public void Email_View_Not_null()
        {

            KontaktController pc = new KontaktController(db,conf);
            ViewResult vr = (ViewResult)pc.Email();
            Assert.IsNotNull(vr);


        }
       

    }
}
