using RPSmartHome.forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static RPSmartHome.Dashboard;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using static Mysqlx.Datatypes.Scalar.Types;
using Button = System.Windows.Forms.Button;
using Mysqlx.Crud;
using System.Drawing.Drawing2D;

namespace RPSmartHome
{
    public partial class Dashboard : UserControl
    {
        public static string deviceName { get; set; }
        public static string devicesStatus { get; set; }
        public static string roomName { get; set; }
        public static string deleteRoomORDevice { get; set; }
        public static string roomStatus { get; set; }
        public static string NewroomName { get; set; }
        public Dashboard()
        {
            InitializeComponent();
            timer1.Start();
            if (flowLayoutPanel1.Controls.Count < 0)
            {
                button1.Visible = false;
            }

        }

        int Top2 = 29;
        int Left2 = 18;
        int count2 = 0;

        private void Dashboard_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.Parent = pBHome;
            flowLayoutPanel1.BackColor = Color.Transparent;

            dbHelper dbHelper  = new dbHelper();
            dbHelper.GetRooms();

            List<string> rooms = dbHelper.GetRooms();

            if (rooms.Count == 0)
            {

            }
            else
            {
                foreach (string room in rooms)
                {
                    count2++;
                    for (int i = 0; i < count2; i++)
                    {
                        //Delete device button

                        Button btnDeleteDevice = new Button();

                        btnDeleteDevice.BackColor = Color.FromArgb(122, 0, 0);
                        btnDeleteDevice.Font = new Font("Times New Roman", 14F,FontStyle.Regular,GraphicsUnit.Point, 0);
                        btnDeleteDevice.Cursor = Cursors.Hand;
                        btnDeleteDevice.ForeColor = Color.White;
                        btnDeleteDevice.Location = new Point(779, 78);
                        btnDeleteDevice.FlatStyle= FlatStyle.Flat;
                        btnDeleteDevice.Name = "btnDeleteRoom";
                        btnDeleteDevice.Size = new Size(263, 51);
                        btnDeleteDevice.TabIndex = 2;
                        btnDeleteDevice.Text = "Delete room";
                        btnDeleteDevice.BringToFront();
                        btnDeleteDevice.Click += new EventHandler(btnDeleteRoom_Click);
                        this.Controls.Add(btnDeleteDevice);

                        Button btnCancel = new Button();

                        btnCancel.BackColor = Color.FromArgb(122, 0, 0);
                        btnCancel.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
                        btnCancel.Cursor = Cursors.Hand;
                        btnCancel.ForeColor = Color.White;
                        btnCancel.Location = new Point(779, 78);
                        btnCancel.Name = "btnCancelRoom";
                        btnCancel.FlatStyle= FlatStyle.Flat;
                        btnCancel.Size = new Size(263, 51);
                        btnCancel.TabIndex = 2;
                        btnCancel.Text = "Cancel";
                        btnCancel.Click += new EventHandler(btnCancelRoom_Click);
                        this.Controls.Add(btnCancel);




                        roomName = room;

                        //Panel
                        FlowLayoutPanel parentPanel = this.flowLayoutPanel1;
                        CustomPanel newPanel = new CustomPanel();
                        newPanel.Location = new Point(Left2, Top2);
                        newPanel.Size = new Size(200, 144);
                        newPanel.Name = roomName;
                        parentPanel.Controls.Add(newPanel);


                        //Label

                        Label label = new Label();
                        label.Location = new Point(40, 4);
                        label.Size = new Size(140, 30);
                        label.Text = room;
                        label.Name = room;
                        label.Font = new Font("Times New Roman", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
                        label.ForeColor = Color.White;
                        label.Cursor = Cursors.Hand;
                        label.Click += new EventHandler(label_Click);
                        newPanel.Controls.Add(label);

                        Label label1 = new Label();
                        label1.Location = new Point(20, 70);
                        label1.Size = new Size(60, 30);
                        label1.Name = "ONorOFF " + room;
                        label1.Font = new Font("Times New Roman", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
                        label1.ForeColor = Color.White;
                        label1.Cursor = Cursors.Hand;
                        label1.Click += new EventHandler(label_Click);
                        newPanel.Controls.Add(label1);



                        // On and Off 

                        PictureBox pictureBox = new PictureBox();
                        pictureBox.Location = new Point(100, 55);
                        pictureBox.Size = new Size(60, 54);
                        pictureBox.Name = room + " Room";
                        pictureBox.Image = imageList1.Images[0];
                        pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBox.Click += new EventHandler(pictureBoxOn_Click);
                        pictureBox.Cursor = Cursors.Hand;
                        newPanel.Controls.Add(pictureBox);

                        PictureBox pictureBox1 = new PictureBox();
                        pictureBox1.Location = new Point(100, 55);
                        pictureBox1.Size = new Size(60, 54);
                        pictureBox1.Name = room + " Room";
                        pictureBox1.Image = imageList1.Images[1];
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBox1.Click += new EventHandler(pictureBoxOff_Click);
                        pictureBox1.Cursor = Cursors.Hand;
                        newPanel.Controls.Add(pictureBox1);

                        dbHelper.GetRoomStatus();


                        List<string> roomsStatus = dbHelper.GetRoomStatus();


                        foreach (string roomStatus in roomsStatus)
                        {
                            int Top1 = 100;
                            int Left1 = 50;
                            int count1 = 0;
                            count1++;
                            for (int j = 0; j < count1; j++)
                            {
                                string Status = roomStatus;
                                if (Status == "ON")
                                {
                                    pictureBox1.BringToFront();
                                    label1.Text = Status;

                                    newPanel.BackColor = Color.FromArgb(0, 150, 80);
                                }
                                else if (Status == "OFF")
                                {
                                    pictureBox.BringToFront();
                                    label1.Text = Status;

                                    newPanel.BackColor = Color.FromArgb(60, 75, 109);
                                }
                                count1--;
                            }
                        }

                        Left2 += 120;
                        count2--;


                    }
                }
            }
            

        }

        

        int Top = 29;
        int Left = 18;
        int count = 0;
        
        public void createRoom()
        {
            NewroomOrDevice newRoomDetails = new NewroomOrDevice();
            NewroomOrDevice.roomOrDevice = "New Room";
            newRoomDetails.ShowDialog();

            if (NewroomOrDevice.roomName != "") 
            {
                count++;
                for (int i = 0; i < count; i++)
                {

                    //Panel

                    FlowLayoutPanel parentPanel = this.flowLayoutPanel1;
                    CustomPanel newPanel = new CustomPanel();
                    newPanel.Location = new Point(Left, Top);
                    newPanel.Size = new Size(200, 144);
                    newPanel.BackColor = Color.FromArgb(60, 75, 109);
                    newPanel.Name = NewroomOrDevice.roomName;
                    parentPanel.Controls.Add(newPanel);


                    //Label

                    Label label = new Label();
                    label.Location = new Point(40, 4);
                    label.Size = new Size(140, 30);
                    label.Text = NewroomOrDevice.roomName;
                    label.Name = "ONorOFF " + NewroomOrDevice.roomName;
                    label.ForeColor = Color.White;
                    label.Cursor = Cursors.Hand;
                    label.Font = new Font("Times New Roman", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
                    label.Click += new EventHandler(label_Click);
                    newPanel.Controls.Add(label);

                    // On and Off 

                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Location = new Point(100, 55);
                    pictureBox.Size = new Size(60, 54);
                    pictureBox.Name = NewroomOrDevice.roomName + " Room";
                    pictureBox.Image = imageList1.Images[0];
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox.Click += new EventHandler(pictureBoxOn_Click);
                    pictureBox.Cursor = Cursors.Hand;
                    newPanel.Controls.Add(pictureBox);

                    PictureBox pictureBox1 = new PictureBox();
                    pictureBox1.Location = new Point(100, 55);
                    pictureBox1.Size = new Size(60, 54);
                    pictureBox1.Name = NewroomOrDevice.roomName + " Room";
                    pictureBox1.Image = imageList1.Images[1];
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox1.Click += new EventHandler(pictureBoxOff_Click);
                    pictureBox1.Cursor = Cursors.Hand;
                    newPanel.Controls.Add(pictureBox1);
                    Left += 120;
                    count--;


                }
            }

            
        }
        
        private async void btnAddRoom_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(dbHelper.personName))
            {
                LoginRegs loginRegs = new LoginRegs();
                loginRegs.ShowDialog();
                if (!string.IsNullOrEmpty(dbHelper.personName))
                {
                    createRoom();

                }
                else
                {

                }

            }
            else
            {
                createRoom();

            }
            
        }

        private bool deleteRoom = false;

        private void btnDeleteRoom_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(dbHelper.personName))
            {
                LoginRegs loginRegs = new LoginRegs();
                loginRegs.ShowDialog();
                if (!string.IsNullOrEmpty(dbHelper.personName))
                {
                    deleteRoom = true;
                    Button clickedButton = sender as Button;
                    clickedButton.SendToBack();
                    NewroomOrDevice.roomOrDevice = "Room";

                    foreach (Control ctrl in flowLayoutPanel1.Controls)
                    {
                        if (ctrl is Panel panel)
                        {
                            // Add the MouseEnter event handler to the panel
                            panel.BackColor = Color.FromArgb(122, 0, 0);
                            panel.Click += Panel_Click;



                        }
                    }

                }
                else
                {

                }

            }
            else
            {
             deleteRoom = true;
            Button clickedButton = sender as Button;
            clickedButton.SendToBack();
            NewroomOrDevice.roomOrDevice = "Room";

            foreach (Control ctrl in flowLayoutPanel1.Controls)
            {
                if (ctrl is Panel panel)
                {
                    // Add the MouseEnter event handler to the panel
                    panel.BackColor = Color.FromArgb(122, 0, 0);
                    panel.Click += Panel_Click;



                }
            }

            }

            

        }

        private void btnCancelRoom_Click(object sender, EventArgs e)
        {
            deleteRoom = false;
            Button clickedButton = sender as Button;
            clickedButton.SendToBack();

            foreach (Control ctrl in flowLayoutPanel1.Controls)
            {
                if (ctrl is Panel panel)
                {
                    // Add the MouseEnter event handler to the panel
                    panel.BackColor = Color.FromArgb(60, 75, 109);


                }
            }
        }

        private void pictureBoxOn_Click(object sender, EventArgs e)
        {
            // Get the clicked PictureBox control
            PictureBox clickedPictureBox = (PictureBox)sender;

            

            // Hide the clicked PictureBox control
            clickedPictureBox.SendToBack();


            

            //If all room or a device turns on

            string[] words = clickedPictureBox.Name.Split(' ');

            if (words.Length == 2 && (words[1].Contains("Room")))
            {

                roomStatus = "ON";
                roomName = words[0];


                Label label = (Label)this.Controls.Find("ONorOFF " + roomName, true)[0];
                label.Text = "ON";


                Panel panel = (Panel)this.Controls.Find(roomName, true)[0];

                panel.BackColor = Color.FromArgb(0, 150, 80);

                dbHelper dbHelper = new dbHelper();

                dbHelper.getRoomId();

                dbHelper.setRoomStatus();
            }
            else if (words.Length == 2 && (words[1].Contains("Device")))
            {
                devicesStatus = "ON";
                deviceName = words[0];

                Label label2 = (Label)_flowLayoutPanel.Controls.Find("ONorOFF " + deviceName, true)[0];
                label2.Text = "ON";


                Panel panel = (Panel)_flowLayoutPanel.Controls.Find(deviceName, true)[0];

                panel.BackColor = Color.FromArgb(0, 150, 80);


                dbHelper dbHelper = new dbHelper();
                dbHelper.setDeviceStatus();

            }
        }
        private void pictureBoxOff_Click(object sender, EventArgs e)
        {

            dbHelper dbHelper = new dbHelper();

            // Get the clicked PictureBox control
            PictureBox clickedPictureBox = (PictureBox)sender;

            // Hide the clicked PictureBox control
            clickedPictureBox.SendToBack();


            

            //If all room or a device turns off
            string[] words = clickedPictureBox.Name.Split(' ');

            if (words.Length == 2 && (words[1].Contains("Room")))
            {
                roomStatus = "OFF";
                roomName = words[0];

                roomName = words[0];


                Label label = (Label)this.Controls.Find("ONorOFF " + roomName, true)[0];
                label.Text = "OFF";


                Panel panel = (Panel)this.Controls.Find(roomName, true)[0];

                panel.BackColor = Color.FromArgb(60, 75, 109);


                dbHelper.getRoomId();
                dbHelper.setRoomStatus();
            }
            else if (words.Length == 2 && (words[1].Contains("Device")))
            {
                devicesStatus = "OFF";
                deviceName = words[0];

                Label label2 = (Label)_flowLayoutPanel.Controls.Find("ONorOFF " + deviceName, true)[0];
                label2.Text = "OFF";


                Panel panel = (Panel)_flowLayoutPanel.Controls.Find(deviceName, true)[0];

                panel.BackColor = Color.FromArgb(60, 75, 109);



                dbHelper.setDeviceStatus();
            }
        }
        public class Room : Form
        {
            Home Home = new Home();
            private string roomName;

            public Room(string roomName)
            {
                this.roomName = roomName;
                this.Size = new Size(600, 450);
                this.MinimizeBox= false;
                this.MaximizeBox= false;
                this.MaximumSize = new Size(600, 450);
                this.MinimumSize = new Size(600, 450);
                this.StartPosition = FormStartPosition.CenterScreen;

            }

        }
        public class deleteDeviceOrRoom : Form
        {
            Home Home = new Home();
            private string Delete;

            public deleteDeviceOrRoom(string Delete)
            {
                this.Delete = Delete;
                this.Size = new Size(400, 250);
                this.MinimizeBox= false;
                this.MaximizeBox= false;
                this.MaximumSize = new Size(400, 250);
                this.MinimumSize = new Size(400, 250);
                this.StartPosition = FormStartPosition.CenterScreen;

            }

        }

        private void label_Click(object sender, EventArgs e)
        {
            Label clickedLabel = (Label)sender;
            NewroomName = clickedLabel.Name;
            roomName = NewroomName;
            NewroomOrDevice.roomOrDevice = "New Device";

            // Create a new RoomForm
            Room roomForm = new Room(roomName);
            roomForm.BackColor= Color.White;

            // Create a new FlowLayoutPanel
            _flowLayoutPanel = new FlowLayoutPanel();

            //Panel
            _flowLayoutPanel.Location = new Point(30, 120);
            _flowLayoutPanel.Size = new Size(530, 250);
            _flowLayoutPanel.BackColor= Color.White;
            _flowLayoutPanel.AutoScroll= true;
            roomForm.Controls.Add(_flowLayoutPanel);


            //Add device button

            Button btnAddDevice = new Button();

            btnAddDevice.BackColor = Color.FromArgb(0, 175, 128);
            btnAddDevice.Font = new Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnAddDevice.Cursor = Cursors.Hand;
            btnAddDevice.ForeColor = Color.White;
            btnAddDevice.Location = new Point(420, 10);
            btnAddDevice.Name = "btnAddDevice";
            btnAddDevice.FlatStyle = FlatStyle.Flat;
            btnAddDevice.Size = new Size(150, 51);
            btnAddDevice.TabIndex = 1;
            btnAddDevice.Text = "+ Device";
            btnAddDevice.BringToFront();
            btnAddDevice.Click += new EventHandler(btnAddDevice_Click);
            roomForm.Controls.Add(btnAddDevice);

            

            //Label

            Label label = new Label();
            label.Location = new Point(200,0);
            label.Size = new Size(212, 46);
            label.Text = roomName;
            label.Name = roomName;
            label.Font = new Font("Times New Roman", 30F, FontStyle.Regular, GraphicsUnit.Point, (0));
            label.ForeColor = Color.Black;
            label.Cursor = Cursors.Hand;
            roomForm.Controls.Add(label);




            dbHelper dbHelper = new dbHelper();

            dbHelper.getRoomId();
            dbHelper.GetDevices();


            List<string> devices = dbHelper.GetDevices();
            if (devices.Count == 0)
            {
            }
            else
            {

                foreach (string device in devices)
                {
                    int Top = 100;
                    int Left = 50;
                    int count = 0;
                    count++;
                    for (int i = 0; i < count; i++)
                    {
                        deviceName = device;
                        //FlowLayoutPanel

                        CustomPanel newPanel = new CustomPanel();
                        newPanel.Location = new Point(Left1, Top1);
                        newPanel.Size = new Size(150, 130);
                        newPanel.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, (0));
                        newPanel.Name = device;
                        newPanel.Cursor= Cursors.Hand;
                        newPanel.Click += new EventHandler(Panel_Click);
                        _flowLayoutPanel.Controls.Add(newPanel);


                        //Label

                        Label label1 = new Label();
                        label1.Location = new Point(30, 4);
                        label1.Size = new Size(114, 30);
                        label1.Text = device;
                        label1.Name = device;
                        label1.ForeColor = Color.White;
                        label1.Cursor = Cursors.Hand;
                        newPanel.Controls.Add(label1);

                        Label label2 = new Label();
                        label2.Location = new Point(15, 65);
                        label2.Size = new Size(50, 30);
                        label2.Name = "ONorOFF " + device;
                        label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
                        label2.ForeColor = Color.White;
                        label2.Cursor = Cursors.Hand;
                        newPanel.Controls.Add(label2);


                        // On and Off 

                        PictureBox pictureBox = new PictureBox();
                        pictureBox.Location = new Point(80, 55);
                        pictureBox.Size = new Size(50, 44);
                        pictureBox.Name = device + " Device";
                        pictureBox.Image = imageList1.Images[0];
                        pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBox.Click += new EventHandler(pictureBoxOn_Click);
                        pictureBox.Cursor = Cursors.Hand;
                        newPanel.Controls.Add(pictureBox);

                        PictureBox pictureBox1 = new PictureBox();
                        pictureBox1.Location = new Point(80, 55);
                        pictureBox1.Size = new Size(50, 44);
                        pictureBox1.Name = device + " Device";
                        pictureBox1.Image = imageList1.Images[1];
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBox1.Click += new EventHandler(pictureBoxOff_Click);
                        pictureBox1.Cursor = Cursors.Hand;
                        newPanel.Controls.Add(pictureBox1);

                        dbHelper.GetDevicesStatus();


                        List<string> devicesStatus = dbHelper.GetDevicesStatus();

                        
                        
                        foreach (string deviceStatus in devicesStatus)
                        {
                            int Top1 = 100;
                            int Left1 = 50;
                            int count1 = 0;
                            count1++;
                            for (int j = 0; j < count1; j++)
                            {
                                string Status = deviceStatus;
                                if (Status == "ON")
                                {
                                    pictureBox1.BringToFront();
                                    label2.Text = Status;
                                    newPanel.BackColor = Color.FromArgb(0, 150, 80);
                                }
                                else if (Status == "OFF")
                                {
                                    pictureBox.BringToFront();
                                    label2.Text = Status;
                                    newPanel.BackColor = Color.FromArgb(60, 75, 109);
                                }
                                count1--;
                            }
                        }

                        Left += 120;
                        count--;

                    }

                }
            }

            roomForm.ShowDialog();
        }
        

        private FlowLayoutPanel _flowLayoutPanel;

        int Top1 = 100;
        int Left1 = 50;
        int count1 = 0;

        private void btnAddDevice_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(dbHelper.personName))
            {
                LoginRegs loginRegs = new LoginRegs();
                loginRegs.ShowDialog();
                if (!string.IsNullOrEmpty(dbHelper.personName))
                {
                    NewroomOrDevice newroomOrDevice = new NewroomOrDevice();
                    newroomOrDevice.ShowDialog();

                    if (string.IsNullOrEmpty(NewroomOrDevice.deviceName))
                    {
                        MessageBox.Show("No device was added in this room");
                    }
                    else
                    {
                        count1++;
                        for (int i = 0; i < count1; i++)
                        {


                            //FlowLayoutPanel

                            CustomPanel newPanel = new CustomPanel();
                            newPanel.Location = new Point(Left1, Top1);
                            newPanel.Size = new Size(150, 130);
                            newPanel.BackColor = Color.FromArgb(60, 75, 109);
                            newPanel.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, (0));
                            newPanel.Name = NewroomOrDevice.deviceName;
                            newPanel.Cursor = Cursors.Hand;
                            newPanel.Click += new EventHandler(Panel_Click);
                            _flowLayoutPanel.Controls.Add(newPanel);


                            //Label
                            Label label = new Label();
                            label.Location = new Point(30, 4);
                            label.Size = new Size(114, 30);
                            label.Text = NewroomOrDevice.deviceName;
                            label.Name = NewroomOrDevice.deviceName;
                            label.ForeColor = Color.White;
                            newPanel.Controls.Add(label);


                            Label label2 = new Label();
                            label2.Location = new Point(15, 65);
                            label2.Size = new Size(50, 30);
                            label2.Name = "ONorOFF " + NewroomOrDevice.deviceName;
                            label2.Text = "OFF";
                            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
                            label2.ForeColor = Color.White;
                            label2.Cursor = Cursors.Hand;
                            newPanel.Controls.Add(label2);



                            // On and Off 

                            PictureBox pictureBox = new PictureBox();
                            pictureBox.Location = new Point(80, 55);
                            pictureBox.Size = new Size(50, 44);
                            pictureBox.Name = NewroomOrDevice.deviceName + " Device";
                            pictureBox.Image = imageList1.Images[0];
                            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                            pictureBox.Click += new EventHandler(pictureBoxOn_Click);
                            pictureBox.Cursor = Cursors.Hand;
                            newPanel.Controls.Add(pictureBox);

                            PictureBox pictureBox1 = new PictureBox();
                            pictureBox1.Location = new Point(80, 55);
                            pictureBox1.Size = new Size(50, 44);
                            pictureBox1.Name = NewroomOrDevice.deviceName + " Device";
                            pictureBox1.Image = imageList1.Images[1];
                            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                            pictureBox1.Click += new EventHandler(pictureBoxOff_Click);
                            pictureBox1.Cursor = Cursors.Hand;
                            newPanel.Controls.Add(pictureBox1);
                            Left1 += 120;
                            count1--;

                        }

                    }

                }

            }
            else
            {
                NewroomOrDevice newroomOrDevice = new NewroomOrDevice();
                newroomOrDevice.ShowDialog();

                if (string.IsNullOrEmpty(NewroomOrDevice.deviceName))
                {
                    MessageBox.Show("No device was added in this room");
                }
                else
                {
                    count1++;
                    for (int i = 0; i < count1; i++)
                    {


                        //FlowLayoutPanel


                        CustomPanel newPanel = new CustomPanel();
                        newPanel.Location = new Point(Left1, Top1);
                        newPanel.Size = new Size(150, 130);
                        newPanel.BackColor = Color.FromArgb(60, 75, 109);
                        newPanel.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, (0));
                        newPanel.Name = NewroomOrDevice.deviceName;
                        newPanel.Cursor = Cursors.Hand;
                        newPanel.Click += new EventHandler(Panel_Click);
                        _flowLayoutPanel.Controls.Add(newPanel);


                        //Label

                        Label label = new Label();
                        label.Location = new Point(30, 4);
                        label.Size = new Size(114, 30);
                        label.Text = NewroomOrDevice.deviceName;
                        label.Name = NewroomOrDevice.deviceName;
                        label.ForeColor = Color.White;
                        newPanel.Controls.Add(label);


                        Label label2 = new Label();
                        label2.Location = new Point(15, 65);
                        label2.Size = new Size(50, 30);
                        label2.Name = "ONorOFF " + NewroomOrDevice.deviceName;
                        label2.Text = "OFF";
                        label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
                        label2.ForeColor = Color.White;
                        label2.Cursor = Cursors.Hand;
                        newPanel.Controls.Add(label2);



                        // On and Off 

                        PictureBox pictureBox = new PictureBox();
                        pictureBox.Location = new Point(80, 55);
                        pictureBox.Size = new Size(50, 44);
                        pictureBox.Name = NewroomOrDevice.deviceName + " Device";
                        pictureBox.Image = imageList1.Images[0];
                        pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBox.Click += new EventHandler(pictureBoxOn_Click);
                        pictureBox.Cursor = Cursors.Hand;
                        newPanel.Controls.Add(pictureBox);

                        PictureBox pictureBox1 = new PictureBox();
                        pictureBox1.Location = new Point(80, 55);
                        pictureBox1.Size = new Size(50, 44);
                        pictureBox1.Name = NewroomOrDevice.deviceName + " Device";
                        pictureBox1.Image = imageList1.Images[1];
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBox1.Click += new EventHandler(pictureBoxOff_Click);
                        pictureBox1.Cursor = Cursors.Hand;
                        newPanel.Controls.Add(pictureBox1);
                        Left1 += 120;
                        count1--;

                    }

                }

            }

            


        }

        private bool deleteDevice = false;

        private void btnDeleteDeviceORRoom_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(dbHelper.personName))
            {
                LoginRegs loginRegs = new LoginRegs();
                loginRegs.ShowDialog();

                dbHelper dbHelper = new dbHelper();
                deleteDevice = true;
                if (deleteRoom)
                {

                    dbHelper.deleteRoom();
                    Button clickedButton = sender as Button;
                    Form deleteDeviceOrRoomForm = clickedButton.Parent as Form;
                    deleteDeviceOrRoomForm.Close();

                }
                else if (deleteDevice)
                {
                    dbHelper.deleteDevice();

                    Button clickedButton = sender as Button;
                    Form deleteDeviceOrRoomForm = clickedButton.Parent as Form;
                    deleteDeviceOrRoomForm.Close();


                    MessageBox.Show($"The Device was deleted");

                    clickedPanel.Parent.Controls.Remove(clickedPanel);
                }

            }
            else
            {
                dbHelper dbHelper = new dbHelper();
                deleteDevice = true;
                if (deleteRoom)
                {

                    dbHelper.deleteRoom();
                    Button clickedButton = sender as Button;
                    Form deleteDeviceOrRoomForm = clickedButton.Parent as Form;
                    deleteDeviceOrRoomForm.Close();

                }
                else if (deleteDevice)
                {
                    dbHelper.deleteDevice();

                    Button clickedButton = sender as Button;
                    Form deleteDeviceOrRoomForm = clickedButton.Parent as Form;
                    deleteDeviceOrRoomForm.Close();


                    MessageBox.Show($"The Device was deleted");

                    clickedPanel.Parent.Controls.Remove(clickedPanel);
                }
            }
            

            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if(deleteRoom)
            {
                Button clickedButton = sender as Button;
                Form deleteDeviceOrRoomForm = clickedButton.Parent as Form;
                deleteDeviceOrRoomForm.Close();


                if (label2.Text == "ON")
                {
                    Panel panel = (Panel)_flowLayoutPanel.Controls.Find(deviceName, true)[0];

                    panel.BackColor = Color.FromArgb(0, 150, 80);
                }
                else if (label2.Text == "OFF")
                {

                    Panel panel = (Panel)_flowLayoutPanel.Controls.Find(deviceName, true)[0];

                    panel.BackColor = Color.FromArgb(60, 75, 109);

                }
            }
            else if (deleteDevice)
            {
                Button clickedButton = sender as Button;
                Form deleteDeviceOrRoomForm = clickedButton.Parent as Form;
                deleteDeviceOrRoomForm.Close();

                Label label2 = (Label)_flowLayoutPanel.Controls.Find("ONorOFF " + deviceName, true)[0];


                if (label2.Text == "ON")
                {
                    Panel panel = (Panel)_flowLayoutPanel.Controls.Find(deviceName, true)[0];

                    panel.BackColor = Color.FromArgb(0, 150, 80);
                }
                else if (label2.Text == "OFF")
                {

                    Panel panel = (Panel)_flowLayoutPanel.Controls.Find(deviceName, true)[0];

                    panel.BackColor = Color.FromArgb(60, 75, 109);

                }
            }
            
        }

        private Panel clickedPanel;
        private void Panel_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(dbHelper.personName))
            {
                LoginRegs loginRegs = new LoginRegs();
                loginRegs.ShowDialog();

                clickedPanel = sender as Panel;
                string Delete = clickedPanel.Name;

                deleteRoomORDevice = Delete;

                deleteDeviceOrRoom deviceOrRoom = new deleteDeviceOrRoom(Delete);
                clickedPanel.BackColor = Color.FromArgb(122, 0, 0);

                Label label = new Label();
                label.Location = new Point(60, 10);
                label.Size = new Size(212, 46);
                label.Text = "Device Name: " + deviceName;
                label.Name = deviceName;
                label.Font = new Font("Times New Roman", 20F, FontStyle.Regular, GraphicsUnit.Point, (0));
                label.ForeColor = Color.Black;
                deviceOrRoom.Controls.Add(label);
                //Label

                Label label1 = new Label();
                label1.Location = new Point(20, 70);
                label1.Size = new Size(350, 46);
                label1.Text = "Are you sure to delete this device?";
                label1.Name = deviceName;
                label1.Font = new Font("Times New Roman", 16F, FontStyle.Regular, GraphicsUnit.Point, (0));
                label1.ForeColor = Color.Black;
                deviceOrRoom.Controls.Add(label1);

                //Delete device button

                Button btnDeleteDevice = new Button();

                btnDeleteDevice.BackColor = Color.FromArgb(122, 0, 0);
                btnDeleteDevice.Font = new Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                btnDeleteDevice.Cursor = Cursors.Hand;
                btnDeleteDevice.ForeColor = Color.White;
                btnDeleteDevice.Location = new Point(20, 140);
                btnDeleteDevice.Name = "btnDeleteDevice";
                btnDeleteDevice.Size = new Size(150, 51);
                btnDeleteDevice.TabIndex = 2;
                btnDeleteDevice.FlatStyle= FlatStyle.Flat;
                btnDeleteDevice.Text = "Delete";
                btnDeleteDevice.BringToFront();
                btnDeleteDevice.Click += new EventHandler(btnDeleteDeviceORRoom_Click);
                deviceOrRoom.Controls.Add(btnDeleteDevice);

                Button btnCancel = new Button();

                btnCancel.BackColor = Color.FromArgb(122, 0, 0);
                btnCancel.Font = new Font("Times New Roman", 16F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                btnCancel.Cursor = Cursors.Hand;
                btnCancel.ForeColor = Color.White;
                btnCancel.Location = new Point(200, 140);
                btnCancel.Name = "btnCancel";
                btnCancel.Size = new Size(150, 51);
                btnCancel.TabIndex = 2;
                btnCancel.FlatStyle = FlatStyle.Flat;
                btnCancel.Text = "Cancel";
                btnCancel.Click += new EventHandler(btnCancel_Click);
                deviceOrRoom.Controls.Add(btnCancel);

                deviceOrRoom.Show();


            }
            else
            {
                

                clickedPanel = sender as Panel;
                string Delete = clickedPanel.Name;

                deleteRoomORDevice = Delete;

                deleteDeviceOrRoom deviceOrRoom = new deleteDeviceOrRoom(Delete);
                clickedPanel.BackColor = Color.FromArgb(122, 0, 0);

                Label label = new Label();
                label.Location = new Point(60, 10);
                label.Size = new Size(212, 46);
                label.Text = "Device Name: " + deviceName;
                label.Name = deviceName;
                label.Font = new Font("Times New Roman", 20F, FontStyle.Regular, GraphicsUnit.Point, (0));
                label.ForeColor = Color.Black;
                deviceOrRoom.Controls.Add(label);
                //Label

                Label label1 = new Label();
                label1.Location = new Point(20, 70);
                label1.Size = new Size(350, 46);
                label1.Text = "Are you sure to delete this device?";
                label1.Name = deviceName;
                label1.Font = new Font("Times New Roman", 16F, FontStyle.Regular, GraphicsUnit.Point, (0));
                label1.ForeColor = Color.Black;
                deviceOrRoom.Controls.Add(label1);

                //Delete device button

                Button btnDeleteDevice = new Button();

                btnDeleteDevice.BackColor = Color.FromArgb(122, 0, 0);
                btnDeleteDevice.Font = new Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                btnDeleteDevice.Cursor = Cursors.Hand;
                btnDeleteDevice.ForeColor = Color.White;
                btnDeleteDevice.Location = new Point(20, 140);
                btnDeleteDevice.Name = "btnDeleteDevice";
                btnDeleteDevice.Size = new Size(150, 51);
                btnDeleteDevice.TabIndex = 2;
                btnDeleteDevice.FlatStyle = FlatStyle.Flat;
                btnDeleteDevice.Text = "Delete";
                btnDeleteDevice.BringToFront();
                btnDeleteDevice.Click += new EventHandler(btnDeleteDeviceORRoom_Click);
                deviceOrRoom.Controls.Add(btnDeleteDevice);

                Button btnCancel = new Button();

                btnCancel.BackColor = Color.FromArgb(122, 0, 0);
                btnCancel.Font = new Font("Times New Roman", 16F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                btnCancel.Cursor = Cursors.Hand;
                btnCancel.ForeColor = Color.White;
                btnCancel.Location = new Point(200, 140);
                btnCancel.Name = "btnCancel";
                btnCancel.Size = new Size(150, 51);
                btnCancel.TabIndex = 2;
                btnCancel.FlatStyle = FlatStyle.Flat;
                btnCancel.Text = "Cancel";
                btnCancel.Click += new EventHandler(btnCancel_Click);
                deviceOrRoom.Controls.Add(btnCancel);

                deviceOrRoom.Show();

            }




        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbClockan.Text = DateTime.Now.ToString("HH:mm:ss");
            lbDay.Text = DateTime.Now.ToString("D");
        }

        private void flowLayoutPanel1_ControlAdded(object sender, ControlEventArgs e)
        {
            if (flowLayoutPanel1.Controls.Count > 0)
            {
                button1.Visible = false;
            }
        }

        private void flowLayoutPanel1_ControlRemoved(object sender, ControlEventArgs e)
        {
            if (flowLayoutPanel1.Controls.Count == 0)
            {
                button1.Visible = true;
            }
        }

        //all Panels corners change to this
        public class CustomPanel : Panel
        {
            private int cornerRadius = 20; 

            protected override void OnPaint(PaintEventArgs e)
            {
                base.OnPaint(e);

                GraphicsPath path = new GraphicsPath();
                path.AddArc(0, 0, cornerRadius * 2, cornerRadius * 2, 180, 90);
                path.AddArc(Width - cornerRadius * 2, 0, cornerRadius * 2, cornerRadius * 2, 270, 90);
                path.AddArc(Width - cornerRadius * 2, Height - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2, 0, 90);
                path.AddArc(0, Height - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2, 90, 90);
                path.CloseFigure();

                this.Region = new Region(path);

                using (SolidBrush brush = new SolidBrush(BackColor))
                {
                    e.Graphics.FillPath(brush, path);
                }
            }
        }
    }
}
