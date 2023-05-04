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
    public partial class CaveTestForm : Form
    {
        Cave cave;
        public CaveTestForm()
        {
            InitializeComponent();
            cave = new Cave();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            int currentRoom = int.Parse(textBoxRoomNumber.Text);

            List<int> possibleMoves = new List<int>();
            possibleMoves = cave.get_possible_moves(currentRoom);

            string ToPrint = "";
            for (int i = 0; i < possibleMoves.Count; i++)
            {
                ToPrint = ToPrint + possibleMoves[i].ToString() + ",";
            }
            richTextBoxAdjacentRooms.Text = ToPrint;
        }

    }
}
