using MobileApp_Tabbed.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

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