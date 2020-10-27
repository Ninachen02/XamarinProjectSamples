using System;
using System.Collections.Generic;
using MobileApp_Tabbed.ViewModels;
using MobileApp_Tabbed.Views;
using Xamarin.Forms;

namespace MobileApp_Tabbed
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
