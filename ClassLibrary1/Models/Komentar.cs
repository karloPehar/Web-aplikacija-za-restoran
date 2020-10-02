using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1.Models
{
    public class Komentar
    {
        public int KomentarID { get; set; }

        public string Sadrzaj { get; set; }

        public User User { get; set; }

        public  int UserID { get; set; }

        public DateTime VrijemePostavljanja { get; set; }
    }
}
