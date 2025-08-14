using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace HotelApp
{
 
    public static class DbHelper
    {
        private static string connString = "server=localhost;port=3306;database=hoteldb;user=root;password=1234;";

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connString);
        }
    }

}
