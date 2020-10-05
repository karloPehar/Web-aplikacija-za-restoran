using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ClassLibrary1.ViewModels
{
    public class KomentarVM
    {
        public int KomentarID { get; set; }

        public string Username { get; set; }
        
        [Required(ErrorMessage = "Polje je obavezno.")]
        [MinLength(15,ErrorMessage ="komentar se mora sastojati od minimalno 15 slova")]
        [MaxLength(256, ErrorMessage = "komentar se mora sastojati od maksimalno 256 slova")]
        public string Sadrzaj { get; set; }

        public string vrijemePostavljanja { get; set; }
    }
}
