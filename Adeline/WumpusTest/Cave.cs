using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WumpusTest
{
   
    public class Cave
    {
        // Array of list to store room connections
        List<int>[] adjacent = new List<int>[30];

        public Cave()
        {
            ReadFromFile();
        }
        public void ReadFromFile()
        {
            // read the file that stores the room connections
            // store room into the Array of list
            StreamReader sr = new StreamReader("MapOfCave.Txt");
            string input = sr.ReadLine();
            while (input != null)
            {
                string[] data = input.Split(',');
                int index = int.Parse(data[0]);

                adjacent[index - 1] = new List<int>();

                for (int i = 1; i <= data.GetUpperBound(0); i++)
                {
                    adjacent[index - 1].Add(int.Parse(data[i]));
                }
                
                //Console.WriteLine(data[0]);
                input = sr.ReadLine();
            }
            sr.Close();
        }

        public List<int> get_possible_moves(int currentRoom)
        {
            // find adjacent rooms for currentRoom 
            List<int> possibleMoves;
            try
            {
                possibleMoves = adjacent[currentRoom - 1];

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
