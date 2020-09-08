
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1.Models
{
    public class Stol
    {
        public int StolID { get; set; }

        public bool Dostupan { get; set; }

        public Poslovnica Poslovnica { get; set; }
        public int? PoslovnicaID { get; set; }

        public KapacitetStola KapacitetStola { get; set; }

        public int? KapacitetStolaID { get; set; }
    }
}