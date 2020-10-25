using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClassLibrary1.Models;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    



    public class KontaktController : Controller
    {

        private mojDbContext db;

        public KontaktController(mojDbContext c)
        {
            db = c;
        }


        public IActionResult Email()
        {
            return View();
        }
    }
}