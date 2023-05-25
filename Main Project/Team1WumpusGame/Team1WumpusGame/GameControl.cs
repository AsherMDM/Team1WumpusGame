using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Team1WumpusGame
{
    public class GameControl
    {
        Trivia trivia = new Trivia();
        Player player = new Player();

        GameLocations gameLocations = new GameLocations();
        Cave cave = new Cave();

        public List<Question> createQuestion()
        {
            for(int i = 0; i <= 99; i++)
            {
                List<Question> questions = new List<Question>();
                questions.Add(trivia.GetQuestion());
                return questions;
            }
            return null;
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

        public void passNewLocation(int roomNumber)
        {
            player.MovePlayer(roomNumber);
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

        public int[] passPossibleMoves()
        {
            Random random = new Random();
            int i = random.Next(1, 5);
            List<int> bob = cave.get_possible_moves(passPlayerLocation(), i);
            int[] PossibleMoves = bob.ToArray();
            return passPossibleMoves();
        }

        public int[] passInventory()
        {
            return player.GetInventory();
        }

        public int AddCoins(int newCoins)
        {
            player.GetInventory()[1] += newCoins;
            return player.GetInventory()[1];
        }

        public int AddArrows(int newArrows)
        {
            player.GetInventory()[0] += newArrows;
            return player.GetInventory()[0];
        }

        public int ShootArrow(int location, int[] adjacentCaves, int WumpusLoc )
        {
            return player.ShootArrow(location,adjacentCaves,WumpusLoc);
        }
    }
}
