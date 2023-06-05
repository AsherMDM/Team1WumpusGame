using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Team1WumpusGame
{
    public partial class TriviaForm : Form
    {
        GameControl gameControl; // =  new GameControl();
        int correctAnswers;
        int counter = 0;
        int newArrows;
        Question bob;

        public TriviaForm(GameControl gc, int newArrows)
        {
            gameControl = gc;
            this.newArrows = newArrows;
            InitializeComponent();

            
        }

        private void TriviaForm_Load(object sender, EventArgs e)
        {
            generateQuestion();
        }
        
        private void generateQuestion()
        {
            bob = gameControl.createQuestion()[counter];

            labelQuestion.Text = bob.Ques;
            radioButtonAnswer1.Text = bob.Answer1;
            radioButtonAnswer2.Text = bob.Answer2;
            radioButtonAnswer3.Text = bob.Answer3;
            radioButtonAnswer4.Text = bob.Answer4;
        }

        private void labelQuestion_Click(object sender, EventArgs e)
        {
            
        }

        private bool returnTrue()
        {
            return true;
        }

        private bool returnFalse()
        {
            return false;
        }

        public int limitChecker()
        {
            if(correctAnswers == 2)
            {
                return 2;
            }
            else if(counter == 3)
            {
                return 3;
            }
            else
            {
                return 0;
            }

        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {

            counter++;
            if (radioButtonAnswer1.Checked && radioButtonAnswer1.Text == bob.CorrectAnswer)
            {
                correctAnswers++;

            }
            else if (radioButtonAnswer2.Checked && radioButtonAnswer2.Text == bob.CorrectAnswer)
            {
                correctAnswers++;

            }
            else if (radioButtonAnswer3.Checked && radioButtonAnswer3.Text == bob.CorrectAnswer)
            {
                correctAnswers++;

            }
            else if (radioButtonAnswer4.Checked && radioButtonAnswer4.Text == bob.CorrectAnswer)
            {
                correctAnswers++;

            }

            if (limitChecker() == 2)
            {
                MessageBox.Show("You got 2 right!");
                gameControl.AddArrows(newArrows);
                gameControl.AddCoins(-3 * newArrows);

                returnTrue();
                this.Close();
            }
            else if (limitChecker() == 3)
            {
                MessageBox.Show("You didn't get enough right. ");
                returnFalse();
                this.Close();
            }

            generateQuestion();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
