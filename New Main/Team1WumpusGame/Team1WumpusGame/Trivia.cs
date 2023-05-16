using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team1WumpusGame
{
    internal class Trivia
    {
        string[] data;
        List<Question> _questions = new List<Question>();
        public Trivia()
        {


            //for(int i = 0; i <= 30; i++)
            //{
            ReadFromFile();
            //}  

            //What is the chemical formula for Carbonic Acid?, A. A, B.Y2, C.H2CO3, D.A ", "C" },);
        }

        private void ReadFromFile()
        {
            StreamReader sr = new StreamReader("Questions.txt");
            string line = sr.ReadLine();
            while (line != null)
            {
                data = line.Split(',');
                Question q = new Question(data[0], data[1], data[2], data[3], data[4], data[5]);
                _questions.Add(q);
                line = sr.ReadLine();
            }
            sr.Close();
            //return data;
        }


        public Question GetQuestion()
        {
            Random randint = new Random();
            int rnd = randint.Next(1, 30);
            return _questions[rnd];
        }
    }
}
