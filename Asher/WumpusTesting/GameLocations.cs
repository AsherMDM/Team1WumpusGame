using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WumpusTesting
{
    internal class GameLocations
    {
        public GameLocations()
        {

        }

        Random rnd = new Random();

        int wumpusLocation = 1;
        int[] batLocations = { 5, 2, 3 };
        int[] pitLocations = { 1, 2, 6, 4 };

        public void GenerateWumpusLocation()
        {
            // called by gamecontrol
            int i = rnd.Next(1, 30);
            wumpusLocation = i;
        }

        public int[] GenerateBatLocations()
        {
            // called by gamecontrol
            return batLocations;
        }

        public int[] GeneratePitLocations()
        {
            // called by gamecontrol
            return pitLocations;
        }

        public int MoveWumpus()
        {
            // called by gamecontrol
            return wumpusLocation;
        }

        public string findAdjacentHazards(int[] adjacentCaves, int[] batLocs, int []pitLocs, int wumpusLoc)
        {
            string warnings = "";
            

            foreach (int cave in adjacentCaves)
            {
                //bats
                foreach (int caveBat in batLocs)
                {
                    if (caveBat == cave)
                    {
                        warnings += "Bats nearby.\n";
                    }
                }

                //pits
                foreach (int cavePit in pitLocs)
                {
                    if (cavePit == cave)
                    {
                        warnings += "Pit nearby.\n";
                    }
                }

                if (cave == wumpusLoc)
                {
                    warnings += "Wumpus nearby.\n";
                }
            }

            return warnings;
        }
        
        public void findCurrentHazards()
        {

        }
    }
}
