using AplikacjaDywanyMob.Models;
using AplikacjaDywanyMob.ViewModels.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace AplikacjaDywanyMob.ViewModels.Pracownik
{
    public class NowyPracownikViewModel : ANewItemViewModel<Pracownicy>
    {
        private int numerPracownika;
        private string imie;
        private string nazwisko;
        public NowyPracownikViewModel()
            : base()
        {

        }
        public override bool ValidateSave()
        {
            return !String.IsNullOrWhiteSpace(nazwisko);
        }
        public int NumerPracownika
        {
            get => numerPracownika;
            set => SetProperty(ref numerPracownika, value);
        }
        public string Imie
        {
            get => imie;
            set => SetProperty(ref imie, value);
        }
        public string Nazwisko
        {
            get => nazwisko;
            set => SetProperty(ref nazwisko, value);
        }
        public override Pracownicy SetItem()
        {

            Pracownicy newItem = new Pracownicy()
            {
                IdPracownika = 1,
                Imie = Imie,
                Nazwisko = Nazwisko,
                NumerPracownika = NumerPracownika
            };
            return newItem;
        }
    }
}
