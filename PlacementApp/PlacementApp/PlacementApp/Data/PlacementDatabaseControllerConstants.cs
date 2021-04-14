using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using PlacementApp.Models;
using Xamarin.Forms;
using System.Data.SqlClient;
using System.Data;

namespace PlacementApp.Data
{



    public class PlacementDatabaseControllerConstants
    {
        static object locker = new object();

        SQLiteConnection database;



        public PlacementDatabaseControllerConstants()
        {
            database = DependencyService.Get<ISQLite>().GetConnection();
            database.CreateTable<User>();
        }



        public User GetUser()
        {
            lock (locker)
            {
                if (database.Table<User>().Count() == 0)
                {
                    return null;
                }
                else
                {
                    return database.Table<User>().First();
                }
            }
        }

        public int SaveUser(User user)
        {
            lock (locker)
            {
                if (user.userID != 0)
                {
                    database.Update(user);
                    return user.userID;

                }
                else
                {
                    return database.Insert(user);
                }
            }
        }

        /*
        public int DeleteUser(int id)
        {
            lock (locker)
            {
                return database.Delete<User>(id);
            }
        }
        */

        public bool LoginValidateConstants(string userName1, string pwd1)
        {
            var data = database.Table<Constants>();
            var d1 = Constants.Username == userName1 && Constants.Password == pwd1;

            if (d1 == true)
            {
                return true;
            }
            else
                return false;
        }
    }
}
