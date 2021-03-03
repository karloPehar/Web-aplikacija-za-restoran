
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ClassLibrary1.Models
{
    public class Rezervacija
    {
        public int RezervacijaID { get; set; }
        [MaxLength(64)]
        public string Ime { get; set; }
        [MaxLength(64)]
        public string Prezime { get; set; }
        [MaxLength(64)]
        [Required ]
        public string BrojTelefona { get; set; }
        [MaxLength(128)]
        [Required]
        public string Email { get; set; }

        public string DatumRezervacije { get; set; }

        public DateTime VrijemeZahtjeva { get; set; }
        [MaxLength(256)]
        public string Napomena { get; set; }

        public User User { get; set; }

        public int? UserID { get; set; }

        public TerminRezervacije TerminRezervacije { get; set; }

        public int? TerminRezervacijeID { get; set; }

        public Poslovnica Poslovnica { get; set; }

        public int? PoslovnicaID { get; set; }

        public BrojOsoba BrojOsoba { get; set; }

        public int? BrojOsobaID { get; set; }
    }
}
