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
    public partial class LoginRegs : Form
    {
        public LoginRegs()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            pnlRegister.Size = new Size(906, 18);
            pnlRegister.Visible = false;
        }

        private void lbSingUp_Click(object sender, EventArgs e)
        {
            pnlRegister.Visible = true;
            pnlRegister.Size = new Size(906, 535);
            pnlRegister.Location = new Point(2, 1);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login_Load(sender, e);
        }

        private void txtUsername_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "username")
            {
                txtUsername.ForeColor = Color.Black;
                txtUsername.Text = "";
                lbUsername.Text = "username";
            }
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                txtUsername.Text = "username";
                txtUsername.ForeColor = Color.Gray;
                lbUsername.Text = "";
            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text == "")
            {
                txtPass.Text = "password";
                txtPass.ForeColor = Color.Gray;
                lbPass.Text = "";
            }
        }

        private void txtPass_Click(object sender, EventArgs e)
        {
            if (txtPass.Text == "password")
            {
                txtPass.Text = "";
                txtPass.ForeColor = Color.Black;
                lbPass.Text = "password";
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            lbUsername.Text = "username";
            txtUsername.ForeColor = Color.Black;
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            lbPass.Text = "password";
            txtPass.ForeColor = Color.Black;
        }

        #region Registreation 
        private void txtFullName_Click(object sender, EventArgs e)
        {
            if (txtFullName.Text == "full name")
            {
                txtFullName.Text = "";
                txtFullName.ForeColor = Color.Black;
                lbFullName.Text = "full name";
            }
        }

        private void txtUsernameReg_Click(object sender, EventArgs e)
        {
            if (txtUsernameReg.Text == "username")
            {
                txtUsernameReg.Text = "";
                txtUsernameReg.ForeColor = Color.Black;
                lbUsernameReg.Text = "username";
            }
        }

        private void txtPassReg_Click(object sender, EventArgs e)
        {
            if (txtPassReg.Text == "password")
            {
                txtPassReg.Text = "";
                txtPassReg.ForeColor = Color.Black;
                lbPassReg.Text = "password";
            }
        }

        private void txtConfPass_Click(object sender, EventArgs e)
        {
            if (txtConfPass.Text == "confirm password")
            {
                txtConfPass.Text = "";
                txtConfPass.ForeColor = Color.Black;
                lbConfPass.Text = "confirm password";
            }
        }

        private void txtFullName_Leave(object sender, EventArgs e)
        {
            if (txtFullName.Text == "")
            {
                txtFullName.Text = "full name";
                txtFullName.ForeColor = Color.Gray;
                lbFullName.Text = "";
            }
        }

        private void txtUsernameReg_Leave(object sender, EventArgs e)
        {
            if (txtUsernameReg.Text == "")
            {
                txtUsernameReg.Text = "username";
                txtUsernameReg.ForeColor = Color.Gray;
                lbUsernameReg.Text = "";
            }
        }

        private void txtPassReg_Leave(object sender, EventArgs e)
        {
            if (txtPassReg.Text == "")
            {
                txtPassReg.Text = "password";
                txtPassReg.ForeColor = Color.Gray;
                lbPassReg.Text = "";
            }
        }

        private void txtConfPass_Leave(object sender, EventArgs e)
        {
            if (txtConfPass.Text == "")
            {
                txtConfPass.Text = "confirm password";
                txtConfPass.ForeColor = Color.Gray;
                lbConfPass.Text = "";
            }
        }

        private void txtFullName_TextChanged(object sender, EventArgs e)
        {
            txtFullName.ForeColor = Color.Black;
            lbFullName.Text = "full name";
        }

        private void txtUsernameReg_TextChanged(object sender, EventArgs e)
        {
            txtUsernameReg.ForeColor = Color.Black;
            lbUsernameReg.Text = "username";
        }

        private void txtPassReg_TextChanged(object sender, EventArgs e)
        {
            txtPassReg.ForeColor = Color.Black;
            lbPassReg.Text = "password";
        }

        private void txtConfPass_TextChanged(object sender, EventArgs e)
        {
            txtConfPass.ForeColor = Color.Black;
            lbConfPass.Text = "confirm password";
        }
        #endregion

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
        }
    }
}
