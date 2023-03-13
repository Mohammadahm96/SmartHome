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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


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

        #region Login

        LoginRegs LoginRegs = new LoginRegs();

        public static string userNameDb { get; set; }
        public static int passwordDb { get; set; }
        public static int loginId { get; set; }
        public static string personName { get; set; }

        public void logIn()
        {
            string query = "rpsmarthome.logIn;";
            conn.Open();

            MySqlCommand cmd = new MySqlCommand(query, conn);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("$userName", LoginRegs.userName);
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    loginId = reader.GetInt32(0);
                    userNameDb = reader.GetString(1);
                    passwordDb = reader.GetInt32(2);

                }
            }
            conn.Close(); ;
        }


        public void person()
        {
            string query = "rpsmarthome.getPerson;";
            conn.Open();

            MySqlCommand cmd = new MySqlCommand(query, conn);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("$loginId", loginId);
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    personName = reader.GetString(1);

                }
            }
            conn.Close(); ;
        }

        #endregion

        #region Register

        public static int duplicateUsrname { get; set; }
        public void Register()
        {
            string query = "rpsmarthome.Register;";
            conn.Open();

            MySqlCommand cmd = new MySqlCommand(query, conn);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("$fullName", LoginRegs.fullName);
            cmd.Parameters.AddWithValue("$userName", LoginRegs.userNameRg);
            cmd.Parameters.AddWithValue("$pass", Convert.ToInt32(LoginRegs.passwordRg));
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    DuplicateRoom = reader.GetInt32(0);

                }
            }
            conn.Close(); ;
        }


        public void checkDuplicateUsername()
        {
            string query = "rpsmarthome.checkDuplicateUsername;";

            conn.Open();

            MySqlCommand cmd = new MySqlCommand(query, conn);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("$userName", LoginRegs.userNameRg);
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    duplicateUsrname = reader.GetInt32(0);

                }
            }
            conn.Close(); ;
        }

        #endregion

        #region rooms and devices
        //Add roomName to DB
        public static string roomId { get; set; }
        public static int DuplicateRoom { get; set; }
        
        public void checkDuplicateRoom()
        {
            string query = "rpsmarthome.checkDuplicateRoom;";

            conn.Open();

            MySqlCommand cmd = new MySqlCommand(query, conn);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("$roomName", NewroomOrDevice.roomName);
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    DuplicateRoom = reader.GetInt32(0);

                }
            }
            conn.Close(); ;
        }
        public void newRoom()
        {
            string query = "rpsmarthome.newRoom;";

            conn.Open();

            MySqlCommand cmd = new MySqlCommand(query, conn);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("$roomName", NewroomOrDevice.roomName);
            var ds = new DataSet();

            cmd.ExecuteReader();

            conn.Close(); ;
        }

        public void newDevice() 
        {
            string query = "rpsmarthome.newDevice";
            conn.Open();

            MySqlCommand cmd = new MySqlCommand(query, conn);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("$deviceName", NewroomOrDevice.deviceName);
            cmd.Parameters.AddWithValue("$roomName", Dashboard.roomName);
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

            cmd.Parameters.AddWithValue("$roomName", Dashboard.roomName);
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
            List<string> devicesStatus = new List<string>();

            string query = "rpsmarthome.GetDevicesStatus;";

            conn.Open();

            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("$devices_name", Dashboard.deviceName);
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


        public List<string> GetRoomStatus()
        {
            Dashboard dashboard = new Dashboard();

            List<string> devicesStatus = new List<string>();

            string query = "rpsmarthome.GetRoomStatus;";

            conn.Open();

            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("$rooms_name", Dashboard.roomName);
            using (MySqlDataReader dataReader = cmd.ExecuteReader())
            {
                while (dataReader.Read())
                {
                    devicesStatus.Add(dataReader["rooms_status"].ToString());
                }
            }
            conn.Close();
            return devicesStatus;

        }



        public void setRoomStatus()
        {
            string query = "rpsmarthome.setRoomStatus;";

            conn.Open();

            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("$rooms_name", NewroomOrDevice.roomName);
            cmd.Parameters.AddWithValue("$roomStatus", Dashboard.roomStatus);
            cmd.Parameters.AddWithValue("$rooms_rooms_id", roomId);
            var ds = new DataSet();

            cmd.ExecuteReader();

            conn.Close();
        }
        
        public void setDeviceStatus()
        {
            string query = "rpsmarthome.setDeviceStatus;";
            conn.Open();

            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("$devices_name", Dashboard.deviceName);
            cmd.Parameters.AddWithValue("$rooms_name", Dashboard.roomName);
            cmd.Parameters.AddWithValue("$devicesStatus", Dashboard.devicesStatus);
           
            var ds = new DataSet();

            cmd.ExecuteReader();

            conn.Close();
        }

        public void deleteRoom()
        {
            string query = "rpsmarthome.deleteRoom;";

            conn.Open();

            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("$rooms_name", Dashboard.deleteRoomORDevice);

            var ds = new DataSet();

            cmd.ExecuteReader();

            conn.Close();
        }
        public void deleteDevice()
        {
            string query = "rpsmarthome.deleteDevice;";

            conn.Open();

            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("$devices_name", Dashboard.deleteRoomORDevice);

            var ds = new DataSet();

            cmd.ExecuteReader();

            conn.Close();
        }

        #endregion
    }
}
