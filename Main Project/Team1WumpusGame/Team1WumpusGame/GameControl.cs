using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Team1WumpusGame
{
    public class GameControl
    {
        Trivia trivia = new Trivia();
        Player player = new Player();
        GameLocations gameLocations = new GameLocations();
        Cave cave = new Cave();
        
        // create questions list
        public List<Question> createQuestion()
        {
            List<Question> questions = new List<Question>();
            for (int i = 0; i <= 30; i++)
            {
                questions.Add(trivia.GetQuestion());
            }
            return questions;
        }

        // format question data
        public Question passQuestion(string Question, string ans1, string ans2, string ans3, string ans4, string correctAnswer)
        {
            Question question = new Question(Question, ans1, ans2, ans3, ans4, correctAnswer);
            return question;
        }

        // pass player location
        public int passPlayerLocation()
        {
            int location = player.GetPlayerLocation();
            return location;    
        }

        // pass move location
        public void passNewLocation(int roomNumber)
        {
            player.MovePlayer(roomNumber);
        }

       
        public void GenerateWumpusLocation()
        {
            gameLocations.GenerateWumpusLocation();
        }

        public int passWumpusLocation()
        {
            return gameLocations.GetWumpusLocation();
        }

        // moves wumpus when missed arrow near it
        public int MoveWumpus()
        {
            return gameLocations.MoveWumpus();
        }

        public void GenerateBatLocations()
        {
            gameLocations.GenerateBatLocations();
        }

        public int[] passBatLocations()
        {
            return gameLocations.GetBatLocations();
        }

        public void GeneratePitLocations()
        {
            gameLocations.GeneratePitLocations();
        }

        public int[] passPitLocations()
        {
            return gameLocations.GetPitLocations();
        }

        // passes possible moves from adjacent caves in cave system
        public int[] passPossibleMoves(int CaveSystem)
        {

            List<int> bob = cave.get_possible_moves(passPlayerLocation(), CaveSystem);
            int[] PossibleMoves = bob.ToArray();
            return PossibleMoves;
        }

        public int[] passInventory()
        {
            return player.GetInventory();
        }

        // adds coins and updates inventory when you move rooms
        public int AddCoins(int newCoins)
        {
            player.GetInventory()[1] += newCoins;
            return player.GetInventory()[1];
        }

        // adds arrows and updates inventory
        public int AddArrows(int newArrows)
        {
            player.GetInventory()[0] += newArrows;
            return player.GetInventory()[0];
        }

        // shoots arrow
        public int ShootArrow(int location, int[] adjacentCaves, int WumpusLoc )
        {
            return player.ShootArrow(location,adjacentCaves,WumpusLoc);
        }

        // passes adjacent caves from cave system file
        public int[] passAdjacentCaves(string cs)
        {
            return cave.ReadFromFileCave("MapOfCave" + cs + ".txt")[int.Parse(cs)].ToArray();
            
        }

        // calculates final score
        public int CalculateScore(bool result)
        {
            return player.CalculateScore(result);
        }
    }
}
