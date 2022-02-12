using AplikacjaDywanyMob.Models;
using AplikacjaDywanyMob.ViewModels.Abstract;
using AplikacjaDywanyMob.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace AplikacjaDywanyMob.ViewModels.Pracownik
{
    public class PracownikViewModel : AItemViewModel<Pracownicy>
    {
        public PracownikViewModel()
            : base()
        {
            Title = "Pracownik";
        }
        public override void GoToPage()
        {
            Shell.Current.GoToAsync(nameof(NowyPracownikPage));
        }
    }
}
