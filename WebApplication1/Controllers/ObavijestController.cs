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
        private mojDbContext db;

        public ObavijestController(mojDbContext c)
        {
            db = c;
        }
        public IActionResult Novosti()
        {

          

            List<ObavijestVM> obavijest = db.Obavijest
                .Select(p => new ObavijestVM
                {
                    ObavijestID = p.ObavijestID,
                    NazivObavijesti = p.Naslov,
                    SadrZajObavijesti = p.Sadrzaj,
                    nazivSlike= p.Slika.lokacijaSlike


                }).OrderByDescending(p => p.ObavijestID).ToList();

            ViewData["obavijestiKljuc"] = obavijest;
           


            return View();
        }

        public int brojacObavijesti()
        {

            
            int br=0;
            br = db.Obavijest.Select(o => o.ObavijestID).Count();



            

            return br;

            

        }
    }


   
}