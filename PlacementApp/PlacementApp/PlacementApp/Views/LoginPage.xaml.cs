using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using PlacementApp.Data;
using PlacementApp.Models;
using System.Data.SqlClient;
using System.Data;

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


        string Conn = ("Data Source=LAPTOP-GLNNG57B\\SQLEXPRESS01;Initial Catalog=TestDatabaseFI;Integrated Security=True");


        private void SignInProcedure(object sender, EventArgs e)
        {
            try
            {

                if (Entry_Username.Text == null && Entry_Password.Text == null)
                {
                    DisplayAlert("Login", "Please Enter The User Name & Password", "Ok");
                }
                else
                {
                    SqlConnection con = new SqlConnection(Conn);
                    SqlCommand cmd = new SqlCommand("SELECT * FROM [User] where Username=@UserName and Password=@Password", con);
                    cmd.Parameters.AddWithValue("@UserName", Entry_Username.Text);
                    cmd.Parameters.AddWithValue("@Password", Entry_Password.Text);

                    con.Open();
                    SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adpt.Fill(ds);
                    con.Close();

                    int count = ds.Tables[0].Rows.Count;

                    if (count == 1)
                    {
                        App.Current.MainPage.Navigation.PushAsync(new MainMenu());
                    }
                    else
                    {
                        DisplayAlert("Login", "Invalid Username & Password", "Ok");
                    }
                }


            }

            catch (Exception ex)
            {
                DisplayAlert("Login", ex.Message, "Ok");
            }




            /*
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
            */
        }

    }
}
