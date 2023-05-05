using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WumpusTestObjectMonica
{
    public partial class GameForm : Form
    {
        GraphicalInterface ui;
        public int currentarrows = 1;

        public GameForm()
        {
            InitializeComponent();
            ui = new GraphicalInterface();
            //labelCurrentCave.Text = ui.GetCave();

        }

        private void buttonShootArrows_Click(object sender, EventArgs e)
        {
            ui.ShootArrows();
            currentarrows--;
            labelArrows.Text = "Arrows: " + currentarrows.ToString();
        }

        private void buttonBuyArrows_Click(object sender, EventArgs e)
        {
            currentarrows = ui.BuyArrows(currentarrows);
            labelArrows.Text = "Arrows: " + currentarrows;

        }

        private void buttonCave1_Click(object sender, EventArgs e)
        {
            int newRoom = int.Parse(buttonCave1.Text);

            int[] adjCaves = ui.DisplayAdjacentCaves(newRoom);

            buttonCave1.Text = adjCaves[0].ToString();
            labelCurrentCave.Text = newRoom.ToString();
        }

        private void buttonCave2_Click(object sender, EventArgs e)
        {
            int newRoom = int.Parse(buttonCave1.Text);

            int[] adjCaves = ui.DisplayAdjacentCaves(newRoom);

            buttonCave2.Text = adjCaves[1].ToString();
            labelCurrentCave.Text = newRoom.ToString();

        }

        private void buttonCave3_Click(object sender, EventArgs e)
        {
            int newRoom = int.Parse(buttonCave1.Text);

            int[] adjCaves = ui.DisplayAdjacentCaves(newRoom);

            buttonCave3.Text = adjCaves[2].ToString();
            labelCurrentCave.Text = newRoom.ToString();
        }

        private void buttonWarnings_Click(object sender, EventArgs e)
        {
            bool[] warnings = { checkBox1.Checked, checkBox2.Checked, checkBox3.Checked };

            labelBatWarning.Visible = warnings[0];
            labelPitWarning.Visible = warnings[1];
            labelWumpusWarning.Visible = warnings[2];
        }   
    }
}
