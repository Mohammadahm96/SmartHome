using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPSmartHome
{
    public partial class Home : Form
    {
        Dashboard Dashboard = new Dashboard();
        public Home()
        {
            InitializeComponent();
            userControl(Dashboard);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pBCancel.Visible = false;
            pnlMenuBar.Size = new System.Drawing.Size(170, 91);
        }


        private void pnlTop_Click(object sender, EventArgs e)
        {
            pBCancel_Click(sender, e);
        }

        #region Menu bar
        //Menu bar open or close
        public void closeMenuBar()
        {
            
            pBthree.Visible = true;
            pBCancel.Visible = false;
            pnlMenuBar.Size = new System.Drawing.Size(170, 91);
        }
        
        public void openMenuBar()
        {
            pBthree.Visible = false;
            pBCancel.Visible = true;
            pnlMenuBar.Size = new System.Drawing.Size(170, 668);
        }


        private void pBthree_Click(object sender, EventArgs e)
        {
            openMenuBar();
        }

        private void pBCancel_Click(object sender, EventArgs e)
        {
            closeMenuBar();
        }
        #endregion

        #region User Controller
        private void pnlUserController_Click(object sender, EventArgs e)
        {
            pBCancel_Click(sender, e);
        }

        //all U_forms controll and show it Panel pnl_U
        private void userControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            pnlUserController.Controls.Clear();
            pnlUserController.Controls.Add(userControl);
            userControl.BringToFront();
        }

        #endregion
        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
