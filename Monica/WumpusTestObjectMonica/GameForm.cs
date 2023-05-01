using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WumpusTestObjectMonica
{
    public partial class GameForm : Form
    {
        public GameForm()
        {
            InitializeComponent();
            // call pretty much all the other objects to get info to start game; current cave, connected rooms, inventory, etc
        }

        private void buttonShootArrows_Click(object sender, EventArgs e)
        {
            // will shoot the arrows into the selected room, will prompt another box asking which room to shoot arrows into
            // calls player object to see how many arrows are in the inventory and to subtract one when shooting arrow
            
        }

        private void buttonBuyArrows_Click(object sender, EventArgs e)
        {
            // calls trivia object and loads trivia screen, if successful update player inventory in player object
            
        }

        private void buttonCave1_Click(object sender, EventArgs e)
        {
            // call gamelocations and game control, move player to connected cave to button
            // call cave object to display new connected caves to current one, update current cave label
            // call player object to update player inventory (coins)
        }

        private void buttonCave2_Click(object sender, EventArgs e)
        {
            // same as the other cave button

        }

        private void buttonCave3_Click(object sender, EventArgs e)
        {
            // same as the other cave button
        }
        
    }
}
