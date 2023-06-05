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
        
        public GameForm(int cs)
        {
            this.gameControl = new GameControl();
            cavesystem = cs;
            InitializeComponent();
            // Display current coins
            labelCoins.Text = gameControl.passInventory()[1].ToString();
            labelArrows.Text = gameControl.passInventory()[0].ToString();
            // generate hazards
            gameControl.GenerateWumpusLocation();
            gameControl.GenerateBatLocations();
            gameControl.GeneratePitLocations();
            ShowHazards();
        }

        private void ShowHazards()
        {
            // pass wumpus, pit, bat locations 
            int[] possMoves = gameControl.passPossibleMoves(gameControl.passPlayerLocation());
            int wumpusLoc = gameControl.passWumpusLocation();
            int[] batLocs = gameControl.passBatLocations();
            int[] pitLocs = gameControl.passPitLocations();


            if (possMoves[0] == wumpusLoc ||
                possMoves[1] == wumpusLoc ||
                possMoves[2] == wumpusLoc)
            {
                labelWumpusWarning.Visible = true;
            }
            else
            {
                labelWumpusWarning.Visible = false;
            }
            
            if (possMoves[0] == batLocs[0] ||
                possMoves[1] == batLocs[0] ||
                possMoves[2] == batLocs[0] ||
                possMoves[0] == batLocs[1] ||
                possMoves[1] == batLocs[1] ||
                possMoves[2] == batLocs[1] ||
                possMoves[0] == batLocs[2] ||
                possMoves[1] == batLocs[2] ||
                possMoves[2] == batLocs[2])
            {
                labelBatWarning.Visible = true;
            }
            else
            {
                labelBatWarning.Visible = false;
            }

            if (possMoves[0] == pitLocs[0] ||
                possMoves[1] == pitLocs[0] ||
                possMoves[2] == pitLocs[0] ||
                possMoves[0] == pitLocs[1] ||
                possMoves[1] == pitLocs[1] ||
                possMoves[2] == pitLocs[1] ||
                possMoves[0] == pitLocs[2] ||
                possMoves[1] == pitLocs[2] ||
                possMoves[2] == pitLocs[2])
            {
                labelPitWarning.Visible = true;
            }
            else
            {
                labelPitWarning.Visible = false;
            }

        }
        public void UpdateInventory()
        {
            // update the inventory
            labelCoins.Text = gameControl.passInventory()[1].ToString();
            labelArrows.Text = gameControl.passInventory()[0].ToString();
        }

        public void UpdateAll(int newMove)
        {
            // update current room
            labelCurrentRoom.Text = newMove.ToString();

            // update the new moves
            int[] possMoves = this.gameControl.passPossibleMoves(newMove);
            labelRoom1.Text = possMoves[0].ToString();
            labelRoom2.Text = possMoves[1].ToString();
            try
            {
                labelRoom3.Text = possMoves[2].ToString();
            }
            catch
            {
                // if there is no third move possible blank out the label
                labelRoom3.Text = "";
            }

            // update coins
            int newCoins = 1;
            labelCoins.Text = this.gameControl.AddCoins(newCoins).ToString();

            ShowHazards();
        }

        private void pictureBoxMoveRoom1_Click(object sender, EventArgs e)
        {
            // move player to new cave
            int newMove = int.Parse(labelRoom1.Text);
            this.gameControl.passNewLocation(newMove);

            // see if you are dead
            if (areYouDead(newMove))
            {
                int score = gameControl.CalculateScore(false);
                MessageBox.Show("You died!" + "\n" + "Your score: " + score);
                GoToMain();
            }

            // if there are bats move to random room
            if (bats(newMove))
            {
                Random random = new Random();
                int newNumber = random.Next(1, 30);
                player.MovePlayer(newNumber);
            }

            UpdateAll(newMove);

        }

        private void pictureBoxMoveRoom2_Click(object sender, EventArgs e)
        {
            // move player to new cave
            int newMove = int.Parse(labelRoom2.Text);
            this.gameControl.passNewLocation(newMove);

            // see if you are dead
            if (areYouDead(newMove))
            {
                int score = gameControl.CalculateScore(false);
                MessageBox.Show("You died!" + "\n" + "Your score: " + score);
                GoToMain();
            }

            // if there are bats move to random room
            if (bats(newMove))
            {
                Random random = new Random();
                int newNumber = random.Next(1, 30);
                player.MovePlayer(newNumber);
            }

            UpdateAll(newMove);
        }

        private void pictureBoxMoveRoom3_Click(object sender, EventArgs e)
        {
            // move player to new cave
            try
            {
                int newMove = int.Parse(labelRoom3.Text);
                this.gameControl.passNewLocation(newMove);

                // see if you are dead
                if (areYouDead(newMove))
                {
                    int score = gameControl.CalculateScore(false);
                    MessageBox.Show("You died!" + "\n" + "Your score: " + score);
                    GoToMain();
                }

                // if there are bats move to random room
                if (bats(newMove))
                {
                    Random random = new Random();
                    int newNumber = random.Next(1, 30);
                    player.MovePlayer(newNumber);
                }

                UpdateAll(newMove);
            }
            catch
            {
                //do nothing if there is no third cave
            }

            ShowHazards();
        }

        public void GoToMain()
        {
            this.Close();
            MainMenuForm mainMenuForm = new MainMenuForm();
            mainMenuForm.Show();
        }

        private void pictureBoxShootArrows_Click(object sender, EventArgs e)
        {
            // Shoot the arrow into the user-input location from textbox
            int[] adjacentCaves = gameControl.passPossibleMoves(cavesystem);
            int location = int.Parse(textBoxShootArrowLocation.Text);
            int wumpusLoc = gameControl.passWumpusLocation();

            // check to see there are a valid amount of arrows first
            if (gameControl.passInventory()[0] > 0)
            {
                try
                {
                    if (gameControl.ShootArrow(location, adjacentCaves, gameControl.passWumpusLocation()) == 1)
                    {
                        //Win
                        gameControl.AddArrows(-1);
                        UpdateInventory();
                        int score = gameControl.CalculateScore(true);
                        MessageBox.Show("You Win!" + "\n" + "Your Score: " + score);
                        GoToMain();
                    }
                    else if (gameControl.ShootArrow(location, adjacentCaves, gameControl.passWumpusLocation()) == 0)
                    {
                        // Missed the wumpus
                        gameControl.AddArrows(-1);
                        UpdateInventory();
                        MessageBox.Show("You Missed!");
                        
                    }
                    else if (gameControl.ShootArrow(location, adjacentCaves, gameControl.passWumpusLocation()) == 2)
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
            else
            {
                MessageBox.Show("You don't have enough arrows for that!");
            }
            
        }

        private void pictureBoxBuyArrows_Click(object sender, EventArgs e)
        {
            // Open shop form to buy arrows
            ShopForm shop = new ShopForm(this.gameControl);
            shop.ShowDialog();
            labelCoins.Text = this.gameControl.passInventory()[1].ToString();
            labelArrows.Text = this.gameControl.passInventory()[0].ToString();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to quit?", "", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                // Closes down the form, takes you back to the main menu
                GoToMain();
            }
            else
            {

                // brings you back to game form
            }

        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            // Get possible moves for current cave
            int[] possiblemoves = gameControl.passPossibleMoves(cavesystem);
            // Display possible moves to label
            labelRoom1.Text = possiblemoves[0].ToString();
            labelRoom2.Text = possiblemoves[1].ToString();
            labelRoom3.Text = possiblemoves[2].ToString();
            ShowHazards();
        }

        public bool areYouDead(int newMove)
        {
            if (newMove == gameControl.passWumpusLocation())
            {
                return true;
            }

            if (newMove == gameControl.passPitLocations()[0] || 
                newMove == gameControl.passPitLocations()[1] ||
                newMove == gameControl.passPitLocations()[2])
            {
                return true;
            }
            
            return false;
        }

        public bool bats(int newMove)
        {
            if (newMove == gameControl.passBatLocations()[0] ||
                newMove == gameControl.passBatLocations()[1] ||
                newMove == gameControl.passBatLocations()[2])
            {
                return true;
            }
            return false;
        }

    }
}
