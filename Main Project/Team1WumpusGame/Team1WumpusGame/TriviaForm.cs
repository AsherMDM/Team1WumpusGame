using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Team1WumpusGame
{
    public partial class TriviaForm : Form
    {
        GameControl gameControl =  new GameControl();
        int correctAnswers;
        int counter = 0;
        Question bob;

        public TriviaForm()
        {
            InitializeComponent();

            //labelQuestion.Text = bob.Ques;
            //labelAnswerA.Text = bob.Answer1;
            //labelAnswerB.Text = bob.Answer2;
            //labelAnswerC.Text = bob.Answer3;
            //labelAnswerD.Text = bob.Answer4;
        }

        private void TriviaForm_Load(object sender, EventArgs e)
        {
            bob = gameControl.createQuestion()[counter];

            labelQuestion.Text = bob.Ques;
            labelAnswerA.Text = bob.Answer1;
            labelAnswerB.Text = bob.Answer2;
            labelAnswerC.Text = bob.Answer3;
            labelAnswerD.Text = bob.Answer4;
        }

        private void labelQuestion_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonB_Click(object sender, EventArgs e)
        {
            try
            {
                limitChecker();
                if (labelAnswerA.Text == bob.CorrectAnswer)
                {
                    correctAnswers++;
                    counter++;
                    if (limitChecker() == 3)
                    {
                        Application.Exit();
                    }
                    bob = gameControl.createQuestion()[counter];

                    labelQuestion.Text = bob.Ques;
                    labelAnswerA.Text = bob.Answer1;
                    labelAnswerB.Text = bob.Answer2;
                    labelAnswerC.Text = bob.Answer3;
                    labelAnswerD.Text = bob.Answer4;
                }
                else
                {
                    counter++;
                    bob = gameControl.createQuestion()[counter];

                    labelQuestion.Text = bob.Ques;
                    labelAnswerA.Text = bob.Answer1;
                    labelAnswerB.Text = bob.Answer2;
                    labelAnswerC.Text = bob.Answer3;
                    labelAnswerD.Text = bob.Answer4;
                }
            }
            catch
            {
                counter = 0;
            }
        }

        private void buttonA_Click(object sender, EventArgs e)
        {
            try
            {

                limitChecker();
                if (labelAnswerA.Text == bob.CorrectAnswer)
                {
                    correctAnswers++;
                    counter++;
                    if (limitChecker() == 3)
                    {
                        Application.Exit();
                    }

                    bob = gameControl.createQuestion()[counter];

                    labelQuestion.Text = bob.Ques;
                    labelAnswerA.Text = bob.Answer1;
                    labelAnswerB.Text = bob.Answer2;
                    labelAnswerC.Text = bob.Answer3;
                    labelAnswerD.Text = bob.Answer4;
                }
                else
                {
                    counter++;
                    bob = gameControl.createQuestion()[counter];

                    labelQuestion.Text = bob.Ques;
                    labelAnswerA.Text = bob.Answer1;
                    labelAnswerB.Text = bob.Answer2;
                    labelAnswerC.Text = bob.Answer3;
                    labelAnswerD.Text = bob.Answer4;
                }
            }
            catch
            {
                counter = 0;
            }
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            try
            {
                limitChecker();
                if (labelAnswerC.Text == bob.CorrectAnswer)
                {
                    correctAnswers++;
                    counter++;
                    if (limitChecker() == 3)
                    {
                        Application.Exit();
                    }
                    counter++;
                    bob = gameControl.createQuestion()[counter];

                    labelQuestion.Text = bob.Ques;
                    labelAnswerA.Text = bob.Answer1;
                    labelAnswerB.Text = bob.Answer2;
                    labelAnswerC.Text = bob.Answer3;
                    labelAnswerD.Text = bob.Answer4;

                }
                else
                {
                    counter++;
                    bob = gameControl.createQuestion()[counter];

                    labelQuestion.Text = bob.Ques;
                    labelAnswerA.Text = bob.Answer1;
                    labelAnswerB.Text = bob.Answer2;
                    labelAnswerC.Text = bob.Answer3;
                    labelAnswerD.Text = bob.Answer4;
                }
            }
            catch
            {
                counter = 0;
            }
        }

        private void buttonD_Click(object sender, EventArgs e)
        {
            try
            {
                limitChecker();
                if (labelAnswerD.Text == bob.CorrectAnswer)
                {
                    correctAnswers++;
                    counter++;
                    if (limitChecker() == 3)
                    {
                        Application.Exit();
                    }
                    bob = gameControl.createQuestion()[counter];

                    labelQuestion.Text = bob.Ques;
                    labelAnswerA.Text = bob.Answer1;
                    labelAnswerB.Text = bob.Answer2;
                    labelAnswerC.Text = bob.Answer3;
                    labelAnswerD.Text = bob.Answer4;
                }
                else
                {
                    bob = gameControl.createQuestion()[counter];

                    labelQuestion.Text = bob.Ques;
                    labelAnswerA.Text = bob.Answer1;
                    labelAnswerB.Text = bob.Answer2;
                    labelAnswerC.Text = bob.Answer3;
                    labelAnswerD.Text = bob.Answer4;
                }
            }
            catch
            {
                counter = 0;
            }
        }

        public int limitChecker()
        {
            if(correctAnswers == 2)
            {
                MessageBox.Show("You got two correct!");
                return correctAnswers;
            }
            else if(counter == 3)
            {
                MessageBox.Show("You didn't get enough correct in time :(");
                return counter;
            }
            else
            {
                return 0;
            }

        }
    }
}
