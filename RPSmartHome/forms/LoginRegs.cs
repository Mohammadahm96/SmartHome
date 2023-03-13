using Microsoft.Win32;
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
            btnSingup.Enabled = false;
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

        #region Login

        public static string userName { get; internal set; }
        public static string password { get; internal set; }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            dbHelper dbHelper = new dbHelper();
            userName = txtUsername.Text;
            password = txtPass.Text;

            try
            {
                string userName1 = txtUsername.Text;
                int password1 = Convert.ToInt32(txtPass.Text);
                dbHelper.logIn();
                if( dbHelper.userNameDb == userName && Convert.ToInt32(password) == dbHelper.passwordDb)
                {
                    dbHelper.person();
                    this.Hide();

                    

                }
                else
                {
                    errortxtUsername.SetError(txtUsername, "Wrong username");
                    errortxtPassword.SetError(txtPass, "Wrong password");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            
        }
        #endregion

        #region Registreation 

        public static string fullName { get; set; }
        public static string userNameRg { get; set; }
        public static string passwordRg { get; set; }

        // Singup 
        private void btnSingup_Click(object sender, EventArgs e)
        {
            dbHelper dbHelper = new dbHelper();
            try
            {
                fullName = txtFullName.Text;
                userNameRg = txtUsernameReg.Text;
                passwordRg = txtPassReg.Text;
                

                if(txtFullName.Text == "full name" || txtFullName.Text == "")
                {
                    errortxtFullName.SetError(txtFullName, "Full Name is reguired!");
                }
                else
                {
                    errortxtFullName.SetError(txtFullName, string.Empty);
                }
                
                if (txtUsernameReg.Text == "username" || txtUsernameReg.Text == "")
                {
                    errortxtUsernameReg.SetError(txtUsernameReg, "Username is reguired!");
                }
                else
                {
                    if (dbHelper.duplicateUsrname > 0)
                    {
                        errortxtUsernameReg.SetError(txtUsernameReg, "The user name is taken. Try another one.");
                    }else
                    {
                        errortxtUsernameReg.SetError(txtUsernameReg, string.Empty);

                    }
                }

                if (txtPassReg.Text == "password" || txtPassReg.Text == "")
                {
                    errortxtPassReg.SetError(txtPassReg, "Password is reguired!");
                }
                else
                {
                    errortxtPassReg.SetError(txtPassReg, string.Empty);
                }

               
                
                if (txtConfPass.Text == "" || txtConfPass.Text == "confirm password")
                {
                    errortxtConfPass.SetError(txtConfPass, "The password not matched!");
                }
                else
                {
                    if (txtPassReg.Text == txtConfPass.Text)
                    {
                        errortxtConfPass.SetError(txtConfPass, string.Empty);
                    }
                    else
                    {
                        MessageBox.Show("not same");
                        errortxtConfPass.SetError(txtConfPass, "The password not matched!");
                    }
                }

                if (txtFullName.Text == "full name" && txtUsername.Text == "username" &&
                   txtPassReg.Text == "password" && txtConfPass.Text == "confirm password")
                {
                    checkBox1.Checked= false;
                    btnSingup.Enabled = false;
                }
                else
                {
                    btnSingup.Enabled = true;
                    checkBox1.Checked = true;

                    dbHelper.Register();
                    MessageBox.Show("Sing up was successfully");
                }

            }
            catch 
            { 
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (txtFullName.Text == "full name" && txtUsername.Text == "username" &&
                   txtPassReg.Text == "password" && txtConfPass.Text == "confirm password")
            {
                checkBox1.Checked = false;
                btnSingup.Enabled = false;
            }
            else
            {
                btnSingup.Enabled = true;
                checkBox1.Checked = true;

            }
        }

        private void txtConfPass_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                checkBox1.Checked = true;
                btnSingup_Click(sender, e);
            }
        }


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
            dbHelper dbHelper = new dbHelper();

            userNameRg = txtUsernameReg.Text;

            dbHelper.checkDuplicateUsername();
            if(dbHelper.duplicateUsrname > 0)
            {
                errortxtUsernameReg.SetError(txtUsernameReg, "The user name is taken. Try another one.");
            }
            
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
    }
}
