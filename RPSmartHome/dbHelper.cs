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

        public static string roomId { get; set; }
        
        public void roomName()
        {
            string query = "INSERT INTO rpsmarthome.rooms (rooms_name) VALUES ('" + NewroomOrDevice.roomName + "');";

            conn.Open();

            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.ExecuteNonQueryAsync();

            conn.Close();
        }

        public void newdevice() 
        {
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

        public void getRoomId()
        {
            string query = "rpsmarthome.getRoomId;";

            conn.Open();

            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("$roomName", NewroomOrDevice.roomName);
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    roomId = reader.GetString(0);
                }
            }
            conn.Close();
        }

        public List<string> GetDevices()
        {
            List<string> devices = new List<string>();

            string query = "rpsmarthome.GetDevices;";

            conn.Open();

            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("$roomId", roomId);
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

        public List<string> GetDevicesStatus()
        {
            Dashboard dashboard = new Dashboard();
            //MessageBox.Show($"{Dashboard.devicesName}");

            List<string> devicesStatus = new List<string>();

            string query = "rpsmarthome.GetDevicesStatus;";

            conn.Open();

            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("$devices_name", Dashboard.devicesName);
            using (MySqlDataReader dataReader = cmd.ExecuteReader())
            {
                while (dataReader.Read())
                {
                    devicesStatus.Add(dataReader["devices_status"].ToString());
                }
            }
            conn.Close();
            return devicesStatus;

        }

        public void roomStatus()
        {
            string query = "rpsmarthome.getRoomId;";

            conn.Open();

            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("$roomName", NewroomOrDevice.roomName);
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    roomId = reader.GetString(0);
                }
            }
            conn.Close();
        }

        public void deviceStatus()
        {
            string query = "rpsmarthome.getRoomId;";

            conn.Open();

            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("$roomName", NewroomOrDevice.roomName);
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    roomId = reader.GetString(0);
                }
            }
            conn.Close();
        }
    }
}
