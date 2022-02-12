using AplikacjaDywanyMob.Models;
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
    public partial class NowyDywanPage : ContentPage
    {
        public Dywany dywany { get; set; }
        public NowyDywanPage()
        {
            InitializeComponent();
            BindingContext = new NowyDywanViewModel();

        }
    }
}