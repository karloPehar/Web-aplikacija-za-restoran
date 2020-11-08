
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1.Models
{
    public class mojDbContext : DbContext
    {
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

        //{

        //    //optionsBuilder.UseSqlServer(@" Server=.;Database=p1903;Trusted_Connection=true;MultipleActiveResultSets=true;User ID=sa;Password=test");
        //    //optionsBuilder.UseSqlServer(@" Server = tcp:p1903.database.windows.net,1433; Initial Catalog = restoran; Persist Security Info = False;
        //    //                                User ID = restoranTest; Password =testTest123; MultipleActiveResultSets = False;
        //    //                                Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30"
        //    //                            );

        //    optionsBuilder.UseSqlServer(@"Server=tcp:p1903restoran.database.windows.net,1433;Initial Catalog=restoran;
        //                                    Persist Security Info=False;User ID=testniUser;Password=testTest123;
        //                                        MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"
        //                                );


        //}
       
       

        public DbSet<User> User { get; set; }

        public DbSet<Proizvod> Proizvod { get; set; }

        public DbSet<Slika> Slika { get; set; }

        public DbSet<TipProizvoda> TipProizvoda { get; set; }

        public DbSet<Uloga> Uloga { get; set; }




        public DbSet<Obavijest> Obavijest { get; set; }

        public DbSet<BrojOsoba> BrojOsoba { get; set; }

        public DbSet<KapacitetStola> KapacitetStola { get; set; }

        public DbSet<Poslovnica> Poslovnica { get; set; }

        public DbSet<Rezervacija> Rezervacija { get; set; }

        public DbSet<Stol> Stol { get; set; }

        public DbSet<TerminRezervacije> TerminRezervacije { get; set; }

        public DbSet<Komentar> Komentar { get; set; }

        public DbSet<Nalog> Nalog { get; set; }

        public DbSet<Token> Token { get; set; }

        public DbSet<Email> Email { get; set; }

        public DbSet<Chat> Chat { get; set; }

        public DbSet<Poruka> Poruka { get; set; }


        public mojDbContext(DbContextOptions<mojDbContext> options)
            : base(options)
        {
        }



    }
}