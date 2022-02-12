using AplikacjaDywanyMob.Models;
using AplikacjaDywanyMob.ViewModels.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace AplikacjaDywanyMob.ViewModels.Promocje
{
    public class NowaPromocjaViewModel : ANewItemViewModel<Promocj>
    {
        private int indeks;
        private string grupa;
        private int ilosc;
        private decimal cena;
        private string nazwa;
        private Miejsca selectedMiejce;
        public NowaPromocjaViewModel()
            : base()
        {
            selectedMiejce = new Miejsca();
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
        public Miejsca SelectedMiejce
        {
            get => selectedMiejce;
            set => SetProperty(ref selectedMiejce, value);
        }
        public override Promocj SetItem()
        {

            Promocj newItem = new Promocj()
            {
                IdPromocji = 1,
                Cena = Cena,
                Ilosc = Ilosc,
                Indeks = Indeks,
                Nazwa = Nazwa,
                IdMiejsca = selectedMiejce.IdMiejsca,
                NazwaMiejsca = selectedMiejce.NazwaMiejsca
            };
            return newItem;
        }
    }
}