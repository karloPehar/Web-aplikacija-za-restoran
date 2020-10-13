using ClassLibrary1.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Helper
{
    public class Autenfikacija
    {
        public static void SetLogiraniKorisnik(HttpContext context, User user)
        {
            context.Session.Set("logiraniKorisnik", user);
        }

        public static User GetLogiraniKorisnik(HttpContext context)
        {
            return context.Session.Get<User>("logiraniKorisnik");
        }
    }
}
