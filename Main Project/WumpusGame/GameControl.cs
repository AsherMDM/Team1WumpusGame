using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WumpusGame
{
    public class GameControl
    {
        public bool currentState { get; set; }
        public int HighScore { get; set; }

        public GameControl()
        {
            //connects everything
        }

        public bool isPlayingGame(bool state)
        {
            //checks if a game is being played
            return state;
        }

        public void displaySplashscreen()
        {
            //displays splashscreen
            SplashScreen splashScreen = new SplashScreen();
            splashScreen.ShowDialog();
        }

        public int displayHighScore(int high)
        {
            //displays high score
            textBoxHighScore.Text = high.ToString();
            return high;
        }

        public int[] availableCaves(Cave cave)
        {
            //see available caved
            int[] availableCaves = cave.adjacentCaves[];
            return availableCaves[];
        }

        public int[] nonAvailableCaves(Cave cave)
        {
            //see non availavle caves
            int[] nonAvailableCaves = cave.nonAvailableCaves;
            return nonAvailableCaves[]; 
        }

        public int[] adjacentCaves(Cave cave)
        {
            //see adjacent caves
            int[] adjacentCaves = cave.adjacentCaves;
            return adjacentCaves[];
        }

        public int[] visitedCaves(Cave cave)
        {
            //see visited saves
            int[] visitedCaves = cave.visitedCaves; 
            return visitedCaves[];
        }

        public int[] currentCave(Cave cave)
        {
            //see current caves
            int[] currentCave = cave.currentCave[];
            return currentCave;
        }

        public int[] seeAdjacentCaves(Cave cave)
        {
            //see hazards in adjacent caves
            int[] seeAdjacentCaves = cave.AdjacentCaves;
            return seeAdjacentCaves;
        }


    }
}
