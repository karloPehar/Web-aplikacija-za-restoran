using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace ClassLibrary1.Models
{
    public class TipProizvoda
    {
        public int TipProizvodaID { get; set; }
        [MaxLength(64)]
        [Required]
        public string Naziv { get; set; }

    }
}
