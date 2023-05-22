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
            gameControl.AddCoins(-3);
            gameControl.AddArrows(1);
            TriviaForm triviaForm = new TriviaForm();   
            triviaForm.Show();
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
