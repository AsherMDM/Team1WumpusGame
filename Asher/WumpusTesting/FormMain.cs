using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WumpusTesting;

namespace WumpusTesting
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        Player player = new Player();
        GameLocations gameLocations = new GameLocations();

        private void richTextBoxInfo_TextChanged(object sender, EventArgs e)
        {
            outputInfoBox.SelectionStart = outputInfoBox.Text.Length;
            outputInfoBox.ScrollToCaret();
        }

        private void buttonCreateSelectedObject_Click(object sender, EventArgs e)
        {
            if (listBoxObjects.SelectedItem == null)
            {
                MessageBox.Show("No object selected");
            } 
            else if (listBoxObjects.SelectedItem.ToString() == "Player")
            {
                Player player = new Player();
                outputInfoBox.Text += "Created player object\n";
            }
            else if (listBoxObjects.SelectedItem.ToString() == "GameLocations")
            {
                GameLocations gameLocations = new GameLocations();
                outputInfoBox.Text += "Created gameLocations Object\n";
            }
            else
            {
                MessageBox.Show("Object creation error");
            }
        }

        private void buttonGetWarnings_Click(object sender, EventArgs e)
        {
            // Adjacent caves
            string[] strings = textBoxNearbyCaves.Text.Split(',');
            int[] caves = new int[3] { 99, 99, 99 };
            int i = 0;
            foreach (string s in strings)
            {
                caves[i] = int.Parse(s);
                i++;
            }

            // Bats
            strings = textBoxBatLocs.Text.Split(',');
            int[] bats = new int[3] { 0, 0, 0 };
            i = 0;
            foreach (string s in strings)
            {
                bats[i] = int.Parse(s);
                i++;
            }

            // pits
            strings = textBoxPitLocs.Text.Split(',');
            int[] pits = new int[3] { 0, 0, 0 };
            i = 0;
            foreach (string s in strings)
            {
                pits[i] = int.Parse(s);
                i++;
            }

            //wumpus 
            int wumpus = int.Parse(textBoxWumpusLoc.Text);


            labelBats.Visible = gameLocations.findAdjacentHazards(caves, bats, pits, wumpus)[0];
            labelPits.Visible = gameLocations.findAdjacentHazards(caves, bats, pits, wumpus)[1];
            labelWumpus.Visible = gameLocations.findAdjacentHazards(caves, bats, pits, wumpus)[2];
        }

        private void buttonGetPlayerLocation_Click(object sender, EventArgs e)
        {
            player.MovePlayer(int.Parse(textBoxPlayerLocationInput.Text));
            textBoxPlayerCurrentLocation.Text = player.GetPlayerLocation().ToString();
        }

        private void textBoxInvModifyAmount_Click(object sender, EventArgs e)
        {
            textBoxInvModifyAmount.Clear();
            textBoxInvModifyAmount.ForeColor = Color.Black;
        }

        private void buttonGetInventory_Click(object sender, EventArgs e)
        {
            int[] inv = player.GetInventory();
            textBoxArrows.Text = inv[0].ToString();
            textBoxCoins.Text = inv[1].ToString();
        }

        private void buttonUpdateArrows_Click(object sender, EventArgs e)
        {
            player.UpdateArrowAmount(int.Parse(textBoxInvModifyAmount.Text));
        }

        private void buttonUpdateCoins_Click(object sender, EventArgs e)
        {
            player.UpdateCoinAmount(int.Parse(textBoxInvModifyAmount.Text));
        }
    }
}
