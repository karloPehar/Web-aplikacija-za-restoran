using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ClassLibrary1.ViewModels
{
    public class NalogVM
    {
        public int NalogID { get; set; }
        [StringLength(320)]
        [RegularExpression(@"^([a-zA-Z0-9_\.\-])+\@(([a-zA-Z0-9\-])+\.)+([a-zA-Z0-9]{2,4})+$", ErrorMessage = "unešeni tekst nije u oblikku maila")]
        [EmailAddress(ErrorMessage = "unesite validnu email adresu")]
        [Required(ErrorMessage = "Polje je obavezno")]
        public string Email { get; set; }
        [Required]
        
        public string Lozinka { get; set; }
    }
}
