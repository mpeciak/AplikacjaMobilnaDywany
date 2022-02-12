using AplikacjaDywanyMob.Models;
using ServiceReferenceDywany;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AplikacjaDywanyMob.Services
{
    public class DywanDataStore:ItemDataStore<Dywany>
    {
        public DywanDataStore()
        {
            items = dywanyServices.GetDywany(null).GetDywanyResult.Select(d => new Dywany
            {
                //IdProduktu = d.IdProkuktu,
                Indeks = d.Indeks,
                IdPolozenia = d.IdPolozenia,
                Grupa = d.Grupa,
                ilosc = d.Ilosc,
                Nazwa = d.Nazwa,
                CZyNaPromocji = d.CzyNaPromocji,
                IdPromocji = d.IdPromocji,
                NazwaPolozenia = d.NazwaPolozenia,
                NazwaPrmocji = d.NazwaPromocji
            }
            ).ToList();
            //List<DywanyForView> listaDFV = _dywanyServices.GetDywany(null).GetDywanyResult.ToList();
            //items = new List<Dywany>();
            //foreach (var d in listaDFV)
            //{
            //    items.Add(new Dywany
            //    {
            //        IdProduktu=d.IdProkuktu,
            //        Indeks=d.Indeks,
            //        IdPolozenia=d.IdPolozenia,
            //        Grupa=d.Grupa,
            //        ilosc=d.Ilosc,
            //        Nazwa=d.Nazwa,
            //        CZyNaPromocji=d.CzyNaPromocji,
            //        IdPromocji=d.IdPromocji,
            //        NazwaPolozenia=d.NazwaPolozenia,
            //        NazwaPrmocji=d.NazwaPromocji
            //    }
            //    );
            //}
            //    items = new List<Dywany>()
            //    {
            //       new Dywany{IdDywanu=1,Nazwa="Shagi",ilosc=1,Cena=145},
            //       new Dywany{IdDywanu=2,Nazwa="Shagssszzzi",ilosc=2,Cena=135},
            //       new Dywany{IdDywanu=3,Nazwa="zzzz",ilosc=3,Cena=165},
            //       new Dywany{IdDywanu=4,Nazwa="Shagddddi",ilosc=4,Cena=175},
            //    };
        }
        public override void Add(Dywany item)
        {
            dywanyServices.AddDywan(new AddDywanRequest(new Dywan {Indeks=item.Indeks,Cena=item.Cena,Grupa=item.Grupa,Ilosc=item.ilosc,Nazwa=item.Nazwa }));
        }
        public override Dywany Find(Dywany item)
        {
            return items.Where((Dywany arg) => arg.IdProduktu == item.IdProduktu).FirstOrDefault();
        }
        public override Dywany Find(int id)
        {
            return items.Where((Dywany arg) => arg.IdProduktu == id).FirstOrDefault();
        }
    }
}