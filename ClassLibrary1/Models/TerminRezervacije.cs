
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ClassLibrary1.Models
{
    public class TerminRezervacije
    {
        public int TerminRezervacijeID { get; set; }
        [Required]
        public string terminRez { get; set; }

    }
}
