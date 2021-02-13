using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ClassLibrary1.ViewModels
{
    public class PorukaVM
    {
        public int PorukaID { get; set; }
        [Required(ErrorMessage = "Polje je obavezno.")]
        [MaxLength(256,ErrorMessage ="Poruka se može sastojati od maksimalno 256 znakova")]
        public string Poruka { get; set; }
    }
}
