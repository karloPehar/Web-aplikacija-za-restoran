using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace ClassLibrary1.Models
{
    public class Slika
    {

        public int SlikaID { get; set; }

        public byte[] slika { get; set; }
        [Required]
        public DateTime datumPostavljanja { get; set; }
        public User User { get; set; }
       
        public int? UserID { get; set; }
        [Required]
        public string lokacijaSlike { get; set; }

    }
}
