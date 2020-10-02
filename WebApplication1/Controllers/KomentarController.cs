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
                    vrijemePostavljanja = k.VrijemePostavljanja.ToShortDateString()

                }).OrderByDescending(v=> v.vrijemePostavljanja).ToList();


            db.Dispose();



            return View();
        }
    }
}