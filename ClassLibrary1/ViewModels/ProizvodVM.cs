using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1.ViewModels
{
    public class ProizvodVM
    {
        public int ProizvodID { get; set; }
        
        public string nazivProizvoda { get; set; }

        public string opisProizvoda { get; set; }

        public double cijenaProizvoda { get; set; }

        public string nazivSlike { get; set; }
    }
}
