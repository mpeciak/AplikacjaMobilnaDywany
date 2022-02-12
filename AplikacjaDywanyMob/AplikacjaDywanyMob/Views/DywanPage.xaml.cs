using AplikacjaDywanyMob.ViewModels.Dywan;
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
    public partial class DywanPage : ContentPage
    {
        DywanyViewModel _viewModel;

        public DywanPage()
        {
            InitializeComponent();

            BindingContext = _viewModel = new DywanyViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }
    }
}