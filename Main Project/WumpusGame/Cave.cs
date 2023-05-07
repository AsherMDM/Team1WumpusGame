using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WumpusTest
{
    // Array of list to store room connections
    private List<int>[] adjacentCave1 = new List<int>[30];
    private List<int>[] adjacentCave2 = new List<int>[30];
    private List<int>[] adjacentCave3 = new List<int>[30];
    private List<int>[] adjacentCave4 = new List<int>[30];
    private List<int>[] adjacentCave5 = new List<int>[30];


    public class Cave
    {
        public Cave()
        {
            // read the file that stores the room connections
            // store it into the Array of list
            get_possible_movesCave1()
            get_possible_movesCave2()
            get_possible_movesCave3()
            get_possible_movesCave4()
            get_possible_movesCave5()

        }

        public List<int> get_possible_movesCave1(int currentRoom)
        {
            // find adjacent rooms for currentRoom
            // return list of adjacent rooms
            
        }
        public List<int> get_possible_movesCave2(int currentRoom)
        {
            // find adjacent rooms for currentRoom
            // return list of adjacent rooms

        }
        public List<int> get_possible_movesCave3(int currentRoom)
        {
            // find adjacent rooms for currentRoom
            // return list of adjacent rooms

        }
        public List<int> get_possible_movesCave4(int currentRoom)
        {
            // find adjacent rooms for currentRoom
            // return list of adjacent rooms

        }
        public List<int> get_possible_movesCave5(int currentRoom)
        {
            // find adjacent rooms for currentRoom
            // return list of adjacent rooms

        }

    }
}
