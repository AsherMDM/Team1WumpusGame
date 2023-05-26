using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Team1WumpusGame
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void SplashScreen_Activated(object sender, EventArgs e)
        {
            timerSplashScreen.Enabled = true;
            
        }

        private void timerSplashScreen_Tick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
