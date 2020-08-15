using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace ClassLibrary1.Models
{
    public class Proizvod
    {
        public int ProizvodID { get; set; }

        public Slika slika { get; set; }
        public int slikaID { get; set; }
        [Required]
        [MaxLength(30)]
        public string Naziv { get; set; }
        [Required]
        [MaxLength(100)]
        public string Opis { get; set; }

        public double Cijena { get; set; }

        public TipProizvoda TipProizvoda { get; set; }
        public int TipProizvodaID { get; set; }


        public User user { get; set; }

        public int userID { get; set; }

       




    }
}
