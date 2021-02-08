using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ClassLibrary1.Models
{
    public class Konekcija
    {
        
        public int KonekcijaID { get; set; }

        public User User { get; set; }

        public int UserID { get; set; }
        
        public string Vrijednost { get; set; }
    }
}
