using MySql.Data.MySqlClient;
using RPSmartHome.forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace RPSmartHome
{
    internal class dbHelper
    {
        NewroomOrDevice NewroomOrDevice = new NewroomOrDevice();

        // Database connection variable

        public static string server = "localhost";
        public static string database = "muabhotel";
        public static string user = "root";
        public static string pass = "0909";            //Your Database password


        MySqlConnection conn = new MySqlConnection($"SERVER={server};DATABASE={database};UID={user};PASSWORD={pass};");

        //Add roomName to DB
        public static string roomNameDb {  get; set; }
        public void roomName()
        {
            MessageBox.Show($"{NewroomOrDevice.roomName}");
            string query = "INSERT INTO rpsmarthome.rooms (rooms_name) VALUES ('" + NewroomOrDevice.roomName + "');";

            conn.Open();

            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.ExecuteNonQueryAsync();

            conn.Close();
        }

        public void newdevice() 
        {
            MessageBox.Show($"{NewroomOrDevice.deviceName}");
            string query = "rpsmarthome.newdevice";

            conn.Open();

            MySqlCommand cmd = new MySqlCommand(query, conn);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("$deviceName", NewroomOrDevice.deviceName);
            cmd.Parameters.AddWithValue("$roomName", NewroomOrDevice.roomName);
            var ds = new DataSet();

            cmd.ExecuteReader();

            conn.Close();
        }


        public List<string> GetRooms()
        {
            List<string> rooms = new List<string>();

            string query = "SELECT * FROM rpsmarthome.rooms;";

            conn.Open();

            MySqlCommand cmd = new MySqlCommand(query, conn);

            using (MySqlDataReader dataReader = cmd.ExecuteReader())
            {
                while (dataReader.Read())
                {
                    rooms.Add(dataReader["rooms_name"].ToString());
                }
            }
            conn.Close();
            return rooms;

        }

        public List<string> GetDevices()
        {
            //MessageBox.Show($"{NewroomOrDevice.roomName} devices");
            List<string> devices = new List<string>();

            string query = "SELECT * FROM rpsmarthome.devices where rooms_rooms_id = '" + NewroomOrDevice.roomName + "';";

            conn.Open();

            MySqlCommand cmd = new MySqlCommand(query, conn);

            using (MySqlDataReader dataReader = cmd.ExecuteReader())
            {
                while (dataReader.Read())
                {
                    devices.Add(dataReader["devices_name"].ToString());
                }
            }
            conn.Close();
            return devices;

        }

    }
}
