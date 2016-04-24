using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceDodger
{
    public partial class StartSplash : Form
    {
        public StartSplash()
        {
            InitializeComponent();
            timer1.Enabled = true;
            this.StartPosition = FormStartPosition.CenterScreen;
        }


        int sec = 0;
        Form1 forma = new Form1();
        private void timer1_tick(object sender, EventArgs e)
        {
            sec = sec + 1;
            if (sec == 15)
            {
                forma.Visible = true;
                this.Hide();

            }
        }
    }
}

