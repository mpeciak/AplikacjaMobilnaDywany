using AplikacjaDywanyMob.Models;
using AplikacjaDywanyMob.ViewModels.Abstract;
using AplikacjaDywanyMob.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace AplikacjaDywanyMob.ViewModels.Promocje
{
    public class PromocjeViewModel : AItemViewModel<Promocj>
    {
        public PromocjeViewModel()
         : base()
        {
            Title = "Promocje";
        }
        public override void GoToPage()
        {
            Shell.Current.GoToAsync(nameof(NowaPromocjaPage));
        }
    }
}