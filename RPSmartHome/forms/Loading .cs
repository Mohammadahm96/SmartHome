﻿using System;
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
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
        }

        private void Loading_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
            {
                progressBar1.Value += 1;

                lbnr.Text = progressBar1.Value.ToString() + "%";
            }
            else
            {
                timer1.Stop();

                //Home home = new Home();

                //home.Show();
                //this.Hide();

                LoginRegs loginRegs = new LoginRegs();
                loginRegs.Show();
                this.Hide();
            }
        }
    }
}
