using AplikacjaDywanyMob.ViewModels;
using AplikacjaDywanyMob.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace AplikacjaDywanyMob
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
            Routing.RegisterRoute(nameof(NowaPromocjaPage), typeof(NowaPromocjaPage));
            Routing.RegisterRoute(nameof(NoweMiejscePage), typeof(NoweMiejscePage));
            Routing.RegisterRoute(nameof(NowyDywanPage), typeof(NowyDywanPage));
            Routing.RegisterRoute(nameof(NowyPlusPage), typeof(NowyPlusPage));
            Routing.RegisterRoute(nameof(NowyPracownikPage), typeof(NowyPracownikPage));
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }
    }
}
