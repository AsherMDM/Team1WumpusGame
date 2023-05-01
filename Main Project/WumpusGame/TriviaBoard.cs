using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WumpusGame
{
    public class TriviaBoard
    {
        public TriviaBoard(int randomNumber)
        {
            //uses a random number to cycle through questions in a dictionary defined below
        }

        Dictionary<String, String> Question = new Dictionary<string, string>()
        {
            { }
        };

        public Dictionary AskQuestion(int randomNumber, Dictionary dictionary)
        {
            //asks a question by looping through the dictionary and asking a question and then returning an answer
            
            return dictionary(randomNumber);
        }
    }
}
