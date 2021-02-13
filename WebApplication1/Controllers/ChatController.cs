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

            ListaPorukaVM model = new ListaPorukaVM();
            var user = Autenfikacija.GetLogiraniKorisnik(HttpContext);
            if (user.UlogaID == 2)
            {
              
                model.ListaPoruka = db.Poruka
              .Select(r => new ListaPorukaVM.Row
              {

                  Sadrzaj = r.Sadrzaj,
                  User = r.User.ime,
                  VrijemePoruke = r.VrijemeSlanja.ToShortTimeString(),
                  DatumPoruke = r.VrijemeSlanja.ToShortDateString(),
                  VrijemeDatumPoruka = r.VrijemeSlanja,
                  ChatID= r.Chat.ChatID
              }).Where((n => n.VrijemeDatumPoruka >= (DateTime.Now.AddDays(-1)))).Where((e => e.ChatID == user.UserID)).ToList();


               

            }


            return View(model);


        }

        public IActionResult SubmitFormPartial()
        {
            var user = Autenfikacija.GetLogiraniKorisnik(HttpContext);

            if(user.UlogaID==2)
            {
                var brAktivnihDjelatnika = db.Konekcija.Where(k => k.User.UlogaID == 1).Select(k => k.Vrijednost).Count();

                if (brAktivnihDjelatnika == 0)
                    TempData["brAktivnihDjelatnika"] = "Trenutno korisnička podrška nije na mreži";
            }
            
            return PartialView();
        }

        public IActionResult PosaljiPoruku(PorukaVM model)
        {

            if (ModelState.IsValid)
            {
                var userID = Autenfikacija.GetLogiraniKorisnik(HttpContext).UserID;
                var user = Autenfikacija.GetLogiraniKorisnik(HttpContext);
                if (user.UlogaID == 2)
                {
                    if (db.Chat.Find(userID) == null)
                    {
                        Chat ch = new Chat
                        {
                            UserID = userID,
                            ChatID = userID,
                            VrijemePocetka = System.DateTime.Now
                        };
                        db.Chat.Add(ch);
                        db.SaveChanges();
                    }

                    Poruka nova = new Poruka
                    {

                        VrijemeSlanja = System.DateTime.Now,

                        UserID = userID,
                        ChatID = userID,
                        Sadrzaj = model.Poruka



                    };
                    db.Poruka.Add(nova);
                    db.SaveChanges();


                }







                var datum = System.DateTime.Now.ToShortDateString();
                var vrijeme = System.DateTime.Now.ToShortTimeString();

                _hubContext.Clients.Group(userID.ToString()).SendAsync("PrimljenaPoruka", model.Poruka, datum, vrijeme, user.ime);


                ModelState.Clear();
            }
           
            return PartialView("SubmitFormPartial");
            
        }

        
    }
}