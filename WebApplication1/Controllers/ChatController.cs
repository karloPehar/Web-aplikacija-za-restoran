using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClassLibrary1.Models;
using ClassLibrary1.ViewModels;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using WebApplication1.Helper;
using WebApplication1.Hubs;

namespace WebApplication1.Controllers
{
    public class ChatController : Controller
    {

        private mojDbContext db;
        private readonly IHubContext<ChatHub> _hubContext;
        


        public ChatController(mojDbContext context, IHubContext<ChatHub> hubContext)
        {
            db = context;
            _hubContext = hubContext;
            
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SubmitFormPartial()
        {
          
            return PartialView();
        }

        public IActionResult PosaljiPoruku(PorukaVM model)
        {


            var userID = Autenfikacija.GetLogiraniKorisnik(HttpContext).UserID;
            var user = Autenfikacija.GetLogiraniKorisnik(HttpContext);
            if (user.UlogaID == 2)
            {
                if (db.Chat.Find(userID) == null)
                {
                    Chat ch = new Chat
                    {
                        KorisnikID = userID,
                        ChatID = userID,
                        VrijemePocetka = System.DateTime.Now
                    };
                    db.Chat.Add(ch);
                    db.SaveChanges();
                }

                Poruka nova = new Poruka
                {

                    VrijemeSlanja = System.DateTime.Now,

                    PosijateljID = userID,
                    ChatID = userID,
                    Sadrzaj = model.Poruka



                };
                db.Poruka.Add(nova);
                db.SaveChanges();

            }







            var datum = System.DateTime.Now.ToShortDateString();
            var vrijeme = System.DateTime.Now.ToShortTimeString();

            _hubContext.Clients.Group(userID.ToString()).SendAsync("PrimljenaPoruka",model.Poruka,datum,vrijeme, userID);
            return PartialView("SubmitFormPartial");
            
        }

        
    }
}