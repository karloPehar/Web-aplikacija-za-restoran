using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ClassLibrary1.Models
{
    public class Nalog
    {
        public int NalogID { get; set; }
        [Required]
        [MaxLength(128)]
        public string Email { get; set; }
        [Required]
        [MaxLength(50)]
        public string Lozinka { get; set; }
        [Required]
        public DateTime DatumKreiranja { get; set; }
    }
}
