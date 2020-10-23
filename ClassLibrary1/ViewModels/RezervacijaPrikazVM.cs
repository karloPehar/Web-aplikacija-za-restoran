using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1.ViewModels
{
    public class RezervacijaPrikazVM
    {
        public int RezervacijaID { get; set; }
        public string Lokacija { get; set; }

        public string Datum { get; set; }

        public string Termin { get; set; }

        public int BrojOsoba { get; set; }
    }
}
