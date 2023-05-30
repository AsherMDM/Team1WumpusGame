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
    public partial class MainMenuForm : Form
    {
        Random random = new Random();
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            this.Hide();
            //GameControl gameControl = new GameControl();
            GameForm gameForm = new GameForm(random.Next(1, 5));//gameControl);
            gameForm.Show();
        }

        private void buttonCredits_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Game made by Team 'Won'\nMonica, Adeline, Asher, and Rayan\nSpecial thanks to Mr. Donnelly!", "Credits");
        }

        private void buttonExitGame_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
