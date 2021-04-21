using PlacementApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PlacementApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PlacementDetails : ContentPage
    {
        public PlacementDetails()
        {
            InitializeComponent();
            BindingContext = new PlacementDetailsViewModel();
        }
    }
}