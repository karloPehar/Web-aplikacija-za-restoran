using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ClassLibrary1.Models;
using ClassLibrary1.ViewModels;

namespace WebApplication1.Controllers
{
    public class ProizvodController : Controller
    {
        private mojDbContext db;

        public ProizvodController(mojDbContext c)
        {
            db = c;
        }
        public IActionResult Ponuda()
        {
           // mojDbContext db = new mojDbContext();

            List<ProizvodVM> proizvodi = db.Proizvod
                .Select(p => new ProizvodVM
                {
                    ProizvodID = p.ProizvodID,
                    nazivProizvoda = p.Naziv,
                    opisProizvoda = p.Opis,
                    cijenaProizvoda = p.Cijena,
                    nazivSlike = p.Slika.lokacijaSlike


                }).ToList();

           // db.Dispose();

            ViewData["ProizvodKljuc"] = proizvodi;
           


            return View();
        }
       

    }
}