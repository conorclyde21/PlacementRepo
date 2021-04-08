using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using PlacementApp.Data;
using PlacementApp.Models;

namespace PlacementApp.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {

        PlacementDatabaseController userData;

        public LoginPage()
        {
            InitializeComponent();
            Init();
            userData = new PlacementDatabaseController();
        }


        void Init()
        {

            Entry_Username.Completed += (s, e) => Entry_Password.Focus();
            Entry_Password.Completed += (s, e) => SignInProcedure(s, e);
        }

        private void SignInProcedure(object sender, EventArgs e)
        {

            if (Entry_Username.Text != null && Entry_Password.Text != null)
            {
                var validData = userData.LoginValidate(Entry_Username.Text, Entry_Password.Text);
                if (validData)
                {

                    App.Current.MainPage.Navigation.PushAsync(new MainMenu());

                }
                else
                {
                    
                    DisplayAlert("Login Failed", "Username or Password Incorrect", "OK");
                }
            }
            else
            {
                
                DisplayAlert("Empty Fields", "Enter User Name and Password Please", "OK");
            }
        }

    }
}