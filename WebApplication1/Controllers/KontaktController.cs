using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClassLibrary1.Models;
using ClassLibrary1.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using WebApplication1.Helper;

namespace WebApplication1.Controllers
{
    



    public class KontaktController : Controller
    {

        private mojDbContext db;
        private IConfiguration Configuration;

        public KontaktController(mojDbContext c, IConfiguration _config)
        {
            db = c;
            Configuration = _config;
        }


        public IActionResult Email()
        {
            return View();
        }
       
        public IActionResult SlanjeMaila(EmailVM model)
        {
            

            if (ModelState.IsValid)
            {
                Nullable<int> userID=0;

                if (Autenfikacija.GetLogiraniKorisnik(HttpContext) != null)
                    userID = Autenfikacija.GetLogiraniKorisnik(HttpContext).UserID;
                else
                    userID = null;
                

                
                EmailPostavka.SendEmail(Configuration, model.Ime, model.EmailAdresa, "Restoran public mail", model.Sadrzaj);
                TempData["poslanEmail"]="Email uspješno poslan";

                Email n = new Email
                {
                    Sadrzaj = model.Sadrzaj,
                    EmailAdresa = model.EmailAdresa,
                    VrijemeSlanja = DateTime.Now,
                    UserID = userID

                };

                db.Email.Add(n);
                db.SaveChanges();
            }
            

            return RedirectToAction("Email");
        }
    }
}