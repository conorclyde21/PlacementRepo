using Foundation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UIKit;
using PlacementApp.Data;
using System.IO;
using Xamarin.Forms;
using PlacementApp.iOS.Data;

[assembly: Dependency(typeof(SQLite_IOS))]

namespace PlacementApp.iOS.Data
{
    public class SQLite_IOS : ISQLite
    {
        public SQLite_IOS() { }
        public SQLite.SQLiteConnection GetConnection()
        {
            var fileName = @"Data Source=LAPTOP-GLNNG57B\SQLEXPRESS01;Initial Catalog=TestDatabaseFI;Integrated Security=True";
            var documentPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var libraryPath = Path.Combine(documentPath, "..", "Library");
            var path = Path.Combine(libraryPath, fileName);
            var connection = new SQLite.SQLiteConnection(path);
            return connection;
        }
    }
}