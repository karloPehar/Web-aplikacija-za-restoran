using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ClassLibrary1.ViewModels
{
    public class RezervacijaVM
    {
        public int  RezervacijaID {get;set;}

        [Required(ErrorMessage = "Polje je obavezno.")]
        [MaxLength(32)]
        [RegularExpression("^[a - zA - Z] *$")]
        public string Ime { get; set; }

        [Required(ErrorMessage = "Polje je obavezno.")]
        [MaxLength(32)]
        [RegularExpression("^[a - zA - Z] *$")]
        public string Prezime { get; set; }
        
        [Required(ErrorMessage = "Polje je obavezno.")]
        [MaxLength(12)]
        [RegularExpression("[0-9]{9}")]
        public string BrojTelefona { get; set; }
        
        [Required(ErrorMessage = "Polje je obavezno.")]
        [MaxLength(128)]
        [RegularExpression(@"^[a-z0-9][-a-z0-9.!#$%&'*+-=?^_`{|}~\/]+@([-a-z0-9]+\.)+[a-z]{2,5}$")]
        public string Email { get; set; }

       
        [Required(ErrorMessage = "Polje je obavezno.")]
        [MaxLength(16)]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public string DatumRezervacije { get; set; }


        [Required(ErrorMessage = "Polje je obavezno.")]
        [MaxLength(512)]
        public string Napomena { get; set; }

        [Required]
        public int TerminRezervacijeID { get; set; }

        [Required(ErrorMessage = "Polje je obavezno.")]
        public List<SelectListItem> TerminRezervacije { get; set; }

        [Required]
        public int brojOsobaID { get; set; }

        [Required(ErrorMessage = "Polje je obavezno.")]
        public List<SelectListItem> brojOsoba { get; set; }

        [Required]
        public int PoslovnicaID { get; set; }
        [Required(ErrorMessage = "Polje je obavezno.")]
        public List<SelectListItem> poslovnice { get; set; }

    }
}
