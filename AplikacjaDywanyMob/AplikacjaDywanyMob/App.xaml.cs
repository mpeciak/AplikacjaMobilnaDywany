using AplikacjaDywanyMob.Services;
using AplikacjaDywanyMob.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AplikacjaDywanyMob
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            DependencyService.Register<DywanDataStore>();
            DependencyService.Register<PlusyDataStore>();
            DependencyService.Register<PracownikDataStore>();
            DependencyService.Register<PromocjeDataStore>();
            DependencyService.Register<MiejsceDataStore>();
            //DependencyService.Register<WartoscDywanowDataStore>();
            DependencyService.Register<ServiceReferenceDywany.ServiceDywanyClient>();

            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
