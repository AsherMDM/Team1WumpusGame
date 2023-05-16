using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team1WumpusGame
{
    internal class GameControl
    {
        Trivia trivia = new Trivia();
        Player player = new Player();
        GameForm gameForm = new GameForm();
        GameLocations gameLocations = new GameLocations();
        Cave cave = new Cave();

        public Question createQuestion()
        {
            
            return trivia.GetQuestion();
        }
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

        public int passNewLocation()
        {
            return gameForm.movingLocation();
        }

        public int passWumpusLocation()
        {
            return gameLocations.GetWumpusLocation();
        }

        public int[] passBatLocations()
        {
            return gameLocations.GetBatLocations();
        }

        public int[] passPitLocations()
        {
            return gameLocations.GetPitLocations();
        }

        public List<int> passPossibleMoves()
        {
            Random random = new Random();
            int bob = random.Next(1, 5);
            return cave.get_possible_moves(passPlayerLocation(), bob);
        }







    }
}
