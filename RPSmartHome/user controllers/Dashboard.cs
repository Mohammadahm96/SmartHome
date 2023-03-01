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

        private void button1_Click(object sender, EventArgs e)
        {
            Panel panel = new Panel();
            this.Controls.Add(panel);
            pictureBox pictureBox = new pictureBox();

            panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(75)))), ((int)(((byte)(109)))));
            //panel.Controls.Add(this.pictureBox4);
            //panel.Controls.Add(this.label9);
            //panel.Controls.Add(this.pictureBox5);
            panel.Location = new System.Drawing.Point(28, 13);
            panel.Name = "panel4";
            panel.Size = new System.Drawing.Size(117, 95);
            panel.TabIndex = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbClockan.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
