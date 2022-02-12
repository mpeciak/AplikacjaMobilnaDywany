using System;
using System.Collections.Generic;
using System.Text;

namespace AplikacjaDywanyMob.Models
{
    public class Dywany
    {
        public int IdProduktu { get; set; }
        public int? Indeks { get; set; }
        public int? ilosc { get; set; }
        public string Nazwa { get; set; }
        public string Grupa { get; set; }
        public decimal Cena { get; set; }
        public string NazwaPolozenia { get; set; }
        public int? IdPolozenia { get; set; }
        public string NazwaPrmocji { get; set; }
        public int? IdPromocji { get; set; }
        public bool? CZyNaPromocji { get; set; }

    }
}
