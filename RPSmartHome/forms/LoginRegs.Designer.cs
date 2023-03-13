namespace RPSmartHome
{
    partial class LoginRegs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginRegs));
            this.lbSingUp = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlRegister = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbConfPass = new System.Windows.Forms.Label();
            this.lbPassReg = new System.Windows.Forms.Label();
            this.lbUsernameReg = new System.Windows.Forms.Label();
            this.lbFullName = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnSingup = new System.Windows.Forms.Button();
            this.txtConfPass = new System.Windows.Forms.TextBox();
            this.txtPassReg = new System.Windows.Forms.TextBox();
            this.txtUsernameReg = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbUsername = new System.Windows.Forms.Label();
            this.lbPass = new System.Windows.Forms.Label();
            this.errortxtUsername = new System.Windows.Forms.ErrorProvider(this.components);
            this.errortxtPassword = new System.Windows.Forms.ErrorProvider(this.components);
            this.errortxtFullName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errortxtUsernameReg = new System.Windows.Forms.ErrorProvider(this.components);
            this.errortxtPassReg = new System.Windows.Forms.ErrorProvider(this.components);
            this.errortxtConfPass = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlRegister.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errortxtUsername)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errortxtPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errortxtFullName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errortxtUsernameReg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errortxtPassReg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errortxtConfPass)).BeginInit();
            this.SuspendLayout();
            // 
            // lbSingUp
            // 
            this.lbSingUp.AutoSize = true;
            this.lbSingUp.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(128)))));
            this.lbSingUp.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSingUp.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(128)))));
            this.lbSingUp.Location = new System.Drawing.Point(780, 454);
            this.lbSingUp.Name = "lbSingUp";
            this.lbSingUp.Size = new System.Drawing.Size(68, 22);
            this.lbSingUp.TabIndex = 11;
            this.lbSingUp.TabStop = true;
            this.lbSingUp.Text = "SingUp";
            this.lbSingUp.Click += new System.EventHandler(this.lbSingUp_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(555, 454);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 22);
            this.label2.TabIndex = 12;
            this.label2.Text = "Don\'t have an account yet?";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(128)))));
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(526, 329);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(326, 51);
            this.btnLogin.TabIndex = 10;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtPass
            // 
            this.txtPass.ForeColor = System.Drawing.Color.Gray;
            this.txtPass.Location = new System.Drawing.Point(526, 255);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(326, 29);
            this.txtPass.TabIndex = 8;
            this.txtPass.Text = "password";
            this.txtPass.Click += new System.EventHandler(this.txtPass_Click);
            this.txtPass.TextChanged += new System.EventHandler(this.txtPass_TextChanged);
            this.txtPass.Leave += new System.EventHandler(this.txtPass_Leave);
            // 
            // txtUsername
            // 
            this.txtUsername.ForeColor = System.Drawing.Color.Gray;
            this.txtUsername.Location = new System.Drawing.Point(526, 185);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(326, 29);
            this.txtUsername.TabIndex = 6;
            this.txtUsername.Text = "username";
            this.txtUsername.Click += new System.EventHandler(this.txtUsername_Click);
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            this.txtUsername.Leave += new System.EventHandler(this.txtUsername_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(596, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 36);
            this.label1.TabIndex = 9;
            this.label1.Text = "Hello Again!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 115);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(453, 329);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pnlRegister
            // 
            this.pnlRegister.Controls.Add(this.pictureBox2);
            this.pnlRegister.Controls.Add(this.lbConfPass);
            this.pnlRegister.Controls.Add(this.lbPassReg);
            this.pnlRegister.Controls.Add(this.lbUsernameReg);
            this.pnlRegister.Controls.Add(this.lbFullName);
            this.pnlRegister.Controls.Add(this.linkLabel1);
            this.pnlRegister.Controls.Add(this.label4);
            this.pnlRegister.Controls.Add(this.checkBox1);
            this.pnlRegister.Controls.Add(this.btnSingup);
            this.pnlRegister.Controls.Add(this.txtConfPass);
            this.pnlRegister.Controls.Add(this.txtPassReg);
            this.pnlRegister.Controls.Add(this.txtUsernameReg);
            this.pnlRegister.Controls.Add(this.txtFullName);
            this.pnlRegister.Controls.Add(this.label3);
            this.pnlRegister.Location = new System.Drawing.Point(2, 12);
            this.pnlRegister.Name = "pnlRegister";
            this.pnlRegister.Size = new System.Drawing.Size(906, 524);
            this.pnlRegister.TabIndex = 13;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(439, 109);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(456, 267);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // lbConfPass
            // 
            this.lbConfPass.AutoSize = true;
            this.lbConfPass.Location = new System.Drawing.Point(28, 265);
            this.lbConfPass.Name = "lbConfPass";
            this.lbConfPass.Size = new System.Drawing.Size(0, 21);
            this.lbConfPass.TabIndex = 21;
            // 
            // lbPassReg
            // 
            this.lbPassReg.AutoSize = true;
            this.lbPassReg.Location = new System.Drawing.Point(28, 191);
            this.lbPassReg.Name = "lbPassReg";
            this.lbPassReg.Size = new System.Drawing.Size(0, 21);
            this.lbPassReg.TabIndex = 21;
            // 
            // lbUsernameReg
            // 
            this.lbUsernameReg.AutoSize = true;
            this.lbUsernameReg.Location = new System.Drawing.Point(28, 120);
            this.lbUsernameReg.Name = "lbUsernameReg";
            this.lbUsernameReg.Size = new System.Drawing.Size(0, 21);
            this.lbUsernameReg.TabIndex = 21;
            // 
            // lbFullName
            // 
            this.lbFullName.AutoSize = true;
            this.lbFullName.Location = new System.Drawing.Point(28, 47);
            this.lbFullName.Name = "lbFullName";
            this.lbFullName.Size = new System.Drawing.Size(0, 21);
            this.lbFullName.TabIndex = 21;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(128)))));
            this.linkLabel1.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(128)))));
            this.linkLabel1.Location = new System.Drawing.Point(268, 450);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(60, 22);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Log in";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 451);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 21);
            this.label4.TabIndex = 19;
            this.label4.Text = "Already have an account?";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(23, 346);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(282, 23);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "I agree to all the Terms and Privacy Policy";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnSingup
            // 
            this.btnSingup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(128)))));
            this.btnSingup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSingup.ForeColor = System.Drawing.Color.White;
            this.btnSingup.Location = new System.Drawing.Point(23, 391);
            this.btnSingup.Name = "btnSingup";
            this.btnSingup.Size = new System.Drawing.Size(372, 51);
            this.btnSingup.TabIndex = 6;
            this.btnSingup.Text = "Create account";
            this.btnSingup.UseVisualStyleBackColor = false;
            this.btnSingup.Click += new System.EventHandler(this.btnSingup_Click);
            // 
            // txtConfPass
            // 
            this.txtConfPass.ForeColor = System.Drawing.Color.Gray;
            this.txtConfPass.Location = new System.Drawing.Point(23, 289);
            this.txtConfPass.Name = "txtConfPass";
            this.txtConfPass.Size = new System.Drawing.Size(372, 29);
            this.txtConfPass.TabIndex = 4;
            this.txtConfPass.Text = "confirm password";
            this.txtConfPass.Click += new System.EventHandler(this.txtConfPass_Click);
            this.txtConfPass.TextChanged += new System.EventHandler(this.txtConfPass_TextChanged);
            this.txtConfPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtConfPass_KeyDown);
            this.txtConfPass.Leave += new System.EventHandler(this.txtConfPass_Leave);
            // 
            // txtPassReg
            // 
            this.txtPassReg.ForeColor = System.Drawing.Color.Gray;
            this.txtPassReg.Location = new System.Drawing.Point(23, 215);
            this.txtPassReg.Name = "txtPassReg";
            this.txtPassReg.Size = new System.Drawing.Size(372, 29);
            this.txtPassReg.TabIndex = 3;
            this.txtPassReg.Text = "password";
            this.txtPassReg.Click += new System.EventHandler(this.txtPassReg_Click);
            this.txtPassReg.TextChanged += new System.EventHandler(this.txtPassReg_TextChanged);
            this.txtPassReg.Leave += new System.EventHandler(this.txtPassReg_Leave);
            // 
            // txtUsernameReg
            // 
            this.txtUsernameReg.ForeColor = System.Drawing.Color.Gray;
            this.txtUsernameReg.Location = new System.Drawing.Point(23, 144);
            this.txtUsernameReg.Name = "txtUsernameReg";
            this.txtUsernameReg.Size = new System.Drawing.Size(372, 29);
            this.txtUsernameReg.TabIndex = 2;
            this.txtUsernameReg.Text = "username";
            this.txtUsernameReg.Click += new System.EventHandler(this.txtUsernameReg_Click);
            this.txtUsernameReg.TextChanged += new System.EventHandler(this.txtUsernameReg_TextChanged);
            this.txtUsernameReg.Leave += new System.EventHandler(this.txtUsernameReg_Leave);
            // 
            // txtFullName
            // 
            this.txtFullName.ForeColor = System.Drawing.Color.Gray;
            this.txtFullName.Location = new System.Drawing.Point(23, 71);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(372, 29);
            this.txtFullName.TabIndex = 1;
            this.txtFullName.Text = "full name";
            this.txtFullName.Click += new System.EventHandler(this.txtFullName_Click);
            this.txtFullName.TextChanged += new System.EventHandler(this.txtFullName_TextChanged);
            this.txtFullName.Leave += new System.EventHandler(this.txtFullName_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(143, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 36);
            this.label3.TabIndex = 11;
            this.label3.Text = "Register";
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Location = new System.Drawing.Point(532, 161);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(0, 21);
            this.lbUsername.TabIndex = 14;
            // 
            // lbPass
            // 
            this.lbPass.AutoSize = true;
            this.lbPass.Location = new System.Drawing.Point(532, 231);
            this.lbPass.Name = "lbPass";
            this.lbPass.Size = new System.Drawing.Size(0, 21);
            this.lbPass.TabIndex = 14;
            // 
            // errortxtUsername
            // 
            this.errortxtUsername.ContainerControl = this;
            this.errortxtUsername.RightToLeft = true;
            // 
            // errortxtPassword
            // 
            this.errortxtPassword.ContainerControl = this;
            this.errortxtPassword.RightToLeft = true;
            // 
            // errortxtFullName
            // 
            this.errortxtFullName.ContainerControl = this;
            this.errortxtFullName.RightToLeft = true;
            // 
            // errortxtUsernameReg
            // 
            this.errortxtUsernameReg.ContainerControl = this;
            this.errortxtUsernameReg.RightToLeft = true;
            // 
            // errortxtPassReg
            // 
            this.errortxtPassReg.ContainerControl = this;
            this.errortxtPassReg.RightToLeft = true;
            // 
            // errortxtConfPass
            // 
            this.errortxtConfPass.ContainerControl = this;
            this.errortxtConfPass.RightToLeft = true;
            // 
            // LoginRegs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(909, 533);
            this.Controls.Add(this.lbPass);
            this.Controls.Add(this.lbUsername);
            this.Controls.Add(this.pnlRegister);
            this.Controls.Add(this.lbSingUp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(925, 572);
            this.MinimumSize = new System.Drawing.Size(925, 572);
            this.Name = "LoginRegs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlRegister.ResumeLayout(false);
            this.pnlRegister.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errortxtUsername)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errortxtPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errortxtFullName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errortxtUsernameReg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errortxtPassReg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errortxtConfPass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lbSingUp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlRegister;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnSingup;
        private System.Windows.Forms.TextBox txtConfPass;
        private System.Windows.Forms.TextBox txtPassReg;
        private System.Windows.Forms.TextBox txtUsernameReg;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbConfPass;
        private System.Windows.Forms.Label lbPassReg;
        private System.Windows.Forms.Label lbUsernameReg;
        private System.Windows.Forms.Label lbFullName;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Label lbPass;
        private System.Windows.Forms.ErrorProvider errortxtUsername;
        private System.Windows.Forms.ErrorProvider errortxtPassword;
        private System.Windows.Forms.ErrorProvider errortxtFullName;
        private System.Windows.Forms.ErrorProvider errortxtUsernameReg;
        private System.Windows.Forms.ErrorProvider errortxtPassReg;
        private System.Windows.Forms.ErrorProvider errortxtConfPass;
    }
}