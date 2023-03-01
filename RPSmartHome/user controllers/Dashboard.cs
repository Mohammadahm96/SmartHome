using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

        private void pBoff_Click(object sender, EventArgs e)
        {
            pBon.BringToFront();
        }

        private void pBon_Click(object sender, EventArgs e)
        {
            pBoff.BringToFront();
        }

        private void pBoff1_Click(object sender, EventArgs e)
        {
            pBon1.BringToFront();
        }

        private void pBon1_Click(object sender, EventArgs e)
        {
            pBoff1.BringToFront();
        }

        int Width = 81;
        int Height = 117;
        int count = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            count ++;
            
            for(int i = 0; i < count; i++)
            {
                createRoom();
            }

        }
        
        private Panel createRoom()
        {
            //Panel

            Panel parentPanel = this.pnlRooms;

            Panel newPanel = new Panel();
            newPanel.Location = new Point(13, 24);
            newPanel.Size = new Size(Height, Width);
            newPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(75)))), ((int)(((byte)(109)))));
            newPanel.Name = "room name";
            parentPanel.Controls.Add(newPanel);

            //Label

            Label label = new Label();
            label.Location = new Point(8, 4);
            label.Size = new Size(114, 23);
            label.Text = "Living room";
            label.Name = "lbLivingRoom";
            label.ForeColor = Color.White;
            newPanel.Controls.Add(label);

            // On and Off 

            PictureBox pictureBox = new PictureBox();
            pictureBox.Location = new Point(30, 35);
            pictureBox.Size = new Size(50, 44);
            pictureBox.Name = "pBroomOff";
            pictureBox.Image = imageList1.Images[0];
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            newPanel.Controls.Add(pictureBox);

            PictureBox pictureBox1 = new PictureBox();
            pictureBox1.Location = new Point(30, 35);
            pictureBox1.Size = new Size(50, 44);
            pictureBox1.Name = "pBroomOn";
            pictureBox1.Image = imageList1.Images[1];
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            newPanel.Controls.Add(pictureBox1);
            Height += 50;
            return newPanel;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbClockan.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
