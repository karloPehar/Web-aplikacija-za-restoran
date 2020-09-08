
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ClassLibrary1.Models
{
    public class KapacitetStola
    {
        public int KapacitetStolaID { get; set; }
        [Required]
        public int minBrStolica { get; set; }

        public int maxBrStolica { get; set; }
    }
}