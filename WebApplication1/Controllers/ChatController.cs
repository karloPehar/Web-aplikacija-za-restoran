using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClassLibrary1.Models;
using ClassLibrary1.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using WebApplication1.Hubs;

namespace WebApplication1.Controllers
{
    public class ChatController : Controller
    {

        private mojDbContext db;
        private readonly IHubContext<ChatHub> _hubContext;

        public ChatController(mojDbContext context, IHubContext<ChatHub> hubContext)
        {
            db = context;
            _hubContext = hubContext;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SubmitFormPartial()
        {

          
            return PartialView();
        }

        public IActionResult PosaljiPoruku(PorukaVM model)
        {
            //ChatHub ch = new ChatHub();
            //string val = ch.Konekcija();

            //var id = _hubContext.Clients.Client(ConnectionID);

            _hubContext.Clients.All.SendAsync("PrimljenaPoruka",model.Poruka );
            return PartialView("SubmitFormPartial");
        }
    }
}