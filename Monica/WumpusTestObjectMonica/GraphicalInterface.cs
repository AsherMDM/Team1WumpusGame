using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WumpusTestObjectMonica
{
    internal class GraphicalInterface
    {
        public GraphicalInterface()
        {
            
        }

        // call gamecontrol & player object to get number of arrows
        public void DisplayArrows()
        {
            int arrows = 0;
            
        }

        // call gamecontrol & player object to shoot arrow into selected room, call gamelocation to see if wumpus is there or not
        // if true, shoot wumpus and if false, nothing 
        // then update arrows 
        public void ShootArrows()
        {
            //let gc know what room arrow was to 

            //gc let me know if hit wumpus

            bool shotWumpus = false;
            if (shotWumpus) MessageBox.Show("Killed wumpus");
            else MessageBox.Show("missed");
            //return false;
        }


        /// <summary>
        /// call gc & trivia to show trivia screen and add arrows if successful
        /// </summary>
        /// <returns></returns>
        public int BuyArrows(int arrows)
        {
            bool questionsAnswered = true;
            if (questionsAnswered) arrows++;
            return arrows;
        }

        // call gc, cave, gamelocations to get current cave # and display it
        public void GetCave()
        {
            int cave = 1;
        }

        // calls cave location and gl to see which adjacent rooms are available & display them
        // shows the cave #s on the buttons
        public int[] DisplayAdjacentCaves(int newCave)
        {
            int[] adjCaves = { 26, 7, 30 };

            return adjCaves;
        }

        
    }
}
