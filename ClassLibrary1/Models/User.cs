using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClassLibrary1.Models
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserID { get; set; }

        public Uloga Uloga { get; set; }
        
        public int? UlogaID { get; set; }

        [Required(AllowEmptyStrings = false)]
        [MaxLength(64)]
        public string ime { get; set; }
       
        [Required(AllowEmptyStrings = false)]
        [MaxLength(64)]
        public string prezime { get; set; }
       
        

        [Required(AllowEmptyStrings =false)]
        [MaxLength(20)]
        public string brojTelefona { get; set; }

        [Required(AllowEmptyStrings = false)]
        [MaxLength(64)]
        public string adresaStanovanja { get; set; }

        public Nalog Nalog { get; set; }

        public int? NalogID { get; set; }
    }
}
