using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team1WumpusGameMain
{
    internal class Player
    {
        public Player()
        {

        }

        //   arrows coins
        int[] inventory = { 3, 10 };
        int turnAmount = 0;
        int playerLocation = 1;

        public int[] GetInventory()
        {
            return inventory;
        }

        public void UpdateArrowAmount(int update)
        {
            inventory[0] += update;
        }

        public void UpdateCoinAmount(int update)
        {
            inventory[1] += update;
        }

        public bool ShootArrow(int cave, int wumpusLoc)
        {
            inventory[0]--;
            if (cave == wumpusLoc)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int GetPlayerLocation()
        {
            return playerLocation;
        }

        public void MovePlayer(int newLocation)
        {
            playerLocation = newLocation;
            turnAmount++;
        }
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
