using PlacementApp.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace PlacementApp.Views
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