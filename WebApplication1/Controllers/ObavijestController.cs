using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ClassLibrary1.Models;
using ClassLibrary1.ViewModels;

namespace WebApplication1.Controllers
{
    public class ObavijestController : Controller
    {
        public IActionResult Novosti()
        {

            mojDbContext db = new mojDbContext();

            List<ObavijestVM> obavijest = db.Obavijest
                .Select(p => new ObavijestVM
                {
                    ObavijestID = p.ObavijestID,
                    NazivObavijesti = p.Naslov,
                    SadrZajObavijesti = p.Sadrzaj,
                    nazivSlike= p.Slika.lokacijaSlike


                }).OrderByDescending(p => p.ObavijestID).ToList();

            ViewData["obavijestiKljuc"] = obavijest;
            db.Dispose();


            return View();
        }
    }
}