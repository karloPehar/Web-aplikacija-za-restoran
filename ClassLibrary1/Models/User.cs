using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace ClassLibrary1.Models
{
    public class User
    {
        public int userID { get; set; }

        public Uloga Uloga { get; set; }
        [Required]
        public int UlogaID { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string ime { get; set; }
       
        [Required(AllowEmptyStrings = false)]
        public string prezime { get; set; }
       
        [Required(AllowEmptyStrings = false)]
        public string email { get; set; }

        [Required(AllowEmptyStrings =false)]
        public string brojTelefona { get; set; }

        public string adresaStanovanja { get; set; }
    }
}
