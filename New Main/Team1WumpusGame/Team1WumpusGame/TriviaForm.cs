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
        public TriviaForm()
        {
            InitializeComponent();
            Question question = gameControl.createQuestion();
            labelQuestion.Text = question.Ques;
            labelAnswerA.Text = question.Answer1;
            labelAnswerB.Text = question.Answer2;
            labelAnswerC.Text = question.Answer3;
            labelAnswerD.Text = question.Answer4;
        }

        private void TriviaForm_Load(object sender, EventArgs e)
        {
            
        }

        private void labelQuestion_Click(object sender, EventArgs e)
        {
            
        }
    }
}
