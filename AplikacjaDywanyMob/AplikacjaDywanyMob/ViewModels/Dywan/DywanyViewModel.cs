using AplikacjaDywanyMob.Models;
using AplikacjaDywanyMob.ViewModels.Abstract;
using AplikacjaDywanyMob.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace AplikacjaDywanyMob.ViewModels.Dywan
{
    public class DywanyViewModel : AItemViewModel<Dywany>
    {
        public DywanyViewModel()
         : base()
        {
            Title = "Dywany";
        }
        public override void GoToPage()
        {
            Shell.Current.GoToAsync(nameof(NowyDywanPage));
        }
    }
}