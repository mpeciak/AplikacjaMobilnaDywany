using AplikacjaDywanyMob.Models;
using ServiceReferenceDywany;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AplikacjaDywanyMob.Services
{
    public  class PromocjeDataStore : ItemDataStore<Promocj>
    {
        public PromocjeDataStore()
        {
            items = dywanyServices.GetPromocja(null).GetPromocjaResult.Select(d => new Promocj
            {
                IdPromocji = d.IdPromocji,
                Cena = d.Cena,
                Ilosc = d.Ilosc,
                Indeks = d.Indeks,
                Nazwa = d.Nazwa
            }
            ).ToList();
        }
        public override void Add(Promocj item)
        {
             dywanyServices.AddPromocja(new AddPromocjaRequest(new Promocja { IdPromocji = item.IdPromocji, Cena = item.Cena, Ilosc= item.Ilosc,Indeks=item.Indeks,Nazwa=item.Nazwa }));
        }
        public override Promocj Find(Promocj item)
        {
            return items.Where((Promocj arg) => arg.IdPromocji == item.IdPromocji).FirstOrDefault();
        }
        public override Promocj Find(int id)
        {
            return items.Where((Promocj arg) => arg.IdPromocji == id).FirstOrDefault();
        }
    }
}
