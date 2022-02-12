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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IServiceDywany
    {
        [OperationContract]
        List<DywanyForAllView> GetDywany();
        [OperationContract]
        List<MiejscaForAllView> GetMiejsca();
        [OperationContract]
        List<PlusyForAllView> GetPlusy();
        [OperationContract]
        List<PracownicyForAllView> GetPracownicy();
        [OperationContract]
        List<PromocjaForAllView> GetPromocja();
        [OperationContract]
        List<ZdjeciaForAllView> GetZdjecia();
        [OperationContract]
        void AddMiejsce(Miejsce miejsce);
        [OperationContract]
        void AddDywan(Dywan dywan);
        [OperationContract]
        void AddPracownik(Pracownik pracownik);
        [OperationContract]
        void AddPlusy(Plusy plusy);
        [OperationContract]
        void AddZdjecie(Zdjecie zdjecie);
        [OperationContract]
        void AddPromocja(Promocja promocja);
        // TODO: dodaj tutaj operacje usługi
    }


    // Użyj kontraktu danych, jak pokazano w poniższym przykładzie, aby dodać typy złożone do operacji usługi.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }

    }
    [DataContract]
    public class DywanyForAllView
    {
        public int IdDywanu { get; set; }
        public int? Indeks { get; set; }
        public string Nazwa { get; set; }
        public string Grupa { get; set; }
        public decimal? Cena { get; set; }
        public string NazwaPolozenia { get; set; }
        public int? IdPolozenia { get; set; }
        public string NazwaPromocji { get; set; }
        public int? IdPromocji { get; set; }
        public bool? CzyNaPromocji { get; set; }
        public int? IdZdjecia { get; set; }
        public string ZdjecieNazwa { get; set; }

    }
    [DataContract]
    public class MiejscaForAllView
    {
        public int IdMiejsca { get; set; }
        public string NazwaMiejsca { get; set; }
        public string NazwaPolozenia { get; set; }
    }
    [DataContract]
    public class PracownicyForAllView
    {
        public int IdPracownika { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public int NumerPracownika { get; set; }
    }
    [DataContract]
    public class PlusyForAllView
    {
        public int IdPlusu { get; set; }
        public int? Indeks { get; set; }
        public decimal? Ilosc { get; set; }
        public string Nazwa { get; set; }
        public string NazwaMiejsca { get; set; }
        public int? IdMiejsca { get; set; }
        public decimal? Cena { get; set; }
    }
    [DataContract]
    public class PromocjaForAllView
    {
        public int IdPromocji { get; set; }
        public int? Indeks { get; set; }
        public decimal? Ilosc { get; set; }
        public string Nazwa { get; set; }
        public string NazwaMiejsca { get; set; }
        public int? IdMiejsca { get; set; }
        public decimal? Cena { get; set; }
    }
    [DataContract]
    public class ZdjeciaForAllView
    {
        public int IdZdjecia { get; set; }
        public string NazwaZdjecia { get; set; }
        public string UrlZdjecia { get; set; }
        public string Miniaturka { get; set; }
    }
}

