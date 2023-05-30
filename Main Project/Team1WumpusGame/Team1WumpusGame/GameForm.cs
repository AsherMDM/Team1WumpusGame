using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Team1WumpusGame
{
    public partial class GameForm : Form
    {
        private readonly GameControl gameControl;
        Player player = new Player();
        GameLocations gameLocations = new GameLocations();

        int cavesystem;
        public GameForm(int cs)//GameControl gameControl)
        {
            this.gameControl = new GameControl();
            cavesystem = cs;
            InitializeComponent();
            labelCoins.Text = gameControl.passInventory()[1].ToString();
        }

        public int CaveSystemReturn()
        {
            return cavesystem;
        }
        private void pictureBoxExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBoxMoveRoom1_Click(object sender, EventArgs e)
        {


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
            
            int[] adjacentCaves = gameControl.passPossibleMoves(CaveSystemReturn());
            try
            {
                if (gameControl.ShootArrow(int.Parse(textBoxShootArrowLocation.Text), adjacentCaves, gameControl.passWumpusLocation()) == 1)
                {
                    //Win
                    player.CalculateScore(true);
                    MessageBox.Show("You Win!");
                }
                else if (gameControl.ShootArrow(int.Parse(textBoxShootArrowLocation.Text), adjacentCaves, gameControl.passWumpusLocation()) == 0)
                {
                    MessageBox.Show("You Missed!");
                }
                else if (gameControl.ShootArrow(int.Parse(textBoxShootArrowLocation.Text), adjacentCaves, gameControl.passWumpusLocation()) == 2)
                {
                    MessageBox.Show("You Can't Shoot There!");
                }
                else
                {
                    MessageBox.Show("BIG ERROR");
                }
            }
            catch
            {
                MessageBox.Show("No");
            }
            
        }

        private void pictureBoxBuyArrows_Click(object sender, EventArgs e)
        {
            ShopForm shop = new ShopForm();
            shop.ShowDialog();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            int[] possiblemoves = gameControl.passPossibleMoves(CaveSystemReturn());
            labelRoom1.Text = possiblemoves[0].ToString();
            labelRoom2.Text = possiblemoves[1].ToString();
            try
            {
                labelRoom3.Text = possiblemoves[2].ToString();
            }
            catch
            {
                labelRoom3.Text = "error";
            }

            gameLocations.GenerateBatLocations();
            gameLocations.GeneratePitLocations();
            gameLocations.GenerateWumpusLocation();

            labelBatWarning.Visible = gameLocations.findAdjacentHazards(gameControl.passPossibleMoves(CaveSystemReturn()))[0];
            labelPitWarning.Visible = gameLocations.findAdjacentHazards(gameControl.passPossibleMoves(CaveSystemReturn()))[1];
            labelWumpusWarning.Visible = gameLocations.findAdjacentHazards(gameControl.passPossibleMoves(CaveSystemReturn()))[2];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[] possiblemoves = gameControl.passPossibleMoves(CaveSystemReturn());
            labelRoom1.Text = possiblemoves[0].ToString();
            labelRoom2.Text = possiblemoves[1].ToString();
            try
            {
                labelRoom3.Text = possiblemoves[2].ToString();
            }
            catch
            {
                labelRoom3.Text = "error";
            }

            gameLocations.GenerateBatLocations();
            gameLocations.GeneratePitLocations();
            gameLocations.GenerateWumpusLocation();

            labelBatWarning.Visible = gameLocations.findAdjacentHazards(gameControl.passPossibleMoves(CaveSystemReturn()))[0];
            labelPitWarning.Visible = gameLocations.findAdjacentHazards(gameControl.passPossibleMoves(CaveSystemReturn()))[1];
            labelWumpusWarning.Visible = gameLocations.findAdjacentHazards(gameControl.passPossibleMoves(CaveSystemReturn()))[2];
        }

        public void areYouDead()
        {
            this.gameControl.passNewLocation(int.Parse(labelRoom1.Text));
            string filename;
            if(CaveSystemReturn() == 1)
            {
                filename = "";
            }
            else if(CaveSystemReturn() == 2)
            {
                filename = "2";
            }
            else if (CaveSystemReturn() == 3)
            {
                filename = "3";
            }
            else if (CaveSystemReturn() == 4)
            {
                filename = "4";
            }
            else if (CaveSystemReturn() == 1)
            {
                filename = "1";
            }
            //if (gameControl.passWumpusLocation() == gameLocations.findAdjacentHazards())
            //{

            //}

            //figure that out too
        }
    }
}
