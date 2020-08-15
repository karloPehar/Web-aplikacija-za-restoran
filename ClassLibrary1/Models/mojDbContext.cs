using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1.Models
{
    public class mojDbContext : DbContext
    {

        public DbSet<Proizvod> Proizvod { get; set; }

        public DbSet<Slika> Slika { get; set; }

        public DbSet<TipProizvoda> TipProizvoda { get; set; }

        public DbSet<Uloga> Uloga { get; set; }

        public DbSet<User> User { get; set; }

       




        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

        {

            optionsBuilder.UseSqlServer(@" Server=.;Database=p1903;Trusted_Connection=true;MultipleActiveResultSets=true;User ID=sa;Password=test");

        }

        
    }
}
