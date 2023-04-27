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
    public partial class Form1 : Form
    {
        private GraphicalInterface ui;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonConstructor_Click(object sender, EventArgs e)
        {
            ui = new GraphicalInterface();
        }
    }
}
