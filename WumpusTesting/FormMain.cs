using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WumpusTesting
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

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

        private void buttonCreateAllObjects_Click(object sender, EventArgs e)
        {
            Player player = new Player();
            outputInfoBox.Text += "Created player object\n";

            GameLocations gameLocations = new GameLocations();
            outputInfoBox.Text += "Created gameLocations Object\n";
        }

    }
}
