using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WumpusGame
{
    public class TriviaBoard
    {
        public TriviaBoard()
        {
            ReadFromFile();
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
