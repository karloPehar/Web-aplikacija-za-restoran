using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ClassLibrary1.Models
{
    public class Chat
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ChatID { get; set; }

        public User Korisnik { get; set; }

        public int KorisnikID { get; set; }



        public DateTime VrijemePocetka { get; set; }


       



    }
}
