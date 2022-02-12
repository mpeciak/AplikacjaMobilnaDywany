using AplikacjaDywanyMob.Models;
using AplikacjaDywanyMob.ViewModels.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace AplikacjaDywanyMob.ViewModels.Miejsce
{
    public class NoweMiejsceViewModel : ANewItemViewModel<Miejsca>
    {
        private string nazwaMiejsca;
        private string nazwaPolozenia;
        public NoweMiejsceViewModel()
            : base()
        {
        }
        public override bool ValidateSave()
        {
            return !String.IsNullOrWhiteSpace(nazwaMiejsca);
        }
        public string NazwaMiejsca
        {
            get => nazwaMiejsca;
            set => SetProperty(ref nazwaMiejsca, value);
        }
        public string NazwaPolozenia
        {
            get => nazwaPolozenia;
            set => SetProperty(ref nazwaPolozenia, value);
        }
        public override Miejsca SetItem()
        {

            Miejsca newItem = new Miejsca()
            {
                IdMiejsca = 1,
                NazwaMiejsca = NazwaMiejsca,
                NazwaPolozenia = NazwaPolozenia
            };
            return newItem;
        }
    }
}
