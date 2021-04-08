using System;
using SQLite;

namespace PlacementApp.Models
{
    public class User
    {
        [PrimaryKey, AutoIncrement]
        public int userID { get; set; }
        public int studentID { get; set; }
        public string username { get; set; }
        public string password { get; set; }

        public User() { }
        
        public User(string Username, string Password)
        {
            this.username = Username;
            this.password = Password;
        }
        
    }
}
