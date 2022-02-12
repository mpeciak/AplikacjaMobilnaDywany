using AplikacjaDywanyMob.ViewModels.Plusy;
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
    public partial class PlusPage : ContentPage
    {
        PlusyViewModel _viewModel;
        public PlusPage()
        {
            InitializeComponent();
            BindingContext = _viewModel = new PlusyViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }
    }
}