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
        List<int>[] adjacentCave1 = new List<int>[30];
        List<int>[] adjacentCave2 = new List<int>[30];
        List<int>[] adjacentCave3 = new List<int>[30];
        List<int>[] adjacentCave4 = new List<int>[30];
        List<int>[] adjacentCave5 = new List<int>[30];

        public Cave()
        {
            ReadFromFileCave1();
            ReadFromFileCave2();
            ReadFromFileCave3();
            ReadFromFileCave4();
            ReadFromFileCave5();
        }
        public void ReadFromFileCave1()
        {
            // read the file that stores the room connections
            // store room into the Array of list
            StreamReader sr = new StreamReader("MapOfCave.Txt");
            string input = sr.ReadLine();
            while (input != null)
            {
                string[] data = input.Split(',');
                int index = int.Parse(data[0]);

                adjacentCave1[index - 1] = new List<int>();

                for (int i = 1; i <= data.GetUpperBound(0); i++)
                {
                    adjacentCave1[index - 1].Add(int.Parse(data[i]));
                }

                //Console.WriteLine(data[0]);
                input = sr.ReadLine();
            }
            sr.Close();
        }

        public List<int> get_possible_movesCave1(int currentRoom)
        {
            // find adjacent rooms for currentRoom 
            List<int> possibleMoves;
            try
            {
                possibleMoves = adjacentCave1[currentRoom - 1];

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
        public void ReadFromFileCave2()
        {
            // read the file that stores the room connections
            // store room into the Array of list
            StreamReader sr = new StreamReader("MapOfCave2.Txt");
            string input = sr.ReadLine();
            while (input != null)
            {
                string[] data = input.Split(',');
                int index = int.Parse(data[0]);

                adjacentCave2[index - 1] = new List<int>();

                for (int i = 1; i <= data.GetUpperBound(0); i++)
                {
                    adjacentCave2[index - 1].Add(int.Parse(data[i]));
                }
                input = sr.ReadLine();
            }
            sr.Close();
        }
        public List<int> get_possible_movesCave2(int currentRoom)
        {
            // find adjacent rooms for currentRoom 
            List<int> possibleMoves;
            try
            {
                possibleMoves = adjacentCave2[currentRoom - 1];

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
        public void ReadFromFileCave3()
        {
            // read the file that stores the room connections
            // store room into the Array of list
            StreamReader sr = new StreamReader("MapOfCave3.Txt");
            string input = sr.ReadLine();
            while (input != null)
            {
                string[] data = input.Split(',');
                int index = int.Parse(data[0]);

                adjacentCave3[index - 1] = new List<int>();

                for (int i = 1; i <= data.GetUpperBound(0); i++)
                {
                    adjacentCave3[index - 1].Add(int.Parse(data[i]));
                }
                input = sr.ReadLine();
            }
            sr.Close();
        }
        public List<int> get_possible_movesCave3(int currentRoom)
        {
            // find adjacent rooms for currentRoom 
            List<int> possibleMoves;
            try
            {
                possibleMoves = adjacentCave3[currentRoom - 1];

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
        public void ReadFromFileCave4()
        {
            // read the file that stores the room connections
            // store room into the Array of list
            StreamReader sr = new StreamReader("MapOfCave4.Txt");
            string input = sr.ReadLine();
            while (input != null)
            {
                string[] data = input.Split(',');
                int index = int.Parse(data[0]);

                adjacentCave4[index - 1] = new List<int>();

                for (int i = 1; i <= data.GetUpperBound(0); i++)
                {
                    adjacentCave4[index - 1].Add(int.Parse(data[i]));
                }
                input = sr.ReadLine();
            }
            sr.Close();
        }
        public List<int> get_possible_movesCave4(int currentRoom)
        {
            // find adjacent rooms for currentRoom 
            List<int> possibleMoves;
            try
            {
                possibleMoves = adjacentCave4[currentRoom - 1];

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
        public void ReadFromFileCave5()
        {
            // read the file that stores the room connections
            // store room into the Array of list
            StreamReader sr = new StreamReader("MapOfCave5.Txt");
            string input = sr.ReadLine();
            while (input != null)
            {
                string[] data = input.Split(',');
                int index = int.Parse(data[0]);

                adjacentCave5[index - 1] = new List<int>();

                for (int i = 1; i <= data.GetUpperBound(0); i++)
                {
                    adjacentCave5[index - 1].Add(int.Parse(data[i]));
                }
                input = sr.ReadLine();
            }
            sr.Close();
        }
        public List<int> get_possible_movesCave5(int currentRoom)
        {
            // find adjacent rooms for currentRoom 
            List<int> possibleMoves;
            try
            {
                possibleMoves = adjacentCave5[currentRoom - 1];

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
