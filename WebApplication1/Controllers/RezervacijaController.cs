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
           
            ViewData["brOsobaVD"] = db.BrojOsoba
                .Select(p => new SelectListItem
                {
                    Value= p.BrojOsobaID.ToString(),
                    Text= p.brOsoba.ToString()


                }).ToList();
            
            ViewData["terminRezervacijeVD"] = db.TerminRezervacije
                .Select(p => new SelectListItem
                {
                    Value = p.TerminRezervacijeID.ToString(),
                    Text = p.terminRez


                }).ToList();

            ViewData["PoslovnicaVD"] = db.Poslovnica
                .Select(p => new SelectListItem
                {
                    Value = p.PoslovnicaID.ToString(),
                    Text = p.Naziv+", "+p.Adresa


                }).ToList();
            db.Dispose();
            return PartialView("~/Views/Rezervacija/Rezervacija.cshtml");
        }
    }
}