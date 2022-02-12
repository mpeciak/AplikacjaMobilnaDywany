using AplikacjaDywanyMob.Models;
using AplikacjaDywanyMob.ViewModels.Abstract;
using AplikacjaDywanyMob.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace AplikacjaDywanyMob.ViewModels.Miejsce
{
    public class MiejsceViewModel : AItemViewModel<Miejsca>
    {
        public MiejsceViewModel()
            : base()
        {
            Title = "Miejsce";
        }
        public override void GoToPage()
        {
            Shell.Current.GoToAsync(nameof(NoweMiejscePage));
        }
    }
}
