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
            LoginRegs loginRegs = new LoginRegs();
            loginRegs.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbClockan.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
