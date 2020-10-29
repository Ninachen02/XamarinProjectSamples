using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MobileApp_Tabbed.Services;
using MobileApp_Tabbed.Views;

namespace MobileApp_Tabbed
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
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
