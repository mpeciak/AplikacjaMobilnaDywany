using AplikacjaDywanyMob.Models;
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
    public partial class NowyPracownikPage : ContentPage
    {
        public Pracownicy pracownicy { get; set; }
        public NowyPracownikPage()
        {
            InitializeComponent();
            BindingContext = new NowyPracownikViewModel();

        }
    }
}