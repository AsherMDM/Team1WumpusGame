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
            {"How old am I? A. 3 , B. 7,  C. your mother,  D. 16 ", "D" },
            {"What is the chemical formula for Carbonic Acid? A. A, B. Y2 , C. H2CO3,  D. A ", "C" },
            {"Is going to work on a Sunday illegal in Fiji? A. Maybe, B. ????? C. Yes, D. No " , "C" },
            {"When was the Commonwealth of Australia federated? A. 01 January, 1901 B. 01 January, 1903 C. 01 January 1899 D. All of the Above", "A" },
            {"Who won the 1999 Champions League Final? A. Seattle Mariners B. AC Milan C. Barcelona D. Manchester United", "D" },
            {"Solve: ∫ln x + 3 dx A. All of the Above B. x^2 + 3x + C C. xln|x| + 2x + C D. dad", "C" },
            {"What is the capital of Singapore? A. Malaysia B. China C. Singapore D. Naples", "C"},
            {"Who is the current Prime Minister of the United Kingdom? A. Boris B. Liz Truss(The cabbage) C. Dodgy Dave D. Rishi ", "D" },
            {"Who is the current Paramount Leader of the of the People's Republic of China? A. 毛泽东 B. 小熊維尼 C. 邓小平 D. 安倍 晋三  ", "B"  },
            {"What is the most commonly consumed refreshment? A. Beer B. Sake C. Wine D. Unsparkling molten ice", "D" },
            {"What is Mr. Donelly's genetic hair colour? A. Blue B. Black C. Red D. Blonde ", "C" },
            {"When was the last time Tottenham Hotspur won a trophy? A. Never B. 1963 C. Today D. 2008", "D"},
            {"What is the highest amount of runs scored in the second innings of an ODI cricket match? A. 437 B. 436 C. 438 D. None of the Above ", "C" },
        };

        public Dictionary AskQuestion(int randomNumber, Dictionary dictionary)
        {
            //asks a question by looping through the dictionary and asking a question and then returning an answer
            
            return dictionary(randomNumber);
        }
    }
}
