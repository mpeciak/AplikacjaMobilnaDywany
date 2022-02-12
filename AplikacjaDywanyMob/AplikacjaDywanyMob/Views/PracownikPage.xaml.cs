using AplikacjaDywanyMob.ViewModels.Pracownik;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AplikacjaDywanyMob.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PracownikPage : ContentPage
    {
        PracownikViewModel _viewModel;
        public PracownikPage()
        {
            InitializeComponent();
            BindingContext = _viewModel = new PracownikViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }
    }
}