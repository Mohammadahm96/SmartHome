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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace RPSmartHome
{
    public partial class Dashboard : UserControl
    {
        
        public Dashboard()
        {
            InitializeComponent();
            timer1.Start();
            lbRoomNmae.Text = "Dashboard";
            if (flowLayoutPanel1.Controls.Count < 0)
            {
                button1.Visible = false;
            }
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            
            if(txtSearch.Text == "search room")
            {
                txtSearch.ForeColor = Color.Black;
                txtSearch.Text = "";
            }

           
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                txtSearch.ForeColor = Color.Gray;
                txtSearch.Text = "search room";
            }
        }


        int Top = 29;
        int Left = 18;
        int count = 0;
        
        private void createRoom()
        {
            Newroom newroom = new Newroom();
            newroom.ShowDialog();

            count++;
            for (int i = 0; i < count; i++)
            {
                

                // Create a new instance of your UserControl class
                UserControl userControl = new UserControl();
                userControl.Name = Newroom.roomName;
                userControl.Size = new Size(753, 481);

                // Add the UserControl to the "pnlRooms" Panel control
                pnlRooms.Controls.Add(userControl);

                // Add a Label to the UserControl
                Label label1 = new Label();
                label1.Location = new Point(297, 208);
                label1.Size = new Size(114, 23);
                label1.Text = Newroom.roomName;
                label1.Name = Newroom.roomName;
                label1.ForeColor = Color.White;
                userControl.Controls.Add(label1);


                //Panel

                FlowLayoutPanel parentPanel = this.flowLayoutPanel1;
                Panel newPanel = new Panel();
                newPanel.Location = new Point(Left, Top);
                newPanel.Size = new Size(117, 81);
                newPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(75)))), ((int)(((byte)(109)))));
                newPanel.Name = Newroom.roomName;
                parentPanel.Controls.Add(newPanel);

                //Label

                Label label = new Label();
                label.Location = new Point(8, 4);
                label.Size = new Size(114, 23);
                label.Text = Newroom.roomName;
                label.Name = Newroom.roomName;
                label.ForeColor = Color.White;
                label.Cursor = Cursors.Hand;
                label.Click += new EventHandler(label_Click);
                newPanel.Controls.Add(label);

                // On and Off 

                PictureBox pictureBox = new PictureBox();
                pictureBox.Location = new Point(30, 35);
                pictureBox.Size = new Size(50, 44);
                pictureBox.Name = "pBroomOff";
                pictureBox.Image = imageList1.Images[0];
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Click += new EventHandler(pictureBoxOn_Click);
                pictureBox.Cursor = Cursors.Hand;
                newPanel.Controls.Add(pictureBox);

                PictureBox pictureBox1 = new PictureBox();
                pictureBox1.Location = new Point(30, 35);
                pictureBox1.Size = new Size(50, 44);
                pictureBox1.Name = "pBroomOn";
                pictureBox1.Image = imageList1.Images[1];
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.Click += new EventHandler(pictureBoxOff_Click);
                pictureBox1.Cursor = Cursors.Hand;
                newPanel.Controls.Add(pictureBox1);
                Left += 120;
                count--;
            }
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            
            createRoom();
        }

        private void pictureBoxOn_Click(object sender, EventArgs e)
        {
            // Get the clicked PictureBox control
            PictureBox clickedPictureBox = (PictureBox)sender;

            // Hide the clicked PictureBox control
            clickedPictureBox.SendToBack();
        }
        private void pictureBoxOff_Click(object sender, EventArgs e)
        {
            // Get the clicked PictureBox control
            PictureBox clickedPictureBox = (PictureBox)sender;

            // Hide the clicked PictureBox control
            clickedPictureBox.SendToBack();

        }


        private void label_Click(object sender, EventArgs e)
        {
            Label clickedLabel = (Label)sender;
            string labelName = clickedLabel.Name;

            // Create a new instance of your UserControl class
            UserControl userControl = new UserControl();
            userControl.Name = labelName; // Set any necessary properties of the control here

            // Set the UserControl as the content of the pnlRooms panel
            userControl.Dock = DockStyle.Fill;
            pnlRooms.Controls.Clear();
            pnlRooms.Controls.Add(userControl);
            userControl.BringToFront();
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
            if (flowLayoutPanel1.Controls.Count < 0)
            {
                button1.Visible = true;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.ToLower();

            foreach (Panel panel in flowLayoutPanel1.Controls.OfType<Panel>())
            {
                if (panel.Name.ToLower().Contains(searchText))
                {
                    panel.Visible = true;
                }
                else
                {
                    panel.Visible = false;
                }
            }
        }
    }
}
