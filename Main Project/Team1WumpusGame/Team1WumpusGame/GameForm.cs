using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Team1WumpusGame
{
    public partial class GameForm : Form
    {
        // Create instances of classes
        private readonly GameControl gameControl;
        Player player = new Player();
        GameLocations gameLocations = new GameLocations();

        int cavesystem;
        public GameForm(int cs)//GameControl gameControl)
        {
            this.gameControl = new GameControl();
            cavesystem = cs;
            InitializeComponent();
            // Display current coins
            labelCoins.Text = gameControl.passInventory()[1].ToString();
        }

        public int CaveSystemReturn()
        {
            return cavesystem;
        }
        private void pictureBoxExit_Click(object sender, EventArgs e)
        {
            // Close this form and return back to the main menu
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
            // Shoot the arrow into the user-input location from textbox
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
                    // Missed the wumpus
                    MessageBox.Show("You Missed!");
                }
                else if (gameControl.ShootArrow(int.Parse(textBoxShootArrowLocation.Text), adjacentCaves, gameControl.passWumpusLocation()) == 2)
                {
                    // If shot in invalid location
                    MessageBox.Show("You Can't Shoot There!");
                }
                else
                {
                    MessageBox.Show("BIG ERROR");
                }
            }
            catch
            {
                // If shot in invalid location
                MessageBox.Show("You Can't Shoot There!");
            }
            
        }

        private void pictureBoxBuyArrows_Click(object sender, EventArgs e)
        {
            // Open shop form to buy arrows
            ShopForm shop = new ShopForm();
            shop.ShowDialog();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            // Closes down the form, takes you back to the main menu
            this.Close();
            MainMenuForm mainMenuForm = new MainMenuForm();
            mainMenuForm.Show();
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            // Get possible moves for current cave
            int[] possiblemoves = gameControl.passPossibleMoves(CaveSystemReturn());
            // Display possible moves to label
            labelRoom1.Text = possiblemoves[0].ToString();
            labelRoom2.Text = possiblemoves[1].ToString();
            labelRoom3.Text = possiblemoves[2].ToString();            

            // Generate danger locations
            gameLocations.GenerateBatLocations();
            gameLocations.GeneratePitLocations();
            gameLocations.GenerateWumpusLocation();

            // Generate warnings based on generated danger locations
            labelBatWarning.Visible = gameLocations.findAdjacentHazards(gameControl.passPossibleMoves(CaveSystemReturn()))[0];
            labelPitWarning.Visible = gameLocations.findAdjacentHazards(gameControl.passPossibleMoves(CaveSystemReturn()))[1];
            labelWumpusWarning.Visible = gameLocations.findAdjacentHazards(gameControl.passPossibleMoves(CaveSystemReturn()))[2];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[] possiblemoves = gameControl.passPossibleMoves(CaveSystemReturn());
            labelRoom1.Text = possiblemoves[0].ToString();
            labelRoom2.Text = possiblemoves[1].ToString();
            labelRoom3.Text = possiblemoves[2].ToString();

            gameLocations.GenerateBatLocations();
            gameLocations.GeneratePitLocations();
            gameLocations.GenerateWumpusLocation();

            labelBatWarning.Visible = gameLocations.findAdjacentHazards(gameControl.passPossibleMoves(CaveSystemReturn()))[0];
            labelPitWarning.Visible = gameLocations.findAdjacentHazards(gameControl.passPossibleMoves(CaveSystemReturn()))[1];
            labelWumpusWarning.Visible = gameLocations.findAdjacentHazards(gameControl.passPossibleMoves(CaveSystemReturn()))[2];
        }

        public bool areYouDead()
        {
            this.gameControl.passNewLocation(int.Parse(labelRoom1.Text));
            string filename = "5";
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
            else if (CaveSystemReturn() == 5)
            {
                filename = "1";
            }



            if (gameControl.passWumpusLocation() == gameControl.passAdjacentCaves(filename)[0]|| 
                gameControl.passWumpusLocation() == gameControl.passAdjacentCaves(filename)[1])
            {
                if(gameControl.passPlayerLocation() == gameControl.passWumpusLocation())
                {
                    return true;
                }
            }

            
            if(gameControl.passPitLocations() == gameControl.passAdjacentCaves(filename))
            {
                foreach (int pit in gameControl.passPitLocations())
                {
                    if(pit == gameControl.passPlayerLocation())
                    {
                        return true;
                    }
                }
            }
            return false;


        }

        private void labelBatWarning_Click(object sender, EventArgs e)
        {

        }

        private void labelWumpusWarning_Click(object sender, EventArgs e)
        {

        }
    }
}
