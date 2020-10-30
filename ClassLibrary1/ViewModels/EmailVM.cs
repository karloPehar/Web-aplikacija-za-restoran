using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ClassLibrary1.ViewModels
{
    public class EmailVM
    {
        public int EmailID { get; set; }
        [Required(ErrorMessage = "Polje je obavezno")]
        public string Ime { get; set; }
        [EmailAddress(ErrorMessage = "unesite validnu email adresu")]
        [Required(ErrorMessage = "Polje je obavezno")]
        public string EmailAdresa { get; set; }
        [Required(ErrorMessage = "Polje je obavezno")]
        [MinLength(15)]
        [MaxLength(256)]
        public string Sadrzaj { get; set; }


    }
}
