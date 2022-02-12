using AplikacjaDywanyMob.Models;
using AplikacjaDywanyMob.ViewModels.Abstract;
using AplikacjaDywanyMob.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace AplikacjaDywanyMob.ViewModels.Plusy
{
    public class PlusyViewModel : AItemViewModel<Plus>
    {
        public PlusyViewModel()
            : base()
        {
            Title = "Plusy";
        }

        public override void GoToPage()
        {
            Shell.Current.GoToAsync(nameof(NowyPlusPage));
        }
    }
}
