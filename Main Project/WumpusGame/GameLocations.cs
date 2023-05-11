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

        Random rnd = new Random();

        int wumpusLocation = 1;
        int[] batLocations = { 0, 0, 0 };
        int[] pitLocations = { 0, 0, 0 };

        public void GenerateWumpusLocation()
        {
            // called by gamecontrol
            int i = rnd.Next(1, 30);
            wumpusLocation = i;
        }

        public int GetWumpusLocation()
        {
            // called by gamecontrol
            return wumpusLocation;
        }

        public void GenerateBatLocations()
        {
            // called by gamecontrol
            batLocations[0] = rnd.Next(1, 30);
            batLocations[1] = rnd.Next(1, 30);
            batLocations[2] = rnd.Next(1, 30);
        }
        public int[] GetBatLocations()
        {
            // called by gamecontrol
            return batLocations;
        }

        public void GeneratePitLocations()
        {
            // called by gamecontrol
            pitLocations[0] = rnd.Next(1, 30);
            pitLocations[1] = rnd.Next(1, 30);
            pitLocations[2] = rnd.Next(1, 30);
        }
        public int[] GetPitLocations()
        {
            // called by gamecontrol
            return pitLocations;
        }

        public int MoveWumpus()
        {
            // called by gamecontrol
            return wumpusLocation;
        }

        public bool[] findAdjacentHazards(int[] adjacentCaves, int[] batLocs, int[] pitLocs, int wumpusLoc)
        {
            bool[] warnings = new bool[3] { false, false, false };


            foreach (int cave in adjacentCaves)
            {
                //bats
                foreach (int caveBat in batLocs)
                {
                    if (caveBat == cave)
                    {
                        warnings[0] = true;
                    }
                }

                //pits
                foreach (int cavePit in pitLocs)
                {
                    if (cavePit == cave)
                    {
                        warnings[1] = true;
                    }
                }

                if (cave == wumpusLoc)
                {
                    warnings[2] = true;
                }
            }

            return warnings;
        }

        public bool[] findCurrentHazards(int cave, int[] batLocs, int[] pitLocs, int wumpusLoc)
        {
            bool[] warnings = new bool[3] { false, false, false };

            foreach (int caveBat in batLocs)
            {
                if (caveBat == cave)
                {
                    warnings[0] = true;
                }
            }

            //pits
            foreach (int cavePit in pitLocs)
            {
                if (cavePit == cave)
                {
                    warnings[1] = true;
                }
            }

            if (cave == wumpusLoc)
            {
                warnings[2] = true;
            }

            return warnings;
        }
    }
}
