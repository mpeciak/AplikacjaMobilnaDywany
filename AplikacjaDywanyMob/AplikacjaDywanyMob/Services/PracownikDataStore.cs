using AplikacjaDywanyMob.Models;
using ServiceReferenceDywany;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AplikacjaDywanyMob.Services
{
    public  class PracownikDataStore : ItemDataStore<Pracownicy>
    {
        public PracownikDataStore()
        {
            items = dywanyServices.GetPracownicy(null).GetPracownicyResult.Select(d => new Pracownicy
            {
                IdPracownika = d.IdPracownika,
                Imie = d.Imie,
                Nazwisko = d.Nazwisko,
                NumerPracownika = d.NumerPracownika
            }
            ).ToList();
        }
        public override void Add(Pracownicy item)
        {
             dywanyServices.AddPracownik(new AddPracownikRequest(new Pracownik { IdPracownika = item.IdPracownika, Imie = item.Imie, Nazwisko = item.Nazwisko, NumerPracownika = item.NumerPracownika }));
        }
        public override Pracownicy Find(Pracownicy item)
        {
            return items.Where((Pracownicy arg) => arg.IdPracownika == item.IdPracownika).FirstOrDefault();
        }
        public override Pracownicy Find(int id)
        {
            return items.Where((Pracownicy arg) => arg.IdPracownika == id).FirstOrDefault();
        }
    }
}

