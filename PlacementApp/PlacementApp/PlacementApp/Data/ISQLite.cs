using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlacementApp.Data
{
    public interface ISQLite
    {
        SQLiteConnection GetConnection();
    }
}
