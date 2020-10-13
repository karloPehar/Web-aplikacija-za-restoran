using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ClassLibrary1.Models
{
    public class Token
    {
        public int TokenID { get; set; }
        [Required]
        public string Vrijednost { get; set; }

        public Nalog Nalog { get; set; }

        public int? NalogID { get; set; }

        [Required]
        public DateTime VrijemeKreiranja { get; set; }
    }
}
