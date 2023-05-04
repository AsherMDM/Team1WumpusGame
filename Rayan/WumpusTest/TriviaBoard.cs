using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WumpusTest
{
    public class TriviaBoard
    {
    public TriviaBoard()
    {
        //uses a random number to cycle through questions in a dictionary defined below
    }

    public Dictionary<string, string> AskQuestion(int randomNumber, Dictionary<string,string> dictionary)
    {
        //asks a question by looping through the dictionary and asking a question and then returning an answer
        for (int i = 0; i < dictionary.Count; i++)
        {
            if (i == randomNumber)
            {
                //return dictionary["kd"];
            }
        }
        return null;

    }
}
}
