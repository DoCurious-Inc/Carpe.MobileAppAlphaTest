using Carpe.MobileApp.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Carpe.MobileApp.Views
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