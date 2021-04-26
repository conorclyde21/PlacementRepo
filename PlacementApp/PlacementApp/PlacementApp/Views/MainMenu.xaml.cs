using PlacementApp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PlacementApp.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainMenu : ContentPage
    {
        public MainMenu()
        {
            InitializeComponent();


        }

        private async void MenuToProfile(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Profile());
        }

        private async void MenuToPlacement(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PlacementDetails());
        }

        private async void MenuToAssessment(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AssessmentDetails());
        }

        private async void MenuToReflect(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Reflect());
        }


        private async void MenuToLogin(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LoginPage());
        }
    }
}