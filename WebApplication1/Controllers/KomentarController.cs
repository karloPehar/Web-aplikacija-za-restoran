using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClassLibrary1.Models;
using ClassLibrary1.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class KomentarController : Controller
    {
        public IActionResult Lista()
        {
            mojDbContext db = new mojDbContext();

            ViewData["komentariVD"] = db.Komentar
                .Select(k => new KomentarVM
                {
                    Username = k.User.ime,
                    Sadrzaj = k.Sadrzaj,
                    vrijemePostavljanja = k.VrijemePostavljanja.ToShortDateString(),
                    KomentarID= k.KomentarID

                }).OrderByDescending(v=> v.KomentarID).ToList();


            db.Dispose();



            return View();
        }

        public IActionResult Dodaj()
        {

            return PartialView();
        }

        public IActionResult Snimi(KomentarVM model)
        {
            //testiranje rada kontrolera
           
           
            if (ModelState.IsValid)
            {
                mojDbContext db = new mojDbContext();
                Komentar novi = new Komentar
                {
                    Sadrzaj = model.Sadrzaj,
                    VrijemePostavljanja = DateTime.Now,
                    UserID = 2




                };

                db.Komentar.Add(novi);
                db.SaveChanges();
                db.Dispose();

            }

            return RedirectToAction("Lista");
        }

        public IActionResult Ponisti()
        {


            return PartialView("DodajButtonPartial");
        }
    }
}