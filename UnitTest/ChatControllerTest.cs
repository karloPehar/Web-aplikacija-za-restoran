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
using Microsoft.AspNetCore.SignalR;
using WebApplication1.Hubs;

namespace UnitTest
{
    [TestClass]
    public class ChatControllerTest
    {
       

        private mojDbContext db;
        private readonly IHubContext<ChatHub> _hubContext;

        public ChatControllerTest()
        {
            TestniContext test = new TestniContext();
            db = test.InMemoryContext();
           

        }



        [TestMethod]
        public void Index_View_Not_null()
        {

            ChatController ch = new ChatController(db, _hubContext);
            ViewResult vr = (ViewResult)ch.Index();
            Assert.IsNotNull(vr);


        }
        [TestMethod]
        public void SubmitFormPartial_PartialView_not_null()
        {

            ChatController pc = new ChatController(db, _hubContext);
            PartialViewResult vr = (PartialViewResult)pc.SubmitFormPartial();
            Assert.IsNotNull(vr);



        }

     
    }
}