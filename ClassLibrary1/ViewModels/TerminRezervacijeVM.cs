using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ClassLibrary1.ViewModels
{
    public class TerminRezervacijeVM
    {
        public int TerminRezervacijeID { get; set; }
        [Required]
        public string terminRez { get; set; }

    }
}
