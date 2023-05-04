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

        public Trivia() { 
            Question q1 = new Question("How old am I ?", "3", "7", "your mother", "16", "16");
            //Question q2 = new Question(How old am I ?, 3, 7, your mother, 16, 16);
            //What is the chemical formula for Carbonic Acid?, A. A, B.Y2, C.H2CO3, D.A ", "C" },);

            _questions.Add(q1);
        }


        public Question GetQuestion()
        {
            return _questions[0];
        }
    }
}
