using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPSmartHome.forms
{
    public partial class NewroomOrDevice : Form
    {
        public static string roomName { get; set; }
        public static string roomORDevice { get; set; }
        public NewroomOrDevice()
        {
            InitializeComponent();
            
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            roomName= txtRoomName.Text;
            this.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtRoomName.Text = "";
            this.Hide();
        }

        private void txtRoomName_Leave(object sender, EventArgs e)
        {
            if (txtRoomName.Text == "")
            {
                txtRoomName.Text = "room name";
                txtRoomName.ForeColor = Color.Gray;
                lbRoomName.Text = "";
            }
        }

        private void txtRoomName_Click(object sender, EventArgs e)
        {
            if (txtRoomName.Text == "room name")
            {
                txtRoomName.Text = "";
                txtRoomName.ForeColor = Color.Black;
                lbRoomName.Text = "room name";
            }
        }

        private void txtRoomName_TextChanged(object sender, EventArgs e)
        {
            lbRoomName.Text = "room name";
            txtRoomName.ForeColor = Color.Black;
        }

        private void NewroomOrDevice_Load(object sender, EventArgs e)
        {
            lbRoomDevice.Text = roomORDevice;
        }
    }
}
