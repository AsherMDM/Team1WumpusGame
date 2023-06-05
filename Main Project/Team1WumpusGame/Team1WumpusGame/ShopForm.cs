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
    public partial class ShopForm : Form
    {
        // Create new instance of game control class
        GameControl gameControl; 

        public ShopForm(GameControl gC)
        {
            InitializeComponent();
            gameControl = gC;
            labelArrows.Text = gameControl.passInventory()[0].ToString();
            labelCoins.Text = gameControl.passInventory()[1].ToString();
            
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void buttonBuyArrows_Click(object sender, EventArgs e)
        {
            // buy arrows method

            int newArrows = 0;

            try
            {
                // see how many arrows user wants
                newArrows = int.Parse(textBoxArrowsBought.Text);

                // calculate arrow price
                int price = -3 * newArrows;
                if (Math.Abs(price) > gameControl.passInventory()[1])
                {
                    MessageBox.Show("You do not have enough coins to buy that many arrows.", "Sorry...");
                    
                }
                else
                {
                    TriviaForm triviaForm = new TriviaForm(this.gameControl, newArrows);
                    triviaForm.ShowDialog();
                }
            }
            catch
            {
                MessageBox.Show("Invalid response", "Error");
                return;
            }

            // update labels & inventory
            labelCoins.Text = gameControl.passInventory()[1].ToString();
            labelArrows.Text = gameControl.passInventory()[0].ToString();
        }

        private void textBoxArrowsBought_TextChanged(object sender, EventArgs e)
        {
            // display coin cost to label
            try
            {
                int newArrows = int.Parse(textBoxArrowsBought.Text);
                int price = 3 * newArrows;
                labelCoinCost.Text = price.ToString();
            }
            catch
            {
                // if there is nothing valid in the textbox display a price of 0 coins
                labelCoinCost.Text = "0";
            }
           
        }

        private void ShopForm_Leave(object sender, EventArgs e)
        {

        }

        private void ShopForm_Activated(object sender, EventArgs e)
        {
            labelCoins.Text = gameControl.passInventory()[1].ToString();
            labelArrows.Text = gameControl.passInventory()[0].ToString();
        }


    }
}
