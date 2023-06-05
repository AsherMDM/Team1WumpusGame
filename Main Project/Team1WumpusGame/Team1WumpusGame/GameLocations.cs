using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team1WumpusGame
{
    internal class GameLocations
    {
        int wumpusLocation = 1;
        int[] batLocations = { 0, 0, 0 };
        int[] pitLocations = { 0, 0, 0 };
        Random rnd = new Random();

        public GameLocations()
        {

        }

        public void GenerateWumpusLocation()
        {
            int i = rnd.Next(1, 31);
            wumpusLocation = i;
        }

        public int GetWumpusLocation()
        {
            return wumpusLocation;
        }

        public void GenerateBatLocations()
        {
            batLocations[0] = rnd.Next(1, 31);
            batLocations[1] = rnd.Next(1, 31);
            batLocations[2] = rnd.Next(1, 31);
        }

        public int[] GetBatLocations()
        {
            
            return batLocations;
        }

        public void GeneratePitLocations()
        {
            pitLocations[0] = rnd.Next(1, 31);
            pitLocations[1] = rnd.Next(1, 31);
            pitLocations[2] = rnd.Next(1, 31);
        }

        public int[] GetPitLocations()
        {
            
            return pitLocations;
        }

        // move wumpus location when shot arrow and missed
        public int MoveWumpus()
        {
            if (wumpusLocation < 29)
            {
                wumpusLocation += 2;

            }
            else
            {
                wumpusLocation -= 2; 
            }
            
            return wumpusLocation;
        }

        public bool[] findAdjacentHazards(int[] adjacentCaves)
        {
            bool[] warnings = new bool[3] { false, false, false };

            foreach (int cave in adjacentCaves)
            {
                foreach (int caveBat in batLocations)
                {
                    if (caveBat == cave)
                    {
                        warnings[0] = true;
                    }
                }

                foreach (int cavePit in pitLocations)
                {
                    if (cavePit == cave)
                    {
                        warnings[1] = true;
                    }
                }

                if (cave == wumpusLocation)
                {
                    warnings[2] = true;
                }
            }

            return warnings;
        }

        public bool[] findCurrentHazards(int cave)
        {
            bool[] warnings = new bool[3] { false, false, false };

            foreach (int caveBat in batLocations)
            {
                if (caveBat == cave)
                {
                    warnings[0] = true;
                }
            }

            foreach (int cavePit in pitLocations)
            {
                if (cavePit == cave)
                {
                    warnings[1] = true;
                }
            }

            if (cave == wumpusLocation)
            {
                warnings[2] = true;
            }

            return warnings;
        }
    }
}
