using MobileApp_Flyout.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

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