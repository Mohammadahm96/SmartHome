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
            this.Activated += Home_Activated;
            lbWelcome.Visible = false;
            lbYou.Visible = false;
            lbSignIn.Visible = false;

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

        private void lbl_exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Exit?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {

                Application.Exit();

            }

        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please call us at 072829131 or email us at Smarthome@hotmail.com for assistance");
        }

        private void lbl_logout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to log out?", "Log out", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {

                Form Login = new LoginRegs();
                Login.Show();
                this.Hide();

            }

            
        }

        private void txt_Install_Click(object sender, EventArgs e)
        {

            MessageBox.Show("We dont not provide home installation at the moment. Our developers are currently performing scheduled maintenance on the Dashboard. Sorry for the inconvenience. Please contact us for more information ", "Maintenence", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);




        }

        private void label2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Our Smarthome application enables users to easily connect with various appliances, including control of lights, refrigerator, washer, air conditioner, oven, vacuum vacuum and more through your smartphones.\r\n\r\n\r\nWith our Smarthome application, you can monitor and control home appliances on the go and enjoy useful services including status check, device control, home view, and customer support.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Home_Activated(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            pnlUserController.Controls.Add(dashboard);
            dashboard.BringToFront();
            
        }

        private void lbSignIn_MouseHover(object sender, EventArgs e)
        {
            lbSignIn.Font = new Font("Times New Roman", 14.25F, FontStyle.Underline);
        }

        private void lbSignIn_MouseLeave(object sender, EventArgs e)
        {
            lbSignIn.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular);

        }

        private void pBDown_Click(object sender, EventArgs e)
        {
            lbWelcome.Visible = true;
            lbYou.Visible = true;
            lbSignIn.Visible = true;
            pBUp.BringToFront();
        }

        private void pBUp_Click(object sender, EventArgs e)
        {
            lbWelcome.Visible = false;
            lbYou.Visible = false;
            lbSignIn.Visible = false;
            pBDown.BringToFront();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            if (lbWelcome.Visible)
            {
                pBUp_Click(sender, e);
            }
            else if (!lbWelcome.Visible)
            {
                pBDown_Click(sender, e);
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (lbWelcome.Visible)
            {
                pBUp_Click(sender, e);
            }
            else if (!lbWelcome.Visible)
            {
                pBDown_Click(sender, e);
            }
        }

        private void lbSignIn_Click(object sender, EventArgs e)
        {
            LoginRegs loginRegs = new LoginRegs();
            loginRegs.Show();
            pBUp_Click(sender, e);

        }
    }
}
