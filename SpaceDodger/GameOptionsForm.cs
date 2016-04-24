using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceDodger
{
    public partial class GameOptionsForm : Form
    {
        private Form1 _game;

        public GameOptionsForm(Form1 form1)
        {
            InitializeComponent();
        }

        private void OnCancel(object sender, EventArgs e)
        {
            //ask the user are u sure u want to cancel
            if (MessageBox.Show("Are you sure you want to quit the Options Menu?", "Game Options", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                //if they hit no, aborts the dialog
                this.DialogResult = DialogResult.None;
            }

            else
            {
                //closes the options form
                this.DialogResult = DialogResult.Cancel;
            }
        }

        private void OnOK(object sender, EventArgs e)
        {
            //save settings
            Properties.Settings.Default.Save();

            //closes the form
            DialogResult = DialogResult.Cancel;

            //hits the user with a msg that changes saved
            MessageBox.Show("The game changes have been saved. The game will now restart", "Game Options");
        }
    }
}