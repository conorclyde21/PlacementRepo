using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using PlacementApp.Models;
using Xamarin.Forms;

namespace PlacementApp.Data
{
    public class PlacementDatabaseController
    {
        static object locker = new object();

        SQLiteConnection database;

        


        public PlacementDatabaseController()
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
                if(user.userID != 0)
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

        public int DeleteUser(int id)
        {
            lock (locker)
            {
                return database.Delete<User>(id);
            }
        }

        public bool LoginValidate(string userName1, string pwd1)
        {
            var data = database.Table<User>();
            var d1 = data.Where(x => x.username == userName1 && x.password == pwd1).FirstOrDefault();

            if (d1 != null)
            {
                return true;
            }
            else
                return false;
        }

    }
}
