using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ClassLibrary1.ViewModels
{
    public class RezervacijaVM
    {
       
        public int RezervacijaID { get; set; }

        [Required(ErrorMessage = "Polje je obavezno.")]
        [MaxLength(32)]
        [RegularExpression(@"^[a-zA-Z]*$")]
        public string Ime { get; set; }

        [Required(ErrorMessage = "Polje je obavezno.")]
        [MaxLength(32)]
        [RegularExpression(@"^[a-zA-Z]*$")]
        public string Prezime { get; set; }

        [Required(ErrorMessage = "Polje je obavezno.")]
        [MaxLength(12)]
        [RegularExpression(@"[0-9]{9}")]
        public string BrojTelefona { get; set; }


        [StringLength(320)]
        [RegularExpression(@"^([a-zA-Z0-9_\.\-])+\@(([a-zA-Z0-9\-])+\.)+([a-zA-Z0-9]{2,4})+$", ErrorMessage = "unešeni tekst nije u oblikku maila")]
        [EmailAddress(ErrorMessage ="unesite validnu email adresu")]
        [Required(ErrorMessage = "Polje je obavezno")]
        public string Email { get; set; }



        [Required(ErrorMessage = "Polje je obavezno")]
        public string DatumRezervacije { get; set; }


        
        [MaxLength(512)]
        public string Napomena { get; set; }

        [Required(ErrorMessage = "Polje je obavezno.")]
        public int TerminRezervacijeID { get; set; }

       
        public List<SelectListItem> TerminRezervacije { get; set; }

        [Required(ErrorMessage = "Polje je obavezno.")]
        public int brojOsobaID { get; set; }

       
        public List<SelectListItem> brojOsoba { get; set; }

        [Required(ErrorMessage = "Polje je obavezno.")]
        public int PoslovnicaID { get; set; }
       
        public List<SelectListItem> poslovnice { get; set; }

    }
}
