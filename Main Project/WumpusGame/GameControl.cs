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
        }

        public int displayHighScore(int high)
        {
            //displays high score
            return high;
        }

        public Cave avaliavleCaves(Cave cave)
        {
            //see available caved
        }

        public Cave nonAvailableSaves(Cave cave)
        {
            //see non availavle caves
        }

        public Cave adjacentCaves(Cave cave)
        {
            //validate user input from player
        }

        public Cave visitedCaves(Cave cave)
        {
            //validate user input from player
        }

        public Cave currentCave(Cave cave)
        {

        }

        public void ValidateUseInputInterface(GraphicalInterface @interface)
        {

        }

    }
}
