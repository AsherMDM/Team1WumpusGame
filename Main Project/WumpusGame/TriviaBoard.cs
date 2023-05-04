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
            //uses a random number to cycle through questions in a dictionary defined below
            public int rn { get; set; }
            public Dictionary<string, string> Question = new Dictionary<string, string>()
            {

            }
        }

        public Dictionary<string, string> AskQuestion(int randomNumber, Dictionary dictionary)
        {
            //asks a question by looping through the dictionary and asking a question and then returning an answer
            rn = randomNumber;
            Question = dictionary;
            for (int i = 0; i < dictionary.length; i++)
            {
                if (i == rn)
                {
                    return dictionary(i);
                    dictionary.Remove(i);
                }
            }

        }



    }
}
