using PlacementApp.Pages;
using Xamarin.Forms;
using System;
using System.IO;
using PlacementApp.Data;
using PlacementApp.Views;

namespace PlacementApp
{
    public partial class App : Application
    {
        static PlacementDatabaseController placementDatabase;

        public static PlacementDatabaseController PlacementDatabase
        {
            get
            {
                if (placementDatabase == null)
                {
                    placementDatabase = new PlacementDatabaseController();

                }
                return placementDatabase;
            }
        }


        public App()
        {
            Xamarin.Forms.DataGrid.DataGridComponent.Init();

            InitializeComponent();

            MainPage = new NavigationPage(new LoginPage());

        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }

        
    }
}
