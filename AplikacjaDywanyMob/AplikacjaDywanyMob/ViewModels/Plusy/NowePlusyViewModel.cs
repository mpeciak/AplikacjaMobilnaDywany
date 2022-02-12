using AplikacjaDywanyMob.Models;
using AplikacjaDywanyMob.Services;
using AplikacjaDywanyMob.ViewModels.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace AplikacjaDywanyMob.ViewModels.Plusy
{
    public class NowePlusyViewModel : ANewItemViewModel<Plus>
    {
        private int indeks;
        private int ilosc;
        private Miejsca selectedMiejsce;
        //private int idMiejsca;
        private decimal cena;
        private string nazwa;
        // private string nazwaMiejsca;
        public List<Miejsca> Miejsca
        {
            get
            {
                return new MiejsceDataStore().items;
            }
        }
        public NowePlusyViewModel()
            : base()
        {
            selectedMiejsce = new Miejsca();
        }
        public override bool ValidateSave()
        {
            return !String.IsNullOrWhiteSpace(nazwa);
        }
        public Miejsca SelectedMiejsce
        {
            get => selectedMiejsce;
            set => SetProperty(ref selectedMiejsce, value);
        }
        public int Indeks
        {
            get => indeks;
            set => SetProperty(ref indeks, value);
        }
        //public int IdMiejsca
        //{
        //    get => idMiejsca;
        //    set => SetProperty(ref idMiejsca, value);
        //}
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
        //public string NazwaMiejsca
        //{
        //    get => nazwaMiejsca;
        //    set => SetProperty(ref nazwaMiejsca, value);
        //}
        public decimal Cena
        {
            get => cena;
            set => SetProperty(ref cena, value);
        }
        public override Plus SetItem()
        {

            Plus newItem = new Plus()
            {
                IdPlusu = 1,
                Nazwa = Nazwa,
                Indeks = Indeks,
                Ilosc = Ilosc,
                Cena = Cena,
                IdMiejsca = selectedMiejsce.IdMiejsca,
                NazwaMiejsca = selectedMiejsce.NazwaMiejsca + " " + selectedMiejsce.NazwaPolozenia,
            };
            return newItem;
        }
    }
}
