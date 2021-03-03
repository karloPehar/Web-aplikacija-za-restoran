using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ClassLibrary1.ViewModels;
using ClassLibrary1.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebApplication1.Helper;
using System.Data.SqlClient;
using System.Configuration;
using Microsoft.Extensions.Configuration;

namespace WebApplication1.Controllers
{
   
    public class RezervacijaController : Controller
    {
        private mojDbContext db;
        private IConfiguration Configuration;

        public RezervacijaController(mojDbContext c, IConfiguration _config)
        {
            db = c;
            Configuration = _config;
        }
        [Autorizacija(true,true)]
        public IActionResult Index()
        {
           
            return View("Rezervacija");
        }
        [Autorizacija(true, true)]
        public IActionResult RezervacijaPartial(RezervacijaVM mod)
        {
            RezervacijaVM model = new RezervacijaVM();

            if(mod!=null)
            {
                RezervacijaVM modeli = new RezervacijaVM();
                modeli = mod;
            }
            
                model.brojOsoba = db.BrojOsoba
                .Select(p => new SelectListItem
                {
                    Value = p.BrojOsobaID.ToString(),
                    Text = p.brOsoba.ToString()


                }).ToList();



           
            
            
           
            model.TerminRezervacije= db.TerminRezervacije
                     .Select(p => new SelectListItem
                     {
                         Value = p.TerminRezervacijeID.ToString(),
                         Text = p.terminRez


                     }).ToList();


            model.poslovnice = db.Poslovnica
                     .Select(p => new SelectListItem
                     {
                         Value = p.PoslovnicaID.ToString(),
                         Text = p.Naziv + ", " + p.Adresa


                     }).ToList();
            model.PoslovnicaID = 1;
            

            

            return PartialView(model);
        }
        
        public IActionResult ProvjeraDatuma(string DatumRezervacije)
        {
            DateTime odabraniDatum = Convert.ToDateTime(DatumRezervacije);
            DateTime trenutniDatum = DateTime.Now;

            if (!(odabraniDatum.Date > trenutniDatum.Date && odabraniDatum.Month >= trenutniDatum.Month && odabraniDatum.Year >= trenutniDatum.Year))
                return Json(false/*"datum mora biti minimalno za jedan dan veci od trenutnog datuma"*/);

            return Json(true);

        }
        [ValidateAntiForgeryToken]
        public IActionResult dodajRezervacija(RezervacijaVM x)
        {

            if (ModelState.IsValid)
            {
                



                Rezervacija nova = new Rezervacija
                {

                    PoslovnicaID = x.PoslovnicaID,
                    Ime = x.Ime,
                    Prezime = x.Prezime,
                    Email = x.Email,
                    DatumRezervacije = x.DatumRezervacije,
                    VrijemeZahtjeva = DateTime.Now,
                    TerminRezervacijeID = x.TerminRezervacijeID,
                    BrojOsobaID = x.brojOsobaID,
                    Napomena = x.Napomena,
                    BrojTelefona = x.BrojTelefona,
                    UserID = Autenfikacija.GetLogiraniKorisnik(HttpContext).UserID



                };

                db.Add(nova);
                db.SaveChanges();
              
                TempData["uspjesnaRezervacija"] = "rezervacija uspjesno obavljena";
            }
           else
                TempData["uspjesnaRezervacija"] = "rezervacija nije uspjesno obavljena";

            
            return RedirectToAction("Index", "Home");
            






        }


       

        public IActionResult ListaRezervacija()
        {

            return View();
        }

        [Autorizacija(true,true)]
        public IActionResult PrikazRezervacija(int userID)
        {
            
            ViewData["aktivneRezervacije"] = db.Rezervacija
                .Where(u=> u.User.UserID==userID)
               .Select(k => new RezervacijaPrikazVM
               {
                   RezervacijaID = k.RezervacijaID,
                   Lokacija = k.Poslovnica.Adresa,
                   Datum = k.DatumRezervacije,
                   Termin = k.TerminRezervacije.terminRez,
                   BrojOsoba = k.BrojOsoba.brOsoba

               }).ToList();

            return PartialView("ListaRezervacijaPartial");
        }

        [Autorizacija(true,true)]
        public IActionResult PonistiRezervaciju(int rezervacijaID, int userID)
        {
            User u = Autenfikacija.GetLogiraniKorisnik(HttpContext);
            if(u.UserID==userID)
            {
                Rezervacija r = db.Rezervacija.Find(rezervacijaID);
                db.Remove(r);
                db.SaveChanges();

                return RedirectToAction("PrikazRezervacija", new { userID = userID });
            }
            return Redirect("/Home/Index");
           
        }
    }

}