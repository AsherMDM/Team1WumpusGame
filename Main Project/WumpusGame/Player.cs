using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WumpusGame
{
    internal class Player
    {
        public Player()
        {

        }

        int amountOfArrows = 3;
        int amountOfCoins = 10;
        int turnAmount = 0;

        public int[] GetInventory()
        {
            // called by gamecontrol
            // Returns an array of the amounts of all objects in players inv
            // arrowsCount, goldCoinsCount
            return { 1, 2 }
        }

        public void UpdateArrowAmount(int update)
        {
            // Updates Arrow Amount
            // called by gamecontrol
        }

        public void UpdateCoinAmount(int update)
        {
            // Updates Coin Amount
            // called by gamecontrol
        }

        public void ShootArrow(int cave, )
        {
            // SHoots arrow
            // called by gamecontrol
        }

        public int CalculateScore()
        {
            //Calculates Final Score
            // called by gamecontrol
        }
    }
}