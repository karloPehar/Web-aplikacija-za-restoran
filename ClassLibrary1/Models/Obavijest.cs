using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1.Models
{
    public class Obavijest
    {
        public int ObavijestID { get; set; }

        public Slika Slika { get; set; }

        public int? SlikaID { get; set; }

        public string Naslov { get; set; }

        public string Sadrzaj { get; set; }

        public DateTime VrijemeObjave { get; set; }

        public User User { get; set; }

        public int? UserID { get; set; } 


    }
}
