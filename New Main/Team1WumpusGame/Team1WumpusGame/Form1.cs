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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            GameForm gameForm = new GameForm();
            gameForm.ShowDialog();
        }

        private void buttonCredits_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Game made by Team 'Won'" + "\n" + "Monica, Adeline, Asher, and Rayan" + "\n" + "Special thanks to Mr. Donnelly!");
        }

        private void buttonExitGame_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
