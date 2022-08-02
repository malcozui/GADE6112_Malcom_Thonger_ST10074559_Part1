using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GADE6112_Malcom_Thonger_ST10074559_Part1
{
    public partial class TheGameForm : Form
    {
        public TheGameForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var gameEngine = new GameEngine();
            gameLbl.Text = gameEngine.ToString();
        }
    }
}
