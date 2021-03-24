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

            /*

            var vm = new LoginViewModel();
            this.BindingContext = vm;
            vm.DisplayInvalidLoginPrompt += () => DisplayAlert("Error", "Invalid Login, try again", "OK");
            vm.ValidLoginPrompt += () => DisplayAlert("Welcome", "Login Success", "OK");

            Email.Completed += (object sender, EventArgs e) =>
            {
                Password.Focus();
            };

            Password.Completed += (object sender, EventArgs e) =>
            {
                vm.SubmitCommand.Execute(null);
            };
            */


        }


        void Init()
        {

            Entry_Username.Completed += (s, e) => Entry_Password.Focus();
            Entry_Password.Completed += (s, e) => SignInProcedure(s, e);
        }


        /*
        void SignInProcedure(object sender, EventArgs e)
        {
            User user = new User(Entry_Username.Text, Entry_Password.Text);
            if (user.CheckInformation())
            {
                App.PlacementDatabase.SaveUser(user);
                App.Current.MainPage.Navigation.PushAsync(new MainMenu());
            }
            else
            {
                DisplayAlert("Login", "Login Not Correct, empty username or password", "Ok");
            }
        }
        */

        private async void SignInProcedure(object sender, EventArgs e)
        {

            if (Entry_Username.Text != null && Entry_Password.Text != null)
            {
                var validData = userData.LoginValidate(Entry_Username.Text, Entry_Password.Text);
                if (validData)
                {

                    await App.Current.MainPage.Navigation.PushAsync(new MainMenu());

                }
                else
                {
                    
                    await DisplayAlert("Login Failed", "Username or Password Incorrect", "OK");
                }
            }
            else
            {
                
                await DisplayAlert("Empty Fields", "Enter User Name and Password Please", "OK");
            }
        }





    }
}