using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team1WumpusGame
{
    public class GameControl
    {
        public Question passQuestion(string Question, string ans1, string ans2, string ans3, string ans4, string correctAnswer)
        {
            Question question = new Question(Question, ans1, ans2, ans3, ans4, correctAnswer);
            return question;
        }

        public int passPlayerLocation()
        {
            Player player = new Player();
            int location = player.GetPlayerLocation();
            return location;    
        }


    }
}
