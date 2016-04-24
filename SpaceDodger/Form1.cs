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
    public partial class Form1 : Form
    {
        int _view = 0;
        int _score = 0;
        Random randomizer = new Random();
        private Form1 _game;

        public Form1()
        {
            InitializeComponent();
            _lblEndLabel.Visible = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            _picBoxSpaceShip.Visible = false;
            _picBoxBlock1.Visible = false;
            _picBoxBlock2.Visible = false;
            _picBoxBlock3.Visible = false;
            _picBoxBlock4.Visible = false;
            _picBoxBlock5.Visible = false;
            _picBoxBlock6.Visible = false;
            _picBoxBlock7.Visible = false;
            _picBoxBlock8.Visible = false;
            _picBoxBlock9.Visible = false;
            _picBoxBlock10.Visible = false;
            _picBoxBlock11.Visible = false;
            _picBoxBlock12.Visible = false;
            _picBoxBlock13.Visible = false;
            _picBoxBlock14.Visible = false;
            _picBoxBlock15.Visible = false;
            _picBoxBlock16.Visible = false;
            _picBoxBlock17.Visible = false;
            _picBoxBlock18.Visible = false;
            _picBoxBlock19.Visible = false;
            _picBoxBlock20.Visible = false;
            _lblInstructions.Text = "Press UP arrow to ascend" + Environment.NewLine + " Do not Hit the Obstacles";
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Left:
                    // The left arrow key is pressed 
                    return true;
                case Keys.Right:
                    // The right arrow key is pressed
                    return true;
                case Keys.Up:
                    _picBoxSpaceShip.Location = new Point(_picBoxSpaceShip.Location.X, _picBoxSpaceShip.Location.Y - 25);
                    return true;
                case Keys.Down:
                    // The down arrow key is pressed.
                    return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void ClickOnClose(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void StartOnClick(object sender, EventArgs e)
        {
            _picBoxSpaceShip.Visible = true;
            _picBoxBlock1.Visible = true;
            _picBoxBlock2.Visible = true;
            _picBoxBlock3.Visible = true;
            _picBoxBlock4.Visible = true;
            _picBoxBlock5.Visible = true;
            _picBoxBlock6.Visible = true;
            _picBoxBlock7.Visible = true;
            _picBoxBlock8.Visible = true;
            _picBoxBlock9.Visible = true;
            _picBoxBlock10.Visible = true;
            _picBoxBlock11.Visible = true;
            _picBoxBlock12.Visible = true;
            _picBoxBlock13.Visible = true;
            _picBoxBlock14.Visible = true;
            _picBoxBlock15.Visible = true;
            _picBoxBlock16.Visible = true;
            _picBoxBlock17.Visible = true;
            _picBoxBlock18.Visible = true;
            _picBoxBlock19.Visible = true;
            _picBoxBlock20.Visible = true;
            _timer.Enabled = true;
            _picBoxStartButton.Visible = false;
            _timer2.Enabled = true;
            _lblInstructions.Visible = true;
            _lblScore.Visible = true;
            _lblEndLabel.Visible = false;
            _picBoxSpaceShip.Location = new Point(144, 160);
            _view = 0;
            _score = 0;
            _picBoxBlock10.Size = new System.Drawing.Size(88, 90);
            _picBoxBlock11.Size = new System.Drawing.Size(88, 90);
            _picBoxBlock12.Size = new System.Drawing.Size(88, 90);
            _picBoxBlock13.Size = new System.Drawing.Size(88, 90);
            _picBoxBlock14.Size = new System.Drawing.Size(88, 90);
            _picBoxBlock15.Size = new System.Drawing.Size(88, 90);
            _picBoxBlock16.Size = new System.Drawing.Size(88, 90);
            _picBoxBlock17.Size = new System.Drawing.Size(88, 90);
            _picBoxBlock18.Size = new System.Drawing.Size(88, 90);
            _picBoxBlock18.Size = new System.Drawing.Size(88, 90);
            _picBoxBlock20.Size = new System.Drawing.Size(88, 90);
            _lblInstructions.Visible = false;
            _btnclose.Visible = false;
            var player = new System.Media.SoundPlayer();
            //player.Stream = Properties.Resources.Kalimba;
            player.Play();
            if (_view == 1)
            {
                player.Stop();
            }
        }

        private void StartTimer(object sender, EventArgs e)
        {
            _picBoxBlock1.Location = new Point(_picBoxBlock1.Location.X - 3, _picBoxBlock1.Location.Y);
            _picBoxBlock2.Location = new Point(_picBoxBlock2.Location.X - 3, _picBoxBlock2.Location.Y);
            _picBoxBlock3.Location = new Point(_picBoxBlock3.Location.X - 3, _picBoxBlock3.Location.Y);
            _picBoxBlock4.Location = new Point(_picBoxBlock4.Location.X - 3, _picBoxBlock4.Location.Y);
            _picBoxBlock5.Location = new Point(_picBoxBlock5.Location.X - 3, _picBoxBlock5.Location.Y);
            _picBoxBlock6.Location = new Point(_picBoxBlock6.Location.X - 3, _picBoxBlock6.Location.Y);
            _picBoxBlock7.Location = new Point(_picBoxBlock7.Location.X - 3, _picBoxBlock7.Location.Y);
            _picBoxBlock8.Location = new Point(_picBoxBlock8.Location.X - 3, _picBoxBlock8.Location.Y);
            _picBoxBlock9.Location = new Point(_picBoxBlock9.Location.X - 3, _picBoxBlock9.Location.Y);
            _picBoxBlock10.Location = new Point(_picBoxBlock10.Location.X - 3, _picBoxBlock10.Location.Y);
            _picBoxBlock11.Location = new Point(_picBoxBlock11.Location.X - 3, _picBoxBlock11.Location.Y);
            _picBoxBlock12.Location = new Point(_picBoxBlock12.Location.X - 3, _picBoxBlock12.Location.Y);
            _picBoxBlock13.Location = new Point(_picBoxBlock13.Location.X - 3, _picBoxBlock13.Location.Y);
            _picBoxBlock14.Location = new Point(_picBoxBlock14.Location.X - 3, _picBoxBlock14.Location.Y);
            _picBoxBlock15.Location = new Point(_picBoxBlock15.Location.X - 3, _picBoxBlock15.Location.Y);
            _picBoxBlock16.Location = new Point(_picBoxBlock16.Location.X - 3, _picBoxBlock16.Location.Y);
            _picBoxBlock17.Location = new Point(_picBoxBlock17.Location.X - 3, _picBoxBlock17.Location.Y);
            _picBoxBlock18.Location = new Point(_picBoxBlock18.Location.X - 3, _picBoxBlock18.Location.Y);
            _picBoxBlock19.Location = new Point(_picBoxBlock19.Location.X - 3, _picBoxBlock19.Location.Y);
            _picBoxBlock20.Location = new Point(_picBoxBlock20.Location.X - 3, _picBoxBlock20.Location.Y);

            if (_picBoxSpaceShip.Bounds.Contains(_picBoxBlock1.Location) || _picBoxSpaceShip.Bounds.Contains(_picBoxBlock2.Location) || _picBoxSpaceShip.Bounds.Contains(_picBoxBlock3.Location) || _picBoxSpaceShip.Bounds.Contains(_picBoxBlock4.Location) || _picBoxSpaceShip.Bounds.Contains(_picBoxBlock5.Location) || _picBoxSpaceShip.Bounds.Contains(_picBoxBlock6.Location) || _picBoxSpaceShip.Bounds.Contains(_picBoxBlock7.Location) || _picBoxSpaceShip.Bounds.Contains(_picBoxBlock8.Location) || _picBoxSpaceShip.Bounds.Contains(_picBoxBlock9.Location) || _picBoxSpaceShip.Bounds.Contains(_picBoxBlock19.Location))
            {
                _view = 1;
            }
            if (_picBoxBlock1.Bounds.Contains(_picBoxSpaceShip.Location) || _picBoxBlock2.Bounds.Contains(_picBoxSpaceShip.Location) || _picBoxBlock3.Bounds.Contains(_picBoxSpaceShip.Location) || _picBoxBlock4.Bounds.Contains(_picBoxSpaceShip.Location) || _picBoxBlock5.Bounds.Contains(_picBoxSpaceShip.Location) || _picBoxBlock6.Bounds.Contains(_picBoxSpaceShip.Location) || _picBoxBlock7.Bounds.Contains(_picBoxSpaceShip.Location) || _picBoxBlock8.Bounds.Contains(_picBoxSpaceShip.Location) || _picBoxBlock9.Bounds.Contains(_picBoxSpaceShip.Location) || _picBoxBlock19.Bounds.Contains(_picBoxSpaceShip.Location))
            {
                _view = 1;
            }
            if (_picBoxSpaceShip.Bounds.Contains(_picBoxBlock10.Location) || _picBoxSpaceShip.Bounds.Contains(_picBoxBlock11.Location) || _picBoxSpaceShip.Bounds.Contains(_picBoxBlock12.Location) || _picBoxSpaceShip.Bounds.Contains(_picBoxBlock13.Location) || _picBoxSpaceShip.Bounds.Contains(_picBoxBlock14.Location) || _picBoxSpaceShip.Bounds.Contains(_picBoxBlock15.Location) || _picBoxSpaceShip.Bounds.Contains(_picBoxBlock16.Location) || _picBoxSpaceShip.Bounds.Contains(_picBoxBlock17.Location) || _picBoxSpaceShip.Bounds.Contains(_picBoxBlock18.Location) || _picBoxSpaceShip.Bounds.Contains(_picBoxBlock20.Location))
            {
                _view = 1;
            }
            if (_picBoxBlock10.Bounds.Contains(_picBoxSpaceShip.Location) || _picBoxBlock11.Bounds.Contains(_picBoxSpaceShip.Location) || _picBoxBlock12.Bounds.Contains(_picBoxSpaceShip.Location) || _picBoxBlock13.Bounds.Contains(_picBoxSpaceShip.Location) || _picBoxBlock14.Bounds.Contains(_picBoxSpaceShip.Location) || _picBoxBlock15.Bounds.Contains(_picBoxSpaceShip.Location) || _picBoxBlock16.Bounds.Contains(_picBoxSpaceShip.Location) || _picBoxBlock17.Bounds.Contains(_picBoxSpaceShip.Location) || _picBoxBlock18.Bounds.Contains(_picBoxSpaceShip.Location) || _picBoxBlock20.Bounds.Contains(_picBoxSpaceShip.Location))
            {
                _view = 1;
            }
            if (_view == 1)
            {
                var player2 = new System.Media.SoundPlayer();
                //player2.Stream = Properties.Resources.explosion;
                player2.Play();
                _timer.Enabled = false;
                _timer2.Enabled = false;
                _picBoxStartButton.Visible = true;
                _btnclose.Visible = true;
                _picBoxSpaceShip.Visible = false;
                MessageBox.Show("You Lose ! Your Score is  " + _score.ToString());
                _picBoxBlock1.Visible = false;
                _picBoxBlock2.Visible = false;
                _picBoxBlock3.Visible = false;
                _picBoxBlock4.Visible = false;
                _picBoxBlock5.Visible = false;
                _picBoxBlock6.Visible = false;
                _picBoxBlock7.Visible = false;
                _picBoxBlock8.Visible = false;
                _picBoxBlock9.Visible = false;
                _picBoxBlock10.Visible = false;
                _picBoxBlock11.Visible = false;
                _picBoxBlock12.Visible = false;
                _picBoxBlock13.Visible = false;
                _picBoxBlock14.Visible = false;
                _picBoxBlock15.Visible = false;
                _picBoxBlock16.Visible = false;
                _picBoxBlock17.Visible = false;
                _picBoxBlock18.Visible = false;
                _picBoxBlock19.Visible = false;
                _picBoxBlock20.Visible = false;
                _lblScore.Visible = false;
                _picBoxSpaceShip.Location = new Point(144, 160);
                _view = 0;
                _score = 0;
                _lblInstructions.Visible = true;
                _picBoxBlock1.Location = new Point(0, 283);
                _picBoxBlock2.Location = new Point(82, 283);
                _picBoxBlock3.Location = new Point(167, 283);
                _picBoxBlock4.Location = new Point(245, 283);
                _picBoxBlock5.Location = new Point(329, 283);
                _picBoxBlock6.Location = new Point(412, 283);
                _picBoxBlock7.Location = new Point(496, 283);
                _picBoxBlock8.Location = new Point(576, 283);
                _picBoxBlock9.Location = new Point(659, 283);
                _picBoxBlock10.Location = new Point(0, 29);
                _picBoxBlock11.Location = new Point(82, 29);
                _picBoxBlock12.Location = new Point(167, 29);
                _picBoxBlock13.Location = new Point(245, 29);
                _picBoxBlock14.Location = new Point(329, 29);
                _picBoxBlock15.Location = new Point(412, 29);
                _picBoxBlock16.Location = new Point(496, 29);
                _picBoxBlock17.Location = new Point(576, 29);
                _picBoxBlock18.Location = new Point(659, 29);
                _picBoxBlock19.Location = new Point(743, 283);
                _picBoxBlock20.Location = new Point(743, 29);
            }

            if (_picBoxBlock1.Location.X < -82)
            {
                int n11 = randomizer.Next(234, 337);
                _picBoxBlock1.Location = new Point(743, n11);
            }
            if (_picBoxBlock2.Location.X < -82)
            {
                int n12 = randomizer.Next(234, 337);
                _picBoxBlock2.Location = new Point(743, n12);
            }
            if (_picBoxBlock3.Location.X < -82)
            {
                int n13 = randomizer.Next(234, 337);
                _picBoxBlock3.Location = new Point(743, n13);
            }
            if (_picBoxBlock4.Location.X < -82)
            {
                int n14 = randomizer.Next(234, 337);
                _picBoxBlock4.Location = new Point(743, n14);
            }
            if (_picBoxBlock5.Location.X < -82)
            {
                int n15 = randomizer.Next(234, 337);
                _picBoxBlock5.Location = new Point(743, n15);
            }
            if (_picBoxBlock6.Location.X < -82)
            {
                int n16 = randomizer.Next(234, 337);
                _picBoxBlock6.Location = new Point(743, n16);
            }
            if (_picBoxBlock7.Location.X < -82)
            {
                int n17 = randomizer.Next(234, 337);
                _picBoxBlock7.Location = new Point(743, n17);
            }
            if (_picBoxBlock8.Location.X < -82)
            {
                int n18 = randomizer.Next(234, 337);
                _picBoxBlock8.Location = new Point(743, n18);
            }
            if (_picBoxBlock9.Location.X < -82)
            {
                int n19 = randomizer.Next(234, 337);
                _picBoxBlock9.Location = new Point(743, n19);
            }
            if (_picBoxBlock10.Location.X < -82)
            {
                _picBoxBlock10.Location = new Point(743, 29);
                int n1 = randomizer.Next(30, 153);
                _picBoxBlock10.Size = new System.Drawing.Size(88, n1);
            }
            if (_picBoxBlock11.Location.X < -82)
            {
                _picBoxBlock11.Location = new Point(743, 29);
                int n2 = randomizer.Next(30, 153);
                _picBoxBlock11.Size = new System.Drawing.Size(88, n2);
            }
            if (_picBoxBlock12.Location.X < -82)
            {
                _picBoxBlock12.Location = new Point(743, 29);
                int n3 = randomizer.Next(30, 153);
                _picBoxBlock12.Size = new System.Drawing.Size(88, n3);
            }
            if (_picBoxBlock13.Location.X < -82)
            {
                _picBoxBlock13.Location = new Point(743, 29);
                int n4 = randomizer.Next(30, 153);
                _picBoxBlock13.Size = new System.Drawing.Size(88, n4);
            }
            if (_picBoxBlock14.Location.X < -82)
            {
                _picBoxBlock14.Location = new Point(743, 29);
                int n5 = randomizer.Next(30, 153);
                _picBoxBlock14.Size = new System.Drawing.Size(88, n5);
            }
            if (_picBoxBlock15.Location.X < -82)
            {
                _picBoxBlock15.Location = new Point(743, 29);
                int n6 = randomizer.Next(30, 153);
                _picBoxBlock15.Size = new System.Drawing.Size(88, n6);
            }
            if (_picBoxBlock16.Location.X < -82)
            {
                _picBoxBlock16.Location = new Point(743, 29);
                int n7 = randomizer.Next(30, 153);
                _picBoxBlock16.Size = new System.Drawing.Size(88, n7);
            }
            if (_picBoxBlock17.Location.X < -82)
            {
                _picBoxBlock17.Location = new Point(743, 29);
                int n8 = randomizer.Next(30, 153);
                _picBoxBlock17.Size = new System.Drawing.Size(88, n8);
            }
            if (_picBoxBlock18.Location.X < -82)
            {
                _picBoxBlock18.Location = new Point(743, 29);
                int n9 = randomizer.Next(30, 153);
                _picBoxBlock18.Size = new System.Drawing.Size(88, n9);
            }
            if (_picBoxBlock19.Location.X < -82)
            {
                int n20 = randomizer.Next(234, 337);
                _picBoxBlock19.Location = new Point(743, n20);
            }
            if (_picBoxBlock20.Location.X < -82)
            {
                _picBoxBlock20.Location = new Point(743, 29);
                int n10 = randomizer.Next(30, 153);
                _picBoxBlock20.Size = new System.Drawing.Size(88, n10);
            }
        }

        private void FormOnKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                _picBoxSpaceShip.Location = new Point(_picBoxSpaceShip.Location.X, _picBoxSpaceShip.Location.Y - 5);
            }
        }

        private void Timer2Tick(object sender, EventArgs e)
        {
            _picBoxSpaceShip.Location = new Point(_picBoxSpaceShip.Location.X, _picBoxSpaceShip.Location.Y + 1);
            _score = _score + 1;
            _lblScore.Text = "Score : " + _score.ToString();
            if (_score > 2499)
            {
                _picBoxSpaceShip.Location = new Point(_picBoxSpaceShip.Location.X + 4, _picBoxSpaceShip.Location.Y);
                _timer.Enabled = false;
                if (_picBoxSpaceShip.Bounds.Contains(_picBoxBlock1.Location) || _picBoxSpaceShip.Bounds.Contains(_picBoxBlock2.Location) || _picBoxSpaceShip.Bounds.Contains(_picBoxBlock3.Location) || _picBoxSpaceShip.Bounds.Contains(_picBoxBlock4.Location) || _picBoxSpaceShip.Bounds.Contains(_picBoxBlock5.Location) || _picBoxSpaceShip.Bounds.Contains(_picBoxBlock6.Location) || _picBoxSpaceShip.Bounds.Contains(_picBoxBlock7.Location) || _picBoxSpaceShip.Bounds.Contains(_picBoxBlock8.Location) || _picBoxSpaceShip.Bounds.Contains(_picBoxBlock9.Location) || _picBoxSpaceShip.Bounds.Contains(_picBoxBlock19.Location))
                {
                    _view = 1;
                }
                if (_picBoxBlock1.Bounds.Contains(_picBoxSpaceShip.Location) || _picBoxBlock2.Bounds.Contains(_picBoxSpaceShip.Location) || _picBoxBlock3.Bounds.Contains(_picBoxSpaceShip.Location) || _picBoxBlock4.Bounds.Contains(_picBoxSpaceShip.Location) || _picBoxBlock5.Bounds.Contains(_picBoxSpaceShip.Location) || _picBoxBlock6.Bounds.Contains(_picBoxSpaceShip.Location) || _picBoxBlock7.Bounds.Contains(_picBoxSpaceShip.Location) || _picBoxBlock8.Bounds.Contains(_picBoxSpaceShip.Location) || _picBoxBlock9.Bounds.Contains(_picBoxSpaceShip.Location) || _picBoxBlock19.Bounds.Contains(_picBoxSpaceShip.Location))
                {
                    _view = 1;
                }
                if (_picBoxSpaceShip.Bounds.Contains(_picBoxBlock10.Location) || _picBoxSpaceShip.Bounds.Contains(_picBoxBlock11.Location) || _picBoxSpaceShip.Bounds.Contains(_picBoxBlock12.Location) || _picBoxSpaceShip.Bounds.Contains(_picBoxBlock13.Location) || _picBoxSpaceShip.Bounds.Contains(_picBoxBlock14.Location) || _picBoxSpaceShip.Bounds.Contains(_picBoxBlock15.Location) || _picBoxSpaceShip.Bounds.Contains(_picBoxBlock16.Location) || _picBoxSpaceShip.Bounds.Contains(_picBoxBlock17.Location) || _picBoxSpaceShip.Bounds.Contains(_picBoxBlock18.Location) || _picBoxSpaceShip.Bounds.Contains(_picBoxBlock20.Location))
                {
                    _view = 1;
                }
                if (_picBoxBlock10.Bounds.Contains(_picBoxSpaceShip.Location) || _picBoxBlock11.Bounds.Contains(_picBoxSpaceShip.Location) || _picBoxBlock12.Bounds.Contains(_picBoxSpaceShip.Location) || _picBoxBlock13.Bounds.Contains(_picBoxSpaceShip.Location) || _picBoxBlock14.Bounds.Contains(_picBoxSpaceShip.Location) || _picBoxBlock15.Bounds.Contains(_picBoxSpaceShip.Location) || _picBoxBlock16.Bounds.Contains(_picBoxSpaceShip.Location) || _picBoxBlock17.Bounds.Contains(_picBoxSpaceShip.Location) || _picBoxBlock18.Bounds.Contains(_picBoxSpaceShip.Location) || _picBoxBlock20.Bounds.Contains(_picBoxSpaceShip.Location))
                {
                    _view = 1;
                }
                if (_view == 1)
                {
                    _timer.Enabled = false;
                    _timer2.Enabled = false;
                    _picBoxStartButton.Visible = true;
                    _picBoxSpaceShip.Visible = false;
                    MessageBox.Show("You Lose! Your Score is" + _score.ToString());
                    _picBoxBlock1.Visible = false;
                    _picBoxBlock2.Visible = false;
                    _picBoxBlock3.Visible = false;
                    _picBoxBlock4.Visible = false;
                    _picBoxBlock5.Visible = false;
                    _picBoxBlock6.Visible = false;
                    _picBoxBlock7.Visible = false;
                    _picBoxBlock8.Visible = false;
                    _picBoxBlock9.Visible = false;
                    _picBoxBlock10.Visible = false;
                    _picBoxBlock11.Visible = false;
                    _picBoxBlock12.Visible = false;
                    _picBoxBlock13.Visible = false;
                    _picBoxBlock14.Visible = false;
                    _picBoxBlock15.Visible = false;
                    _picBoxBlock16.Visible = false;
                    _picBoxBlock17.Visible = false;
                    _picBoxBlock18.Visible = false;
                    _picBoxBlock19.Visible = false;
                    _picBoxBlock20.Visible = false;
                    _lblScore.Visible = false;
                    _picBoxSpaceShip.Location = new Point(144, 160);
                    _view = 0;
                    _score = 0;
                    _lblInstructions.Visible = true;
                    _picBoxBlock1.Location = new Point(0, 283);
                    _picBoxBlock2.Location = new Point(82, 283);
                    _picBoxBlock3.Location = new Point(167, 283);
                    _picBoxBlock4.Location = new Point(245, 283);
                    _picBoxBlock5.Location = new Point(329, 283);
                    _picBoxBlock6.Location = new Point(412, 283);
                    _picBoxBlock7.Location = new Point(496, 283);
                    _picBoxBlock8.Location = new Point(576, 283);
                    _picBoxBlock9.Location = new Point(659, 283);
                    _picBoxBlock10.Location = new Point(0, 29);
                    _picBoxBlock11.Location = new Point(82, 29);
                    _picBoxBlock12.Location = new Point(167, 29);
                    _picBoxBlock13.Location = new Point(245, 29);
                    _picBoxBlock14.Location = new Point(329, 29);
                    _picBoxBlock15.Location = new Point(412, 29);
                    _picBoxBlock16.Location = new Point(496, 29);
                    _picBoxBlock17.Location = new Point(576, 29);
                    _picBoxBlock18.Location = new Point(659, 29);
                    _picBoxBlock19.Location = new Point(743, 283);
                    _picBoxBlock20.Location = new Point(743, 29);
                }
                if (_picBoxSpaceShip.Location.X > 661)
                {
                    _timer2.Enabled = false;
                    _picBoxStartButton.Visible = true;
                    _picBoxSpaceShip.Visible = false;
                    _picBoxBlock1.Visible = false;
                    _picBoxBlock2.Visible = false;
                    _picBoxBlock3.Visible = false;
                    _picBoxBlock4.Visible = false;
                    _picBoxBlock5.Visible = false;
                    _picBoxBlock6.Visible = false;
                    _picBoxBlock7.Visible = false;
                    _picBoxBlock8.Visible = false;
                    _picBoxBlock9.Visible = false;
                    _picBoxBlock10.Visible = false;
                    _picBoxBlock11.Visible = false;
                    _picBoxBlock12.Visible = false;
                    _picBoxBlock13.Visible = false;
                    _picBoxBlock14.Visible = false;
                    _picBoxBlock15.Visible = false;
                    _picBoxBlock16.Visible = false;
                    _picBoxBlock17.Visible = false;
                    _picBoxBlock18.Visible = false;
                    _picBoxBlock19.Visible = false;
                    _picBoxBlock20.Visible = false;
                    _lblScore.Visible = false;
                    _picBoxSpaceShip.Location = new Point(144, 160);
                    _view = 0;
                    _score = 0;
                    _lblEndLabel.Visible = true;
                    _lblInstructions.Visible = true;
                    _picBoxBlock1.Location = new Point(0, 283);
                    _picBoxBlock2.Location = new Point(82, 283);
                    _picBoxBlock3.Location = new Point(167, 283);
                    _picBoxBlock4.Location = new Point(245, 283);
                    _picBoxBlock5.Location = new Point(329, 283);
                    _picBoxBlock6.Location = new Point(412, 283);
                    _picBoxBlock7.Location = new Point(496, 283);
                    _picBoxBlock8.Location = new Point(576, 283);
                    _picBoxBlock9.Location = new Point(659, 283);
                    _picBoxBlock10.Location = new Point(0, 29);
                    _picBoxBlock11.Location = new Point(82, 29);
                    _picBoxBlock12.Location = new Point(167, 29);
                    _picBoxBlock13.Location = new Point(245, 29);
                    _picBoxBlock14.Location = new Point(329, 29);
                    _picBoxBlock15.Location = new Point(412, 29);
                    _picBoxBlock16.Location = new Point(496, 29);
                    _picBoxBlock17.Location = new Point(576, 29);
                    _picBoxBlock18.Location = new Point(659, 29);
                    _picBoxBlock19.Location = new Point(743, 283);
                    _picBoxBlock20.Location = new Point(743, 29);

                }


            }
        }

        private void OnClickOptions(object sender, EventArgs e)
        {
            GameOptionsForm optionsForm = new GameOptionsForm(_game);

            //display the option form as a dialog and obtain the interaction result
            DialogResult optFormResult = optionsForm.ShowDialog();
        }
    }
}
