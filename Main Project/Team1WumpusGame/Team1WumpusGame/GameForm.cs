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

        GameControl gameControl = new GameControl();

        int movedLocation;
        public GameForm()
        {
            InitializeComponent();
        }

        private void pictureBoxExit_Click(object sender, EventArgs e)
        {
            MainMenuForm form1 = new MainMenuForm();
            form1.Show();
            this.Close();
        }

        private void pictureBoxMoveRoom1_Click(object sender, EventArgs e)
        {
            movedLocation = int.Parse(labelRoom1.Text);
        }

        private void pictureBoxMoveRoom2_Click(object sender, EventArgs e)
        {
            movedLocation = int.Parse(labelRoom2.Text);
        }

        private void pictureBoxMoveRoom3_Click(object sender, EventArgs e)
        {
            movedLocation = int.Parse(labelRoom3.Text);
        }

        public int movingLocation()
        {

                return movedLocation;
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TriviaForm trivia = new TriviaForm();
            trivia.ShowDialog();
            this.Hide();
        }

        private void pictureBoxShootArrows_Click(object sender, EventArgs e)
        {
            
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
    }
}
