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
        Form1 mainForm = new Form1();
        private void timer1_tick(object sender, EventArgs e)
        {
            sec = sec + 1;
            if (sec == 5)
            {
                mainForm.Visible = true;
                this.Hide();

            }
        }
    }
}

