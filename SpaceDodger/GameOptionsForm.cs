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

       
    }
}