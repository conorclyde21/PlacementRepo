using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using PlacementApp.Data;
using PlacementApp.Droid.Data;
using Xamarin.Forms;

[assembly: Dependency(typeof(SQLite_Android))]

namespace PlacementApp.Droid.Data
{

    public class SQLite_Android : ISQLite
    {
        
        public SQLite_Android() { }
        
        
        public SQLite.SQLiteConnection GetConnection()
        {
            
            var sqliteFileName = @"Data Source = LAPTOP - GLNNG57B\SQLEXPRESS01; Initial Catalog = TestDatabaseFI; Integrated Security = True";
            string documentPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var path = Path.Combine(documentPath, sqliteFileName);
            var conn = new SQLite.SQLiteConnection(path);

            return conn;
            
        }
        
    }
}