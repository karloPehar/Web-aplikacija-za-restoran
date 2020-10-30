using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.Extensions.Configuration;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Helper
{
    public static class EmailPostavka
    {
        public static void SendEmail(IConfiguration Configuration, string PosiljateljIme, string PosiljateljEmail,string Naslov,string Sadrzaj )
        {
            var Email = new MimeMessage();

            //Email.From.Add(new MailboxAddress(PosiljateljIme, PosiljateljEmail));
            Email.From.Add(new MailboxAddress(Configuration.GetValue<string>("EmailPostavka:Name"), Configuration.GetValue<string>("EmailPostavka:Email")));


            Email.To.Add(new MailboxAddress(Configuration.GetValue<string>("EmailPostavka:Name"), Configuration.GetValue<string>("EmailPostavka:Email")));

            Email.Subject = Naslov;

            Email.Body = new TextPart("html")
            {
                Text =Sadrzaj+"<br><hr>"+PosiljateljEmail+",<br>"+PosiljateljIme
                
            };
         

            using (var client= new SmtpClient())
            {
                client.Connect(Configuration.GetValue<string>("SmtpSettings:ServerAddress"),
                   int.Parse(Configuration.GetValue<string>("SmtpSettings:Port")), false);
                
                client.Authenticate(Configuration.GetValue<string>("EmailPostavka:Email"),
                    Configuration.GetValue<string>("EmailPostavka:Password"));
                client.Send(Email);
                client.Disconnect(true);
            }

        }
    }
}
