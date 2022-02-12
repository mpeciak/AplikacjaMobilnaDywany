using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WcfServiceDywany.Model;

namespace WcfServiceDywany
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class ServiceDywany : IServiceDywany
    {


        public void AddDywan(Dywan dywan)
        {
            DywanEntities db = new DywanEntities();
            db.Dywan.Add(dywan);
        }

        public void AddMiejsce(Miejsce miejsce)
        {
            DywanEntities db = new DywanEntities();
            db.Miejsce.Add(miejsce);
        }

        public void AddPlusy(Plusy plusy)
        {
            DywanEntities db = new DywanEntities();
            db.Plusy.Add(plusy);
        }

        public void AddPracownik(Pracownik pracownik)
        {
            DywanEntities db = new DywanEntities();
            db.Pracownik.Add(pracownik);
        }

        public void AddPromocja(Promocja promocja)
        {
            DywanEntities db = new DywanEntities();
            db.Promocja.Add(promocja);
        }

        public void AddZdjecie(Zdjecie zdjecie)
        {
            DywanEntities db = new DywanEntities();
            db.Zdjecie.Add(zdjecie);
        }

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public List<DywanyForAllView> GetDywany()
        {
            DywanEntities db = new DywanEntities();
            return
                 (
                 from dywan in db.Dywan
                 select new DywanyForAllView
                 {
                     IdDywanu = dywan.IdDywanu,
                     Cena = dywan.Cena,
                     Grupa = dywan.Grupa,
                     NazwaPromocji = dywan.Promocja.Nazwa,
                     IdPromocji = dywan.IdPromocji,
                     NazwaPolozenia = dywan.Miejsce.NazwaMiejsca,
                     IdPolozenia = dywan.IdPolozenia,
                     CzyNaPromocji = dywan.CzyNaPromocji,
                     Indeks = dywan.Indeks,
                     Nazwa = dywan.Nazwa,
                     IdZdjecia = dywan.IdZdjecia,
                     ZdjecieNazwa = dywan.Zdjecie.NazwaZdjecia

                 }
                 ).ToList();
        }

        public List<MiejscaForAllView> GetMiejsca()
        {
            DywanEntities db = new DywanEntities();
            return
                (
                  from miejsce in db.Miejsce
                  select new MiejscaForAllView
                  {
                      IdMiejsca = miejsce.IdMiejsca,
                      NazwaMiejsca = miejsce.NazwaMiejsca,
                      NazwaPolozenia = miejsce.NazwaPolozenia
                  }
                ).ToList();
        }

        public List<PlusyForAllView> GetPlusy()
        {
            DywanEntities db = new DywanEntities();
            return
                (
                    from plusy in db.Plusy
                    select new PlusyForAllView
                    {
                        IdPlusu = plusy.IdPlusu,
                        Cena = plusy.Cena,
                        Ilosc = plusy.Ilosc,
                        IdMiejsca = plusy.IdMiejsca,
                        NazwaMiejsca = plusy.Miejsce.NazwaMiejsca,
                        Indeks = plusy.Indeks,
                        Nazwa = plusy.Nazwa,
                    }
                ).ToList();
        }

        public List<PracownicyForAllView> GetPracownicy()
        {
            DywanEntities db = new DywanEntities();
            return
                (
                    from pracownik in db.Pracownik
                    select new PracownicyForAllView
                    {
                        IdPracownika = pracownik.IdPracownika,
                        Imie = pracownik.Imie,
                        Nazwisko = pracownik.Nazwisko,
                        NumerPracownika = pracownik.NumerPracownika
                    }
                 ).ToList();
        }

        public List<PromocjaForAllView> GetPromocja()
        {
            DywanEntities db = new DywanEntities();
            return
                (
                from promocja in db.Promocja
                select new PromocjaForAllView
                {
                    IdPromocji = promocja.IdPromocji,
                    IdMiejsca = promocja.IdMiejsca,
                    NazwaMiejsca = promocja.Miejsce.NazwaMiejsca,
                    Cena = promocja.Cena,
                    Ilosc = promocja.Ilosc,
                    Indeks = promocja.Indeks,
                    Nazwa = promocja.Nazwa
                }
                ).ToList();
        }

        public List<ZdjeciaForAllView> GetZdjecia()
        {
            DywanEntities db = new DywanEntities();
            return
                (
                    from zdjecie in db.Zdjecie
                    select new ZdjeciaForAllView
                    {
                        IdZdjecia = zdjecie.IdZdjecia,
                        NazwaZdjecia = zdjecie.NazwaZdjecia,
                        Miniaturka = zdjecie.Miniaturka,
                        UrlZdjecia = zdjecie.UrlZdjecia
                    }
                ).ToList();
        }
    }

}