using AplikacjaDywanyMob.Models;
using AplikacjaDywanyMob.ViewModels.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace AplikacjaDywanyMob.ViewModels.Dywan
{
    public class NowyDywanViewModel : ANewItemViewModel<Dywany>
    {
        private int indeks;
        private string grupa;
        private int ilosc;
        private decimal cena;
        private string nazwa;
        public NowyDywanViewModel()
            : base()
        {
        }
        public override bool ValidateSave()
        {
            return !String.IsNullOrWhiteSpace(nazwa);
        }
        public int Indeks
        {
            get => indeks;
            set => SetProperty(ref indeks, value);
        }
        public string Grupa
        {
            get => grupa;
            set => SetProperty(ref grupa, value);
        }
        public int Ilosc
        {
            get => ilosc;
            set => SetProperty(ref ilosc, value);
        }
        public string Nazwa
        {
            get => nazwa;
            set => SetProperty(ref nazwa, value);
        }
        public decimal Cena
        {
            get => cena;
            set => SetProperty(ref cena, value);
        }
        public override Dywany SetItem()
        {

            Dywany newItem = new Dywany()
            {
                IdProduktu = 1,
                Nazwa = Nazwa,
                Grupa = Grupa,
                Indeks = Indeks,
                ilosc = Ilosc,
                Cena = Cena
            };
            return newItem;
        }
    }
}