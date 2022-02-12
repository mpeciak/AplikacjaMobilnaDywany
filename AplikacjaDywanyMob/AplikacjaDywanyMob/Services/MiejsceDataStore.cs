using AplikacjaDywanyMob.Models;
using ServiceReferenceDywany;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AplikacjaDywanyMob.Services
{
    public class MiejsceDataStore : ItemDataStore<Miejsca>
    {
        public MiejsceDataStore()
        {
            items = dywanyServices.GetMiejsca(null).GetMiejscaResult.Select(d => new Miejsca
            {
                IdMiejsca = d.IdMiejsca,
                NazwaMiejsca = d.NazwaMiejsca,
                NazwaPolozenia = d.NazwaPolozenia
            }
          ).ToList();
        }
        public override void Add(Miejsca item)
        {
               dywanyServices.AddMiejsce(new AddMiejsceRequest(new Miejsce { IdMiejsca = item.IdMiejsca, NazwaMiejsca = item.NazwaMiejsca, NazwaPolozenia = item.NazwaPolozenia }));
        }
        public override Miejsca Find(Miejsca item)
        {
            return items.Where((Miejsca arg) => arg.IdMiejsca == item.IdMiejsca).FirstOrDefault();
        }
        public override Miejsca Find(int id)
        {
            return items.Where((Miejsca arg) => arg.IdMiejsca == id).FirstOrDefault();
        }
    }
}
