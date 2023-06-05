using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Team1WumpusGame
{
    internal class Player
    {
        public Player()
        {
            //this game sucks
        }

        // starting arrows & coins inventory
        int[] inventory = { 3, 10 };
        int turnAmount = 0;
        // starting location
        int playerLocation = 1;

        // get inventory method
        public int[] GetInventory()
        {
            return inventory;
        }

        // shoot arrows method
        public int ShootArrow(int caveToShoot, int[] allowedCaves, int wumpusLoc)
        {
            int result = 3;

            if (caveToShoot == allowedCaves[0] ||
                caveToShoot == allowedCaves[1] ||
                caveToShoot == allowedCaves[2])
            {
                if (caveToShoot == wumpusLoc)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                result = 2;
            }

            return result;
            //foreach (int cave in allowedCaves)
            //{
            //    // if the shooting location is not in one of the adjacent caves
            //    if (cave != caveToShoot)
            //    {
            //        result = 2;
            //    } 
            //    else
            //    {
            //        // if you shot the wumpus
            //        if (cave == wumpusLoc)
            //        {
            //            result = 1;
            //        }
            //        else // if you missed the wumpus
            //        {
            //            result = 0;
            //        }
            //    }
            //}

        }

        // get player location method
        public int GetPlayerLocation()
        {
            return playerLocation;
        }

        // move player location method, counts turns for score keeping
        public void MovePlayer(int newLocation)
        {
            playerLocation = newLocation;
            turnAmount++;
        }

        // calculates the final score when you die/win
        public int CalculateScore(bool win)
        {
            // 100 - number of turns + gold coins + (5 * Arrows) + 50 ( if won )
            int score = 100 - turnAmount + inventory[1] + (5 * inventory[0]);
            if (win)
            {
                score += 50;
            }
            return score;
        }
    }
}
