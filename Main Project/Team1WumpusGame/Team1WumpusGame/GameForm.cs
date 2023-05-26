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
        Player player = new Player();
        GameLocations gameLocations = new GameLocations();
        
        public GameForm()//GameControl gameControl)
        {
            this.gameControl = new GameControl();
            InitializeComponent();
            labelCoins.Text = gameControl.passInventory()[1].ToString();
        }

        public int CaveSystemReturn()
        {
            Random random = new Random();
            int i = random.Next(1, 5);
            return i;
        }
        private void pictureBoxExit_Click(object sender, EventArgs e)
        {
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
            this.Close();
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            labelRoom1.Text = gameControl.passPossibleMoves(CaveSystemReturn())[0].ToString();
            labelRoom2.Text = gameControl.passPossibleMoves(CaveSystemReturn())[1].ToString();
            try
            {
                labelRoom3.Text = gameControl.passPossibleMoves(CaveSystemReturn())[2].ToString();
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
            labelRoom1.Text = gameControl.passPossibleMoves(CaveSystemReturn())[0].ToString();
            labelRoom2.Text = gameControl.passPossibleMoves(CaveSystemReturn())[1].ToString();
            try
            {
                labelRoom3.Text = gameControl.passPossibleMoves(CaveSystemReturn())[2].ToString();
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
    }
}
