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
<<<<<<< HEAD
<<<<<<< HEAD
        Player player = new Player();
        Cave cave = new Cave();
        GameControl gameControl = new GameControl();    
=======

        GameControl gameControl = new GameControl();

>>>>>>> 8da03975f36d3b6ed84d23846a34a9a589d84fda
=======

        GameControl gameControl = new GameControl();

>>>>>>> 8da03975f36d3b6ed84d23846a34a9a589d84fda
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
<<<<<<< HEAD
<<<<<<< HEAD
            //player.ShootArrow(,gameControl.passPossibleMoves(),gameControl.passWumpusLocation());

=======
            
>>>>>>> 8da03975f36d3b6ed84d23846a34a9a589d84fda
=======
            
>>>>>>> 8da03975f36d3b6ed84d23846a34a9a589d84fda
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

        private void GameForm_Load(object sender, EventArgs e)
        {

        }
    }
}
