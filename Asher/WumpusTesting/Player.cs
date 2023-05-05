using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WumpusTesting
{
    public class Player
    {
        public Player()
        {

        }

        //arrows coins
        int[] inventory = { 3, 10 };
        int turnAmount = 0;
        int playerLocation = 1;

        public int[] GetInventory()
        {
            // called by gamecontrol
            // Returns an array of the amounts of all objects in players inv
            // arrowsCount, goldCoinsCount
            return inventory;
        }

        public void UpdateArrowAmount(int update)
        {
            // Updates Arrow Amount
            // called by gamecontrol
            inventory[0] += update;
        }

        public void UpdateCoinAmount(int update)
        {
            // Updates Coin Amount
            // called by gamecontrol
            inventory[1] += update;
        }

        public void ShootArrow(int cave)
        {
            // SHoots arrow
            // called by gamecontrol
        }

        public int CalculateScore()
        {
            //Calculates Final Score
            // called by gamecontrol
            return 0;
        }

        public int GetPlayerLocation()
        {
            return playerLocation;
        }

        public void MovePlayer(int newLocation)
        {
            playerLocation = newLocation;
        }
    }
}