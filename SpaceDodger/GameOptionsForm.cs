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

            _game = form1;
        }

        private void OnLoad (object sender, EventArgs e)
        {
            _btnEasy.Checked = Properties.Settings.Default.easy_button;
            _btnMedium.Checked = Properties.Settings.Default.med_button;
            _btnHard.Checked = Properties.Settings.Default.hard_button;

            _btnClassic.Checked = Properties.Settings.Default.classic_button;
            _btnDark.Checked = Properties.Settings.Default.dark_button;
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
            if (_btnEasy.Checked)
            {
                //_game.easySet();

                //Properties.Settings.Default.ship_timer = _game._timer.Interval;

                _btnEasy.Checked = Properties.Settings.Default.easy_button = true;
                _btnMedium.Checked = Properties.Settings.Default.med_button = false;
            }

            if (_btnMedium.Checked)
            {
                //_game.medSet();

                //Properties.Settings.Default.ship_timer = _game._timer.Interval;

                _btnEasy.Checked = Properties.Settings.Default.easy_button = false;
                _btnHard.Checked = Properties.Settings.Default.hard_button = false;
                _btnMedium.Checked = Properties.Settings.Default.med_button = true;
            }

            if (_btnHard.Checked)
            {
                //_game.hardSet();

                //Properties.Settings.Default.ship_timer = _game._timer.Interval;

                _btnHard.Checked = Properties.Settings.Default.hard_button = true;
                _btnMedium.Checked = Properties.Settings.Default.med_button = false;
            }

            if (_btnClassic.Checked)
            {
                //_game.BackColor = System.Drawing.Color.AntiqueWhite;

                _btnDark.Checked = Properties.Settings.Default.dark_button = false;
                _btnClassic.Checked = Properties.Settings.Default.classic_button = true;
            }

            if (_btnDark.Checked)
            {
                //_game.BackColor = System.Drawing.Color.Brown;

                _btnDark.Checked = Properties.Settings.Default.dark_button = true;
                _btnClassic.Checked = Properties.Settings.Default.classic_button = false;
            }

            //save settings
            Properties.Settings.Default.Save();

            //closes the form
            DialogResult = DialogResult.Cancel;

            //hits the user with a msg that changes saved
            MessageBox.Show("The game changes have been saved. The game will now restart", "Game Options");
        }
    }
}