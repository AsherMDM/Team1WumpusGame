using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WumpusTest
{
    // Array of list to store room connections
    private List<int>[] adjacent = new List<int>[30];

    public class Cave
    {
        public Cave()
        {
            // read the file that stores the room connections
            // store it into the Array of list
        } 
        public void ReadFromFile()
        {
            StreamReader sr = new StreamReader("MapofCave.txt");
            string caves = sr.ReadLine();
            sdfdghjklk
            
        }

        public List<int> get_possible_moves(int currentRoom)
        {
            // find adjacent rooms for currentRoom
            // return list of adjacent rooms
            
        }

    }
}
