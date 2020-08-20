using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ClassLibrary1.ViewModels;
using ClassLibrary1.Models;

namespace WebApplication1.Controllers
{
    public class JelovnikController : Controller
    {
        public IActionResult Proizvodi()
        {
            mojDbContext db = new mojDbContext();

            List<ProizvodJelovnikVM> proizvodiDorucak = db.Proizvod
                .Select(p => new ProizvodJelovnikVM
                {
                    ProizvodID = p.ProizvodID,
                    nazivProizvoda = p.Naziv,
                    opisProizvoda = p.Opis,
                    cijenaProizvoda = p.Cijena,
                    nazivSlike = p.Slika.lokacijaSlike,
                    tipProizvoda = p.TipProizvoda.Naziv


                }).Where(p => p.tipProizvoda == "dorucak").ToList();


            List<ProizvodJelovnikVM> proizvodiRucak = db.Proizvod
                .Select(p => new ProizvodJelovnikVM
                {
                    ProizvodID = p.ProizvodID,
                    nazivProizvoda = p.Naziv,
                    opisProizvoda = p.Opis,
                    cijenaProizvoda = p.Cijena,
                    nazivSlike = p.Slika.lokacijaSlike,
                    tipProizvoda = p.TipProizvoda.Naziv


                }).Where(p => p.tipProizvoda == "rucak").ToList();

            List<ProizvodJelovnikVM> proizvodiVecera = db.Proizvod
                .Select(p => new ProizvodJelovnikVM
                {
                    ProizvodID = p.ProizvodID,
                    nazivProizvoda = p.Naziv,
                    opisProizvoda = p.Opis,
                    cijenaProizvoda = p.Cijena,
                    nazivSlike = p.Slika.lokacijaSlike,
                    tipProizvoda = p.TipProizvoda.Naziv


                }).Where(p => p.tipProizvoda == "vecera").ToList();

            db.Dispose();

            ViewData["proizvodiDorucak"] = proizvodiDorucak;
            ViewData["proizvodiRucak"] = proizvodiRucak;
            ViewData["proizvodiVecera"] = proizvodiVecera;


            return View();
        }
    }
}