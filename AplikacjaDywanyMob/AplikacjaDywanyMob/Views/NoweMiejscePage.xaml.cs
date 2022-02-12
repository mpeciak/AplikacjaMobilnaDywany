using AplikacjaDywanyMob.Models;
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
    public partial class NoweMiejscePage : ContentPage
    {
        public Miejsca miejsca { get; set; }
        public NoweMiejscePage()
        {
            InitializeComponent();
            BindingContext = new NoweMiejsceViewModel();

        }
    }
}