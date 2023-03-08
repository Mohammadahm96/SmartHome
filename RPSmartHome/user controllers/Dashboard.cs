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
using Button = System.Windows.Forms.Button;

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
            NewroomOrDevice newRoomDetails = new NewroomOrDevice();
            newRoomDetails.ShowDialog();


            count++;
            for (int i = 0; i < count; i++)
            {




                //Panel

                FlowLayoutPanel parentPanel = this.flowLayoutPanel1;
                Panel newPanel = new Panel();
                newPanel.Location = new Point(Left, Top);
                newPanel.Size = new Size(117, 81);
                newPanel.BackColor = Color.FromArgb(60, 75, 109);
                newPanel.Name = NewroomOrDevice.roomName;
                parentPanel.Controls.Add(newPanel);


                //Label

                Label label = new Label();
                label.Location = new Point(8, 4);
                label.Size = new Size(114, 23);
                label.Text = NewroomOrDevice.roomName;
                label.Name = NewroomOrDevice.roomName;
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
            NewroomOrDevice newroomOrDevice = new NewroomOrDevice();
            NewroomOrDevice.roomORDevice = "New Room";
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
        public class RoomForm : Form
        {
            private string roomName;

            public RoomForm(string roomName)
            {
                this.roomName = roomName;
                this.Size = new Size(600, 450);
                this.MinimizeBox= false;
                this.MaximizeBox= false;
                this.StartPosition = FormStartPosition.CenterScreen;

            }
        }

        private void label_Click(object sender, EventArgs e)
        {
            Label clickedLabel = (Label)sender;

            // Get the name of the room associated with the label
            string roomName = clickedLabel.Name;

            // Create a new instance of RoomForm
            RoomForm roomForm = new RoomForm(roomName);
            roomForm.BackColor= Color.White;

            // Create a new instance of FlowLayoutPanel
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
            btnAddDevice.Size = new Size(150, 51);
            btnAddDevice.TabIndex = 1;
            btnAddDevice.Text = "+ Device";
            btnAddDevice.BringToFront();
            btnAddDevice.Click += new EventHandler(btnAddDevice_Click);
            roomForm.Controls.Add(btnAddDevice);

            //Delete device button

            Button btnDeleteDevice = new Button();

            btnDeleteDevice.BackColor = Color.FromArgb(122,0 , 0);
            btnDeleteDevice.Font = new Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnDeleteDevice.Cursor = Cursors.Hand;
            btnDeleteDevice.ForeColor = Color.White;
            btnDeleteDevice.Location = new Point(420, 60);
            btnDeleteDevice.Name = "btnDeleteDevice";
            btnDeleteDevice.Size = new Size(150, 51);
            btnDeleteDevice.TabIndex = 2;
            btnDeleteDevice.Text = "Delete";
            btnDeleteDevice.BringToFront();
            btnDeleteDevice.Click += new EventHandler(btnDeleteDevice_Click);
            roomForm.Controls.Add(btnDeleteDevice);

            Button btnCancel = new Button();

            btnCancel.BackColor = Color.FromArgb(122, 0, 0);
            btnCancel.Font = new Font("Times New Roman", 16F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(420, 60);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(150, 51);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Cancel";
            btnCancel.Click += new EventHandler(btnCancel_Click);
            roomForm.Controls.Add(btnCancel);

            //Label

            Label label = new Label();
            label.Location = new Point(200,0);
            label.Size = new Size(212, 46);
            label.Text = NewroomOrDevice.roomName;
            label.Name = NewroomOrDevice.roomName;
            label.Font = new Font("Times New Roman", 30F, FontStyle.Regular, GraphicsUnit.Point, (0));
            label.ForeColor = Color.Black;
            label.Cursor = Cursors.Hand;
            roomForm.Controls.Add(label);

            // Show the new form
            roomForm.ShowDialog();


        }

        private FlowLayoutPanel _flowLayoutPanel;

        int Top1 = 100;
        int Left1 = 50;
        int count1 = 0;

        private void btnAddDevice_Click(object sender, EventArgs e)
        {
            NewroomOrDevice newroomOrDevice = new NewroomOrDevice();
            NewroomOrDevice.roomORDevice = "New Device";
            newroomOrDevice.ShowDialog();

            count1++;
            for (int i = 0; i < count1; i++)
            {
                RoomForm roomForm = (RoomForm)((Button)sender).FindForm();
                               
               
                //FlowLayoutPanel

                
                Panel newPanel = new Panel();
                newPanel.Location = new Point(Left1, Top1);
                newPanel.Size = new Size(120, 100);
                newPanel.BackColor = Color.FromArgb(60, 75, 109);
                newPanel.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, (0));
                newPanel.Name = NewroomOrDevice.roomName;
                _flowLayoutPanel.Controls.Add(newPanel);


                //Label

                Label label = new Label();
                label.Location = new Point(8, 4);
                label.Size = new Size(114, 23);
                label.Text = NewroomOrDevice.roomName;
                label.Name = NewroomOrDevice.roomName;
                label.ForeColor = Color.White;
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
                Left1 += 120;
                count1--;

            }

            
        }

        private bool deleteDevice = false;

        private void btnDeleteDevice_Click(object sender, EventArgs e)
        {
            deleteDevice = true;
            //RoomForm roomForm = (RoomForm)((Button)sender).FindForm();

            Button clickedButton = sender as Button;
            clickedButton.SendToBack();

            //Cancel delete device button

            


            foreach (Control ctrl in _flowLayoutPanel.Controls)
            {
                if (ctrl is Panel panel)
                {
                    // Add the MouseEnter event handler to the panel
                    panel.BackColor = Color.FromArgb(122, 0, 0);
                    panel.Click += Panel_Click;

               
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            deleteDevice = false;

            Button clickedButton = sender as Button;
            clickedButton.SendToBack();
            foreach (Control ctrl in _flowLayoutPanel.Controls)
            {
                if (ctrl is Panel panel)
                {
                    // Add the MouseEnter event handler to the panel
                    panel.BackColor = Color.FromArgb(60, 75, 109);


                }
            }
        }

        private void Panel_Click(object sender, EventArgs e)
        {
            if (deleteDevice)
            {
                // Remove the panel from the flowLayoutPanel
                MessageBox.Show("Are sure to delete this Device?");
                Panel newPanel = (Panel)sender;
                _flowLayoutPanel.Controls.Remove(newPanel);
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
