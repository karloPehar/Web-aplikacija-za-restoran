using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClassLibrary1.Models;
using ClassLibrary1.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Helper;

namespace WebApplication1.Controllers
{
    public class PrijavaController : Controller
    {
        private mojDbContext db;

        public PrijavaController(mojDbContext c)
        {
            db = c;
        }
        public IActionResult Index()
        {
            return PartialView();
        }

        public IActionResult Prijava(PrijavaVM model)
        {


            if (ModelState.IsValid)
            {
               // mojDbContext db = new mojDbContext();


                //Nalog x = db.Nalog.SingleOrDefault(n => n.Email == model.Email && n.Lozinka == model.Lozinka);
                User u = db.User.SingleOrDefault(k => k.Nalog.Email == model.Email && k.Nalog.Lozinka == model.Lozinka);

                if (u == null)
                {
                    TempData["neuspjesnaprijava"] = "pogrešno ste unjeli email ili lozinku";
                    return PartialView("Index", model);


                }

                Autenfikacija.SetLogiraniKorisnik(HttpContext, u);

            }

            return PartialView("Index", model);


        }
        
        public IActionResult Odjava()
        {



            Autenfikacija.SetLogiraniKorisnik(HttpContext, null);
            return RedirectToAction("Index","Home");
        }
    }
}