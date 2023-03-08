using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSmartHome
{
    internal class dbHelper
    {
        // Database connection variable

        public static string server = "localhost";
        public static string database = "muabhotel";
        public static string user = "root";
        public static string pass = "0909";            //Your Database password


        MySqlConnection conn = new MySqlConnection($"SERVER={server};DATABASE={database};UID={user};PASSWORD={pass};");


    }
}
