using AplikacjaDywanyMob.ViewModels.Miejsce;
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
    public partial class MiejscaPage : ContentPage
    {
        MiejsceViewModel _viewModel;
        public MiejscaPage()
        {
            InitializeComponent();
            BindingContext = _viewModel = new MiejsceViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }
    }
}