using ClassLibrary1.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1.ViewModels
{
    public class ListaPorukaVM
    {
        public int PorukaID { get; set; }

        public List<Row> ListaPoruka { get; set; }

        public class Row
        {
            public string User { get; set; }

            public int ChatID { get; set; }

            public string Sadrzaj { get; set; }

            public string VrijemePoruke { get; set; }

            public string DatumPoruke { get; set; }

            public DateTime VrijemeDatumPoruka { get; set; }

        }
       

    }
}
