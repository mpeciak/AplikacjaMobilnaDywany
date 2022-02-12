using AplikacjaDywanyMob.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace AplikacjaDywanyMob.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}