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
            labelArrows.Text = gameControl.passInventory()[0].ToString();
            // generate hazards
            gameLocations.GenerateWumpusLocation();
            gameLocations.GenerateBatLocations();
            gameLocations.GeneratePitLocations();
            ShowHazards();
        }

        private void ShowHazards()
        {
            string filename = "";
            if (cavesystem == 1)
            {
                filename = "1";
            }
            else if (cavesystem == 2)
            {
                filename = "2";
            }
            else if (cavesystem == 3)
            {
                filename = "3";
            }
            else if (cavesystem == 4)
            {
                filename = "4";
            }
            else if (cavesystem == 5)
            {
                filename = "5";
            }

            labelWumpusWarning.Visible = (gameControl.passWumpusLocation() == gameControl.passAdjacentCaves(filename)[0] || 
                gameControl.passWumpusLocation() == gameControl.passAdjacentCaves(filename)[1] ||
                gameControl.passWumpusLocation() == gameControl.passAdjacentCaves(filename)[2]);

            labelPitWarning.Visible = (gameControl.passPitLocations() == gameControl.passAdjacentCaves(filename));

            labelBatWarning.Visible = (gameControl.passBatLocations() == gameControl.passAdjacentCaves(filename));
        }
        public void UpdateInventory()
        {
            // update the inventory
            labelCoins.Text = gameControl.passInventory()[1].ToString();
            labelArrows.Text = gameControl.passInventory()[0].ToString();
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
            // move player to new cave
            int newMove = int.Parse(labelRoom1.Text);
            this.gameControl.passNewLocation(newMove);

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

        private void pictureBoxMoveRoom2_Click(object sender, EventArgs e)
        {
            // move player to new cave
            int newMove = int.Parse(labelRoom2.Text);
            this.gameControl.passNewLocation(newMove);

            // update current room
            labelCurrentRoom.Text = newMove.ToString();

            //update possible moves
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

        private void pictureBoxMoveRoom3_Click(object sender, EventArgs e)
        {
            // move player to new cave
            try
            {
                int newMove = int.Parse(labelRoom3.Text);
                this.gameControl.passNewLocation(newMove);

                // update current room
                labelCurrentRoom.Text = newMove.ToString();

                // update possible moves
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
            }
            catch
            {
                //do nothing if there is no third cave
            }

            ShowHazards();
        }




        private void pictureBoxShootArrows_Click(object sender, EventArgs e)
        {
            // Shoot the arrow into the user-input location from textbox
            int[] adjacentCaves = gameControl.passPossibleMoves(CaveSystemReturn());
            
            // check to see there are a valid amount of arrows first
            if (gameControl.passInventory()[0] > 0)
            {
                try
                {
                    if (gameControl.ShootArrow(int.Parse(textBoxShootArrowLocation.Text), adjacentCaves, gameControl.passWumpusLocation()) == 1)
                    {
                        //Win
                        gameControl.AddArrows(-1);
                        player.CalculateScore(true);
                        MessageBox.Show("You Win!");
                        
                    }
                    else if (gameControl.ShootArrow(int.Parse(textBoxShootArrowLocation.Text), adjacentCaves, gameControl.passWumpusLocation()) == 0)
                    {
                        // Missed the wumpus
                        gameControl.AddArrows(-1);
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
            DialogResult result = MessageBox.Show("Are you sure you want to quit?", ".", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                // Closes down the form, takes you back to the main menu
                this.Close();

                MainMenuForm mainMenuForm = new MainMenuForm();
                mainMenuForm.Show();
            }
            else
            {

                // brings you back to game form
            }

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

        public bool bats()
        {
            string filename = "5";
            if (CaveSystemReturn() == 1)
            {
                filename = "";
            }
            else if (CaveSystemReturn() == 2)
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
            if (gameControl.passBatLocations() == gameControl.passAdjacentCaves(filename))
            {
                Random random = new Random();
                int newNumber = random.Next(1, 30);
                player.MovePlayer(newNumber);
            }
            return false;
        }

    }
}
