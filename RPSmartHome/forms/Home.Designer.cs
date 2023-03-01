namespace RPSmartHome
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.pnlMenuBar = new System.Windows.Forms.Panel();
            this.pBCancel = new System.Windows.Forms.PictureBox();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pnlUserController = new System.Windows.Forms.Panel();
            this.pBthree = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlMenuBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBCancel)).BeginInit();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBthree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenuBar
            // 
            this.pnlMenuBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
            this.pnlMenuBar.Controls.Add(this.pBthree);
            this.pnlMenuBar.Controls.Add(this.pBCancel);
            this.pnlMenuBar.Location = new System.Drawing.Point(920, 1);
            this.pnlMenuBar.Name = "pnlMenuBar";
            this.pnlMenuBar.Size = new System.Drawing.Size(170, 91);
            this.pnlMenuBar.TabIndex = 1;
            // 
            // pBCancel
            // 
            this.pBCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pBCancel.Image = ((System.Drawing.Image)(resources.GetObject("pBCancel.Image")));
            this.pBCancel.Location = new System.Drawing.Point(113, 24);
            this.pBCancel.Name = "pBCancel";
            this.pBCancel.Size = new System.Drawing.Size(34, 30);
            this.pBCancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBCancel.TabIndex = 0;
            this.pBCancel.TabStop = false;
            this.pBCancel.Click += new System.EventHandler(this.pBCancel_Click);
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
            this.pnlTop.Controls.Add(this.pictureBox1);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1090, 92);
            this.pnlTop.TabIndex = 2;
            this.pnlTop.Click += new System.EventHandler(this.pnlTop_Click);
            // 
            // pnlUserController
            // 
            this.pnlUserController.Location = new System.Drawing.Point(12, 98);
            this.pnlUserController.Name = "pnlUserController";
            this.pnlUserController.Size = new System.Drawing.Size(1070, 571);
            this.pnlUserController.TabIndex = 3;
            this.pnlUserController.Click += new System.EventHandler(this.pnlUserController_Click);
            // 
            // pBthree
            // 
            this.pBthree.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pBthree.Image = ((System.Drawing.Image)(resources.GetObject("pBthree.Image")));
            this.pBthree.Location = new System.Drawing.Point(113, 24);
            this.pBthree.Name = "pBthree";
            this.pBthree.Size = new System.Drawing.Size(34, 30);
            this.pBthree.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBthree.TabIndex = 0;
            this.pBthree.TabStop = false;
            this.pBthree.Click += new System.EventHandler(this.pBthree_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pBthree_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 681);
            this.Controls.Add(this.pnlMenuBar);
            this.Controls.Add(this.pnlUserController);
            this.Controls.Add(this.pnlTop);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1106, 720);
            this.MinimumSize = new System.Drawing.Size(1106, 720);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Home_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlMenuBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pBCancel)).EndInit();
            this.pnlTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pBthree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenuBar;
        private System.Windows.Forms.PictureBox pBCancel;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlUserController;
        private System.Windows.Forms.PictureBox pBthree;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

