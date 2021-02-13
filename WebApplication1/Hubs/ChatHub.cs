using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClassLibrary1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.SignalR;
using WebApplication1.Controllers;
using WebApplication1.Helper;

namespace WebApplication1.Hubs
{


    public class ChatHub : Hub
    {
        private mojDbContext db;
        

        public ChatHub(mojDbContext _db)
        {
            db = _db;
            
        }
        public string GetConnectionId()
        {
            return Context.ConnectionId;
        }

        public override async Task OnConnectedAsync()
        {


            var userID = Autenfikacija.GetLogiraniKorisnik(Context.GetHttpContext()).UserID;
            var user = Autenfikacija.GetLogiraniKorisnik(Context.GetHttpContext());
            Konekcija nova = new Konekcija
            {
                UserID = userID,
                Vrijednost = Context.ConnectionId

            };

            db.Konekcija.Add(nova);
            db.SaveChanges();



            if (user.UlogaID == 2)
            {

                await Groups.AddToGroupAsync(Context.ConnectionId, userID.ToString());

                var lista = AktivniDjelatinici();

                foreach (var id in lista)
                {
                    await Groups.AddToGroupAsync(id, userID.ToString());
                }
            }
            else
            if(user.UlogaID==1)
            {
                var lista = AktivniKorisnici();
               

                foreach (var grupa in lista)
                {
                    await Groups.AddToGroupAsync(Context.ConnectionId, grupa.ToString());
                }

                var listaDjelatnika = AktivniDjelatinici();
                if (listaDjelatnika.Count <= 1)
                {
                    var korisniciKonekcija = AktivniKorisniciKonekcija();
                    foreach (var x in korisniciKonekcija)
                    {
                        await Clients.Client(x).SendAsync("refreshForm");
                    }
                }
                    
                    
                    
                   


            }






            await base.OnConnectedAsync();
        }

      

        public override async Task OnDisconnectedAsync(Exception exception)
        {
            var userID = Autenfikacija.GetLogiraniKorisnik(Context.GetHttpContext()).UserID;
           

            var kon = db.Konekcija.Where(k => k.Vrijednost == Context.ConnectionId).FirstOrDefault();
            db.Konekcija.Remove(kon);
            db.SaveChanges();

            var listaDjelatnika = AktivniDjelatinici();
            if (listaDjelatnika.Count ==0)
            {
                var korisniciKonekcija = AktivniKorisniciKonekcija();
                foreach (var x in korisniciKonekcija)
                {
                    await Clients.Client(x).SendAsync("refreshForm");
                }
            }

            await base.OnDisconnectedAsync(exception);
        }



        public List<string> AktivniDjelatinici()
        {

           
            return db.Konekcija.Where(k => k.User.UlogaID == 1).Select(k => k.Vrijednost).ToList();
        }

        public List<int> AktivniKorisnici()
        {

            return db.Konekcija.Where(k => k.User.UlogaID == 2).Select(k => k.User.UserID).ToList();
        }

        public List<string> AktivniKorisniciKonekcija()
        {

            return db.Konekcija.Where(k => k.User.UlogaID == 2).Select(k => k.Vrijednost).ToList();
        }
       


    }
}
