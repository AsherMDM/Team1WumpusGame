using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WumpusGame
{
    internal class GameLocations
    {
        public GameLocations()
        {

        }

        int wumpusLocation = 1;
        int[] batLocations = { 1, 2, 3 };
        int[] pitLocations = { 1, 2, 3, 4 };

        public int GenerateWumpusLocation()
        {
            // called by gamecontrol
            return wumpusLocation;
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
    }
}
