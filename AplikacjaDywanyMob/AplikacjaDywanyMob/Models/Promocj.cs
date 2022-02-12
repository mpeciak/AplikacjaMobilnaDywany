using System;
using System.Collections.Generic;
using System.Text;

namespace AplikacjaDywanyMob.Models
{
    public  class Promocj
    {
        public int IdPromocji { get; set; }
        public int? Indeks { get; set; }
        public string NazwaMiejsca { get; set; }
        public int? IdMiejsca { get; set; }
        public string Nazwa { get; set; }
        public decimal? Ilosc { get; set; }
        public decimal? Cena { get; set; }

    }
}
