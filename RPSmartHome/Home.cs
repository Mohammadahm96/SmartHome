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
        public Home()
        {
            InitializeComponent();
        }

        private void pBMenuBar_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pBCancel.Visible = false;
            pnlMenuBar.Size = new System.Drawing.Size(170, 91);
        }

        private void pBthree_Click(object sender, EventArgs e)
        {
            pBthree.Visible = false;
            pBCancel.Visible = true;
            pnlMenuBar.Size = new System.Drawing.Size(170, 668);
        }

        private void pBCancel_Click(object sender, EventArgs e)
        {
            pBthree.Visible = true;
            pBCancel.Visible = false;
            pnlMenuBar.Size = new System.Drawing.Size(170, 91);
        }
    }
}
