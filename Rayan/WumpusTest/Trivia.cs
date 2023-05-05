using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace WumpusTest
{
    public class Trivia
    {
        List<Question> _questions = new List<Question>();
        int counter = -1;
        public Trivia() { 
            Question q1 = new Question("How old am I ?", "3", "7", "your mother", "16", "D");
            Question q2 = new Question("What is the chemical formula for Carbonic Acid?", "A", "Y2", "H2CO3", "A", "C");
            Question q3 = new Question("Is going to work on a Sunday illegal in Fiji?", "Maybe", "?????", "Yes", "No ", "C");
            Question q4 = new Question("When was the Commonwealth of Australia federated?", "01 January, 1901", "01 January, 1903", "01 January 1899", "All of the Above", "A");
            Question q5 = new Question("Who won the 1999 Champions League Final?", "Seattle Mariners", "AC Milan", "Barcelona", "Manchester United", "D");
            Question q6 = new Question("Solve: ∫ln x + 3 dx", "All of the Above", "x^2 + 3x + C", "xln|x| + 2x + C", "dad", "C");

            //What is the chemical formula for Carbonic Acid?, A. A, B.Y2, C.H2CO3, D.A ", "C" },);

            _questions.Add(q1);
        }


        public Question GetQuestion()
        {
            counter++;
            return _questions[counter];
        }
    }
}
