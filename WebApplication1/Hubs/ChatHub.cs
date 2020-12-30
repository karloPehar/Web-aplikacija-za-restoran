using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClassLibrary1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.SignalR;
using WebApplication1.Controllers;
using WebApplication1.Helper;

namespace WebApplication1.Hubs
{


    public class ChatHub : Hub
    {
        //public override Task OnConnectedAsync()
        //{
        //    string name = Context.User.Identity.Name;

        //   // Groups.AddToGroupAsync(Context.ConnectionId, name);

        //    return base.OnConnectedAsync();
        //}
        //public override async Task OnConnectedAsync()
        //{
        //    //Session["asd"] = Context.ConnectionId;
        //}
        //private mojDbContext db;
        //private HubCallerContext hcc;
        // public string GetConnectionId()
        // {
        //     return Context.ConnectionId;
        // }
        //public  string Konekcija()
        // {
        //    return Context.ConnectionId;
        //     //Console.WriteLine(Context.ConnectionId);
        // }
        //public ChatHub(mojDbContext context, HubCallerContext hc)
        //{
        //    db = context;
        //    hcc = hc;
        //}

        //public Task SendMessageToAll(string message)
        //{

        //    Console.WriteLine("proba");
        //    Console.WriteLine(Context.User.Identity.Name);



        //    return Clients.All.SendAsync("PrimljenaPoruka", message);
        //}

        //public Task SendMessageToAll(string poruka)
        //{





        //    return Clients.All.SendAsync("test", poruka);
        //}

    }
}
