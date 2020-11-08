using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1.Models
{
    public class Chat
    {
        public int ChatID { get; set; }

        public User Korisnik { get; set; }

        public int KorisnikID { get; set; }

        public User KorisnickaSluzba { get; set; }

        public int KorisnickaSluzbaID { get; set; }

        public DateTime VrijemePocetka { get; set; }


    }
}
