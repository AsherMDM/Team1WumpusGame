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
        GameControl gameControl = new GameControl();


        public ShopForm()
        {
            InitializeComponent();
            
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonBuyArrows_Click(object sender, EventArgs e)
        {
            // 
            int newArrows = int.Parse(textBoxArrowsBought.Text);
            int price = -3 * newArrows;
            if(price > gameControl.passInventory()[1])
            {
                MessageBox.Show("You do not have enough coins to buy that many arrows.");
            }
            else
            {
                gameControl.AddCoins(price);
                gameControl.AddArrows(newArrows);
                TriviaForm triviaForm = new TriviaForm();
                triviaForm.Show();
            }
        }

        private void textBoxArrowsBought_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelCoins_Click(object sender, EventArgs e)
        {

        }

        private void ShopForm_Load(object sender, EventArgs e)
        {

            labelCoins.Text = gameControl.passInventory()[1].ToString();
            labelArrows.Text = gameControl.passInventory()[0].ToString();
            
        }
    }
}
