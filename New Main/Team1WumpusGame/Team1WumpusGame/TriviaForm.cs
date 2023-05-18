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
            Question bob = gameControl.createQuestion();
            labelQuestion.Text = bob.Ques;
            labelAnswerA.Text = bob.Answer1;
            labelAnswerB.Text = bob.Answer2;
            labelAnswerC.Text = bob.Answer3;
            labelAnswerD.Text = bob.Answer4;
        }

        private void TriviaForm_Load(object sender, EventArgs e)
        {
            
        }

        private void labelQuestion_Click(object sender, EventArgs e)
        {
            
        }

    }
}
