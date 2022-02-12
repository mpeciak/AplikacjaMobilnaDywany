using AplikacjaDywanyMob.Models;
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
    public partial class NowaPromocjaPage : ContentPage
    {
        public Promocj promocj { get; set; }
        public NowaPromocjaPage()
        {
            InitializeComponent();
            BindingContext = new NowaPromocjaViewModel();

        }
    }
}