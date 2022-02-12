using AplikacjaDywanyMob.Models;
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
    public partial class NowyPlusPage : ContentPage
    {
        public Plus plus { get; set; }
        public NowyPlusPage()
        {
            InitializeComponent();
            BindingContext = new NowePlusyViewModel();

        }
    }
}