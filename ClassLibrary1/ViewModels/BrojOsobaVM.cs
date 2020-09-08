using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ClassLibrary1.ViewModels
{
    public class BrojOsobaVM
    {
        public int BrojOsobaID { get; set; }
        [Required]
        public int brOsoba { get; set; }
    }
}
