
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ClassLibrary1.Models
{
    public class Poslovnica
    {
        public int PoslovnicaID { get; set; }
        [Required]
        public string Naziv { get; set; }

        public string Adresa { get; set; }

        public User User { get; set; }

        public int? UserID { get; set; }
    }
}
