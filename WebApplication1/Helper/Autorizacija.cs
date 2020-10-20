using ClassLibrary1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace WebApplication1.Helper
{
    public class AutorizacijaAttribute : TypeFilterAttribute
    {
        public AutorizacijaAttribute(bool administrator, bool korisnik)
            : base(typeof(MyAuthorizeImpl)) 
        {
            Arguments = new object[] { administrator, korisnik };
        }
 

    }

    public class MyAuthorizeImpl : IAsyncActionFilter
    {
        private readonly bool _administrator;
        private readonly bool _korisnik;

        public MyAuthorizeImpl(bool administrator, bool korisnik)
        {
            _administrator = administrator;
            _korisnik = korisnik;
        }

        public async Task OnActionExecutionAsync(ActionExecutingContext filterContext, ActionExecutionDelegate next)
        {
            User nalog = Autenfikacija.GetLogiraniKorisnik(filterContext.HttpContext);

            if (nalog == null)
            {
                filterContext.Result = new RedirectToActionResult("Index", "Home", new { @area = "" });
                return;
            }



            mojDbContext db = filterContext.HttpContext.RequestServices.GetService<mojDbContext>();

            if (_administrator && nalog.UlogaID == 1 && db.User.Any(i => i.UserID == nalog.UserID))
            {
                await next();
                return;
            }

            if (_korisnik && nalog.UlogaID==2 && db.User.Any(i=>i.UserID== nalog.UserID))
            {
                await next();
                return;
            }
           
            //if (_korisnik && db.User.Any(i => i.Nalog.NalogID == nalog.Nalog.NalogID && "korisnik" == nalog.Uloga.nazivUloge))
            //{
            //    await next();
            //    return;
            //}

            //if (_administrator && db.User.Any(i => i.Nalog.NalogID == nalog.Nalog.NalogID && "administrator" == nalog.Uloga.nazivUloge))
            //{
            //    await next();
            //    return;
            //}



            filterContext.Result = new RedirectToActionResult("Index", "Home", new { @area = "" });



        }

    }
}
