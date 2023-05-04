using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WumpusTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Dictionary<string, string> Question = new Dictionary<string, string>()
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
            {"What is: ↑↑↓↓←→←→BA A. A bunch of characters B. The Konami Code C. The nearest path to the Wumpus D. Stairway to Heaven", "B" },
            {"Karate is a martial art from A. China B. India C. Okinawa D. Saudi Arabia", "C" },
            {"Who is the highest scoring player for Chelsea FC A. Didier Drogba B. Frank Lampard C. Son Heung-Min D. Hidetoshi Nakata", "B" },
            {"What Pokemon type was the move Curse in the game 'Pokemon Diamond' A. Ghost B. ??? C. Water D. Dark", "B" },
            {"What language is this game coded in? A. C B. C++ C. C# D. C-- ", "C" },
            {"What country is Samsung Corporation headquartered in? A. Japan B. South Korea C. North Korea D. West Korea", "B"},
            {"What is the largest ethnic group in the United Arab Emirates? A. Arabs B. Indians C. Filipinos D. Chinese ", "B" },
            {"What country acheieved 4th Place in the 2002 World Cup? A. England B. Brazil C. Turkey D. South Korea", "D" },
            {"The answer to this trivia question is the first letter of the name of this video: https://www.youtube.com/watch?v=dQw4w9WgXcQ ", "N" },
            {"How many squares are on a chess board? A. 30 B. 89 C. 23 D. 64", "D" },
            {"Is Taiwan a country? A. Yes B. No C. Maybe D. It is now!!! (This is a joke, please dont cancel me)", "B" },
            {"When was the War of 1812? A. 1813 B. 1811 C. 1812 D. 18", "C" },
            {"In Greek Mythology, Poseidon is the God of the A. Sea B. Land C. Earth D. Gods", "A" },
            {"How do you spell colour A. Color B. Colour C. coloor D. All of the Above", "B" },
            {"Did Asher lose a chess game on the 2nd of May, 2023 A. ??? B. Yes C. Maybe D. No, Asher never loses", "B"  },
            {"In the game of Go, does Black or White move first? A. Blue B. Green C. Black D. White", "C" },
            {"Is Adeline contemplating life right now due to her maths homework? A. yes B. (Click A) C. (Click A) D. No ", "A"},
            {"Is this the last question? A. Yes B. No C. Maybe", "C" },
            {"Which one of these is a K-Drama? A. Zootopia B. One Piece C. Dae Jang Geum D. Yeh Deewani Hey Jeewani", "C" }
        };


        private void ConstructorButton_Click(object sender, EventArgs e)
        {
            TriviaBoard Board = new TriviaBoard();
            GameControl control = new GameControl();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonAskQuestion_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int randint = random.Next(0, Question.Count);
            TriviaBoard tb = new TriviaBoard();
            listBoxQuestion.Items.Add(tb.AskQuestion(randint, Question));
            
        }
    }
}
