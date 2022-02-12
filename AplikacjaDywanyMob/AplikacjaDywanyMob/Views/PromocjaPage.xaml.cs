using AplikacjaDywanyMob.ViewModels.Promocje;
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
    public partial class PromocjaPage : ContentPage
    {
        PromocjeViewModel _viewModel;
        public PromocjaPage()
        {
            InitializeComponent();
            BindingContext = _viewModel = new PromocjeViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }
    }
}