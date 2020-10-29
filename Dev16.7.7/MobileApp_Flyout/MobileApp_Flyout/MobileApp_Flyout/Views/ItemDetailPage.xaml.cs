using System.ComponentModel;
using Xamarin.Forms;
using MobileApp_Flyout.ViewModels;

namespace MobileApp_Flyout.Views
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