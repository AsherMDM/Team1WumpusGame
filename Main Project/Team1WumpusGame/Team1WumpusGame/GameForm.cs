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
    public partial class GameForm : Form
    {


        private readonly GameControl gameControl;
        

        int movedLocation;
        public GameForm(GameControl gameControl)
        {
            this.gameControl = gameControl;
            InitializeComponent();
            labelCoins.Text = gameControl.passInventory()[1].ToString();
        }

        private void pictureBoxExit_Click(object sender, EventArgs e)
        {
            MainMenuForm form1 = new MainMenuForm();
            form1.Show();
            this.Close();
        }

        private void pictureBoxMoveRoom1_Click(object sender, EventArgs e)
        {
            this.gameControl.passNewLocation(int.Parse(labelRoom1.Text));
        }

        private void pictureBoxMoveRoom2_Click(object sender, EventArgs e)
        {
            this.gameControl.passNewLocation(int.Parse(labelRoom2.Text));
        }

        private void pictureBoxMoveRoom3_Click(object sender, EventArgs e)
        {
            this.gameControl.passNewLocation(int.Parse(labelRoom3.Text));
        }


        private void button1_Click(object sender, EventArgs e)
        {
            TriviaForm trivia = new TriviaForm();
            trivia.ShowDialog();
            this.Hide();
        }


        private void pictureBoxShootArrows_Click(object sender, EventArgs e)
        {
            int[] adjacentCaves = gameControl.passPossibleMoves();
            gameControl.ShootArrow(int.Parse(textBoxShootArrowLocation.Text), adjacentCaves, gameControl.passWumpusLocation());
        }

        private void pictureBoxBuyArrows_Click(object sender, EventArgs e)
        {
            ShopForm shop = new ShopForm();
            shop.ShowDialog();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            MainMenuForm form1 = new MainMenuForm();
            form1.Show();
            this.Close();
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            labelRoom1.Text = gameControl.passPossibleMoves()[0].ToString();
            labelRoom2.Text = gameControl.passPossibleMoves()[1].ToString();
            labelRoom3.Text = gameControl.passPossibleMoves()[2].ToString();
        }
    }
}
