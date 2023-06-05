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

        // starts the game and opens new game form
        private void buttonStart_Click(object sender, EventArgs e)
        {
            this.Hide();
            
            // chooses which map to use and starts game
            GameForm gameForm = new GameForm(random.Next(1, 5));
            gameForm.Show();
        }

        // shows the credits
        private void buttonCredits_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Game made by Team 'Won'\nMonica, Adeline, Asher, and Rayan\nThanks to Mr.Donnelly for saving our mental state (barely)", "Credits");
        }

        // fully closes the game
        private void buttonExitGame_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
