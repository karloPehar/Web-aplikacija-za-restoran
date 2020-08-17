using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace ClassLibrary1.Models
{
    public class Proizvod
    {
        public int ProizvodID { get; set; }

        public Slika Slika { get; set; }
        public int? SlikaID { get; set; }
        [Required]
        [MaxLength(64)]
        public string Naziv { get; set; }
        [Required]
        [MaxLength(256)]
        public string Opis { get; set; }

        public double Cijena { get; set; }
        
        public TipProizvoda TipProizvoda { get; set; }
        public int? TipProizvodaID { get; set; }


        public User User { get; set; }

        public int? UserID { get; set; }

       




    }
}
