using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace ClassLibrary1.Models
{
    public class Uloga
    {
       public int ulogaID {get;set;}

        [Required(AllowEmptyStrings = false)]
        public string nazivUloge { get; set; }

    }
}
