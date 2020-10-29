using System.ComponentModel;
using Xamarin.Forms;
using MobileApp_Tabbed.ViewModels;

namespace MobileApp_Tabbed.Views
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