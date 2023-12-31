﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace RPSmartHome.forms
{
    public partial class NewroomOrDevice : Form
    {
        public static string roomName { get; set; }
        public static string roomOrDevice { get; set; }
        public static string deviceName { get; set; }
        public NewroomOrDevice()
        {
            InitializeComponent();

            if (roomOrDevice == "New Room")
            {
                if (txtRoomName.Text == "")
                {
                    txtRoomName.Text = "room name";
                    txtRoomName.ForeColor = Color.Gray;
                    lbRoomName.Text = "";
                }
            }
            else if (roomOrDevice == "New Device")
            {
                if (txtRoomName.Text == "")
                {
                    txtRoomName.Text = "device name";
                    txtRoomName.ForeColor = Color.Gray;
                    lbRoomName.Text = "";
                }

            }


        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            Loading loading = new Loading();
            
            if(txtRoomName.Text == "room name")
            {
                error.SetError(txtRoomName, "Room name is required");
            }
            else
            {
                dbHelper dbHelper = new dbHelper();
                if (roomOrDevice == "New Room")
                {
                    roomName = txtRoomName.Text;
                    dbHelper.checkDuplicateRoom();

                    if (dbHelper.DuplicateRoom > 0)
                    {
                        error.SetError(txtRoomName, "Record already exists.");
                        return;
                    }
                    else
                    {
                        dbHelper.newRoom();
                        loading.Show();
                        this.Close();
                    }
                    
                }
                else if (roomOrDevice == "New Device")
                {
                    
                    deviceName = txtRoomName.Text;
                    dbHelper.newDevice();
                    this.Close();
                }
            }

            
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            deviceName = "";
            this.Close();
            
        }

        private void txtRoomName_Leave(object sender, EventArgs e)
        {
            if (roomOrDevice == "New Room")
            {
                if (txtRoomName.Text == "")
                {
                    txtRoomName.Text = "room name";
                    txtRoomName.ForeColor = Color.Gray;
                    lbRoomName.Text = "";
                }
            }
            else if (roomOrDevice == "New Device")
            {
                if (txtRoomName.Text == "")
                {
                    txtRoomName.Text = "device name";
                    txtRoomName.ForeColor = Color.Gray;
                    lbRoomName.Text = "";
                }

            }

            
        }

        private void txtRoomName_Click(object sender, EventArgs e)
        {
            if (roomOrDevice == "New Room")
            {
                if (txtRoomName.Text == "room name")
                {
                    txtRoomName.Text = "";
                    txtRoomName.ForeColor = Color.Black;
                    lbRoomName.Text = "room name";
                }
            }
            else if (roomOrDevice == "New Device")
            {
                if (txtRoomName.Text == "device name")
                {
                    txtRoomName.Text = "";
                    txtRoomName.ForeColor = Color.Black;
                    lbRoomName.Text = "device name";
                }

            }


            
        }

        private void txtRoomName_TextChanged(object sender, EventArgs e)
        {
            if (roomOrDevice == "New Room")
            {
                lbRoomName.Text = "room name";
                txtRoomName.ForeColor = Color.Black;
            }
            else if (roomOrDevice == "New Device")
            {
                lbRoomName.Text = "device name";
                txtRoomName.ForeColor = Color.Black;


            }

            
        }

        private void NewroomOrDevice_Load(object sender, EventArgs e)
        {
            lbRoomDevice.Text = roomOrDevice;
            if (roomOrDevice == "New Room")
            {
                if (txtRoomName.Text == "")
                {
                    txtRoomName.Text = "room name";
                    txtRoomName.ForeColor = Color.Gray;
                    lbRoomName.Text = "";
                }
            }
            else if (roomOrDevice == "New Device")
            {
                if (txtRoomName.Text == "room name")
                {
                    txtRoomName.Text = "device name";
                    txtRoomName.ForeColor = Color.Gray;
                    lbRoomName.Text = "";
                }

            }
        }

        private void txtRoomName_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtRoomName_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnAddRoom_Click(sender, e);
            }
        }
    }
}
