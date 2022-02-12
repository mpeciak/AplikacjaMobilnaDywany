using AplikacjaDywanyMob.Models;
using ServiceReferenceDywany;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AplikacjaDywanyMob.Services
{
    public class PlusyDataStore : ItemDataStore<Plus>
    {
        public PlusyDataStore()
        {
            items = dywanyServices.GetPlusy(null).GetPlusyResult.Select(d => new Plus
            {
                IdPlusu = d.IdPlusu,
                Indeks = d.Indeks,
                Cena = d.Cena,
                Ilosc = d.Ilosc,
                Nazwa = d.Nazwa,
                NazwaMiejsca = d.NazwaPolozenia

            }
            ).ToList();
        }
        public override void Add(Plus item)
        {
            dywanyServices.AddPlusy(new AddPlusyRequest(new Plusy
            {
                Indeks = item.Indeks,
                Cena = item.Cena,
                IdMiejsca = item.IdMiejsca,
                Ilosc = item.Ilosc,
                Nazwa = item.Nazwa,
            }));
        }
        public override Plus Find(Plus item)
        {
            return items.Where((Plus arg) => arg.IdPlusu == item.IdPlusu).FirstOrDefault();
        }
        public override Plus Find(int id)
        {
            return items.Where((Plus arg) => arg.IdPlusu == id).FirstOrDefault();
        }
    }
}