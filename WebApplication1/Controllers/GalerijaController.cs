using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ClassLibrary1.ViewModels;
using ClassLibrary1.Models; 

namespace WebApplication1.Controllers
{
    public class GalerijaController : Controller
    {
        private mojDbContext db;

        public GalerijaController(mojDbContext c)
        {
            db = c;
        }
        public IActionResult Slike()
        {

           

            List<SlikaVM> slika = db.Slika
                .Select(s => new SlikaVM
                {
                   SlikaID= s.SlikaID,
                   nazivSlike= s.lokacijaSlike


                }).ToList();

            ViewData["slikaKljuc"] = slika;
            //db.Dispose();


            return View();

        }
    }
}