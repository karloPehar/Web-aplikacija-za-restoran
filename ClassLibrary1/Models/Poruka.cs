using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1.Models
{
    public class Poruka
    {
        public int PorukaID { get; set; }

        public string Sadrzaj { get; set; }

        public DateTime VrijemeSlanja { get; set; }

        public Chat Chat { get; set; }

        public int ChatID { get; set; }

        public User Posiljatelj { get; set; }
        public int PosijateljID { get; set; }
    }
}
