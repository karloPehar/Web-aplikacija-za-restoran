using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ClassLibrary1.ViewModels;
using ClassLibrary1.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WebApplication1.Controllers
{
    public class RezervacijaController : Controller
    {
        public IActionResult Index()
        {
            mojDbContext db = new mojDbContext();


            RezervacijaVM model = new RezervacijaVM();

            model.brojOsoba = db.BrojOsoba
                .Select(p => new SelectListItem
                {
                    Value = p.BrojOsobaID.ToString(),
                    Text = p.brOsoba.ToString()


                }).ToList();


            model.TerminRezervacije = db.TerminRezervacije
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

            db.Dispose();
            return PartialView("~/Views/Rezervacija/Rezervacija.cshtml", model);
        }



        public IActionResult dodajRezervacija(RezervacijaVM x)
        {

            if (ModelState.IsValid)
            {
                mojDbContext db = new mojDbContext();



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
                    Napomena = x.Napomena




                };

                db.Add(nova);
                db.SaveChanges();
                db.Dispose();
                TempData["uspjesnaRezervacija"] = "rezervacija uspjesno obavljena";
            }
           else
                TempData["uspjesnaRezervacija"] = "rezervacija nije uspjesno obavljena";

            //return View("~/Views/Home/index.cshtml");
            return RedirectToAction("Index", "Home");






        }


        public int brojPrikazanihPoslovnica()
        {
            int brPos = 0;

            mojDbContext db = new mojDbContext();
            

            brPos = db.Poslovnica
               .Select(p => new SelectListItem
               {
                   Value = p.PoslovnicaID.ToString(),
                   Text = p.Naziv + ", " + p.Adresa


               }).ToList().Count();
            db.Dispose();
            return brPos;
        }

        public int brojPrikazanihTermina()
        {
            int brTer = 0;

            mojDbContext db = new mojDbContext();
            

            brTer = db.TerminRezervacije
                .Select(p => new SelectListItem
                {
                    Value = p.TerminRezervacijeID.ToString(),
                    Text = p.terminRez


                }).ToList().Count();
            db.Dispose();
            return brTer;
        }

        public int brojPrikazanihBrOsoba()
        {
            int brOsoba = 0;

            mojDbContext db = new mojDbContext();


            brOsoba = db.BrojOsoba
                .Select(p => new SelectListItem
                {
                    Value = p.BrojOsobaID.ToString(),
                    Text = p.brOsoba.ToString()


                }).ToList().Count();
            db.Dispose();
            return brOsoba;
        }
    }
}