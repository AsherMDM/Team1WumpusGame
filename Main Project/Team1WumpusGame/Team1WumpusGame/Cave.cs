using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Team1WumpusGame
{
    internal class Cave
    {
        // Array of list to store room connections
        List<int>[] adjacentCave1;
        List<int>[] adjacentCave2;
        List<int>[] adjacentCave3;
        List<int>[] adjacentCave4;
        List<int>[] adjacentCave5;

        public Cave()
        {
            adjacentCave1 = ReadFromFileCave("MapOfCave.txt");
            adjacentCave2 = ReadFromFileCave("MapOfCave2.txt");
            adjacentCave3 = ReadFromFileCave("MapOfCave3.txt");
            adjacentCave4 = ReadFromFileCave("MapOfCave4.txt");
            adjacentCave5 = ReadFromFileCave("MapOfCave5.txt");
        }
        public List<int>[] ReadFromFileCave(string filename)
        {
            List<int>[] adjacentCave = new List<int>[30];
            // read the file that stores the room connections
            // store room into the Array of list
            StreamReader sr = new StreamReader(filename);
            string input = sr.ReadLine();
            while (input != null)
            {
                string[] data = input.Split(',');
                int index = int.Parse(data[0]);
                
                adjacentCave[index - 1] = new List<int>();

                for (int i = 1; i <= data.GetUpperBound(0); i++)
                {
                    adjacentCave[index - 1].Add(int.Parse(data[i]));
                }
                input = sr.ReadLine();
            }
            sr.Close();
            return adjacentCave;
        }
        public List<int> get_possible_moves(int currentRoom, int caveNum)
        {
            //MessageBox.Show(caveNum.ToString(), "Alert");

            // find adjacent rooms for currentRoom 
            List<int> possibleMoves;
            List<int>[] adjacentCave;
            if (caveNum == 1)
            {
                adjacentCave = adjacentCave1;
            }
            else if (caveNum == 2)
            {
                adjacentCave = adjacentCave2;
            }
            else if (caveNum == 3)
            {
                adjacentCave = adjacentCave3;
            }
            else if (caveNum == 4)
            {
                adjacentCave = adjacentCave4;
            }
            else if (caveNum == 5)
            {
                adjacentCave = adjacentCave5;
            }
            else // default option
            {
                adjacentCave = adjacentCave1;
            }

            try
            {
                possibleMoves = adjacentCave[currentRoom - 1];

                // return list of adjacent rooms
                return possibleMoves;
            }
            catch
            {
                MessageBox.Show("Current room has to be within 30", "Alert");
                possibleMoves = new List<int>(); // return empty list
                return possibleMoves;
            }
        }
    }
}
