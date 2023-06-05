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
using Team1WumpusGame.Properties;

namespace Team1WumpusGame
{
    public partial class GameForm : Form
    {
        // Create instances of classes
        private readonly GameControl gameControl;
        Player player = new Player();
        GameLocations gameLocations = new GameLocations();

        // random var for bats (see bottom)
        Random rnd = new Random();

        // cave system (1-5)
        int cavesystem;
        
        public GameForm(int cs)
        {
            // create game control instance and determine which cave system
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

        public void ChangeUI()
        {
            // update the ui depending on location
            int pl = gameControl.passPlayerLocation();
            int wump = gameControl.passWumpusLocation();
            int[] bat = gameControl.passBatLocations();
            int[] pit = gameControl.passPitLocations();
            int ui = 4;

            // shows wumpus
            if (pl == wump)
            {
                ui = 1;
            }

            // shows bats
            foreach (int i in bat)
            {
                if (pl == i)
                {
                    ui = 2;
                }
            }

            // shows pits
            foreach (int e in pit)
            {
                if (pl == e)
                {
                    ui = 3;
                }
            }

             
            if (ui == 1)
            {
                pictureBoxGame.Image = Resources.wumpuscave1;   
            }
            else if (ui == 2)
            {
                pictureBoxGame.Image = Resources.batcave1;
            }
            else if (ui == 3)
            {
                pictureBoxGame.Image = Resources.pitcave1;
            }
            else
            {
                // if there is no hazards to be seen
                ui = rnd.Next(4, 7);

                if (ui == 4)
                {
                    pictureBoxGame.Image = Resources.emptycave1;
                }

                if (ui == 5)
                {
                    pictureBoxGame.Image = Resources.emptycave2;
                }

                if (ui == 6)
                {
                    pictureBoxGame.Image = Resources.emptycave3;
                }
            }
            
        }

        private void ShowHazards()
        {
            // pass wumpus, pit, bat locations 
            int[] possMoves = gameControl.passPossibleMoves(gameControl.passPlayerLocation());
            int wumpusLoc = gameControl.passWumpusLocation();
            int[] batLocs = gameControl.passBatLocations();
            int[] pitLocs = gameControl.passPitLocations();

            //determine wumpus
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
            
            // determine bats
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

            // determine pits
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

        public void OutOfArrows()
        {
            // no arrows
            int score = gameControl.CalculateScore(false);
            MessageBox.Show("You ran out of arrows! Game Over!" + "\n" + "Your score: " + score);
            GoToMain();
        }

        public void OutOfCoins()
        {
            // if you run out of coins
            int score = gameControl.CalculateScore(false);
            MessageBox.Show("You ran out of coins! Game Over!" + "\n" + "Your score: " + score);
            GoToMain();
        }

        public void UpdateAll(int newMove)
        {
            
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

            // update current room
            labelCurrentRoom.Text = newMove.ToString();

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
            ChangeUI();

            // see if you are dead
            if (areYouDead(newMove))
            {
                int score = gameControl.CalculateScore(false);
                MessageBox.Show("You died!" + "\n" + "Your score: " + score);
                GoToMain();
            }

            UpdateAll(newMove);

            // if there are bats move to random room
            if (bats(newMove))
            {
                MessageBox.Show("You ran into bats!");
                Random random = new Random();
                int newNumber = random.Next(1, 31);
                player.MovePlayer(newNumber);
                UpdateAll(newNumber);
            }


        }

        private void pictureBoxMoveRoom2_Click(object sender, EventArgs e)
        {
            // move player to new cave
            int newMove = int.Parse(labelRoom2.Text);
            this.gameControl.passNewLocation(newMove);
            ChangeUI();

            // see if you are dead
            if (areYouDead(newMove))
            {
                int score = gameControl.CalculateScore(false);
                MessageBox.Show("You died!" + "\n" + "Your score: " + score);
                GoToMain();
            }

            UpdateAll(newMove);

            // if there are bats move to random room
            if (bats(newMove))
            {
                MessageBox.Show("You ran into bats!");
                Random random = new Random();
                int newNumber = random.Next(1, 31);
                player.MovePlayer(newNumber);
                UpdateAll(newNumber);
            }

            
        }

        private void pictureBoxMoveRoom3_Click(object sender, EventArgs e)
        {
            // move player to new cave
            try
            {
                int newMove = int.Parse(labelRoom3.Text);
                this.gameControl.passNewLocation(newMove);
                ChangeUI();

                // see if you are dead
                if (areYouDead(newMove))
                {
                    int score = gameControl.CalculateScore(false);
                    MessageBox.Show("You died!" + "\n" + "Your score: " + score);
                    GoToMain();
                }

                UpdateAll(newMove);

                // if there are bats move to random room
                if (bats(newMove))
                {
                    MessageBox.Show("You ran into bats!");
                    Random random = new Random();
                    int newNumber = random.Next(1, 31);
                    player.MovePlayer(newNumber);
                    UpdateAll(newNumber);
                }

            }
            catch
            {
                //do nothing if there is no third cave
            }

            ShowHazards();
        }

        // go back to main menu method
        public void GoToMain()
        {
            this.Close();
            MainMenuForm mainMenuForm = new MainMenuForm();
            mainMenuForm.Show();
        }

        // shoot arrow method
        private void pictureBoxShootArrows_Click(object sender, EventArgs e)
        {
            // Shoot the arrow into the user-input location from textbox
            int[] adjacentCaves = gameControl.passPossibleMoves(cavesystem);
            int wumpusLoc = gameControl.passWumpusLocation();

            try
            {
                int location = int.Parse(textBoxShootArrowLocation.Text);
                int shootArrow = gameControl.ShootArrow(location, adjacentCaves, wumpusLoc);
                // check to see there are a valid amount of arrows first
                if (gameControl.passInventory()[0] > 0)
                {
                    if (shootArrow == 1) // Win
                    {
                        
                        gameControl.AddArrows(-1);
                        UpdateInventory();
                        int score = gameControl.CalculateScore(true);
                        MessageBox.Show("You Win!" + "\n" + "Your Score: " + score);
                        GoToMain();
                    }
                    else if (shootArrow == 0) // Missed the wumpus
                    {
                        gameControl.AddArrows(-1);
                        UpdateInventory();

                        // lose game if you ran out of arrows
                        if (gameControl.passInventory()[0] == 0)
                        {
                            OutOfArrows();
                        }

                        MessageBox.Show("You Missed!");
                        gameControl.MoveWumpus();
                        ShowHazards();
                    }
                    else if (shootArrow == 2) // If shot in invalid location
                    {
                        MessageBox.Show("You Can't Shoot There!");
                    }
                    else
                    {
                        MessageBox.Show("BIG ERROR");
                    }

                }
                else
                {
                    MessageBox.Show("You don't have enough arrows for that!");
                    OutOfArrows();
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
            // determines if you die from running into wumpus or pit

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

        // when you run into bats, puts you in new location
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
