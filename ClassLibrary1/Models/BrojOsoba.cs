using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ClassLibrary1.Models
{
    public class BrojOsoba
    {
        public int BrojOsobaID { get; set; }
        [Required]
        public int brOsoba { get; set; }

    }
}
